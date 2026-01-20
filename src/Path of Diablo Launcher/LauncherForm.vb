Imports System.ComponentModel
Imports System.Diagnostics
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Security.Policy
Imports System.Threading
Imports System.Timers
Imports Microsoft.Win32

Public Class LauncherForm

    Dim stopwatch As Stopwatch = New Stopwatch()

    Dim cmd As CommandLineOptions = New CommandLineOptions()

    Dim isUpdateClicked As Boolean = False

    Dim isPlayAvailable = False

    Dim playButtonCounter As Double = 0

    Public Function GetCRC32(ByVal sFileName As String) As String
        Try
            Dim FS As FileStream = New FileStream(sFileName, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
            Dim CRC32Result As Integer = &HFFFFFFFF
            Dim Buffer(4096) As Byte
            Dim ReadSize As Integer = 4096
            Dim Count As Integer = FS.Read(Buffer, 0, ReadSize)
            Dim CRC32Table(256) As Integer
            Dim DWPolynomial As Integer = &HEDB88320
            Dim DWCRC As Integer
            Dim i As Integer, j As Integer, n As Integer

            'Create CRC32 Table
            For i = 0 To 255
                DWCRC = i
                For j = 8 To 1 Step -1
                    If (DWCRC And 1) Then
                        DWCRC = ((DWCRC And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                        DWCRC = DWCRC Xor DWPolynomial
                    Else
                        DWCRC = ((DWCRC And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                    End If
                Next j
                CRC32Table(i) = DWCRC
            Next i

            'Calcualting CRC32 Hash
            Do While (Count > 0)
                For i = 0 To Count - 1
                    n = (CRC32Result And &HFF) Xor Buffer(i)
                    CRC32Result = ((CRC32Result And &HFFFFFF00) \ &H100) And &HFFFFFF
                    CRC32Result = CRC32Result Xor CRC32Table(n)
                Next i
                Count = FS.Read(Buffer, 0, ReadSize)
            Loop
            FS.Close()
            Return Hex(Not (CRC32Result)).PadLeft(8, "0"c)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Make registry entry for podlauncher:// protocol
        RegisterPodLauncherProtocol()
        TextBoxLootFilterURL.Text = My.MySettings.Default.stringLootLink
        TextBoxLootFilterURLTwo.Text = My.MySettings.Default.stringLootLinkTwo
        TextBoxLootFilterURLThree.Text = My.MySettings.Default.stringLootLinkThree
        SetText(LabelDownloadStatus, "")

        'check and create needed directories
        If Not My.Computer.FileSystem.DirectoryExists("./tmp") Then
            My.Computer.FileSystem.CreateDirectory("./tmp")
        End If
        If Not My.Computer.FileSystem.DirectoryExists("./config") Then
            My.Computer.FileSystem.CreateDirectory("./config")
        End If
        If Not My.Computer.FileSystem.DirectoryExists("./filter") Then
            My.Computer.FileSystem.CreateDirectory("./filter")
        End If
        If Not My.Computer.FileSystem.DirectoryExists("./Save") Then
            My.Computer.FileSystem.CreateDirectory("./Save")
        End If

        'clear "tmp" on load
        For Each file As String In My.Computer.FileSystem.GetFiles("./tmp/", FileIO.SearchOption.SearchAllSubDirectories, "*.*")
            Try
                My.Computer.FileSystem.DeleteFile(file, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            Catch ex As Exception
                'do nothing, just continue
            End Try
        Next

        cmd.ScanCommandLine(Environment.GetCommandLineArgs())

        Log("Welcome to the Path of Diablo Launcher v14")

        Dim args() As String = Environment.GetCommandLineArgs()
        ' DEBUG
        'MsgBox("Args count: " & args.Length & vbCrLf & String.Join(vbCrLf, args))
        Dim podUrl As String = Nothing
        For Each a As String In args
            If a.StartsWith("podlauncher://", StringComparison.OrdinalIgnoreCase) Then
                podUrl = a
                Exit For
            End If
        Next

        LootFilterSettingsPanel.Visible = True
        If podUrl IsNot Nothing Then
            Try
                Dim uri As New Uri(podUrl)
                Dim query = uri.Query
                If query.StartsWith("?url=", StringComparison.OrdinalIgnoreCase) Then
                    Dim filterUrl As String = Uri.UnescapeDataString(query.Substring(5))

                    LootFilterSettingsPanel.Visible = True
                    Dim targetBox As TextBox = Nothing
                    Dim targetSetting As String = Nothing

                    If String.IsNullOrWhiteSpace(My.MySettings.Default.stringLootLink) Then
                        targetBox = TextBoxLootFilterURL
                        targetSetting = "stringLootLink"
                    ElseIf String.IsNullOrWhiteSpace(My.MySettings.Default.stringLootLinkTwo) Then
                        targetBox = TextBoxLootFilterURLTwo
                        targetSetting = "stringLootLinkTwo"
                    ElseIf String.IsNullOrWhiteSpace(My.MySettings.Default.stringLootLinkThree) Then
                        targetBox = TextBoxLootFilterURLThree
                        targetSetting = "stringLootLinkThree"
                    Else
                        MsgBox("Too many subscriptions, please delete one!")
                    End If

                    If targetBox IsNot Nothing Then
                        ' Assign TextBox first
                        targetBox.Text = filterUrl
                        ' Assign the setting
                        Select Case targetSetting
                            Case "stringLootLink"
                                My.MySettings.Default.stringLootLink = filterUrl
                            Case "stringLootLinkTwo"
                                My.MySettings.Default.stringLootLinkTwo = filterUrl
                            Case "stringLootLinkThree"
                                My.MySettings.Default.stringLootLinkThree = filterUrl
                        End Select
                        ' Save immediately
                        My.MySettings.Default.Save()
                    End If
                End If
            Catch ex As Exception
                Log("Failed to parse Podlauncher URL: " & ex.Message)
            End Try
        End If
        ' OPTIONAL: auto-start download
        ' ButtonDownload.PerformClick()

        If Not CheckDependancies() Then
            Log("Missing MSVC 10 runtime, installing")
            InstallDependacies()
        End If

        If CheckParentInstallation() = 0 Then
            Exit Sub
        End If

        Dim thread As New Thread(AddressOf UpdaterThread)
        thread.IsBackground = True
        thread.Start()

    End Sub

    Private Sub playBtn_Click(sender As Object, e As EventArgs) Handles ButtonPlay.Click
        If Not isPlayAvailable Then
            Return
        End If

        With ButtonPlay
            .Enabled = False
            .Refresh()
        End With

        Dim d2 As New ProcessStartInfo

        d2.FileName = "PoD.exe"
        If Not File.Exists(d2.FileName) Then
            MsgBox("Unable to find: " & d2.FileName & ". Make sure your launcher is up-to-date.")
            Return
        End If

        If TextBoxLootFilterURL.Text.Equals("") Then
            My.MySettings.Default.stringLootLink = Me.TextBoxLootFilterURL.Text
        End If
        If TextBoxLootFilterURLTwo.Text.Equals("") Then
            My.MySettings.Default.stringLootLinkTwo = Me.TextBoxLootFilterURLTwo.Text
        End If
        If TextBoxLootFilterURLThree.Text.Equals("") Then
            My.MySettings.Default.stringLootLinkThree = Me.TextBoxLootFilterURLThree.Text
        End If

        Try
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers", My.Computer.FileSystem.CurrentDirectory & "\" & d2.FileName, "~ DisableNXShowUI RUNASADMIN")
        Catch ex As System.Security.SecurityException
            MsgBox("You don't have the required admin rights. Run the launcher as admin and try again!")
            Me.Close()
        Catch ex As Exception
            MsgBox("Unexpected registry error.")
            Me.Close()
        End Try

        'run D2 as administrator
        d2.Verb = "runas"
        d2.Arguments = If(cmd.Passthrough, cmd.PassthroughArgs, "")

        Const argWindowed As String = "-w"
        If radioGDI.Checked = True And d2.Arguments.IndexOf(argWindowed) = -1 Then
            d2.Arguments = d2.Arguments & argWindowed & " "
        End If

        Const argSkipToBnet As String = "-skiptobnet"
        If skipChk.Checked = True And d2.Arguments.IndexOf(argSkipToBnet) = -1 Then
            d2.Arguments = d2.Arguments & argSkipToBnet & " "
        End If

        Const argNoSound As String = "-ns"
        If nsChk.Checked = True And d2.Arguments.IndexOf(argNoSound) = -1 Then
            d2.Arguments = d2.Arguments & argNoSound & " "
        End If

        Const argGlide As String = "-3dfx"
        If radio3DFX.Checked = True And d2.Arguments.IndexOf(argGlide) = -1 Then
            d2.Arguments = d2.Arguments & argGlide & " "
        End If

        Const argDirect As String = "-direct"
        If directChk.Checked = True And d2.Arguments.IndexOf(argDirect) = -1 Then
            d2.Arguments = d2.Arguments & argDirect & " "
        End If

        Const argD2GL As String = "-d2gl"
        If radioD2GL.Checked = True And d2.Arguments.IndexOf(argD2GL) = -1 Then
            d2.Arguments = d2.Arguments & argGlide & " " & argD2GL & " "
        End If

        Const argNoFixAspect As String = "-nofixaspect"
        If aspectChk.Checked = True And d2.Arguments.IndexOf(argNoFixAspect) = -1 Then
            d2.Arguments = d2.Arguments & argNoFixAspect & " "
        End If

        Const argSndBkg As String = "-sndbkg"
        If sndbkgChk.Checked = True And d2.Arguments.IndexOf(argSndBkg) = -1 Then
            d2.Arguments = d2.Arguments & argSndBkg & " "
        End If

        Const argWideScreen As String = "-widescreen"
        If widescreenChk.Checked = True And d2.Arguments.IndexOf(argWideScreen) = -1 Then
            d2.Arguments = d2.Arguments & argWideScreen & " "
        End If

        Const argCpuFix As String = "-cpufix"
        If cpufixChk.Checked = True And d2.Arguments.IndexOf(argCpuFix) = -1 Then
            d2.Arguments = d2.Arguments & argCpuFix & " "
        End If

        Const argDdraw As String = "-ddraw"
        If radioDDraw.Checked = True And d2.Arguments.IndexOf(argDdraw) = -1 Then
            d2.Arguments = d2.Arguments & argDdraw & " "
        End If

        Const argPtr As String = "-ptr"
        If ptrChk.Enabled = True And ptrChk.Checked = True And d2.Arguments.IndexOf(argPtr) = -1 Then
            d2.Arguments = d2.Arguments & argPtr & " "
        End If

        Const argIdSound As String = "-idsound"
        If idsoundChk.Checked = True And d2.Arguments.IndexOf(argIdSound) = -1 Then
            d2.Arguments = d2.Arguments & argIdSound & " "
        End If

        Const argDSOAL As String = "-dsoal"
        If idsoundChk.Checked = True And d2.Arguments.IndexOf(argDSOAL) = -1 Then
            d2.Arguments = d2.Arguments & argDSOAL & " "
        End If

        Dim p As New Process
        p.StartInfo = d2
        p.Start()

        If CheckCloseOnPlay.Checked Then
            Me.Hide() 'hide window, so that it doesn't look like it doesn't respond anymore
            Me.Close()
        Else
            playButtonCounter = 0
            Dim playButtonTimer As Timers.Timer = New Timers.Timer(500)
            AddHandler playButtonTimer.Elapsed, Sub(timer, timerEvent) AllowPlayButtonAfterDelay(timer, timerEvent, p)
            playButtonTimer.AutoReset = True
            playButtonTimer.Start()
        End If
    End Sub

    Private Sub AllowPlayButtonAfterDelay(sourceTimer As Timers.Timer, e As ElapsedEventArgs, p As Process)
        If p.HasExited Or playButtonCounter >= 3000 Then
            With ButtonPlay
                .Enabled = True
                .Refresh()
            End With

            sourceTimer.Stop()
        Else
            playButtonCounter += sourceTimer.Interval
        End If
    End Sub

    'Private Sub DEP_Only_Click(sender As Object, e As EventArgs)
    '    Try
    '        Dim wDEP As New StreamWriter("000aaaDEP.bat")
    '        wDEP.WriteLine("@ECHO OFF")
    '        wDEP.WriteLine("ECHO %~dp0")
    '        wDEP.WriteLine("set ""mypath=%~dp0%Diablo II.exe""")
    '        wDEP.WriteLine("ECHO %mypath%")
    '        wDEP.WriteLine("ECHO Enabling DEP exception")
    '        wDEP.WriteLine("call bcdedit.exe /set {current} nx OptOut && color 0A && echo DEP policy changed to allow exceptions || color 0C && echo RUN AS ADMIN")
    '        wDEP.WriteLine("call REG ADD ""HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers"" /t REG_SZ /d ""~ DisableNXShowUI"" /f /v ""%mypath% ")
    '        wDEP.WriteLine("PAUSE")
    '        wDEP.WriteLine("EXIT")
    '        wDEP.Close()
    '        MsgBox("When you click OK you will be sent to your Diablo II folder" & vbCrLf & vbCrLf & "Right click on 000aaaDEP.bat and run as admin, the text should come out green, a restart might be required")
    '        Process.Start(".")
    '    Catch ex As Exception
    '        MsgBox("Error generating fix file, it's probably open")
    '    End Try

    'End Sub

    'Private Sub DEP_and_XP_SP2_Click(sender As Object, e As EventArgs)
    '    Try
    '        Dim wDEP As New StreamWriter("000aaaDEP+XP_SP2.bat")
    '        wDEP.WriteLine("@ECHO OFF")
    '        wDEP.WriteLine("ECHO %~dp0")
    '        wDEP.WriteLine("set ""mypath=%~dp0%Diablo II.exe""")
    '        wDEP.WriteLine("ECHO %mypath%")
    '        wDEP.WriteLine("ECHO Enabling DEP exception")
    '        wDEP.WriteLine("call bcdedit.exe /set {current} nx OptOut && color 0A && echo DEP policy changed to allow exceptions || color 0C && echo RUN AS ADMIN")
    '        wDEP.WriteLine("call REG ADD ""HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers"" /t REG_SZ /d ""~ RUNASADMIN WINXPSP2 DisableNXShowUI"" /f /v ""%mypath% ")
    '        wDEP.WriteLine("PAUSE")
    '        wDEP.WriteLine("EXIT")
    '        wDEP.Close()
    '        MsgBox("When you click OK you will be sent to your Diablo II folder" & vbCrLf & vbCrLf & "Right click on 000aaaDEP+XP_SP2.bat and run as admin, the text should come out green, a restart might be required")
    '        Process.Start(".")
    '    Catch ex As Exception
    '        MsgBox("Error generating fix file, it's probably open")
    '    End Try

    'End Sub

    Private Sub VideoMode_Changed(sender As Object, e As EventArgs) Handles radio3DFX.CheckedChanged, radioDDraw.CheckedChanged, radioGDI.CheckedChanged, radioVidTest.CheckedChanged, radioD2GL.CheckedChanged
        My.MySettings.Default.chkboxW = False
        My.MySettings.Default.chkboxVidTest = False
        My.MySettings.Default.chkboxDdraw = False
        My.MySettings.Default.chkbox3dfx = False
        My.MySettings.Default.chkboxD2GL = False
        If (radioGDI.Checked) Then My.MySettings.Default.chkboxW = True
        If (radioVidTest.Checked) Then My.MySettings.Default.chkboxVidTest = True
        If (radioDDraw.Checked) Then My.MySettings.Default.chkboxDdraw = True
        If (radio3DFX.Checked) Then My.MySettings.Default.chkbox3dfx = True
        If (radioD2GL.Checked) Then My.MySettings.Default.chkboxD2GL = True
    End Sub

    Private Sub dfxConfigButton_Click(sender As Object, e As EventArgs) Handles ButtonGlideConfig.Click
        Dim glideInit As New ProcessStartInfo
        glideInit.FileName = "glide-init.exe"
        glideInit.Verb = "runas" 'run as administrator
        Dim p As New Process
        p.StartInfo = glideInit
        Try
            p.Start()
        Catch ex As Exception
            MessageBox.Show("Unable to run glide-init.exe", "Path of Diablo Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Banner_Click(sender As Object, e As EventArgs) Handles LauncherBanner.Click
        Process.Start("https://beta.pathofdiablo.com/")
    End Sub

    Private Sub Donate_Click(sender As Object, e As EventArgs) Handles ButtonDonate.Click
        Process.Start("https://pathofdiablo.com/donate")
    End Sub

    Private Sub Reddit_Click(sender As Object, e As EventArgs) Handles ButtonReddit.Click
        Process.Start("https://www.reddit.com/r/pathofdiablo")
    End Sub

    Private Sub Wiki_Click(sender As Object, e As EventArgs) Handles ButtonWiki.Click
        Process.Start("https://pathofdiablo.com/wiki")
    End Sub

    Private Sub Rules_Click(sender As Object, e As EventArgs) Handles ButtonRules.Click
        Process.Start("https://pathofdiablo.com/rules")
    End Sub

    Private Sub ServerList_Click(sender As Object, e As EventArgs) Handles ButtonServerList.Click
        Process.Start("https://pathofdiablo.com/servers")
    End Sub
    Private Sub Discord_Click(sender As Object, e As EventArgs) Handles ButtonDiscord.Click
        Process.Start("https://discordapp.com/invite/0cUlOSBTPbtjahc5")
    End Sub

    Private Sub SelectFilter_Click(sender As Object, e As EventArgs) Handles ButtonSelectFilter.Click
        Process.Start("https://pathofdiablo.com/filters")
    End Sub

    Private Sub WebBrowserNews_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowserNews.Navigating

        ' Allow the initial embedded page
        If e.Url.AbsoluteUri = "https://beta.pathofdiablo.com/launcher-embed" Then
            Exit Sub
        End If

        ' Stop IE navigation
        e.Cancel = True

        ' Open link in default browser
        Process.Start(New ProcessStartInfo With {
        .FileName = e.Url.AbsoluteUri,
        .UseShellExecute = True
    })

    End Sub

    Private Sub WebBrowserNews_NewWindow(sender As Object, e As ComponentModel.CancelEventArgs) Handles WebBrowserNews.NewWindow

        ' Cancel IE opening a new window
        e.Cancel = True

        ' Get the URL IE wanted to open
        Dim url As String = WebBrowserNews.StatusText

        If Not String.IsNullOrEmpty(url) Then
            Process.Start(New ProcessStartInfo With {
            .FileName = url,
            .UseShellExecute = True
        })
        End If
    End Sub
    Private Sub dDownloadFilter_Click(sender As Object, e As EventArgs) Handles ButtonDownloadFilter.Click
        Dim urls() As String = {
            TextBoxLootFilterURL.Text,
            TextBoxLootFilterURLTwo.Text,
            TextBoxLootFilterURLThree.Text
        }
        isUpdateClicked = True

        Dim thread As New Thread(Sub() LootFilterDownloaderThread(urls))
        thread.IsBackground = True
        thread.Start()
    End Sub

    Private Async Sub LootFilterDownloaderThread(urls() As String)
        'If lootfiltername.Text.Equals("") Then
        '    Log("Please give the loot filter to be downloaded a name.")
        '    Exit Sub
        'End If
        Invoke(Sub()
                   Log("AUTO-UPDATE URLS = " &
        "[" & TextBoxLootFilterURL.Text & "] [" &
        TextBoxLootFilterURLTwo.Text & "] [" &
        TextBoxLootFilterURLThree.Text & "]")
               End Sub)
        If urls.All(Function(s) String.IsNullOrEmpty(s)) Then
            Invoke(Sub()
                       Log("Please enter a url where the loot filter will be downloaded from.")
                   End Sub)
            Exit Sub
        End If

        'SetEnabled(playBtn, False)
        Invoke(Sub()
                   SetEnabled(ButtonDownloadFilter, False)
                   isPlayAvailable = False
               End Sub)

        Dim dl As WebClient = New WebClient()

        For i As Integer = 0 To urls.Length - 1
            Dim url As String = urls(i)

            If String.IsNullOrWhiteSpace(url) Then
                Continue For
            End If

            Dim filterName As String = ""
            Try
                Dim parts As String() = url.Split("/"c)
                filterName = parts(parts.Length - 1)

                Invoke(Sub() Log("Downloading " & filterName & " from " & url))
                Await (dl.DownloadFileTaskAsync(url, "./filter/" & filterName))
                Invoke(Sub() Log("Successfully downloaded loot filter " & filterName & " from " & url))

                If isUpdateClicked Then
                    Invoke(Sub() Log("Custom filter installed. You must enable 'custom filter' in-game via Settings button to activate it."))
                End If
                'Save the last downloaded URL based on index
                Invoke(Sub()
                           Select Case i
                               Case 0
                                   Global.Path_of_Diablo_Launcher.My.MySettings.Default.stringLootLink = url
                               Case 1
                                   Global.Path_of_Diablo_Launcher.My.MySettings.Default.stringLootLinkTwo = url
                               Case 2
                                   Global.Path_of_Diablo_Launcher.My.MySettings.Default.stringLootLinkThree = url
                           End Select
                       End Sub)
            Catch ex As Exception
                Invoke(Sub()
                           Log("An error occured while downloading loot filter " & filterName & " from " & url)
                       End Sub)
            End Try
        Next
        'If File.Exists("./filter" & tmp(tmp.Count - 1)) Then
        'Log("Custom filter installed. You must enable 'custom filter' in-game via Settings button to activate it.")
        'MsgBox("Custom filter installed. You must enable 'custom filter' in-game via Settings button to activate it.")
        'Exit Sub
        'End If
        My.MySettings.Default.Save()
        'TODO zip file handling for filters with custom sounds
        'Dim url As String = TextBoxLootFilterURL.Text

        'SetEnabled(playBtn, True)
        Invoke(Sub()
                   SetEnabled(ButtonDownloadFilter, True)
                   isPlayAvailable = True
               End Sub)
    End Sub

    Delegate Sub SetEnabledDelegate(ByVal ctrl As Control, ByVal bool As Boolean)
    Private Sub SetEnabled(ByVal ctrl As Control, ByVal bool As Boolean)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New SetEnabledDelegate(AddressOf SetEnabled), {ctrl, bool})
            Return
        End If
        ctrl.Enabled = bool
    End Sub

    Delegate Sub SetTextDelegate(ByVal ctrl As Control, ByVal text As String)
    Private Sub SetText(ByVal ctrl As Control, ByVal text As String)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New SetTextDelegate(AddressOf SetText), {ctrl, text})
            Return
        End If
        ctrl.Text = text
    End Sub

    Delegate Sub SetColorDelegate(ByVal ctrl As Control, ByVal col As Color)
    Private Sub SetColor(ByVal ctrl As Control, ByVal col As Color)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New SetColorDelegate(AddressOf SetColor), {ctrl, col})
            Return
        End If
        ctrl.ForeColor = col
    End Sub

    Delegate Sub SetCursorDelegate(ByVal ctrl As Control, ByVal cursor As Cursor)
    Private Sub SetCursor(ByVal ctrl As Control, ByVal cursor As Cursor)
        If ctrl.InvokeRequired Then
            ctrl.Invoke(New SetCursorDelegate(AddressOf SetCursor), {ctrl, cursor})
            Return
        End If
        ctrl.Cursor = cursor
    End Sub

    Delegate Sub LogDelegate(ByVal text As String)
    Public Sub Log(ByVal text As String)
        If LogBoxEventLog.InvokeRequired Then
            LogBoxEventLog.Invoke(New LogDelegate(AddressOf Log), {text})
            Return
        End If
        Dim newText As String = "[" & TimeOfDay.ToString("HH:mm:ss") & "] " & text
        LogBoxEventLog.Items.Add(newText)
        'highlight last added item
        LogBoxEventLog.SelectedIndex = LogBoxEventLog.Items.Count - 1
        'LogBox.ClearSelected()
    End Sub

    Delegate Sub SetProgressDelegate(ByVal progress As Integer)
    Private Sub SetProgress(ByVal progress As Integer)
        If ProgressBarDownload.InvokeRequired Then
            ProgressBarDownload.Invoke(New SetProgressDelegate(AddressOf SetProgress), {progress})
            Return
        End If
        Try
            ProgressBarDownload.Value = progress
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Downloads_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        SetText(LabelDownloadStatus, String.Format("Downloading at {0} kb/s", (e.BytesReceived / 1024D / stopwatch.Elapsed.TotalSeconds).ToString("0.00")))

        SetProgress(Int32.Parse(Math.Truncate(percentage).ToString()))
    End Sub

    Private Sub Downloads_DownloadCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        SetProgress(0)
        stopwatch.Reset()
        SetText(LabelDownloadStatus, "Complete!")
        SyncLock e.UserState
            'release block
            Monitor.Pulse(e.UserState)
        End SyncLock
    End Sub

    Private Sub UpdaterThread()
        Invoke(Sub()
                   Log("DEBUG AutoUpdate checkbox = " & CheckAutoUpdateFilter.Checked)
               End Sub)
        'Allow additional ssl connection protocols
        Try
            ServicePointManager.SecurityProtocol += SecurityProtocolType.Tls11
            ServicePointManager.SecurityProtocol += SecurityProtocolType.Tls12
            ServicePointManager.SecurityProtocol += 12288 'Tls 1.3 not available in the SecurityProtocolType enum
        Catch ex As Exception
            'Attempt to continue if protocol not available
        End Try

        'SetEnabled(playBtn, False)
        SetEnabled(ButtonDownloadFilter, False)
        isPlayAvailable = False
        SetText(ButtonPlay, "Updating...")
        SetCursor(ButtonPlay, Cursors.WaitCursor)
        SetColor(ButtonPlay, Color.LightGreen)
        Log("Searching for updates...")

        If Not cmd.NoUpdate Then

            Dim p1() As Process = Process.GetProcessesByName("pod")
            If p1.Count > 0 Then
                MsgBox("PoD.exe is running, press ok to close this process and continue.")
                p1(0).Kill()
            End If

            Dim file As String = "./tmp/files.xml"

            Dim xmlLink As String = "https://raw.githubusercontent.com/GreenDude120/PoD-Launcher/master/files.xml"
            'Dim xmlLink As String = "https://raw.githubusercontent.com/vileskin/PoD-Launcher/refs/heads/main/files.xml"
            Dim xmlLinkFallback As String = "https://d2.lc/files.xml"
            Dim dl As WebClient = New WebClient()
            Try
                dl.DownloadFile(xmlLink, file)
            Catch ex As WebException
                'Use fallback url if github is down or client doesn't support tls 1.2
                Log("Using fallback files.xml")
                Try
                    dl.DownloadFile(xmlLinkFallback, file)
                Catch ex2 As WebException
                    isPlayAvailable = False

                    SetText(ButtonPlay, "Error!")
                    SetCursor(ButtonPlay, Cursors.No)
                    SetColor(ButtonPlay, Color.Red)
                    If ex2.Status = WebExceptionStatus.ProtocolError Then
                        Dim res As HttpWebResponse = ex2.Response
                        Log("An error occurred checking for updates. HTTP error: " & res.StatusCode & " " & res.StatusDescription)
                    Else
                        Log("An error occurred checking for updates. WebExceptionStatus: " & ex2.Status.ToString())
                    End If
                    Exit Sub
                End Try
            Catch ex As Exception
                isPlayAvailable = False

                SetText(ButtonPlay, "Error!")
                SetCursor(ButtonPlay, Cursors.No)
                SetColor(ButtonPlay, Color.Red)
                Log("An unexpected error occurred checking for updates. Please try again later.")
                Exit Sub
            End Try

            Dim reader As Xml.XmlTextReader = New Xml.XmlTextReader(file)

            Dim restartRequired As Boolean = False

            Dim files As LinkedList(Of DownloadItem) = New LinkedList(Of DownloadItem)

            Do While reader.Read()
                Select Case reader.NodeType
                    Case Xml.XmlNodeType.Element

                        If reader.Name.Equals("file") Then

                            Dim dlme As DownloadItem = New DownloadItem

                            'read attributes
                            If reader.AttributeCount > 0 Then
                                While reader.MoveToNextAttribute
                                    If reader.Name.Equals("name") Then
                                        dlme.Name = reader.Value
                                    ElseIf reader.Name.Equals("crc") Then
                                        dlme.Crc = reader.Value
                                    ElseIf reader.Name.Equals("restartRequired") Then
                                        If reader.Value.Equals("true") Then
                                            dlme.RestartRequired = True
                                        End If
                                    ElseIf reader.Name.Equals("showDialog") Then
                                        If reader.Value.Equals("true") Then
                                            dlme.ShowDialog = True
                                        End If
                                    ElseIf reader.Name.Equals("path") Then
                                        dlme.Path = reader.Value
                                    ElseIf reader.Name.Equals("unzip") Then
                                        If reader.Value.Equals("true") Then
                                            dlme.Unzip = True
                                        End If
                                    End If
                                End While
                            End If

                            'read links (reads until end of 
                            While reader.Read()
                                Select Case reader.NodeType
                                    Case Xml.XmlNodeType.Element

                                        Dim link As NamedLink = New NamedLink
                                        'read attributes
                                        If reader.AttributeCount > 0 Then
                                            While reader.MoveToNextAttribute
                                                If reader.Name.Equals("name") Then
                                                    link.Name = reader.Value
                                                End If
                                            End While

                                            reader.MoveToContent()
                                        End If

                                        link.Link = reader.ReadInnerXml()
                                        dlme.AddLink(link)

                                    Case Xml.XmlNodeType.EndElement

                                        If reader.Name.Equals("file") Then
                                            files.AddLast(dlme)
                                            Exit While
                                        End If

                                End Select
                            End While

                        End If

                End Select
            Loop

            reader.Close()

            For Each dlme As DownloadItem In files
                Dim i As Integer = DownloadFile(dlme)
                If i = 1 Then
                    restartRequired = True
                ElseIf i = -1 Then
                    'problem detected, just exit. there should be something in the logs
                    Exit Sub
                End If
            Next

            Log("Finished checking " & files.Count & " file(s) for updates")

            'restart if needed
            If restartRequired Then
                MsgBox("An updated file requires the Launcher to restart to function correctly. Restarting Now!")
                Application.Restart()
            End If
        Else
            Log("Updates disabled!")
        End If

        If My.Settings.chkboxAutoUpdate Then
            Dim urls() As String = {
                My.MySettings.Default.stringLootLink,
                My.MySettings.Default.stringLootLinkTwo,
                My.MySettings.Default.stringLootLinkThree
            }

            Dim thread As New Thread(Sub() LootFilterDownloaderThread(urls))
            thread.IsBackground = True
            isUpdateClicked = False
            thread.Start()
        End If

        isPlayAvailable = True

        SetText(ButtonPlay, "Play")
        SetCursor(ButtonPlay, Cursors.Hand)
        SetColor(ButtonPlay, Color.LawnGreen)
        'SetEnabled(playBtn, True)
        SetEnabled(ButtonDownloadFilter, True)

        If cmd.StartOnUpdateSuccess Then
            ButtonPlay.PerformClick()
        End If

    End Sub

    Private Function DownloadFile(ByRef file As DownloadItem) As Integer

        Dim uptodate As Boolean = False
        Dim fullpath As String = Path.Combine(file.Path, file.Name)
        'crc = "" -> only check if file exists, don't actually check the crc
        If file.Crc.Equals("") Then
            If IO.File.Exists(fullpath) Then
                Log("File " & file.Name & " already exists, no need to download again.")
                uptodate = True
            Else
                file.Crc = "-1"
            End If
        End If

        'no need to update if file has same crc as the servers file
        Dim localCrc As String = GetCRC32(fullpath)
        If file.Crc.Equals(localCrc) And Not uptodate Then
            Log("File " & file.Name & " is up-to-date")
            Return 0
        End If

        If Not uptodate Then
            If IO.File.Exists(fullpath) Then
                Try
                    IO.File.Move(file.Name, Path.Combine(Environment.CurrentDirectory, "tmp", file.Path, file.Name))
                Catch ex As Exception
                End Try
            ElseIf Not String.IsNullOrEmpty(file.Path) Then
                Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, file.Path))
            End If

            For Each link As NamedLink In file.Links
                If file.ShowDialog Then
                    LinkChooser.Links.Items.Clear()

                    For Each l As NamedLink In file.Links
                        If Not l.Name Is Nothing Then
                            LinkChooser.Links.Items.Add(l.Name)
                        Else
                            LinkChooser.Links.Items.Add(l.Link)
                        End If
                    Next

                    LinkChooser.Links.SelectedIndex = 0

                    LinkChooser.ShowDialog()

                    link = file.Links.ElementAt(LinkChooser.Links.SelectedIndex)
                End If

                Log("Downloading file " & file.Name & " from " & link.Link)
                'Console.WriteLine("Downloading file " & file.Name & " from " & link.Link)

                Dim dl As WebClient = New WebClient()
                AddHandler dl.DownloadProgressChanged, AddressOf Downloads_ProgressChanged
                AddHandler dl.DownloadFileCompleted, AddressOf Downloads_DownloadCompleted

                Try
                    Dim myLock As Object = New Object()
                    SyncLock myLock
                        stopwatch.Start()
                        dl.DownloadFileAsync(New Uri(link.Link), fullpath, myLock)
                        Monitor.Wait(myLock)
                    End SyncLock
                Catch ex As Exception
                    Log("An error occured while downloading file " & file.Name & " from " & link.Link)
                    Continue For
                End Try

                Log("Successfully downloaded file " & file.Name & " from " & link.Link)

                localCrc = GetCRC32(fullpath)
                If Not file.Crc.Equals("-1") And Not file.Crc.Equals(localCrc) Then
                    Log("Checksum of downloaded file (" & file.Name & ") from " & link.Link & " doesn't match the specified checksum.")
                    Continue For
                ElseIf file.Unzip Then
                    Try
                        ZipFile.ExtractToDirectory(fullpath, Environment.CurrentDirectory)
                    Catch ex As Exception
                        Log("Failed to extract archive (" & file.Name & ")")
                    End Try
                End If

                uptodate = True
                Exit For
            Next

        End If

        If Not uptodate Then
            Log("An error occured while updating file " & file.Name & ". Please restart and try again.")
            Return -1
        End If

        If file.RestartRequired Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Declare Function FreeLibrary Lib "kernel32" (ByVal hLibModule As Long) As Long
    Private Declare Function LoadLibrary Lib "kernel32" Alias "LoadLibraryA" (ByVal lpLibFileName As String) As Long

    Private Function CheckDependancies() As Boolean
        If Not My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\10.0\VC\VCRedist\x86", "Installed", Nothing) Is Nothing Then
            Dim installed = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\10.0\VC\VCRedist\x86", "Installed", 0)
            If installed = 1 Then
                Return True
            Else
                Return False
            End If
        End If

        Dim msvcr100 = LoadLibrary("msvcr100")
        If msvcr100 = 0 Then
            Return False
        End If

        FreeLibrary(msvcr100)
        Return True
    End Function

    Private Sub InstallDependacies()
        Dim file As String = "./tmp/vcredist_x86.exe"

        If Not IO.File.Exists(file) Then
            Dim redistLink As String = "https://raw.githubusercontent.com/GreenDude120/PoD-Launcher/master/vcredist_x86.exe"
            Dim redistLinkFallback As String = "https://d2.lc/vcredist_x86.exe"
            Dim dl As WebClient = New WebClient()

            Try
                dl.DownloadFile(redistLink, file)
            Catch ex As WebException
                'Use fallback url if github is down or client doesn't support tls 1.2
                Log("Using fallback vcredist_x86.exe")
                Try
                    dl.DownloadFile(redistLinkFallback, file)
                Catch ex2 As WebException
                    isPlayAvailable = False

                    SetText(ButtonPlay, "Error!")
                    SetCursor(ButtonPlay, Cursors.No)
                    SetColor(ButtonPlay, Color.Red)
                    If ex2.Status = WebExceptionStatus.ProtocolError Then
                        Dim res As HttpWebResponse = ex2.Response
                        Log("An error occurred downloading dependancies. HTTP error: " & res.StatusCode & " " & res.StatusDescription)
                    Else
                        Log("An error occurred checking for updates. WebExceptionStatus: " & ex2.Status.ToString())
                    End If
                    Exit Sub
                End Try
            Catch ex As Exception
                Log("An unexpected error occurred downloading dependancies. Please try again later.")
                Exit Sub
            End Try
        End If

        Log("Installing MSVC 10 redistributable")

        Dim ProcessProperties As New ProcessStartInfo
        ProcessProperties.FileName = file
        ProcessProperties.Arguments = "/quiet /norestart"
        ProcessProperties.WindowStyle = ProcessWindowStyle.Hidden
        Dim redistProcess As Process = Process.Start(ProcessProperties)
        redistProcess.WaitForExit()

        Log("Installation complete!")
    End Sub

    Private Function CheckParentInstallation() As Integer
        isPlayAvailable = False

        'SetEnabled(playBtn, False)
        SetEnabled(ButtonDownloadFilter, False)
        SetText(ButtonPlay, "Checking...")
        SetCursor(ButtonPlay, Cursors.WaitCursor)
        SetColor(ButtonPlay, Color.LightGreen)
        Log("Checking Installation...")

        'Dim files As String() = New String() {
        '    "d2char.mpq",
        '    "d2data.mpq",
        '    "d2exp.mpq",
        '    "d2music.mpq",
        '    "d2sfx.mpq",
        '    "d2speech.mpq",
        '    "d2video.mpq",
        '    "d2xmusic.mpq", required cinematics? shouldnt check for it
        '    "d2xtalk.mpq",
        '}
        Dim files As String() = New String() {
            "d2char.mpq",
            "d2data.mpq",
            "d2exp.mpq",
            "d2music.mpq",
            "d2sfx.mpq",
            "d2speech.mpq"
        }

        For Each f In files
            If Not IO.File.Exists("..\\" & f) Then
                isPlayAvailable = False

                SetText(ButtonPlay, "FAILED")
                SetCursor(ButtonPlay, Cursors.No)
                SetColor(ButtonPlay, Color.Red)

                Log("Can't find Diablo II installation in the parent (previous) folder.")
                Log("Reinstall PoD but make sure to select your Diablo II installation path during the PoD installation process.")
                Return 0
            End If
        Next

        Log("Parent Installation verified correctly.")
        Return 1

    End Function

    Private Sub Form_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'clear "tmp" on exit
        For Each file As String In My.Computer.FileSystem.GetFiles("./tmp/", FileIO.SearchOption.SearchAllSubDirectories, "*.*")
            Try
                My.Computer.FileSystem.DeleteFile(file, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            Catch ex As Exception
                'do nothing, just continue
            End Try
        Next
        My.MySettings.Default.stringLootLink = TextBoxLootFilterURL.Text
        My.MySettings.Default.stringLootLinkTwo = TextBoxLootFilterURLTwo.Text
        My.MySettings.Default.stringLootLinkThree = TextBoxLootFilterURLThree.Text

        ' Persist settings to disk
        My.MySettings.Default.Save()
    End Sub

    Private Sub dsoalChk_CheckedChanged(sender As Object, e As EventArgs) Handles dsoalChk.CheckedChanged
        If dsoalChk.Checked And idsoundChk.Checked Then
            idsoundChk.Checked = False
            dsoalChk.Checked = True
        End If
    End Sub

    Private Sub idsoundChk_CheckedChanged(sender As Object, e As EventArgs) Handles idsoundChk.CheckedChanged
        If idsoundChk.Checked And dsoalChk.Checked Then
            dsoalChk.Checked = False
            idsoundChk.Checked = True
        End If
    End Sub

    Private Sub ButtonDDrawConfig_Click(sender As Object, e As EventArgs) Handles ButtonDDrawConfig.Click
        Dim ddrawIni As New ProcessStartInfo
        ddrawIni.FileName = "notepad.exe"
        ddrawIni.Arguments = "ddraw.ini"
        ddrawIni.UseShellExecute = True
        ddrawIni.Verb = "runas" 'run as administrator
        Dim p As New Process
        p.StartInfo = ddrawIni
        Try
            p.Start()
        Catch ex As Exception
            MessageBox.Show("Unable to open ddraw.ini", "Path of Diablo Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonD2VidTestConfig_Click(sender As Object, e As EventArgs) Handles ButtonD2VidTestConfig.Click
        Dim ddrawIni As New ProcessStartInfo
        ddrawIni.FileName = "D2VidTest.exe"
        ddrawIni.Arguments = ""
        ddrawIni.UseShellExecute = True
        ddrawIni.Verb = "runas" 'run as administrator
        Dim p As New Process
        p.StartInfo = ddrawIni
        Try
            p.Start()
        Catch ex As Exception
            MessageBox.Show("Unable to open D2VidTest", "Path of Diablo Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ptrChk_CheckedChanged(sender As Object, e As EventArgs) Handles ptrChk.CheckedChanged

    End Sub

    Private Sub LootFilerButton_Click(sender As Object, e As EventArgs) Handles LootFilterButton.Click
        LootFilterSettingsPanel.Visible = True
    End Sub

    Private Sub LootFilterSettingsPanel_Paint(sender As Object, e As PaintEventArgs) Handles LootFilterSettingsPanel.Paint

    End Sub
    Private Sub LootFilerSettingsCloseButton_Click(sender As Object, e As EventArgs) Handles LootFilerSettingsCloseButton.Click
        My.MySettings.Default.stringLootLink = Me.TextBoxLootFilterURL.Text
        My.MySettings.Default.stringLootLinkTwo = Me.TextBoxLootFilterURLTwo.Text
        My.MySettings.Default.stringLootLinkThree = Me.TextBoxLootFilterURLThree.Text
        My.MySettings.Default.Save()
        LootFilterSettingsPanel.Visible = False

    End Sub

    Private Sub ButtonDeleteFilterOne_Click(sender As Object, e As EventArgs) Handles ButtonDeleteFilterOne.Click

        Dim url As String = My.MySettings.Default.stringLootLink
        If String.IsNullOrWhiteSpace(url) Then Return

        Dim fileName As String = System.IO.Path.GetFileName(url)
        Dim filePath As String = System.IO.Path.Combine(Application.StartupPath, "filter", fileName)

        If System.IO.File.Exists(filePath) Then
            Try
                System.IO.File.Delete(filePath)
                MessageBox.Show($"{fileName} deleted successfully.")
            Catch ex As Exception
                MessageBox.Show($"Error deleting {fileName}: {ex.Message}")
            End Try
        End If

        ' Clear the setting and textbox
        My.MySettings.Default.stringLootLink = ""
        TextBoxLootFilterURL.Text = ""
        My.MySettings.Default.Save()
    End Sub

    Private Sub ButtonDeleteFilterTwo_Click(sender As Object, e As EventArgs) Handles ButtonDeleteFilterTwo.Click
        Dim url As String = My.MySettings.Default.stringLootLinkTwo
        If String.IsNullOrWhiteSpace(url) Then Return

        Dim fileName As String = System.IO.Path.GetFileName(url)
        Dim filePath As String = System.IO.Path.Combine(Application.StartupPath, "filter", fileName)

        If System.IO.File.Exists(filePath) Then
            Try
                System.IO.File.Delete(filePath)
                MessageBox.Show($"{fileName} deleted successfully.")
            Catch ex As Exception
                MessageBox.Show($"Error deleting {fileName}: {ex.Message}")
            End Try
        End If

        ' Clear the setting and textbox
        My.MySettings.Default.stringLootLinkTwo = ""
        TextBoxLootFilterURLTwo.Text = ""
        My.MySettings.Default.Save()
    End Sub

    Private Sub ButtonDeleteFilterThree_Click(sender As Object, e As EventArgs) Handles ButtonDeleteFilterThree.Click
        Dim url As String = My.MySettings.Default.stringLootLinkThree
        If String.IsNullOrWhiteSpace(url) Then Return

        Dim fileName As String = System.IO.Path.GetFileName(url)
        Dim filePath As String = System.IO.Path.Combine(Application.StartupPath, "filter", fileName)

        If System.IO.File.Exists(filePath) Then
            Try
                System.IO.File.Delete(filePath)
                MessageBox.Show($"{fileName} deleted successfully.")
            Catch ex As Exception
                MessageBox.Show($"Error deleting {fileName}: {ex.Message}")
            End Try
        End If

        ' Clear the setting and textbox
        My.MySettings.Default.stringLootLinkThree = ""
        TextBoxLootFilterURLThree.Text = ""
        My.MySettings.Default.Save()
    End Sub

    Sub RegisterPodLauncherProtocol()
        Try
            ' Open HKEY_CLASSES_ROOT (requires admin rights for some cases)
            Using key As RegistryKey = Registry.ClassesRoot.OpenSubKey("podlauncher")
                If key IsNot Nothing Then
                    ' Already exists, nothing to do
                    Return
                End If
            End Using

            ' Create the registry tree
            Using podKey As RegistryKey = Registry.ClassesRoot.CreateSubKey("podlauncher")
                podKey.SetValue("", "URL:PodLauncher Protocol")
                podKey.SetValue("URL Protocol", "") ' value must exist but empty

                ' shell\open\command
                Using shellKey As RegistryKey = podKey.CreateSubKey("shell")
                    Using openKey As RegistryKey = shellKey.CreateSubKey("open")
                        Using commandKey As RegistryKey = openKey.CreateSubKey("command")
                            ' %1 passes the URL to your app
                            commandKey.SetValue("", """" & Application.ExecutablePath & """ ""%1""")
                        End Using
                    End Using
                End Using
            End Using

            MessageBox.Show("PodLauncher protocol registered successfully!")

        Catch ex As Exception
            MessageBox.Show("Failed to register PodLauncher protocol: " & ex.Message)
        End Try
    End Sub
End Class
Imports System.IO
Imports System.Net
Imports System.Threading
Imports System.Timers
Imports System.Diagnostics
Imports System.ComponentModel

Public Class Form1

    Dim stopwatch As Stopwatch = New Stopwatch()

    Dim cmd As CommandLineOptions = New CommandLineOptions()

    Dim isUpdateClicked As Boolean = False

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
            Return Hex(Not (CRC32Result))
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        'show/hide advanced options
        If advancedChk.Checked Then
            directcbox.Visible = True
        Else
            directcbox.Visible = False
        End If

        cmd.ScanCommandLine(Environment.GetCommandLineArgs())

        Log("Welcome to the Path of Diablo Launcher v12")

        If CheckParentInstallation() = 0 Then
            Exit Sub
        End If

        Dim thread As New Thread(AddressOf UpdaterThread)
        thread.IsBackground = True
        thread.Start()

    End Sub

    Private Sub playBtn_Click(sender As Object, e As EventArgs) Handles playBtn.Click
        With playBtn
            .Enabled = False
            .Refresh()
        End With

        Dim d2 As New ProcessStartInfo

        d2.FileName = "Game.exe"
        Global.Path_of_Diablo_Launcher.My.MySettings.Default.stringLootLink = Me.lootfilterurl.Text
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

        If cmd.Passthrough Then
            d2.Arguments = cmd.PassthroughArgs
        Else
            d2.Arguments = ""
        End If

        Const argWindowed As String = "-w"
        If d3dChk.Checked = True AndAlso wChk.Checked = True And d2.Arguments.IndexOf(argWindowed) = -1 Then
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
        If dfxChk.Checked = True And d2.Arguments.IndexOf(argGlide) = -1 Then
            d2.Arguments = d2.Arguments & argGlide & " "
        End If

        Const argDirect As String = "-direct"
        If directcbox.Checked = True And d2.Arguments.IndexOf(argDirect) = -1 Then
            d2.Arguments = d2.Arguments & argDirect & " "
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
        If ddrawChk.Checked = True And d2.Arguments.IndexOf(argDdraw) = -1 Then
            d2.Arguments = d2.Arguments & argDdraw & " "
        End If

        Dim p As New Process
        p.StartInfo = d2
        p.Start()

        If playCloseChk.Checked Then
            Me.Hide() 'hide window, so that it doesn't look like it doesn't respond anymore
            Me.Close()
        End If

        Const FiveHundredMillisecondInterval As Short = 500
        Dim playButtonTimer As System.Timers.Timer = New System.Timers.Timer(FiveHundredMillisecondInterval)
        AddHandler playButtonTimer.Elapsed, AddressOf AllowPlayButtonAfterDelay
        playButtonTimer.AutoReset = True
        playButtonTimer.Start()
    End Sub

    Private Sub AllowPlayButtonAfterDelay(sourceTimer As System.Timers.Timer, e As ElapsedEventArgs)
        Const threeSeconds As Short = 3000
        Static secondsSincePlayButtonWasPressed As Decimal = 500
        Dim game() As Process
        game = Process.GetProcessesByName("game")
        If game.Count > 0 Or secondsSincePlayButtonWasPressed > threeSeconds Then
            With playBtn
                .Enabled = True
                .Refresh()
            End With
            sourceTimer.Stop()
        Else
            secondsSincePlayButtonWasPressed += sourceTimer.Interval
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

    Private Sub VideoMode_Changed(sender As Object, e As EventArgs) Handles ddrawChk.CheckedChanged, dfxChk.CheckedChanged, d3dChk.CheckedChanged
        My.MySettings.Default.chkboxD3d = False
        My.MySettings.Default.chkboxDdraw = False
        My.MySettings.Default.chkbox3dfx = False
        If (d3dChk.Checked) Then My.MySettings.Default.chkboxD3d = True
        If (ddrawChk.Checked) Then My.MySettings.Default.chkboxDdraw = True
        If (dfxChk.Checked) Then My.MySettings.Default.chkbox3dfx = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        System.Diagnostics.Process.Start("https://pathofdiablo.com/p/")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("https://pathofdiablo.com/donate")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("https://www.reddit.com/r/pathofdiablo")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("https://pathofdiablo.com/wiki")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("https://pathofdiablo.com/rules")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("https://pathofdiablo.com/servers")
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        System.Diagnostics.Process.Start("https://discordapp.com/invite/0cUlOSBTPbtjahc5")
    End Sub

    Private Sub filterlibBtn_Click(sender As Object, e As EventArgs) Handles filterlibBtn.Click
        System.Diagnostics.Process.Start("https://pathofdiablo.com/filters")
    End Sub

    Private Sub downloadcfg_Click(sender As Object, e As EventArgs) Handles downloadcfg.Click
        Dim thread As New Thread(AddressOf LootFilterDownloaderThread)
        thread.IsBackground = True
        isUpdateClicked = True
        thread.Start()
    End Sub

    Private Sub LootFilterDownloaderThread()
        If lootfilterurl.Text.Equals("") Then
            Log("Please enter a url where the loot filter will be downloaded from.")
            Exit Sub
        End If
        'If lootfiltername.Text.Equals("") Then
        '    Log("Please give the loot filter to be downloaded a name.")
        '    Exit Sub
        'End If

        Dim tmp As String() = lootfilterurl.Text.Split(New Char() {"/"})
        'If File.Exists("./filter" & tmp(tmp.Count - 1)) Then
        'Log("Custom filter installed. You must enable 'custom filter' in-game via Settings button to activate it.")
        'MsgBox("Custom filter installed. You must enable 'custom filter' in-game via Settings button to activate it.")
        'Exit Sub
        'End If

        SetEnabled(playBtn, False)
        SetEnabled(downloadcfg, False)

        Dim name As String = "item.filter"      'lootfiltername.Text
        Dim url As String = lootfilterurl.Text

        Log("Downloading " & name & " from " & url)

        Try
            Dim dl As WebClient = New WebClient()
            dl.DownloadFile(url, "./" & name)
            'dl.DownloadFile(url, name)

            Log("Successfully downloaded loot filter " & name & " from " & url)

            If isUpdateClicked Then
                Log("Custom filter installed. You must enable 'custom filter' in-game via Settings button to activate it.")
                MsgBox("Custom filter installed. You must enable 'custom filter' in-game via Settings button to activate it.")
            End If


            Global.Path_of_Diablo_Launcher.My.MySettings.Default.stringLootLink = url
        Catch ex As Exception
            Log("An error occured while downloading loot filter " & name & " from " & url)
        End Try

        SetEnabled(playBtn, True)
        SetEnabled(downloadcfg, True)
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

    Delegate Sub LogDelegate(ByVal text As String)
    Public Sub Log(ByVal text As String)
        If LogBox.InvokeRequired Then
            LogBox.Invoke(New LogDelegate(AddressOf Log), {text})
            Return
        End If
        Dim newText As String = "[" & TimeOfDay.ToString("HH:mm:ss") & "] " & text
        LogBox.Items.Add(newText)
        'highlight last added item
        LogBox.SelectedIndex = LogBox.Items.Count - 1
        'LogBox.ClearSelected()
    End Sub

    Delegate Sub SetProgressDelegate(ByVal progress As Integer)
    Private Sub SetProgress(ByVal progress As Integer)
        If ProgressBar.InvokeRequired Then
            ProgressBar.Invoke(New SetProgressDelegate(AddressOf SetProgress), {progress})
            Return
        End If
        Try
            ProgressBar.Value = progress
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Downloads_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        SetText(dlInfo, String.Format("Downloading at {0} kb/s", (e.BytesReceived / 1024D / stopwatch.Elapsed.TotalSeconds).ToString("0.00")))

        SetProgress(Int32.Parse(Math.Truncate(percentage).ToString()))
    End Sub

    Private Sub Downloads_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        SetProgress(0)
        stopwatch.Reset()
        SetText(dlInfo, "")
        SyncLock e.UserState
            'release block
            Monitor.Pulse(e.UserState)
        End SyncLock
    End Sub

    Private Sub UpdaterThread()

        SetEnabled(playBtn, False)
        SetEnabled(downloadcfg, False)
        SetText(playBtn, "Updating...")
        Log("Searching for updates...")

        If Not cmd.NoUpdate Then

            Dim p1() As Process
            Dim p2() As Process
            p1 = Process.GetProcessesByName("diablo2")
            p2 = Process.GetProcessesByName("game")
            If p1.Count > 0 Then
                MsgBox("diablo2.exe is running, press ok to close this process and continue.")
                p1(0).Kill()
            ElseIf p2.Count > 0 Then
                MsgBox("game.exe is running, press ok to close this process and continue.")
                p2(0).Kill()
            End If

            Dim file As String = "./tmp/files.xml"

            Dim xmlLink As String = "https://raw.githubusercontent.com/GreenDude120/PoD-Launcher/master/files.xml"
            Dim dl As WebClient = New WebClient()
            Try
                dl.DownloadFile(xmlLink, file)
            Catch ex As WebException
                SetText(playBtn, "Error!")
                If ex.Status = WebExceptionStatus.ProtocolError Then
                    Dim res As HttpWebResponse = ex.Response
                    Log("An error occurred checking for updates. HTTP error: " & res.StatusCode & " " & res.StatusDescription)
                Else
                    Log("An error occurred checking for updates. WebExceptionStatus: " & ex.Status.ToString())
                End If
                Exit Sub
            Catch ex As Exception
                SetText(playBtn, "Error!")
                Log("An unexpected error occurred checking for updates. Please try again later.")
                Exit Sub
            End Try

            Dim reader As Xml.XmlTextReader = New Xml.XmlTextReader(file)

            Dim restartRequired As Boolean = False

            Dim files As System.Collections.Generic.LinkedList(Of DownloadItem) = New System.Collections.Generic.LinkedList(Of DownloadItem)

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

        If autoLootChk.Checked Then
            Dim thread As New Thread(AddressOf LootFilterDownloaderThread)
            thread.IsBackground = True
            isUpdateClicked = False
            thread.Start()
        End If


        SetText(playBtn, "Play")
        SetEnabled(playBtn, True)
        SetEnabled(downloadcfg, True)

        If cmd.StartOnUpdateSuccess Then
            playBtn.PerformClick()
        End If

    End Sub

    Private Function DownloadFile(ByRef file As DownloadItem) As Integer

        Dim uptodate As Boolean = False

        'crc = "" -> only check if file exists, don't actually check the crc
        If file.Crc.Equals("") Then
            If IO.File.Exists(file.Name) Then
                Log("File " & file.Name & " already exists, no need to download again.")
                uptodate = True
            Else
                file.Crc = "-1"
            End If
        End If

        'no need to update if file has same crc as the servers file
        Dim localCrc As String = GetCRC32(file.Name)
        If file.Crc.Equals(localCrc) And Not uptodate Then
            Log("File " & file.Name & " is up-to-date")
            Return 0
        End If

        If Not uptodate Then
            If IO.File.Exists(file.Name) Then
                Try
                    IO.File.Move(file.Name, "./tmp/" & file.Name)
                Catch ex As Exception
                End Try
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
                        dl.DownloadFileAsync(New Uri(link.Link), file.Name, myLock)
                        Monitor.Wait(myLock)
                    End SyncLock
                Catch ex As Exception
                    Log("An error occured while downloading file " & file.Name & " from " & link.Link)
                    Continue For
                End Try
                Log("Successfully downloaded file " & file.Name & " from " & link.Link)

                localCrc = GetCRC32(file.Name)
                If Not file.Crc.Equals("-1") And Not file.Crc.Equals(localCrc) Then
                    Log("Checksum of downloaded file (" & file.Name & ") from " & link.Link & " doesn't match the specified checksum.")
                    Continue For
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

    Private Sub d3dChk_CheckedChanged(sender As Object, e As EventArgs) Handles d3dChk.CheckedChanged
        If d3dChk.Checked Then
            wChk.Visible = True
        Else
            wChk.Visible = False
        End If
    End Sub

    Private Sub advancedChk_CheckedChanged(sender As Object, e As EventArgs) Handles advancedChk.CheckedChanged
        If advancedChk.Checked Then
            directcbox.Visible = True
        Else
            directcbox.Visible = False
        End If
    End Sub

    Private Function CheckParentInstallation() As Integer

        SetEnabled(playBtn, False)
        SetEnabled(downloadcfg, False)
        SetText(playBtn, "Checking...")
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
            "Game.exe",
            "d2speech.mpq"
        }

        For Each f In files
            If Not IO.File.Exists("..\\" & f) Then
                SetText(playBtn, "FAILED")
                Log("Can't find D2 installation in the parent(previous) folder. Reinstall PoD but make sure to select your D2 installation path during the PoD installation process.")
                Return 0
            End If
        Next

        Log("Parent Installation verified correctly.")
        Return 1

    End Function

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'clear "tmp" on exit
        For Each file As String In My.Computer.FileSystem.GetFiles("./tmp/", FileIO.SearchOption.SearchAllSubDirectories, "*.*")
            Try
                My.Computer.FileSystem.DeleteFile(file, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            Catch ex As Exception
                'do nothing, just continue
            End Try
        Next
    End Sub

End Class
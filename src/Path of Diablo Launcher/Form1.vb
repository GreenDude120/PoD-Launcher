Imports System.IO
Imports System.Net
Imports System.Threading
Imports System.Diagnostics

Public Class Form1

    Dim updateAvailable As Boolean = False

    Dim stopwatch As Stopwatch = New Stopwatch()

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

        Log("Welcome to the Path of Diablo Launcher v11")

        Dim thread As New Thread(AddressOf UpdaterThread)
        thread.IsBackground = True
        thread.Start()
    End Sub

    Private Sub playBtn_Click(sender As Object, e As EventArgs) Handles playBtn.Click

        Dim d2 As New ProcessStartInfo

        d2.FileName = "Game.exe"
        Try
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers", My.Computer.FileSystem.CurrentDirectory & "\" & d2.FileName, "~ DisableNXShowUI RUNASADMIN")
        Catch ex As Exception
            MsgBox("You don't have the required admin rights. Run the launcher as admin and try again!")
            Me.Close()
        End Try


        d2.Arguments = ""

        If wChk.Checked = True Then
            d2.Arguments = d2.Arguments & "-w "
        End If

        If skipChk.Checked = True Then
            d2.Arguments = d2.Arguments & "-skiptobnet "
        End If

        If nsChk.Checked = True Then
            d2.Arguments = d2.Arguments & "-ns "
        End If

        If dfxChk.Checked = True Then
            d2.Arguments = d2.Arguments & "-3dfx "
        End If

        If directcbox.Checked = True Then
            d2.Arguments = d2.Arguments & "-direct "
        End If

        If aspectChk.Checked = True Then
            d2.Arguments = d2.Arguments & "-nofixaspect "
        End If

        Me.Hide()                           'hide window, so that it doesn't look like it doesn't respond anymore
        Dim p As New Process
        p.StartInfo = d2
        p.Start()

        Me.Close()

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        System.Diagnostics.Process.Start("https://pathofdiablo.com/p/")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("http://pathofdiablo.com/donate")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("https://www.reddit.com/r/pathofdiablo")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("http://pathofdiablo.com/wiki")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("https://www.reddit.com/r/pathofdiablo/wiki/rules")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("http://pathofdiablo.com/servers")
    End Sub

    Private Sub filterlibBtn_Click(sender As Object, e As EventArgs) Handles filterlibBtn.Click
        System.Diagnostics.Process.Start("http://pathofdiablo.com/filters")
    End Sub

    Private Sub downloadcfg_Click(sender As Object, e As EventArgs) Handles downloadcfg.Click
        Dim thread As New Thread(AddressOf LootFilterDownloaderThread)
        thread.IsBackground = True
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

        SetEnabled(playBtn, False)
        SetEnabled(downloadcfg, False)

        Dim name As String = "item.filter"      'lootfiltername.Text
        Dim url As String = lootfilterurl.Text

        Log("Downloading " & name & " from " & url)

        Try
            Dim dl As WebClient = New WebClient()
            dl.DownloadFile(url, "./filter/" & name)

            Log("Successfully downloaded loot filter " & name & " from " & url)
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
    Private Sub Log(ByVal text As String)
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
        ProgressBar.Value = progress
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

        Dim file As String = "./tmp/files.xml"

        Dim xmlLink As String = "https://raw.githubusercontent.com/GreenDude120/PoD-Launcher/master/files.xml"
        Dim dl As WebClient = New WebClient()
        Try
            dl.DownloadFile(xmlLink, file)
        Catch ex As Exception
            SetText(playBtn, "Error!")
            Log("An error occured checking for updates. Please try again later.")
            Exit Sub
        End Try

        Dim reader As Xml.XmlTextReader = New Xml.XmlTextReader(file)

        Dim restartRequired As Boolean = False
        Dim nUpdates As Integer = 0

        Do While reader.Read()
            Select Case reader.NodeType
                Case Xml.XmlNodeType.Element
                    If reader.Name.Equals("file") Then
                        Dim name As String = ""
                        Dim crc As String = ""
                        Dim restart As Boolean = False

                        'read name and crc (ignore all other attributes)
                        If reader.AttributeCount > 0 Then
                            While reader.MoveToNextAttribute
                                If reader.Name.Equals("name") Then
                                    name = reader.Value
                                ElseIf reader.Name.Equals("crc") Then
                                    crc = reader.Value
                                ElseIf reader.Name.Equals("restartRequired") Then
                                    If reader.Value.Equals("true") Then
                                        restart = True
                                    End If
                                End If
                            End While
                        End If

                        If name.Equals("") Then
                            Log("Malformed " & file & ". Notifiy GreenDude!")
                            Exit Sub
                        End If

                        Dim uptodate As Boolean = False

                        'crc = "" -> only check if file exists, don't actually check the crc
                        If crc.Equals("") Then
                            If IO.File.Exists(name) Then
                                Log("File " & name & " already exists, no need to download again.")
                                uptodate = True
                            Else
                                crc = "-1"
                            End If
                        End If

                        'no need to update if file has same crc as the servers file
                        Dim localCrc As String = GetCRC32(name)
                        If crc.Equals(localCrc) And Not uptodate Then
                            Log("File " & name & " is up-to-date")
                            uptodate = True
                        End If

                        'read links
                        While reader.Read()
                            Select Case reader.NodeType
                                Case Xml.XmlNodeType.Element
                                    If Not uptodate Then
                                        If IO.File.Exists(name) Then
                                            Try
                                                IO.File.Move(name, "./tmp/" & name)
                                            Catch ex As Exception
                                            End Try
                                        End If

                                        Dim link As String = reader.ReadInnerXml()
                                        Log("Downloading file " & name & " from " & link)

                                        dl = New WebClient()
                                        AddHandler dl.DownloadProgressChanged, AddressOf Downloads_ProgressChanged
                                        AddHandler dl.DownloadFileCompleted, AddressOf Downloads_DownloadCompleted

                                        Try
                                            Dim myLock As Object = New Object()
                                            SyncLock myLock
                                                stopwatch.Start()
                                                dl.DownloadFileAsync(New Uri(link), name, myLock)
                                                Monitor.Wait(myLock)
                                            End SyncLock
                                        Catch ex As Exception
                                            Log("An error occured while downloading file " & name & " from " & link)
                                            Continue While
                                        End Try
                                        Log("Successfully downloaded file " & name & " from " & link)

                                        localCrc = GetCRC32(name)
                                        If Not crc.Equals("-1") And Not crc.Equals(localCrc) Then
                                            Log("Checksum of downloaded file (" & name & ") from " & link & " doesn't match the specified checksum. Please try again later.")
                                            Exit Sub
                                        End If

                                        uptodate = True
                                        If restart Then
                                            restartRequired = True
                                        End If
                                    End If
                                Case Xml.XmlNodeType.EndElement
                                    Exit While
                            End Select
                        End While

                        nUpdates = nUpdates + 1
                        If Not uptodate Then
                            Log("An error occured while updating file " & name & ". Please restart and try again.")
                            Exit Sub
                        End If
                    End If

            End Select
        Loop

        reader.Close()

        Log("Finished checking " & nUpdates & " file(s) for updates")

        'restart if needed
        If restartRequired Then
            MsgBox("An updated file requires the Launcher to restart to function correctly. Restarting Now!")
            Application.Restart()
        End If

        SetText(playBtn, "Play")
        SetEnabled(playBtn, True)
        SetEnabled(downloadcfg, True)

    End Sub

    Private Sub advancedChk_CheckedChanged(sender As Object, e As EventArgs) Handles advancedChk.CheckedChanged
        If advancedChk.Checked Then
            directcbox.Visible = True
        Else
            directcbox.Visible = False
        End If
    End Sub

End Class
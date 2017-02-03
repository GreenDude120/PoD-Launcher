Imports System.IO
Imports System.Net

Public Class Form1

    Dim updateAvailable As Boolean = False
    Dim installPath As String

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

        If Not My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "wChk", Nothing) Is Nothing Then

            Dim savedwChk = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "wChk", Nothing)
            Dim savedskipChk = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "skipChk", Nothing)
            Dim savednsChk = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "nsChk", Nothing)
            Dim saveddfxChk = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "dfxChk", Nothing)
            Dim savedaspectChk = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "aspectChk", Nothing)
            Dim savedrunasChk = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "runasChk", Nothing)
            Dim savedtxtChk = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "txtChk", Nothing)
            Dim saveddirectChk = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "directChk", Nothing)
            Dim savedMainGtw = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "mainGtw", Nothing)
            Dim savedQolChk = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "qolChk", Nothing)

            If savedwChk = "True" Then
                wChk.Checked = True
            Else
                wChk.Checked = False
            End If

            If savedskipChk = "True" Then
                skipChk.Checked = True
            Else
                skipChk.Checked = False
            End If

            If savednsChk = "True" Then
                nsChk.Checked = True
            Else
                nsChk.Checked = False
            End If

            If saveddfxChk = "True" Then
                dfxChk.Checked = True
            Else
                dfxChk.Checked = False
            End If

            If savedaspectChk = "True" Then
                aspectChk.Checked = True
            Else
                aspectChk.Checked = False
            End If

            If savedtxtChk = "True" Then
                txtcbox.Checked = True
            Else
                txtcbox.Checked = False
            End If

            If saveddirectChk = "True" Then
                directcbox.Checked = True
            Else
                directcbox.Checked = False
            End If

            If savedrunasChk = "True" Then
                runasChk.Checked = True
            Else
                runasChk.Checked = False
            End If

            If savedMainGtw = "False" Then
                radioMain.Checked = False
                radioCustom.Checked = True
            Else
                radioMain.Checked = True
                radioCustom.Checked = False
            End If

            If savedQolChk = "True" Then
                qoladdoncbox.Checked = True
            Else
                qoladdoncbox.Checked = False
            End If

        End If

        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", Nothing) Is Nothing Then

            Dim defaultGatewayValues() As String = {"1009", "01", "uswest.battle.net", "8", "U.S.West", "useast.battle.net", "6", "U.S.East", "asia.battle.net", "-9", "Asia", "europe.battle.net", "-1", "Europe"}
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", defaultGatewayValues)

        End If

        If Not My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "InstallPath", Nothing) Is Nothing Then

            installPath = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "InstallPath", Nothing)

            installPath = installPath.TrimEnd("\") & "\"

            Dim localCRC = GetCRC32(installPath & "patch_d2.mpq")

            Dim d2version = FileVersionInfo.GetVersionInfo(installPath & "Game.exe").FileVersion

            If Not d2version = "1, 0, 13, 60" Then
                If Not d2version = "1, 0, 13, 64" Then
                    Dim updatedialog As New UpdateD2()

                    If updatedialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then

                        updatedialog.Dispose()

                        Dim gameproc() As Process
                        Dim updatecomplete As Boolean = False

                        While updatecomplete = False
                            gameproc = Process.GetProcessesByName("Diablo II")
                            If gameproc.Count > 0 Then
                                gameproc(0).Kill()
                                updatecomplete = True
                            End If
                        End While

                    Else

                        End

                    End If
                End If
            End If

            localcrcTxt.Text = localCRC

            Dim address As String = "https://raw.githubusercontent.com/GreenDude120/PoD-Launcher/master/currentpatch"
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
            servercrcTxt.Text = reader.ReadToEnd

            If servercrcTxt.Text = localcrcTxt.Text Then

                playBtn.Enabled = True
                playBtn.Text = "PLAY"

            Else

                playBtn.Enabled = True
                playBtn.Text = "Update Available"
                updateAvailable = True

            End If

        Else

            setgatewayBtn.Enabled = False
            playBtn.Enabled = False
            playBtn.Text = "No D2 Installation Found"

        End If

        Dim launchervonline As String = "https://raw.githubusercontent.com/GreenDude120/PoD-Launcher/master/launcherversion"
        Dim wclient As WebClient = New WebClient()
        Dim wreader As StreamReader = New StreamReader(wclient.OpenRead(launchervonline))
        Dim launchervonlinetxt As Integer
        launchervonlinetxt = wreader.ReadToEnd

        If Int(podlauncherlocalv.Text) = launchervonlinetxt Then

            'launcher is up-to-date

        Else
            MsgBox("A new version of the Path of Diablo Launcher is available. Please uninstall this current version and download the updated version.")
            System.Diagnostics.Process.Start("http://pathofdiablo.com/wiki/index.php/Download")
        End If
    End Sub

    Private Sub patchclient_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        patchPrgBr.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Private Sub patchclient_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        patchPrgBr.Visible = False
        localcrcTxt.Visible = True

        Dim localCRC = GetCRC32(installPath & "patch_d2.mpq")

        localcrcTxt.Text = localCRC

        If servercrcTxt.Text = localcrcTxt.Text Then

            updateAvailable = False
            playBtn.Enabled = True
            playBtn.Text = "PLAY"

        Else

            playBtn.Enabled = False
            playBtn.Text = "Patch Failed"

        End If

    End Sub

    Public Declare Function GetProcAddress Lib "kernel32" (
        ByVal hModule As Integer, ByVal lpProcName As String) As Integer

    Public Declare Function GetModuleHandle Lib "Kernel32" Alias "GetModuleHandleA" (
        ByVal lpModuleName As String) As Integer

    Public Declare Function VirtualAllocEx Lib "kernel32" (
        ByVal hProcess As Integer,
        ByVal lpAddress As Integer,
        ByVal dwSize As Integer,
        ByVal flAllocationType As Integer,
        ByVal flProtect As Integer) As Integer

    Public Declare Function OpenProcess Lib "kernel32" (
        ByVal dwDesiredAccess As Integer,
        ByVal bInheritHandle As Integer,
        ByVal dwProcessId As Integer) As Integer

    Public Declare Function WriteProcessMemory Lib "kernel32" (
        ByVal hProcess As Integer,
        ByVal lpBaseAddress As Integer,
        ByVal lpBuffer As String,
        ByVal nSize As Integer,
        ByRef lpNumberOfBytesWritten As Integer) As Integer

    Public Declare Function CreateRemoteThread Lib "kernel32" (
        ByVal hProcess As Integer,
        ByVal lpThreadAttributes As Integer,
        ByVal dwStackSize As Integer,
        ByVal lpStartAddress As Integer,
        ByVal lpParameter As Integer,
        ByVal dwCreationFlags As Integer,
        ByRef lpThreadId As Integer) As Integer

    Public Declare Function CloseHandle Lib "kernel32" Alias "CloseHandle" (
        ByVal hObject As Integer) As Integer

    Public Declare Function WaitForSingleObject Lib "kernel32.dll" (
        ByVal hHandle As Integer,
        ByVal dwMilliseconds As Integer) As Integer

    Public Declare Function GetCurrentProcess Lib "kernel32.dll" () As Integer

    Public Declare Function OpenProcessToken Lib "advapi32.dll" (
        ByVal ProcessHandle As Integer,
        ByVal DesiredAcess As Integer,
        ByRef TokenHandle As Integer) As Integer

    Structure LUID
        Public LowPart As UInt32
        Public HighPart As Integer
    End Structure

    Structure TOKEN_PRIVILEGES
        Public PrivilegeCount As Integer
        Public TheLuid As LUID
        Public Attributes As Integer
    End Structure

    Public Declare Function LookupPrivilegeValue Lib "advapi32.dll" Alias "LookupPrivilegeValueA" (
        ByVal lpSystemName As String,
        ByVal lpName As String,
        ByRef lpLuid As LUID) As Integer

    Public Declare Function AdjustTokenPrivileges Lib "advapi32.dll" (
        ByVal TokenHandle As Integer,
        ByVal DisableAllPrivileges As Boolean,
        ByRef NewState As TOKEN_PRIVILEGES,
         BufferLength As Integer,
        ByRef PreviousState As Integer,
        ByRef ReturnLength As Integer) As Integer

    Public Declare Function MessageBox Lib "user32.dll" Alias "MessageBoxA" (
        ByVal hWnd As Integer,
        ByVal lpText As String,
        ByVal lpCaption As String,
        ByVal uType As Integer) As Integer



    Const INFINITE = &HFFFF

    Private Sub playBtn_Click(sender As Object, e As EventArgs) Handles playBtn.Click

        If updateAvailable = True Then

            localcrcTxt.Visible = False
            patchPrgBr.Visible = True

            If System.IO.File.Exists(installPath & "patch_d2.mpq.bak") = True Then

                System.IO.File.Delete(installPath & "patch_d2.mpq.bak")

            End If

            My.Computer.FileSystem.RenameFile(installPath & "patch_d2.mpq", "patch_d2.mpq.bak")

            Dim patchclient As WebClient = New WebClient

            AddHandler patchclient.DownloadProgressChanged, AddressOf patchclient_ProgressChanged

            AddHandler patchclient.DownloadFileCompleted, AddressOf patchclient_DownloadCompleted

            patchclient.DownloadFileAsync(New Uri("https://raw.githubusercontent.com/GreenDude120/PoD-Launcher/master/patch_d2.mpq"), installPath & "patch_d2.mpq")

            playBtn.Text = "Update in Progress"

            playBtn.Enabled = False


        Else

            Dim d2 As New ProcessStartInfo
            d2.FileName = installPath & "Diablo II.exe"
            d2.Arguments = ""

            If wChk.Checked = True Then
                d2.Arguments = d2.Arguments & "-w "
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "wChk", "True")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "wChk", "False")
            End If

            If skipChk.Checked = True Then
                d2.Arguments = d2.Arguments & "-skiptobnet "
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "skipChk", "True")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "skipChk", "False")
            End If

            If nsChk.Checked = True Then
                d2.Arguments = d2.Arguments & "-ns "
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "nsChk", "True")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "nsChk", "False")
            End If

            If dfxChk.Checked = True Then
                d2.Arguments = d2.Arguments & "-3dfx "
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "dfxChk", "True")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "dfxChk", "False")
            End If

            If directcbox.Checked = True Then
                d2.Arguments = d2.Arguments & "-direct "
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "directChk", "True")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "directChk", "False")
            End If

            If txtcbox.Checked = True Then
                d2.Arguments = d2.Arguments & "-txt "
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "txtChk", "True")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "txtChk", "False")
            End If

            If aspectChk.Checked = True Then
                d2.Arguments = d2.Arguments & "-nofixaspect "
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "aspectChk", "True")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "aspectChk", "False")
            End If

            If runasChk.Checked = True Then
                d2.Verb = "runas"
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "runasChk", "True")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "runasChk", "False")
            End If

            If radioMain.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "mainGtw", "True")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "mainGtw", "False")
            End If

            If qoladdoncbox.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "qolChk", "True")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\PoDLauncher", "qolChk", "False")
            End If

            Me.Hide()                           'hide window, so that it doesn't look like it doesn't respond anymore
            Dim p As New Process
            p.StartInfo = d2
            p.Start()

            If qoladdoncbox.Checked = True Then
                p.WaitForExit()                     'wait for "diablo II.exe" finish running game.exe
                System.Threading.Thread.Sleep(5000)   'security wait for the window to build up

                Dim sucess As Integer = 1

                'get debug privileges
                Dim hToken As Integer
                Dim sedebugnameValue As LUID
                Dim tkp As New TOKEN_PRIVILEGES
                If OpenProcessToken(GetCurrentProcess(), &H20 Or &H8, hToken) <> 0 Then
                    If LookupPrivilegeValue(vbNullString, "SeDebugPrivilege", sedebugnameValue) <> 0 Then
                        tkp.PrivilegeCount = 1
                        tkp.TheLuid = sedebugnameValue
                        tkp.Attributes = &H2
                        If AdjustTokenPrivileges(hToken, False, tkp, System.Runtime.InteropServices.Marshal.SizeOf(tkp), 0, 0) <> 0 Then
                            'null
                        Else
                            MessageBox(0, "Error Code: 8" + Environment.NewLine + "Please file a bug report" + Environment.NewLine + "Until it is fixed, please try running podqol.exe every time you start the game", "QoL-Features", &H30 Or &H10000)
                            sucess = 0
                        End If
                    Else
                        MessageBox(0, "Error Code: 7" + Environment.NewLine + "Please file a bug report" + Environment.NewLine + "Until it is fixed, please try running podqol.exe every time you start the game", "QoL-Features", &H30 Or &H10000)
                        sucess = 0
                    End If
                Else
                    MessageBox(0, "Error Code: 6" + Environment.NewLine + "Please file a bug report" + Environment.NewLine + "Until it is fixed, please try running podqol.exe every time you start the game", "QoL-Features", &H30 Or &H10000)
                    sucess = 0
                End If
                CloseHandle(hToken)

                If sucess = 1 Then
                    Dim x As Process() = Process.GetProcesses()
                    For Each current As Process In x
                        If String.IsNullOrEmpty(current.MainWindowTitle) Then
                            Continue For
                        End If
                        If String.Compare("Diablo II", current.MainWindowTitle, True) = 0 Then
                            Dim hProc As Integer = OpenProcess(&HF0000 Or &H100000 Or &HFFFF, False, current.Id)
                            If hProc <> 0 Then
                                Dim hKernel32 As Integer = GetModuleHandle("Kernel32.dll")
                                If hKernel32 <> 0 Then
                                    Dim lpLoadLibraryA As Integer = GetProcAddress(hKernel32, "LoadLibraryA")
                                    If lpLoadLibraryA <> 0 Then
                                        Dim wPath As String = installPath & "pod.dll"
                                        Dim lpRemoteString As Integer = VirtualAllocEx(hProc, 0, Len(wPath), &H2000 Or &H1000, &H4)
                                        If lpRemoteString <> 0 Then
                                            Dim writeReturn As Integer = WriteProcessMemory(hProc, lpRemoteString, wPath, wPath.Length, 0)
                                            If writeReturn <> 0 Then
                                                Dim hThread As Integer = CreateRemoteThread(hProc, 0, 0, lpLoadLibraryA, lpRemoteString, 0, 0)
                                                WaitForSingleObject(hThread, INFINITE)
                                            Else
                                                MessageBox(0, "Error Code: 5" + Environment.NewLine + "Please file a bug report" + Environment.NewLine + "Until it is fixed, please try running podqol.exe every time you start the game", "QoL-Features", &H30 Or &H10000)
                                                sucess = 0
                                            End If
                                        Else
                                            MessageBox(0, "Error Code: 4" + Environment.NewLine + "Please file a bug report" + Environment.NewLine + "Until it is fixed, please try running podqol.exe every time you start the game", "QoL-Features", &H30 Or &H10000)
                                            sucess = 0
                                        End If
                                    Else
                                        MessageBox(0, "Error Code: 3" + Environment.NewLine + "Please file a bug report" + Environment.NewLine + "Until it is fixed, please try running podqol.exe every time you start the game", "QoL-Features", &H30 Or &H10000)
                                        sucess = 0
                                    End If
                                Else
                                    MessageBox(0, "Error Code: 2" + Environment.NewLine + "Please file a bug report" + Environment.NewLine + "Until it is fixed, please try running podqol.exe every time you start the game", "QoL-Features", &H30 Or &H10000)
                                    sucess = 0
                                End If
                            Else
                                MessageBox(0, "Error Code: 1" + Environment.NewLine + "Please file a bug report" + Environment.NewLine + "Until it is fixed, please try running podqol.exe every time you start the game", "QoL-Features", &H30 Or &H10000)
                                sucess = 0
                            End If
                            Exit For
                        End If
                    Next
                End If


                End

            Else
                End
            End If

        End If

    End Sub

    Private Sub DEP_Only_Click(sender As Object, e As EventArgs) Handles DEP_Only.Click
        Try
            Dim wDEP As New StreamWriter(installPath & "000aaaDEP.bat")
            wDEP.WriteLine("@ECHO OFF")
            wDEP.WriteLine("ECHO %~dp0")
            wDEP.WriteLine("set ""mypath=%~dp0%Diablo II.exe""")
            wDEP.WriteLine("ECHO %mypath%")
            wDEP.WriteLine("ECHO Enabling DEP exception")
            wDEP.WriteLine("call bcdedit.exe /set {current} nx OptOut && color 0A && echo DEP policy changed to allow exceptions || color 0C && echo RUN AS ADMIN")
            wDEP.WriteLine("call REG ADD ""HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers"" /t REG_SZ /d ""~ DisableNXShowUI"" /f /v ""%mypath% ")
            wDEP.WriteLine("PAUSE")
            wDEP.WriteLine("EXIT")
            wDEP.Close()
            MsgBox("When you click OK you will be sent to your Diablo II folder" & vbCrLf & vbCrLf & "Right click on 000aaaDEP.bat and run as admin, the text should come out green, a restart might be required")
            Process.Start(installPath)
        Catch ex As Exception
            MsgBox("Error generating fix file, it's probably open")
        End Try

    End Sub

    Private Sub DEP_and_XP_SP2_Click(sender As Object, e As EventArgs) Handles DEP_and_XP_SP2.Click
        Try
            Dim wDEP As New StreamWriter(installPath & "000aaaDEP+XP_SP2.bat")
            wDEP.WriteLine("@ECHO OFF")
            wDEP.WriteLine("ECHO %~dp0")
            wDEP.WriteLine("set ""mypath=%~dp0%Diablo II.exe""")
            wDEP.WriteLine("ECHO %mypath%")
            wDEP.WriteLine("ECHO Enabling DEP exception")
            wDEP.WriteLine("call bcdedit.exe /set {current} nx OptOut && color 0A && echo DEP policy changed to allow exceptions || color 0C && echo RUN AS ADMIN")
            wDEP.WriteLine("call REG ADD ""HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers"" /t REG_SZ /d ""~ RUNASADMIN WINXPSP2 DisableNXShowUI"" /f /v ""%mypath% ")
            wDEP.WriteLine("PAUSE")
            wDEP.WriteLine("EXIT")
            wDEP.Close()
            MsgBox("When you click OK you will be sent to your Diablo II folder" & vbCrLf & vbCrLf & "Right click on 000aaaDEP+XP_SP2.bat and run as admin, the text should come out green, a restart might be required")
            Process.Start(installPath)
        Catch ex As Exception
            MsgBox("Error generating fix file, it's probably open")
        End Try

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

    Private Sub viewmorecfg_Click(sender As Object, e As EventArgs) Handles viewmorecfg.Click

        System.Diagnostics.Process.Start("http://pathofdiablo.com/filters")

    End Sub

    Private Sub downloadcfg_Click(sender As Object, e As EventArgs) Handles downloadcfg.Click

        Dim downloadfilter As WebClient = New WebClient
        downloadfilter.DownloadFileAsync(New Uri(lootfilterurl.Text), installPath & "item.filter")
        MsgBox("item.filter was overwrote by " & lootfilterurl.Text)
    End Sub

    Private Sub resetcfg_Click(sender As Object, e As EventArgs) Handles resetcfg.Click
        Dim resetfilter As WebClient = New WebClient
        resetfilter.DownloadFileAsync(New Uri("http://pathofdiablo.com/item.filter"), installPath & "item.filter")
        MsgBox("item.filter was overwrote by http://pathofdiablo.com/item.filter")
    End Sub

    Private Sub setGatewayBtn_Click(sender As Object, e As EventArgs) Handles setGatewayBtn.Click

        Dim gatewayValues = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", Nothing)

        My.Computer.Registry.CurrentUser.DeleteSubKey("Software\Battle.net\Configuration")

        Dim newGatewayValues() As String

        If radioMain.Checked Then

            newGatewayValues = {"1009", "05", "uswest.battle.net", "8", "U.S.West", "useast.battle.net", "6", "U.S.East", "asia.battle.net", "-9", "Asia", "europe.battle.net", "-1", "Europe", "s.pathofdiablo.com", "6", "Path of Diablo"}

        Else

            newGatewayValues = {"1009", "05", "uswest.battle.net", "8", "U.S.West", "useast.battle.net", "6", "U.S.East", "asia.battle.net", "-9", "Asia", "europe.battle.net", "-1", "Europe", CustomGatewayTextBox.Text, "6", "Path of Diablo"}

        End If

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", newGatewayValues)

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BNETIP", "s.pathofdiablo.com")

    End Sub

    Private Sub resoreDefaultGatewaysBtn_Click(sender As Object, e As EventArgs) Handles resoreDefaultGatewaysBtn.Click

        Dim defaultGatewayValues() As String = {"1009", "01", "uswest.battle.net", "8", "U.S.West", "useast.battle.net", "6", "U.S.East", "asia.battle.net", "-9", "Asia", "europe.battle.net", "-1", "Europe"}
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", defaultGatewayValues)

        My.Computer.Registry.CurrentUser.OpenSubKey("Software\Blizzard Entertainment\Diablo II", True).DeleteValue("BNETIP")

    End Sub

End Class
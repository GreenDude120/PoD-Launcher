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

            If savedrunasChk = "True" Then
                runasChk.Checked = True
            Else
                runasChk.Checked = False
            End If

        End If

        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", Nothing) Is Nothing Then

            Dim defaultGatewayValues() As String = {"1009", "01", "uswest.battle.net", "8", "U.S.West", "useast.battle.net", "6", "U.S.East", "asia.battle.net", "-9", "Asia", "europe.battle.net", "-1", "Europe"}
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", defaultGatewayValues)

        End If
        'Main IP
        If Not My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BNETIP", Nothing) Is Nothing Then

            Dim currentGateway = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BNETIP", Nothing)

            If Not currentGateway = "r.pathofdiablo.com" Then
                setgatewayBtn.Enabled = True
                setgatewayBtn.Text = "Set Gateway"
                CustomGatewayTextBox.Text = currentGateway
                setgatewayBtnCustom.Enabled = True
            Else
                setgatewayBtn.Enabled = True
                setgatewayBtn.Text = "Remove Gateway"
                setgatewayBtnCustom.Text = "Set Gateway"
                setgatewayBtnCustom.Enabled = True
                CustomGatewayTextBox.Text = currentGateway
            End If

        Else

            setgatewayBtn.Enabled = True
            setgatewayBtnCustom.Enabled = True
            setgatewayBtn.Text = "Set Gateway"

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

    End Sub
    Private Sub setgatewayBtn_Click(sender As Object, e As EventArgs) Handles setgatewayBtn.Click

        If setgatewayBtn.Text = "Set Gateway" Then

            setgatewayBtn.Text = "Remove Gateway"

            setgatewayBtnCustom.Text = "Set Gateway"

            Dim gatewayValues = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", Nothing)

            If gatewayValues(0).GetType().FullName.Equals("System.Byte") Then

                My.Computer.Registry.CurrentUser.DeleteSubKey("Software\Battle.net\Configuration")

                Dim newGatewayValues() As String = {"1009", "05", "uswest.battle.net", "8", "U.S.West", "useast.battle.net", "6", "U.S.East", "asia.battle.net", "-9", "Asia", "europe.battle.net", "-1", "Europe", "6", "r.pathofdiablo.com", "Path of Diablo"}

                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", newGatewayValues)

            Else

                Array.Resize(gatewayValues, gatewayValues.Length + 1)
                gatewayValues(gatewayValues.Length - 1) = "r.pathofdiablo.com"

                Array.Resize(gatewayValues, gatewayValues.Length + 1)
                gatewayValues(gatewayValues.Length - 1) = "6"

                Array.Resize(gatewayValues, gatewayValues.Length + 1)
                gatewayValues(gatewayValues.Length - 1) = "Path of Diablo"

                gatewayValues(1) = "05"

                My.Computer.Registry.CurrentUser.DeleteSubKey("Software\Battle.net\Configuration")

                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", gatewayValues)

            End If

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BNETIP", "r.pathofdiablo.com")

        Else

            setgatewayBtn.Text = "Set Gateway"

            Dim defaultGatewayValues() As String = {"1009", "01", "uswest.battle.net", "8", "U.S.West", "useast.battle.net", "6", "U.S.East", "asia.battle.net", "-9", "Asia", "europe.battle.net", "-1", "Europe"}
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", defaultGatewayValues)

            My.Computer.Registry.CurrentUser.OpenSubKey("Software\Blizzard Entertainment\Diablo II", True).DeleteValue("BNETIP")

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



            Process.Start(d2)

            End

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

    Private Sub setgatewayBtnCustom_Click(sender As Object, e As EventArgs) Handles setgatewayBtnCustom.Click

        If setgatewayBtnCustom.Text = "Set Gateway" Then

            setgatewayBtn.Text = "Set Gateway"

            setgatewayBtnCustom.Text = "Remove Gateway"

            Dim gatewayValues = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", Nothing)

            If gatewayValues(0).GetType().FullName.Equals("System.Byte") Then

                My.Computer.Registry.CurrentUser.DeleteSubKey("Software\Battle.net\Configuration")

                Dim newGatewayValues() As String = {"1009", "05", "uswest.battle.net", "8", "U.S.West", "useast.battle.net", "6", "U.S.East", "asia.battle.net", "-9", "Asia", "europe.battle.net", "-1", "Europe", "6", CustomGatewayTextBox.Text, "Path of Diablo"}

                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", newGatewayValues)

            Else

                Array.Resize(gatewayValues, gatewayValues.Length + 1)
                gatewayValues(gatewayValues.Length - 1) = CustomGatewayTextBox.Text

                Array.Resize(gatewayValues, gatewayValues.Length + 1)
                gatewayValues(gatewayValues.Length - 1) = "6"

                Array.Resize(gatewayValues, gatewayValues.Length + 1)
                gatewayValues(gatewayValues.Length - 1) = "Path of Diablo"

                gatewayValues(1) = "05"

                My.Computer.Registry.CurrentUser.DeleteSubKey("Software\Battle.net\Configuration")

                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", gatewayValues)

            End If

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BNETIP", CustomGatewayTextBox.Text)

        Else

            setgatewayBtnCustom.Text = "Set Gateway"

            Dim defaultGatewayValues() As String = {"1009", "01", "uswest.battle.net", "8", "U.S.West", "useast.battle.net", "6", "U.S.East", "asia.battle.net", "-9", "Asia", "europe.battle.net", "-1", "Europe"}
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", defaultGatewayValues)

            My.Computer.Registry.CurrentUser.OpenSubKey("Software\Blizzard Entertainment\Diablo II", True).DeleteValue("BNETIP")

        End If


    End Sub
End Class
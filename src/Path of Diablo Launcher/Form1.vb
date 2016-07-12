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
            End If

            If savedskipChk = "True" Then
                skipChk.Checked = True
            End If

            If savednsChk = "True" Then
                nsChk.Checked = True
            End If

            If saveddfxChk = "True" Then
                dfxChk.Checked = True
            End If

            If savedaspectChk = "True" Then
                aspectChk.Checked = True
            End If

            If savedrunasChk = "True" Then
                runasChk.Checked = True
            End If

        End If

        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", Nothing) Is Nothing Then

            Dim defaultGatewayValues() As String = {"1009", "01", "uswest.battle.net", "8", "U.S.West", "useast.battle.net", "6", "U.S.East", "asia.battle.net", "-9", "Asia", "europe.battle.net", "-1", "Europe"}
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", defaultGatewayValues)

        End If
        'NA
        If Not My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BNETIP", Nothing) Is Nothing Then

            Dim currentGateway = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BNETIP", Nothing)

            If Not currentGateway = "na.pathofdiablo.com" Then
                setgatewayBtn.Enabled = True
                setgatewayBtn.Text = "Set NA Gateway"
            Else
                setgatewayBtn.Enabled = True
                setgatewayBtn.Text = "Remove NA Gateway"
            End If

        Else

            setgatewayBtn.Enabled = True
            setgatewayBtn.Text = "Set NA Gateway"

        End If
        'EU
        If Not My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BNETIP", Nothing) Is Nothing Then

            Dim currentGateway = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BNETIP", Nothing)

            If Not currentGateway = "eu.pathofdiablo.com" Then
                setgateway2Btn.Enabled = True
                setgateway2Btn.Text = "Set EU Gateway"
            Else
                setgateway2Btn.Enabled = True
                setgateway2Btn.Text = "Remove EU Gateway"
            End If

        Else

            setgateway2Btn.Enabled = True
            setgateway2Btn.Text = "Set EU Gateway"

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
            setgateway2Btn.Enabled = False
            playBtn.Enabled = False
            playBtn.Text = "No D2 Installation Found"

        End If

    End Sub
    Private Sub setgatewayBtn_Click(sender As Object, e As EventArgs) Handles setgatewayBtn.Click

        If setgatewayBtn.Text = "Set NA Gateway" Then

            setgatewayBtn.Text = "Remove NA Gateway"
            setgateway2Btn.Text = "Set EU Gateway"

            Dim gatewayValues = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", Nothing)

            If gatewayValues(0).GetType().FullName.Equals("System.Byte") Then

                My.Computer.Registry.CurrentUser.DeleteSubKey("Software\Battle.net\Configuration")

                Dim newGatewayValues() As String = {"1009", "05", "uswest.battle.net", "8", "U.S.West", "useast.battle.net", "6", "U.S.East", "asia.battle.net", "-9", "Asia", "europe.battle.net", "-1", "Europe", "6", "na.pathofdiablo.com", "Path of Diablo"}

                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", newGatewayValues)

            Else

                Array.Resize(gatewayValues, gatewayValues.Length + 1)
                gatewayValues(gatewayValues.Length - 1) = "na.pathofdiablo.com"

                Array.Resize(gatewayValues, gatewayValues.Length + 1)
                gatewayValues(gatewayValues.Length - 1) = "6"

                Array.Resize(gatewayValues, gatewayValues.Length + 1)
                gatewayValues(gatewayValues.Length - 1) = "Path of Diablo"

                gatewayValues(1) = "05"

                My.Computer.Registry.CurrentUser.DeleteSubKey("Software\Battle.net\Configuration")

                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", gatewayValues)

            End If

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BNETIP", "na.pathofdiablo.com")

        Else

            setgatewayBtn.Text = "Set Gateway"

            Dim defaultGatewayValues() As String = {"1009", "01", "uswest.battle.net", "8", "U.S.West", "useast.battle.net", "6", "U.S.East", "asia.battle.net", "-9", "Asia", "europe.battle.net", "-1", "Europe"}
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", defaultGatewayValues)

            My.Computer.Registry.CurrentUser.OpenSubKey("Software\Blizzard Entertainment\Diablo II", True).DeleteValue("BNETIP")

        End If

        setgateway2Btn.Text = "Set EU Gateway"

    End Sub

    Private Sub setgateway2Btn_Click(sender As Object, e As EventArgs) Handles setgateway2Btn.Click

        If setgateway2Btn.Text = "Set EU Gateway" Then

            setgateway2Btn.Text = "Remove EU Gateway"
            setgatewayBtn.Text = "Set NA Gateway"

            Dim gatewayValues = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", Nothing)

            If gatewayValues(0).GetType().FullName.Equals("System.Byte") Then

                My.Computer.Registry.CurrentUser.DeleteSubKey("Software\Battle.net\Configuration")

                Dim newGatewayValues() As String = {"1009", "05", "uswest.battle.net", "8", "U.S.West", "useast.battle.net", "6", "U.S.East", "asia.battle.net", "-9", "Asia", "europe.battle.net", "-1", "Europe", "6", "eu.pathofdiablo.com", "Path of Diablo"}

                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", newGatewayValues)

            Else

                Array.Resize(gatewayValues, gatewayValues.Length + 1)
                gatewayValues(gatewayValues.Length - 1) = "eu.pathofdiablo.com"

                Array.Resize(gatewayValues, gatewayValues.Length + 1)
                gatewayValues(gatewayValues.Length - 1) = "6"

                Array.Resize(gatewayValues, gatewayValues.Length + 1)
                gatewayValues(gatewayValues.Length - 1) = "Path of Diablo"

                gatewayValues(1) = "05"

                My.Computer.Registry.CurrentUser.DeleteSubKey("Software\Battle.net\Configuration")

                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", gatewayValues)

            End If

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BNETIP", "eu.pathofdiablo.com")

        Else

            setgateway2Btn.Text = "Set Gateway"

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


End Class
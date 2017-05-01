Imports System.IO
Imports System.Net

Public Class Form1

    Dim updateAvailable As Boolean = False

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
                CustomGatewayTextBox.Enabled = True
            Else
                radioMain.Checked = True
                radioCustom.Checked = False
                CustomGatewayTextBox.Enabled = False
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

        If Not System.IO.File.Exists("Game.exe") Then
            MsgBox("Game.exe not found. Are you sure you installed the launcher into a D2 installation?")
            End
        End If

        Dim localCRC = GetCRC32("patch_d2.mpq")

        Dim d2version = FileVersionInfo.GetVersionInfo("Game.exe").FileVersion

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

        'disable qol stuff if not on 1.13d
        If Not d2version = "1, 0, 13, 64" Then
            qoladdoncbox.Checked = False
            qoladdoncbox.Enabled = False
            qoladdoncbox.Text = "QoL Features (1.13d only)"
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

        playBtn.BringToFront()

        handleSetCurrentGateway()

        Dim launchervonline As String = "https://raw.githubusercontent.com/GreenDude120/PoD-Launcher/master/launcherversion"
        Dim wclient As WebClient = New WebClient()
        Dim wreader As StreamReader = New StreamReader(wclient.OpenRead(launchervonline))
        Dim launchervonlinetxt As Integer
        launchervonlinetxt = wreader.ReadToEnd

        If Int(podlauncherlocalv.Text) >= launchervonlinetxt Then

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

        Dim localCRC = GetCRC32("patch_d2.mpq")

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

            If System.IO.File.Exists("patch_d2.mpq.bak") = True Then

                System.IO.File.Delete("patch_d2.mpq.bak")

            End If

            My.Computer.FileSystem.RenameFile("patch_d2.mpq", "patch_d2.mpq.bak")

            Dim patchclient As WebClient = New WebClient

            AddHandler patchclient.DownloadProgressChanged, AddressOf patchclient_ProgressChanged

            AddHandler patchclient.DownloadFileCompleted, AddressOf patchclient_DownloadCompleted

            patchclient.DownloadFileAsync(New Uri("https://raw.githubusercontent.com/GreenDude120/PoD-Launcher/master/patch_d2.mpq"), "patch_d2.mpq")

            playBtn.Text = "Update in Progress"


            playBtn.Enabled = False

        Else

            Dim d2 As New ProcessStartInfo

            If qoladdoncbox.Checked Then
                d2.FileName = "poddiablo.exe"
                If Not System.IO.File.Exists("poddiablo.exe") Then
                    MsgBox("poddiablo.exe not found. Please reinstall!")
                    End
                End If
                If Not System.IO.File.Exists("pod.exe") Then
                    MsgBox("pod.exe not found. Please reinstall!")
                    End
                End If
                If Not System.IO.File.Exists("pod.dll") Then
                    MsgBox("pod.dll.exe not found. Please reinstall!")
                    End
                End If
            Else
                d2.FileName = "Diablo II.exe"
                If Not System.IO.File.Exists("Game.exe") Then
                    MsgBox("Game.exe not found. Are you sure you installed the launcher into a D2 installation?")
                    End
                End If
                If Not System.IO.File.Exists("Diablo II.exe") Then
                    MsgBox("Diablo II.exe not found. Are you sure you installed the launcher into a D2 installation?")
                    End
                End If
            End If

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

            If radioMain.Checked Then
                If String.Compare("s.pathofdiablo.com", CustomGatewayTextBox.Text, True) <> 0 Then
                    'show error message and don't start the game
                    MsgBox("Choose a gateway option and click ""Set Gateway""" + Environment.NewLine + "After that you can start the game and start playing online.")
                    Return
                End If
            End If

            Me.Hide()                           'hide window, so that it doesn't look like it doesn't respond anymore
            Dim p As New Process
            p.StartInfo = d2
            p.Start()

            End

        End If

    End Sub

    Private Sub DEP_Only_Click(sender As Object, e As EventArgs) Handles DEP_Only.Click
        Try
            Dim wDEP As New StreamWriter("000aaaDEP.bat")
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
            Process.Start(".")
        Catch ex As Exception
            MsgBox("Error generating fix file, it's probably open")
        End Try

    End Sub

    Private Sub DEP_and_XP_SP2_Click(sender As Object, e As EventArgs) Handles DEP_and_XP_SP2.Click
        Try
            Dim wDEP As New StreamWriter("000aaaDEP+XP_SP2.bat")
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
            Process.Start(".")
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
        downloadfilter.DownloadFileAsync(New Uri(lootfilterurl.Text), "item.filter")
        MsgBox("item.filter was overwrote by " & lootfilterurl.Text)
    End Sub

    Private Sub resetcfg_Click(sender As Object, e As EventArgs) Handles resetcfg.Click
        Dim resetfilter As WebClient = New WebClient
        resetfilter.DownloadFileAsync(New Uri("http://pathofdiablo.com/item.filter"), "item.filter")
        MsgBox("item.filter was overwrote by http://pathofdiablo.com/item.filter")
    End Sub

    Private Sub setGatewayBtn_Click(sender As Object, e As EventArgs) Handles setGatewayBtn.Click

        Dim gatewayValues = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", Nothing)

        My.Computer.Registry.CurrentUser.DeleteSubKey("Software\Battle.net\Configuration")

        Dim newGatewayValues() As String

        If radioMain.Checked Then

            newGatewayValues = {"1009", "05", "uswest.battle.net", "8", "U.S.West", "useast.battle.net", "6", "U.S.East", "asia.battle.net", "-9", "Asia", "europe.battle.net", "-1", "Europe", "s.pathofdiablo.com", "6", "Path of Diablo"}
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BNETIP", "s.pathofdiablo.com")

        Else

            newGatewayValues = {"1009", "05", "uswest.battle.net", "8", "U.S.West", "useast.battle.net", "6", "U.S.East", "asia.battle.net", "-9", "Asia", "europe.battle.net", "-1", "Europe", CustomGatewayTextBox.Text, "6", "Path of Diablo"}
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BNETIP", CustomGatewayTextBox.Text)

        End If

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", newGatewayValues)

        handleSetCurrentGateway()

    End Sub

    Private Sub resoreDefaultGatewaysBtn_Click(sender As Object, e As EventArgs) Handles resoreDefaultGatewaysBtn.Click

        Dim defaultGatewayValues() As String = {"1009", "01", "uswest.battle.net", "8", "U.S.West", "useast.battle.net", "6", "U.S.East", "asia.battle.net", "-9", "Asia", "europe.battle.net", "-1", "Europe"}
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", defaultGatewayValues)

        If Not My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "BNETIP", Nothing) Is Nothing Then
            My.Computer.Registry.CurrentUser.OpenSubKey("Software\Blizzard Entertainment\Diablo II", True).DeleteValue("BNETIP")
        End If


        handleSetCurrentGateway()

    End Sub

    Private Sub radioCustom_CheckedChanged(sender As Object, e As EventArgs) Handles radioCustom.CheckedChanged

        If radioCustom.Checked = True Then
            CustomGatewayTextBox.Enabled = True
        Else
            CustomGatewayTextBox.Enabled = False
        End If

    End Sub

    Private Sub handleSetCurrentGateway()

        If Not My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", Nothing) Is Nothing Then

            Dim testMe = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", Nothing)
            If testMe.GetType() Is GetType(String()) Then

                Dim gatewayValues() As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Battle.net\Configuration", "Diablo II Battle.net gateways", Nothing)

                Dim currentRealm As Integer = CInt(gatewayValues(1)) - 1

                If gatewayValues.Length > (2 + currentRealm * 3) Then

                    Dim currentRealmAddress As String = gatewayValues(2 + currentRealm * 3)
                    CustomGatewayTextBox.Text = currentRealmAddress

                End If

            End If



        End If

    End Sub

End Class
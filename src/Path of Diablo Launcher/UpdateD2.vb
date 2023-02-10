Imports System.Net

Public Class UpdateD2

    Dim installpath As String

    Private Sub updateclient_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        updated2Bar.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Private Sub updateclient_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        Dim d2update As New ProcessStartInfo
        d2update.FileName = installpath & "LODPatch_113d.exe"
        Process.Start(d2update)

        DialogResult = Windows.Forms.DialogResult.OK

    End Sub
    Private Sub updated2Btn_Click(sender As Object, e As EventArgs) Handles updated2Btn.Click

        installPath = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Blizzard Entertainment\Diablo II", "InstallPath", Nothing)

        installpath = installpath.TrimEnd("\") & "\"

        Dim updateclient As WebClient = New WebClient

        AddHandler updateclient.DownloadProgressChanged, AddressOf updateclient_ProgressChanged

        AddHandler updateclient.DownloadFileCompleted, AddressOf updateclient_DownloadCompleted

        updateclient.DownloadFileAsync(New Uri("http://ftp.blizzard.com/pub/diablo2exp/patches/PC/LODPatch_113d.exe"), installPath & "LODPatch_113d.exe")

        updated2Btn.Text = "Update in Progress"

        updated2Btn.Enabled = False

    End Sub
End Class
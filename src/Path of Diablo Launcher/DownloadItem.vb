Public Class DownloadItem

    Private filename As String = ""
    Private filecrc As String = ""
    Private restartReq As Boolean = False
    Private linkDialog As Boolean = False
    Private dllinks As System.Collections.Generic.LinkedList(Of NamedLink) = New System.Collections.Generic.LinkedList(Of NamedLink)

    Property Name As String
        Get
            Return filename
        End Get
        Set(value As String)
            filename = value
        End Set
    End Property

    Property Crc As String
        Get
            Return filecrc
        End Get
        Set(value As String)
            filecrc = value
        End Set
    End Property

    Property RestartRequired As Boolean
        Get
            Return restartReq
        End Get
        Set(value As Boolean)
            restartReq = value
        End Set
    End Property

    Property ShowDialog As Boolean
        Get
            Return linkDialog
        End Get
        Set(value As Boolean)
            linkDialog = value
        End Set
    End Property

    ReadOnly Property Links As System.Collections.Generic.LinkedList(Of NamedLink)
        Get
            Return dllinks
        End Get
    End Property

    Public Sub AddLink(ByVal link As NamedLink)
        dllinks.AddLast(link)
    End Sub

End Class

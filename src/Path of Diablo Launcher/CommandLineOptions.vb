Public Class CommandLineOptions

    ' do not update
    Private NoUpdate_ As Boolean
    ' start after updating finished successfully
    Private StartOnUpdateSuccess_ As Boolean

    Property NoUpdate As Boolean
        Get
            Return NoUpdate_
        End Get
        Set(value As Boolean)
            NoUpdate_ = value
        End Set
    End Property

    Property StartOnUpdateSuccess As Boolean
        Get
            Return StartOnUpdateSuccess_
        End Get
        Set(value As Boolean)
            StartOnUpdateSuccess_ = value
        End Set
    End Property



    Public Sub ScanCommandLine(ByRef args As String())
        For Each arg As String In args
            Select Case arg
                Case "-no_update"
                    NoUpdate_ = True
                Case "-start_on_update_success"
                    StartOnUpdateSuccess_ = True
            End Select
        Next
    End Sub

End Class

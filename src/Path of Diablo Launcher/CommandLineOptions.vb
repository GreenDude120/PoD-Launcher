Public Class CommandLineOptions

    ' do not update
    Private NoUpdate_ As Boolean
    ' start after updating finished successfully
    Private StartOnUpdateSuccess_ As Boolean
    ' passthrough some args
    Private Passthrough_ As Boolean
    Private PassthroughArgs_ As String

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

    ReadOnly Property Passthrough As Boolean
        Get
            Return Passthrough_
        End Get
    End Property

    ReadOnly Property PassthroughArgs As String
        Get
            Return PassthroughArgs_
        End Get
    End Property



    Public Sub ScanCommandLine(ByRef args As String())
        For Each arg As String In args
            Select Case arg
                Case "-no_update"
                    NoUpdate_ = True
                Case "-start_on_update_success"
                    StartOnUpdateSuccess_ = True
                Case Else
                    Const lead As String = "-passthrough("
                    Const trail As String = ")"
                    If arg.StartsWith(lead) And arg.EndsWith(trail) Then
                        Passthrough_ = True

                        PassthroughArgs_ = arg.Substring(lead.Length, arg.Length - lead.Length - trail.Length)
                    End If
            End Select
        Next
    End Sub

End Class

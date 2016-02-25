Public Class classITworker
    Inherits classWorker
    Protected Shadows Const hourlyWage = 80
    Public Sub New(workerId As Integer, name As String, surname1 As String, surname2 As String, dni As String)
        MyBase.New(workerId, name, surname1, surname2, dni, New List(Of String) From {"hardware", "software"})
    End Sub

End Class

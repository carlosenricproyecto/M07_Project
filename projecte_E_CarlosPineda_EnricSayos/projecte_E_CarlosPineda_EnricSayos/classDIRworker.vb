Public Class classDIRworker
    Inherits classWorker
    Protected Shadows Const hourlyWage = 20
    Public Sub New(workerId As Integer, name As String, surname1 As String, surname2 As String, dni As String)
        MyBase.New(workerId, name, surname1, surname2, dni, New List(Of String) From {"relacions públiques"})
    End Sub

End Class

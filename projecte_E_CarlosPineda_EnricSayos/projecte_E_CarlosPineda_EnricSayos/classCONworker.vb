﻿Public Class classCONworker
    Inherits classWorker
    Protected Shadows Const houlyWage = 10
    Public Sub New(workerId As Integer, name As String, surname1 As String, surname2 As String, dni As String)
        MyBase.New(workerId, name, surname1, surname2, dni, New List(Of String) From {"comptabilitat"})
    End Sub





End Class

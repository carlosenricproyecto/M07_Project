Public MustInherit Class classWorker
    Protected workerId As Integer
    Protected name As String
    Protected surname1 As String
    Protected surname2 As String
    Protected dni As String
    Protected hourlyWage As Double
    Protected Const maxHours As Integer = 120

    Public Sub New(workerId As Integer, name As String, surname1 As String, surname2 As String, dni As String)
        Me.WorkerId1 = workerId
        Me.Name1 = name
        Me.Surname11 = surname1
        Me.Surname21 = surname2
        Me.Dni1 = dni
    End Sub

    Public Property WorkerId1 As Integer
        Get
            Return workerId
        End Get
        Set(value As Integer)
            workerId = value
        End Set
    End Property

    Public Property Name1 As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property Surname11 As String
        Get
            Return surname1
        End Get
        Set(value As String)
            surname1 = value
        End Set
    End Property

    Public Property Surname21 As String
        Get
            Return surname2
        End Get
        Set(value As String)
            surname2 = value
        End Set
    End Property

    Public Property Dni1 As String
        Get
            Return dni
        End Get
        Set(value As String)
            dni = value
        End Set
    End Property

    Public Property HourlyWage1 As Double
        Get
            Return hourlyWage
        End Get
        Set(value As Double)
            hourlyWage = value
        End Set
    End Property

End Class
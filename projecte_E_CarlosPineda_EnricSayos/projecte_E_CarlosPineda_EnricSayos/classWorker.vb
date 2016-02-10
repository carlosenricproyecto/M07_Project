Public Class classWorker
    Private workerId As Integer
    Private name As String
    Private surname1 As String
    Private surname2 As String
    Private dni As String
    Private category As String
    Private hourlyWage As Double
    Public Const maxHours As Integer = 120


    Public Sub New(workerId As Integer, name As String, surname1 As String, surname2 As String, dni As String, category As String, hourlyWage As Double)
        WorkerId1 = workerId
        Name1 = name
        Surname11 = surname1
        Surname21 = surname2
        Dni1 = dni
        Category1 = category
        HourlyWage1 = hourlyWage
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

    Public Property Category1 As String
        Get
            Return category
        End Get
        Set(value As String)
            category = value
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

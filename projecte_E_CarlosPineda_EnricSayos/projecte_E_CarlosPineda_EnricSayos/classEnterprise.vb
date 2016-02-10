Public Class classEnterprise
    Private enterpriseId As Integer
    Private name As String
    Private cif As String
    Private workerList As ArrayList
    Private courses As ArrayList
    Private enrollments As ArrayList

    Public Sub New(enterpriseId As Integer, name As String, cif As String)
        EnterpriseId1 = enterpriseId
        Name1 = name
        Cif1 = cif
        Me.workerList = New ArrayList
        Me.courses = New ArrayList
        Me.enrollments = New ArrayList
    End Sub

    Public Property EnterpriseId1 As Integer
        Get
            Return enterpriseId
        End Get
        Set(value As Integer)
            enterpriseId = value
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

    Public Property Cif1 As String
        Get
            Return cif
        End Get
        Set(value As String)
            cif = value
        End Set
    End Property

    Public Property WorkerList1 As ArrayList
        Get
            Return workerList
        End Get
        Set(value As ArrayList)
            workerList = value
        End Set
    End Property

    Public Property Courses1 As ArrayList
        Get
            Return courses
        End Get
        Set(value As ArrayList)
            courses = value
        End Set
    End Property

    Public Property Enrollments1 As ArrayList
        Get
            Return enrollments
        End Get
        Set(value As ArrayList)
            enrollments = value
        End Set
    End Property
End Class

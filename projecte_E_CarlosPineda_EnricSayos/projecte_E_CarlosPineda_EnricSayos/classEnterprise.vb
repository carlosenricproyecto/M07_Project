Imports projecte_E_CarlosPineda_EnricSayos

Public Class classEnterprise
    Private enterpriseId As Integer
    Private name As String
    Private cif As String
    Private workerList As List(Of classWorker)
    Private courses As List(Of classCourse)
    Private enrollments As List(Of classEnrollment)

    Public Sub New(enterpriseId As Integer, name As String, cif As String)
        EnterpriseId1 = enterpriseId
        Name1 = name
        Cif1 = cif
        Me.WorkerList1 = New List(Of classWorker)
        Me.Courses1 = New List(Of classCourse)
        Me.Enrollments1 = New List(Of classEnrollment)
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

    Public Property WorkerList1 As List(Of classWorker)
        Get
            Return workerList
        End Get
        Set(value As List(Of classWorker))
            workerList = value
        End Set
    End Property

    Public Property Courses1 As List(Of classCourse)
        Get
            Return courses
        End Get
        Set(value As List(Of classCourse))
            courses = value
        End Set
    End Property

    Public Property Enrollments1 As List(Of classEnrollment)
        Get
            Return enrollments
        End Get
        Set(value As List(Of classEnrollment))
            enrollments = value
        End Set
    End Property

    Public Sub addWorker(type As Integer, workerId As Integer, name As String, surname1 As String, surname2 As String, dni As String)
        Dim wor
        Select Case type
            Case 1
                'administrativo
                wor = New classADworker(workerId, name, surname1, surname2, dni)
            Case 2
                'contable
                wor = New classCONworker(workerId, name, surname1, surname2, dni)
            Case 3
                'directivo
                wor = New classDIRworker(workerId, name, surname1, surname2, dni)
            Case 4
                'informatico
                wor = New classITworker(workerId, name, surname1, surname2, dni)
            Case 5
                'transportista
                wor = New classTRworker(workerId, name, surname1, surname2, dni)
            Case Else
        End Select

    End Sub
End Class

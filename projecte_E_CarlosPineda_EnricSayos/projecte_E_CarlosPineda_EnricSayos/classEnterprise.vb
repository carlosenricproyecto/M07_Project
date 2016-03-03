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
                'info
                wor = New classITworker(workerId, name, surname1, surname2, dni)
            Case 2
                'admin
                wor = New classADworker(workerId, name, surname1, surname2, dni)
            Case 3
                'trans
                wor = New classTRworker(workerId, name, surname1, surname2, dni)
            Case 4
                'dir
                wor = New classDIRworker(workerId, name, surname1, surname2, dni)
            Case 5
                'contable
                wor = New classCONworker(workerId, name, surname1, surname2, dni)
            Case Else
        End Select
        Try
            Me.WorkerList1.Add(wor)
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Public Sub addCourse(courseId As Integer, courseName As String, courseHours As String, courseType As String, courseTheme As String, startDate As Date, endDate As Date, active As Boolean)
        Dim crs
        crs = New classCourse(courseId, courseName, courseHours, courseType, courseTheme, startDate, endDate, active)
        Try
            Me.Courses1.Add(crs)
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Public Sub doEnrollment(idEnrollment As Integer, worker As classWorker, course As classCourse, enrollmentYear As Date)
        Dim enr
        enr = New classEnrollment(idEnrollment, worker, course, enrollmentYear)
        Try
            Me.Enrollments1.Add(enr)
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub
End Class

Imports projecte_E_CarlosPineda_EnricSayos

Public Class classEnrollment
    Private idEnrollment As Integer
    Private worker As classWorker
    Private course As classCourse
    Private enrollmentYear As Date

    Public Sub New(idEnrollment As Integer, worker As classWorker, course As classCourse, enrollmentYear As Date)
        IdEnrollment1 = idEnrollment
        Worker1 = worker
        Course1 = course
        EnrollmentYear1 = enrollmentYear
    End Sub

    Public Property IdEnrollment1 As Integer
        Get
            Return idEnrollment
        End Get
        Set(value As Integer)
            idEnrollment = value
        End Set
    End Property

    Public Property Worker1 As classWorker
        Get
            Return worker
        End Get
        Set(value As classWorker)
            worker = value
        End Set
    End Property

    Public Property Course1 As classCourse
        Get
            Return course
        End Get
        Set(value As classCourse)
            course = value
        End Set
    End Property

    Public Property EnrollmentYear1 As Date
        Get
            Return enrollmentYear
        End Get
        Set(value As Date)
            enrollmentYear = value
        End Set
    End Property
End Class

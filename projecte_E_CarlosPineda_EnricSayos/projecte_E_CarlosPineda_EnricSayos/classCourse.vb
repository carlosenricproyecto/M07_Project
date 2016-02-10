Public Class classCourse
    Private courseId As Integer
    Private courseName As String
    Private courseHours As Integer
    Private courseType As String
    Private courseTheme As String
    Private startDate As Date
    Private endDate As Date
    Private active As Boolean

    Public Sub New(courseId As Integer, courseName As String, courseHours As Integer, courseType As String, courseTheme As String, startDate As Date, endDate As Date, active As Boolean)
        CourseId1 = courseId
        CourseName1 = courseName
        CourseHours1 = courseHours
        CourseType1 = courseType
        CourseTheme1 = courseTheme
        StartDate1 = startDate
        EndDate1 = endDate
        Active1 = active
    End Sub

    Public Property CourseId1 As Integer
        Get
            Return courseId
        End Get
        Set(value As Integer)
            courseId = value
        End Set
    End Property

    Public Property CourseName1 As String
        Get
            Return courseName
        End Get
        Set(value As String)
            courseName = value
        End Set
    End Property

    Public Property CourseHours1 As Integer
        Get
            Return courseHours
        End Get
        Set(value As Integer)
            courseHours = value
        End Set
    End Property

    Public Property CourseType1 As String
        Get
            Return courseType
        End Get
        Set(value As String)
            courseType = value
        End Set
    End Property

    Public Property CourseTheme1 As String
        Get
            Return courseTheme
        End Get
        Set(value As String)
            courseTheme = value
        End Set
    End Property

    Public Property StartDate1 As Date
        Get
            Return startDate
        End Get
        Set(value As Date)
            startDate = value
        End Set
    End Property

    Public Property EndDate1 As Date
        Get
            Return endDate
        End Get
        Set(value As Date)
            endDate = value
        End Set
    End Property

    Public Property Active1 As Boolean
        Get
            Return active
        End Get
        Set(value As Boolean)
            active = value
        End Set
    End Property
End Class

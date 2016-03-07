Public Class allCourses
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim text As String
            For i As Integer = 0 To entr.Courses1.Count - 1
                text = text & entr.Courses1(i).CourseName1 & " - " & entr.Courses1(i).CourseTheme1 & "<br>"
            Next
            Label1.Text = text
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("menu.aspx")
    End Sub
End Class
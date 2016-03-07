Public Class newCourse
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("menu.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            entr.addCourse(TextBox1.Text, TextBox2.Text, RadioButtonList1.SelectedValue, DropDownList1.SelectedValue, Calendar1.SelectedDate, Calendar2.SelectedDate, True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
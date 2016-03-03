Public Class newEnrollment
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            For i As Integer = 0 To entr.WorkerList1.Count - 1
                ListBox1.Items.Add(entr.WorkerList1(i).Name1)
            Next
            For i As Integer = 0 To entr.Courses1.Count - 1
                DropDownList1.Items.Add(entr.Courses1(i).CourseName1)
            Next
        End If
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Response.Redirect("menu.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not ListBox1.SelectedItem Is Nothing Then
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not ListBox2.SelectedItem Is Nothing Then
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cour As classCourse
            For i As Integer = 0 To entr.Courses1.Count - 1
                If DropDownList1.SelectedItem.Text = entr.Courses1(i).CourseName1 Then
                    cour = entr.Courses1(i)
                End If
            Next
            If Not cour Is Nothing Then
                Dim wrk As classWorker
                Dim id As Integer
                For j As Integer = 0 To ListBox2.Items.Count - 1
                    For k As Integer = 0 To entr.WorkerList1.Count - 1
                        If ListBox2.Items(j).Text = entr.WorkerList1(k).Name1 Then
                            wrk = entr.WorkerList1(k)
                            If entr.Enrollments1.Count > 0 Then
                                id = entr.Enrollments1(entr.Enrollments1.Count - 1).IdEnrollment1 + 1
                            Else
                                id = 0
                            End If
                            entr.doEnrollment(id, wrk, cour, New Date())
                        End If
                    Next
                Next
                For i As Integer = 0 To entr.Enrollments1.Count - 1
                    MsgBox(entr.Enrollments1(i).IdEnrollment1)
                    MsgBox(entr.Enrollments1(i).Course1.CourseName1)
                    MsgBox(entr.Enrollments1(i).Worker1.Name1)

                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class
Public Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("login") Is Nothing Then

            Dim enterprise As New classEnterprise(1, "Enterprise Of da Boss", "343234243K")

        Else

        End If

        Response.Redirect("login.aspx")

    End Sub

End Class
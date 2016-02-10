Public Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim enterprise As New classEnterprise(1, "Enterprise Of da Boss", "343234243K")
        Response.Redirect("login.aspx")

    End Sub

End Class
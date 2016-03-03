Public Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim enterprise As New classEnterprise(1, "Enterprise Of da Boss", "343234243K")
            populateEnterprise()
            Response.Redirect("menu.aspx")
        End If
    End Sub

End Class
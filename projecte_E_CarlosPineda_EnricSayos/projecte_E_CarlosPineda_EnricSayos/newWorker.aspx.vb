Public Class newWorker
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            For i = 0 To workerTypes.Count
                DropDownList1.Items.Add(workerTypes.Item(i))
            Next

        End If
    End Sub

End Class
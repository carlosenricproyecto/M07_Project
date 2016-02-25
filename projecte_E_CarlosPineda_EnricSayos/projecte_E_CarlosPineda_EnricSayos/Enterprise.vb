Public Module Enterprise
    Public entr As New classEnterprise(1, "enterprise", "15874684R")
    Public workerTypes As New List(Of String) From {"Informàtic", "Administratiu", "Transportista", "Gerent", "Comptable"}

    Public Sub populateEnterprise()
        entr.addWorker(1, 1, "infor", "mático", "junior", "00000000T")
        entr.addWorker(2, 2, "admin", "istra", "tivo", "12345678H")
        entr.addWorker(3, 3, "trans", "portis", "ta", "15936247K")
        entr.addWorker(4, 4, "ge", "ren", "te", "74856941P")
        entr.addWorker(5, 5, "con", "ta", "ble", "12349545L")

    End Sub

End Module

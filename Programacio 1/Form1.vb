Public Class Form1
    Dim objContenidos = New Contenido
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDepartamento.Items.AddRange(objContenidos.Departamento)
    End Sub

    Private Sub cboDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartamento.SelectedIndexChanged
        cboMunicipio.Items.Clear()
        cboMunicipio.Text = ""
        cboMunicipio.Items.AddRange(objContenidos.Municipio(cboDepartamento.SelectedIndex))
    End Sub
End Class

Class Contenido
    Public Departamento() As String = {"Seleccione un Dep.", "Usulután", "San Miguel", "La Union", "Morazan", "La union", "La paz", "La libertad", "San Salvador"}
    Public Municipio()() As String = {
        New String() {"Selecione un Mun."},
        New String() {"Seleccione un Mun.", "Usulután", "Jiquilisco", "Santa Elena", "Santa Maria", "Alegria", "Berlin", "California", "Santa Elena"},                       '1-> Usulután
        New String() {"Seleccione un Mun.", "San Miguel", "El Transito", "San Rafael Ote", "San Jorge", "Ciudad Barrios", "Comacaran", "Lolotique", "Nueva Guadalupe"},      '2->San Miguel
        New String() {"Seleccione un Mun.", "La Union", "Snta. Rosa de Lima", "Anamoros", "Bolivar", "Nueva Esparta", "Pasaquina", "San Alejo", "Yayantique"},               '3->La Union
        New String() {"Seleccione un Mun.", "Arambala", "Perquin", "Corinto", "Cacaopera", "Sn. Francisco Gotera", "Chilanga", "El rosario", "Joateca"},                     '4->Morazan
        New String() {"Seleccione Un Mun.", "La union", "Anamoros", "Bolivar", "Concepcion de oriente", "Conchagua", "El Carmen", "El sauce", "Lislique"},                   '5->La union
        New String() {"Seleccione un Mun.", "Zacatecoluca", "Cuyultitan", "El Rosario", "Jerusalen", "Mercedes la Ceiba", "Olocuilta", "Paraiso de Osiorio", "San Emigdio"}, '6->Lapaz
        New String() {"Seleccione un Mun.", "Santa Tecla", "Antig. Cuscatlan", "Chiltiupan", "Ciudaad Arce", "Colon", "Comasagua", "Huizucar", "Jayaque"},                   '7->La libertad
        New String() {"Seleciione un Mun.", "San Salvador", "Aguilares", "Apopa", "Ayutuxtepeque", "Ciudad Delgado", "Cuscatancingo", "El Paisnal", "Guazapa"}               '8->San Salvador
    }
End Class

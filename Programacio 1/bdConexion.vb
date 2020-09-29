Imports System.Data 'Importar las bibliotecas y clases necesarias para trabajar con ado.net
Imports System.Data.SqlClient 'Biblioteca de clases para SQl server y ado.net
Public Class bdConexion
    Dim MiConexion As New SqlConnection 'Conectarse a la BD
    Dim MiComand As New SqlCommand 'Ejecutar consultas o sentencias SQL.
    Dim MiAdapter As New SqlDataAdapter 'Es un intermediario entre la fuente de datos y la aplicacion... como un puente 
    Dim DS As New DataSet 'Representa una copia de la arquitectura (tablas, campos, indices, llaves, relaciones, datos, etc) de la BD en memoria

    Public Sub New()
        Dim CadenaConexion As String
        CadenaConexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bdSistema.mdf;Integrated Security=TrueDataSource"
        MiConexion.ConnectionString = CadenaConexion

        MiConexion.Open()
    End Sub

    Public Function ObtenerDatos()
        DS.Clear()
        MiComand.Connection = MiConexion
        MiComand.CommandText = "Selec * From Clientes"
        MiAdapter.SelectCommand = MiComand
        MiAdapter.Fill(DS, "Clientes")

        Return DS
    End Function
End Class

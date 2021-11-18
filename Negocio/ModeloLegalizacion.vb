Imports Persistencia
Imports Transversal

Public Class ModeloLegalizacion
    'Instancio objeto de persistencia del usuario
    Dim legalizacionPO As New LegalizacionPO
    'Creo atributos
    Private id_legalizacion
    Private estado

    'Inicializo los atributos
    Public Sub New(id_legalizacion As Object, estado As Object)
        Me.id_legalizacion = id_legalizacion
        Me.estado = estado
    End Sub

    'Creo una función para listar las legalizaciones pendientes
    Public Function ListarLegalizaciones(listar As String) As DataSet
        Return legalizacionPO.ListarLegalizaciones(listar)
    End Function

    'Creo una función para gestionar las legalizaciones
    Public Function GestionLegalizacion() As String
        Try
            legalizacionPO.GestionLegalizacion(id_legalizacion, estado)
            Return "La legalización ha sido " + estado.toLower()
        Catch ex As Exception
            Return "Error: " & ex.Message
        End Try
    End Function
End Class

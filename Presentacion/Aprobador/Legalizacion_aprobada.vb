Imports Negocio

Public Class Legalizacion_aprobada
    Private dataView As New DataView

    'Cargo las legalizaciones una vez ingresen al formulario
    Private Sub Legalizacion_aprobada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarLegalizaciones()
    End Sub

    'Metódo para cargar las legalizaciones en el DataGridView
    Private Sub ListarLegalizaciones()
        Dim modeloLegalizacion As New ModeloLegalizacion(id_legalizacion:=Nothing, estado:=Nothing)
        Dim resultado = modeloLegalizacion.ListarLegalizaciones("APROBADA")
        dataView.Table = resultado.Tables(0)
        DataGridList.DataSource = dataView
    End Sub

    'Filtro por consecutivo
    Private Sub txtConsecutivo_TextChanged(sender As Object, e As EventArgs) Handles txtConsecutivo.TextChanged
        dataView.RowFilter = String.Format("consecutivo Like '%{0}%'", txtConsecutivo.Text)
    End Sub

    'Filtro por fecha de gasto
    Private Sub txtFecha_TextChanged(sender As Object, e As EventArgs) Handles txtFecha.TextChanged
        dataView.RowFilter = String.Format("fecha_gasto Like '%{0}%'", txtFecha.Text)
    End Sub
End Class
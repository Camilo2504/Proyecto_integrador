Imports Negocio
Public Class Legalizacion_pendiente
    Private dataView As New DataView

    'Cargo las legalizaciones una vez ingresen al formulario
    Private Sub Legalizacion_pendiente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarLegalizaciones()
    End Sub

    'Metódo para cargar las legalizaciones en el DataGridView
    Private Sub ListarLegalizaciones()
        Dim modeloLegalizacion As New ModeloLegalizacion(id_legalizacion:=Nothing, estado:=Nothing)
        Dim resultado = modeloLegalizacion.ListarLegalizaciones("PENDIENTE")
        dataView.Table = resultado.Tables(0)
        DataGridList.DataSource = dataView
    End Sub

    'Cuando seleccionen la celda
    Private Sub DataGridList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridList.CellClick
        Dim i As Integer
        i = DataGridList.CurrentRow.Index
        lbID.Text = DataGridList.Item(0, i).Value()
        btnAprobar.Enabled = True
        btnRechazar.Enabled = True
    End Sub

    'Aprobar legalización
    Private Sub btnAprobar_Click(sender As Object, e As EventArgs) Handles btnAprobar.Click
        If MessageBox.Show("¿Está seguro que desea aprobar esta legalización?", "Advertencia",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim modeloLegalizacion As New ModeloLegalizacion(id_legalizacion:=lbID.Text, estado:="APROBADA")
            Dim resultado = modeloLegalizacion.GestionLegalizacion()
            MessageBox.Show(resultado)
            ListarLegalizaciones()
        End If
    End Sub

    'Rechazar legalización
    Private Sub btnRechazar_Click(sender As Object, e As EventArgs) Handles btnRechazar.Click
        If MessageBox.Show("¿Está seguro que desea rechazar esta legalización?", "Advertencia",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim modeloLegalizacion As New ModeloLegalizacion(id_legalizacion:=lbID.Text, estado:="RECHAZADA")
            Dim resultado = modeloLegalizacion.GestionLegalizacion()
            MessageBox.Show(resultado)
            ListarLegalizaciones()
        End If
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
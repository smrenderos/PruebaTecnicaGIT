Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGridOrd()

        DataGridViewOrd.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewOrd.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewOrd.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewOrd.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridViewOrd.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewOrd.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewOrd.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewOrd.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewOrd.Columns(10).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewOrd.Columns(11).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridViewOrd.Columns(2).Visible = False
        DataGridViewOrd.Columns(3).Visible = False
        DataGridViewOrd.Columns(5).Visible = False
        DataGridViewOrd.Columns(6).Visible = False
        DataGridViewOrd.Columns(7).Visible = False
        DataGridViewOrd.Columns(8).Visible = False

    End Sub
    Private Sub ActualizarGridOrd()
        Try
            Consultar("SELECT A.ID_ORDEN AS ""No de orden"",A.NOMBRE_CLIENTE AS ""Solicitante"",A.ID_PRODUCTO AS ""CodigoP"",NVL(B.NOMBRE_PRODUCTO,'No existe en catálogo') AS ""NombreP"",A.CANTIDAD AS ""Cantidad"",A.FECHA_PEDIDO AS ""FechaPedido"",A.DIRECCION AS ""Direccion"",A.COMENTARIOS AS ""Comentarios"",A.ESTADO AS ""Estado"",B.PRECIO AS ""Precio unitario"",(A.CANTIDAD*B.PRECIO) AS ""Total"",A.USUARIO AS ""Usuario"" FROM ORDENES A LEFT JOIN PRODUCTOS B ON B.ID_PRODUCTO = A.ID_PRODUCTO ORDER BY A.ID_ORDEN DESC", DataGridViewOrd)
            Consultar("SELECT ID_PRODUCTO FROM PRODUCTOS", textOrdProducto)
            textOrdProducto.DisplayMember = "ID_PRODUCTO"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonOrdNueva_Click(sender As Object, e As EventArgs) Handles ButtonOrdNueva.Click
        textOrdID.Text = ""
        textOrdCliente.Clear()
        textOrdProducto.Text = Nothing
        textOrdCantidad.Clear()
        DateTimePicker.Value = Date.Now()
        textOrdDireccion.Clear()
        textOrdComentarios.Clear()
        textOrdEstado.Text = "Pendiente"
    End Sub
    Private Sub ButtonOrdAgregar_Click(sender As Object, e As EventArgs) Handles ButtonOrdAgregar.Click
        Try
            Insertar("INSERT INTO ORDENES VALUES(ORDENES_SEQ.nextval,'" & textOrdCliente.Text & "','" & textOrdProducto.Text & "','" & textOrdCantidad.Text & "','" & DateTimePicker.Value.Date & "','" & textOrdDireccion.Text & "','" & textOrdComentarios.Text & "','" & textOrdEstado.Text & "','" & usuarioLogin & "')")
            ActualizarGridOrd()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonOrdModificar_Click(sender As Object, e As EventArgs) Handles ButtonOrdModificar.Click
        Try
            If textOrdID.Text <> "0" And textOrdID.Text <> "" Then
                Actualizar("UPDATE ORDENES SET NOMBRE_CLIENTE='" & textOrdCliente.Text & "',ID_PRODUCTO='" & textOrdProducto.Text & "',CANTIDAD='" & textOrdCantidad.Text & "',FECHA_PEDIDO='" & DateTimePicker.Value.Date & "',DIRECCION='" & textOrdDireccion.Text & "',COMENTARIOS='" & textOrdComentarios.Text & "',ESTADO='" & textOrdEstado.Text & "' WHERE ID_ORDEN='" & textOrdID.Text & "'")
                ActualizarGridOrd()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonOrdEliminar_Click(sender As Object, e As EventArgs) Handles ButtonOrdEliminar.Click
        Try
            If MessageBox.Show("Desea eliminar esta Orden?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Eliminar("DELETE FROM ORDENES WHERE ID_ORDEN='" & textOrdID.Text & "'")
                ActualizarGridOrd()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub DataGridViewOrd_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewOrd.CellEnter
        If DataGridViewOrd.RowCount > 0 Then
            textOrdID.Text = DataGridViewOrd.CurrentRow.Cells(0).Value
            textOrdCliente.Text = DataGridViewOrd.CurrentRow.Cells(1).Value
            textOrdProducto.Text = DataGridViewOrd.CurrentRow.Cells(2).Value
            textOrdCantidad.Text = DataGridViewOrd.CurrentRow.Cells(4).Value
            DateTimePicker.Value = DataGridViewOrd.CurrentRow.Cells(5).Value
            textOrdDireccion.Text = DataGridViewOrd.CurrentRow.Cells(6).Value
            textOrdComentarios.Text = DataGridViewOrd.CurrentRow.Cells(7).Value
            textOrdEstado.Text = DataGridViewOrd.CurrentRow.Cells(8).Value
        End If
    End Sub
    Private Sub ButtonOrdAministrar_Click(sender As Object, e As EventArgs) Handles ButtonOrdAministrar.Click
        Productos.Show()
    End Sub

    Private Sub CambiarUsuario_Click(sender As Object, e As EventArgs) Handles CambiarUsuario.Click
        Me.Close()
        Login.Show()
        Productos.Close()
    End Sub

    Private Sub Principal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Show()
        Productos.Close()
    End Sub
End Class
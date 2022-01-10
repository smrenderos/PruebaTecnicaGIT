Public Class Productos
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGridProd()
    End Sub
    Private Sub ActualizarGridProd()
        Try
            Consultar("SELECT ID_PRODUCTO AS ID, NOMBRE_PRODUCTO AS ""Nombre"", CANTIDAD_PORCIONES AS ""Porciones"", DESCRIPCION AS ""Descripción"", PRECIO AS ""Precio"", TAMAÑO AS ""Tamaño"" FROM PRODUCTOS ORDER BY ID_PRODUCTO DESC", DataGridViewProd)
            Consultar("SELECT ID_PRODUCTO FROM PRODUCTOS", Principal.textOrdProducto)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub buttonProdNuevo_Click(sender As Object, e As EventArgs) Handles buttonProdNuevo.Click
        textProdID.Text = ""
        textProdNombre.Clear()
        textProdcantidad.Clear()
        textProdDescripcion.Clear()
        textProdPrecio.Clear()
        textProdTamaño.Text = "Personal"
    End Sub
    Private Sub buttonProdAgregar_Click(sender As Object, e As EventArgs) Handles buttonProdAgregar.Click
        Try
            Insertar("INSERT INTO PRODUCTOS(ID_PRODUCTO,NOMBRE_PRODUCTO,CANTIDAD_PORCIONES,DESCRIPCION,PRECIO,TAMAÑO) VALUES(PRODUCTOS_SEQ.nextval,'" & textProdNombre.Text & "','" & textProdcantidad.Text & "','" & textProdDescripcion.Text & "','" & textProdPrecio.Text & "','" & textProdTamaño.Text & "')")
            ActualizarGridProd()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub buttonProdModificar_Click(sender As Object, e As EventArgs) Handles buttonProdModificar.Click
        Try
            If textProdID.Text <> "0" And textProdID.Text <> "" Then
                Actualizar("UPDATE PRODUCTOS SET NOMBRE_PRODUCTO='" & textProdNombre.Text & "',CANTIDAD_PORCIONES='" & textProdcantidad.Text & "',DESCRIPCION='" & textProdDescripcion.Text & "',PRECIO='" & textProdPrecio.Text & "',TAMAÑO='" & textProdTamaño.Text & "' WHERE ID_PRODUCTO='" & textProdID.Text & "'")
                ActualizarGridProd()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub buttonProdEliminar_Click(sender As Object, e As EventArgs) Handles buttonProdEliminar.Click
        Try
            If MessageBox.Show("Desea eliminar este Producto?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Eliminar("DELETE FROM PRODUCTOS WHERE ID_PRODUCTO='" & textProdID.Text & "'")
                ActualizarGridProd()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub DataGridViewProd_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProd.CellEnter
        If DataGridViewProd.RowCount > 0 Then
            textProdID.Text = DataGridViewProd.CurrentRow.Cells(0).Value
            textProdNombre.Text = DataGridViewProd.CurrentRow.Cells(1).Value
            textProdcantidad.Text = DataGridViewProd.CurrentRow.Cells(2).Value
            textProdDescripcion.Text = DataGridViewProd.CurrentRow.Cells(3).Value
            textProdPrecio.Text = DataGridViewProd.CurrentRow.Cells(4).Value
            textProdTamaño.Text = DataGridViewProd.CurrentRow.Cells(5).Value
        End If
    End Sub

End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewOrd = New System.Windows.Forms.DataGridView()
        Me.textOrdProducto = New System.Windows.Forms.ComboBox()
        Me.textOrdEstado = New System.Windows.Forms.ComboBox()
        Me.ButtonOrdAministrar = New System.Windows.Forms.Button()
        Me.ButtonOrdEliminar = New System.Windows.Forms.Button()
        Me.ButtonOrdModificar = New System.Windows.Forms.Button()
        Me.ButtonOrdAgregar = New System.Windows.Forms.Button()
        Me.ButtonOrdNueva = New System.Windows.Forms.Button()
        Me.textOrdCantidad = New System.Windows.Forms.TextBox()
        Me.textOrdComentarios = New System.Windows.Forms.TextBox()
        Me.textOrdDireccion = New System.Windows.Forms.TextBox()
        Me.textOrdCliente = New System.Windows.Forms.TextBox()
        Me.textOrdID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CambiarUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewOrd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker.Location = New System.Drawing.Point(610, 79)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(116, 25)
        Me.DateTimePicker.TabIndex = 63
        '
        'DataGridViewOrd
        '
        Me.DataGridViewOrd.AllowUserToAddRows = False
        Me.DataGridViewOrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewOrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOrd.Location = New System.Drawing.Point(44, 289)
        Me.DataGridViewOrd.Name = "DataGridViewOrd"
        Me.DataGridViewOrd.RowHeadersVisible = False
        Me.DataGridViewOrd.Size = New System.Drawing.Size(775, 284)
        Me.DataGridViewOrd.TabIndex = 62
        '
        'textOrdProducto
        '
        Me.textOrdProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.textOrdProducto.FormattingEnabled = True
        Me.textOrdProducto.Location = New System.Drawing.Point(200, 147)
        Me.textOrdProducto.Name = "textOrdProducto"
        Me.textOrdProducto.Size = New System.Drawing.Size(209, 21)
        Me.textOrdProducto.TabIndex = 61
        '
        'textOrdEstado
        '
        Me.textOrdEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.textOrdEstado.FormattingEnabled = True
        Me.textOrdEstado.Items.AddRange(New Object() {"Pendiente", "Entregada"})
        Me.textOrdEstado.Location = New System.Drawing.Point(610, 181)
        Me.textOrdEstado.Name = "textOrdEstado"
        Me.textOrdEstado.Size = New System.Drawing.Size(209, 21)
        Me.textOrdEstado.TabIndex = 60
        '
        'ButtonOrdAministrar
        '
        Me.ButtonOrdAministrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOrdAministrar.Location = New System.Drawing.Point(669, 234)
        Me.ButtonOrdAministrar.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonOrdAministrar.Name = "ButtonOrdAministrar"
        Me.ButtonOrdAministrar.Size = New System.Drawing.Size(150, 30)
        Me.ButtonOrdAministrar.TabIndex = 59
        Me.ButtonOrdAministrar.Text = "Administrar Productos"
        Me.ButtonOrdAministrar.UseVisualStyleBackColor = True
        '
        'ButtonOrdEliminar
        '
        Me.ButtonOrdEliminar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOrdEliminar.Location = New System.Drawing.Point(408, 234)
        Me.ButtonOrdEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonOrdEliminar.Name = "ButtonOrdEliminar"
        Me.ButtonOrdEliminar.Size = New System.Drawing.Size(114, 30)
        Me.ButtonOrdEliminar.TabIndex = 58
        Me.ButtonOrdEliminar.Text = "Eliminar Orden"
        Me.ButtonOrdEliminar.UseVisualStyleBackColor = True
        '
        'ButtonOrdModificar
        '
        Me.ButtonOrdModificar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOrdModificar.Location = New System.Drawing.Point(286, 234)
        Me.ButtonOrdModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonOrdModificar.Name = "ButtonOrdModificar"
        Me.ButtonOrdModificar.Size = New System.Drawing.Size(114, 30)
        Me.ButtonOrdModificar.TabIndex = 57
        Me.ButtonOrdModificar.Text = "Modificar Orden"
        Me.ButtonOrdModificar.UseVisualStyleBackColor = True
        '
        'ButtonOrdAgregar
        '
        Me.ButtonOrdAgregar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOrdAgregar.Location = New System.Drawing.Point(165, 234)
        Me.ButtonOrdAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonOrdAgregar.Name = "ButtonOrdAgregar"
        Me.ButtonOrdAgregar.Size = New System.Drawing.Size(114, 30)
        Me.ButtonOrdAgregar.TabIndex = 56
        Me.ButtonOrdAgregar.Text = "Agregar Orden"
        Me.ButtonOrdAgregar.UseVisualStyleBackColor = True
        '
        'ButtonOrdNueva
        '
        Me.ButtonOrdNueva.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOrdNueva.Location = New System.Drawing.Point(44, 234)
        Me.ButtonOrdNueva.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonOrdNueva.Name = "ButtonOrdNueva"
        Me.ButtonOrdNueva.Size = New System.Drawing.Size(114, 30)
        Me.ButtonOrdNueva.TabIndex = 55
        Me.ButtonOrdNueva.Text = "Limpiar"
        Me.ButtonOrdNueva.UseVisualStyleBackColor = True
        '
        'textOrdCantidad
        '
        Me.textOrdCantidad.Location = New System.Drawing.Point(200, 181)
        Me.textOrdCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.textOrdCantidad.Name = "textOrdCantidad"
        Me.textOrdCantidad.Size = New System.Drawing.Size(209, 20)
        Me.textOrdCantidad.TabIndex = 53
        '
        'textOrdComentarios
        '
        Me.textOrdComentarios.Location = New System.Drawing.Point(610, 147)
        Me.textOrdComentarios.Margin = New System.Windows.Forms.Padding(4)
        Me.textOrdComentarios.Multiline = True
        Me.textOrdComentarios.Name = "textOrdComentarios"
        Me.textOrdComentarios.Size = New System.Drawing.Size(209, 25)
        Me.textOrdComentarios.TabIndex = 54
        '
        'textOrdDireccion
        '
        Me.textOrdDireccion.Location = New System.Drawing.Point(610, 113)
        Me.textOrdDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.textOrdDireccion.Name = "textOrdDireccion"
        Me.textOrdDireccion.Size = New System.Drawing.Size(209, 20)
        Me.textOrdDireccion.TabIndex = 52
        '
        'textOrdCliente
        '
        Me.textOrdCliente.Location = New System.Drawing.Point(200, 113)
        Me.textOrdCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.textOrdCliente.Name = "textOrdCliente"
        Me.textOrdCliente.Size = New System.Drawing.Size(209, 20)
        Me.textOrdCliente.TabIndex = 51
        '
        'textOrdID
        '
        Me.textOrdID.Enabled = False
        Me.textOrdID.Location = New System.Drawing.Point(200, 79)
        Me.textOrdID.Margin = New System.Windows.Forms.Padding(4)
        Me.textOrdID.Name = "textOrdID"
        Me.textOrdID.ReadOnly = True
        Me.textOrdID.Size = New System.Drawing.Size(116, 20)
        Me.textOrdID.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(456, 181)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 17)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Estado de Orden"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(456, 147)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 17)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Comentarios"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(456, 113)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 17)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Dirección de Envío"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(456, 83)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 17)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Fecha de Orden"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 181)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 147)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 17)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Código de Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 17)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Nombre del Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "No de Orden"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.CambiarUsuario)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(863, 52)
        Me.Panel1.TabIndex = 41
        '
        'CambiarUsuario
        '
        Me.CambiarUsuario.AutoSize = True
        Me.CambiarUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CambiarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CambiarUsuario.Location = New System.Drawing.Point(748, 14)
        Me.CambiarUsuario.Name = "CambiarUsuario"
        Me.CambiarUsuario.Size = New System.Drawing.Size(84, 13)
        Me.CambiarUsuario.TabIndex = 42
        Me.CambiarUsuario.Text = "Cambiar Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(11, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Administración de Ordenes de Pizza"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 599)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.DataGridViewOrd)
        Me.Controls.Add(Me.textOrdProducto)
        Me.Controls.Add(Me.textOrdEstado)
        Me.Controls.Add(Me.ButtonOrdAministrar)
        Me.Controls.Add(Me.ButtonOrdEliminar)
        Me.Controls.Add(Me.ButtonOrdModificar)
        Me.Controls.Add(Me.ButtonOrdAgregar)
        Me.Controls.Add(Me.ButtonOrdNueva)
        Me.Controls.Add(Me.textOrdCantidad)
        Me.Controls.Add(Me.textOrdComentarios)
        Me.Controls.Add(Me.textOrdDireccion)
        Me.Controls.Add(Me.textOrdCliente)
        Me.Controls.Add(Me.textOrdID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Principal"
        Me.Text = "Principal"
        CType(Me.DataGridViewOrd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents DataGridViewOrd As DataGridView
    Friend WithEvents textOrdProducto As ComboBox
    Friend WithEvents textOrdEstado As ComboBox
    Friend WithEvents ButtonOrdAministrar As Button
    Friend WithEvents ButtonOrdEliminar As Button
    Friend WithEvents ButtonOrdModificar As Button
    Friend WithEvents ButtonOrdAgregar As Button
    Friend WithEvents ButtonOrdNueva As Button
    Friend WithEvents textOrdCantidad As TextBox
    Friend WithEvents textOrdComentarios As TextBox
    Friend WithEvents textOrdDireccion As TextBox
    Friend WithEvents textOrdCliente As TextBox
    Friend WithEvents textOrdID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CambiarUsuario As Label
    Friend WithEvents Label1 As Label
End Class

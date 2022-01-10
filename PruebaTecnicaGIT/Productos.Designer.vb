<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textProdTamaño = New System.Windows.Forms.ComboBox()
        Me.DataGridViewProd = New System.Windows.Forms.DataGridView()
        Me.buttonProdEliminar = New System.Windows.Forms.Button()
        Me.buttonProdModificar = New System.Windows.Forms.Button()
        Me.buttonProdNuevo = New System.Windows.Forms.Button()
        Me.buttonProdAgregar = New System.Windows.Forms.Button()
        Me.textProdPrecio = New System.Windows.Forms.TextBox()
        Me.textProdDescripcion = New System.Windows.Forms.TextBox()
        Me.textProdcantidad = New System.Windows.Forms.TextBox()
        Me.textProdNombre = New System.Windows.Forms.TextBox()
        Me.textProdID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(554, 40)
        Me.Panel1.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Catálogo de Pizza"
        '
        'textProdTamaño
        '
        Me.textProdTamaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.textProdTamaño.FormattingEnabled = True
        Me.textProdTamaño.Items.AddRange(New Object() {"Personal", "Mediana", "Familiar", "Extra Grande"})
        Me.textProdTamaño.Location = New System.Drawing.Point(193, 227)
        Me.textProdTamaño.Name = "textProdTamaño"
        Me.textProdTamaño.Size = New System.Drawing.Size(180, 21)
        Me.textProdTamaño.TabIndex = 57
        '
        'DataGridViewProd
        '
        Me.DataGridViewProd.AllowUserToAddRows = False
        Me.DataGridViewProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProd.Location = New System.Drawing.Point(30, 263)
        Me.DataGridViewProd.Name = "DataGridViewProd"
        Me.DataGridViewProd.RowHeadersVisible = False
        Me.DataGridViewProd.Size = New System.Drawing.Size(481, 170)
        Me.DataGridViewProd.TabIndex = 56
        '
        'buttonProdEliminar
        '
        Me.buttonProdEliminar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonProdEliminar.Location = New System.Drawing.Point(423, 180)
        Me.buttonProdEliminar.Name = "buttonProdEliminar"
        Me.buttonProdEliminar.Size = New System.Drawing.Size(88, 27)
        Me.buttonProdEliminar.TabIndex = 55
        Me.buttonProdEliminar.Text = "Eliminar"
        Me.buttonProdEliminar.UseVisualStyleBackColor = True
        '
        'buttonProdModificar
        '
        Me.buttonProdModificar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonProdModificar.Location = New System.Drawing.Point(423, 147)
        Me.buttonProdModificar.Name = "buttonProdModificar"
        Me.buttonProdModificar.Size = New System.Drawing.Size(88, 27)
        Me.buttonProdModificar.TabIndex = 54
        Me.buttonProdModificar.Text = "Modificar"
        Me.buttonProdModificar.UseVisualStyleBackColor = True
        '
        'buttonProdNuevo
        '
        Me.buttonProdNuevo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonProdNuevo.Location = New System.Drawing.Point(423, 81)
        Me.buttonProdNuevo.Name = "buttonProdNuevo"
        Me.buttonProdNuevo.Size = New System.Drawing.Size(88, 27)
        Me.buttonProdNuevo.TabIndex = 52
        Me.buttonProdNuevo.Text = "Limpiar"
        Me.buttonProdNuevo.UseVisualStyleBackColor = True
        '
        'buttonProdAgregar
        '
        Me.buttonProdAgregar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonProdAgregar.Location = New System.Drawing.Point(423, 114)
        Me.buttonProdAgregar.Name = "buttonProdAgregar"
        Me.buttonProdAgregar.Size = New System.Drawing.Size(88, 27)
        Me.buttonProdAgregar.TabIndex = 53
        Me.buttonProdAgregar.Text = "Agregar"
        Me.buttonProdAgregar.UseVisualStyleBackColor = True
        '
        'textProdPrecio
        '
        Me.textProdPrecio.Location = New System.Drawing.Point(193, 201)
        Me.textProdPrecio.Name = "textProdPrecio"
        Me.textProdPrecio.Size = New System.Drawing.Size(180, 20)
        Me.textProdPrecio.TabIndex = 50
        '
        'textProdDescripcion
        '
        Me.textProdDescripcion.Location = New System.Drawing.Point(193, 135)
        Me.textProdDescripcion.Multiline = True
        Me.textProdDescripcion.Name = "textProdDescripcion"
        Me.textProdDescripcion.Size = New System.Drawing.Size(180, 60)
        Me.textProdDescripcion.TabIndex = 49
        '
        'textProdcantidad
        '
        Me.textProdcantidad.Location = New System.Drawing.Point(193, 108)
        Me.textProdcantidad.Name = "textProdcantidad"
        Me.textProdcantidad.Size = New System.Drawing.Size(180, 20)
        Me.textProdcantidad.TabIndex = 51
        '
        'textProdNombre
        '
        Me.textProdNombre.Location = New System.Drawing.Point(193, 82)
        Me.textProdNombre.Name = "textProdNombre"
        Me.textProdNombre.Size = New System.Drawing.Size(180, 20)
        Me.textProdNombre.TabIndex = 48
        '
        'textProdID
        '
        Me.textProdID.Enabled = False
        Me.textProdID.Location = New System.Drawing.Point(193, 56)
        Me.textProdID.Name = "textProdID"
        Me.textProdID.ReadOnly = True
        Me.textProdID.Size = New System.Drawing.Size(100, 20)
        Me.textProdID.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 17)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Tamaño"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 17)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Nombre de Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 17)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Cantidad de Porciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 17)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "ID"
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.textProdTamaño)
        Me.Controls.Add(Me.DataGridViewProd)
        Me.Controls.Add(Me.buttonProdEliminar)
        Me.Controls.Add(Me.buttonProdModificar)
        Me.Controls.Add(Me.buttonProdNuevo)
        Me.Controls.Add(Me.buttonProdAgregar)
        Me.Controls.Add(Me.textProdPrecio)
        Me.Controls.Add(Me.textProdDescripcion)
        Me.Controls.Add(Me.textProdcantidad)
        Me.Controls.Add(Me.textProdNombre)
        Me.Controls.Add(Me.textProdID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Productos"
        Me.Text = "Productos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents textProdTamaño As ComboBox
    Friend WithEvents DataGridViewProd As DataGridView
    Friend WithEvents buttonProdEliminar As Button
    Friend WithEvents buttonProdModificar As Button
    Friend WithEvents buttonProdNuevo As Button
    Friend WithEvents buttonProdAgregar As Button
    Friend WithEvents textProdPrecio As TextBox
    Friend WithEvents textProdDescripcion As TextBox
    Friend WithEvents textProdcantidad As TextBox
    Friend WithEvents textProdNombre As TextBox
    Friend WithEvents textProdID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class

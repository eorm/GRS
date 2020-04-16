<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Manifiesto2
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
        Me.Dgvimportacion = New System.Windows.Forms.DataGridView()
        Me.DSimport = New System.Data.DataSet()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.Dgvimportacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSimport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgvimportacion
        '
        Me.Dgvimportacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvimportacion.Location = New System.Drawing.Point(7, 12)
        Me.Dgvimportacion.Name = "Dgvimportacion"
        Me.Dgvimportacion.Size = New System.Drawing.Size(721, 468)
        Me.Dgvimportacion.TabIndex = 0
        '
        'DSimport
        '
        Me.DSimport.DataSetName = "NewDataSet"
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Enabled = False
        Me.Button2.Image = Global.AppReports.My.Resources.Resources.zEdit2
        Me.Button2.Location = New System.Drawing.Point(378, 499)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 59)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Calcular Flete"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Image = Global.AppReports.My.Resources.Resources.znuevo1
        Me.Button1.Location = New System.Drawing.Point(258, 499)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 59)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Importar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(237, 486)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 88)
        Me.Panel1.TabIndex = 3
        '
        'Frm_Manifiesto2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(741, 586)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Dgvimportacion)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Frm_Manifiesto2"
        Me.Text = "Frm_Manifiesto2"
        CType(Me.Dgvimportacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSimport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dgvimportacion As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DSimport As System.Data.DataSet
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class

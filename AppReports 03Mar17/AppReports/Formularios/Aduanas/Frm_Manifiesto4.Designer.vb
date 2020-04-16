<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Manifiesto4
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
        Me.DgvImportacion = New System.Windows.Forms.DataGridView()
        Me.DgvResult = New System.Windows.Forms.DataGridView()
        Me.DTPDateimportpkg = New System.Windows.Forms.DateTimePicker()
        Me.BtnImportar = New System.Windows.Forms.Button()
        Me.BtnCalcularFlete = New System.Windows.Forms.Button()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.DSImport = New System.Data.DataSet()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        CType(Me.DgvImportacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSImport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvImportacion
        '
        Me.DgvImportacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvImportacion.Location = New System.Drawing.Point(29, 121)
        Me.DgvImportacion.Name = "DgvImportacion"
        Me.DgvImportacion.Size = New System.Drawing.Size(616, 129)
        Me.DgvImportacion.TabIndex = 0
        '
        'DgvResult
        '
        Me.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvResult.Location = New System.Drawing.Point(29, 256)
        Me.DgvResult.Name = "DgvResult"
        Me.DgvResult.Size = New System.Drawing.Size(616, 129)
        Me.DgvResult.TabIndex = 1
        '
        'DTPDateimportpkg
        '
        Me.DTPDateimportpkg.Location = New System.Drawing.Point(44, 29)
        Me.DTPDateimportpkg.Name = "DTPDateimportpkg"
        Me.DTPDateimportpkg.Size = New System.Drawing.Size(200, 20)
        Me.DTPDateimportpkg.TabIndex = 2
        '
        'BtnImportar
        '
        Me.BtnImportar.Location = New System.Drawing.Point(357, 45)
        Me.BtnImportar.Name = "BtnImportar"
        Me.BtnImportar.Size = New System.Drawing.Size(75, 23)
        Me.BtnImportar.TabIndex = 3
        Me.BtnImportar.Text = "Importacion"
        Me.BtnImportar.UseVisualStyleBackColor = True
        '
        'BtnCalcularFlete
        '
        Me.BtnCalcularFlete.Location = New System.Drawing.Point(458, 45)
        Me.BtnCalcularFlete.Name = "BtnCalcularFlete"
        Me.BtnCalcularFlete.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcularFlete.TabIndex = 4
        Me.BtnCalcularFlete.Text = "Calculo Flete"
        Me.BtnCalcularFlete.UseVisualStyleBackColor = True
        '
        'BtnExportar
        '
        Me.BtnExportar.Location = New System.Drawing.Point(569, 44)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(75, 23)
        Me.BtnExportar.TabIndex = 5
        Me.BtnExportar.Text = "Exportar"
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'DSImport
        '
        Me.DSImport.DataSetName = "NewDataSet"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(582, 83)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(63, 20)
        Me.TxtTotal.TabIndex = 6
        '
        'Frm_Manifiesto4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 410)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.BtnCalcularFlete)
        Me.Controls.Add(Me.BtnImportar)
        Me.Controls.Add(Me.DTPDateimportpkg)
        Me.Controls.Add(Me.DgvResult)
        Me.Controls.Add(Me.DgvImportacion)
        Me.Name = "Frm_Manifiesto4"
        Me.Text = "Frm_Manifiesto4"
        CType(Me.DgvImportacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSImport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvImportacion As System.Windows.Forms.DataGridView
    Friend WithEvents DgvResult As System.Windows.Forms.DataGridView
    Friend WithEvents DTPDateimportpkg As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnImportar As System.Windows.Forms.Button
    Friend WithEvents BtnCalcularFlete As System.Windows.Forms.Button
    Friend WithEvents BtnExportar As System.Windows.Forms.Button
    Friend WithEvents DSImport As System.Data.DataSet
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MenuVentas
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnImportacion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Image = Global.AppReports.My.Resources.Resources.Write
        Me.Button3.Location = New System.Drawing.Point(291, 41)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 86)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "REPORTE EXCEL"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.AppReports.My.Resources.Resources.log
        Me.Button2.Location = New System.Drawing.Point(401, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 86)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "COMPENSACION"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnImportacion
        '
        Me.BtnImportacion.Image = Global.AppReports.My.Resources.Resources.ark2
        Me.BtnImportacion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnImportacion.Location = New System.Drawing.Point(172, 41)
        Me.BtnImportacion.Name = "BtnImportacion"
        Me.BtnImportacion.Size = New System.Drawing.Size(113, 86)
        Me.BtnImportacion.TabIndex = 0
        Me.BtnImportacion.Text = "IMPORTACION"
        Me.BtnImportacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnImportacion.UseVisualStyleBackColor = True
        '
        'Frm_MenuVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(725, 547)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnImportacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_MenuVentas"
        Me.Text = "Frm_MenuVentas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnImportacion As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class

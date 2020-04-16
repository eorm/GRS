<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.Btnoperciones = New System.Windows.Forms.Button()
        Me.BtnAduanas = New System.Windows.Forms.Button()
        Me.PnPrincipal = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(375, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "OPERACIONES"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(899, 99)
        Me.Panel1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(375, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "VENTAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(375, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ADUANA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(136, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(563, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GESTION DE REPORTES SOLOSA"
        '
        'BtnVentas
        '
        Me.BtnVentas.BackColor = System.Drawing.Color.White
        Me.BtnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.Image = CType(resources.GetObject("BtnVentas.Image"), System.Drawing.Image)
        Me.BtnVentas.Location = New System.Drawing.Point(11, 539)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(131, 115)
        Me.BtnVentas.TabIndex = 10
        Me.BtnVentas.Text = "Ventas"
        Me.BtnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnVentas.UseVisualStyleBackColor = False
        '
        'Btnoperciones
        '
        Me.Btnoperciones.BackColor = System.Drawing.Color.White
        Me.Btnoperciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnoperciones.Image = CType(resources.GetObject("Btnoperciones.Image"), System.Drawing.Image)
        Me.Btnoperciones.Location = New System.Drawing.Point(11, 405)
        Me.Btnoperciones.Name = "Btnoperciones"
        Me.Btnoperciones.Size = New System.Drawing.Size(131, 115)
        Me.Btnoperciones.TabIndex = 9
        Me.Btnoperciones.Text = "Operaciones"
        Me.Btnoperciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btnoperciones.UseVisualStyleBackColor = False
        '
        'BtnAduanas
        '
        Me.BtnAduanas.BackColor = System.Drawing.Color.White
        Me.BtnAduanas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAduanas.Image = CType(resources.GetObject("BtnAduanas.Image"), System.Drawing.Image)
        Me.BtnAduanas.Location = New System.Drawing.Point(11, 271)
        Me.BtnAduanas.Name = "BtnAduanas"
        Me.BtnAduanas.Size = New System.Drawing.Size(131, 115)
        Me.BtnAduanas.TabIndex = 7
        Me.BtnAduanas.Text = "Aduanas"
        Me.BtnAduanas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAduanas.UseVisualStyleBackColor = False
        '
        'PnPrincipal
        '
        Me.PnPrincipal.BackColor = System.Drawing.Color.White
        Me.PnPrincipal.BackgroundImage = Global.AppReports.My.Resources.Resources.ups_latest2_1
        Me.PnPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PnPrincipal.Location = New System.Drawing.Point(160, 102)
        Me.PnPrincipal.Name = "PnPrincipal"
        Me.PnPrincipal.Size = New System.Drawing.Size(741, 586)
        Me.PnPrincipal.TabIndex = 6
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.MintCream
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = Global.AppReports.My.Resources.Resources.zsalir211
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(11, 137)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(131, 115)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(904, 691)
        Me.Controls.Add(Me.BtnVentas)
        Me.Controls.Add(Me.Btnoperciones)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnAduanas)
        Me.Controls.Add(Me.PnPrincipal)
        Me.Controls.Add(Me.BtnSalir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAduanas As System.Windows.Forms.Button
    Friend WithEvents PnPrincipal As System.Windows.Forms.Panel
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btnoperciones As System.Windows.Forms.Button
    Friend WithEvents BtnVentas As System.Windows.Forms.Button

End Class

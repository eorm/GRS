<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ReportePiezas
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
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.DgvPiezas = New System.Windows.Forms.DataGridView()
        Me.CboEstacion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtFC = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtFD = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtPP = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtPLT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNDOC = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDOC = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtLTR = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPesoKG = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPiezas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAWB = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.DgvResumen = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        CType(Me.DgvPiezas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtpDesde
        '
        Me.DtpDesde.Location = New System.Drawing.Point(19, 68)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(200, 20)
        Me.DtpDesde.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reporte de Piezas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(314, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hasta"
        '
        'DtpHasta
        '
        Me.DtpHasta.Location = New System.Drawing.Point(231, 67)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(200, 20)
        Me.DtpHasta.TabIndex = 4
        '
        'DgvPiezas
        '
        Me.DgvPiezas.AllowUserToAddRows = False
        Me.DgvPiezas.BackgroundColor = System.Drawing.Color.White
        Me.DgvPiezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPiezas.Location = New System.Drawing.Point(12, 363)
        Me.DgvPiezas.Name = "DgvPiezas"
        Me.DgvPiezas.Size = New System.Drawing.Size(704, 217)
        Me.DgvPiezas.TabIndex = 5
        '
        'CboEstacion
        '
        Me.CboEstacion.FormattingEnabled = True
        Me.CboEstacion.Location = New System.Drawing.Point(534, 63)
        Me.CboEstacion.Name = "CboEstacion"
        Me.CboEstacion.Size = New System.Drawing.Size(68, 21)
        Me.CboEstacion.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(458, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Estacion"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(702, 77)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totales"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.TxtFC)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.TxtFD)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.TxtPP)
        Me.Panel3.Location = New System.Drawing.Point(524, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(156, 53)
        Me.Panel3.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(109, 1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 15)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "F/C"
        '
        'TxtFC
        '
        Me.TxtFC.Location = New System.Drawing.Point(102, 21)
        Me.TxtFC.Name = "TxtFC"
        Me.TxtFC.Size = New System.Drawing.Size(39, 20)
        Me.TxtFC.TabIndex = 12
        Me.TxtFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(60, 1)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 15)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "F/D"
        '
        'TxtFD
        '
        Me.TxtFD.Location = New System.Drawing.Point(54, 21)
        Me.TxtFD.Name = "TxtFD"
        Me.TxtFD.Size = New System.Drawing.Size(39, 20)
        Me.TxtFD.TabIndex = 10
        Me.TxtFD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 1)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 15)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "P/P"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtPP
        '
        Me.TxtPP.Location = New System.Drawing.Point(6, 21)
        Me.TxtPP.Name = "TxtPP"
        Me.TxtPP.Size = New System.Drawing.Size(39, 20)
        Me.TxtPP.TabIndex = 0
        Me.TxtPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TxtPLT)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TxtNDOC)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TxtDOC)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TxtLTR)
        Me.Panel2.Location = New System.Drawing.Point(259, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(226, 53)
        Me.Panel2.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(179, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 15)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "PLT"
        '
        'TxtPLT
        '
        Me.TxtPLT.Location = New System.Drawing.Point(171, 21)
        Me.TxtPLT.Name = "TxtPLT"
        Me.TxtPLT.Size = New System.Drawing.Size(45, 20)
        Me.TxtPLT.TabIndex = 14
        Me.TxtPLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(111, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "NDOC"
        '
        'TxtNDOC
        '
        Me.TxtNDOC.Location = New System.Drawing.Point(110, 21)
        Me.TxtNDOC.Name = "TxtNDOC"
        Me.TxtNDOC.Size = New System.Drawing.Size(45, 20)
        Me.TxtNDOC.TabIndex = 12
        Me.TxtNDOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(63, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "DOC"
        '
        'TxtDOC
        '
        Me.TxtDOC.Location = New System.Drawing.Point(57, 21)
        Me.TxtDOC.Name = "TxtDOC"
        Me.TxtDOC.Size = New System.Drawing.Size(45, 20)
        Me.TxtDOC.TabIndex = 10
        Me.TxtDOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "LTR"
        '
        'TxtLTR
        '
        Me.TxtLTR.Location = New System.Drawing.Point(6, 21)
        Me.TxtLTR.Name = "TxtLTR"
        Me.TxtLTR.Size = New System.Drawing.Size(45, 20)
        Me.TxtLTR.TabIndex = 0
        Me.TxtLTR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtPesoKG)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtPiezas)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtAWB)
        Me.Panel1.Location = New System.Drawing.Point(15, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(208, 53)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(126, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Peso KG"
        '
        'TxtPesoKG
        '
        Me.TxtPesoKG.Location = New System.Drawing.Point(124, 21)
        Me.TxtPesoKG.Name = "TxtPesoKG"
        Me.TxtPesoKG.Size = New System.Drawing.Size(59, 20)
        Me.TxtPesoKG.TabIndex = 12
        Me.TxtPesoKG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(66, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Piezas"
        '
        'TxtPiezas
        '
        Me.TxtPiezas.Location = New System.Drawing.Point(65, 21)
        Me.TxtPiezas.Name = "TxtPiezas"
        Me.TxtPiezas.Size = New System.Drawing.Size(47, 20)
        Me.TxtPiezas.TabIndex = 10
        Me.TxtPiezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "AWB"
        '
        'TxtAWB
        '
        Me.TxtAWB.Location = New System.Drawing.Point(6, 21)
        Me.TxtAWB.Name = "TxtAWB"
        Me.TxtAWB.Size = New System.Drawing.Size(47, 20)
        Me.TxtAWB.TabIndex = 0
        Me.TxtAWB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.BtnSalir)
        Me.Panel4.Controls.Add(Me.BtnExportar)
        Me.Panel4.Controls.Add(Me.BtnAceptar)
        Me.Panel4.Controls.Add(Me.BtnCancelar)
        Me.Panel4.Location = New System.Drawing.Point(15, 100)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(701, 65)
        Me.Panel4.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Location = New System.Drawing.Point(14, 40)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(702, 55)
        Me.Panel5.TabIndex = 13
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.Image = Global.AppReports.My.Resources.Resources.salida
        Me.BtnSalir.Location = New System.Drawing.Point(427, 5)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(62, 54)
        Me.BtnSalir.TabIndex = 13
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnExportar
        '
        Me.BtnExportar.BackColor = System.Drawing.Color.White
        Me.BtnExportar.Enabled = False
        Me.BtnExportar.Image = Global.AppReports.My.Resources.Resources.sobresalir
        Me.BtnExportar.Location = New System.Drawing.Point(349, 3)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(62, 54)
        Me.BtnExportar.TabIndex = 12
        Me.BtnExportar.Text = "Exportar "
        Me.BtnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnExportar.UseVisualStyleBackColor = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.White
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Image = Global.AppReports.My.Resources.Resources.circulo_con_el_simbolo_de_verificacion
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAceptar.Location = New System.Drawing.Point(193, 5)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(62, 54)
        Me.BtnAceptar.TabIndex = 9
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.White
        Me.BtnCancelar.Image = Global.AppReports.My.Resources.Resources.error__1_
        Me.BtnCancelar.Location = New System.Drawing.Point(271, 5)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(62, 54)
        Me.BtnCancelar.TabIndex = 10
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'DgvResumen
        '
        Me.DgvResumen.AllowUserToAddRows = False
        Me.DgvResumen.BackgroundColor = System.Drawing.Color.White
        Me.DgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvResumen.Location = New System.Drawing.Point(206, 271)
        Me.DgvResumen.Name = "DgvResumen"
        Me.DgvResumen.Size = New System.Drawing.Size(316, 90)
        Me.DgvResumen.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(297, 250)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(135, 15)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Resumen de Piezas"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Location = New System.Drawing.Point(8, 268)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(714, 313)
        Me.Panel6.TabIndex = 16
        '
        'Frm_ReportePiezas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(731, 586)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DgvResumen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CboEstacion)
        Me.Controls.Add(Me.DgvPiezas)
        Me.Controls.Add(Me.DtpHasta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtpDesde)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_ReportePiezas"
        Me.Text = "Frm_ReportePiezas"
        CType(Me.DgvPiezas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtpDesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpHasta As DateTimePicker
    Friend WithEvents DgvPiezas As DataGridView
    Friend WithEvents CboEstacion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtPesoKG As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPiezas As TextBox
    Friend WithEvents TxtAWB As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNDOC As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtDOC As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtLTR As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtPLT As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtFC As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtFD As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtPP As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnExportar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DgvResumen As DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel6 As Panel
End Class

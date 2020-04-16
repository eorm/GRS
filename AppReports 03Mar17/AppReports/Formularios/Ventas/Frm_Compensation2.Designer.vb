<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Compensation2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DTPDateimportpkg = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DSImport = New System.Data.DataSet()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.Dgvresult = New System.Windows.Forms.DataGridView()
        Me.TxtAwb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPiezas = New System.Windows.Forms.TextBox()
        Me.TxtPesoKG = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DgvImportacion2 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtLTR = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDOC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNDOC = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtFC = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtFD = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtPP = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DgvResumen = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtPLT = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnImportar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblTotalGuiasG = New System.Windows.Forms.Label()
        Me.LblTotalGuiasD = New System.Windows.Forms.Label()
        Me.DgvGuiasHijas = New System.Windows.Forms.DataGridView()
        Me.ShipmentId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorrelativoGH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightGH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightUnitGH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConvKGGH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyGH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OverSizeGH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncompleteGH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrackingGH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFileLevel1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaImportGRS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DSImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgvresult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvImportacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvGuiasHijas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTPDateimportpkg
        '
        Me.DTPDateimportpkg.Location = New System.Drawing.Point(17, 22)
        Me.DTPDateimportpkg.Name = "DTPDateimportpkg"
        Me.DTPDateimportpkg.Size = New System.Drawing.Size(200, 20)
        Me.DTPDateimportpkg.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Import Date"
        '
        'DSImport
        '
        Me.DSImport.DataSetName = "NewDataSet"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Image = Global.AppReports.My.Resources.Resources.Floppy_1
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(334, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(78, 49)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnExportar
        '
        Me.BtnExportar.Enabled = False
        Me.BtnExportar.Location = New System.Drawing.Point(537, 4)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(78, 49)
        Me.BtnExportar.TabIndex = 5
        Me.BtnExportar.Text = "Export"
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'Dgvresult
        '
        Me.Dgvresult.AllowUserToAddRows = False
        Me.Dgvresult.BackgroundColor = System.Drawing.Color.White
        Me.Dgvresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dgvresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvresult.Location = New System.Drawing.Point(6, 167)
        Me.Dgvresult.Name = "Dgvresult"
        Me.Dgvresult.Size = New System.Drawing.Size(729, 196)
        Me.Dgvresult.TabIndex = 6
        '
        'TxtAwb
        '
        Me.TxtAwb.BackColor = System.Drawing.Color.White
        Me.TxtAwb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAwb.Location = New System.Drawing.Point(38, 91)
        Me.TxtAwb.Name = "TxtAwb"
        Me.TxtAwb.ReadOnly = True
        Me.TxtAwb.Size = New System.Drawing.Size(54, 21)
        Me.TxtAwb.TabIndex = 7
        Me.TxtAwb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "AWB"
        '
        'TxtPiezas
        '
        Me.TxtPiezas.BackColor = System.Drawing.Color.White
        Me.TxtPiezas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPiezas.Location = New System.Drawing.Point(96, 91)
        Me.TxtPiezas.Name = "TxtPiezas"
        Me.TxtPiezas.ReadOnly = True
        Me.TxtPiezas.Size = New System.Drawing.Size(54, 21)
        Me.TxtPiezas.TabIndex = 12
        Me.TxtPiezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPesoKG
        '
        Me.TxtPesoKG.BackColor = System.Drawing.Color.White
        Me.TxtPesoKG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPesoKG.Location = New System.Drawing.Point(154, 91)
        Me.TxtPesoKG.Name = "TxtPesoKG"
        Me.TxtPesoKG.ReadOnly = True
        Me.TxtPesoKG.Size = New System.Drawing.Size(62, 21)
        Me.TxtPesoKG.TabIndex = 13
        Me.TxtPesoKG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(153, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Peso KG"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(101, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Piezas"
        '
        'DgvImportacion2
        '
        Me.DgvImportacion2.AllowUserToAddRows = False
        Me.DgvImportacion2.BackgroundColor = System.Drawing.Color.White
        Me.DgvImportacion2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvImportacion2.Location = New System.Drawing.Point(6, 133)
        Me.DgvImportacion2.Name = "DgvImportacion2"
        Me.DgvImportacion2.Size = New System.Drawing.Size(729, 451)
        Me.DgvImportacion2.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(279, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "LTR"
        '
        'TxtLTR
        '
        Me.TxtLTR.BackColor = System.Drawing.Color.White
        Me.TxtLTR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLTR.Location = New System.Drawing.Point(274, 91)
        Me.TxtLTR.Name = "TxtLTR"
        Me.TxtLTR.ReadOnly = True
        Me.TxtLTR.Size = New System.Drawing.Size(41, 21)
        Me.TxtLTR.TabIndex = 22
        Me.TxtLTR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(325, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "DOC"
        '
        'TxtDOC
        '
        Me.TxtDOC.BackColor = System.Drawing.Color.White
        Me.TxtDOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDOC.Location = New System.Drawing.Point(321, 91)
        Me.TxtDOC.Name = "TxtDOC"
        Me.TxtDOC.ReadOnly = True
        Me.TxtDOC.Size = New System.Drawing.Size(41, 21)
        Me.TxtDOC.TabIndex = 24
        Me.TxtDOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(366, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "NDOC"
        '
        'TxtNDOC
        '
        Me.TxtNDOC.BackColor = System.Drawing.Color.White
        Me.TxtNDOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNDOC.Location = New System.Drawing.Point(367, 91)
        Me.TxtNDOC.Name = "TxtNDOC"
        Me.TxtNDOC.ReadOnly = True
        Me.TxtNDOC.Size = New System.Drawing.Size(41, 21)
        Me.TxtNDOC.TabIndex = 26
        Me.TxtNDOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(632, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "F/C"
        '
        'TxtFC
        '
        Me.TxtFC.BackColor = System.Drawing.Color.White
        Me.TxtFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFC.Location = New System.Drawing.Point(632, 91)
        Me.TxtFC.Name = "TxtFC"
        Me.TxtFC.ReadOnly = True
        Me.TxtFC.Size = New System.Drawing.Size(28, 21)
        Me.TxtFC.TabIndex = 32
        Me.TxtFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(597, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "F/D"
        '
        'TxtFD
        '
        Me.TxtFD.BackColor = System.Drawing.Color.White
        Me.TxtFD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFD.Location = New System.Drawing.Point(597, 91)
        Me.TxtFD.Name = "TxtFD"
        Me.TxtFD.ReadOnly = True
        Me.TxtFD.Size = New System.Drawing.Size(29, 21)
        Me.TxtFD.TabIndex = 30
        Me.TxtFD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(562, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "P/P"
        '
        'TxtPP
        '
        Me.TxtPP.BackColor = System.Drawing.Color.White
        Me.TxtPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPP.Location = New System.Drawing.Point(562, 91)
        Me.TxtPP.Name = "TxtPP"
        Me.TxtPP.ReadOnly = True
        Me.TxtPP.Size = New System.Drawing.Size(29, 21)
        Me.TxtPP.TabIndex = 28
        Me.TxtPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(32, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(189, 54)
        Me.Panel1.TabIndex = 34
        '
        'DgvResumen
        '
        Me.DgvResumen.AllowUserToAddRows = False
        Me.DgvResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DgvResumen.BackgroundColor = System.Drawing.Color.White
        Me.DgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvResumen.Location = New System.Drawing.Point(6, 399)
        Me.DgvResumen.Name = "DgvResumen"
        Me.DgvResumen.Size = New System.Drawing.Size(729, 185)
        Me.DgvResumen.TabIndex = 9
        Me.DgvResumen.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TxtPLT)
        Me.Panel2.Location = New System.Drawing.Point(262, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(203, 54)
        Me.Panel2.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(155, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "PLT"
        '
        'TxtPLT
        '
        Me.TxtPLT.BackColor = System.Drawing.Color.White
        Me.TxtPLT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPLT.Location = New System.Drawing.Point(150, 19)
        Me.TxtPLT.Name = "TxtPLT"
        Me.TxtPLT.ReadOnly = True
        Me.TxtPLT.Size = New System.Drawing.Size(41, 21)
        Me.TxtPLT.TabIndex = 39
        Me.TxtPLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Location = New System.Drawing.Point(516, 70)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(184, 54)
        Me.Panel3.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(17, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(702, 75)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TOTALES"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(435, 4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(78, 49)
        Me.BtnCancelar.TabIndex = 38
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(639, 4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(78, 49)
        Me.BtnSalir.TabIndex = 39
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnImportar
        '
        Me.BtnImportar.Enabled = False
        Me.BtnImportar.Image = Global.AppReports.My.Resources.Resources.BitTorrent_1
        Me.BtnImportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnImportar.Location = New System.Drawing.Point(232, 4)
        Me.BtnImportar.Name = "BtnImportar"
        Me.BtnImportar.Size = New System.Drawing.Size(78, 49)
        Me.BtnImportar.TabIndex = 1
        Me.BtnImportar.Text = "Importar"
        Me.BtnImportar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnImportar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Red
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(256, 366)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(281, 31)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "GUIAS DUPLICADAS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(256, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(268, 31)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "GUIAS A GUARDAR"
        '
        'LblTotalGuiasG
        '
        Me.LblTotalGuiasG.AutoSize = True
        Me.LblTotalGuiasG.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalGuiasG.Location = New System.Drawing.Point(530, 133)
        Me.LblTotalGuiasG.Name = "LblTotalGuiasG"
        Me.LblTotalGuiasG.Size = New System.Drawing.Size(0, 31)
        Me.LblTotalGuiasG.TabIndex = 42
        '
        'LblTotalGuiasD
        '
        Me.LblTotalGuiasD.AutoSize = True
        Me.LblTotalGuiasD.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalGuiasD.Location = New System.Drawing.Point(543, 366)
        Me.LblTotalGuiasD.Name = "LblTotalGuiasD"
        Me.LblTotalGuiasD.Size = New System.Drawing.Size(0, 31)
        Me.LblTotalGuiasD.TabIndex = 43
        '
        'DgvGuiasHijas
        '
        Me.DgvGuiasHijas.AllowUserToAddRows = False
        Me.DgvGuiasHijas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvGuiasHijas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShipmentId, Me.CorrelativoGH, Me.WeightGH, Me.WeightUnitGH, Me.ConvKGGH, Me.CurrencyGH, Me.OverSizeGH, Me.IncompleteGH, Me.TrackingGH, Me.FechaFileLevel1, Me.FechaImportGRS})
        Me.DgvGuiasHijas.Location = New System.Drawing.Point(-18, 209)
        Me.DgvGuiasHijas.Name = "DgvGuiasHijas"
        Me.DgvGuiasHijas.Size = New System.Drawing.Size(753, 87)
        Me.DgvGuiasHijas.TabIndex = 44
        Me.DgvGuiasHijas.Visible = False
        '
        'ShipmentId
        '
        Me.ShipmentId.HeaderText = "Shipment"
        Me.ShipmentId.Name = "ShipmentId"
        '
        'CorrelativoGH
        '
        Me.CorrelativoGH.HeaderText = "Correlativo"
        Me.CorrelativoGH.Name = "CorrelativoGH"
        '
        'WeightGH
        '
        Me.WeightGH.HeaderText = "Weight"
        Me.WeightGH.Name = "WeightGH"
        '
        'WeightUnitGH
        '
        Me.WeightUnitGH.HeaderText = "Weight Unit"
        Me.WeightUnitGH.Name = "WeightUnitGH"
        '
        'ConvKGGH
        '
        Me.ConvKGGH.HeaderText = "Weight KG"
        Me.ConvKGGH.Name = "ConvKGGH"
        '
        'CurrencyGH
        '
        Me.CurrencyGH.HeaderText = "Currency"
        Me.CurrencyGH.Name = "CurrencyGH"
        '
        'OverSizeGH
        '
        Me.OverSizeGH.HeaderText = "OverSize"
        Me.OverSizeGH.Name = "OverSizeGH"
        '
        'IncompleteGH
        '
        Me.IncompleteGH.HeaderText = "Incomplete"
        Me.IncompleteGH.Name = "IncompleteGH"
        '
        'TrackingGH
        '
        Me.TrackingGH.HeaderText = "Tracking"
        Me.TrackingGH.Name = "TrackingGH"
        '
        'FechaFileLevel1
        '
        Me.FechaFileLevel1.HeaderText = "Fecha Level1"
        Me.FechaFileLevel1.Name = "FechaFileLevel1"
        '
        'FechaImportGRS
        '
        Me.FechaImportGRS.HeaderText = "Fecha Import"
        Me.FechaImportGRS.Name = "FechaImportGRS"
        '
        'Frm_Compensation2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(741, 586)
        Me.Controls.Add(Me.DgvImportacion2)
        Me.Controls.Add(Me.LblTotalGuiasD)
        Me.Controls.Add(Me.LblTotalGuiasG)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtFC)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtFD)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtPP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtNDOC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDOC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtLTR)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtPesoKG)
        Me.Controls.Add(Me.TxtPiezas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DgvResumen)
        Me.Controls.Add(Me.Dgvresult)
        Me.Controls.Add(Me.TxtAwb)
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTPDateimportpkg)
        Me.Controls.Add(Me.BtnImportar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvGuiasHijas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Compensation2"
        Me.Text = "Frm_Manifiesto3"
        CType(Me.DSImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgvresult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvImportacion2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgvGuiasHijas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnImportar As System.Windows.Forms.Button
    Friend WithEvents DTPDateimportpkg As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSImport As System.Data.DataSet
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnExportar As System.Windows.Forms.Button
    Friend WithEvents Dgvresult As System.Windows.Forms.DataGridView
    Friend WithEvents TxtAwb As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPiezas As TextBox
    Friend WithEvents TxtPesoKG As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DgvImportacion2 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtLTR As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDOC As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNDOC As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtFC As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtFD As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtPP As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DgvResumen As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtPLT As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LblTotalGuiasG As Label
    Friend WithEvents LblTotalGuiasD As Label
    Friend WithEvents DgvGuiasHijas As DataGridView
    Friend WithEvents ShipmentId As DataGridViewTextBoxColumn
    Friend WithEvents CorrelativoGH As DataGridViewTextBoxColumn
    Friend WithEvents WeightGH As DataGridViewTextBoxColumn
    Friend WithEvents WeightUnitGH As DataGridViewTextBoxColumn
    Friend WithEvents ConvKGGH As DataGridViewTextBoxColumn
    Friend WithEvents CurrencyGH As DataGridViewTextBoxColumn
    Friend WithEvents OverSizeGH As DataGridViewTextBoxColumn
    Friend WithEvents IncompleteGH As DataGridViewTextBoxColumn
    Friend WithEvents TrackingGH As DataGridViewTextBoxColumn
    Friend WithEvents FechaFileLevel1 As DataGridViewTextBoxColumn
    Friend WithEvents FechaImportGRS As DataGridViewTextBoxColumn
End Class

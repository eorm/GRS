<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ImportManifiesto
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
        Me.BtnImportar = New System.Windows.Forms.Button()
        Me.TxtNombreHoja = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtFechaMan = New System.Windows.Forms.TextBox()
        Me.DgvImpMan = New System.Windows.Forms.DataGridView()
        Me.TxtTotalGuias = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTotalPiezas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTotalPeso = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtGuiaMaster = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtManifiesto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DgvImpMan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnImportar
        '
        Me.BtnImportar.Location = New System.Drawing.Point(13, 17)
        Me.BtnImportar.Name = "BtnImportar"
        Me.BtnImportar.Size = New System.Drawing.Size(91, 53)
        Me.BtnImportar.TabIndex = 0
        Me.BtnImportar.Text = "Importar Archivo"
        Me.BtnImportar.UseVisualStyleBackColor = True
        '
        'TxtNombreHoja
        '
        Me.TxtNombreHoja.Location = New System.Drawing.Point(34, 23)
        Me.TxtNombreHoja.Name = "TxtNombreHoja"
        Me.TxtNombreHoja.Size = New System.Drawing.Size(85, 20)
        Me.TxtNombreHoja.TabIndex = 1
        Me.TxtNombreHoja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre Hoja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Manifiesto"
        '
        'TxtFechaMan
        '
        Me.TxtFechaMan.BackColor = System.Drawing.Color.White
        Me.TxtFechaMan.Location = New System.Drawing.Point(164, 23)
        Me.TxtFechaMan.Name = "TxtFechaMan"
        Me.TxtFechaMan.ReadOnly = True
        Me.TxtFechaMan.Size = New System.Drawing.Size(76, 20)
        Me.TxtFechaMan.TabIndex = 3
        Me.TxtFechaMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DgvImpMan
        '
        Me.DgvImpMan.AllowUserToAddRows = False
        Me.DgvImpMan.BackgroundColor = System.Drawing.Color.White
        Me.DgvImpMan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvImpMan.Location = New System.Drawing.Point(13, 134)
        Me.DgvImpMan.Name = "DgvImpMan"
        Me.DgvImpMan.ReadOnly = True
        Me.DgvImpMan.Size = New System.Drawing.Size(689, 401)
        Me.DgvImpMan.TabIndex = 9
        '
        'TxtTotalGuias
        '
        Me.TxtTotalGuias.BackColor = System.Drawing.Color.White
        Me.TxtTotalGuias.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalGuias.Location = New System.Drawing.Point(109, 89)
        Me.TxtTotalGuias.Name = "TxtTotalGuias"
        Me.TxtTotalGuias.ReadOnly = True
        Me.TxtTotalGuias.Size = New System.Drawing.Size(40, 27)
        Me.TxtTotalGuias.TabIndex = 10
        Me.TxtTotalGuias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Total Guias"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(154, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Total Piezas"
        '
        'TxtTotalPiezas
        '
        Me.TxtTotalPiezas.BackColor = System.Drawing.Color.White
        Me.TxtTotalPiezas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPiezas.Location = New System.Drawing.Point(250, 89)
        Me.TxtTotalPiezas.Name = "TxtTotalPiezas"
        Me.TxtTotalPiezas.ReadOnly = True
        Me.TxtTotalPiezas.Size = New System.Drawing.Size(45, 27)
        Me.TxtTotalPiezas.TabIndex = 12
        Me.TxtTotalPiezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(300, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Total Peso KG"
        '
        'TxtTotalPeso
        '
        Me.TxtTotalPeso.BackColor = System.Drawing.Color.White
        Me.TxtTotalPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPeso.Location = New System.Drawing.Point(414, 89)
        Me.TxtTotalPeso.Name = "TxtTotalPeso"
        Me.TxtTotalPeso.ReadOnly = True
        Me.TxtTotalPeso.Size = New System.Drawing.Size(51, 27)
        Me.TxtTotalPeso.TabIndex = 14
        Me.TxtTotalPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BtnLimpiar)
        Me.Panel1.Controls.Add(Me.BtnSalir)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(13, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(689, 49)
        Me.Panel1.TabIndex = 16
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnLimpiar.Image = Global.AppReports.My.Resources.Resources.zEdit2
        Me.BtnLimpiar.Location = New System.Drawing.Point(531, 0)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(77, 44)
        Me.BtnLimpiar.TabIndex = 19
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnSalir.Image = Global.AppReports.My.Resources.Resources.zsalir21
        Me.BtnSalir.Location = New System.Drawing.Point(607, 0)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(77, 44)
        Me.BtnSalir.TabIndex = 18
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnGuardar.Image = Global.AppReports.My.Resources.Resources.Floppy_11
        Me.BtnGuardar.Location = New System.Drawing.Point(455, 0)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(77, 44)
        Me.BtnGuardar.TabIndex = 17
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TxtGuiaMaster
        '
        Me.TxtGuiaMaster.BackColor = System.Drawing.Color.White
        Me.TxtGuiaMaster.Location = New System.Drawing.Point(283, 23)
        Me.TxtGuiaMaster.Name = "TxtGuiaMaster"
        Me.TxtGuiaMaster.ReadOnly = True
        Me.TxtGuiaMaster.Size = New System.Drawing.Size(85, 20)
        Me.TxtGuiaMaster.TabIndex = 5
        Me.TxtGuiaMaster.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(293, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Guia Master"
        '
        'TxtManifiesto
        '
        Me.TxtManifiesto.BackColor = System.Drawing.Color.White
        Me.TxtManifiesto.Location = New System.Drawing.Point(399, 23)
        Me.TxtManifiesto.Name = "TxtManifiesto"
        Me.TxtManifiesto.ReadOnly = True
        Me.TxtManifiesto.Size = New System.Drawing.Size(137, 20)
        Me.TxtManifiesto.TabIndex = 7
        Me.TxtManifiesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(435, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Manifiesto #"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxtManifiesto)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TxtGuiaMaster)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TxtFechaMan)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TxtNombreHoja)
        Me.Panel2.Location = New System.Drawing.Point(105, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(594, 52)
        Me.Panel2.TabIndex = 17
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 208)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(680, 202)
        Me.DataGridView1.TabIndex = 18
        Me.DataGridView1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(627, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Frm_ImportManifiesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 547)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTotalPeso)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTotalPiezas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTotalGuias)
        Me.Controls.Add(Me.DgvImpMan)
        Me.Controls.Add(Me.BtnImportar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_ImportManifiesto"
        Me.Text = "Frm_ImportManifiesto"
        CType(Me.DgvImpMan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnImportar As Button
    Friend WithEvents TxtNombreHoja As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtFechaMan As TextBox
    Friend WithEvents DgvImpMan As DataGridView
    Friend WithEvents TxtTotalGuias As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTotalPiezas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTotalPeso As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents TxtGuiaMaster As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtManifiesto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class

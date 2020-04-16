<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ValidarFacturas
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
        Dim Label1 As System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.DgvvalidacionMagic = New System.Windows.Forms.DataGridView()
        Me.DgvConsultaManAdu = New System.Windows.Forms.DataGridView()
        Me.TxtTotalGuias = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvvalidacionMagic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvConsultaManAdu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(27, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(645, 29)
        Label1.TabIndex = 0
        Label1.Text = "Validacion de Guias Facturadas en MAGIC Vrs Aduana"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Guias Manifiestadas en Aduana"
        '
        'DtpDesde
        '
        Me.DtpDesde.Location = New System.Drawing.Point(13, 73)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(200, 20)
        Me.DtpDesde.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(218, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Seleccione Rango de Fecha"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BtnSalir)
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.BtnConsultar)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DtpHasta)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DtpDesde)
        Me.Panel1.Location = New System.Drawing.Point(6, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(692, 106)
        Me.Panel1.TabIndex = 4
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(601, 58)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 39)
        Me.BtnSalir.TabIndex = 9
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(521, 57)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 39)
        Me.BtnCancelar.TabIndex = 8
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(441, 57)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(75, 39)
        Me.BtnConsultar.TabIndex = 7
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(305, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Hasta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Desde"
        '
        'DtpHasta
        '
        Me.DtpHasta.Location = New System.Drawing.Point(229, 73)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(200, 20)
        Me.DtpHasta.TabIndex = 4
        '
        'DgvvalidacionMagic
        '
        Me.DgvvalidacionMagic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvvalidacionMagic.Location = New System.Drawing.Point(6, 229)
        Me.DgvvalidacionMagic.Name = "DgvvalidacionMagic"
        Me.DgvvalidacionMagic.Size = New System.Drawing.Size(692, 267)
        Me.DgvvalidacionMagic.TabIndex = 5
        '
        'DgvConsultaManAdu
        '
        Me.DgvConsultaManAdu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsultaManAdu.Location = New System.Drawing.Point(174, 366)
        Me.DgvConsultaManAdu.Name = "DgvConsultaManAdu"
        Me.DgvConsultaManAdu.Size = New System.Drawing.Size(430, 112)
        Me.DgvConsultaManAdu.TabIndex = 6
        '
        'TxtTotalGuias
        '
        Me.TxtTotalGuias.Location = New System.Drawing.Point(82, 154)
        Me.TxtTotalGuias.Name = "TxtTotalGuias"
        Me.TxtTotalGuias.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalGuias.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total Guias"
        '
        'Frm_ValidarFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(709, 508)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTotalGuias)
        Me.Controls.Add(Me.DgvConsultaManAdu)
        Me.Controls.Add(Me.DgvvalidacionMagic)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_ValidarFacturas"
        Me.Text = "Revision Facturas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvvalidacionMagic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvConsultaManAdu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents DtpDesde As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DtpHasta As DateTimePicker
    Friend WithEvents DgvvalidacionMagic As DataGridView
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents DgvConsultaManAdu As DataGridView
    Friend WithEvents TxtTotalGuias As TextBox
    Friend WithEvents Label6 As Label
End Class

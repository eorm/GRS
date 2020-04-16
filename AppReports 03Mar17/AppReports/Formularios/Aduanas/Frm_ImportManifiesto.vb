Imports MySql.Data.MySqlClient
Imports MySql.Data.Types

Public Class Frm_ImportManifiesto
    Private Sub Frm_ImportManifiesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'strconexion = "server=localhost; database=dbsolosa; uid=root; password=Ups2810"
        'DgvImpMan.Columns(10).DefaultCellStyle.Format = "##,##0.00"
        'DgvImpMan.Columns(10).DefaultCellStyle.Format = "##,##0.00"
        'DgvImpMan.Columns(14).DefaultCellStyle.Format = "##,##0.00"
        DgvImpMan.AllowUserToAddRows = False
        DataGridView1.AllowUserToAddRows = False
        TxtNombreHoja.Text = "Page 1"
        BtnGuardar.Enabled = False
    End Sub

    Private Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        Dim openFD As New OpenFileDialog()
        Dim NombreHoja = TxtNombreHoja.Text
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ImportExcellToDataGridView(.FileName, DgvImpMan, NombreHoja)
            End If
            'TextBox1.Text = VariablePrueba2
            TxtFechaMan.Text = FechaManifiesto
            TxtGuiaMaster.Text = Replace(GuiaMaster, " ", "")
            TxtManifiesto.Text = Replace(Manifiesto, " ", "")
        End With
        BtnGuardar.Enabled = True
        Totales()

    End Sub
    Sub Totales()
        Dim TotalPiezas As Integer
        Dim TotalPeso As Double
        Dim fila As DataGridViewRow = New DataGridViewRow

        For Each fila In DgvImpMan.Rows
            TotalPiezas += Convert.ToInt32(fila.Cells("F5").Value)
            TotalPeso += Convert.ToDouble(fila.Cells("F6").Value)

        Next
        TxtTotalGuias.Text = DgvImpMan.Rows.Count
        TxtTotalPiezas.Text = TotalPiezas
        TxtTotalPeso.Text = TotalPeso
    End Sub
    Sub Limpiar()

        TxtFechaMan.Text = ""
        TxtGuiaMaster.Text = ""
        TxtManifiesto.Text = ""
        TxtTotalGuias.Text = Nothing
        TxtTotalPiezas.Text = Nothing
        TxtTotalPeso.Text = Nothing
        BtnGuardar.Enabled = False
        FechaManifiesto = Nothing

        DgvImpMan.AllowUserToAddRows = False
        DataGridView1.Visible = True
        DgvImpMan.DataSource = Nothing
        DgvImpMan.Show()

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Visible = False
        DataGridView1.DataSource = Nothing

        TxtNombreHoja.Text = "Page 1"
        BtnGuardar.Enabled = False
        BtnImportar.Enabled = True

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dispose()

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Dim DataSetPrueba As New DataSet
        Dim DtConsultManifiesto As New DataTable
        Dim DtGuiasDuplicadas As New DataTable
        Dim ContadorClonado As Integer = 0
        conectarBD()
        DataSetPrueba.Tables.Add(DtConsultManifiesto)
        DataSetPrueba.Tables.Add(DtGuiasDuplicadas)
        Trim(TxtGuiaMaster.Text)


        Try

            For Each row As DataGridViewRow In DgvImpMan.Rows


                DtConsultManifiesto = consultaSQL("Select * from manifiestoaduana where NumeroGuia='" & row.Cells(1).Value & "'")

                If ContadorClonado < 1 Then
                    DtGuiasDuplicadas = DtConsultManifiesto.Clone()
                End If


                If DtConsultManifiesto.Rows.Count > 0 Then

                    For Each drow As DataRow In DtConsultManifiesto.Rows

                        DtGuiasDuplicadas.ImportRow(drow)

                    Next

                End If

                DataGridView1.DataSource = DtGuiasDuplicadas
                'MsgBox(row.Cells(1).Value)

                ContadorClonado += 1

            Next

            If DtGuiasDuplicadas.Rows.Count > 0 Then
                MsgBox("No puede existir guias duplicadas, favor revisar manifiesto", vbCritical, "Valores Duplicados")
                DataGridView1.Visible = True
                DataGridView1.ReadOnly = True
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
                DataGridView1.Font = New Font("Tahoma", 7, FontStyle.Regular)

                DgvImpMan.Visible = False
                BtnImportar.Enabled = False
            Else

                MsgBox("No existen guias duplicadas")
                GrabarRegristrasAduana()
                Limpiar()
            End If

            DataGridView1.DataSource = DtGuiasDuplicadas

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

        BtnGuardar.Enabled = False
        DesconectarBD()

    End Sub

    Sub GrabarRegristrasAduana()
        conectarBD()
        Dim AgregarRegistro As MySqlCommand
        'AgregarRegistro = New MySqlCommand("insert into test(nombre) values(?nombre)", conex)
        AgregarRegistro = New MySqlCommand("insert into manifiestoaduana(NumeroGuia,Fila,Proveedor,Consignatario,Piezas,Peso,Descripcion,Valor,Flete,Seguro,Otros,FechaManifiesto,GuiaMaster,ManifiestoNumero,FechaCargaArchivo) values(?NumeroGuia,?Fila,?Proveedor,?Consignatario,?Piezas,?Peso,?Descripcion,?Valor,?Flete,?Seguro,?Otros,?FechaManifiesto,?GuiaMaster,?ManifiestoNumero,?FechaCargaArchivo)", conex)
        'Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim FechaExportacionB As String = FechaManifiesto.ToString("yyyy-MM-dd")
        Dim FechaCargaArchivoDB As String = Now.ToString("yyyy-MM-dd HH:mm:ss")
        For Each fila In DgvImpMan.Rows
            AgregarRegistro.Parameters.Clear()
            AgregarRegistro.Parameters.Add("?NumeroGuia", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("F2").Value)
            AgregarRegistro.Parameters.Add("?Fila", MySqlDbType.Int32).Value = Convert.ToString(fila.Cells("F1").Value)
            AgregarRegistro.Parameters.Add("?Proveedor", MySqlDbType.VarChar).Value = fila.Cells("F3").Value
            AgregarRegistro.Parameters.Add("?Consignatario", MySqlDbType.VarChar).Value = fila.Cells("F4").Value
            AgregarRegistro.Parameters.Add("?Piezas", MySqlDbType.Int32).Value = fila.Cells("f5").Value
            AgregarRegistro.Parameters.Add("?Peso", MySqlDbType.Double).Value = fila.Cells("f6").Value
            AgregarRegistro.Parameters.Add("?DEscripcion", MySqlDbType.VarChar).Value = fila.Cells("f7").Value
            AgregarRegistro.Parameters.Add("?Valor", MySqlDbType.Double).Value = fila.Cells("f8").Value
            AgregarRegistro.Parameters.Add("?Flete", MySqlDbType.Double).Value = fila.Cells("f9").Value
            AgregarRegistro.Parameters.Add("?Seguro", MySqlDbType.Double).Value = fila.Cells("f10").Value
            AgregarRegistro.Parameters.Add("?Otros", MySqlDbType.Double).Value = fila.Cells("f11").Value
            AgregarRegistro.Parameters.Add("?FechaManifiesto", MySqlDbType.DateTime).Value = FechaExportacionB
            AgregarRegistro.Parameters.Add("?GuiaMaster", MySqlDbType.VarChar).Value = TxtGuiaMaster.Text
            AgregarRegistro.Parameters.Add("?ManifiestoNumero", MySqlDbType.VarChar).Value = TxtManifiesto.Text
            AgregarRegistro.Parameters.Add("?FechaCargaArchivo", MySqlDbType.VarChar).Value = FechaCargaArchivoDB
            AgregarRegistro.ExecuteNonQuery()
        Next
        MsgBox("Registros Guardados Satisfactoriamente", vbInformation, "Informacion")
        DesconectarBD()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim GuiaM As String

        'GuiaM = Replace(TxtGuiaMaster.Text, " ", "")

        'MsgBox(GuiaM)
        Dim fecha As Date
        Dim Nombrecolumna As String
        Dim DatoColumna As String

        Nombrecolumna = Me.DgvImpMan.Columns.Item(0).Name.ToString
        DatoColumna = Me.DgvImpMan.Rows(0).Cells(1).Value
        fecha = TxtFechaMan.Text
        MsgBox(fecha)
        MsgBox((DgvImpMan.Rows.Count).ToString)

        'MsgBox(Nombrecolumna + " Dato en columna " + DatoColumna)

    End Sub
End Class
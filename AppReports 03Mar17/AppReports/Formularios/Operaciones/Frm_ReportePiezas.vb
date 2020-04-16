Public Class Frm_ReportePiezas
    Dim DtConsultaResumen As New DataTable
    Dim DtConsultaPiezas As New DataTable
    Dim FechaDesde As Date
    Dim FechaDesdeDB As String
    Dim FechaHasta As Date
    Dim FechaHastaDB As String


    Private Sub Frm_ReportePiezas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboEstacion.Items.Add("SAP")
        CboEstacion.Items.Add("TGU")

        FechaDesde = DtpDesde.Value.ToShortDateString
        FechaDesdeDB = FechaDesde.ToString("yyyy-MM-dd")
        FechaHasta = DtpHasta.Value.ToShortDateString
        FechaHastaDB = FechaHasta.ToString("yyyy-MM-dd")

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        Dispose()

    End Sub

    Private Sub BtnSalir_Click_1(sender As Object, e As EventArgs) Handles BtnSalir.Click

        Dispose()

    End Sub

    Private Sub DtpDesde_ValueChanged(sender As Object, e As EventArgs) Handles DtpDesde.ValueChanged
        FechaDesde = DtpDesde.Value.ToShortDateString
        FechaDesdeDB = FechaDesde.ToString("yyyy-MM-dd")
        'MsgBox(FechaDesdeDB.ToString + " " + FechaHastaDB.ToString)
    End Sub

    Private Sub DtpHasta_ValueChanged(sender As Object, e As EventArgs) Handles DtpHasta.ValueChanged
        FechaHasta = DtpHasta.Value.ToShortDateString
        FechaHastaDB = FechaHasta.ToString("yyyy-MM-dd")
        'MsgBox(FechaDesdeDB.ToString + " " + FechaHastaDB.ToString)
    End Sub

    Private Sub CboEstacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboEstacion.SelectedIndexChanged
        BtnAceptar.Enabled = True

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        ConsultarResumen()
        ConsultarPiezasDB()
        DgvResumen.Visible = True
        DgvResumen.ReadOnly = True
        DgvResumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvResumen.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        DgvResumen.Font = New Font("Tahoma", 8, FontStyle.Regular)

        DgvPiezas.Visible = True
        DgvPiezas.ReadOnly = True
        DgvPiezas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvPiezas.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        DgvPiezas.Font = New Font("Tahoma", 7, FontStyle.Regular)
        TotalesReportePiezas()

    End Sub
    Sub ConsultarPiezasDB()
        conectarBD()

        Dim SentenciaSQL As String = "select country,destination,typepack,tracking,billingterm,qtpack,consignee,convkgs from importlevel1 where date(dateimportpkg) between '" & FechaDesdeDB & "' and '" & FechaHastaDB & "' and Estacion='" & CboEstacion.Text & "' order by field(typepack,'LTR','DOC','SPX')"
        DtConsultaPiezas = consultaSQL(SentenciaSQL)
        If DtConsultaPiezas.Rows.Count > 0 Then
            DgvPiezas.DataSource = DtConsultaPiezas
            BtnExportar.Enabled = True
        Else
            MsgBox("No se ecuentran registros en la fecha seleccionada", vbInformation, "Informacion")
        End If
        'TxtTotalGuias.Text = DgvConsultaManAdu.Rows.Count
        BtnAceptar.Enabled = False
        DesconectarBD()

    End Sub
    Sub ConsultarResumen()
        conectarBD()

        Dim SentenciaSQL As String = "select typepack,sum(qtpack),sum(convkgs) from importlevel1 where date(dateimportpkg) between '" & FechaDesdeDB & "' and '" & FechaHastaDB & "' and Estacion='" & CboEstacion.Text & "' group by typepack order by field(typepack,'LTR','DOC','SPX')"
        DtConsultaResumen = consultaSQL(SentenciaSQL)
        If DtConsultaResumen.Rows.Count > 0 Then
            DgvResumen.DataSource = DtConsultaResumen
        Else
            'MsgBox("No se ecuentran registros en la fecha seleccionada", vbInformation, "Informacion")
        End If
        'TxtTotalGuias.Text = DgvConsultaManAdu.Rows.Count
        DesconectarBD()

    End Sub
    Sub TotalesReportePiezas()
        Dim Awb, Piezas As Integer
        Dim PP, FD, FC As Integer
        Dim LTR, DOC, NDOC, PLT As Integer
        Dim PesoKG As Double
        Awb = 0
        Piezas = 0
        PesoKG = 0.00



        If DtConsultaPiezas.Rows.Count > 0 Then

            Try
                For Each drow As DataRow In DtConsultaPiezas.Rows
                    Awb = Awb + 1
                    Piezas += Convert.ToInt32(drow.Item("qtpack").ToString)
                    PesoKG += Convert.ToDouble(drow.Item("convkgs").ToString)
                    Select Case drow.Item("billingterm")
                        Case "P/P"
                            PP = PP + 1
                        Case "F/D"
                            FD = FD + 1
                        Case "F/C"
                            FC = FC + 1

                    End Select

                    Select Case drow.Item("typepack")

                        Case "LTR"
                            LTR = LTR + 1
                        Case "DOC"
                            DOC = DOC + 1
                        Case "SPX"
                            NDOC = NDOC + 1
                        Case "PLT"
                            PLT = PLT + 1

                    End Select

                Next


            Catch ex As Exception
                'MsgBox(ex.ToString)
            End Try

            TxtAWB.Text = Awb
            TxtPiezas.Text = Piezas
            TxtPesoKG.Text = PesoKG
            TxtPP.Text = PP
            TxtFD.Text = FD
            TxtFC.Text = FC
            TxtLTR.Text = LTR
            TxtDOC.Text = DOC
            TxtNDOC.Text = NDOC
            TxtPLT.Text = PLT

        End If


    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Dim save As New SaveFileDialog
        save.Filter = "Archivo Excel | *.xlsx"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
        End If
        Exportar_Excel(Me.DgvPiezas, save.FileName)
        Limpiar()

    End Sub
    Public Sub Exportar_Excel(ByVal dgv As DataGridView, ByVal pth As String)
        Try


            Dim xlApp As Object = CreateObject("Excel.Application")
            'crear una nueva hoja de calculo 
            Dim xlWB As Object = xlApp.WorkBooks.add
            Dim xlWS As Object = xlWB.WorkSheets(1)

            'exportamos los caracteres de las columnas 
            For c As Integer = 0 To DgvPiezas.Columns.Count - 1
                xlWS.cells(1, c + 1).value = DgvPiezas.Columns(c).HeaderText
            Next

            'exportamos las cabeceras de columnas 
            For r As Integer = 0 To DgvPiezas.RowCount - 1
                For c As Integer = 0 To DgvPiezas.Columns.Count - 1
                    xlWS.cells(r + 2, c + 1).value = DgvPiezas.Item(c, r).Value
                Next
            Next

            'guardamos la hoja de calculo en la ruta especificada 
            xlWB.saveas(pth)
            xlWS = Nothing
            xlWB = Nothing
            xlApp.quit()
            xlApp = Nothing


            MessageBox.Show("Exportacion Finalizada", "Informacion")

        Catch ex As Exception

            MsgBox("No Exporto nada", MsgBoxStyle.Information, "Informacion")

        End Try

    End Sub
    Sub Limpiar()

        TxtAWB.Clear()
        TxtPiezas.Clear()
        TxtPesoKG.Clear()
        TxtPP.Clear()
        TxtFD.Clear()
        TxtFC.Clear()
        TxtLTR.Clear()
        TxtDOC.Clear()
        TxtNDOC.Clear()
        TxtPLT.Clear()
        DtpDesde.Value = Now
        DtpHasta.Value = Now
        CboEstacion.Text = ""
        DtConsultaPiezas.Clear()
        DtConsultaResumen.Clear()
        BtnAceptar.Enabled = False
        BtnExportar.Enabled = False


    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()

    End Sub
End Class
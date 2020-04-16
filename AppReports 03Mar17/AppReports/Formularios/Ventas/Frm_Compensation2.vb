Imports System
Imports System.IO
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
'Imports System.Collections


Public Class Frm_Compensation2
    Dim conexion As MySqlConnection
    Dim registro As DataRow
    Dim da_import As MySqlDataAdapter
    Dim da_result As MySqlDataAdapter
    Dim da_result2 As MySqlDataAdapter
    Dim da_result3 As MySqlDataAdapter
    Dim da_delete As MySqlDataAdapter
    Dim ds_vista As DataSet
    Dim comando As MySqlCommandBuilder
    Dim comando1 As MySqlCommandBuilder
    Dim strconexion As String
    Dim fechainicio As Date
    Dim fechainicioDB As String
    Dim DsArchivoImport As DataSet
    Dim da_importLevel1 As MySqlDataAdapter
    Dim da_GuardarRegistros As MySqlDataAdapter
    Dim DtConsultaImportLevel1 As New DataTable
    Dim DtShipmentIdDuplicados As New DataTable
    Dim DtShipmentIDGuardar As New DataTable



    Private Sub Frm_Compensation2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'strconexion = "server=localhost; database=dbsolosa; uid=root; password=Ups2810"
        'strconexion = "server=192.100.16.200; database=dbsolosa; uid=root; password=upshn9048t1"
        'DgvImportacion.Columns(5).DefaultCellStyle.Format = "##,##0.00"
        'DgvImportacion.Columns(7).DefaultCellStyle.Format = "##,##0.00"
        'DgvImportacion.Columns(8).DefaultCellStyle.Format = "##,##0.00"
        fechainicio = DTPDateimportpkg.Value.ToShortDateString
        fechainicioDB = fechainicio.ToString("yyyy-MM-dd")
        'DgvImportacion2.AllowUserToAddRows = False
        'MsgBox(fechainicio & " " & fechafinal)




        'da_import = New MySqlDataAdapter("select * from  importacion", conexion)
        'da_import.FillSchema(DSImport, SchemaType.Source, "importacion")
        'da_import.Fill(DSImport, "importacion")
        'conectarDB()

        'conexion = New MySqlConnection(strconexion)
        'da_import = New MySqlDataAdapter("select * from  importacion", conexion)
        'da_import.FillSchema(DSImport, SchemaType.Source, "importacion")
        'da_import.Fill(DSImport)
        'comando = New MySqlCommandBuilder(da_import)
        conectarBD()
        DsArchivoImport = New DataSet
        da_importLevel1 = New MySqlDataAdapter("select * from  importlevel1 where idimportacion=0", conex)
        da_GuardarRegistros = New MySqlDataAdapter("select * from  importlevel1 where idimportacion=0", conex)
        da_importLevel1.FillSchema(DsArchivoImport, SchemaType.Source, "DtImportacion")
        da_GuardarRegistros.FillSchema(DsArchivoImport, SchemaType.Source, "DtShipmentIDGuardar")

        'da_importLevel1.Fill(DsArchivoImport, "DtImportacion")
        'da_GuardarRegistros.Fill(DsArchivoImport, "DtShipmentIDGuardar")
        comando = New MySqlCommandBuilder(da_importLevel1)
        comando1 = New MySqlCommandBuilder(da_GuardarRegistros)



        DsArchivoImport.Tables.Add("DtConsultaImportLevel1")
        DsArchivoImport.Tables.Add("DtShipmentIdDuplicados")


        Dgvresult.DataSource = DsArchivoImport.Tables("DtImportacion")
        DgvResumen.DataSource = DsArchivoImport.Tables("DtShipmentIDGuardar")
        BtnGuardar.Enabled = False
        BtnExportar.Enabled = False



    End Sub

    Sub GrabarRegristrosDBGHPrueba()
        conectarBD()
        Dim AgregarRegistro As MySqlCommand
        'AgregarRegistro = New MySqlCommand("insert into test(nombre) values(?nombre)", conex)
        AgregarRegistro = New MySqlCommand("insert into importlevel1gh(ShipmentID,CorrelativoGH,WeightGH,WeightUnitGH,ConvKGGH,CurrencyGH,OversizeGH,IncompleteGH,TrackingGH,FechaFileLevel1,FechaImportGRS) values(?ShipmentID,?CorrelativoGH,?WeightGH,?WeightUnitGH,?ConvKGGH,?CurrencyGH,?OversizeGH,?IncompleteGH,?TrackingGH,?FechaFileLevel1,?FechaImportGRS)", conex)
        'Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In DgvGuiasHijas.Rows
            AgregarRegistro.Parameters.Clear()
            AgregarRegistro.Parameters.Add("?ShipmentID", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("ShipmentID").Value)
            AgregarRegistro.Parameters.Add("?CorrelativoGH", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("CorrelativoGH").Value)
            AgregarRegistro.Parameters.Add("?WeightGH", MySqlDbType.Double).Value = fila.Cells("WeightGH").Value
            AgregarRegistro.Parameters.Add("?WeightUnitGH", MySqlDbType.VarChar).Value = fila.Cells("WeightUnitGH").Value
            AgregarRegistro.Parameters.Add("?ConvKGGH", MySqlDbType.Double).Value = fila.Cells("ConvKGGH").Value
            AgregarRegistro.Parameters.Add("?CurrencyGH", MySqlDbType.VarChar).Value = fila.Cells("CurrencyGH").Value
            AgregarRegistro.Parameters.Add("?OversizeGH", MySqlDbType.VarChar).Value = fila.Cells("OversizeGH").Value
            AgregarRegistro.Parameters.Add("?IncompleteGH", MySqlDbType.VarChar).Value = fila.Cells("IncompleteGH").Value
            AgregarRegistro.Parameters.Add("?TrackingGH", MySqlDbType.VarChar).Value = fila.Cells("TrackingGH").Value
            AgregarRegistro.Parameters.Add("?FechaFileLevel1", MySqlDbType.VarChar).Value = fila.Cells("FechaFileLevel1").Value
            AgregarRegistro.Parameters.Add("?FechaImportGRS", MySqlDbType.VarChar).Value = fila.Cells("FechaImportGRS").Value
            AgregarRegistro.ExecuteNonQuery()
        Next
        'MsgBox("Registros Guardados Satisfactoriamente", vbInformation, "Informacion")
        DesconectarBD()
    End Sub

    Private Sub BtnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImportar.Click
        Call LecturaArchivoLevel1()
        Call ObtenerTotales()
    End Sub


    Function FormatoFecha(ByVal fecha As String) As String
        Dim IngresoDigitos As String
        Dim IngresoGuion1 As String
        Dim CambioFormato As String

        IngresoDigitos = fecha.Insert(0, "20")

        IngresoGuion1 = IngresoDigitos.Insert(4, "-")
        CambioFormato = IngresoGuion1.Insert(7, "-")

        Return CambioFormato

    End Function
    Sub GrabarRegistroDB()

        Dim x As Integer = 0
        Dim ContadorClonado As Integer = 0

        BtnGuardar.Enabled = False
        BtnExportar.Enabled = False
        DgvImportacion2.Visible = False

        Dgvresult.Visible = True
        Dgvresult.ReadOnly = True
        Dgvresult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dgvresult.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        Dgvresult.Font = New Font("Tahoma", 7, FontStyle.Regular)

        DgvResumen.Visible = True
        DgvResumen.ReadOnly = True
        DgvResumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvResumen.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        DgvResumen.Font = New Font("Tahoma", 7, FontStyle.Regular)

        'DgvImportacion.DataSource = Nothing

        Try

            For Each Drow As DataRow In DsArchivoImport.Tables("DtImportacion").Rows
                If Drow.Item(3) = "" Or Drow.Item(21) = "" Then
                    x = x + 1
                Else

                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


        If x > 0 Then
            MsgBox("No es posible guardar registros, Datos Obligatorios en blanco", vbCritical, "Mensage")
        Else

            Try
                For Each drow As DataRow In DsArchivoImport.Tables("Dtimportacion").Rows

                    DtConsultaImportLevel1 = consultaSQL("Select * from importlevel1 where shipmentID='" & drow.Item(21) & "'")


                    If ContadorClonado < 1 Then
                        DtShipmentIdDuplicados = DtConsultaImportLevel1.Clone()
                        DtShipmentIDGuardar = DtConsultaImportLevel1.Clone()

                    End If


                    If DtConsultaImportLevel1.Rows.Count > 0 Then

                        For Each drow2 As DataRow In DtConsultaImportLevel1.Rows
                            DtShipmentIdDuplicados.ImportRow(drow2)
                        Next

                    Else
                        DsArchivoImport.Tables("DtShipmentIDGuardar").ImportRow(drow)
                    End If

                    ContadorClonado += 1

                Next

                DgvResumen.DataSource = DtShipmentIdDuplicados
                Dgvresult.DataSource = DsArchivoImport.Tables("DtShipmentIDGuardar")
                LblTotalGuiasG.Text = Dgvresult.Rows.Count.ToString
                LblTotalGuiasD.Text = DgvResumen.Rows.Count.ToString
                MsgBox("Cantidad de Guias a Guardar " + Dgvresult.Rows.Count.ToString, vbInformation)
                MsgBox("Cantidad de Guias Duplicadas " + DgvResumen.Rows.Count.ToString, vbInformation)



                If DsArchivoImport.Tables("DtShipmentIDGuardar").Rows.Count > 0 Then
                    GrabarRegistrosDBGH()
                    MsgBox("Espere mientras se graban los registros", vbInformation)
                    da_GuardarRegistros.Update(DsArchivoImport, "DtShipmentIDGuardar")
                    MsgBox("Registros grabados correctamente", vbInformation, "Grabar")
                    DgvResumen.DataSource = DsArchivoImport.Tables("DtShipmentIDGuardar")
                    Call Limpiar()
                Else

                    MsgBox("No existen guias a grabar", vbCritical, "Informacion")

                End If


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
        DesconectarBD()


    End Sub
    Sub GrabarGuiasHiajas()


    End Sub
    Sub ObtenerTotales()
        Dim Awb, Piezas As Integer
        Dim PP, FD, FC As Integer
        Dim LTR, DOC, NDOC, PLT As Integer
        Dim PesoKG As Double
        Awb = 0
        Piezas = 0
        PesoKG = 0.00



        If DsArchivoImport.Tables("Dtimportacion").Rows.Count > 0 Then
            Try
                For Each drow As DataRow In DsArchivoImport.Tables("Dtimportacion").Rows
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

            End Try

            TxtAwb.Text = Awb
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
        'MsgBox("Thentotal AWB, qtpack, convkgs " + Awb.ToString + " " + Piezas.ToString + " " + PesoKG.ToString)

    End Sub
    Sub Limpiar()
        BtnImportar.Enabled = False
        BtnGuardar.Enabled = False
        BtnExportar.Enabled = False

        If DsArchivoImport.Tables("DtImportacion").Rows.Count > 0 Then
            DsArchivoImport.Tables("DtImportacion").Clear()
        End If
        If DsArchivoImport.Tables("DtShipmentIdDuplicados").Rows.Count > 0 Then
            DsArchivoImport.Tables("DtShipmentIdDuplicados").Clear()
        End If
        If DsArchivoImport.Tables("DtShipmentIDGuardar").Rows.Count > 0 Then
            DsArchivoImport.Tables("DtShipmentIDGuardar").Clear()
        End If

        Dgvresult.DataSource = Nothing
        DgvResumen.DataSource = Nothing
        DgvImportacion2.DataSource = Nothing

        DgvImportacion2.Visible = True

        TxtAwb.Text = ""
        TxtPiezas.Text = ""
        TxtPesoKG.Text = ""
        TxtLTR.Text = ""
        TxtDOC.Text = ""
        TxtNDOC.Text = ""
        TxtPLT.Text = ""
        TxtPP.Text = ""
        TxtFD.Text = ""
        TxtFC.Text = ""
        LblTotalGuiasD.Text = ""
        LblTotalGuiasG.Text = ""

    End Sub
    Sub grabarDB()
        'Dim contador As Integer = 1
        '' typepack, qtpack, weight, strweight, convkg, declared, currencydeclared, dateimportfile)
        'Try

        '    'Recorrer los datos en DataGridView donde se almacenan tempralmente los datos  obtenidos del archico TXT
        '    For i = 0 To DgvImportacion.RowCount - 1
        '        registro = DSImport.Tables("importacion").NewRow
        '        Dim FechaDGV As Date = DgvImportacion.Item(0, i).Value
        '        Dim FechaDB As String = FechaDGV.ToString("yyyy-MM-dd")
        '        registro("dateimport") = FechaDB
        '        registro("destination") = DgvImportacion.Item(1, i).Value
        '        registro("country") = DgvImportacion.Item(2, i).Value
        '        registro("tracking") = DgvImportacion.Item(3, i).Value
        '        registro("shippername") = DgvImportacion.Item(4, i).Value
        '        registro("consignee") = DgvImportacion.Item(5, i).Value
        '        registro("billingterm") = DgvImportacion.Item(6, i).Value
        '        registro("convservicelevel") = DgvImportacion.Item(7, i).Value
        '        registro("typepack") = DgvImportacion.Item(8, i).Value
        '        registro("qtpack") = DgvImportacion.Item(9, i).Value
        '        registro("weight") = DgvImportacion.Item(10, i).Value
        '        registro("strweight") = DgvImportacion.Item(11, i).Value
        '        registro("convkgs") = DgvImportacion.Item(12, i).Value
        '        registro("declaredvalue") = DgvImportacion.Item(13, i).Value
        '        registro("currencydeclared") = DgvImportacion.Item(14, i).Value
        '        registro("consigneecontacname") = DgvImportacion.Item(15, i).Value
        '        registro("consigneephonenumber") = DgvImportacion.Item(16, i).Value
        '        registro("dateimportfile") = Now 'DgvImportacion.Item(15, i).Value
        '        registro("dateimportpkg") = Now 'DgvImportacion.Item(16, i).Value
        '        DSImport.Tables("importacion").Rows.Add(registro)
        '    Next

        '    da_import.Update(DSImport, "importacion")

        'Catch ex As Exception

        '    MsgBox(ex.ToString)

        'End Try




    End Sub


    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        DgvImportacion2.Visible = False
        Call GrabarRegistroDB()



    End Sub

    Private Sub BtnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportar.Click


        Dim save As New SaveFileDialog
        save.Filter = "Archivo Excel | *.xlsx"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
        End If
        Exportar_Excel(Me.Dgvresult, save.FileName)




    End Sub

    Private Sub DTPDateimportpkg_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPDateimportpkg.ValueChanged
        fechainicio = DTPDateimportpkg.Value.ToShortDateString
        fechainicioDB = fechainicio.ToString("yyyy-MM-dd")
        BtnImportar.Enabled = True
    End Sub

    Public Sub Exportar_Excel(ByVal dgv As DataGridView, ByVal pth As String)
        Try



            Dim xlApp As Object = CreateObject("Excel.Application")
            'crear una nueva hoja de calculo 
            Dim xlWB As Object = xlApp.WorkBooks.add
            Dim xlWS As Object = xlWB.WorkSheets(1)

            'exportamos los caracteres de las columnas 
            For c As Integer = 0 To Dgvresult.Columns.Count - 1
                xlWS.cells(1, c + 1).value = Dgvresult.Columns(c).HeaderText
            Next

            'exportamos las cabeceras de columnas 
            For r As Integer = 0 To Dgvresult.RowCount - 1
                For c As Integer = 0 To Dgvresult.Columns.Count - 1
                    xlWS.cells(r + 2, c + 1).value = Dgvresult.Item(c, r).Value
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

    Sub TotalCompensation()
        Dim Total As Double = 0.00
        Dim Piezas As Integer = 0
        Dim PP As Integer = 0
        Dim FC As Integer = 0
        Dim FD As Integer = 0


        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In Dgvresult.Rows
            Total += Convert.ToDouble(fila.Cells(5).Value)
            Piezas += Convert.ToDouble(fila.Cells(1).Value)
            If fila.Cells(3).Value = "P/P" Then
                PP = PP + 1
            End If
            If fila.Cells(3).Value = "F/C" Then
                FC = FC + 1
            End If
            If fila.Cells(3).Value = "F/D" Then
                FD = FD + 1
            End If
        Next

        TxtPesoKG.Text = Format(Total, "#,###.00")
        TxtPiezas.Text = Piezas
        'TxtPP.Text = PP
        'TxtFC.Text = FC
        'TxtFD.Text = FD


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TotalCompensation()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Call GrabarRegistroDB()
    End Sub

    Private Sub DgvImportacion2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvImportacion2.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtLTR.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtDOC.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call Limpiar()


    End Sub

    Sub ImportarOld()
        Dim sentenciaSQLVista As String
        Dim sentenciaSQLVista2 As String
        Dim sentenciaSQLVista3 As String

        grabarDB()


        Try



            'sentenciaSQLVista = "drop view If EXISTS vw_importacion;" &
            '                   "create view vw_importacion As (" &
            '                   " Select dateimport As fecha,billingterm,country,tracking As Guia,shippername As Proveedor,declaredvalue As Valor, " &
            '                   " consignee As Consignatario,typepack As Envio,qtpack As Bultos,convkgs As Peso,02_zona As Zona," &
            '                   " If(convkgs>0 And convkgs<=0.5,0.5,If(convkgs>0.5 And convkgs<=1,1,If(convkgs>=1.01 And convkgs<=1.5,1.5," &
            '                   " If(convkgs>1.5 And convkgs<=2,2,If(convkgs>=2.01 And convkgs<=2.5,2.5,If(convkgs>2.5 And convkgs<=3,3," &
            '                   " If(convkgs>=3.01 And convkgs<=3.5,3.5,If(convkgs>3.5 And convkgs<=4,4,If(convkgs>=4.01 And convkgs<=4.5,4.5," &
            '                   " If(convkgs>4.5 And convkgs<=5,5,If(convkgs>=5.01 And convkgs<=5.5,5.5,If(convkgs>5.5 And convkgs<=6,6," &
            '                   " If(convkgs>=6.01 And convkgs<=6.5,6.5,If(convkgs>6.5 And convkgs<=7,7,If(convkgs>=7.01 And convkgs<=7.5,7.5,If(convkgs>7.5 And convkgs<=8,8," &
            '                   " If(convkgs>=8.01 And convkgs<=8.5,8.5,If(convkgs>8.5 And convkgs<=9,9,If(convkgs>=9.01 And convkgs<=9.5,9.5,If(convkgs>9.5 And convkgs<=10,10," &
            '                   " If(convkgs>=10.01 And convkgs<=10.5,10.5,If(convkgs>10.5 And convkgs<=11,11,If(convkgs>=11.01 And convkgs<=11.5,11.5,If(convkgs>11.5 And convkgs<=12,12," &
            '                   " If(convkgs>=12.01 And convkgs<=12.5,12.5,If(convkgs>12.5 And convkgs<=13,13,If(convkgs>=13.01 And convkgs<=13.5,13.5,If(convkgs>13.5 And convkgs<=14,14," &
            '                   " If(convkgs>=14.01 And convkgs<=14.5,14.5,If(convkgs>14.5 And convkgs<=15,15,If(convkgs>=15.01 And convkgs<=15.5,15.5,If(convkgs>15.5 And convkgs<=16,16," &
            '                   " If(convkgs>=16.01 And convkgs<=16.5,16.5,If(convkgs>16.5 And convkgs<=17,17,If(convkgs>=17.01 And convkgs<=17.5,17.5,If(convkgs>17.5 And convkgs<=18,18," &
            '                   " If(convkgs>=18.01 And convkgs<=18.5,18.5,If(convkgs>18.5 And convkgs<=19,19,If(convkgs>=19.01 And convkgs<=19.5,19.5,If(convkgs>19.5 And convkgs<=20,20," &
            '                   " If(convkgs>=20.01 And convkgs<=20.5,20.5,If(convkgs>20.5 And convkgs<=21,21,If(convkgs>=21.01 And convkgs<=21.5,21.5,If(convkgs>21.5 And convkgs<=22,22," &
            '                   " If(convkgs>=22.01 And convkgs<=22.5,22.5,If(convkgs>22.5 And convkgs<=23,23,If(convkgs>=23.01 And convkgs<=23.5,23.5,If(convkgs>23.5 And convkgs<=24,24," &
            '                   " If(convkgs>=24.01 And convkgs<=24.5,24.5,If(convkgs>24.5 And convkgs<=25,25,If(convkgs>=25.01 And convkgs<=25.5,25.5,If(convkgs>25.5 And convkgs<=26,26," &
            '                   " If(convkgs>=26.01 And convkgs<=26.5,26.5,If(convkgs>26.5 And convkgs<=27,27,If(convkgs>=27.01 And convkgs<=27.5,27.5,If(convkgs>27.5 And convkgs<=28,28," &
            '                   " If(convkgs>=28.01 And convkgs<=28.5,28.5,If(convkgs>28.5 And convkgs<=29,29,If(convkgs>=29.01 And convkgs<=29.5,29.5,If(convkgs>29.5 And convkgs<=30,30," &
            '                   " If(convkgs>=30.01 And convkgs<=30.5,30.5,If(convkgs>30.5 And convkgs<=31,31,If(convkgs>=31.01 And convkgs<=31.5,31.5," &
            '                   " ceiling(convkgs)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))) As PesoCalculado,convservicelevel As tipo_servicio " &
            '                   " from importacion,zonas_importacion where typepack='SPX' and dateimportpkg between'" & fechainicio & "'and '" & fechafinal & "' and country=01_pais);" &
            '                   " select Guia, Consignatario, Bultos as Piezas, PesoCalculado as Peso,(05_tarifa_por_kg*Peso) as Tarifa from vw_importacion, tarifa_importacion_mayor" &
            '                   " where Peso>31.5 and 01_fdc=tipo_servicio and 02_zona=zona and envio=03_envio" &
            '                   " union all" &
            '                   " select Guia, Consignatario, Bultos as Piezas, PesoCalculado as Peso, 05_tarifa as Tarifa from vw_importacion left join tarifa_importacion on" &
            '                   " (tipo_servicio=01_fdc and pesocalculado=04_peso and envio=03_envio and zona=02_zona) where pesocalculado<=31.5"

            sentenciaSQLVista = "drop view If EXISTS vw_importacion;" &
                               "create view vw_importacion As (" &
                               " Select dateimport As fecha, billingterm, country, tracking As Guia, shippername As Proveedor, declaredvalue As Valor, " &
                               " consignee As Consignatario, typepack As Envio, qtpack As Bultos, convkgs As Peso, 02_zona As Zona, " &
                               " If(convkgs>0 And convkgs<=0.5, 0.5, If(convkgs > 0.5 And convkgs <= 1, 1, If(convkgs >= 1.01 And convkgs <= 1.5, 1.5, " &
                               " If(convkgs>1.5 And convkgs<=2,2,If(convkgs>=2.01 And convkgs<=2.5,2.5,If(convkgs>2.5 And convkgs<=3,3," &
                               " If(convkgs>=3.01 And convkgs<=3.5,3.5,If(convkgs>3.5 And convkgs<=4,4,If(convkgs>=4.01 And convkgs<=4.5,4.5," &
                               " If(convkgs>4.5 And convkgs<=5,5,If(convkgs>=5.01 And convkgs<=5.5,5.5,If(convkgs>5.5 And convkgs<=6,6," &
                               " If(convkgs>=6.01 And convkgs<=6.5,6.5,If(convkgs>6.5 And convkgs<=7,7,If(convkgs>=7.01 And convkgs<=7.5,7.5,If(convkgs>7.5 And convkgs<=8,8," &
                               " If(convkgs>=8.01 And convkgs<=8.5,8.5,If(convkgs>8.5 And convkgs<=9,9,If(convkgs>=9.01 And convkgs<=9.5,9.5,If(convkgs>9.5 And convkgs<=10,10," &
                               " If(convkgs>=10.01 And convkgs<=10.5,10.5,If(convkgs>10.5 And convkgs<=11,11,If(convkgs>=11.01 And convkgs<=11.5,11.5,If(convkgs>11.5 And convkgs<=12,12," &
                               " If(convkgs>=12.01 And convkgs<=12.5,12.5,If(convkgs>12.5 And convkgs<=13,13,If(convkgs>=13.01 And convkgs<=13.5,13.5,If(convkgs>13.5 And convkgs<=14,14," &
                               " If(convkgs>=14.01 And convkgs<=14.5,14.5,If(convkgs>14.5 And convkgs<=15,15,If(convkgs>=15.01 And convkgs<=15.5,15.5,If(convkgs>15.5 And convkgs<=16,16," &
                               " If(convkgs>=16.01 And convkgs<=16.5,16.5,If(convkgs>16.5 And convkgs<=17,17,If(convkgs>=17.01 And convkgs<=17.5,17.5,If(convkgs>17.5 And convkgs<=18,18," &
                               " If(convkgs>=18.01 And convkgs<=18.5,18.5,If(convkgs>18.5 And convkgs<=19,19,If(convkgs>=19.01 And convkgs<=19.5,19.5,If(convkgs>19.5 And convkgs<=20,20," &
                               " If(convkgs>=20.01 And convkgs<=20.5,20.5,If(convkgs>20.5 And convkgs<=21,21,If(convkgs>=21.01 And convkgs<=21.5,21.5,If(convkgs>21.5 And convkgs<=22,22," &
                               " If(convkgs>=22.01 And convkgs<=22.5,22.5,If(convkgs>22.5 And convkgs<=23,23,If(convkgs>=23.01 And convkgs<=23.5,23.5,If(convkgs>23.5 And convkgs<=24,24," &
                               " If(convkgs>=24.01 And convkgs<=24.5,24.5,If(convkgs>24.5 And convkgs<=25,25,If(convkgs>=25.01 And convkgs<=25.5,25.5,If(convkgs>25.5 And convkgs<=26,26," &
                               " If(convkgs>=26.01 And convkgs<=26.5,26.5,If(convkgs>26.5 And convkgs<=27,27,If(convkgs>=27.01 And convkgs<=27.5,27.5,If(convkgs>27.5 And convkgs<=28,28," &
                               " If(convkgs>=28.01 And convkgs<=28.5,28.5,If(convkgs>28.5 And convkgs<=29,29,If(convkgs>=29.01 And convkgs<=29.5,29.5,If(convkgs>29.5 And convkgs<=30,30," &
                               " If(convkgs>=30.01 And convkgs<=30.5,30.5,If(convkgs>30.5 And convkgs<=31,31,If(convkgs>=31.01 And convkgs<=31.5,31.5," &
                               " ceiling(convkgs)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))) As PesoCalculado,convservicelevel As tipo_servicio " &
                               " from importacion,zonas_importacion where typepack='SPX' and dateimportpkg between'" & fechainicioDB & "'and '" & fechainicioDB & "' and country=01_pais);" &
                               " drop view If EXISTS vw_compensation;" &
                               " create view vw_compensation as " &
                               " select Tracking,QtPack,TypePack,comp.BillingTerm,if(qtpack>1,'Y','N') MultiPackage,if(qtpack>1,(((qtpack-1)*(ValueMult))+ ValueSgl),ValueSgl) Compensation, ValueSgl, ValueMult " &
                               " from importacion imp,compensation comp " &
                               " where imp.typepack=comp.type and imp.BillingTerm=comp.billingterm and TypeAWB='IMPORT'; " &
                               " select * from vw_compensation "


            '" select imp.guia,imp.bultos,ifnull((comp.valuecompensation),0)Compensacion,ifnull(round(((comp.valuecompensation/100)+2.5),2),0) as Calculo,ifnull((tarimp.05_tarifa),0) Tarifa" &
            '" From vw_importacion imp inner Join compensation comp" &
            '" On (comp.Zone=imp.Zona And comp.billingterm=imp.billingterm And comp.MultiPkg=if(imp.Bultos>1,'N','S') and comp.typecompensation=1)" &
            '" inner Join tarifa_importacion tarimp" &
            '" On Peso<=31.5 And tarimp.01_fdc=tipo_servicio And tarimp.02_zona=zona And envio=tarimp.03_envio"

            sentenciaSQLVista2 = " select typepack, BillingTerm, MultiPackage, sum(qtpack), count(MultiPackage), sum(compensation) " &
                                 " From vw_compensation " &
                                 " Group By typepack, BillingTerm, MultiPackage " &
                                 " Order By field(typepack, 'LTR', 'DOC', 'SPX'), field(BillingTerm,'P/P','F/D','F/C'),field(MultiPackage,'N','Y')"

            sentenciaSQLVista3 = " select sum(compensation) " &
                                 " from vw_compensation     "


            da_result = New MySqlDataAdapter(sentenciaSQLVista, conexion)
            DSImport.Clear()
            da_result.Fill(DSImport, "vista")

            da_result2 = New MySqlDataAdapter(sentenciaSQLVista2, conexion)
            'DSImport.Clear()
            da_result2.Fill(DSImport, "compensation")
            DgvResumen.DataSource = DSImport.Tables("compensation")
            'TxtCompensation.Text = DSImport.Tables("compensation").Rows.Count

            'da_result3 = New MySqlDataAdapter(sentenciaSQLVista3, conexion)
            'DSImport.Clear()
            'da_result3.Fill(DSImport, "TotalCompensation")
            'TxtTotalComp.Text = DSImport.Tables("TotalCompensation")


            'comando = New MySqlCommandBuilder(da)
            Dgvresult.Visible = True
            DgvResumen.Visible = True
            'DgvImportacion.Visible = False
            TxtAwb.Text = DSImport.Tables("vista").Rows.Count
            Dgvresult.DataSource = DSImport.Tables("vista")
            Dgvresult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


            DgvResumen.Font = New Font("Tahoma", 6.7, FontStyle.Regular)
            DgvResumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader


            'DgvResumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'DataGridView1.ForeColor = Color.Brown
            'DataGridView1.BackgroundColor = Color.Black
            Dgvresult.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
            DgvResumen.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
            'Dgvresult.Columns(4).DefaultCellStyle.Format = "##,##0.00"
            'Dgvresult.Columns(5).DefaultCellStyle.Format = "##,##0.00"
            'Dgvresult.Columns(6).DefaultCellStyle.Format = "##,##0.00"
            'Dgvresult.ReadOnly = True
            DgvResumen.ReadOnly = True
            BtnGuardar.Enabled = False
            TotalCompensation()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dispose()

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        'DgvImportacion.Rows.Clear()
        'DgvImportacion2.Rows.Clear()


        'Try

        '    'limpia tabla temporal de importacion dbsolosa
        '    Dim SQLcommand As String = "delete from importacion"
        '    da_delete = New MySqlDataAdapter(SQLcommand, conexion)
        '    da_delete.Fill(DSImport, "importacion")


        'Catch ex As Exception
        '    'Mensaje si sucede algun error
        '    MsgBox(ex.ToString)
        'End Try
        BtnImportar.Enabled = False
        BtnExportar.Enabled = False



        Dim ds As DataSet
        Dim sr As StreamReader
        'Ruta para importacion de archivo LVL1
        Dim ruta As String = "C:\importacionUPS\import.txt"
        'Lectura de linea de archivo 
        Dim linea As String

        'Arreglos para obtener valores de archivo LVL1
        Dim nuevoregistro As Object = {"2000", "2020", "3000", "4000", "5000", "6000", "9000"}

        Dim i As Integer
        Dim j As Integer
        Dim setinput As String
        'Dim items() As DictionaryEntry
        Dim items() As ArrayList

        Dim destination As String
        Dim country As String
        Dim tracking As String
        Dim shippername As String
        Dim consignee As String
        Dim billingterm As String
        Dim servicelevel As String
        Dim convservicelevel As Double
        Dim typepack As String
        Dim convtypepack As String
        Dim qtpack As Double
        Dim weight As Double
        Dim strweight As String
        Dim convkg As Double
        Dim declared As Double
        Dim declarevalue As Double
        Dim currencydeclared As String
        Dim dateimportfile As DateTime = Now
        Dim dateimportpkg As String
        Dim DateImportPkgDB As String

        'Ultimos campos solicitados
        Dim OriginPort As String
        Dim DestinationPort As String
        Dim dateimport As String
        Dim DateImportDB As String
        Dim ShipmentType As String
        Dim ShipmentID As String
        Dim SobrePesoR As String
        Dim SobrePesoD As String
        Dim InputDate As String
        Dim Weightfirtspackage As String
        Dim WeightUnitFirtsPackage As String
        Dim FreightCollect As String
        Dim DimensionalWeigh As String
        Dim DimensionalWeightUnit As String
        Dim IncompleteShipment As String
        Dim RegionDistrict As String
        Dim PickupCenter As String
        Dim ShipperNumber As String
        Dim Building As String
        Dim Street As String
        Dim ShipperCity As String
        Dim ShipperCounty As String
        Dim ShipperState As String
        Dim ShipperCodePostal As String
        Dim ShipperCountry As String
        Dim ShipperPhoneNumber As String
        Dim Party3Account As String
        Dim Party3AccountName As String
        Dim Party3Country As String
        Dim AlternateTracking As String
        Dim ShipperContac As String
        'Datos Consignee
        Dim ConsigneeNumber As String
        Dim ConsigneeContact As String
        Dim ConsigneeBuilding As String
        Dim ConsigneeStreet As String
        Dim consigneecity As String
        Dim ConsgineeeCountry As String
        Dim ConsigneeState As String
        Dim ConsigneeCodePostal As String
        Dim ConsigneeCountryCode As String
        Dim consigneephonenumber As String
        Dim ConsigneePONumber As String
        Dim descripcion As String

        Dim DtImportacion As DataTable = New DataTable
        Dim AgregarFila As DataRow

        DtImportacion.Columns.Add("IdImportacion")
        DtImportacion.Columns.Add("destination")
        DtImportacion.Columns.Add("country")
        DtImportacion.Columns.Add("tracking")
        DtImportacion.Columns.Add("shippername")
        DtImportacion.Columns.Add("consignee")
        DtImportacion.Columns.Add("billingterm")
        DtImportacion.Columns.Add("convservicelevel")
        DtImportacion.Columns.Add("typepack")
        DtImportacion.Columns.Add("qtpack")
        DtImportacion.Columns.Add("weight")
        DtImportacion.Columns.Add("strweight")
        DtImportacion.Columns.Add("convkgs")
        DtImportacion.Columns.Add("declaredvalue")
        DtImportacion.Columns.Add("currencydeclared")
        DtImportacion.Columns.Add("dateimportfile")
        DtImportacion.Columns.Add("dateimportpkg")
        DtImportacion.Columns.Add("OriginPort")
        DtImportacion.Columns.Add("DestinationPort")
        DtImportacion.Columns.Add("ImportDate")
        DtImportacion.Columns.Add("ShipmentType")
        DtImportacion.Columns.Add("ShipmentID")
        DtImportacion.Columns.Add("SobrePesoR")
        DtImportacion.Columns.Add("SobrePesoD")
        DtImportacion.Columns.Add("InputDate")
        DtImportacion.Columns.Add("WeightFirtsPackage")
        DtImportacion.Columns.Add("WeightUnitFirtsPackage")
        DtImportacion.Columns.Add("FreightCollect")
        DtImportacion.Columns.Add("DimensionalWeight")
        DtImportacion.Columns.Add("DimensionalWeightUnit")
        DtImportacion.Columns.Add("IncompleteShipment")
        DtImportacion.Columns.Add("RegionDistrict")
        DtImportacion.Columns.Add("PickupCenter")
        DtImportacion.Columns.Add("ShipperNumber")
        DtImportacion.Columns.Add("ShipperBuilding")
        DtImportacion.Columns.Add("ShipperStreet")
        DtImportacion.Columns.Add("ShipperCity")
        DtImportacion.Columns.Add("ShipperCounty")
        DtImportacion.Columns.Add("ShipperState")
        DtImportacion.Columns.Add("ShipperCodePostal")
        DtImportacion.Columns.Add("ShipperCountry")
        DtImportacion.Columns.Add("ShipperPhoneNumber")
        DtImportacion.Columns.Add("Party3Account")
        DtImportacion.Columns.Add("Party3AccountName")
        DtImportacion.Columns.Add("Party3Country")
        DtImportacion.Columns.Add("AlternateTracking")
        DtImportacion.Columns.Add("ShipperContact")
        'Datos Consignee
        DtImportacion.Columns.Add("ConsigneeNumber")
        DtImportacion.Columns.Add("ConsigneeContactname")
        DtImportacion.Columns.Add("ConsigneeBuilding")
        DtImportacion.Columns.Add("ConsigneeStreet")
        DtImportacion.Columns.Add("ConsigneeCity")
        DtImportacion.Columns.Add("ConsigneeCountry")
        DtImportacion.Columns.Add("ConsigneeState")
        DtImportacion.Columns.Add("ConsigneeCodePostal")
        DtImportacion.Columns.Add("ConsigneeCountryCode")
        DtImportacion.Columns.Add("ConsigneePhoneNumbe")
        DtImportacion.Columns.Add("ConsigneePONumber")
        DtImportacion.Columns.Add("description")

        Dim contadorgrid As Integer = 0
        Dim registro As Boolean = False
        Dim convdeclarevalue As Double

        DgvImportacion2.Visible = True
        DgvImportacion2.ReadOnly = True
        DgvImportacion2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvImportacion2.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        DgvImportacion2.Font = New Font("Tahoma", 7, FontStyle.Regular)

        Dim CrearNuevoRegistro As Integer = 2000
        Dim ValoresdeCampos() As String = {"2000", "3000"}
        Dim ControlWhile As Boolean = False
        Dim ShipmentID2 As String



        Try

            sr = New StreamReader(ruta)
            linea = sr.ReadLine()
            MsgBox(linea)

            While Not linea Is Nothing
                j = 0
                i = i + 1
                setinput = Mid(linea, 45, 4)

                If setinput = CrearNuevoRegistro Then
                    While ControlWhile = False

                        MsgBox("Este es ciclo anidado")
                        linea = sr.ReadLine()
                        setinput = Mid(linea, 45, 4)
                        MsgBox(setinput.ToString + " Leyendo el ciclo")
                        ShipmentID2 = Mid(linea, 51, 11)
                        MsgBox(ShipmentID2.ToString + " Este es el Id de esta linea")
                        If setinput = CrearNuevoRegistro Then
                            ControlWhile = True
                        End If
                    End While


                    MsgBox(j.ToString + " Valor antes del Case")
                    Select Case nuevoregistro(j)


                        Case "2000"
                            contadorgrid = contadorgrid + 1
                            MsgBox(j.ToString + " Valor En el case 2000")
                            'Ultimos campos agregados 10May18
                            country = Mid(linea, 1, 2)
                            OriginPort = Mid(linea, 3, 4)
                            destination = Mid(linea, 7, 2)
                            DestinationPort = Mid(linea, 9, 4)
                            ShipmentType = Mid(linea, 33, 1)
                            ShipmentID = Mid(linea, 51, 11)
                            InputDate = Mid(linea, 192, 9)
                            Weightfirtspackage = Trim(Mid(linea, 201, 3))
                            WeightUnitFirtsPackage = Trim(Mid(linea, 204, 3))

                            servicelevel = Mid(linea, 220, 1)
                            If servicelevel = "S" Then
                                convservicelevel = 28
                            ElseIf servicelevel = "5" Then
                                convservicelevel = 5
                            ElseIf servicelevel = "T" Then
                                convservicelevel = 29
                            ElseIf servicelevel = "1" Then
                                convservicelevel = 1
                            End If

                            SobrePesoR = Trim(Mid(linea, 228, 1))
                            FreightCollect = Mid(linea, 229, 1)
                            SobrePesoR = Trim(Mid(linea, 238, 1))

                            'Cambiar formato del campo fecha en DB
                            dateimport = Mid(linea, 13, 6)
                            DateImportDB = FormatoFecha(dateimport)

                            billingterm = Trim(Mid(linea, 319, 3))
                            DimensionalWeigh = Trim(Mid(linea, 332, 5))
                            DimensionalWeightUnit = Mid(linea, 337, 3)
                            IncompleteShipment = Mid(linea, 369, 1)

                            convtypepack = Trim(Mid(linea, 73, 1))

                            Select Case convtypepack
                                Case "L"
                                    typepack = "LTR"
                                Case "D"
                                    typepack = "DOC"
                                Case "N"
                                    typepack = "SPX"
                                Case "P"
                                    typepack = "PLT"

                            End Select

                            'MsgBox("convtypepack " + convtypepack + " " + "typepack" + typepack)
                            'If convtypepack = "L" Then
                            '    typepack = "LTR"
                            'ElseIf convtypepack = "D" Then
                            '    typepack = "DOC"
                            'ElseIf convtypepack = "N" Then
                            '    typepack = "SPX"
                            'ElseIf convtypepack = "P" Then
                            '    typepack = "PLT"
                            'End If

                            convdeclarevalue = FormatNumber(Val(Trim(Mid(linea, 308, 11))) / 100, 2)

                            If convdeclarevalue > 0 Then
                                declared = FormatNumber(Val(Trim(Mid(linea, 308, 11))) / 100, 2)
                                currencydeclared = Trim(Mid(linea, 253, 3))
                            Else
                                declared = FormatNumber(0.0, 2)
                                currencydeclared = Format("")
                            End If

                            weight = Val(Trim(Mid(linea, 77, 5)))
                            strweight = Trim(Mid(linea, 82, 3))

                            If strweight = "LBS" Then
                                convkg = FormatNumber(Val(Trim(Mid(linea, 77, 5))) / 2.2, 1)
                            Else
                                convkg = FormatNumber((Trim(Mid(linea, 77, 5))) / 10, 1)
                            End If

                            qtpack = Val(Mid(linea, 75, 2))

                        Case "2020"
                            tracking = Trim(Mid(linea, 51, 35))

                        Case "3000"
                            shippername = Trim(Mid(linea, 69, 35))

                            'Ultimos campos agregados 10May18
                            RegionDistrict = Trim(Mid(linea, 51, 4))
                            PickupCenter = Trim(Mid(linea, 55, 4))
                            ShipperNumber = Trim(Mid(linea, 59, 10))
                            Building = Trim(Mid(linea, 104, 35))
                            Street = Trim(Mid(linea, 139, 35))
                            ShipperCity = Trim(Mid(linea, 174, 35))
                            ShipperCounty = Trim(Mid(linea, 209, 20))
                            ShipperState = Trim(Mid(linea, 229, 2))
                            ShipperCodePostal = Trim(Mid(linea, 231, 9))
                            ShipperCountry = Trim(Mid(linea, 240, 3))
                            ShipperPhoneNumber = Trim(Mid(linea, 243, 14))
                            Party3Account = Trim(Mid(linea, 271, 10))
                            Party3AccountName = Trim(Mid(linea, 281, 35))
                            Party3Country = Trim(Mid(linea, 316, 2))
                            AlternateTracking = Trim(Mid(linea, 333, 35)) 'Numero de Factura
                            ShipperContac = Trim(Mid(linea, 368, 11))

                        Case "4000"

                            consignee = Trim(Mid(linea, 69, 35))
                            'consigneecontacname = Mid(linea, 104, 25)
                            consigneecity = Trim(Mid(linea, 199, 35))
                            consigneephonenumber = Trim(Mid(linea, 268, 14))

                            'Ultimos campos agregados 10My18
                            ConsigneeNumber = Trim(Mid(linea, 59, 10))
                            'ConsigneeName = Trim(Mid(linea, 69, 35))
                            ConsigneeContact = Trim(Mid(linea, 104, 25))
                            ConsigneeBuilding = Trim(Mid(linea, 129, 35))
                            ConsigneeStreet = Trim(Mid(linea, 164, 35))
                            '
                            ConsgineeeCountry = Trim(Mid(linea, 234, 20))
                            ConsigneeState = Trim(Mid(linea, 254, 2))
                            ConsigneeCodePostal = Trim(Mid(linea, 256, 9))
                            ConsigneeCountryCode = Trim(Mid(linea, 265, 3))
                            ConsigneePONumber = Trim(Mid(linea, 296, 12)) 'Numero de PO

                            'Dgv.Rows.Add(tracking, shipper, consignee, declared, typepack, weight, strweight, convkg)
                            'DgvImportacion.Rows.Add(dateimport, destination, country, tracking, shippername, consignee, billingterm, convservicelevel, typepack, qtpack, weight, strweight, convkg, declared, currencydeclared, ConsigneeContac, consigneephonenumber, dateimportfile, dateimportpkg, OriginPort)
                            'MsgBox((DsArchivoImport.Tables.Count).ToString + " " + country.ToString)
                            MsgBox(j.ToString + " Valor antes de guardar")

                            AgregarFila = DsArchivoImport.Tables("DtImportacion").NewRow()
                            AgregarFila.Item(1) = destination
                            AgregarFila.Item(2) = country
                            AgregarFila.Item(3) = tracking
                            AgregarFila.Item(4) = shippername
                            AgregarFila.Item(5) = consignee
                            AgregarFila.Item(6) = billingterm
                            AgregarFila.Item(7) = convservicelevel
                            'MsgBox(typepack.ToString + " 1")
                            AgregarFila.Item(8) = typepack
                            'MsgBox(typepack.ToString + " 2")
                            AgregarFila.Item(9) = qtpack
                            AgregarFila.Item(10) = weight
                            AgregarFila.Item(11) = strweight
                            AgregarFila.Item(12) = convkg
                            AgregarFila.Item(13) = declared
                            AgregarFila.Item(14) = currencydeclared
                            AgregarFila.Item(15) = dateimportfile
                            AgregarFila.Item(16) = fechainicio
                            AgregarFila.Item(17) = OriginPort
                            AgregarFila.Item(18) = DestinationPort
                            AgregarFila.Item(19) = DateImportDB
                            AgregarFila.Item(20) = ShipmentType
                            AgregarFila.Item(21) = ShipmentID
                            AgregarFila.Item(22) = SobrePesoR
                            AgregarFila.Item(23) = SobrePesoD
                            AgregarFila.Item(24) = InputDate
                            If Weightfirtspackage = Nothing Then

                            Else
                                AgregarFila.Item(25) = Weightfirtspackage
                            End If
                            AgregarFila.Item(26) = WeightUnitFirtsPackage
                            AgregarFila.Item(27) = FreightCollect
                            If DimensionalWeigh = Nothing Then
                                'MsgBox("Datos Vacios" + DimensionalWeigh)
                            Else
                                'MsgBox("Opcion de datos " + DimensionalWeigh)
                                AgregarFila.Item(28) = Convert.ToDouble(DimensionalWeigh).ToString()
                            End If
                            AgregarFila.Item(39) = DimensionalWeightUnit
                            AgregarFila.Item(30) = IncompleteShipment
                            AgregarFila.Item(31) = RegionDistrict
                            AgregarFila.Item(32) = PickupCenter
                            AgregarFila.Item(33) = ShipperNumber
                            AgregarFila.Item(34) = Building
                            AgregarFila.Item(35) = Street
                            AgregarFila.Item(36) = ShipperCity
                            AgregarFila.Item(37) = ShipperCounty
                            AgregarFila.Item(38) = ShipperState
                            AgregarFila.Item(39) = ShipperCodePostal
                            AgregarFila.Item(40) = ShipperCountry
                            AgregarFila.Item(41) = ShipperPhoneNumber
                            AgregarFila.Item(42) = Party3Account
                            AgregarFila.Item(43) = Party3AccountName
                            AgregarFila.Item(44) = Party3Country
                            AgregarFila.Item(45) = AlternateTracking
                            AgregarFila.Item(46) = ShipperContac
                            AgregarFila.Item(47) = ConsigneeNumber
                            AgregarFila.Item(48) = ConsigneeContact
                            AgregarFila.Item(49) = ConsigneeBuilding
                            AgregarFila.Item(50) = ConsigneeStreet
                            AgregarFila.Item(51) = consigneecity
                            AgregarFila.Item(52) = ConsgineeeCountry
                            AgregarFila.Item(53) = ConsigneeState
                            AgregarFila.Item(54) = ConsigneeCodePostal
                            AgregarFila.Item(55) = ConsigneeCountryCode
                            AgregarFila.Item(56) = consigneephonenumber
                            AgregarFila.Item(57) = ConsigneePONumber
                            AgregarFila.Item(58) = descripcion
                            DsArchivoImport.Tables("DtImportacion").Rows.Add(AgregarFila)
                            DgvImportacion2.DataSource = DsArchivoImport.Tables("DtImportacion")


                        Case "5000"

                            descripcion = Trim(Mid(linea, 58, 104))



                    End Select



                End If

                linea = sr.ReadLine()
                MsgBox(linea.ToString + " Final del ciclo for")

            End While
            sr.Close()

            BtnGuardar.Enabled = True
            BtnImportar.Enabled = False

        Catch ex As Exception
            MsgBox("Archivo no encontrado" & ruta + ex.ToString, MsgBoxStyle.Exclamation)
        End Try

        Call ObtenerTotales()
    End Sub
    Sub LecturaArchivoLevel1()

        BtnImportar.Enabled = False
        BtnExportar.Enabled = False

        Dim ds As DataSet
        Dim sr As StreamReader
        'Ruta para importacion de archivo LVL1
        Dim ruta As String = "C:\importacionUPS\import.txt"
        'Lectura de linea de archivo 
        Dim linea As String

        'Arreglos para obtener valores de archivo LVL1
        Dim nuevoregistro As Object = {"2000", "2020", "3000", "4000", "5000", "6000", "9000"}

        Dim i As Integer
        Dim j As Integer
        Dim setinput As String
        'Dim items() As DictionaryEntry
        Dim items() As ArrayList


        Dim destination As String
        Dim country As String
        Dim tracking As String
        Dim shippername As String
        Dim consignee As String
        Dim billingterm As String
        Dim servicelevel As String
        Dim convservicelevel As Double
        Dim typepack As String
        Dim convtypepack As String
        Dim qtpack As Double
        Dim weight As Double
        Dim strweight As String
        Dim convkg As Double
        Dim declared As Double
        Dim declarevalue As Double
        Dim currencydeclared As String
        Dim dateimportfile As DateTime = Now
        Dim dateimportpkg As String
        Dim DateImportPkgDB As String

        'Ultimos campos solicitados
        Dim OriginPort As String
        Dim DestinationPort As String
        Dim dateimport As String
        Dim DateImportDB As String
        Dim ShipmentType As String
        Dim ShipmentID As String
        Dim SobrePesoR As String
        Dim SobrePesoD As String
        Dim InputDate As String
        Dim Weightfirtspackage As String
        Dim WeightUnitFirtsPackage As String
        Dim FreightCollect As String
        Dim DimensionalWeigh As String
        Dim DimensionalWeightUnit As String
        Dim IncompleteShipment As String
        Dim RegionDistrict As String
        Dim PickupCenter As String
        Dim ShipperNumber As String
        Dim Building As String
        Dim Street As String
        Dim ShipperCity As String
        Dim ShipperCounty As String
        Dim ShipperState As String
        Dim ShipperCodePostal As String
        Dim ShipperCountry As String
        Dim ShipperPhoneNumber As String
        Dim Party3Account As String
        Dim Party3AccountName As String
        Dim Party3Country As String
        Dim AlternateTracking As String
        Dim ShipperContac As String
        'Datos Consignee
        Dim ConsigneeNumber As String
        Dim ConsigneeContact As String
        Dim ConsigneeBuilding As String
        Dim ConsigneeStreet As String
        Dim consigneecity As String
        Dim ConsgineeeCountry As String
        Dim ConsigneeState As String
        Dim ConsigneeCodePostal As String
        Dim ConsigneeCountryCode As String
        Dim consigneephonenumber As String
        Dim ConsigneePONumber As String
        Dim descripcion As String
        'Guias Hijas
        Dim ShipmentIdGH As String
        Dim CorrelativoGH As String
        Dim WeightGH As Double
        Dim WeightUnitGH As String
        Dim CurrencyGH As String
        Dim OverSizeGH As String
        Dim IncompleteShipmentGH As String
        Dim TrackingGH As String
        Dim FechaLevel1 As String
        Dim FechaLevel1DB As String
        'Dim FechaActual As Date = Now
        Dim FechaActualDB As String = Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim ConvKGGH As Double





        Dim DtImportacion As DataTable = New DataTable
        Dim AgregarFila As DataRow

        DtImportacion.Columns.Add("IdImportacion")
        DtImportacion.Columns.Add("destination")
        DtImportacion.Columns.Add("country")
        DtImportacion.Columns.Add("tracking")
        DtImportacion.Columns.Add("shippername")
        DtImportacion.Columns.Add("consignee")
        DtImportacion.Columns.Add("billingterm")
        DtImportacion.Columns.Add("convservicelevel")
        DtImportacion.Columns.Add("typepack")
        DtImportacion.Columns.Add("qtpack")
        DtImportacion.Columns.Add("weight")
        DtImportacion.Columns.Add("strweight")
        DtImportacion.Columns.Add("convkgs")
        DtImportacion.Columns.Add("declaredvalue")
        DtImportacion.Columns.Add("currencydeclared")
        DtImportacion.Columns.Add("dateimportfile")
        DtImportacion.Columns.Add("dateimportpkg")
        DtImportacion.Columns.Add("OriginPort")
        DtImportacion.Columns.Add("DestinationPort")
        DtImportacion.Columns.Add("ImportDate")
        DtImportacion.Columns.Add("ShipmentType")
        DtImportacion.Columns.Add("ShipmentID")
        DtImportacion.Columns.Add("SobrePesoR")
        DtImportacion.Columns.Add("SobrePesoD")
        DtImportacion.Columns.Add("InputDate")
        DtImportacion.Columns.Add("WeightFirtsPackage")
        DtImportacion.Columns.Add("WeightUnitFirtsPackage")
        DtImportacion.Columns.Add("FreightCollect")
        DtImportacion.Columns.Add("DimensionalWeight")
        DtImportacion.Columns.Add("DimensionalWeightUnit")
        DtImportacion.Columns.Add("IncompleteShipment")
        DtImportacion.Columns.Add("RegionDistrict")
        DtImportacion.Columns.Add("PickupCenter")
        DtImportacion.Columns.Add("ShipperNumber")
        DtImportacion.Columns.Add("ShipperBuilding")
        DtImportacion.Columns.Add("ShipperStreet")
        DtImportacion.Columns.Add("ShipperCity")
        DtImportacion.Columns.Add("ShipperCounty")
        DtImportacion.Columns.Add("ShipperState")
        DtImportacion.Columns.Add("ShipperCodePostal")
        DtImportacion.Columns.Add("ShipperCountry")
        DtImportacion.Columns.Add("ShipperPhoneNumber")
        DtImportacion.Columns.Add("Party3Account")
        DtImportacion.Columns.Add("Party3AccountName")
        DtImportacion.Columns.Add("Party3Country")
        DtImportacion.Columns.Add("AlternateTracking")
        DtImportacion.Columns.Add("ShipperContact")
        'Datos Consignee
        DtImportacion.Columns.Add("ConsigneeNumber")
        DtImportacion.Columns.Add("ConsigneeContactname")
        DtImportacion.Columns.Add("ConsigneeBuilding")
        DtImportacion.Columns.Add("ConsigneeStreet")
        DtImportacion.Columns.Add("ConsigneeCity")
        DtImportacion.Columns.Add("ConsigneeCountry")
        DtImportacion.Columns.Add("ConsigneeState")
        DtImportacion.Columns.Add("ConsigneeCodePostal")
        DtImportacion.Columns.Add("ConsigneeCountryCode")
        DtImportacion.Columns.Add("ConsigneePhoneNumbe")
        DtImportacion.Columns.Add("ConsigneePONumber")
        DtImportacion.Columns.Add("description")

        Dim contadorgrid As Integer = 0
        Dim registro As Boolean = False
        Dim convdeclarevalue As Double
        Dim NumeroRegistro As String
        Dim Control As Boolean = True
        Dim IniciarCicloInformacion As String = "2000"


        DgvImportacion2.Visible = True
        DgvImportacion2.ReadOnly = True
        DgvImportacion2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvImportacion2.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        DgvImportacion2.Font = New Font("Tahoma", 7, FontStyle.Regular)


        Try

            sr = New StreamReader(ruta)
            linea = sr.ReadLine()

            While Not linea Is Nothing

                setinput = Mid(linea, 45, 4)


                If IniciarCicloInformacion = setinput Then
                    While Control = True

                        nuevoregistro = Mid(linea, 45, 4)

                    Select Case nuevoregistro

                            Case "2000"
                                contadorgrid = contadorgrid + 1
                                'Ultimos campos agregados 10May18
                                country = Mid(linea, 1, 2)
                                OriginPort = Mid(linea, 3, 4)
                                destination = Mid(linea, 7, 2)
                            DestinationPort = Mid(linea, 9, 4)
                            ShipmentType = Mid(linea, 33, 1)
                            ShipmentID = Mid(linea, 51, 11)
                            InputDate = Mid(linea, 192, 9)
                            Weightfirtspackage = Trim(Mid(linea, 201, 3))
                            WeightUnitFirtsPackage = Trim(Mid(linea, 204, 3))

                            servicelevel = Mid(linea, 220, 1)
                            If servicelevel = "S" Then
                                convservicelevel = 28
                            ElseIf servicelevel = "5" Then
                                convservicelevel = 5
                            ElseIf servicelevel = "T" Then
                                convservicelevel = 29
                            ElseIf servicelevel = "1" Then
                                convservicelevel = 1
                            End If

                            SobrePesoR = Trim(Mid(linea, 228, 1))
                            FreightCollect = Mid(linea, 229, 1)
                            SobrePesoR = Trim(Mid(linea, 238, 1))

                            'Cambiar formato del campo fecha en DB
                            dateimport = Mid(linea, 13, 6)
                            DateImportDB = FormatoFecha(dateimport)

                            billingterm = Trim(Mid(linea, 319, 3))
                            DimensionalWeigh = Trim(Mid(linea, 332, 5))
                            DimensionalWeightUnit = Mid(linea, 337, 3)
                            IncompleteShipment = Mid(linea, 369, 1)

                            convtypepack = Trim(Mid(linea, 73, 1))

                            Select Case convtypepack
                                Case "L"
                                    typepack = "LTR"
                                Case "D"
                                    typepack = "DOC"
                                Case "N"
                                    typepack = "SPX"
                                    Case "P"
                                        typepack = "PLT"

                                End Select


                                convdeclarevalue = FormatNumber(Val(Trim(Mid(linea, 308, 11))) / 100, 2)

                            If convdeclarevalue > 0 Then
                                declared = FormatNumber(Val(Trim(Mid(linea, 308, 11))) / 100, 2)
                                currencydeclared = Trim(Mid(linea, 253, 3))
                            Else
                                declared = FormatNumber(0.0, 2)
                                currencydeclared = Format("")
                            End If

                            weight = Val(Trim(Mid(linea, 77, 5)))
                            strweight = Trim(Mid(linea, 82, 3))

                            If strweight = "LBS" Then
                                convkg = FormatNumber(Val(Trim(Mid(linea, 77, 5))) / 2.2, 1)
                            Else
                                convkg = FormatNumber((Trim(Mid(linea, 77, 5))) / 10, 1)
                            End If

                            qtpack = Val(Mid(linea, 75, 2))

                        Case "2020"
                            tracking = Trim(Mid(linea, 51, 35))

                        Case "3000"
                            shippername = Trim(Mid(linea, 69, 35))

                            'Ultimos campos agregados 10May18
                            RegionDistrict = Trim(Mid(linea, 51, 4))
                            PickupCenter = Trim(Mid(linea, 55, 4))
                            ShipperNumber = Trim(Mid(linea, 59, 10))
                            Building = Trim(Mid(linea, 104, 35))
                            Street = Trim(Mid(linea, 139, 35))
                            ShipperCity = Trim(Mid(linea, 174, 35))
                            ShipperCounty = Trim(Mid(linea, 209, 20))
                            ShipperState = Trim(Mid(linea, 229, 2))
                            ShipperCodePostal = Trim(Mid(linea, 231, 9))
                            ShipperCountry = Trim(Mid(linea, 240, 3))
                            ShipperPhoneNumber = Trim(Mid(linea, 243, 14))
                            Party3Account = Trim(Mid(linea, 271, 10))
                            Party3AccountName = Trim(Mid(linea, 281, 35))
                            Party3Country = Trim(Mid(linea, 316, 2))
                            AlternateTracking = Trim(Mid(linea, 333, 35)) 'Numero de Factura
                            ShipperContac = Trim(Mid(linea, 368, 11))

                        Case "4000"

                            consignee = Trim(Mid(linea, 69, 35))
                            'consigneecontacname = Mid(linea, 104, 25)
                            consigneecity = Trim(Mid(linea, 199, 35))
                            consigneephonenumber = Trim(Mid(linea, 268, 14))

                            'Ultimos campos agregados 10My18
                            ConsigneeNumber = Trim(Mid(linea, 59, 10))
                            'ConsigneeName = Trim(Mid(linea, 69, 35))
                            ConsigneeContact = Trim(Mid(linea, 104, 25))
                            ConsigneeBuilding = Trim(Mid(linea, 129, 35))
                            ConsigneeStreet = Trim(Mid(linea, 164, 35))
                            '
                            ConsgineeeCountry = Trim(Mid(linea, 234, 20))
                            ConsigneeState = Trim(Mid(linea, 254, 2))
                            ConsigneeCodePostal = Trim(Mid(linea, 256, 9))
                            ConsigneeCountryCode = Trim(Mid(linea, 265, 3))
                            ConsigneePONumber = Trim(Mid(linea, 296, 12)) 'Numero de PO


                            Case "5000"

                                descripcion = Trim(Mid(linea, 58, 104))
                            Case "6000"

                                FechaLevel1 = (Trim(Mid(linea, 13, 6)))
                                FechaLevel1DB = FormatoFecha(FechaLevel1)

                                ShipmentIdGH = (Trim(Mid(linea, 34, 11)))
                                CorrelativoGH = (Trim(Mid(linea, 50, 1)))
                                WeightGH = Val(Trim(Mid(linea, 66, 3)))
                                WeightUnitGH = (Trim(Mid(linea, 69, 3)))

                                If WeightUnitGH = "LBS" Then
                                    ConvKGGH = FormatNumber(Val(Trim(Mid(linea, 66, 5))) / 2.2, 1)
                                Else
                                    ConvKGGH = FormatNumber(Val(Trim(Mid(linea, 66, 5))) / 10, 1)
                                End If

                                CurrencyGH = (Trim(Mid(linea, 81, 3)))
                                OverSizeGH = (Trim(Mid(linea, 96, 1)))
                                IncompleteShipmentGH = (Trim(Mid(linea, 165, 1)))
                                TrackingGH = (Trim(Mid(linea, 167, 35)))

                                DgvGuiasHijas.Rows.Add(ShipmentID, CorrelativoGH, WeightGH, WeightUnitGH, ConvKGGH, CurrencyGH, OverSizeGH, IncompleteShipmentGH, TrackingGH, FechaLevel1DB, FechaActualDB)

                        End Select

                        linea = sr.ReadLine()

                        If linea = Nothing Then
                            'MsgBox("Graba ultimo Registro y " + "Fuera por Fin de lectura")
                            AgregarFila = DsArchivoImport.Tables("DtImportacion").NewRow()
                            AgregarFila.Item(1) = destination
                            AgregarFila.Item(2) = country
                            AgregarFila.Item(3) = tracking
                            AgregarFila.Item(4) = shippername
                            AgregarFila.Item(5) = consignee
                            AgregarFila.Item(6) = billingterm
                            AgregarFila.Item(7) = convservicelevel
                            'MsgBox(typepack.ToString + " 1")
                            AgregarFila.Item(8) = typepack
                            'MsgBox(typepack.ToString + " 2")
                            AgregarFila.Item(9) = qtpack
                            AgregarFila.Item(10) = weight
                            AgregarFila.Item(11) = strweight
                            AgregarFila.Item(12) = convkg
                            AgregarFila.Item(13) = declared
                            AgregarFila.Item(14) = currencydeclared
                            AgregarFila.Item(15) = dateimportfile
                            AgregarFila.Item(16) = fechainicioDB
                            AgregarFila.Item(17) = OriginPort
                            AgregarFila.Item(18) = DestinationPort
                            AgregarFila.Item(19) = DateImportDB
                            AgregarFila.Item(20) = ShipmentType
                            AgregarFila.Item(21) = ShipmentID
                            AgregarFila.Item(22) = SobrePesoR
                            AgregarFila.Item(23) = SobrePesoD
                            AgregarFila.Item(24) = InputDate
                            If Weightfirtspackage = Nothing Then

                            Else
                                AgregarFila.Item(25) = Weightfirtspackage
                            End If
                            AgregarFila.Item(26) = WeightUnitFirtsPackage
                            AgregarFila.Item(27) = FreightCollect
                            If DimensionalWeigh = Nothing Then
                                'MsgBox("Datos Vacios" + DimensionalWeigh)
                            Else
                                'MsgBox("Opcion de datos " + DimensionalWeigh)
                                AgregarFila.Item(28) = Convert.ToDouble(DimensionalWeigh).ToString()
                            End If
                            AgregarFila.Item(39) = DimensionalWeightUnit
                            AgregarFila.Item(30) = IncompleteShipment
                            AgregarFila.Item(31) = RegionDistrict
                            AgregarFila.Item(32) = PickupCenter
                            AgregarFila.Item(33) = ShipperNumber
                            AgregarFila.Item(34) = Building
                            AgregarFila.Item(35) = Street
                            AgregarFila.Item(36) = ShipperCity
                            AgregarFila.Item(37) = ShipperCounty
                            AgregarFila.Item(38) = ShipperState
                            AgregarFila.Item(39) = ShipperCodePostal
                            AgregarFila.Item(40) = ShipperCountry
                            AgregarFila.Item(41) = ShipperPhoneNumber
                            AgregarFila.Item(42) = Party3Account
                            AgregarFila.Item(43) = Party3AccountName
                            AgregarFila.Item(44) = Party3Country
                            AgregarFila.Item(45) = AlternateTracking
                            AgregarFila.Item(46) = ShipperContac
                            AgregarFila.Item(47) = ConsigneeNumber
                            AgregarFila.Item(48) = ConsigneeContact
                            AgregarFila.Item(49) = ConsigneeBuilding
                            AgregarFila.Item(50) = ConsigneeStreet
                            AgregarFila.Item(51) = consigneecity
                            AgregarFila.Item(52) = ConsgineeeCountry
                            AgregarFila.Item(53) = ConsigneeState
                            AgregarFila.Item(54) = ConsigneeCodePostal
                            AgregarFila.Item(55) = ConsigneeCountryCode
                            AgregarFila.Item(56) = consigneephonenumber
                            AgregarFila.Item(57) = ConsigneePONumber
                            AgregarFila.Item(58) = descripcion
                            AgregarFila.Item(59) = "SAP"
                            DsArchivoImport.Tables("DtImportacion").Rows.Add(AgregarFila)
                            DgvImportacion2.DataSource = DsArchivoImport.Tables("DtImportacion")
                            Control = False
                        End If


                        If (Mid(linea, 45, 4)) = "2000" Then

                            AgregarFila = DsArchivoImport.Tables("DtImportacion").NewRow()
                            AgregarFila.Item(1) = destination
                            AgregarFila.Item(2) = country
                            AgregarFila.Item(3) = tracking
                            AgregarFila.Item(4) = shippername
                            AgregarFila.Item(5) = consignee
                            AgregarFila.Item(6) = billingterm
                            AgregarFila.Item(7) = convservicelevel
                            'MsgBox(typepack.ToString + " 1")
                            AgregarFila.Item(8) = typepack
                            'MsgBox(typepack.ToString + " 2")
                            AgregarFila.Item(9) = qtpack
                            AgregarFila.Item(10) = weight
                            AgregarFila.Item(11) = strweight
                            AgregarFila.Item(12) = convkg
                            AgregarFila.Item(13) = declared
                            AgregarFila.Item(14) = currencydeclared
                            AgregarFila.Item(15) = dateimportfile
                            AgregarFila.Item(16) = fechainicio
                            AgregarFila.Item(17) = OriginPort
                            AgregarFila.Item(18) = DestinationPort
                            AgregarFila.Item(19) = DateImportDB
                            AgregarFila.Item(20) = ShipmentType
                            AgregarFila.Item(21) = ShipmentID
                            AgregarFila.Item(22) = SobrePesoR
                            AgregarFila.Item(23) = SobrePesoD
                            AgregarFila.Item(24) = InputDate
                            If Weightfirtspackage = Nothing Then

                            Else
                                AgregarFila.Item(25) = Weightfirtspackage
                            End If
                            AgregarFila.Item(26) = WeightUnitFirtsPackage
                            AgregarFila.Item(27) = FreightCollect
                            If DimensionalWeigh = Nothing Then
                                'MsgBox("Datos Vacios" + DimensionalWeigh)
                            Else
                                'MsgBox("Opcion de datos " + DimensionalWeigh)
                                AgregarFila.Item(28) = Convert.ToDouble(DimensionalWeigh).ToString()
                            End If
                            AgregarFila.Item(39) = DimensionalWeightUnit
                            AgregarFila.Item(30) = IncompleteShipment
                            AgregarFila.Item(31) = RegionDistrict
                            AgregarFila.Item(32) = PickupCenter
                            AgregarFila.Item(33) = ShipperNumber
                            AgregarFila.Item(34) = Building
                            AgregarFila.Item(35) = Street
                            AgregarFila.Item(36) = ShipperCity
                            AgregarFila.Item(37) = ShipperCounty
                            AgregarFila.Item(38) = ShipperState
                            AgregarFila.Item(39) = ShipperCodePostal
                            AgregarFila.Item(40) = ShipperCountry
                            AgregarFila.Item(41) = ShipperPhoneNumber
                            AgregarFila.Item(42) = Party3Account
                            AgregarFila.Item(43) = Party3AccountName
                            AgregarFila.Item(44) = Party3Country
                            AgregarFila.Item(45) = AlternateTracking
                            AgregarFila.Item(46) = ShipperContac
                            AgregarFila.Item(47) = ConsigneeNumber
                            AgregarFila.Item(48) = ConsigneeContact
                            AgregarFila.Item(49) = ConsigneeBuilding
                            AgregarFila.Item(50) = ConsigneeStreet
                            AgregarFila.Item(51) = consigneecity
                            AgregarFila.Item(52) = ConsgineeeCountry
                            AgregarFila.Item(53) = ConsigneeState
                            AgregarFila.Item(54) = ConsigneeCodePostal
                            AgregarFila.Item(55) = ConsigneeCountryCode
                            AgregarFila.Item(56) = consigneephonenumber
                            AgregarFila.Item(57) = ConsigneePONumber
                            AgregarFila.Item(58) = descripcion
                            AgregarFila.Item(59) = "SAP"
                            DsArchivoImport.Tables("DtImportacion").Rows.Add(AgregarFila)
                            DgvImportacion2.DataSource = DsArchivoImport.Tables("DtImportacion")
                            'MsgBox("Grabando registro en tabla local")
                            descripcion = ""
                        End If

                    End While

                End If


                linea = sr.ReadLine()
                'MsgBox(linea.ToString + " Final del ciclo for")

            End While
            sr.Close()
            BtnGuardar.Enabled = True
            BtnImportar.Enabled = False

        Catch ex As Exception
            MsgBox("Archivo no encontrado" & ruta + ex.ToString, MsgBoxStyle.Exclamation)
        End Try

        Call ObtenerTotales()

    End Sub


    Sub GrabarRegistrosDBGH()
        For Each DataRowGH As DataGridViewRow In DgvGuiasHijas.Rows
            For Each DataRowDTGuardar As DataRow In DsArchivoImport.Tables("DtShipmentIDGuardar").Rows
                If DataRowGH.Cells("ShipmentID").Value.ToString = DataRowDTGuardar.Item(21).ToString Then
                    'MsgBox("Existe " + DataRowGH.Cells("ShipmentID").Value.ToString + " " + DataRowDTGuardar.Item(21).ToString)
                    Dim AgregarRegistro As MySqlCommand
                    AgregarRegistro = New MySqlCommand("insert into importlevel1gh(ShipmentID,CorrelativoGH,WeightGH,WeightUnitGH,ConvKGGH,CurrencyGH,OversizeGH,IncompleteGH,TrackingGH,FechaFileLevel1,FechaImportGRS) values(?ShipmentID,?CorrelativoGH,?WeightGH,?WeightUnitGH,?ConvKGGH,?CurrencyGH,?OversizeGH,?IncompleteGH,?TrackingGH,?FechaFileLevel1,?FechaImportGRS)", conex)
                    AgregarRegistro.Parameters.Clear()
                    AgregarRegistro.Parameters.Add("?ShipmentID", MySqlDbType.VarChar).Value = Convert.ToString(DataRowGH.Cells("ShipmentID").Value)
                    AgregarRegistro.Parameters.Add("?CorrelativoGH", MySqlDbType.VarChar).Value = Convert.ToString(DataRowGH.Cells("CorrelativoGH").Value)
                    AgregarRegistro.Parameters.Add("?WeightGH", MySqlDbType.Double).Value = DataRowGH.Cells("WeightGH").Value
                    AgregarRegistro.Parameters.Add("?WeightUnitGH", MySqlDbType.VarChar).Value = DataRowGH.Cells("WeightUnitGH").Value
                    AgregarRegistro.Parameters.Add("?ConvKGGH", MySqlDbType.Double).Value = DataRowGH.Cells("ConvKGGH").Value
                    AgregarRegistro.Parameters.Add("?CurrencyGH", MySqlDbType.VarChar).Value = DataRowGH.Cells("CurrencyGH").Value
                    AgregarRegistro.Parameters.Add("?OversizeGH", MySqlDbType.VarChar).Value = DataRowGH.Cells("OversizeGH").Value
                    AgregarRegistro.Parameters.Add("?IncompleteGH", MySqlDbType.VarChar).Value = DataRowGH.Cells("IncompleteGH").Value
                    AgregarRegistro.Parameters.Add("?TrackingGH", MySqlDbType.VarChar).Value = DataRowGH.Cells("TrackingGH").Value
                    AgregarRegistro.Parameters.Add("?FechaFileLevel1", MySqlDbType.VarChar).Value = DataRowGH.Cells("FechaFileLevel1").Value
                    AgregarRegistro.Parameters.Add("?FechaImportGRS", MySqlDbType.VarChar).Value = DataRowGH.Cells("FechaImportGRS").Value
                    AgregarRegistro.ExecuteNonQuery()
                End If
            Next
        Next

    End Sub

End Class
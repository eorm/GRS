Imports System
Imports System.IO
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
'Imports System.Collections

Public Class Frm_manifiesto3
    Dim conexion As MySqlConnection
    Dim registro As DataRow
    Dim da_import As MySqlDataAdapter
    Dim da_result As MySqlDataAdapter
    Dim da_delete As MySqlDataAdapter
    Dim ds_vista As DataSet
    Dim comando As MySqlCommandBuilder
    Dim strconexion As String
    Dim fechainicio As String
    Dim fechafinal As String


    Private Sub Frm_Manifiesto3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'conex.ConnectionString = "server=192.100.16.200; database=dbsolosa; uid=root; password=upshn9048t1"
        strconexion = "server=localhost; database=dbsolosa; uid=root; password=Ups2810"
        DgvImportacion.Columns(10).DefaultCellStyle.Format = "##,##0.00"
        DgvImportacion.Columns(10).DefaultCellStyle.Format = "##,##0.00"
        DgvImportacion.Columns(14).DefaultCellStyle.Format = "##,##0.00"
        fechainicio = DTPDateimportpkg.Value.Year & "/" & DTPDateimportpkg.Value.Month & "/" & DTPDateimportpkg.Value.Day
        fechafinal = DTPDateimportpkg.Value.Year & "/" & DTPDateimportpkg.Value.Month & "/" & DTPDateimportpkg.Value.Day

        'MsgBox(fechainicio & " " & fechafinal)
        'da_import = New MySqlDataAdapter("select * from  importacion", conexion)
        'da_import.FillSchema(DSImport, SchemaType.Source, "importacion")
        'da_import.Fill(DSImport, "importacion")
        'conectarDB()

        conexion = New MySqlConnection(strconexion)
        da_import = New MySqlDataAdapter("select * from  importacion", conexion)
        da_import.FillSchema(DSImport, SchemaType.Source, "importacion")
        da_import.Fill(DSImport)
        comando = New MySqlCommandBuilder(da_import)

    End Sub

    Private Sub BtnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImportar.Click
        DgvImportacion.Rows.Clear()

        Try


            Dim SQLcommand As String = "delete from importacion"
            da_delete = New MySqlDataAdapter(SQLcommand, conexion)
            da_delete.Fill(DSImport, "importacion")


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dim ds As DataSet
        Dim fila As DataRow
        Dim sr As StreamReader
        Dim ruta As String = "C:\importacionUPS\import.txt"
        Dim linea As String
        Dim nuevoregistro As Object = {"2000", "2020", "3000", "4000", "5000"}
        Dim i As Integer
        Dim j As Integer
        Dim setinput As String
        'Dim items() As DictionaryEntry
        Dim items() As ArrayList

        Dim country As String
        Dim destination As String
        Dim convdateimport As String
        Dim dateimport As DateTime
        Dim tracking As String
        Dim idtracking As String
        Dim servicelevel As String
        Dim convservicelevel As Double
        Dim descripcion As String
        Dim shipper As String
        Dim consignee As String
        Dim declared As Double
        Dim currencydeclared As String
        Dim billingterm As String
        Dim typepack As String
        Dim convtypepack As String
        Dim qtpack As Double
        Dim declarevalue As Double
        Dim weight As Double
        Dim strweight As String
        Dim shippername As String
        Dim contadorgrid As Integer = 0
        Dim registro As Boolean = False
        Dim convdeclarevalue As Double
        Dim convkg As Double
        Dim convkgt As Double
        Dim dateimportfile As DateTime = Today
        Dim dateimportpkg As DateTime = Now
        Dim consigneecontacname As String
        Dim consigneephonenumber As String
        Dim consigneecity As String











        'FormatNumber(Val(Trim(Mid(linea, 77, 5))) / 10, 1)

        Try




            sr = New StreamReader(ruta)
            linea = sr.ReadLine()
            While Not linea Is Nothing
                j = 0
                i = i + 1

                setinput = Mid(linea, 45, 4)


                For j = 0 To 4
                    If setinput = nuevoregistro(j) Then

                        Select Case nuevoregistro(j)

                            Case "2000"
                                contadorgrid = contadorgrid + 1

                                country = Mid(linea, 1, 2)
                                destination = Mid(linea, 7, 2)

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

                                Dim pattern As String = "yyMMdd"
                                convdateimport = Mid(linea, 13, 6)
                                'convdateimport = Mid(linea, 13, 2) & "/" & Mid(linea, 15, 2) & "/" & Mid(linea, 17, 2)
                                DateTime.TryParseExact(convdateimport, pattern, Nothing, Globalization.DateTimeStyles.None, dateimport)
                                'dateimport = Date.TryParseExact(convdateimport, "dd/mm/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
                                'dateimport = CDate(convdateimport)

                                billingterm = Trim(Mid(linea, 319, 3))

                                convtypepack = Trim(Mid(linea, 73, 1))
                                If convtypepack = "L" Then
                                    typepack = "LTR"
                                ElseIf convtypepack = "D" Then
                                    typepack = "DOC"
                                ElseIf convtypepack = "N" Then
                                    typepack = "SPX"
                                ElseIf convtypepack = "P" Then
                                    typepack = "PLT"

                                End If


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
                                    convkg = Val(Trim(Mid(linea, 77, 5))) / 2.2
                                Else
                                    convkg = FormatNumber((Trim(Mid(linea, 77, 5))) / 10, 1)
                                End If

                                shipper = Trim(Mid(linea, 51, 11))
                                qtpack = Val(Mid(linea, 75, 2))

                            Case "2020"
                                tracking = Trim(Mid(linea, 51, 35))
                                idtracking = Trim(Mid(linea, 34, 11))

                            Case "3000"
                                shippername = Trim(Mid(linea, 69, 35))

                            Case "4000"

                                consignee = Mid(linea, 69, 35)
                                consigneecontacname = Mid(linea, 104, 25)
                                'consigneecity = Mid(linea, 199, 35)
                                consigneephonenumber = Mid(linea, 268, 14)



                                'Dgv.Rows.Add(tracking, shipper, consignee, declared, typepack, weight, strweight, convkg)
                                DgvImportacion.Rows.Add(dateimport, destination, country, idtracking, tracking, shippername, consignee, billingterm, convservicelevel, typepack, qtpack, weight, strweight, convkg, declared, currencydeclared, consigneecontacname, consigneephonenumber, dateimportfile, dateimportpkg)


                                'Case "5000"

                                'descripcion = Trim(Mid(linea, 58, 104))





                        End Select




                    End If



                Next

                linea = sr.ReadLine()


            End While
            'MsgBox(contadorgrid)
            sr.Close()
            Dim totallist As Integer = DgvImportacion.Rows.Count - 1
            MsgBox(totallist)
            'MsgBox(i & " " & j, MsgBoxStyle.Information, "Informe")
            'Label1.Text = Dgv.Rows.Count
            BtnCalcular.Enabled = True
            BtnImportar.Enabled = False
        Catch ex As Exception
            'MsgBox("Archivo no encontrado" & ruta, MsgBoxStyle.Exclamation)
            MsgBox(ex.ToString)
        End Try

    End Sub


    Sub grabarDB()

        Dim contador As Integer = 1
        ' typepack, qtpack, weight, strweight, convkg, declared, currencydeclared, dateimportfile)
        Try


            For i = 0 To DgvImportacion.RowCount - 2
                registro = DSImport.Tables("importacion").NewRow
                'registro("idimportacion") = i + 1
                registro("dateimport") = Now  'DgvImportacion.Item(0, i).Value
                registro("destination") = DgvImportacion.Item(1, i).Value
                registro("country") = DgvImportacion.Item(2, i).Value
                registro("idtracking") = DgvImportacion.Item(3, i).Value
                registro("tracking") = DgvImportacion.Item(4, i).Value
                registro("shippername") = DgvImportacion.Item(5, i).Value
                registro("consignee") = DgvImportacion.Item(6, i).Value
                registro("billingterm") = DgvImportacion.Item(7, i).Value
                registro("convservicelevel") = DgvImportacion.Item(8, i).Value
                registro("typepack") = DgvImportacion.Item(9, i).Value
                registro("qtpack") = DgvImportacion.Item(10, i).Value
                registro("weight") = DgvImportacion.Item(11, i).Value
                registro("strweight") = DgvImportacion.Item(12, i).Value
                registro("convkgs") = DgvImportacion.Item(13, i).Value
                registro("declaredvalue") = DgvImportacion.Item(14, i).Value
                registro("currencydeclared") = DgvImportacion.Item(15, i).Value
                registro("consigneecontacname") = DgvImportacion.Item(16, i).Value
                registro("consigneephonenumber") = DgvImportacion.Item(17, i).Value
                registro("dateimportfile") = Now 'DgvImportacion.Item(15, i).Value
                registro("dateimportpkg") = Now 'DgvImportacion.Item(16, i).Value
                DSImport.Tables("importacion").Rows.Add(registro)
            Next
            da_import.Update(DSImport, "importacion")

        Catch ex As Exception
            MsgBox(DgvImportacion.RowCount)
            MsgBox(ex.ToString)

        End Try




    End Sub


    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click

        Dim sentenciaSQLVista As String
        grabarDB()

        Try



            sentenciaSQLVista = "drop view if EXISTS vw_importacion;" &
                               "create view vw_importacion as (" &
                               " select dateimport as fecha,country,tracking as Guia,shippername as Proveedor,declaredvalue as Valor, " &
                               " consignee as Consignatario,typepack as Envio,qtpack as Bultos,convkgs as Peso,02_zona as Zona," &
                               " if(convkgs>0 and convkgs<=0.5,0.5,if(convkgs>0.5 and convkgs<=1,1,if(convkgs>=1.01 and convkgs<=1.5,1.5," &
                               " if(convkgs>1.5 and convkgs<=2,2,if(convkgs>=2.01 and convkgs<=2.5,2.5,if(convkgs>2.5 and convkgs<=3,3," &
                               " if(convkgs>=3.01 and convkgs<=3.5,3.5,if(convkgs>3.5 and convkgs<=4,4,if(convkgs>=4.01 and convkgs<=4.5,4.5," &
                               " if(convkgs>4.5 and convkgs<=5,5,if(convkgs>=5.01 and convkgs<=5.5,5.5,if(convkgs>5.5 and convkgs<=6,6," &
                               " if(convkgs>=6.01 and convkgs<=6.5,6.5,if(convkgs>6.5 and convkgs<=7,7,if(convkgs>=7.01 and convkgs<=7.5,7.5,if(convkgs>7.5 and convkgs<=8,8," &
                               " if(convkgs>=8.01 and convkgs<=8.5,8.5,if(convkgs>8.5 and convkgs<=9,9,if(convkgs>=9.01 and convkgs<=9.5,9.5,if(convkgs>9.5 and convkgs<=10,10," &
                               " if(convkgs>=10.01 and convkgs<=10.5,10.5,if(convkgs>10.5 and convkgs<=11,11,if(convkgs>=11.01 and convkgs<=11.5,11.5,if(convkgs>11.5 and convkgs<=12,12," &
                               " if(convkgs>=12.01 and convkgs<=12.5,12.5,if(convkgs>12.5 and convkgs<=13,13,if(convkgs>=13.01 and convkgs<=13.5,13.5,if(convkgs>13.5 and convkgs<=14,14," &
                               " if(convkgs>=14.01 and convkgs<=14.5,14.5,if(convkgs>14.5 and convkgs<=15,15,if(convkgs>=15.01 and convkgs<=15.5,15.5,if(convkgs>15.5 and convkgs<=16,16," &
                               " if(convkgs>=16.01 and convkgs<=16.5,16.5,if(convkgs>16.5 and convkgs<=17,17,if(convkgs>=17.01 and convkgs<=17.5,17.5,if(convkgs>17.5 and convkgs<=18,18," &
                               " if(convkgs>=18.01 and convkgs<=18.5,18.5,if(convkgs>18.5 and convkgs<=19,19,if(convkgs>=19.01 and convkgs<=19.5,19.5,if(convkgs>19.5 and convkgs<=20,20," &
                               " if(convkgs>=20.01 and convkgs<=20.5,20.5,if(convkgs>20.5 and convkgs<=21,21,if(convkgs>=21.01 and convkgs<=21.5,21.5,if(convkgs>21.5 and convkgs<=22,22," &
                               " if(convkgs>=22.01 and convkgs<=22.5,22.5,if(convkgs>22.5 and convkgs<=23,23,if(convkgs>=23.01 and convkgs<=23.5,23.5,if(convkgs>23.5 and convkgs<=24,24," &
                               " if(convkgs>=24.01 and convkgs<=24.5,24.5,if(convkgs>24.5 and convkgs<=25,25,if(convkgs>=25.01 and convkgs<=25.5,25.5,if(convkgs>25.5 and convkgs<=26,26," &
                               " if(convkgs>=26.01 and convkgs<=26.5,26.5,if(convkgs>26.5 and convkgs<=27,27,if(convkgs>=27.01 and convkgs<=27.5,27.5,if(convkgs>27.5 and convkgs<=28,28," &
                               " if(convkgs>=28.01 and convkgs<=28.5,28.5,if(convkgs>28.5 and convkgs<=29,29,if(convkgs>=29.01 and convkgs<=29.5,29.5,if(convkgs>29.5 and convkgs<=30,30," &
                               " if(convkgs>=30.01 and convkgs<=30.5,30.5,if(convkgs>30.5 and convkgs<=31,31,if(convkgs>=31.01 and convkgs<=31.5,31.5," &
                               " ceiling(convkgs)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))) as PesoCalculado,convservicelevel as tipo_servicio " &
                               " from importacion,zonas_importacion where typepack='SPX' and dateimportpkg between'" & fechainicio & "'and '" & fechafinal & "' and country=01_pais);" &
                               " select Guia ,Proveedor,Consignatario , Bultos , Peso,Valor,(05_tarifa_por_kg*Peso) as Tarifa,if(valor<=200,3,valor*0.015) as Seguro from vw_importacion, tarifa_importacion_mayor" &
                               " where Peso>31.5 and 01_fdc=tipo_servicio and 02_zona=zona and envio=03_envio" &
                               " union all" &
                               " select Guia, Proveedor,Consignatario, Bultos, Peso,Valor,05_tarifa as Tarifa,if(valor<=200,3,valor*0.015) as Seguro from vw_importacion left join tarifa_importacion on" &
                               " (tipo_servicio=01_fdc and pesocalculado=04_peso and envio=03_envio and zona=02_zona) where pesocalculado<=31.5"

            da_result = New MySqlDataAdapter(sentenciaSQLVista, conexion)
            DSImport.Clear()
            da_result.Fill(DSImport, "vista")

            'comando = New MySqlCommandBuilder(da)
            Dgvresult.Visible = True
            TxtTotal.Text = DSImport.Tables("vista").Rows.Count
            Dgvresult.DataSource = DSImport.Tables("vista")
            Dgvresult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'DataGridView1.ForeColor = Color.Brown
            'DataGridView1.BackgroundColor = Color.Black
            Dgvresult.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
            Dgvresult.Columns(4).DefaultCellStyle.Format = "##,##0.00"
            Dgvresult.Columns(5).DefaultCellStyle.Format = "##,##0.00"
            Dgvresult.Columns(6).DefaultCellStyle.Format = "##,##0.00"
            Dgvresult.ReadOnly = True
            BtnCalcular.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub BtnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportar.Click


        Dim save As New SaveFileDialog
        save.Filter = "Archivo Excel | *.xlsx"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
        End If
        Exportar_Excel(Me.Dgvresult, save.FileName)




    End Sub

    Private Sub DTPDateimportpkg_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPDateimportpkg.ValueChanged
        Dim fechainicio As String = DTPDateimportpkg.Value.Year & "/" & DTPDateimportpkg.Value.Month & "/" & DTPDateimportpkg.Value.Day
        Dim fechafinal As String = DTPDateimportpkg.Value.Year & "/" & DTPDateimportpkg.Value.Month & "/" & DTPDateimportpkg.Value.Day
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


End Class
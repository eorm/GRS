Imports System
Imports System.IO
Imports MySql.Data
Imports MySql.Data.MySqlClient
'Imports System.Collections

Public Class Frm_Manifiesto4
    Dim conexion As MySqlConnection
    Dim registro As DataRow
    Dim da_import As MySqlDataAdapter
    Dim da_result As MySqlDataAdapter
    Dim comando As MySqlCommandBuilder
    Dim strconexion As String
    Dim fechainicio As String '= DTPDateimportpkg.Value.Year & "/" & DTPDateimportpkg.Value.Month & "/" & DTPDateimportpkg.Value.Day
    Dim fechafinal As String '= DTPDateimportpkg.Value.Year & "/" & DTPDateimportpkg.Value.Month & "/" & DTPDateimportpkg.Value.Day


    Private Sub Frm_Manifiesto4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strconexion = "server=localhost; database=dbsolosa; uid=root;password=Ups2810"

        'DgvImportacion.Columns(10).DefaultCellStyle.Format = "##,##0.00"
        'DgvImportacion.Columns(14).DefaultCellStyle.Format = "##,##0.00"
        Dim fechainicio As String = DTPDateimportpkg.Value.Year & "/" & DTPDateimportpkg.Value.Month & "/" & DTPDateimportpkg.Value.Day
        Dim fechafinal As String = DTPDateimportpkg.Value.Year & "/" & DTPDateimportpkg.Value.Month & "/" & DTPDateimportpkg.Value.Day





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
        Dim servicelevel As String
        Dim convservicelevel As Integer
        Dim descripcion As String
        Dim shipper As String
        Dim consignee As String
        Dim declared As Integer
        Dim currencydeclared As String
        Dim billingterm As String
        Dim typepack As String
        Dim qtpack As Integer
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
                                Else
                                    convservicelevel = 5
                                End If

                                Dim pattern As String = "yyMMdd"
                                convdateimport = Mid(linea, 13, 6)
                                'convdateimport = Mid(linea, 13, 2) & "/" & Mid(linea, 15, 2) & "/" & Mid(linea, 17, 2)
                                DateTime.TryParseExact(convdateimport, pattern, Nothing, Globalization.DateTimeStyles.None, dateimport)
                                'dateimport = Date.TryParseExact(convdateimport, "dd/mm/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
                                'dateimport = CDate(convdateimport)

                                billingterm = Trim(Mid(linea, 319, 3))
                                typepack = Trim(Mid(linea, 73, 1))
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
                                qtpack = Mid(linea, 75, 2)

                            Case "2020"
                                tracking = Trim(Mid(linea, 51, 35))

                            Case "3000"
                                shippername = Trim(Mid(linea, 69, 35))

                            Case "4000"

                                consignee = Mid(linea, 69, 35)



                                'Dgv.Rows.Add(tracking, shipper, consignee, declared, typepack, weight, strweight, convkg)
                                DgvImportacion.Rows.Add(dateimport, destination, country, tracking, shippername, consignee, billingterm, convservicelevel, typepack, qtpack, weight, strweight, convkg, declared, currencydeclared, dateimportfile, dateimportpkg)


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
        Catch ex As Exception
            MsgBox("Archivo no encontrado" & ruta, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub BtnCalcularFlete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcularFlete.Click
        Dim sentenciaSQLVista As String


        sentenciaSQLVista = "drop view if EXISTS importacion;" & _
                           "create view importacion as (" & _
                           " select dateimport as fecha,country,tracking as 'Guia',shipper as Proveedor," & _
                           " consignee as Consignatario,typepack as envio,qtpack as Bultos,convkgs as Peso,zona as Zona," & _
                           " if(convkgs>=0.00 and convkgs<=0.5,0.5,if(convkgs>=0.6 and convkgs<=1,1,if(convkgs>=1.01 and convkgs<=1.5,1.5," & _
                           " if(convkgs>=1.6 and convkgs<=2,2,if(convkgs>=2.01 and convkgs<=2.5,2.5,if(convkgs>=2.6 and convkgs<=3,3," & _
                           " if(convkgs>=3.01 and convkgs<=3.5,3.5,if(convkgs>=3.6 and convkgs<=4,4,if(convkgs>=4.01 and convkgs<=4.5,4.5," & _
                           " if(convkgs>=4.6 and convkgs<=5,5,if(convkgs>=5.01 and convkgs<=5.5,5.5,if(convkgs>=5.6 and convkgs<=6,6," & _
                           " if(convkgs>=6.01 and convkgs<=6.5,6.5,if(convkgs>=6.6 and convkgs<=7,7,if(convkgs>=7.01 and convkgs<=7.5,7.5,if(convkgs>=7.6 and convkgs<=8,8," & _
                           " if(convkgs>=8.01 and convkgs<=8.5,8.5,if(convkgs>=8.6 and convkgs<=9,9,if(convkgs>=9.01 and convkgs<=9.5,9.5,if(convkgs>=9.6 and convkgs<=10,10," & _
                           " if(convkgs>=10.01 and convkgs<=10.5,10.5,if(convkgs>=10.6 and convkgs<=11,11,if(convkgs>=11.01 and convkgs<=11.5,11.5,if(convkgs>=11.6 and convkgs<=12,12," & _
                           " if(convkgs>=12.01 and convkgs<=12.5,12.5,if(convkgs>=12.6 and convkgs<=13,13,if(convkgs>=13.01 and convkgs<=13.5,13.5,if(convkgs>=13.6 and convkgs<=14,14," & _
                           " if(convkgs>=14.01 and convkgs<=14.5,14.5,if(convkgs>=14.6 and convkgs<=15,15,if(convkgs>=15.01 and convkgs<=15.5,15.5,if(convkgs>=15.6 and convkgs<=16,16," & _
                           " if(convkgs>=16.01 and convkgs<=16.5,16.5,if(convkgs>=16.6 and convkgs<=17,17,if(convkgs>=17.01 and convkgs<=17.5,17.5,if(convkgs>=17.6 and convkgs<=18,18," & _
                           " if(convkgs>=18.01 and convkgs<=18.5,18.5,if(convkgs>=18.6 and convkgs<=19,19,if(convkgs>=19.01 and convkgs<=19.5,19.5,if(convkgs>=19.6 and convkgs<=20,20," & _
                           " if(convkgs>=20.01 and convkgs<=20.5,20.5,if(convkgs>=20.6 and convkgs<=21,21,if(convkgs>=21.01 and convkgs<=21.5,21.5,if(convkgs>=21.6 and convkgs<=22,22," & _
                           " if(convkgs>=22.01 and convkgs<=22.5,22.5,if(convkgs>=22.6 and convkgs<=23,23,if(convkgs>=23.01 and convkgs<=23.5,23.5,if(convkgs>=23.6 and convkgs<=24,24," & _
                           " if(convkgs>=24.01 and convkgs<=24.5,24.5,if(convkgs>=24.6 and convkgs<=25,25,if(convkgs>=25.01 and convkgs<=25.5,25.5,if(convkgs>=25.6 and convkgs<=26,26," & _
                           " if(convkgs>=26.01 and convkgs<=26.5,26.5,if(convkgs>=26.6 and convkgs<=27,27,if(convkgs>=27.01 and convkgs<=27.5,27.5,if(convkgs>=27.6 and convkgs<=28,28," & _
                           " if(convkgs>=28.01 and convkgs<=28.5,28.5,if(convkgs>=28.6 and convkgs<=29,29,if(convkgs>=29.01 and convkgs<=29.5,29.5,if(convkgs>=29.6 and convkgs<=30,30," & _
                           " if(convkgs>=30.01 and convkgs<=30.5,30.5,if(convkgs>=30.6 and convkgs<=31,31,if(convkgs>=31.01 and convkgs<=31.5,31.5," & _
                           " convkgs))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))) as PesoCalculado" & _
                           " from importacion and typepack='N' and dateimportpkg between'" & fechainicio & "'and '" & fechafinal & "');" & _
                           " select  tracking as Guia,shipper as Proveedor,consignee as Consignatario,qtpack as Bultos,convkgs as Peso,((05_tarifa_por_kg*convkgs)-((05_tarifa_por_kg*convkgs)*0.40)) as Tarifa from  importacion, tarifa_import_mayor" & _
                           " where convkgs>31.5 and convservicelevel=tipo_servicio and 02_zona=zona and tipo=envio" & _
                           " union all" & _
                           " select tracking as Guia,shipper as Proveedor,consignee as Consignatario,qtpack as Bultos,convkgs as Peso,(05_tarifa -(05_tarifa*0.40)) as Tarifa from importacion left join tarifa_import on" & _
                           " (tipo_servicio=convservicelevel and convkgs=04_peso and convservicelevel=03_envio and zona=02_zona) where pesocalculado<=31.5"





        da_result = New MySqlDataAdapter(sentenciaSQLVista, conexion)
        'DSImport.Clear()
        da_result.Fill(DSImport)

        'comando = New MySqlCommandBuilder(da)
        Dgvresult.Visible = True
        TxtTotal.Text = DSImport.Tables(0).Rows.Count
        Dgvresult.DataSource = DSImport.Tables(0)
        Dgvresult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'DataGridView1.ForeColor = Color.Brown
        'DataGridView1.BackgroundColor = Color.Black
        Dgvresult.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        Dgvresult.ReadOnly = True
    End Sub

    Private Sub BtnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportar.Click

    End Sub
End Class
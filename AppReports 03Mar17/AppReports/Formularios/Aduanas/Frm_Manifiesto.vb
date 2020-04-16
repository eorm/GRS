Imports MySql.Data.MySqlClient
Imports System.Data.OleDb

Public Class Frm_Manifiesto
   

    Private Sub BtnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEjecutar.Click

        Dim cn As MySqlConnection
        Dim da_vista As MySqlDataAdapter
        'Dim da_consulta
        Dim ds_vista As New DataSet
        Dim ds_consulta As New DataSet
        Dim cadenaSQL As String
        Dim sentenciaSQLVista As String
        'Dim setenciaSQLconsulta As String
        Dim comando As MySqlCommandBuilder
        Dim fechainicio As String = DateTimePicker1.Value.Year & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Day
        Dim fechafinal As String = DateTimePicker2.Value.Year & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Day


        Try
            cadenaSQL = "server=192.100.26.6; database=DM10; uid='it'; pwd='Ups2810'"
            'cadenaSQL = "server=localhost; database=DM10; uid=root"
            'cadenaSQL = "server=192.100.26.6;User Id=root;password=adminsqlserver;database=dm10"
            'cadenaSQL = "server=localhost; database=DM10; uid=root; pwd=; port=3306"

            Dim itesm As DictionaryEntry


            sentenciaSQLVista = "drop view if EXISTS importacion;" & _
                            "create view importacion as (" & _
                            " select USFIL220.14_fecha_de_guia as fecha,USFIL220.01_pais,if(45_guia_de_18='',02_guia,45_guia_de_18) as 'Guia',23_300_shp_name as Proveedor," & _
                            " 29_400_imp_name as Consignatario,03_envio as envio,04_piezas as Bultos,(05_envio/10) as Peso,USFIL585.02_zona as Zona," & _
                            " if((05_envio/10)>=0.00 and (05_envio/10)<=0.5,0.5,if((05_envio/10)>=0.6 and (05_envio/10)<=1,1,if((05_envio/10)>=1.01 and (05_envio/10)<=1.5,1.5," & _
                            " if((05_envio/10)>=1.6 and (05_envio/10)<=2,2,if((05_envio/10)>=2.01 and (05_envio/10)<=2.5,2.5,if((05_envio/10)>=2.6 and (05_envio/10)<=3,3," & _
                            " if((05_envio/10)>=3.01 and (05_envio/10)<=3.5,3.5,if((05_envio/10)>=3.6 and (05_envio/10)<=4,4,if((05_envio/10)>=4.01 and (05_envio/10)<=4.5,4.5," & _
                            " if((05_envio/10)>=4.6 and (05_envio/10)<=5,5,if((05_envio/10)>=5.01 and (05_envio/10)<=5.5,5.5,if((05_envio/10)>=5.6 and (05_envio/10)<=6,6," & _
                            " if((05_envio/10)>=6.01 and (05_envio/10)<=6.5,6.5,if((05_envio/10)>=6.6 and (05_envio/10)<=7,7,if((05_envio/10)>=7.01 and (05_envio/10)<=7.5,7.5,if((05_envio/10)>=7.6 and (05_envio/10)<=8,8," & _
                            " if((05_envio/10)>=8.01 and (05_envio/10)<=8.5,8.5,if((05_envio/10)>=8.6 and (05_envio/10)<=9,9,if((05_envio/10)>=9.01 and (05_envio/10)<=9.5,9.5,if((05_envio/10)>=9.6 and (05_envio/10)<=10,10," & _
                            " if((05_envio/10)>=10.01 and (05_envio/10)<=10.5,10.5,if((05_envio/10)>=10.6 and (05_envio/10)<=11,11,if((05_envio/10)>=11.01 and (05_envio/10)<=11.5,11.5,if((05_envio/10)>=11.6 and (05_envio/10)<=12,12," & _
                            " if((05_envio/10)>=12.01 and (05_envio/10)<=12.5,12.5,if((05_envio/10)>=12.6 and (05_envio/10)<=13,13,if((05_envio/10)>=13.01 and (05_envio/10)<=13.5,13.5,if((05_envio/10)>=13.6 and (05_envio/10)<=14,14," & _
                            " if((05_envio/10)>=14.01 and (05_envio/10)<=14.5,14.5,if((05_envio/10)>=14.6 and (05_envio/10)<=15,15,if((05_envio/10)>=15.01 and (05_envio/10)<=15.5,15.5,if((05_envio/10)>=15.6 and (05_envio/10)<=16,16," & _
                            " if((05_envio/10)>=16.01 and (05_envio/10)<=16.5,16.5,if((05_envio/10)>=16.6 and (05_envio/10)<=17,17,if((05_envio/10)>=17.01 and (05_envio/10)<=17.5,17.5,if((05_envio/10)>=17.6 and (05_envio/10)<=18,18," & _
                            " if((05_envio/10)>=18.01 and (05_envio/10)<=18.5,18.5,if((05_envio/10)>=18.6 and (05_envio/10)<=19,19,if((05_envio/10)>=19.01 and (05_envio/10)<=19.5,19.5,if((05_envio/10)>=19.6 and (05_envio/10)<=20,20," & _
                            " if((05_envio/10)>=20.01 and (05_envio/10)<=20.5,20.5,if((05_envio/10)>=20.6 and (05_envio/10)<=21,21,if((05_envio/10)>=21.01 and (05_envio/10)<=21.5,21.5,if((05_envio/10)>=21.6 and (05_envio/10)<=22,22," & _
                            " if((05_envio/10)>=22.01 and (05_envio/10)<=22.5,22.5,if((05_envio/10)>=22.6 and (05_envio/10)<=23,23,if((05_envio/10)>=23.01 and (05_envio/10)<=23.5,23.5,if((05_envio/10)>=23.6 and (05_envio/10)<=24,24," & _
                            " if((05_envio/10)>=24.01 and (05_envio/10)<=24.5,24.5,if((05_envio/10)>=24.6 and (05_envio/10)<=25,25,if((05_envio/10)>=25.01 and (05_envio/10)<=25.5,25.5,if((05_envio/10)>=25.6 and (05_envio/10)<=26,26," & _
                            " if((05_envio/10)>=26.01 and (05_envio/10)<=26.5,26.5,if((05_envio/10)>=26.6 and (05_envio/10)<=27,27,if((05_envio/10)>=27.01 and (05_envio/10)<=27.5,27.5,if((05_envio/10)>=27.6 and (05_envio/10)<=28,28," & _
                            " if((05_envio/10)>=28.01 and (05_envio/10)<=28.5,28.5,if((05_envio/10)>=28.6 and (05_envio/10)<=29,29,if((05_envio/10)>=29.01 and (05_envio/10)<=29.5,29.5,if((05_envio/10)>=29.6 and (05_envio/10)<=30,30," & _
                            " if((05_envio/10)>=30.01 and (05_envio/10)<=30.5,30.5,if((05_envio/10)>=30.6 and (05_envio/10)<=31,31,if((05_envio/10)>=31.01 and (05_envio/10)<=31.5,31.5," & _
                            " (05_envio/10)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))) as PesoCalculado,if(USFIL220.43_servicio_fdc='00','28',USFIL220.43_servicio_fdc) as tipo_servicio" & _
                            " from USFIL220,USFIL585 where USFIL220.01_PAIS=USFIL585.01_pais and USFIL220.03_envio='N' and 14_fecha_de_guia between'" & fechainicio & "'and '" & fechafinal & "');" & _
                            " select  guia as Guia,proveedor as Proveecor,consignatario as Consignatario,bultos as Bultos,pesocalculado as Peso,((05_tarifa_por_kg*peso)-((05_tarifa_por_kg*peso)*0.40)) as Tarifa from  importacion, tarifa_import_mayor" & _
                            " where pesocalculado>31.5 and 01_fdc=tipo_servicio and 02_zona=zona and tipo=envio" & _
                            " union all" & _
                            " select guia as Guia,proveedor as Proveedor,consignatario as Consignatario,bultos as Bultos,pesocalculado as Peso,(05_tarifa -(05_tarifa*0.40)) as Tarifa from importacion left join tarifa_import on" & _
                            " (tipo_servicio=01_FDC and pesocalculado=04_peso and envio=03_envio and zona=02_zona) where pesocalculado<=31.5"




            cn = New MySqlConnection(cadenaSQL)
            da_vista = New MySqlDataAdapter(sentenciaSQLVista, cn)
            ds_consulta.Clear()
            da_vista.Fill(ds_vista)

            'comando = New MySqlCommandBuilder(da)
            DgvDatos.Visible = True
            total.Text = ds_vista.Tables(0).Rows.Count
            DgvDatos.DataSource = ds_vista.Tables(0)
            DgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'DataGridView1.ForeColor = Color.Brown
            'DataGridView1.BackgroundColor = Color.Black
            DgvDatos.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
            DgvDatos.ReadOnly = True


            'setenciaSQLconsulta = " select USFIL220.14_fecha_de_guia as fecha,USFIL220.01_pais,if(45_guia_de_18='',02_guia,45_guia_de_18) as 'Guia',23_300_shp_name as Proveedor," & _
            '                            " 29_400_imp_name as Consignatario,03_envio as envio,04_piezas as Bultos,(05_envio/10) as Peso,USFIL585.02_zona as Zona," & _
            '                            " if((05_envio/10)>=0.1 and (05_envio/10)<=0.5,0.5,if((05_envio/10)>=0.6 and (05_envio/10)<=1,1,if((05_envio/10)>=1.1 and (05_envio/10)<=1.5,1.5," & _
            '                            " if((05_envio/10)>=1.6 and (05_envio/10)<=2,2,if((05_envio/10)>=2.1 and (05_envio/10)<=2.5,2.5,if((05_envio/10)>=2.6 and (05_envio/10)<=3,3," & _
            '                            " if((05_envio/10)>=3.1 and (05_envio/10)<=3.5,3.5,if((05_envio/10)>=3.6 and (05_envio/10)<=4,4,if((05_envio/10)>=4.1 and (05_envio/10)<=4.5,4.5," & _
            '                            " if((05_envio/10)>=4.6 and (05_envio/10)<=5,75,if((05_envio/10)>=5.1 and (05_envio/10)<=5.5,5.5,if((05_envio/10)>=5.6 and (05_envio/10)<=6,6," & _
            '                            " if((05_envio/10)>=6.1 and (05_envio/10)<=6.5,6.5,if((05_envio/10)>=6.6 and (05_envio/10)<=7,7,if((05_envio/10)>=7.1 and (05_envio/10)<=7.5,7.5,if((05_envio/10)>=7.6 and (05_envio/10)<=8,8," & _
            '                            " if((05_envio/10)>=8.1 and (05_envio/10)<=8.5,8.5,if((05_envio/10)>=8.6 and (05_envio/10)<=9,9,if((05_envio/10)>=9.1 and (05_envio/10)<=9.5,9.5,if((05_envio/10)>=9.6 and (05_envio/10)<=10,10," & _
            '                            " if((05_envio/10)>=10.1 and (05_envio/10)<=10.5,10.5,if((05_envio/10)>=10.6 and (05_envio/10)<=11,11,if((05_envio/10)>=11.1 and (05_envio/10)<=11.5,11.5,if((05_envio/10)>=11.6 and (05_envio/10)<=12,12," & _
            '                            " if((05_envio/10)>=12.1 and (05_envio/10)<=12.5,12.5,if((05_envio/10)>=12.6 and (05_envio/10)<=13,13,if((05_envio/10)>=13.1 and (05_envio/10)<=13.5,13.5,if((05_envio/10)>=13.6 and (05_envio/10)<=14,14," & _
            '                            " if((05_envio/10)>=14.1 and (05_envio/10)<=14.5,14.5,if((05_envio/10)>=14.6 and (05_envio/10)<=15,15,if((05_envio/10)>=15.1 and (05_envio/10)<=15.5,15.5,if((05_envio/10)>=15.6 and (05_envio/10)<=16,16," & _
            '                            " if((05_envio/10)>=16.1 and (05_envio/10)<=16.5,16.5,if((05_envio/10)>=16.6 and (05_envio/10)<=17,17,if((05_envio/10)>=17.1 and (05_envio/10)<=17.5,17.5,if((05_envio/10)>=17.6 and (05_envio/10)<=18,18," & _
            '                            " if((05_envio/10)>=18.1 and (05_envio/10)<=18.5,18.5,if((05_envio/10)>=18.6 and (05_envio/10)<=19,19,if((05_envio/10)>=19.1 and (05_envio/10)<=19.5,19.5,if((05_envio/10)>=19.6 and (05_envio/10)<=20,20," & _
            '                            " if((05_envio/10)>=20.1 and (05_envio/10)<=20.5,20.5,if((05_envio/10)>=20.6 and (05_envio/10)<=21,21,if((05_envio/10)>=21.1 and (05_envio/10)<=21.5,21.5,if((05_envio/10)>=21.6 and (05_envio/10)<=22,22," & _
            '                            " if((05_envio/10)>=22.1 and (05_envio/10)<=22.5,22.5,if((05_envio/10)>=22.6 and (05_envio/10)<=23,23,if((05_envio/10)>=23.1 and (05_envio/10)<=23.5,23.5,if((05_envio/10)>=23.6 and (05_envio/10)<=24,24," & _
            '                            " if((05_envio/10)>=24.1 and (05_envio/10)<=24.5,24.5,if((05_envio/10)>=24.6 and (05_envio/10)<=25,25,if((05_envio/10)>=25.1 and (05_envio/10)<=25.5,25.5,if((05_envio/10)>=25.6 and (05_envio/10)<=26,26," & _
            '                            " if((05_envio/10)>=26.1 and (05_envio/10)<=26.5,26.5,if((05_envio/10)>=26.6 and (05_envio/10)<=27,27,if((05_envio/10)>=27.1 and (05_envio/10)<=27.5,27.5,if((05_envio/10)>=27.6 and (05_envio/10)<=28,28," & _
            '                            " if((05_envio/10)>=28.1 and (05_envio/10)<=28.5,28.5,if((05_envio/10)>=28.6 and (05_envio/10)<=29,29,if((05_envio/10)>=29.1 and (05_envio/10)<=29.5,29.5,if((05_envio/10)>=29.6 and (05_envio/10)<=30,30," & _
            '                            " if((05_envio/10)>=30.1 and (05_envio/10)<=30.5,30.5,if((05_envio/10)>=30.6 and (05_envio/10)<=31,31,if((05_envio/10)>=31.1 and (05_envio/10)<=31.5,31.5," & _
            '                            " (05_envio/10)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))) as PesoCalculado,if(USFIL220.43_servicio_fdc='00','28',USFIL220.43_servicio_fdc) as tipo_servicio" & _
            '                            " from USFIL220,USFIL585 where USFIL220.01_PAIS=USFIL585.01_pais and USFIL220.03_envio='N' and 14_fecha_de_guia='2012-10-10'"


            'cn = New MySqlConnection(cadenaSQL)
            'da_consulta = New MySqlDataAdapter(setenciaSQLconsulta, cn)
            'da_consulta.Fill(ds_consulta)





        Catch ex As Exception

            MessageBox.Show(ex.Message)
            'Debug.Print(ex.ToString)


        End Try
    End Sub

    Private Sub BtnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportar.Click


        Dim save As New SaveFileDialog
        save.Filter = "Archivo Excel | *.xlsx"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
        End If
        Exportar_Excel(Me.DgvDatos, save.FileName)


    End Sub

    Public Sub Exportar_Excel(ByVal dgv As DataGridView, ByVal pth As String)
        Dim xlApp As Object = CreateObject("Excel.Application")
        'crear una nueva hoja de calculo 
        Dim xlWB As Object = xlApp.WorkBooks.add
        Dim xlWS As Object = xlWB.WorkSheets(1)

        'exportamos los caracteres de las columnas 
        For c As Integer = 0 To DgvDatos.Columns.Count - 1
            xlWS.cells(1, c + 1).value = DgvDatos.Columns(c).HeaderText
        Next

        'exportamos las cabeceras de columnas 
        For r As Integer = 0 To DgvDatos.RowCount - 1
            For c As Integer = 0 To DgvDatos.Columns.Count - 1
                xlWS.cells(r + 2, c + 1).value = DgvDatos.Item(c, r).Value
            Next
        Next

        'guardamos la hoja de calculo en la ruta especificada 
        xlWB.saveas(pth)
        xlWS = Nothing
        xlWB = Nothing
        xlApp.quit()
        xlApp = Nothing


        MessageBox.Show("Exportacion Finalizada", "Informacion")

    End Sub


End Class
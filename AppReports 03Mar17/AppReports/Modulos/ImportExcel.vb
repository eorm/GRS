Imports System.Data.OleDb

Module ImportExcel
    Public Manifiesto As String
    Public GuiaMaster As String
    Public FechaManifiesto As Date
    Public RegistroTotal As Integer
    Public VariablePrueba As String
    Public VariablePrueba2 As String
    Public Function ImportExcellToDataGridView(ByRef path As String, ByVal Datagrid As DataGridView, ByVal NombreHojaExcel As String)

        Try
            Dim stConexion As String = ("Provider=Microsoft.ACE.OLEDB.12.0;" & ("Data Source=" & (path & ";Extended Properties=""Excel 12.0;Xml;HDR=NO;IMEX=2"";")))
            Dim cnConex As New OleDbConnection(stConexion)
            Dim Cmd As New OleDbCommand("Select * From  [" & NombreHojaExcel & "$A3:K100]")
            Dim Ds As New DataSet
            Dim Da As New OleDbDataAdapter
            Dim Dt As New DataTable
            Dim DtTemporal As New DataTable
            cnConex.Open()
            Cmd.Connection = cnConex
            Da.SelectCommand = Cmd
            Ds.Clear()
            Da.Fill(Ds)
            Dt = Ds.Tables(0)
            DtTemporal = Dt.Copy()
            'Obtener datos de DataTable de fila y columna especifica
            FechaManifiesto = DtTemporal.Rows(0).Item(3)
            GuiaMaster = DtTemporal.Rows(1).Item(3)
            Manifiesto = DtTemporal.Rows(2).Item(3)
            'Obtener datos de DataTable de fila y columna especifica
            VariablePrueba = Dt(0)(3).ToString
            'DataSet.Tabla("nombre o numero").Compute("Lo_que_quieres(columna)", "filtro")
            'Dim Variableprueba3 As Integer
            'Variableprueba3 = Ds.Tables(0).Compute("Count(row.item(0))", "")
            'MsgBox(Variableprueba3)
            RegistroTotal = Ds.Tables(0).Select().Count
            Dt.Rows.Remove(Dt.Rows(RegistroTotal - 1))
            'Dt.Rows.RemoveAt(3)
            'Dt.Rows.RemoveAt(2)
            'Dt.Rows.RemoveAt(1)
            'Dt.Rows.RemoveAt(0)
            Dt.Rows.Remove(Dt.Rows(3))
            Dt.Rows.Remove(Dt.Rows(2))
            Dt.Rows.Remove(Dt.Rows(1))
            Dt.Rows.Remove(Dt.Rows(0))
            'Datagrid.Columns.Clear()
            'Dim rows As DataRow() = DtTemporal.Select()
            'row = DtTemporal.Rows(3)
            'temporal = row

            'Aplicar formato a DataGridView
            Datagrid.DataSource = Dt
            Datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
            Datagrid.Font = New Font("Tahoma", 7, FontStyle.Regular)
            Datagrid.Columns(7).DefaultCellStyle.Format = "##,##0.00"
            Datagrid.Columns(8).DefaultCellStyle.Format = "##,##0.00"
            Datagrid.Columns(9).DefaultCellStyle.Format = "##,##0.00"
            Datagrid.Columns(10).DefaultCellStyle.Format = "##,##0.00"
            Datagrid.Columns(0).HeaderCell.Value = "Fila"
            Datagrid.Columns(1).HeaderCell.Value = "Guia"
            Datagrid.Columns(2).HeaderCell.Value = "Proveedor"
            Datagrid.Columns(3).HeaderCell.Value = "Consignatario"
            Datagrid.Columns(4).HeaderCell.Value = "Piezas"
            Datagrid.Columns(5).HeaderCell.Value = "Peso KG"
            Datagrid.Columns(6).HeaderCell.Value = "Descripcion"
            Datagrid.Columns(7).HeaderCell.Value = "Valor"
            Datagrid.Columns(8).HeaderCell.Value = "Flete"
            Datagrid.Columns(9).HeaderCell.Value = "Seguro"
            Datagrid.Columns(10).HeaderCell.Value = "Otros"


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return True
    End Function

End Module

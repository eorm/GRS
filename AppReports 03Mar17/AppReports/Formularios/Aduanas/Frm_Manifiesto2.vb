Imports System.Data.OleDb
Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class Frm_Manifiesto2

    Dim da_import As MySqlDataAdapter
    Dim comando As MySqlCommandBuilder



    Private Sub Frm_Manifiesto2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da_import = New MySqlDataAdapter("select * from import_level1", conex)
        da_import.FillSchema(DSimport, SchemaType.Source, "import_level1")
        da_import.Fill(DSimport, "import_level1")

        



    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cnn As New OleDbConnection( _
         "Provider=Microsoft.Jet.OLEDB.4.0;" & _
         "Data Source=C:\importacionUPS;" & _
         "Extended Properties='TEXT;HDR=yes'")

        Using cnn
            Try
                Dim sql As String = "SELECT * FROM [level 1.csv]"

                Dim cmd As New OleDbCommand(sql, cnn)

                Dim da As New OleDbDataAdapter(cmd)

                Dim ds As New DataSet

                da.Fill(ds, "ArchivoCSV")

                With Dgvimportacion
                    .DataSource = ds
                    .DataMember = "ArchivoCSV"
                End With
                Button2.Enabled = True
                Dgvimportacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'DataGridView1.ForeColor = Color.Brown
                'DataGridView1.BackgroundColor = Color.Black
                Dgvimportacion.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
                Dgvimportacion.ReadOnly = True


            Catch ex As OleDbException
                MessageBox.Show(ex.Errors(0).Message)

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End Using

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim registro As DataRow

        Try

            'Registrar en la tabla sol_actividad_diaria AM
            For i = 0 To Dgvimportacion.RowCount - 1

                registro = DSimport.Tables("import_level1").NewRow
                registro("idimport_level1") = i + 1
                registro("import_level1col") = Dgvimportacion.Item(1, i).Value
                registro("guia") = Dgvimportacion.Item(2, i).Value
                registro("descripcion") = Dgvimportacion.Item(4, i).Value
                registro("shipper") = Dgvimportacion.Item(5, i).Value
                registro("consignee") = Dgvimportacion.Item(6, i).Value
                registro("weight") = Dgvimportacion.Item(9, i).Value
                registro("weight_unit") = Dgvimportacion.Item(9, i).Value
                registro("declare_value") = Dgvimportacion.Item(11, i).Value

                DSimport.Tables("import_level1").Rows.Add(registro)
            Next

            da_import.Update(DSimport, "import_level1")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)


        End Try


    End Sub


End Class
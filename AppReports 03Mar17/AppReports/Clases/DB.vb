Imports MySql.Data
Imports MySql.Data.MySqlClient

Module DB

    Public conex As MySqlConnection
    Public conex2 As MySqlConnection
    Public Sub conectarBD()
        Try
            conex = New MySqlConnection
            'conex.ConnectionString = "server=192.100.19.5; database=DM10; uid=it; password=Ups2810"
            conex.ConnectionString = "server=192.100.19.5; database=dbsolosa; uid=it; password=Ups2810"
            'conex.ConnectionString = "server=192.100.16.200; database=dbsolosa; uid=root; password=upshn9048t1"
            'conex.ConnectionString = "server=localhost; database=dbsolosa; uid=root; password=Ups2810"
            If conex.State = ConnectionState.Closed Then
                conex.Open()
                'MessageBox.Show("Conexion correcta", "nformacion")
            End If


        Catch ex As Exception
            MsgBox(ex.ToString + " VALIDA ESTE PROCEDIMIENTO ELVIN RIVERA")
            'Application.Exit()

        End Try

        
    End Sub
    Sub ConectarDB2()
        Try
            conex2 = New MySqlConnection
            'conex.ConnectionString = "server=192.100.19.5; database=DM10; uid=it; password=Ups2810"
            'conex2.ConnectionString = "server=192.100.19.5; database=DM10; uid=it; password=Ups2810"
            'conex.ConnectionString = "server=192.100.16.200; database=dbsolosa; uid=root; password=upshn9048t1"
            'conex.ConnectionString = "server=localhost; database=dbsolosa; uid=root; password=Ups2810"
            If conex2.State = ConnectionState.Closed Then
                conex2.Open()
                MessageBox.Show("Conexion Correcta", "Informacion")

            End If
        Catch ex As Exception
            MsgBox(ex.ToString + " VALIDA ESTE PROCEDIMIENTO ELVIN RIVERA")
            'Application.Exit()

        End Try

    End Sub
    Sub DesconectarBD()
        Try
            If conex.State = ConnectionState.Open Then
                conex.Close()
                'MsgBox("Conexion Cerrada")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical, "ERROR")
        End Try

    End Sub

    Sub DesconectarBD2()
        Try
            If conex2.State = ConnectionState.Open Then
                conex2.Close()
                'MsgBox("Conexion Cerrada")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical, "ERROR")
        End Try

    End Sub

    Function consultaSQL(ByVal sentencia As String) As DataTable
        Dim da_consulta As MySqlDataAdapter
        Dim tabla As New DataTable

        Try
            da_consulta = New MySqlDataAdapter
            da_consulta.SelectCommand = New MySqlCommand(sentencia, conex)
            da_consulta.Fill(tabla)




        Catch ex As Exception
            MsgBox(ex.ToString + " ERROR Consulta SQL")
            Application.Exit()

        End Try


        consultaSQL = tabla



    End Function

    Function consultaSQL2(ByVal sentencia As String) As DataTable
        Dim da_consulta As MySqlDataAdapter
        Dim tabla As New DataTable

        Try
            da_consulta = New MySqlDataAdapter
            da_consulta.SelectCommand = New MySqlCommand(sentencia, conex2)
            da_consulta.Fill(tabla)




        Catch ex As Exception
            MsgBox(ex.ToString + " ERROR Consulta SQL")
            Application.Exit()

        End Try


        consultaSQL2 = tabla


    End Function


    Function GuardarSQL(ByVal sentenciaSQL As String) As Boolean
        Dim cmd As MySqlCommand



        Try
            cmd = New MySqlCommand(sentenciaSQL, conex)
            cmd.ExecuteNonQuery()
            MsgBox("Manifiesto Guardado Correctamente")
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try


    End Function


End Module

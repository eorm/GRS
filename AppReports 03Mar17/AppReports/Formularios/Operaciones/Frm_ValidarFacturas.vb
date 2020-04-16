Imports System.Data
Public Class Frm_ValidarFacturas
    Dim FechaConsultaDesde As Date
    Dim FechaConsultaHasta As Date
    Dim FechaConsultaDesdeDB As String
    Dim FechaConsultaHastaDB As String

    Private Sub Frm_ValidarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvConsultaManAdu.AllowUserToAddRows = False
        DgvvalidacionMagic.AllowUserToAddRows = False
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dispose()

    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        conectarBD()
        'ConectarDB2()
        Dim DtConsultaManifiesto As New DataTable
        FechaConsultaDesde = DtpDesde.Value.ToShortDateString
        FechaConsultaDesdeDB = FechaConsultaDesde.ToString("yyyy-MM-dd")
        FechaConsultaHasta = DtpHasta.Value.ToShortDateString
        FechaConsultaHastaDB = FechaConsultaHasta.ToString("yyyy-MM-dd")

        MsgBox(FechaConsultaDesde + " " + FechaConsultaHasta + " " + FechaConsultaDesdeDB + " " + FechaConsultaHastaDB)
        Dim SentenciaSQL As String = "select NumeroGuia from manifiestoaduana where FechaManifiesto between '" & FechaConsultaDesdeDB & "' and '" & FechaConsultaHastaDB & "' "
        MsgBox(SentenciaSQL)
        DtConsultaManifiesto = consultaSQL(SentenciaSQL)
        If DtConsultaManifiesto.Rows.Count > 0 Then
            DgvConsultaManAdu.DataSource = DtConsultaManifiesto
            MsgBox("Consulta Exitosa")
            ConsultarGuiaDB()
        Else
            MsgBox("No se ecuentran registros en la fecha seleccionada", vbInformation, "Informacion")
        End If
        TxtTotalGuias.Text = DgvConsultaManAdu.Rows.Count
        DesconectarBD()
    End Sub

    Sub ConsultarGuiaDB()
        ConectarDB2()
        Dim Tabla_Resualtado As DataTable

        For Each row As DataGridViewRow In DgvConsultaManAdu.Rows

            Tabla_Resualtado = consultaSQL2("Select 01_Codigo_pais_destino, 02_numero_de_guia, 07_Fecha_de_ingreso, 10_terminos_del_pago from USFIL123 where 45_Guia_de_18_Digitos = '" & row.Cells(0).Value & "'")
            DgvvalidacionMagic.DataSource = Tabla_Resualtado
            TxtTotalGuias.Text = DgvvalidacionMagic.Rows.Count.ToString
            'VariableData = DataGridView2(1, i).Value.ToString
            MsgBox(row.Cells(0).Value)

        Next


        DesconectarBD2()

    End Sub

    Private Sub DtpDesde_ValueChanged(sender As Object, e As EventArgs) Handles DtpDesde.ValueChanged
        FechaConsultaDesde = DtpDesde.Value.ToShortDateString
        FechaConsultaHasta = DtpHasta.Value.ToShortDateString

    End Sub
End Class
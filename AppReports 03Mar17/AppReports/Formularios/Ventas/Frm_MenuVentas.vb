Public Class Frm_MenuVentas


    Private Sub BtnImportacion_Click(sender As Object, e As EventArgs) Handles BtnImportacion.Click
        Dispose()
        Frm_Principal.abrir_en_panel(Frm_Compensation2, Frm_Principal.PnPrincipal)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dispose()
        Frm_Principal.abrir_en_panel(Frm_manifiesto3, Frm_Principal.PnPrincipal)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
        Frm_Principal.abrir_en_panel(Frm_ReportePiezas, Frm_Principal.PnPrincipal)
    End Sub
End Class
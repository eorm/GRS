Public Class Frm_MenuOperaciones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dispose()
        Frm_Principal.abrir_en_panel(Frm_ValidarFacturas, Frm_Principal.PnPrincipal)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
        Frm_Principal.abrir_en_panel(Frm_ReportePiezas, Frm_Principal.PnPrincipal)
    End Sub
End Class
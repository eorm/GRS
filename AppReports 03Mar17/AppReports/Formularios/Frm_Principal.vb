Public Class Frm_Principal

    Public Sub abrir_en_panel(ByVal frm_hijo As Object, ByVal panel As Panel)
        panel.Controls.Clear()
        Dim form As Form = CType(frm_hijo, Form)
        form.TopLevel = False
        panel.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Principal_Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Dispose()

    End Sub


    Private Sub BtnAduanas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAduanas.Click
        'abrir_en_panel(Frm_manifiesto3, PnPrincipal)
        abrir_en_panel(Frm_ImportManifiesto, PnPrincipal)



    End Sub



    Private Sub Btnoperciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnoperciones.Click
        abrir_en_panel(Frm_MenuOperaciones, PnPrincipal)

    End Sub

    Private Sub BtnVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVentas.Click
        'abrir_en_panel(Frm_Compensation2, PnPrincipal)
        abrir_en_panel(Frm_MenuVentas, PnPrincipal)
    End Sub
End Class

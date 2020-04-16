
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Frm_Tpd
    Dim da_courier, da_estacion, da_ruta, da_actividades, da_actividad_diaria, da_ruta_diaria, da_vehiculo, da_vehiculo2 As MySqlDataAdapter
    Dim fecha As Date
    Dim comando As MySqlCommandBuilder






    Private Sub Frm_Tpd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Color_TextboxAM()
        Color_TextboxPM()
        DTPFecha.Value = Now


        DgvDatosAM.AllowUserToAddRows = False
        DgvDatosPM.AllowUserToAddRows = False


        da_courier = New MySqlDataAdapter("select *,concat(primer_nombre,' ',primer_apellido,' ',segundo_apellido) as nombrecompleto from sol_courier", conex)
        da_courier.FillSchema(DSTpd, SchemaType.Source, "sol_courier")
        da_courier.Fill(DSTpd, "sol_courier")



        da_estacion = New MySqlDataAdapter("select * from sol_estacion", conex)
        da_estacion.FillSchema(DSTpd, SchemaType.Source, "sol_estacion")
        da_estacion.Fill(DSTpd, "sol_estacion")


        da_ruta = New MySqlDataAdapter("select * from sol_ruta", conex)
        da_ruta.FillSchema(DSTpd, SchemaType.Source, "sol_ruta")
        da_ruta.Fill(DSTpd, "sol_ruta")

        da_ruta = New MySqlDataAdapter("select * from sol_ruta", conex)
        da_ruta.FillSchema(DSTpd, SchemaType.Source, "sol_ruta_2")
        da_ruta.Fill(DSTpd, "sol_ruta_2")

        da_actividades = New MySqlDataAdapter("select * from sol_actividades", conex)
        da_actividades.FillSchema(DSTpd, SchemaType.Source, "sol_actividades")
        da_actividades.Fill(DSTpd, "sol_actividades")

        da_vehiculo = New MySqlDataAdapter("select * from sol_vehiculo", conex)
        da_vehiculo.FillSchema(DSTpd, SchemaType.Source, "Sol_vehiculo")
        da_vehiculo.Fill(DSTpd, "Sol_vehiculo")

        da_actividad_diaria = New MySqlDataAdapter("select * from sol_actividad_diaria", conex)
        da_actividad_diaria.FillSchema(DSTpd, SchemaType.Source, "sol_actividad_diaria")
        da_actividad_diaria.Fill(DSTpd, "sol_actividad_diaria")
        comando = New MySqlCommandBuilder(da_actividad_diaria)

        da_ruta_diaria = New MySqlDataAdapter("select * from sol_ruta_diaria", conex)
        da_ruta_diaria.FillSchema(DSTpd, SchemaType.Source, "sol_ruta_diaria")
        da_ruta_diaria.Fill(DSTpd, "sol_ruta_diaria")
        comando = New MySqlCommandBuilder(da_ruta_diaria)





        CboNombre.DataSource = DSTpd.Tables("sol_courier")
        CboNombre.DisplayMember = "nombrecompleto"
        CboNombre.ValueMember = "id"

        CboRuta.DataSource = DSTpd.Tables("sol_ruta")
        CboRuta.DisplayMember = "descripcion_ruta"
        CboRuta.ValueMember = "id_ruta"

        CboRutaPM.DataSource = DSTpd.Tables("sol_ruta_2")
        CboRutaPM.DisplayMember = ("descripcion_ruta")
        CboRutaPM.ValueMember = ("id_ruta")



        CboNumero_vehiculo.DataSource = DSTpd.Tables("sol_vehiculo")
        CboNumero_vehiculo.DisplayMember = ("placa")
        CboNumero_vehiculo.ValueMember = "placa"

        CboNumero_vehiculoPM.DataSource = DSTpd.Tables("sol_vehiculo")
        CboNumero_vehiculoPM.DisplayMember = ("placa")
        CboNumero_vehiculoPM.ValueMember = "placa"



        LimpiarGBAM(Me)
        LimpiarGBPM(Me)
        LimpiarGBIngreso(Me)
        LimpiarGBTPD(Me)

        DgvDatosAM.Rows.Clear()
        DgvDatosPM.Rows.Clear()



    End Sub


    Private Sub CboNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboNombre.KeyPress
        e.Handled = True
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                Dim registro As DataRow

                registro = DSTpd.Tables("sol_courier").Rows.Find(CboNombre.SelectedValue)

                If registro Is Nothing Then
                    MessageBox.Show("Courier no existe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CboNombre.Focus()
                Else

                    TxtId.Text = registro("id").ToString
                    TxtEstacion.Text = registro("sol_estacion_id").ToString
                    moverEnfoque()
      
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try

        End If



    End Sub

    Private Sub CboNombre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboNombre.SelectedIndexChanged
        
    End Sub

   
    Private Sub CboRuta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True


    End Sub

    Private Sub CboNumero_vehiculo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True

    End Sub

    Private Sub CboRutaPM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True

    End Sub

    Private Sub CboNumero_vehiculoPM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True

    End Sub

    Private Sub CboNombre_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboNombre.SelectionChangeCommitted
        Try
            Dim registro As DataRow

            registro = DSTpd.Tables("sol_courier").Rows.Find(CboNombre.SelectedValue)

            TxtId.Text = registro("id").ToString
            TxtEstacion.Text = registro("sol_estacion_id").ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

   
    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        If TxtCodigo.Text = "" Then
            MessageBox.Show("Debe que ingresar codigo de actividad", "Informacion")
            TxtCodigo.Focus()

        ElseIf (TxtCodigo.Text = 42 And TxtKilometraje.Text = "") Or (TxtCodigo.Text = 50 And TxtKilometraje.Text = "") Or (TxtCodigo.Text = 51 And TxtKilometraje.Text = "") Or (TxtCodigo.Text = 52 And TxtKilometraje.Text = "") Or (TxtCodigo.Text = 99 And TxtKilometraje.Text = "") Or (TxtCodigo.Text = 600 And TxtKilometraje.Text = "") And + _
            (TxtCodigo.Text = 750 And TxtKilometraje.Text = "") Or (TxtCodigo.Text = 753 And TxtKilometraje.Text = "") Or (TxtCodigo.Text = 755 And TxtKilometraje.Text = "") Or (TxtCodigo.Text = 757 And TxtKilometraje.Text = "") Or (TxtCodigo.Text = 758 And TxtKilometraje.Text = "") Then
            MessageBox.Show("Debe ingresar Kilometraje para esta actividad", "Informacion")
            TxtKilometraje.Focus()
        ElseIf CboCiclo.Text = "" Then
            MessageBox.Show("Debe de ingresar ciclo de actividad", "Informacion")
            CboCiclo.Focus()
        ElseIf MskHora.Text = ":" Then
            MessageBox.Show("Debe ingresar Hora de actividad", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                Dim buscar As DataRow

                buscar = DSTpd.Tables("sol_actividades").Rows.Find(TxtCodigo.Text)
                If buscar Is Nothing Then
                    MessageBox.Show("Codigo de actividad no existe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TxtCodigo.Focus()
                Else
                    If CboCiclo.Text = "AM" Then
                        DgvDatosAM.Rows.Add(TxtCodigo.Text, TxtGrupo.Text, MskHora.Text, TxtKilometraje.Text)

                    ElseIf CboCiclo.Text = "PM" Then
                        DgvDatosPM.Rows.Add(TxtCodigo.Text, TxtGrupo.Text, MskHora.Text, TxtKilometraje.Text)
                    ElseIf CboCiclo.Text <> "AM" And CboCiclo.Text <> "PM" Then
                        MessageBox.Show("Ciclo no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If
                    Exit Try
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try


        End If

    End Sub

    Public Sub solonumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Debe ingresar datos numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If

    End Sub
    Sub fuente()



    End Sub


    Private Sub TxtEntregas_antes_1030_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        solonumeros(e)

    End Sub

    Private Sub TxtEntregas_entre_1030_y_1200_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        solonumeros(e)

    End Sub

  


    Private Sub TieneFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim miTextBox As TextBox

        miTextBox = CType(sender, TextBox)
        miTextBox.BackColor = Color.Yellow


    End Sub

    Private Sub PierdeFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim miTextBox As TextBox


        miTextBox = CType(sender, TextBox)


        miTextBox.BackColor = Color.White
    End Sub

    Sub Color_TextboxAM()
        Dim ctrl As Control
        For Each ctrl In Me.GBAM.Controls
            If (TypeOf (ctrl) Is TextBox) Then
                Dim miTextBox As TextBox
                miTextBox = CType(ctrl, TextBox)
                AddHandler miTextBox.Enter, AddressOf TieneFoco
                AddHandler miTextBox.Leave, AddressOf PierdeFoco
            End If
        Next
    End Sub
    Sub Color_TextboxPM()
        Dim ctrl As Control
        For Each ctrl In Me.GBPM.Controls
            If (TypeOf (ctrl) Is TextBox) Then
                Dim miTextBox As TextBox
                miTextBox = CType(ctrl, TextBox)
                AddHandler miTextBox.Enter, AddressOf TieneFoco
                AddHandler miTextBox.Leave, AddressOf PierdeFoco
            End If
        Next
    End Sub





    Private Sub TxtTotal_awbs_spx_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTotal_recogidasPM.KeyPress, TxtTotal_recogidas_pickupPM.KeyPress, TxtTotal_recogidas_pickup.KeyPress, TxtTotal_recogidas.KeyPress, Txttotal_piezasPM.KeyPress, Txttotal_piezas.KeyPress, TxtTotal_paradasPM.KeyPress, TxtTotal_paradas_pickupPM.KeyPress, TxtTotal_paradas_pickup.KeyPress, TxtTotal_paradas.KeyPress, TxtTotal_awbsPM.KeyPress, TxtTotal_awbs_WSPM.KeyPress, TxtTotal_awbs_WS.KeyPress, TxtTotal_awbs_spxPM.KeyPress, TxtTotal_awbs_spx.KeyPress, TxtTotal_awbs.KeyPress, TxtRetornos_paq_basePM.KeyPress, TxtRetornos_paq_base.KeyPress, TxtParadas_vaciasPM.KeyPress, TxtParadas_vacias.KeyPress, TxtEntregas_entre_1030_y_1200PM.KeyPress, TxtEntregas_entre_1030_y_1200.KeyPress, TxtEntregas_despues_1200PM.KeyPress, TxtEntregas_despues_1200.KeyPress, TxtEntregas_antes_1030PM.KeyPress, TxtEntregas_antes_1030.KeyPress
        solonumeros(e)

        If e.KeyChar = ChrW(Keys.Enter) Then
            moverEnfoque()
        End If


    End Sub

    Private Sub CboEstacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True

    End Sub

    Private Sub CboNombre_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboNombre.Enter
        Try
            Dim registro As DataRow


            registro = DSTpd.Tables("sol_courier").Rows.Find(CboNombre.SelectedValue)
            If registro Is Nothing Then
                MessageBox.Show("Id de Courier no existe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                TxtId.Text = registro("id").ToString
                TxtEstacion.Text = registro("sol_estacion_id").ToString

            End If
            

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub TxtKilometraje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        solonumeros(e)

    End Sub
    Private Sub moverEnfoque()
        SendKeys.Send("{TAB}")
    End Sub

   
    
    Private Sub CboRuta_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboRutaPM.KeyPress, CboRuta.KeyPress, CboNumero_vehiculoPM.KeyPress, CboNumero_vehiculo.KeyPress
        e.Handled = True
        If e.KeyChar = ChrW(Keys.Enter) Then
            moverEnfoque()
        End If

    End Sub

    Private Sub TxtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKilometraje.KeyPress, TxtGrupo.KeyPress, TxtCodigo.KeyPress, MskHora.KeyPress
        solonumeros(e)
        If e.KeyChar = ChrW(Keys.Enter) Then
            moverEnfoque()
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Dispose()

    End Sub

   

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click

        LimpiarGBAM(Me)
        LimpiarGBPM(Me)
        LimpiarGBIngreso(Me)
        LimpiarGBTPD(Me)

        DgvDatosAM.Rows.Clear()
        DgvDatosPM.Rows.Clear()

    End Sub

    'Declaramos nuestro metodo que hara la limpieza de los textbox
    Sub LimpiarGBIngreso(ByVal ofrm As Form)
        'hace un chequeo por todos los textbox del formulario
        For Each oControl As Control In Me.GBIngreso.Controls
            If (TypeOf oControl Is TextBox) Or (TypeOf oControl Is ComboBox) Or (TypeOf oControl Is MaskedTextBox) Then
                oControl.Text = ""
                CboNombre.Focus()

            End If
        Next
    End Sub

    Sub LimpiarGBAM(ByVal ofrm As Form)
        'hace un chequeo por todos los textbox del formulario
        For Each oControl As Control In Me.GBAM.Controls
            If (TypeOf oControl Is TextBox) Or (TypeOf oControl Is ComboBox) Then
                oControl.Text = ""
                CboNombre.Focus()
            End If
        Next
    End Sub
    Sub LimpiarGBPM(ByVal ofrm As Form)
        'hace un chequeo por todos los textbox del formulario
        For Each oControl As Control In Me.GBPM.Controls
            If (TypeOf oControl Is TextBox) Or (TypeOf oControl Is ComboBox) Then
                oControl.Text = ""
                CboNombre.Focus()
            End If
        Next

    End Sub
    Sub LimpiarGBTPD(ByVal ofrm As Form)
        'hace un chequeo por todos los textbox del formulario
        For Each oControl As Control In Me.GbTpd.Controls
            If (TypeOf oControl Is TextBox) Or (TypeOf oControl Is ComboBox) Then
                oControl.Text = ""
                CboNombre.Focus()
            End If
        Next
        DTPFecha.Value = Now
    End Sub
    

    Private Sub BtnEliminarPM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarPM.Click

        If (DgvDatosPM.RowCount < 1) Then
            MessageBox.Show("No hay registros que eliminar", "Informacion")
        Else
            DgvDatosPM.Rows.Remove(DgvDatosPM.CurrentRow)
        End If

        
    End Sub


    Private Sub BtnEliminarAM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarAM.Click
        If (DgvDatosAM.RowCount < 1) Then
            MessageBox.Show("No hay registros que eliminar", "Informacion")
        Else
            DgvDatosAM.Rows.Remove(DgvDatosAM.CurrentRow)
        End If
    End Sub

    Private Sub CboCiclo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboCiclo.KeyPress
        e.Handled = True
        If e.KeyChar = ChrW(Keys.Enter) Then
            moverEnfoque()
        End If
    End Sub

    Private Sub DTPFecha_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPFecha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            moverEnfoque()
        End If

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim registrotpd As DataRow
        Dim registrotpdPM As DataRow
        Dim registrotpdruta As DataRow
        Dim registrotpdrutapm As DataRow
        Dim AM As String = "AM"
        Dim PM As String = "PM"

        Dim temporal As Integer = 1


        If TxtId.Text = "" Then
            MessageBox.Show("Tiene que seleccionar un courier")

        ElseIf CboNombre.Text = "" Then
            MessageBox.Show("Tiene que seleccionar un courier")
            CboRuta.Focus()

        ElseIf CboRuta.Text = "" And CboRutaPM.Text = "" Then
            MessageBox.Show("Ingrese Ruta ", "Informacion")
            CboRuta.Focus()

            'ElseIf (DgvDatosAM.RowCount < 1) And (DgvDatosPM.RowCount < 1) Then
            '    MessageBox.Show("Debe de ingresar actividad de la ruta antes de guardar registro", "Informacion")

            'ElseIf Txttotal_piezas.Text = "" And TxtTotal_recogidas_pickup.Text = "" Then
            '    If Txttotal_piezasPM.Text = "" And TxtTotal_recogidas_pickupPM.Text = "" Then
            '        MessageBox.Show("No hay informacion de RUTA que procesar")
            '        CboRuta.Focus()
            '        Exit Sub
            '    End If


            'ElseIf Txttotal_piezasPM.Text = "" Or TxtTotal_recogidas_pickup.Text = "" Then
            '    If Txttotal_piezas.Text = "" And TxtTotal_recogidas_pickup.Text = "" Then
            '        MessageBox.Show("No hay informacion de RUTA que procesar")
            '        CboRuta.Focus()
            '        Exit Sub
            '    End If

        


        Else
            MessageBox.Show("Aqui Guardar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
          

            Try
                'Registrar en la tabla sol_actividad_diaria AM
                For i = 0 To DgvDatosAM.RowCount - 1

                    registrotpd = DSTpd.Tables("sol_actividad_diaria").NewRow
                    registrotpd("id") = CboRuta.Text
                    registrotpd("sol_courier_id") = TxtId.Text
                    registrotpd("sol_estacion_id") = TxtEstacion.Text
                    registrotpd("sol_actividades_id_actividad") = DgvDatosAM.Item(0, i).Value
                    registrotpd("sol_ruta_id_ruta") = CboRuta.SelectedValue
                    registrotpd("hora_inicio") = DgvDatosAM.Item(2, i).Value
                    registrotpd("Kilometraje") = DgvDatosAM.Item(3, i).Value
                    registrotpd("fecha") = DTPFecha.Value.Year & "-" & DTPFecha.Value.Month & "-" & DTPFecha.Value.Day
                    registrotpd("ciclo") = AM
                    registrotpd("correlativo") = (i + 1)
                    DSTpd.Tables("sol_actividad_diaria").Rows.Add(registrotpd)
                Next

                da_actividad_diaria.Update(DSTpd, "sol_actividad_diaria")

                'Registrar en la tabla sol_actividad_diaria AM
                For i = 0 To DgvDatosPM.RowCount - 1

                    registrotpdPM = DSTpd.Tables("sol_actividad_diaria").NewRow
                    registrotpdPM("id") = CboRutaPM.Text
                    registrotpdPM("sol_courier_id") = TxtId.Text
                    registrotpdPM("sol_estacion_id") = TxtEstacion.Text
                    registrotpdPM("sol_actividades_id_actividad") = DgvDatosPM.Item(0, i).Value
                    registrotpdPM("sol_ruta_id_ruta") = CboRutaPM.SelectedValue
                    registrotpdPM("hora_inicio") = DgvDatosPM.Item(2, i).Value
                    registrotpdPM("Kilometraje") = DgvDatosPM.Item(3, i).Value
                    registrotpdPM("fecha") = DTPFecha.Value.Year & "-" & DTPFecha.Value.Month & "-" & DTPFecha.Value.Day
                    registrotpdPM("ciclo") = PM
                    registrotpdPM("correlativo") = (i + 1)
                    DSTpd.Tables("sol_actividad_diaria").Rows.Add(registrotpdPM)
                Next

                da_actividad_diaria.Update(DSTpd, "sol_actividad_diaria")


                'Registrar en la tabla sol_ruta_diaria AM
                registrotpdruta = DSTpd.Tables("sol_ruta_diaria").NewRow 
                registrotpdruta("ruta") = CboRuta.Text
                registrotpdruta("sol_courier_id") = TxtId.Text
                registrotpdruta("sol_estacion_id") = TxtEstacion.Text
                registrotpdruta("sol_ruta_id_ruta") = CboRuta.SelectedValue
                registrotpdruta("numero_vehiculo") = CboNumero_vehiculo.Text
                registrotpdruta("entregas_antes_1030") = TxtEntregas_antes_1030.Text
                registrotpdruta("entregas_entre_1030_y_1200") = TxtEntregas_entre_1030_y_1200.Text
                registrotpdruta("entregas_despues_1200") = TxtEntregas_despues_1200.Text
                registrotpdruta("retornos_paq_base") = TxtRetornos_paq_base.Text
                registrotpdruta("total_paradas") = TxtTotal_paradas.Text
                registrotpdruta("total_piezas") = Txttotal_piezas.Text
                registrotpdruta("total_recogidas") = TxtTotal_recogidas.Text
                registrotpdruta("total_paradas_pickup") = TxtTotal_paradas_pickup.Text
                registrotpdruta("total_recogidas_pickup") = TxtTotal_recogidas_pickup.Text
                registrotpdruta("paradas_vacias") = TxtParadas_vacias.Text
                registrotpdruta("total_awbs") = TxtTotal_awbs.Text
                registrotpdruta("total_awbs_WS") = TxtTotal_awbs_WS.Text
                registrotpdruta("total_awbs_spx") = TxtTotal_awbs_spx.Text
                registrotpdruta("fecha_de_ruta") = DTPFecha.Value.Year & "-" & DTPFecha.Value.Month & "-" & DTPFecha.Value.Day
                registrotpdruta("ciclo") = AM

                DSTpd.Tables("sol_ruta_diaria").Rows.Add(registrotpdruta)
                da_ruta_diaria.Update(DSTpd, "sol_ruta_diaria")

                'Registrar en la tabla sol_ruta_diaria PM
                registrotpdrutapm = DSTpd.Tables("sol_ruta_diaria").NewRow
                registrotpdrutapm("ruta") = CboRutaPM.Text
                registrotpdrutapm("sol_courier_id") = TxtId.Text
                registrotpdrutapm("sol_estacion_id") = TxtEstacion.Text
                registrotpdrutapm("sol_ruta_id_ruta") = CboRutaPM.SelectedValue
                registrotpdrutapm("numero_vehiculo") = CboNumero_vehiculoPM.Text
                registrotpdrutapm("entregas_antes_1030") = TxtEntregas_antes_1030PM.Text
                registrotpdrutapm("entregas_entre_1030_y_1200") = TxtEntregas_entre_1030_y_1200PM.Text
                registrotpdrutapm("entregas_despues_1200") = TxtEntregas_despues_1200PM.Text
                registrotpdrutapm("retornos_paq_base") = TxtRetornos_paq_basePM.Text
                registrotpdrutapm("total_paradas") = TxtTotal_paradasPM.Text
                registrotpdrutapm("total_piezas") = Txttotal_piezasPM.Text
                registrotpdrutapm("total_recogidas") = TxtTotal_recogidasPM.Text
                registrotpdrutapm("total_paradas_pickup") = TxtTotal_paradas_pickupPM.Text
                registrotpdrutapm("total_recogidas_pickup") = TxtTotal_recogidas_pickupPM.Text
                registrotpdrutapm("paradas_vacias") = TxtParadas_vaciasPM.Text
                registrotpdrutapm("total_awbs") = TxtTotal_awbsPM.Text
                registrotpdrutapm("total_awbs_WS") = TxtTotal_awbs_WSPM.Text
                registrotpdrutapm("total_awbs_spx") = TxtTotal_awbs_spxPM.Text
                registrotpdrutapm("fecha_de_ruta") = DTPFecha.Value.Year & "-" & DTPFecha.Value.Month & "-" & DTPFecha.Value.Day
                registrotpdrutapm("ciclo") = PM

                DSTpd.Tables("sol_ruta_diaria").Rows.Add(registrotpdrutapm)
                da_ruta_diaria.Update(DSTpd, "sol_ruta_diaria")


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

        End If

    End Sub

End Class
Public Class Form1
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Not ValidarCodigoPostal(txtCP.Text) Then
            MsgBox("El codigo postal debe contener 5 digitos numericos")
            txtCP.Focus()
        End If

        If Not ValidarRFC(txtRFC.Text) Then
            MsgBox("RFC no valido")
            txtRFC.Focus()
        End If

    End Sub

    Public Function ValidarCodigoPostal(numero As String) As Boolean
        If Not System.Text.RegularExpressions.Regex.IsMatch(numero, "^[0-9]{5}$") Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidarRFC(rfc As String) As Boolean
        If Not System.Text.RegularExpressions.Regex.IsMatch(rfc, "^([A-ZÑ&]{3,4}) ?(?:[A-Z]{1}) ?(?:[0-9]{2})(?:0[1-9]|1[012])(?:0[1-9]|[12][0-9]|3[01])(?:[A-Z0-9]{3})?$") Then
            Return False
        End If
        Return True
    End Function

    Private Sub LlenarComboBoxRegimenFiscal()
        ' Creamos una lista con los tipos de régimen fiscal.
        Dim tiposRegimenFiscal As New List(Of String)
        tiposRegimenFiscal.Add("Régimen General de Ley Personas Morales")
        tiposRegimenFiscal.Add("Personas Morales con Fines no Lucrativos")
        tiposRegimenFiscal.Add("Sueldos y Salarios e Ingresos Asimilados a Salarios")
        tiposRegimenFiscal.Add("Régimen de Actividades Empresariales y Profesionales")
        tiposRegimenFiscal.Add("Régimen de Incorporación Fiscal")
        tiposRegimenFiscal.Add("Régimen Simplificado de Confianza")

        ' Llenamos el ComboBox con los tipos de régimen fiscal.
        cmbRegimenFiscal.DataSource = tiposRegimenFiscal
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboBoxRegimenFiscal()
    End Sub

    Private Sub cmbRegimenFiscal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRegimenFiscal.SelectedIndexChanged
        LlenarComboUsoCFDI(cmbRegimenFiscal.SelectedIndex)
    End Sub

    Private Sub LlenarComboUsoCFDI(Regimen As Integer)
        Dim usoCFDI As New List(Of String)

        Select Case Regimen
            Case 1 ' Régimen General de Ley Personas Morales
                usoCFDI.Add("Adquisición de mercancías")
                usoCFDI.Add("Devoluciones, descuentos o bonificaciones")
                usoCFDI.Add("Gastos en general")
                usoCFDI.Add("Rentas")
                usoCFDI.Add("Honorarios")
                usoCFDI.Add("Retenciones")
                usoCFDI.Add("Pagos")
                usoCFDI.Add("Intermediación de pagos")

            Case 2 ' Personas Morales con Fines no Lucrativos
                usoCFDI.Add("Adquisición de mercancías")
                usoCFDI.Add("Devoluciones, descuentos o bonificaciones")
                usoCFDI.Add("Gastos en general")
                usoCFDI.Add("Honorarios")
                usoCFDI.Add("Rentas")
                usoCFDI.Add("Retenciones")
                usoCFDI.Add("Pagos")
                usoCFDI.Add("Intermediación de pagos")

            Case 3 ' Sueldos y Salarios e Ingresos Asimilados a Salarios
                usoCFDI.Add("Honorarios médicos, dentales y gastos hospitalarios")
                usoCFDI.Add("Gastos médicos por incapacidad o discapacidad")
                usoCFDI.Add("Gastos funerales")
                usoCFDI.Add("Donativos")
                usoCFDI.Add("Intereses reales efectivamente pagados por créditos hipotecarios (casa habitación)")
                usoCFDI.Add("Aportaciones voluntarias al SAR")
                usoCFDI.Add("Primas por seguros de gastos médicos")
                usoCFDI.Add("Gastos de transportación escolar obligatoria")
                usoCFDI.Add("Depósitos en cuentas para el ahorro, primas que tengan como base planes de pensiones")
                usoCFDI.Add("Pagos por servicios educativos (colegiaturas)")
                usoCFDI.Add("Sin efectos fiscales")
                usoCFDI.Add("Pagos")
                usoCFDI.Add("Nómina")

            Case 4 ' Régimen de Actividades Empresariales y Profesionales
                usoCFDI.Add("Adquisición de mercancías")
                usoCFDI.Add("Devoluciones, descuentos o bonificaciones")
                usoCFDI.Add("Gastos en general")
                usoCFDI.Add("Construcciones")
                usoCFDI.Add("Mobiliario y equipo de oficina por inversiones")
                usoCFDI.Add("Equipo de transporte")
                usoCFDI.Add("Equipo de computo y accesorios")
                usoCFDI.Add("Dados, troqueles, moldes, matrices y herramental")
                usoCFDI.Add("Comunicaciones telefónicas")
                usoCFDI.Add("Comunicaciones satelitales")
                usoCFDI.Add("Otra maquinaria y equipo")
                usoCFDI.Add("Honorarios médicos, dentales y gastos hospitalarios")
                usoCFDI.Add("Gastos médicos por incapacidad o discapacidad")
                usoCFDI.Add("Gastos funerales")
                usoCFDI.Add("Donativos")
                usoCFDI.Add("Intereses reales efectivamente pagados por créditos hipotecarios (casa habitación)")
                usoCFDI.Add("Aportaciones voluntarias al SAR")
                usoCFDI.Add("Primas por seguros de gastos médicos")
                usoCFDI.Add("Gastos de transportación escolar obligatoria")
                usoCFDI.Add("Depósitos en cuentas para el ahorro, primas que tengan como base planes de pensiones")
                usoCFDI.Add("Pagos por servicios educativos (colegiaturas)")
                usoCFDI.Add("Sin efectos fiscales")
                usoCFDI.Add("Pagos")

            Case 5 ' Régimen de Incorporación Fiscal
                usoCFDI.Add("Adquisición de mercancías")
                usoCFDI.Add("Devoluciones, descuentos o bonificaciones")
                usoCFDI.Add("Gastos en general")
                usoCFDI.Add("Construcciones")
                usoCFDI.Add("Mobiliario y equipo de oficina por inversiones")
                usoCFDI.Add("Equipo de transporte")
                usoCFDI.Add("Equipo de computo y accesorios")
                usoCFDI.Add("Dados, troqueles, moldes, matrices y herramental")
                usoCFDI.Add("Comunicaciones telefónicas")
                usoCFDI.Add("Comunicaciones satelitales")
                usoCFDI.Add("Otra maquinaria y equipo")
                usoCFDI.Add("Sin efectos fiscales")
                usoCFDI.Add("Pagos")

            Case 6 ' Régimen Simplificado de Confianza
                usoCFDI.Add("Adquisición de mercancías")
                usoCFDI.Add("Devoluciones, descuentos o bonificaciones")
                usoCFDI.Add("Gastos en general")
                usoCFDI.Add("Construcciones")
                usoCFDI.Add("Mobiliario y equipo de oficina por inversiones")
                usoCFDI.Add("Equipo de transporte")
                usoCFDI.Add("Equipo de computo y accesorios")
                usoCFDI.Add("Dados, troqueles, moldes, matrices y herramental")
                usoCFDI.Add("Comunicaciones telefónicas")
                usoCFDI.Add("Comunicaciones satelitales")
                usoCFDI.Add("Otra maquinaria y equipo")
                usoCFDI.Add("Sin efectos fiscales")
                usoCFDI.Add("Pagos")

        End Select

        cmbCDFI.DataSource = usoCFDI

    End Sub
End Class

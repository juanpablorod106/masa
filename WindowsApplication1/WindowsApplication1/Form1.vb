Public Class Form1
    Dim precio_zapato As Double = 75.74
    Dim descuento As Double = 1.0
    'Calculadora de zapateria
    'Mas de 10 zapatos = 10%
    'Mas de 20 zapatos = 20%
    'Mas de 30 zapatos = 40%


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_desc.Text = ""
        lbl_st.Text = ""
        lbl_t.Text = ""
    End Sub

    Private Sub btt_calcular_Click(sender As Object, e As EventArgs) Handles btt_calcular.Click

        'Mostrar el descuento - Accion del boton.

        Dim cantidadZapatos As Integer = Int(tbx_c_z.Text)
        If (cantidadZapatos >= 10 And cantidadZapatos < 20) Then
            descuento = 0.1
            lbl_desc.Text = "10%"
        ElseIf (cantidadZapatos >= 20 And cantidadZapatos <= 30) Then
            descuento = 0.2
            lbl_desc.Text = "20%"
        ElseIf (cantidadZapatos > 30) Then
            descuento = 0.4
            lbl_desc.Text = "40%"
        End If

        'Subtotal accion del boton.

        Dim Sub_total As Double = (cantidadZapatos * precio_zapato)
        lbl_st.Text = Sub_total

        'Total calculado.

        Dim Total_total As Double = Sub_total - (Sub_total * descuento)
        lbl_t.Text = Total_total

    End Sub

End Class


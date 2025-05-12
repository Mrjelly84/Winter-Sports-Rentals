Public Class Form1
    Private ReadOnly Taxrate As Double = 0.07
    Private rentalPrices As New Prices

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Today.ToShortDateString

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmWeatherForecast.WebBrowser1.Navigate("https://weather.metoffice.gov.uk/forecast/gctf4tb4d#?forecastChoice=weather&date=2025-05-12")
        frmWeatherForecast.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub btnCalulate_Click(sender As Object, e As EventArgs) Handles btnCalulate.Click
        If lstEquipment.SelectedIndices.Count = 0 Then
            errorProvider.SetError(lstEquipment, "Please select an equipment to rent")
            Return
        Else
            errorProvider.SetError(lstEquipment, "")
        End If

        Dim duration As Prices.DurationType = CType(cboDuration.SelectedIndex, Prices.DurationType)
        If duration = -1 Then
            errorProvider.SetError(cboDuration, "Please select valid duration")
            Return
        Else
            errorProvider.SetError(cboDuration, "")

        End If
        Dim deposit As Double
        If Not Double.TryParse(txtDeposit.Text, deposit) Then
            errorProvider.SetError(txtDeposit, "Desposit must be a positve number")
        Else
            errorProvider.SetError(txtDeposit, "")

        End If

        Dim subTotal As Double = 0
        For Each index As Integer In lstEquipment.SelectedIndices
            Dim equipType As Prices.EquipmentType = CType(index, Prices.EquipmentType)
            subTotal += rentalPrices.GetRentalPrice(equipType, duration)

        Next
        Dim insurance As Double = 0
        If chkInsurance.Checked Then
            insurance = Prices.InsuranceCost(subTotal)

        End If
        subTotal += insurance
        Dim tax As Double = subTotal * Taxrate

        Dim balance As Double = subTotal + tax - deposit
        lblSubtotal.Text = subTotal.ToString("")
        lblTax.Text = tax.ToString("n")
        lblBalance.Text = balance.ToString("c")

    End Sub
End Class

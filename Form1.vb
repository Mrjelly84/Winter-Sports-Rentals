Public Class Form1
    Private ReadOnly Taxrate As Double = 0.07
    Private rentalPrices As New Prices

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Today.ToShortDateString

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmWeatherForecast.WebBrowser1.Navigate("https://www.google.com/search?q=weather&sca_esv=acc27629dfc230bb&sxsrf=AHTn8zqA1UgZ9aCrVEUak7bqxNbxUvBjjw%3A1746794926958&source=hp&ei=rvkdaPv3N--PhbIPxoW-0AI&iflsig=ACkRmUkAAAAAaB4HvpbxutH_Auu6AgDPbG767k5JbVcD&oq=wea&gs_lp=Egdnd3Mtd2l6IgN3ZWEqAggAMg8QIxiABBgnGIoFGEYYgAIyChAjGIAEGCcYigUyERAuGIAEGJECGMcBGIoFGK8BMggQABiABBiSAzILEAAYgAQYkgMYigUyCxAAGIAEGLEDGIMBMgsQABiABBixAxiDATILEAAYgAQYsQMYgwEyCBAAGIAEGLEDMgsQABiABBixAxiDAUjYK1D4CFjQDXABeACQAQCYAVmgAeMBqgEBM7gBAcgBAPgBAZgCBKAC7wGoAgrCAgcQIxgnGOoCwgILEAAYgAQYkQIYigXCAhEQLhiABBixAxjRAxiDARjHAcICDhAAGIAEGLEDGIMBGIoFwgIFEAAYgATCAg4QLhiABBixAxjRAxjHAcICCxAuGIAEGNEDGMcBmAMF8QUezZHde-Nc1ZIHATSgB5smsgcBM7gH6gE&sclient=gws-wiz")
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

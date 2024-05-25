Public Class Form1

    Const dbl800minRate As Double = 19.99
    Const dbl1500minRate As Double = 28.99
    Const dblUnlimitedTalkRate As Double = 39.99

    Const dblSamsungRate As Double = 29.99
    Const dblIphoneRate As Double = 39.99

    Const dblUnlimitedTextRate As Double = 10
    Const dblVideoChatRate As Double = 15

    Const dblTaxRate As Double = 7.5

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declairing our variables
        Dim dbl800min As Double
        Dim dbl1500min As Double
        Dim dblUnlimitedTalk As Double

        Dim dblSamsung As Double
        Dim dblIphone As Double
        Dim dblCustomerPhone As Double

        Dim dblUnlimitedText As Double
        Dim dblVideoChat As Double

        Dim dblSubotal As Double
        Dim dblTax As Double
        Dim dblMonthlyTotal As Double

        ' get inputs
        dbl800min = rad800min.Checked
        dbl1500min = rad1500min.Checked
        dblUnlimitedTalk = radUnlimitedTalk.Checked

        dblSamsung = radSamsung.Checked
        dblIphone = radIphone.Checked
        dblCustomerPhone = radCustmerPhone.Checked


        dblUnlimitedText = chckUnlimitedText.Checked
        dblVideoChat = chckVideoChat.Checked

        ' Calculation
        If rad800min.Checked Then
            dblSubotal += dbl800minRate
        End If
        If rad1500min.Checked Then
            dblSubotal += dbl1500minRate
        End If
        If radUnlimitedTalk.Checked Then
            dblSubotal += dblUnlimitedTalkRate
        End If


        If radSamsung.Checked Then
            dblSubotal += dblSamsungRate
        End If
        If radIphone.Checked Then
            dblSubotal += dblIphoneRate

        End If


        If chckUnlimitedText.Checked Then
            dblSubotal += dblUnlimitedTextRate
        End If
        If chckVideoChat.Checked Then
            dblSubotal += dblVideoChatRate

        End If

        dblTax = dblSubotal * (dblTaxRate / 100)
        dblMonthlyTotal = dblSubotal + dblTax

        'display outputs
        lblSubtotal.Text = FormatCurrency(dblSubotal)
        lblTax.Text = FormatCurrency(dblTax)
        lblMonthlyTotal.Text = FormatCurrency(dblMonthlyTotal)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblMonthlyTotal.ResetText()
        lblSubtotal.ResetText()
        lblTax.ResetText()

        rad800min.Checked = False
        rad1500min.Checked = False
        radUnlimitedTalk.Checked = False

        radIphone.Checked = False
        radSamsung.Checked = False

        chckUnlimitedText.Checked = False
        chckVideoChat.Checked = False

        radCustmerPhone.Focus()
    End Sub

End Class

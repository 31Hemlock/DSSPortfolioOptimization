Public Class frmDeveloperData

    '
    'NZ: Shows the proper forms.
    '
    Private Sub btnInvestments_Click(sender As Object, e As EventArgs) Handles btnInvestments.Click
        frmInvestments.Show()
    End Sub

    Private Sub btnPeriods_Click(sender As Object, e As EventArgs) Handles btnPeriods.Click
        frmPeriods.Show()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Close()
        frmMenu.Show()
    End Sub
End Class
Public Class frmMenu


    '
    'NZ: Added functionality to buttons to display the correct forms.
    '
    Private Sub picTeam_Click(sender As Object, e As EventArgs) Handles picTeam.Click
        'Me.Hide()
        'frmTeam.Show()
    End Sub

    Private Sub picDeveloper_Click(sender As Object, e As EventArgs) Handles picDeveloper.Click
        Me.Hide()
        frmDeveloperData.Show()
    End Sub

    Private Sub btnPreferences_Click(sender As Object, e As EventArgs) Handles btnPreferences.Click
        Me.Hide()
        frmUpdateInfo.Show()

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Application.Exit()
    End Sub
End Class
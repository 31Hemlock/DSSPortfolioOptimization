Public Class FormWelcome

    Private Sub FrmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'NZ: Loads the objects from the CreateObjects class.
        Dim myObject As New CreateObjects
        myObject.MakeObjects()
        myObject.Query()


    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'NZ: Assign user input to variables
        'Dim username = txtUsername.Text
        'Dim password = txtPassword.Text


        'NZ: Sample code:
        'NZ: Determine data in database using SQL
        'Compare data to user-inputted data
        'if SQLUsername.Text = txtUsername.Text & SQLPassword.Text then 
        'frmMenu.Show()
        'Me.close()
        'Else
        'messageBox.Show("Please enter a valid password.")

        Dim username As String = "user"
        Dim password As String = "pass"


        If txtUsername.Text = username And txtPassword.Text = password Then
            Me.Hide()
            frmMenu.Show()
        ElseIf txtUsername.Text <> username Then
            MessageBox.Show("There is no account associated with that username.")
        ElseIf txtPassword.Text <> password Then
            MessageBox.Show("Incorrect password.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        '
        'NZ: Exits the application.
        '
        Application.Exit()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class
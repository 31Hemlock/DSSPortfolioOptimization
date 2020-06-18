Public Class frmUpdateInfo


    'NZ: Creates an array to catch the returned array from the Optimization class.
    Public DVAssignments(9, 7) As Double

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'NZ: Creates a list that will be used to store labels.
        Dim output As New List(Of Label)

        'NZ: Catches non-numeric values.
        If Not IsNumeric(txtBudget.Text) Or Not IsNumeric(txtBudget.Text) Or Not IsNumeric(txtBudget.Text) Then
            MessageBox.Show("Please enter numeric values for each parameter.")

        Else
            'NZ: The following code will run the optimization.
            Dim prjOptimize As New Optimization
            DVAssignments = prjOptimize.BuildModel() 'NZ: This line assigns the array values of the decision variable to the DVAssignments array.



            Dim labelCount As Integer = 0     'NZ: This variable will count the number of output labels that we need to post to the form


            'NZ: Creating labels for each cell in the objective function



            'Nested for loops to sort through each row and column
            For rowIndex As Byte = 0 To DVAssignments.GetLength(0) - 1
                For columnIndex As Byte = 0 To DVAssignments.GetLength(1) - 1
                    If DVAssignments(rowIndex, columnIndex) >= 0 Then
                        'NZ: Creates the label
                        Dim outputLabel As New Label()
                        'NZ: Assigns the label to the list of labels
                        output.Add(outputLabel)
                        output(labelCount).Text = DVAssignments(rowIndex, columnIndex)
                        output(labelCount).Name = "lblInvestment" & (rowIndex + 1).ToString & "_" & "Period" & (columnIndex + 1).ToString
                        'NZ: Adds the labels to their correct cells in the table
                        frmSolution.tblObjective.Controls.Add(output(labelCount))
                        frmSolution.tblObjective.SetColumn(output(labelCount), columnIndex + 1)
                        frmSolution.tblObjective.SetRow(output(labelCount), rowIndex + 1)
                        labelCount += 1

                    End If
                Next
            Next

            '
            'NZ: Setting common label properties
            '
            For labelNumber As Integer = 0 To labelCount - 1
                'output(labelNumber).Anchor = Bottom
                output(labelNumber).Anchor = Top
                output(labelNumber).AutoSize = False
                'output(labelNumber).BorderStyle = BorderStyle.FixedSingle
                'output(labelNumber).ForeColor = Color.Black
                'output(labelNumber).BackColor = Color.Aquamarine
                output(labelNumber).Enabled = True
                'output(labelNumber).Height = 20
                'output(labelNumber).Width = 40
                output(labelNumber).Visible = True
                output(labelNumber).Show()
                output(labelNumber).BringToFront()
                output(labelNumber).TextAlign = ContentAlignment.TopLeft
            Next










            'NZ: Shows the solution form.
            Me.Close()
            frmSolution.Show()

        End If

    End Sub

End Class
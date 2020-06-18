Imports Microsoft.Solverfoundation.Common
Imports Microsoft.Solverfoundation.Services
Imports Microsoft.SolverFoundation.Solvers

Public Class Optimization
    Dim prjCreateObjects As New CreateObjects
    Dim prjSolver As New SimplexSolver


    Public Function BuildModel() As Double(,)
        'NZ: This is is a function so it can return this array:
        Dim decisionVariable(9, 7) As Double

        'NZ: Creates the objects and lists we need.
        prjCreateObjects.MakeObjects()

        ' *******************************************************************
        'NZ: Define the decision variables
        Dim coefficient As Single
        Dim dvKey As String
        Dim dvIndex As Integer

        'HEH: Loop over the 10 investments
        For Each investmentName As InvestmentNames In prjCreateObjects.InvestmentNamesList
            'HEH: Loop over the 8 periods
            For Each period As PeriodNames In prjCreateObjects.PeriodNamesList
                dvKey = investmentName.Investment & "_" & period.Period
                'NZ: 80 unique combinations run by for loops^
                prjSolver.AddVariable(dvKey, dvIndex)
                'NZ: variable has to be >=0 and can go up to infinity
                prjSolver.SetBounds(dvIndex, 0, Rational.PositiveInfinity)
            Next
        Next

        '*******************************************************************
        'HEH: RISK CONSTRAINT
        Dim constraintKey As String
        Dim constraintIndex As Integer

        'NZ: Theorized code:
        'constraintKey = "Risk Constraint"
        'prjSolver.AddRow(constraintKey, constraintIndex)

        Dim columnTotal As Single
        'HEH: we loop through each period
        For Each risk As BetaRiskData In prjCreateObjects.BetaRiskDataList
            constraintKey = "Risk Constraint_" & risk.Name
            prjSolver.AddRow(constraintKey, constraintIndex)
            'HEH: we loop through each investment
            For Each period As PeriodNames In prjCreateObjects.PeriodNamesList
                'HEH: we need to set the beta risk coefficient for each decision variable to be multiplied by its decision variable
                'HEH: the beta risk coefficient is pulled from the list of beta risk data depending on the period
                If period.Period = "Period1" Then coefficient = risk.Period1
                If period.Period = "Period2" Then coefficient = risk.Period2
                If period.Period = "Period3" Then coefficient = risk.Period3
                If period.Period = "Period4" Then coefficient = risk.Period4
                If period.Period = "Period5" Then coefficient = risk.Period5
                If period.Period = "Period6" Then coefficient = risk.Period6
                If period.Period = "Period7" Then coefficient = risk.Period7
                If period.Period = "Period8" Then coefficient = risk.Period8
                'HEH: the decision variables are multiplied by the beta risk coefficients
                dvKey = risk.Name & "_" & period.Period
                dvIndex = prjSolver.GetIndexFromKey(dvKey)
                prjSolver.SetCoefficient(constraintIndex, dvIndex, coefficient)
                columnTotal += dvIndex * coefficient
            Next
            'NZ: upper boundary is user risk tolerance * total amount of the period
            'prjSolver.SetBounds(constraintIndex, 0, frmUpdateInfo.txtRisk.Text * columnTotal)
            prjSolver.SetBounds(constraintIndex, 0, frmUpdateInfo.txtRisk.Text * columnTotal)
            columnTotal = 0
        Next
        'HEH: the lower bound for the risk constraint is zero
        'HEH: the upper bound for the risk constraint is the investor's portfolio risk prefernce times the investor's portfolio desired budget (this is a weighted average)

        'NZ: Theorized code:
        'prjSolver.SetBounds(constraintIndex, 0, Integer.Parse(frmUpdateInfo.txtRisk.Text) * Integer.Parse(frmUpdateInfo.txtBudget.Text))
        'prjSolver.SetBounds(constraintIndex, 0, frmUpdateInfo.txtRisk.Text * frmUpdateInfo.txtBudget.Text)
        prjCreateObjects.objRiskReturn = prjSolver.GetValue(dvIndex).ToDouble()


        '************************************************************************
        'HEH: SOCIAL EQUITY CONSTRAINT

        'HEH: there is one large social equity constraint for the entire portfolio combined so there is one social equity constraint key
        constraintKey = "Social Equity Constraint"

        'HEH: we loop through each period
        For Each socialEquity As SocialEquity In prjCreateObjects.SocialEquityList
            'HEH: we loop through each investment
            For Each period As PeriodNames In prjCreateObjects.PeriodNamesList
                prjSolver.AddRow(constraintKey, constraintIndex)
                coefficient = 1
                'HEH: we need to set the social equity coefficient for each decision variable to be multiplied by
                'HEH: the social equity coefficient is pulled from the list of social equity data depending on the period
                If period.Period = "Period1" Then coefficient = socialEquity.Period1
                If period.Period = "Period2" Then coefficient = socialEquity.Period2
                If period.Period = "Period3" Then coefficient = socialEquity.Period3
                If period.Period = "Period4" Then coefficient = socialEquity.Period4
                If period.Period = "Period5" Then coefficient = socialEquity.Period5
                If period.Period = "Period6" Then coefficient = socialEquity.Period6
                If period.Period = "Period7" Then coefficient = socialEquity.Period7
                If period.Period = "Period8" Then coefficient = socialEquity.Period8
                'HEH: the decision variables are multiplied by the social equity coefficients
                'potentially: dvKey = "Equity" & socialEquity.Name & "_" & period.Period

                If coefficient >= frmUpdateInfo.txtEquity.Text Then
                    dvKey = socialEquity.Name & "_" & period.Period
                    dvIndex = prjSolver.GetIndexFromKey(dvKey)
                    prjSolver.SetCoefficient(constraintIndex, dvIndex, coefficient)
                    prjSolver.SetBounds(constraintIndex, frmUpdateInfo.txtEquity.Text, Rational.PositiveInfinity)
                End If

            Next

        Next
        prjCreateObjects.objEquityReturn = prjSolver.GetValue(constraintIndex).ToDouble() 'NZ: This should show the value of the constraint in the final form - we're getting NaN


        ' *************************************************************************************
        'NZ: Budget constraint

        constraintKey = "Budget constraint"
        prjSolver.AddRow(constraintKey, constraintIndex)

        'NZ: Loop through the 10 investments
        For Each investmentName As InvestmentNames In prjCreateObjects.InvestmentNamesList
            'HEH: Loop over the 8 periods
            For Each period As PeriodNames In prjCreateObjects.PeriodNamesList
                coefficient = 1
                dvKey = investmentName.Investment & "_" & period.Period
                dvIndex = prjSolver.GetIndexFromKey(dvKey)
                prjSolver.SetCoefficient(constraintIndex, dvIndex, coefficient)

            Next
        Next
        'NZ: the lower bound for the risk constraint is the user's input for social equity.
        'NZ: the upper bound is positive infinity.
        prjSolver.SetBounds(constraintIndex, frmUpdateInfo.txtBudget.Text, frmUpdateInfo.txtBudget.Text)
        prjCreateObjects.objBudgetReturn = prjSolver.GetValue(constraintIndex).ToDouble()

        '***************************************************************************************************
        'HEH: We set up the objective function
        Dim objKey As String = "Objective Function"
        Dim objIndex As Integer
        prjSolver.AddRow(objKey, objIndex)
        For Each returnOnInvestment As ReturnOnInvestment In prjCreateObjects.ReturnOnInvestmentList
            'HEH: we loop through each investment
            For Each period As PeriodNames In prjCreateObjects.PeriodNamesList

                dvKey = returnOnInvestment.Name & "_" & period.Period
                dvIndex = prjSolver.GetIndexFromKey(dvKey)

                If period.Period = "Period1" Then coefficient = returnOnInvestment.Period1
                If period.Period = "Period2" Then coefficient = returnOnInvestment.Period2
                If period.Period = "Period3" Then coefficient = returnOnInvestment.Period3
                If period.Period = "Period4" Then coefficient = returnOnInvestment.Period4
                If period.Period = "Period5" Then coefficient = returnOnInvestment.Period5
                If period.Period = "Period6" Then coefficient = returnOnInvestment.Period6
                If period.Period = "Period7" Then coefficient = returnOnInvestment.Period7
                If period.Period = "Period8" Then coefficient = returnOnInvestment.Period8



                prjSolver.SetCoefficient(objIndex, dvIndex, coefficient)
            Next

        Next
        prjSolver.AddGoal(objIndex, 0, False) 'NZ: Falze for maximized
        ' ********************************************************************************
        'HEH: We run the optimization
        Dim mySolverParams As New SimplexSolverParams
        'NZ: Optional solver parameters.
        'mySolverParams.MixedIntegerGapTolerance = 0.01
        'mySolverParams.MaxPivotCount = 1000
        '*********************************************************************************
        'HEH: Run the search algorithm
        prjSolver.Solve(mySolverParams)

        'HEH: Traps errors if the linear problem Is infeasible Or unbounded And does Not work
        If prjSolver.Result = LinearResult.InfeasiblePrimal Then
            MessageBox.Show("infeasible model")
            Exit Function
        End If
        If prjSolver.Result = LinearResult.UnboundedPrimal Then
            MessageBox.Show("unbounded problem")
            Exit Function
        End If

        'HEH: uses a variable to store the objective function value/index into to later display
        prjCreateObjects.objReturn = prjSolver.GetValue(objIndex).ToDouble()

        'HEH: Loop over the 10 investments
        For i = 0 To 9
            'HEH: Loop over the 8 periods
            For j = 0 To 7
                dvKey = "Investment" & i + 1 & "_" & "Period" & j + 1
                'NZ: 80 unique combinations run by for loops^
                prjSolver.AddVariable(dvKey, dvIndex)
                'NZ: variable has to be >=0 and can go up to infinity
                decisionVariable(i, j) = prjSolver.GetValue(dvIndex).ToDouble()
            Next
        Next

        '**************************************************************************************************
        'NZ: Displays the solution.
        frmSolution.txtReturn.Text = prjCreateObjects.objReturn
        frmSolution.txtEquity.Text = prjCreateObjects.objEquityReturn
        frmSolution.txtBudget.Text = prjCreateObjects.objBudgetReturn
        frmSolution.txtRisk.Text = prjCreateObjects.objRiskReturn

        Return decisionVariable

    End Function

End Class
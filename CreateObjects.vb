Public Class CreateObjects

    'NZ: Creates  lists that will hold our values
    Public BetaRiskDataList As New List(Of BetaRiskData)
    Public DecisionVariablesList As New List(Of DecisionVariables)
    Public InvestorParametersList As New List(Of InvestorParameters)
    Public ReturnOnInvestmentList As New List(Of ReturnOnInvestment)
    Public SocialEquityList As New List(Of SocialEquity)
    Public UserList As New List(Of User)
    Public InvestmentNamesList As New List(Of InvestmentNames)
    Public PeriodNamesList As New List(Of PeriodNames)
    Public LabelsList As New List(Of Label)

    'NZ: Creates return variables
    Public objBetaRiskData As New BetaRiskData
    Public objReturn As Integer
    Public objEquityReturn As Double
    Public objRiskReturn As Double
    Public objBudgetReturn As Double

    'NZ: Creates connection to the database and allows for SQL connections
    Dim objDatabase As New Database
    Dim objConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Investment.mdb"
    Dim objSQL As String
    Dim objDataset As New DataSet
    Dim tableName As String

    Public Sub MakeObjects()
        'NZ: Reads the data from the database and loads it into object properties
        'NZ: First we get the table in the dataset updated
        tableName = "BetaRiskData"
        'NZ: Then we create an SQL query
        objSQL = "SELECT * FROM " & tableName

        'NZ: We run the SQL command given the connection and destination
        objDatabase.RunSQL(objConnectionString, objSQL, objDataset, tableName)

        'NZ: We fill our variables with the SQL data in a for loop
        For rowNumber As Integer = 0 To objDataset.Tables(tableName).Rows.Count - 1
            'NZ: We create an instance of our BetaRiskData class to store data

            objBetaRiskData.Name = objDataset.Tables(tableName).Rows(rowNumber)("Name")
            objBetaRiskData.UM = objDataset.Tables(tableName).Rows(rowNumber)("U/M")
            objBetaRiskData.Period1 = objDataset.Tables(tableName).Rows(rowNumber)("Period 1")
            objBetaRiskData.Period2 = objDataset.Tables(tableName).Rows(rowNumber)("Period 2")
            objBetaRiskData.Period3 = objDataset.Tables(tableName).Rows(rowNumber)("Period 3")
            objBetaRiskData.Period4 = objDataset.Tables(tableName).Rows(rowNumber)("Period 4")
            objBetaRiskData.Period5 = objDataset.Tables(tableName).Rows(rowNumber)("Period 5")
            objBetaRiskData.Period6 = objDataset.Tables(tableName).Rows(rowNumber)("Period 6")
            objBetaRiskData.Period7 = objDataset.Tables(tableName).Rows(rowNumber)("Period 7")
            objBetaRiskData.Period8 = objDataset.Tables(tableName).Rows(rowNumber)("Period 8")
            'NZ: We add this data to a list
            BetaRiskDataList.Add(objBetaRiskData)
        Next


        '
        ' ******************************************************************************************
        ' NZ: Repeats the first query for the InvestorParameters table

        tableName = "InvestorParameters"
        objSQL = "SELECT * FROM " & tableName

        objDatabase.RunSQL(objConnectionString, objSQL, objDataset, tableName)

        For rowNumber As Integer = 0 To objDataset.Tables(tableName).Rows.Count - 1
            Dim objInvestorParameters As New InvestorParameters
            objInvestorParameters.Name = objDataset.Tables(tableName).Rows(rowNumber)("Name")
            objInvestorParameters.UM = objDataset.Tables(tableName).Rows(rowNumber)("U/M")
            objInvestorParameters.UserInput = objDataset.Tables(tableName).Rows(rowNumber)("User Input")

            InvestorParametersList.Add(objInvestorParameters)
        Next


        '
        ' ******************************************************************************************
        ' NZ: Repeats the first query for the ReturnOnInvestment table

        tableName = "ReturnOnInvestment"
        objSQL = "SELECT * FROM " & tableName

        objDatabase.RunSQL(objConnectionString, objSQL, objDataset, tableName)

        For rowNumber As Integer = 0 To objDataset.Tables(tableName).Rows.Count - 1
            Dim objReturnOnInvestment As New ReturnOnInvestment
            objReturnOnInvestment.Name = objDataset.Tables(tableName).Rows(rowNumber)("Name")
            objReturnOnInvestment.UM = objDataset.Tables(tableName).Rows(rowNumber)("U/M")
            objReturnOnInvestment.Period1 = objDataset.Tables(tableName).Rows(rowNumber)("Period 1")
            objReturnOnInvestment.Period2 = objDataset.Tables(tableName).Rows(rowNumber)("Period 2")
            objReturnOnInvestment.Period3 = objDataset.Tables(tableName).Rows(rowNumber)("Period 3")
            objReturnOnInvestment.Period4 = objDataset.Tables(tableName).Rows(rowNumber)("Period 4")
            objReturnOnInvestment.Period5 = objDataset.Tables(tableName).Rows(rowNumber)("Period 5")
            objReturnOnInvestment.Period6 = objDataset.Tables(tableName).Rows(rowNumber)("Period 6")
            objReturnOnInvestment.Period7 = objDataset.Tables(tableName).Rows(rowNumber)("Period 7")
            objReturnOnInvestment.Period8 = objDataset.Tables(tableName).Rows(rowNumber)("Period 8")
            ReturnOnInvestmentList.Add(objReturnOnInvestment)
        Next

        '
        ' ******************************************************************************************
        ' NZ: Repeats the first query for the SocialEquity table

        tableName = "SocialEquity"
        objSQL = "SELECT * FROM " & tableName

        objDatabase.RunSQL(objConnectionString, objSQL, objDataset, tableName)

        For rowNumber As Integer = 0 To objDataset.Tables(tableName).Rows.Count - 1
            Dim objSocialEquity As New SocialEquity
            objSocialEquity.Name = objDataset.Tables(tableName).Rows(rowNumber)("Name")
            objSocialEquity.UM = objDataset.Tables(tableName).Rows(rowNumber)("U/M")
            objSocialEquity.Period1 = objDataset.Tables(tableName).Rows(rowNumber)("Period 1")
            objSocialEquity.Period2 = objDataset.Tables(tableName).Rows(rowNumber)("Period 2")
            objSocialEquity.Period3 = objDataset.Tables(tableName).Rows(rowNumber)("Period 3")
            objSocialEquity.Period4 = objDataset.Tables(tableName).Rows(rowNumber)("Period 4")
            objSocialEquity.Period5 = objDataset.Tables(tableName).Rows(rowNumber)("Period 5")
            objSocialEquity.Period6 = objDataset.Tables(tableName).Rows(rowNumber)("Period 6")
            objSocialEquity.Period7 = objDataset.Tables(tableName).Rows(rowNumber)("Period 7")
            objSocialEquity.Period8 = objDataset.Tables(tableName).Rows(rowNumber)("Period 8")
            SocialEquityList.Add(objSocialEquity)
        Next


        '
        ' ******************************************************************************************
        ' NZ: Repeats the first query for the user's login information

        'tableName = "User"
        'objSQL = "SELECT * FROM " & tableName

        'objDatabase.RunSQL(objConnectionString, objSQL, objDataset, tableName)

        'For rowNumber As Integer = 0 To objDataset.Tables(tableName).Rows.Count - 1
        '    Dim objUser As New User
        '    objUser.Username = objDataset.Tables(tableName).Rows(rowNumber)("Username")
        '    objUser.Password = objDataset.Tables(tableName).Rows(rowNumber)("Password")
        '    UserList.Add(objUser)
        'Next

        '
        ' ******************************************************************************************
        ' NZ: Repeats the first query for the InvestmentNames table

        tableName = "InvestmentNames"
        objSQL = "SELECT * FROM " & tableName

        objDatabase.RunSQL(objConnectionString, objSQL, objDataset, tableName)

        For rowNumber As Integer = 0 To objDataset.Tables(tableName).Rows.Count - 1
            Dim objInvestmentNames As New InvestmentNames
            objInvestmentNames.Investment = objDataset.Tables(tableName).Rows(rowNumber)("InvestmentNames")
            InvestmentNamesList.Add(objInvestmentNames)
        Next

        '
        ' ******************************************************************************************
        ' NZ: Repeats the first query for the PeriodNames table

        tableName = "PeriodNames"
        objSQL = "SELECT * FROM " & tableName

        objDatabase.RunSQL(objConnectionString, objSQL, objDataset, tableName)

        For rowNumber As Integer = 0 To objDataset.Tables(tableName).Rows.Count - 1
            Dim objPeriodNames As New PeriodNames
            objPeriodNames.Period = objDataset.Tables(tableName).Rows(rowNumber)("PeriodNames")
            PeriodNamesList.Add(objPeriodNames)
        Next



    End Sub
    Public Sub Query()

    End Sub
End Class

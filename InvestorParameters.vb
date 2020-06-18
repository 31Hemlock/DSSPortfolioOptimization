Public Class InvestorParameters

    '
    'NZ: Creates a property for each column of the table.
    'These properties are used for data storage.

    'NZ: Name of the field.

    Public Property Name As String

    'NZ: Unit of measurement.

    Public Property UM As String

    'NZ: Long values representing user inputted data.

    Public Property UserInput As Double

    Public Property DesiredBetaTolerance As Double

    Public Property DesiredSocialEquity As Single

    Public Property DesiredBudget As Long

    'NZ: New constructor.


    Public Sub New()

    End Sub

End Class

Public Class BetaRiskData

    '
    'NZ: Creates a property for each column of the table.
    'Information about risk using Beta

    'NZ: Name of the field.

    Public Property Name As String

    'NZ: Unit of measurement.

    Public Property UM As String

    'NZ: Short values that hold information about risk
    'for different periods of time.

    Public Property Period1 As Double
    Public Property Period2 As Double
    Public Property Period3 As Double
    Public Property Period4 As Double
    Public Property Period5 As Double
    Public Property Period6 As Double
    Public Property Period7 As Double
    Public Property Period8 As Double

    'NZ: New constructor.

    Public Sub New()

    End Sub

End Class

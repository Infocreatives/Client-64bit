Public Class TextAndValueInComboExtension
    Public DisplayText As String
    Public ItemValue As String
    Public Item As String
    Public Item1 As String
    Public Item2 As String
    Public Sub New(ByVal NewItemValue As String, ByVal NewDisplayText As String, ByVal NewItem As String)
        DisplayText = NewDisplayText
        ItemValue = NewItemValue
        Item = NewItem
    End Sub
    Public Overrides Function ToString() As String
        Return DisplayText
    End Function
End Class

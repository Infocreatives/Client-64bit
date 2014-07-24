Public Enum ShowDialogTypes
    ShowDialogSystemModal
End Enum

Public Class datetm
    Private Sub datetm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As Integer
        a = My.Computer.Clock.LocalTime.Year
        For i As Integer = 1 To 12
            ComboBox1.Items.Add(i)
        Next
        For i As Integer = a - 1 To a
            ComboBox2.Items.Add(i)
        Next
        MonthCalendar1.MaxSelectionCount = 1
        ComboBox1.SelectedItem = My.Computer.Clock.LocalTime.Month
        ComboBox2.SelectedItem = My.Computer.Clock.LocalTime.Year
        MonthCalendar1.TodayDate = Now

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox2.SelectedItem = Nothing Then
            ComboBox2.SelectedItem = My.Computer.Clock.LocalTime.Year
        End If
        MonthCalendar1.SetDate(ComboBox1.Text + "/1/" + ComboBox2.Text)
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox1.SelectedItem = Nothing Then
            ComboBox1.SelectedItem = My.Computer.Clock.LocalTime.Month
        End If
        MonthCalendar1.SetDate(ComboBox1.Text + "/1/" + ComboBox2.Text)
    End Sub
    Public Overloads Function ShowDialog(ByVal ShowSystemModal As ShowDialogTypes) As DialogResult
        Me.TopMost = True
        Me.StartPosition = FormStartPosition.CenterScreen
        Return MyBase.ShowDialog()
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        strDate = (MonthCalendar1.SelectionRange.Start.Day.ToString) + "/" + (MonthCalendar1.SelectionRange.Start.Month.ToString) + "/" + (MonthCalendar1.SelectionRange.Start.Year.ToString)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class
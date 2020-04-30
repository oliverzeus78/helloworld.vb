Public Class Form1
    Dim Names(9) As String
    Dim Marks(9) As String
    Dim StCount As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Names(StCount) = InputBox("Enter the name of the student")
        Marks(StCount) = InputBox("Enter the mark")
        DataGridView1.Rows.Add(Names(StCount), Marks(StCount))
        StCount = StCount + 1
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim I As Integer
        Dim MaxPos As Integer
        MaxPos = 0
        For I = 1 To StCount - 1
            If Marks(I) > Marks(MaxPos) Then
                MaxPos = I
            End If
        Next
        MsgBox("student" & Names(MaxPos) & "has the maximum mark")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim I As Integer
        Dim MinPos As Integer
        MinPos = 0
        For I = 1 To StCount - 1
            If Marks(I) < Marks(MinPos) Then
                MinPos = I
            End If
        Next
        MsgBox("student" & Names(MinPos) & "has the minimum mark")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim I As Integer
        Dim AVG As Double
        AVG = 0
        For I = 0 To StCount - 1
            AVG += Marks(I)
        Next
        AVG = AVG / StCount
        MsgBox("The average is: " & AVG)
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub
End Class

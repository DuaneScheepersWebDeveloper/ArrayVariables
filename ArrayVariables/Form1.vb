Public Class Form1
    Dim aiData(4) As String
    Dim i As Integer
    Public Sub btnEx1_Click(sender As Object, e As EventArgs) Handles btnEx1.Click
        aiData(0) = "5"
        aiData(1) = "7"
        aiData(2) = "33"
        aiData(3) = "22"
        aiData(4) = "8"

        For i = 0 To 4
            MsgBox(aiData(i))
        Next
    End Sub

    Public Sub btnEx2_Click(sender As Object, e As EventArgs) Handles btnEx2.Click
        Dim itotal As Integer
        For i = 0 To 4
            itotal += aiData(i)
        Next
        MsgBox("Exercise 3 , Your Total is : " & itotal)
    End Sub
End Class

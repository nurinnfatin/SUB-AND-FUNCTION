Public Class Form1
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        lbl1.Text = "Submit"
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Dim strText As String
        strText = txt1.Text
        lbl2.Text = strText
    End Sub

    Private Function Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        lbl3.Text = "Submit"
        Return lbl3
    End Function

    Private Function Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Dim strText2 As String
        strText2 = txt2.Text
        lbl4.Text = txt2.Text
        Return lbl4

    End Function
End Class

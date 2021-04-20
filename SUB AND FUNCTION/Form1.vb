Public Class Form1
    Private Sub S1()
        lbl1.Text = "Submit"
    End Sub
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        S1()
    End Sub

    Private Sub S2()
        Dim strText As String
        strText = txt1.Text
        lbl2.Text = strText
    End Sub
    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        S2()
    End Sub

    Private Function F1()
        Return "DATA TERSEBUT"
    End Function

    Private Function Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        lbl3.Text = F1()

    End Function

    Private Function F2()
        Dim strText2 As String
        strText2 = txt2.Text
        Return strText2

    End Function

    Private Function Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click

        lbl4.Text = F2()
    End Function

End Class

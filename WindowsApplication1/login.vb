Public Class login

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String

        username = uname.Text
        password = upass.Text

        If (username.Equals("Admin") And password.Equals("Admin@123")) Then
            Me.Hide()
            Borrow.Show()
        Else
            MsgBox("Error : Please Try Again....")
        End If
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click
        Me.Hide()
        Admin.Show()
    End Sub

End Class

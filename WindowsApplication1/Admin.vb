Public Class Admin

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click
        Me.Hide()
        login.Show()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim password As String
        password = adpass.Text

        If (password.Equals("Admin@123")) Then
            Me.Hide()
            Books.Show()
        Else
            MsgBox("Error : Please Try Again....")
        End If
    End Sub
End Class
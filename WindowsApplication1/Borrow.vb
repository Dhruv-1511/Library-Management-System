Imports System.Data.OleDb

Public Class Borrow
    Sub recordshow()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB\Library Management\WindowsApplication1\Books.accdb")
        con.Open()
        Dim adp As New OleDbDataAdapter("select * from Borrow", con)
        Dim ds As New DataSet
        adp.Fill(ds, "lib")
        DataGridView1.DataSource = ds.Tables("lib")
        con.Close()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB\Library Management\WindowsApplication1\Books.accdb")
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into Borrow values(" & cid.Text & ", '" & cname.Text & "', " & bookid.Text & ", '" & bookname.Text & "', '" & bdate.Value & "')"
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record inserted Successfully.....")
        recordshow()

    End Sub

    Private Sub Borrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        recordshow()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB\Library Management\WindowsApplication1\Books.accdb")
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from Borrow where Customer_id= " & cid.Text & " "
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record Deleted Successfully.....")
        recordshow()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB\Library Management\WindowsApplication1\Books.accdb")
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update Borrow set Customer_Name='" & cname.Text & "', Book_Id=" & bookid.Text & ", Book_name='" & bookname.Text & "' where Customer_Id=" & cid.Text & " "
        cmd.ExecuteNonQuery()
        cmd.Clone()
        MsgBox("Record Updated Successfully.....")
        recordshow()
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        Me.Hide()
        Returnback.Show()

    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click
        Me.Close()
        login.Show()
    End Sub

End Class
Imports System.Data.OleDb

Public Class Books
    Sub recordshow()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB\Library Management\WindowsApplication1\Books.accdb")
        con.Open()
        Dim adp As New OleDbDataAdapter("select * from Books", con)
        Dim ds As New DataSet
        adp.Fill(ds, "lib")
        DataGridView1.DataSource = ds.Tables("lib")
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB\Library Management\WindowsApplication1\Books.accdb")
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into Books values(" & bid.Text & ", '" & bname.Text & "', '" & blang.Text & "', '" & aname.Text & "', " & price.Text & ")"
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record inserted Successfully.....")
        recordshow()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB\Library Management\WindowsApplication1\Books.accdb")
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from Books where Books_Id= " & bid.Text & " "
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
        cmd.CommandText = "update Books set Books_Name='" & bname.Text & "', Books_Lang='" & blang.Text & "', Author_Name='" & aname.Text & "', Price=" & price.Text & " where Books_Id=" & bid.Text & " "
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record Updated Successfully.....")
        recordshow()
    End Sub

    Private Sub Books_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        recordshow()
    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click
        Me.Close()
        Admin.Show()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB\Library Management\WindowsApplication1\Books.accdb")
        con.Open()
        Dim adp As New OleDbDataAdapter("select * from Books where Books_Id=" & bid.Text & " ", con)
        Dim ds As New DataSet
        adp.Fill(ds, "aa")
        DataGridView1.DataSource = ds.Tables("aa")
        con.Close()
    End Sub
End Class
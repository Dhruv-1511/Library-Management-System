Imports System.Data.OleDb

Public Class Returnback
    Sub recordshow()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB\Library Management\WindowsApplication1\Books.accdb")
        con.Open()
        Dim adp As New OleDbDataAdapter("select * from Return", con)
        Dim ds As New DataSet
        adp.Fill(ds, "lib")
        DataGridView1.DataSource = ds.Tables("lib")
        con.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB\Library Management\WindowsApplication1\Books.accdb")
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update Return set Customer_Name='" & rcname.Text & "', Book_Id=" & rbid.Text & ", Book_name='" & rbname.Text & "' where Customer_Id=" & rcid.Text & " "
        cmd.ExecuteNonQuery()
        cmd.Clone()
        MsgBox("Record Updated Successfully.....")
        recordshow()
    End Sub

    Private Sub Returnback_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        recordshow()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB\Library Management\WindowsApplication1\Books.accdb")
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from Return where Customer_id= " & rcid.Text & " "
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record Deleted Successfully.....")
        recordshow()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        Me.Hide()
        Borrow.Show()

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB\Library Management\WindowsApplication1\Books.accdb")
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into Return values(" & rcid.Text & ", '" & rcname.Text & "', " & rbid.Text & ", '" & rbname.Text & "', '" & rdate.Value & "')"
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record inserted Successfully.....")
        recordshow()
    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click
        Me.Close()
        login.Show()
    End Sub
End Class
Imports System.Data.OleDb
Public Class Form1
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\DCTRAVELERS\tickets.accdb")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mycon.Open()
        Dim mycmd As New OleDbCommand("Insert into Passenger(Username,Name,Telephone)Values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')", mycon)
        Try
            mycmd.ExecuteNonQuery()
            mycon.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
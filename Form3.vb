Imports System.Data.OleDb
Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim con As New OleDbConnection
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\DCTRAVELERS\tickets.accdb")
        con.Open()

        Dim strsql As String
        Dim strsqll As String

        'strsql = " SELECT JID,BID,Frm,To,DepartureTime,BusName FROM Journey WHERE JID='" + TextBox2.Text + "'"
        strsqll = "SELECT Username,Name,Telephone FROM Passenger WHERE Username='" + TextBox1.Text + "'"
        strsql = "SELECT Journey.JID, Journey.BID, Journey.Frm, Journey.To, Journey.DepartureTime,Journey.Cost,Journey.Time,Bus.BusName,Bus.ParkingPlace FROM Bus INNER JOIN Journey ON Bus.BID = Journey.BID WHERE (((Journey.[To])='" + TextBox2.Text + "'));"

        Dim cmd As New OleDbCommand(strsql, con)
        Dim myreader As OleDbDataReader
        Dim cmdd As New OleDbCommand(strsqll, con)
        Dim myreaderr As OleDbDataReader

        myreader = cmd.ExecuteReader
        myreader.Read()
        myreaderr = cmdd.ExecuteReader
        myreaderr.Read()





        Form4.TextBox1.Text = myreaderr("Name")
        Form4.TextBox2.Text = myreaderr("Telephone")
        Form4.TextBox3.Text = myreader("JID")
        Form4.TextBox4.Text = myreader("Frm")
        Form4.TextBox5.Text = myreader("To")
        Form4.TextBox6.Text = myreader("BusName")
        Form4.TextBox7.Text = myreader("DepartureTime")
        Form4.TextBox8.Text = myreader("ParkingPlace")
        'Form4.TextBox9.Text = myreaderr()
        Form4.TextBox10.Text = myreader("Cost")
        Form4.TextBox11.Text = myreader("Time")
        Form4.Show()

        con.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
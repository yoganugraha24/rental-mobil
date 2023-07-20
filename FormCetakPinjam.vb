Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Public Class FormCetakPinjam

    Private Sub FormCetakPinjam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        Button1.Visible = True

    End Sub
End Class
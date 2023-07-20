Imports System.Data.Odbc
Public Class FormLog

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
    Sub KondisiAwal()
        TextBox1.Text = "USR01"
        TextBox2.Text = "ADMIN1"
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Kode User dan Password  belum lengkap")
            Exit Sub
        Else
            Call Koneksi()
            Cmd = New OdbcCommand("Select * from tbl_petugas where KodeUser='" & TextBox1.Text & "' and PasswordUser='" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Close()
                FormMenuUtama.STSlabel2.Text = Rd!KodeUser
                FormMenuUtama.STSLabel4.Text = Rd!Namauser
                FormMenuUtama.STSLabel6.Text = Rd!LevelUser
                FormMenuUtama.Show()
                FormMenuUtama.LoginToolStripMenuItem.Enabled = False
                FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
                FormMenuUtama.MasterToolStripMenuItem.Enabled = True
                FormMenuUtama.TransaksiToolStripMenuItem.Enabled = True
                FormMenuUtama.AboutToolStripMenuItem.Enabled = True
            Else
                MsgBox("Kode User atau Password salah")
            End If
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
Imports System.Data.Odbc
Public Class FormMenuUtama
    Sub Terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        AboutToolStripMenuItem.Enabled = False
    End Sub

    Private Sub FormMenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Terkunci()
        STSLabel10.Text = Today
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        FormLog.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Terkunci()
    End Sub

    Private Sub MasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterToolStripMenuItem.Click

    End Sub

    Private Sub PetugasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PetugasToolStripMenuItem.Click
        FormAdmin.ShowDialog()
    End Sub

    Private Sub AnggotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnggotaToolStripMenuItem.Click
        FormPelanggan.ShowDialog()
    End Sub

    Private Sub MobilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MobilToolStripMenuItem.Click
        Formmobil.ShowDialog()
    End Sub

    Private Sub PeminjamanFilmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeminjamanFilmToolStripMenuItem.Click
        FormPeminjaman.ShowDialog()
    End Sub

    Private Sub PengembalianFilmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PengembalianFilmToolStripMenuItem.Click
        FormPengembalian.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        STSLabel8.Text = TimeOfDay
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
    End Sub

    Private Sub About1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles About1ToolStripMenuItem.Click
        FormAbout.ShowDialog()
    End Sub
End Class

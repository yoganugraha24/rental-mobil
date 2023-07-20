Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Public Class FormAdmin
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Call koneksi()
        da = New OdbcDataAdapter("Select kodeuser,Namauser,leveluser From tbl_petugas", Conn)
        Ds = New DataSet
        da.Fill(ds, "tbl_petugas")
        DataGridView1.DataSource = ds.Tables("tbl_petugas")
        DataGridView1.ReadOnly = True


    End Sub
    Sub SiapIsi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
        ComboBox1.Items.Add("ADMIN")
        ComboBox1.Items.Add("USER")

    End Sub
    Private Sub FormAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silakan Isi Semua Field")
            Else
                Call koneksi()
                Dim InputData As String = "insert into tbl_petugas values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
                Cmd = New OdbcCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button2.Text = "Simpan"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silakan Isi Semua Field")
            Else
                Call koneksi()
                Dim UpdateData As String = "Update tbl_petugas set Namauser='" & TextBox2.Text & "',PasswordUser='" & TextBox3.Text & "',LevelUser='" & ComboBox1.Text & "'where kodeUser='" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(UpdateData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Update Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From tbl_petugas where KodeUser = '" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox1.Text = Rd.Item("KodeUser")
                TextBox2.Text = Rd.Item("Namauser")
                TextBox3.Text = Rd.Item("PasswordUser")
                ComboBox1.Text = Rd.Item("LevelUser")
            Else
                MsgBox("Data Tidak Ada")

            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "Tutup" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "Hapus" Then
            Button3.Text = "Delete"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silakan Isi Semua Field")
            Else
                Call koneksi()
                Dim HapusData As String = "Delete from tbl_petugas where KodeUser = '" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
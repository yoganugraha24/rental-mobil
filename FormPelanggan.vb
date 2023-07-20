Imports System.Data.Odbc
Public Class FormPelanggan
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        ComboBox1.Enabled = False

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Call koneksi()
        da = New OdbcDataAdapter("Select kodepelanggan,Nama,Alamat,JenisKelamin,Telepon From tbl_pelanggan", Conn)
        ds = New DataSet
        da.Fill(ds, "tbl_pelanggan")
        DataGridView1.DataSource = ds.Tables("tbl_pelanggan")
        DataGridView1.ReadOnly = True


    End Sub
    Sub SiapIsi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
        ComboBox1.Items.Add("PRIA")
        ComboBox1.Items.Add("WANITA")
        TextBox4.Enabled = True

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
                Call Koneksi()
                Dim InputData As String = "insert into tbl_pelanggan values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "')"
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Silakan Isi Semua Field")
            Else
                Call Koneksi()
                Dim UpdateData As String = "Update tbl_pelanggan set Nama='" & TextBox2.Text & "',Alamat='" & TextBox3.Text & "',JenisKelamin='" & ComboBox1.Text & "',Telepon='" & TextBox4.Text & "'where kodepelanggan='" & TextBox1.Text & "'"
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
            Cmd = New OdbcCommand("Select * From tbl_pelanggan where Kodepelanggan = '" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox1.Text = Rd.Item("Kodepelanggan")
                TextBox2.Text = Rd.Item("Nama")
                TextBox3.Text = Rd.Item("Alamat")
                TextBox4.Text = Rd.Item("Telepon")
                ComboBox1.Text = Rd.Item("JenisKelamin")
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Silakan Isi Semua Field")
            Else
                Call Koneksi()
                Dim HapusData As String = "Delete from tbl_pelanggan where Kodepelanggan = '" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub
End Class
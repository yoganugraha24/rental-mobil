Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Public Class FormPeminjaman
    Dim tglsql As String
    Sub KondisiAwal()
        LBPetugas.Text = FormMenuUtama.STSLabel4.Text
        LBNama.Text = ""
        LBAlamat.Text = ""
        LBTelepon.Text = ""
        LBhargamobil.Text = ""
        LBtahunmobil.Text = ""
        ComboBox1.Text = ""
        Call NoOtomatis()
        Call MunculKodePelanggan()
        Label14.Text = "0"
    End Sub
    Private Sub FormPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        grid()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBJam.Text = TimeOfDay
    End Sub
    Sub NoOtomatis()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tbl_pinjam where Nopinjam in (select max(Nopinjam) from tbl_pinjam)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "PJM" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "PJM" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBNoPinjam.Text = UrutanKode
    End Sub
    Sub MunculKodePelanggan()
        Call Koneksi()
        ComboBox1.Items.Clear()
        Cmd = New OdbcCommand("Select * from tbl_pelanggan", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tbl_pelanggan where kodepelanggan = '" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBNama.Text = Rd!Nama
            LBAlamat.Text = Rd!Alamat
            LBTelepon.Text = Rd!Telepon

        End If
    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From tbl_mobil where NomorPolisi = '" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox1.Text = Rd.Item("NomorPolisi")
                LBNamaMobil.Text = Rd.Item("NamaMobil")
                LBtahunmobil.Text = Rd.Item("Tahunmobil")
                LBhargamobil.Text = Rd.Item("HargaSewa")
                TextBox7.Text = Rd.Item("Jumlah")
                TextBox2.Text = True
                TextBox2.Text = "1"
            Else
                MsgBox("kode mobil Tidak Ada")

            End If
        End If
    End Sub

    Sub save()
        Call Koneksi()
        
        Dim str As String


        str = "insert into tbl_pinjam(Nopinjam,Tglpinjam,Jampinjam,Kodepelanggan,NomorPolisi,LamaPinjam,JumlahPinjam ,NoKTP,NoSIM,UangBayar,SisaBayar,Kembalian,TotalBayar,Kodepetugas) values('" & LBNoPinjam.Text & "','" & DTPEM.Text & "','" & LBJam.Text & "','" & ComboBox1.Text & "','" & TextBox1.Text & "','" & TextBox6.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox3.Text & "','" & Label21.Text & "','" & Label8.Text & "','" & Label14.Text & "','" & FormMenuUtama.STSlabel2.Text & "')"


        Cmd = New OdbcCommand(str, Conn)
        Cmd.ExecuteNonQuery()

        MsgBox("Data telah disave")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'DataGridView1.Rows.Add(New String() {LBNoPinjam.Text, tglsql.ToString, LBJam.Text, ComboBox1.Text, TextBox1.Text, TextBox6.Text, TextBox4.Text, TextBox5.Text, TextBox3.Text, Label21.Text, Label8.Text, Label14.Text, FormMenuUtama.STSlabel2.Text})
        RumusSubtotal()
        'TextBox1.Text = ""
        'LBNamaMobil.Text = ""
        'LBhargamobil.Text = ""
        'TextBox2.Text = ""
        'TextBox2.Enabled = False
        Dim kurang, bil As Integer
        bil = TextBox7.Text
        kurang = bil - 1
        Label24.Text = kurang


    End Sub
    Sub RumusSubtotal()
        Dim Lama As Integer
        Dim LBH, hitung As Integer
        Lama = TextBox6.Text
        LBH = LBhargamobil.Text
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            'DataGridView1.Rows(i).Cells(5).Value
            hitung = LBH * Lama
            Label14.Text = hitung
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Koneksi()
        Dim str2 As String
        save()
        str2 = "Update tbl_mobil set Jumlah='" & Label24.Text & "'where NomorPolisi ='" & TextBox1.Text & "'"
        Cmd = New OdbcCommand(str2, Conn)
        Cmd.ExecuteNonQuery()
        grid()
        cetak()

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call KondisiAwal()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox3.Text) < Val(Label14.Text) Then
                Label8.Text = "0"
                Label21.Text = Val(Label14.Text) - Val(TextBox3.Text)
            ElseIf Val(TextBox3.Text) = Val(Label14.Text) Then
                Label8.Text = "0"
                Label21.Text = "0"
            ElseIf Val(TextBox3.Text) > Val(Label14.Text) Then
                Label8.Text = Val(TextBox3.Text) - Val(Label14.Text)
                Button1.Focus()
            End If
        End If
    End Sub
    Sub grid()
        Call Koneksi()
        da = New OdbcDataAdapter("Select Nopinjam as NO_PINJAM, Tglpinjam as TANGGAL_PINJAM, Kodepelanggan as KODE_PELANGGAN, NomorPolisi as NOMOR_POLISI, LamaPinjam as LAMA_PINJAM,JumlahPinjam as JUMLAH_PINJAM,NoKTP as NO_KTP, NoSIM as NO_SIM,UangBayar as UANG_BAYAR, SisaBayar as SISA_BAYAR, Kembalian as KEMBALIAN, TotalBayar as TOTAL_BAYAR,Kodepetugas as KODE_PETUGAS from tbl_pinjam ", Conn)
        ds = New DataSet()
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns("NO_PINJAM").Width = 100
        DataGridView1.Columns("TANGGAL_PINJAM").Width = 100
        DataGridView1.Columns("KODE_PELANGGAN").Width = 100
        DataGridView1.Columns("NOMOR_POLISI").Width = 100
        DataGridView1.Columns("LAMA_PINJAM").Width = 100
        DataGridView1.Columns("JUMLAH_PINJAM").Width = 100
        DataGridView1.Columns("NO_KTP").Width = 100
        DataGridView1.Columns("NO_SIM").Width = 100
        DataGridView1.Columns("UANG_BAYAR").Width = 100
        DataGridView1.Columns("SISA_BAYAR").Width = 100
        DataGridView1.Columns("KEMBALIAN").Width = 100
        DataGridView1.Columns("TOTAL_BAYAR").Width = 100
        DataGridView1.Columns("KODE_PETUGAS").Width = 100

    End Sub

    Sub cetak()
        FormCetakPinjam.Show()

        FormCetakPinjam.Label23.Text = LBNoPinjam.Text
        FormCetakPinjam.Label22.Text = ComboBox1.Text
        FormCetakPinjam.Label21.Text = DTPEM.Text
        FormCetakPinjam.Label20.Text = LBAlamat.Text
        FormCetakPinjam.Label19.Text = LBNamaMobil.Text
        FormCetakPinjam.Label18.Text = TextBox1.Text
        FormCetakPinjam.Label17.Text = TextBox6.Text
        FormCetakPinjam.Label16.Text = TextBox2.Text
        FormCetakPinjam.Label15.Text = TextBox3.Text
        FormCetakPinjam.Label14.Text = Label14.Text
        FormCetakPinjam.Label13.Text = Label8.Text
        FormCetakPinjam.Label24.Text = Label21.Text
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click
    End Sub
End Class

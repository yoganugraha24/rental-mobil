Imports System.Data.Odbc
Public Class FormPengembalian
    Private Sub KondisiAwal()
        'TxtN.Text = ""
        Label16.Text = ""
        Label17.Text = ""
        Label8.Text = ""
        Label18.Text = ""
        Call NoOtomatis()
    End Sub
    Sub TampilGrid1()
        Call Koneksi()
        da = New OdbcDataAdapter("Select KodePengembalian as KODE_PENGEMBALIAN, NoPinjam as NO_PINJAM,Kodepelanggan as KODE_PELANGGAN, NomorPolisi as NOMOR_POLISI, TglPinjam as TANGGAL_PINJAM,TglPengembalian as TANGGAL_PENGEMBALIAN,NamaMobil as NAMA_MOBIL, LamaPinjam as LAMA_PINJAM,JumlahPinjam as JUMLAH_PINJAM, Denda as DENDA, Dibayar as DIBAYAR, Kembalian as KEMBALIAN From tbl_pengembalian ", Conn)
        ds = New DataSet()
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns("KODE_PENGEMBALIAN").Width = 100
        DataGridView1.Columns("NO_PINJAM").Width = 100
        DataGridView1.Columns("KODE_PELANGGAN").Width = 100
        DataGridView1.Columns("NOMOR_POLISI").Width = 100
        DataGridView1.Columns("TANGGAL_PINJAM").Width = 100
        DataGridView1.Columns("TANGGAL_PENGEMBALIAN").Width = 100
        DataGridView1.Columns("NAMA_MOBIL").Width = 100
        DataGridView1.Columns("LAMA_PINJAM").Width = 100
        DataGridView1.Columns("JUMLAH_PINJAM").Width = 100
        DataGridView1.Columns("DENDA").Width = 100
        DataGridView1.Columns("DIBAYAR").Width = 100
        DataGridView1.Columns("KEMBALIAN").Width = 100

    End Sub
    Sub save()
        Call Koneksi()

        Dim str As String
        str = "insert into tbl_pengembalian(KodePengembalian,Nopinjam,Kodepelanggan,NomorPolisi,TglPinjam,TglPengembalian,NamaMobil,LamaPinjam,JumlahPinjam,Denda,Dibayar,Kembalian) values('" & LBpengembalian.Text & "','" & TextBox1.Text & "','" & Label16.Text & "','" & Label17.Text & "','" & label8.Text & "','" & DateTimePicker1.Text & "','" & Label18.Text & "','" & LblLamaPjm.Text & "','" & TextBox2.Text & "','" & LBL_Denda.Text & "','" & TxtDibayar.Text & "','" & Label12.Text & "')"
        Cmd = New OdbcCommand(str, Conn)
        Cmd.ExecuteNonQuery()

        MsgBox("Data telah disave")
        TampilGrid1()

    End Sub

    Private Sub FormPengembalian_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TampilGrid1()
        Call KondisiAwal()
        Call Koneksi()
        Call TampilGrid1()
        'Call HapusMaster()
        'Call Otomatis()
        LblNamaPelanggan.Text = FormMenuUtama.STSLabel4.Text
    End Sub

    Sub tampilPelanggan()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * From tbl_pelanggan where Kodepelanggan = '" & Label16.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LblNamaPelanggan.Text = Rd.Item("Nama")
        End If

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From tbl_pinjam where NoPinjam = '" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox1.Text = Rd.Item("NoPinjam")
                Label16.Text = Rd.Item("Kodepelanggan")
                Label17.Text = Rd.Item("NomorPolisi")
                label8.Text = Rd.Item("Tglpinjam")
                LblLamaPjm.Text = Rd.Item("LamaPinjam")
                TextBox2.Text = Rd.Item("JumlahPinjam")

                tampilPelanggan()
                tampilMobil()
            Else
                MsgBox("Nomor Pinjam Tidak Ada")

            End If
        End If

    End Sub

    Sub tampilMobil()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * From tbl_mobil where NomorPolisi = '" & Label17.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Label13.Text = Rd.Item("Jumlah")
            Label18.Text = Rd.Item("NamaMobil")
        Else
            MsgBox("kode mobil Tidak Ada")

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label3.Text = DateDiff(DateInterval.Day, label8.Value, DateTimePicker1.Value)
        Dim lbl3, lbl, hitung As Integer
        lbl3 = Label3.Text
        lbl = LblLamaPjm.Text
        hitung = lbl3 - lbl
        Label20.Text = hitung
        If Label20.Text = 0 Then
            LBL_Denda.Text = "0"
        ElseIf Label20.Text >= 1 Then
            LBL_Denda.Text = "50000"
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim bil1, bil2, Hitung As Integer
        bil1 = TxtDibayar.Text
        bil2 = LBL_Denda.Text
        Hitung = bil1 - bil2
        Label12.Text = Hitung
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Koneksi()
        Dim kurang, bil As Integer
        bil = Label13.Text
        kurang = bil + 1
        Dim str2 As String
        save()
        str2 = "Update tbl_mobil set Jumlah='" & kurang & "'where NomorPolisi ='" & Label17.Text & "'"
        Cmd = New OdbcCommand(str2, Conn)
        Cmd.ExecuteNonQuery()
        cetak()

    End Sub

    Sub NoOtomatis()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tbl_pengembalian where KodePengembalian in (select max(KodePengembalian) from tbl_pengembalian)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "PGM" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "PGM" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBpengembalian.Text = UrutanKode
    End Sub

    Sub cetak()
        FormCetakPengembalian.Show()

        FormCetakPengembalian.Label23.Text = LBpengembalian.Text
        FormCetakPengembalian.Label22.Text = TextBox1.Text
        FormCetakPengembalian.Label21.Text = Label16.Text
        FormCetakPengembalian.Label20.Text = Label17.Text
        FormCetakPengembalian.Label19.Text = label8.Text
        FormCetakPengembalian.Label18.Text = DateTimePicker1.Text
        FormCetakPengembalian.Label17.Text = LblLamaPjm.Text
        FormCetakPengembalian.Label16.Text = TextBox2.Text
        FormCetakPengembalian.Label15.Text = LBL_Denda.Text
        FormCetakPengembalian.Label14.Text = TxtDibayar.Text
        FormCetakPengembalian.Label13.Text = Label12.Text

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call KondisiAwal()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class


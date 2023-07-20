<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCetakPinjam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCetakPinjam))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 341)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sisa Bayar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Pinjam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Pelanggan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Pinjam"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alamat Pelanggan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nama Mobil"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Nomor Polisi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Lama Pinjam"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Jumlah Pinjam"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 292)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Sub Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 319)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Kembalian"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 262)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Bayar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(145, 319)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Label13"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(145, 292)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Label14"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(145, 262)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Label15"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(145, 229)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Label16"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(145, 197)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Label17"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(145, 170)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Label18"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(145, 142)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Label19"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(145, 114)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Label20"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(145, 84)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Label21"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(145, 58)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Label22"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(145, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 13)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "Label23"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(145, 341)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 13)
        Me.Label24.TabIndex = 13
        Me.Label24.Text = "Label24"
        '
        'Button1
        '
        Me.Button1.Image = Global.RentalMobilVB.My.Resources.Resources.icons8_print_16
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(26, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 29)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Cetak"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormCetakPinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(404, 417)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCetakPinjam"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

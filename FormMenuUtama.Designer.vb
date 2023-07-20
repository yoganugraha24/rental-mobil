<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.About1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.STSlabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STSlabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STSlabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STSLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STSLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STSLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STSLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STSLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STSLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STSLabel10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeminjamanFilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianFilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PetugasToolStripMenuItem, Me.AnggotaToolStripMenuItem, Me.MobilToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeminjamanFilmToolStripMenuItem, Me.PengembalianFilmToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.About1ToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'About1ToolStripMenuItem
        '
        Me.About1ToolStripMenuItem.Image = Global.RentalMobilVB.My.Resources.Resources.iconfinder_Info_132643
        Me.About1ToolStripMenuItem.Name = "About1ToolStripMenuItem"
        Me.About1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.About1ToolStripMenuItem.Text = "About"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(441, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.RentalMobilVB.My.Resources.Resources.rental_mobil
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.StatusStrip1)
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(439, 256)
        Me.Panel1.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STSlabel1, Me.STSlabel2, Me.STSlabel3, Me.STSLabel4, Me.STSLabel5, Me.STSLabel6, Me.STSLabel7, Me.STSLabel8, Me.STSLabel9, Me.STSLabel10})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 234)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(439, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'STSlabel1
        '
        Me.STSlabel1.Name = "STSlabel1"
        Me.STSlabel1.Size = New System.Drawing.Size(39, 17)
        Me.STSlabel1.Text = "KODE:"
        '
        'STSlabel2
        '
        Me.STSlabel2.Name = "STSlabel2"
        Me.STSlabel2.Size = New System.Drawing.Size(0, 17)
        '
        'STSlabel3
        '
        Me.STSlabel3.Name = "STSlabel3"
        Me.STSlabel3.Size = New System.Drawing.Size(46, 17)
        Me.STSlabel3.Text = "NAMA:"
        '
        'STSLabel4
        '
        Me.STSLabel4.Name = "STSLabel4"
        Me.STSLabel4.Size = New System.Drawing.Size(0, 17)
        '
        'STSLabel5
        '
        Me.STSLabel5.Name = "STSLabel5"
        Me.STSLabel5.Size = New System.Drawing.Size(41, 17)
        Me.STSLabel5.Text = "LEVEL:"
        '
        'STSLabel6
        '
        Me.STSLabel6.Name = "STSLabel6"
        Me.STSLabel6.Size = New System.Drawing.Size(0, 17)
        '
        'STSLabel7
        '
        Me.STSLabel7.Name = "STSLabel7"
        Me.STSLabel7.Size = New System.Drawing.Size(33, 17)
        Me.STSLabel7.Text = "JAM:"
        '
        'STSLabel8
        '
        Me.STSLabel8.Name = "STSLabel8"
        Me.STSLabel8.Size = New System.Drawing.Size(0, 17)
        '
        'STSLabel9
        '
        Me.STSLabel9.BackColor = System.Drawing.Color.Transparent
        Me.STSLabel9.Name = "STSLabel9"
        Me.STSLabel9.Size = New System.Drawing.Size(63, 17)
        Me.STSLabel9.Text = "TANGGAL:"
        '
        'STSLabel10
        '
        Me.STSLabel10.Name = "STSLabel10"
        Me.STSLabel10.Size = New System.Drawing.Size(0, 17)
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Image = CType(resources.GetObject("LoginToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LoginToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LoginToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(120, 30)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(120, 30)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(120, 30)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PetugasToolStripMenuItem
        '
        Me.PetugasToolStripMenuItem.Image = Global.RentalMobilVB.My.Resources.Resources.iconfinder_Boss_132688
        Me.PetugasToolStripMenuItem.Name = "PetugasToolStripMenuItem"
        Me.PetugasToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PetugasToolStripMenuItem.Text = "Admin"
        '
        'AnggotaToolStripMenuItem
        '
        Me.AnggotaToolStripMenuItem.Image = Global.RentalMobilVB.My.Resources.Resources.iconfinder_Male_132787
        Me.AnggotaToolStripMenuItem.Name = "AnggotaToolStripMenuItem"
        Me.AnggotaToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.AnggotaToolStripMenuItem.Text = "Pelanggan"
        '
        'MobilToolStripMenuItem
        '
        Me.MobilToolStripMenuItem.Image = Global.RentalMobilVB.My.Resources.Resources.icons8_car_16
        Me.MobilToolStripMenuItem.Name = "MobilToolStripMenuItem"
        Me.MobilToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.MobilToolStripMenuItem.Text = "Mobil"
        '
        'PeminjamanFilmToolStripMenuItem
        '
        Me.PeminjamanFilmToolStripMenuItem.Image = Global.RentalMobilVB.My.Resources.Resources.icons8_car_rental_16__1_
        Me.PeminjamanFilmToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PeminjamanFilmToolStripMenuItem.Name = "PeminjamanFilmToolStripMenuItem"
        Me.PeminjamanFilmToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.PeminjamanFilmToolStripMenuItem.Text = "Peminjaman mobil"
        '
        'PengembalianFilmToolStripMenuItem
        '
        Me.PengembalianFilmToolStripMenuItem.Image = Global.RentalMobilVB.My.Resources.Resources.icons8_carpool_16
        Me.PengembalianFilmToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PengembalianFilmToolStripMenuItem.Name = "PengembalianFilmToolStripMenuItem"
        Me.PengembalianFilmToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.PengembalianFilmToolStripMenuItem.Text = "Pengembalian mobil"
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 285)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents STSlabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STSlabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STSlabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STSLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STSLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STSLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STSLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STSLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STSLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STSLabel10 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PetugasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnggotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MobilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PeminjamanFilmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengembalianFilmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents About1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip

End Class

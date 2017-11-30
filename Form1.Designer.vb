<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AVP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AVP))
        Me.Prvi = New System.Windows.Forms.Button()
        Me.Odaberi = New System.Windows.Forms.OpenFileDialog()
        Me.Slika = New System.Windows.Forms.PictureBox()
        Me.Tekst = New System.Windows.Forms.TextBox()
        Me.WMP = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Lista = New System.Windows.Forms.ListBox()
        Me.Drugi = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.IzbrisiSve = New System.Windows.Forms.Button()
        Me.Lista2 = New System.Windows.Forms.ListBox()
        CType(Me.Slika, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Prvi
        '
        Me.Prvi.Location = New System.Drawing.Point(14, 8)
        Me.Prvi.Name = "Prvi"
        Me.Prvi.Size = New System.Drawing.Size(130, 36)
        Me.Prvi.TabIndex = 1
        Me.Prvi.Text = "Pretraži mapu"
        Me.Prvi.UseVisualStyleBackColor = True
        '
        'Odaberi
        '
        Me.Odaberi.Multiselect = True
        '
        'Slika
        '
        Me.Slika.BackColor = System.Drawing.Color.Gray
        Me.Slika.Location = New System.Drawing.Point(-8, 0)
        Me.Slika.Name = "Slika"
        Me.Slika.Size = New System.Drawing.Size(891, 49)
        Me.Slika.TabIndex = 2
        Me.Slika.TabStop = False
        '
        'Tekst
        '
        Me.Tekst.Font = New System.Drawing.Font("Lucida Calligraphy", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Tekst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Tekst.Location = New System.Drawing.Point(290, 1)
        Me.Tekst.Multiline = True
        Me.Tekst.Name = "Tekst"
        Me.Tekst.Size = New System.Drawing.Size(586, 47)
        Me.Tekst.TabIndex = 3
        Me.Tekst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WMP
        '
        Me.WMP.Enabled = True
        Me.WMP.Location = New System.Drawing.Point(-8, 55)
        Me.WMP.Name = "WMP"
        Me.WMP.OcxState = CType(resources.GetObject("WMP.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WMP.Size = New System.Drawing.Size(629, 406)
        Me.WMP.TabIndex = 0
        '
        'Lista
        '
        Me.Lista.FormattingEnabled = True
        Me.Lista.Location = New System.Drawing.Point(622, 55)
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(261, 329)
        Me.Lista.TabIndex = 4
        '
        'Drugi
        '
        Me.Drugi.Location = New System.Drawing.Point(150, 8)
        Me.Drugi.Name = "Drugi"
        Me.Drugi.Size = New System.Drawing.Size(132, 36)
        Me.Drugi.TabIndex = 6
        Me.Drugi.Text = "Pretraži pjesmu"
        Me.Drugi.UseVisualStyleBackColor = True
        '
        'IzbrisiSve
        '
        Me.IzbrisiSve.Location = New System.Drawing.Point(691, 390)
        Me.IzbrisiSve.Name = "IzbrisiSve"
        Me.IzbrisiSve.Size = New System.Drawing.Size(110, 41)
        Me.IzbrisiSve.TabIndex = 10
        Me.IzbrisiSve.Text = "Izbriši sve"
        Me.IzbrisiSve.UseVisualStyleBackColor = True
        '
        'Lista2
        '
        Me.Lista2.FormattingEnabled = True
        Me.Lista2.Location = New System.Drawing.Point(656, 263)
        Me.Lista2.Name = "Lista2"
        Me.Lista2.Size = New System.Drawing.Size(120, 95)
        Me.Lista2.TabIndex = 11
        Me.Lista2.Visible = False
        '
        'AVP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 462)
        Me.Controls.Add(Me.Lista2)
        Me.Controls.Add(Me.IzbrisiSve)
        Me.Controls.Add(Me.Drugi)
        Me.Controls.Add(Me.Lista)
        Me.Controls.Add(Me.Tekst)
        Me.Controls.Add(Me.Prvi)
        Me.Controls.Add(Me.WMP)
        Me.Controls.Add(Me.Slika)
        Me.Name = "AVP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AVPlayer"
        CType(Me.Slika, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WMP As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Prvi As Button
    Friend WithEvents Odaberi As OpenFileDialog
    Friend WithEvents Slika As PictureBox
    Friend WithEvents Tekst As TextBox
    Friend WithEvents Lista As ListBox
    Friend WithEvents Drugi As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents IzbrisiSve As Button
    Friend WithEvents Lista2 As ListBox
End Class

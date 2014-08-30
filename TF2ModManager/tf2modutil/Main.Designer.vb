<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.bnF5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.bnActDea = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bnOpc = New System.Windows.Forms.Button()
        Me.CheckedListBox3 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox4 = New System.Windows.Forms.CheckedListBox()
        Me.BnInst = New System.Windows.Forms.Button()
        Me.bnUtil = New System.Windows.Forms.Button()
        Me.bnExa = New System.Windows.Forms.Button()
        Me.picAbout = New System.Windows.Forms.PictureBox()
        Me.bnBorrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(3, 21)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(194, 265)
        Me.CheckedListBox1.TabIndex = 1
        Me.CheckedListBox1.ThreeDCheckBoxes = True
        '
        'bnF5
        '
        Me.bnF5.Location = New System.Drawing.Point(430, 325)
        Me.bnF5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bnF5.Name = "bnF5"
        Me.bnF5.Size = New System.Drawing.Size(30, 30)
        Me.bnF5.TabIndex = 5
        Me.bnF5.Text = "F5"
        Me.bnF5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckedListBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 289)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mods activados"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckedListBox2)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(224, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 289)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mods Desactivados"
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.CheckOnClick = True
        Me.CheckedListBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Location = New System.Drawing.Point(3, 21)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(194, 265)
        Me.CheckedListBox2.TabIndex = 0
        '
        'bnActDea
        '
        Me.bnActDea.Location = New System.Drawing.Point(430, 87)
        Me.bnActDea.Name = "bnActDea"
        Me.bnActDea.Size = New System.Drawing.Size(100, 60)
        Me.bnActDea.TabIndex = 0
        Me.bnActDea.Text = "Activar / Desactivar seleccionados"
        Me.bnActDea.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(784, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ola k ase"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnOpc
        '
        Me.bnOpc.Location = New System.Drawing.Point(430, 290)
        Me.bnOpc.Name = "bnOpc"
        Me.bnOpc.Size = New System.Drawing.Size(100, 30)
        Me.bnOpc.TabIndex = 7
        Me.bnOpc.Text = "Opciones"
        Me.bnOpc.UseVisualStyleBackColor = True
        '
        'CheckedListBox3
        '
        Me.CheckedListBox3.FormattingEnabled = True
        Me.CheckedListBox3.HorizontalScrollbar = True
        Me.CheckedListBox3.Location = New System.Drawing.Point(555, 120)
        Me.CheckedListBox3.Name = "CheckedListBox3"
        Me.CheckedListBox3.Size = New System.Drawing.Size(100, 164)
        Me.CheckedListBox3.TabIndex = 8
        '
        'CheckedListBox4
        '
        Me.CheckedListBox4.FormattingEnabled = True
        Me.CheckedListBox4.HorizontalScrollbar = True
        Me.CheckedListBox4.Location = New System.Drawing.Point(661, 120)
        Me.CheckedListBox4.Name = "CheckedListBox4"
        Me.CheckedListBox4.Size = New System.Drawing.Size(100, 164)
        Me.CheckedListBox4.TabIndex = 9
        '
        'BnInst
        '
        Me.BnInst.Location = New System.Drawing.Point(430, 219)
        Me.BnInst.Name = "BnInst"
        Me.BnInst.Size = New System.Drawing.Size(100, 30)
        Me.BnInst.TabIndex = 10
        Me.BnInst.Text = "Instalar..."
        Me.BnInst.UseVisualStyleBackColor = True
        '
        'bnUtil
        '
        Me.bnUtil.Location = New System.Drawing.Point(430, 255)
        Me.bnUtil.Name = "bnUtil"
        Me.bnUtil.Size = New System.Drawing.Size(100, 29)
        Me.bnUtil.TabIndex = 12
        Me.bnUtil.Text = "Utilidades"
        Me.bnUtil.UseVisualStyleBackColor = True
        '
        'bnExa
        '
        Me.bnExa.Image = Global.tf2modutil.My.Resources.Resources.Carpetita
        Me.bnExa.Location = New System.Drawing.Point(466, 326)
        Me.bnExa.Name = "bnExa"
        Me.bnExa.Size = New System.Drawing.Size(64, 29)
        Me.bnExa.TabIndex = 13
        Me.bnExa.UseVisualStyleBackColor = True
        '
        'picAbout
        '
        Me.picAbout.Dock = System.Windows.Forms.DockStyle.Top
        Me.picAbout.Image = Global.tf2modutil.My.Resources.Resources.tf2modmanagerlogo
        Me.picAbout.Location = New System.Drawing.Point(0, 0)
        Me.picAbout.Name = "picAbout"
        Me.picAbout.Size = New System.Drawing.Size(784, 60)
        Me.picAbout.TabIndex = 11
        Me.picAbout.TabStop = False
        '
        'bnBorrar
        '
        Me.bnBorrar.Location = New System.Drawing.Point(430, 153)
        Me.bnBorrar.Name = "bnBorrar"
        Me.bnBorrar.Size = New System.Drawing.Size(100, 60)
        Me.bnBorrar.TabIndex = 14
        Me.bnBorrar.Text = "Borrar seleccionados"
        Me.bnBorrar.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 383)
        Me.Controls.Add(Me.bnExa)
        Me.Controls.Add(Me.bnBorrar)
        Me.Controls.Add(Me.bnUtil)
        Me.Controls.Add(Me.picAbout)
        Me.Controls.Add(Me.BnInst)
        Me.Controls.Add(Me.bnF5)
        Me.Controls.Add(Me.CheckedListBox4)
        Me.Controls.Add(Me.bnOpc)
        Me.Controls.Add(Me.CheckedListBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bnActDea)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Team Fortress 2 Mod Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.picAbout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents bnF5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckedListBox2 As System.Windows.Forms.CheckedListBox
    Friend WithEvents bnActDea As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bnOpc As System.Windows.Forms.Button
    Friend WithEvents CheckedListBox3 As System.Windows.Forms.CheckedListBox
    Friend WithEvents CheckedListBox4 As System.Windows.Forms.CheckedListBox
    Friend WithEvents BnInst As System.Windows.Forms.Button
    Friend WithEvents picAbout As System.Windows.Forms.PictureBox
    Friend WithEvents bnUtil As System.Windows.Forms.Button
    Friend WithEvents bnExa As System.Windows.Forms.Button
    Friend WithEvents bnBorrar As System.Windows.Forms.Button

End Class

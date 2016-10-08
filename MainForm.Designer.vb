'
' Created by SharpDevelop.
' User: IP-Man
' Date: 3/7/2016
' Time: 5:40 PM
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.earnControlBox1 = New CPUMiner_GUI.EarnControlBox()
		Me.earnGroupBox1 = New CPUMiner_GUI.EarnGroupBox()
		Me.output = New System.Windows.Forms.ListBox()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.GO = New CPUMiner_GUI.EarnButton()
		Me.pass = New CPUMiner_GUI.EarnTextBox()
		Me.worker = New CPUMiner_GUI.EarnTextBox()
		Me.url = New CPUMiner_GUI.EarnTextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.earnTheme1 = New CPUMiner_GUI.EarnTheme()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.about = New CPUMiner_GUI.EarnButton()
		Me.acceptedshares = New System.Windows.Forms.Label()
		Me.minericon = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.earnGroupBox1.SuspendLayout
		Me.groupBox1.SuspendLayout
		Me.earnTheme1.SuspendLayout
		Me.groupBox2.SuspendLayout
		Me.SuspendLayout
		'
		'earnControlBox1
		'
		Me.earnControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.earnControlBox1.Customization = "8PDw//Dw8P9ZTUv/8PDw/w=="
		Me.earnControlBox1.Font = New System.Drawing.Font("Verdana", 8!)
		Me.earnControlBox1.Image = Nothing
		Me.earnControlBox1.Location = New System.Drawing.Point(466, 0)
		Me.earnControlBox1.Name = "earnControlBox1"
		Me.earnControlBox1.NoRounding = false
		Me.earnControlBox1.Size = New System.Drawing.Size(44, 18)
		Me.earnControlBox1.TabIndex = 0
		Me.earnControlBox1.Text = "earnControlBox1"
		Me.earnControlBox1.Transparent = false
		'
		'earnGroupBox1
		'
		Me.earnGroupBox1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.earnGroupBox1.Controls.Add(Me.output)
		Me.earnGroupBox1.Customization = "WU1L/1lNS/9ZTUv//////w=="
		Me.earnGroupBox1.Font = New System.Drawing.Font("Verdana", 8!)
		Me.earnGroupBox1.Image = Nothing
		Me.earnGroupBox1.Location = New System.Drawing.Point(16, 208)
		Me.earnGroupBox1.Movable = true
		Me.earnGroupBox1.Name = "earnGroupBox1"
		Me.earnGroupBox1.NoRounding = false
		Me.earnGroupBox1.Sizable = true
		Me.earnGroupBox1.Size = New System.Drawing.Size(479, 146)
		Me.earnGroupBox1.SmartBounds = true
		Me.earnGroupBox1.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.earnGroupBox1.TabIndex = 1
		Me.earnGroupBox1.Text = "minerd.exe | Output"
		Me.earnGroupBox1.TransparencyKey = System.Drawing.Color.Fuchsia
		Me.earnGroupBox1.Transparent = false
		'
		'output
		'
		Me.output.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.output.FormattingEnabled = true
		Me.output.Location = New System.Drawing.Point(0, 25)
		Me.output.Name = "output"
		Me.output.Size = New System.Drawing.Size(479, 121)
		Me.output.TabIndex = 0
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.GO)
		Me.groupBox1.Controls.Add(Me.pass)
		Me.groupBox1.Controls.Add(Me.worker)
		Me.groupBox1.Controls.Add(Me.url)
		Me.groupBox1.Controls.Add(Me.label3)
		Me.groupBox1.Controls.Add(Me.label2)
		Me.groupBox1.Controls.Add(Me.label1)
		Me.groupBox1.Location = New System.Drawing.Point(16, 48)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(479, 148)
		Me.groupBox1.TabIndex = 3
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Settings"
		'
		'GO
		'
		Me.GO.Customization = "R819/za1VP//////"
		Me.GO.Font = New System.Drawing.Font("Verdana", 8!)
		Me.GO.Image = Nothing
		Me.GO.Location = New System.Drawing.Point(363, 31)
		Me.GO.Name = "GO"
		Me.GO.NoRounding = false
		Me.GO.Size = New System.Drawing.Size(107, 96)
		Me.GO.TabIndex = 8
		Me.GO.Text = "Start Mining"
		Me.GO.Transparent = false
		AddHandler Me.GO.Click, AddressOf Me.GOClick
		'
		'pass
		'
		Me.pass.Customization = "WU1L//Dw8P9ZTUv/"
		Me.pass.Font = New System.Drawing.Font("Verdana", 8!)
		Me.pass.Image = Nothing
		Me.pass.Location = New System.Drawing.Point(108, 103)
		Me.pass.MaxLength = 32767
		Me.pass.Multiline = false
		Me.pass.Name = "pass"
		Me.pass.NoRounding = false
		Me.pass.ReadOnly = false
		Me.pass.Size = New System.Drawing.Size(249, 24)
		Me.pass.TabIndex = 7
		Me.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.pass.Transparent = false
		Me.pass.UseSystemPasswordChar = false
		'
		'worker
		'
		Me.worker.Customization = "WU1L//Dw8P9ZTUv/"
		Me.worker.Font = New System.Drawing.Font("Verdana", 8!)
		Me.worker.Image = Nothing
		Me.worker.Location = New System.Drawing.Point(108, 67)
		Me.worker.MaxLength = 32767
		Me.worker.Multiline = false
		Me.worker.Name = "worker"
		Me.worker.NoRounding = false
		Me.worker.ReadOnly = false
		Me.worker.Size = New System.Drawing.Size(249, 24)
		Me.worker.TabIndex = 6
		Me.worker.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.worker.Transparent = false
		Me.worker.UseSystemPasswordChar = false
		'
		'url
		'
		Me.url.Customization = "WU1L//Dw8P9ZTUv/"
		Me.url.Font = New System.Drawing.Font("Verdana", 8!)
		Me.url.Image = Nothing
		Me.url.Location = New System.Drawing.Point(108, 31)
		Me.url.MaxLength = 32767
		Me.url.Multiline = false
		Me.url.Name = "url"
		Me.url.NoRounding = false
		Me.url.ReadOnly = false
		Me.url.Size = New System.Drawing.Size(249, 24)
		Me.url.TabIndex = 5
		Me.url.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.url.Transparent = false
		Me.url.UseSystemPasswordChar = false
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(14, 108)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 4
		Me.label3.Text = "Password : "
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(14, 71)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 3
		Me.label2.Text = "Worker Name : "
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(14, 38)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 2
		Me.label1.Text = "URL : "
		'
		'earnTheme1
		'
		Me.earnTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer), CType(CType(240,Byte),Integer))
		Me.earnTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.earnTheme1.Controls.Add(Me.groupBox2)
		Me.earnTheme1.Controls.Add(Me.groupBox1)
		Me.earnTheme1.Controls.Add(Me.earnGroupBox1)
		Me.earnTheme1.Controls.Add(Me.earnControlBox1)
		Me.earnTheme1.Customization = "WU1L//////8="
		Me.earnTheme1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.earnTheme1.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
		Me.earnTheme1.Image = Nothing
		Me.earnTheme1.Location = New System.Drawing.Point(0, 0)
		Me.earnTheme1.Movable = true
		Me.earnTheme1.Name = "earnTheme1"
		Me.earnTheme1.NoRounding = false
		Me.earnTheme1.Sizable = true
		Me.earnTheme1.Size = New System.Drawing.Size(513, 424)
		Me.earnTheme1.SmartBounds = true
		Me.earnTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.earnTheme1.TabIndex = 0
		Me.earnTheme1.Text = "CPUMiner GUI For Litecoin"
		Me.earnTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
		Me.earnTheme1.Transparent = false
		AddHandler Me.earnTheme1.Click, AddressOf Me.EarnTheme1Click
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.about)
		Me.groupBox2.Controls.Add(Me.acceptedshares)
		Me.groupBox2.Location = New System.Drawing.Point(16, 360)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(479, 44)
		Me.groupBox2.TabIndex = 4
		Me.groupBox2.TabStop = false
		'
		'about
		'
		Me.about.Customization = "R819/za1VP//////"
		Me.about.Font = New System.Drawing.Font("Verdana", 8!)
		Me.about.Image = Nothing
		Me.about.Location = New System.Drawing.Point(450, 16)
		Me.about.Name = "about"
		Me.about.NoRounding = false
		Me.about.Size = New System.Drawing.Size(20, 20)
		Me.about.TabIndex = 9
		Me.about.Text = "?"
		Me.about.Transparent = false
		AddHandler Me.about.Click, AddressOf Me.AboutClick
		'
		'acceptedshares
		'
		Me.acceptedshares.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.acceptedshares.Location = New System.Drawing.Point(14, 15)
		Me.acceptedshares.Name = "acceptedshares"
		Me.acceptedshares.Size = New System.Drawing.Size(343, 22)
		Me.acceptedshares.TabIndex = 9
		Me.acceptedshares.Text = "Shares :  None"
		'
		'minericon
		'
		Me.minericon.Icon = CType(resources.GetObject("minericon.Icon"),System.Drawing.Icon)
		Me.minericon.Text = "CPUMiner GUI"
		Me.minericon.Visible = true
		AddHandler Me.minericon.MouseClick, AddressOf Me.MinericonMouseClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(513, 424)
		Me.Controls.Add(Me.earnTheme1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "CPUMiner GUI For Litecoin"
		Me.TransparencyKey = System.Drawing.Color.Fuchsia
		AddHandler FormClosed, AddressOf Me.MainFormFormClosed
		AddHandler Load, AddressOf Me.MainFormLoad
		AddHandler Resize, AddressOf Me.MainFormResize
		Me.earnGroupBox1.ResumeLayout(false)
		Me.groupBox1.ResumeLayout(false)
		Me.earnTheme1.ResumeLayout(false)
		Me.groupBox2.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private minericon As System.Windows.Forms.NotifyIcon
	Private about As CPUMiner_GUI.EarnButton
	Private acceptedshares As System.Windows.Forms.Label
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private GO As CPUMiner_GUI.EarnButton
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private url As CPUMiner_GUI.EarnTextBox
	Private worker As CPUMiner_GUI.EarnTextBox
	Private pass As CPUMiner_GUI.EarnTextBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private earnControlBox1 As CPUMiner_GUI.EarnControlBox
	Private output As System.Windows.Forms.ListBox
	Private earnGroupBox1 As CPUMiner_GUI.EarnGroupBox
	Private earnTheme1 As CPUMiner_GUI.EarnTheme
	

	
	Sub MinericonMouseClick(sender As Object, e As MouseEventArgs)
		Me.Show
		Me.WindowState = FormWindowState.Normal 
	End Sub
	
	Sub EarnTheme1Click(sender As Object, e As EventArgs)
		
	End Sub
End Class

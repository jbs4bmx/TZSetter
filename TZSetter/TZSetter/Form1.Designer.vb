<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbSelector = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.applyBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbSelector)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.GroupBox1.Location = New System.Drawing.Point(12, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 57)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Time Zones"
        '
        'cbSelector
        '
        Me.cbSelector.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSelector.FormattingEnabled = True
        Me.cbSelector.Items.AddRange(New Object() {"(UTC-12:00) International Date Line West - Dateline Standard Time", "(UTC-11:00) Coordinated Universal Time-11 - UTC-11", "(UTC-10:00) Aleutian Islands - Aleutian Standard Time", "(UTC-10:00) Hawaii - Hawaiian Standard Time", "(UTC-09:30) Marquesas Islands - Marquesas Standard Time", "(UTC-09:00) Alaska - Alaskan Standard Time", "(UTC-09:00) Coordinated Universal Time-09 - UTC-09", "(UTC-08:00) Baja California - Pacific Standard Time (Mexico)", "(UTC-08:00) Coordinated Universal Time-08 - UTC-08", "(UTC-08:00) Pacific Time (US & Canada) - Pacific Standard Time", "(UTC-07:00) Arizona - US Mountain Standard Time", "(UTC-07:00) La Paz, Mazatlan - Mountain Standard Time (Mexico)", "(UTC-07:00) Mountain Time (US & Canada) - Mountain Standard Time", "(UTC-07:00) Yukon - Yukon Standard Time", "(UTC-06:00) Central America - Central America Standard Time", "(UTC-06:00) Central Time (US & Canada) - Central Standard Time", "(UTC-06:00) Easter Island - Easter Island Standard Time", "(UTC-06:00) Guadalajara, Mexico City, Monterrey - Central Standard Time (Mexico)", "(UTC-06:00) Saskatchewan - Canada Central Standard Time", "(UTC-05:00) Bogota, Lima, Quito, Rio Branco - SA Pacific Standard Time", "(UTC-05:00) Chetumal - Eastern Standard Time (Mexico)", "(UTC-05:00) Eastern Time (US & Canada) - Eastern Standard Time", "(UTC-05:00) Haiti - Haiti Standard Time", "(UTC-05:00) Havana - Cuba Standard Time", "(UTC-05:00) Indiana (East) - US Eastern Standard Time", "(UTC-05:00) Turks and Caicos - Turks And Caicos Standard Time", "(UTC-04:00) Asuncion - Paraguay Standard Time", "(UTC-04:00) Atlantic Time (Canada) - Atlantic Standard Time", "(UTC-04:00) Caracas - Venezuela Standard Time", "(UTC-04:00) Cuiaba - Central Brazilian Standard Time", "(UTC-04:00) Georgetown, La Paz, Manaus, San Juan - SA Western Standard Time", "(UTC-04:00) Santiago - Pacific SA Standard Time", "(UTC-03:30) Newfoundland - Newfoundland Standard Time", "(UTC-03:00) Araguaina - Tocantins Standard Time", "(UTC-03:00) Brasilia - E. South America Standard Time", "(UTC-03:00) Cayenne, Fortaleza - SA Eastern Standard Time", "(UTC-03:00) City of Buenos Aires - Argentina Standard Time", "(UTC-03:00) Montevideo - Montevideo Standard Time", "(UTC-03:00) Punta Arenas - Magallanes Standard Time", "(UTC-03:00) Saint Pierre and Miquelon - Saint Pierre Standard Time", "(UTC-03:00) Salvador - Bahia Standard Time", "(UTC-02:00) Coordinated Universal Time-02 - UTC-02", "(UTC-02:00) Greenland - Greenland Standard Time", "(UTC-01:00) Azores - Azores Standard Time", "(UTC-01:00) Cabo Verde Is. - Cape Verde Standard Time", "(UTC) Coordinated Universal Time - UTC", "(UTC+00:00) Dublin, Edinburgh, Lisbon, London - GMT Standard Time", "(UTC+00:00) Monrovia, Reykjavik - Greenwich Standard Time", "(UTC+00:00) Sao Tome - Sao Tome Standard Time", "(UTC+01:00) Casablanca - Morocco Standard Time", "(UTC+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna - W. Europe Standard" &
                " Time", "(UTC+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague - Central Europe St" &
                "andard Time", "(UTC+01:00) Brussels, Copenhagen, Madrid, Paris - Romance Standard Time", "(UTC+01:00) Sarajevo, Skopje, Warsaw, Zagreb - Central European Standard Time", "(UTC+01:00) West Central Africa - W. Central Africa Standard Time", "(UTC+02:00) Athens, Bucharest - GTB Standard Time", "(UTC+02:00) Beirut - Middle East Standard Time", "(UTC+02:00) Cairo - Egypt Standard Time", "(UTC+02:00) Chisinau - E. Europe Standard Time", "(UTC+02:00) Gaza, Hebron - West Bank Standard Time", "(UTC+02:00) Harare, Pretoria - South Africa Standard Time", "(UTC+02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius - FLE Standard Time", "(UTC+02:00) Jerusalem - Israel Standard Time", "(UTC+02:00) Juba - South Sudan Standard Time", "(UTC+02:00) Kaliningrad - Kaliningrad Standard Time", "(UTC+02:00) Khartoum - Sudan Standard Time", "(UTC+02:00) Tripoli - Libya Standard Time", "(UTC+02:00) Windhoek - Namibia Standard Time", "(UTC+03:00) Amman - Jordan Standard Time", "(UTC+03:00) Baghdad - Arabic Standard Time", "(UTC+03:00) Damascus - Syria Standard Time", "(UTC+03:00) Istanbul - Turkey Standard Time", "(UTC+03:00) Kuwait, Riyadh - Arab Standard Time", "(UTC+03:00) Minsk - Belarus Standard Time", "(UTC+03:00) Moscow, St. Petersburg - Russian Standard Time", "(UTC+03:00) Nairobi - E. Africa Standard Time", "(UTC+03:00) Volgograd - Volgograd Standard Time", "(UTC+03:30) Tehran - Iran Standard Time", "(UTC+04:00) Abu Dhabi, Muscat - Arabian Standard Time", "(UTC+04:00) Astrakhan, Ulyanovsk - Astrakhan Standard Time", "(UTC+04:00) Baku - Azerbaijan Standard Time", "(UTC+04:00) Izhevsk, Samara - Russia Time Zone 3", "(UTC+04:00) Port Louis - Mauritius Standard Time", "(UTC+04:00) Saratov - Saratov Standard Time", "(UTC+04:00) Tbilisi - Georgian Standard Time", "(UTC+04:00) Yerevan - Caucasus Standard Time", "(UTC+04:30) Kabul - Afghanistan Standard Time", "(UTC+05:00) Ashgabat, Tashkent - West Asia Standard Time", "(UTC+05:00) Astana - Qyzylorda Standard Time", "(UTC+05:00) Ekaterinburg - Ekaterinburg Standard Time", "(UTC+05:00) Islamabad, Karachi - Pakistan Standard Time", "(UTC+05:30) Chennai, Kolkata, Mumbai, New Delhi - India Standard Time", "(UTC+05:30) Sri Jayawardenepura - Sri Lanka Standard Time", "(UTC+05:45) Kathmandu - Nepal Standard Time", "(UTC+06:00) Bishkek - Central Asia Standard Time", "(UTC+06:00) Dhaka - Bangladesh Standard Time", "(UTC+06:00) Omsk - Omsk Standard Time", "(UTC+06:30) Yangon (Rangoon) - Myanmar Standard Time", "(UTC+07:00) Bangkok, Hanoi, Jakarta - SE Asia Standard Time", "(UTC+07:00) Barnaul, Gorno-Altaysk - Altai Standard Time", "(UTC+07:00) Hovd - W. Mongolia Standard Time", "(UTC+07:00) Krasnoyarsk - North Asia Standard Time", "(UTC+07:00) Novosibirsk - N. Central Asia Standard Time", "(UTC+07:00) Tomsk - Tomsk Standard Time", "(UTC+08:00) Beijing, Chongqing, Hong Kong, Urumqi - China Standard Time", "(UTC+08:00) Irkutsk - North Asia East Standard Time", "(UTC+08:00) Kuala Lumpur, Singapore - Singapore Standard Time", "(UTC+08:00) Perth - W. Australia Standard Time", "(UTC+08:00) Taipei - Taipei Standard Time", "(UTC+08:00) Ulaanbaatar - Ulaanbaatar Standard Time", "(UTC+08:45) Eucla - Aus Central W. Standard Time", "(UTC+09:00) Chita - Transbaikal Standard Time", "(UTC+09:00) Osaka, Sapporo, Tokyo - Tokyo Standard Time", "(UTC+09:00) Pyongyang - North Korea Standard Time", "(UTC+09:00) Seoul - Korea Standard Time", "(UTC+09:00) Yakutsk - Yakutsk Standard Time", "(UTC+09:30) Adelaide - Cen. Australia Standard Time", "(UTC+09:30) Darwin - AUS Central Standard Time", "(UTC+10:00) Brisbane - E. Australia Standard Time", "(UTC+10:00) Canberra, Melbourne, Sydney - AUS Eastern Standard Time", "(UTC+10:00) Guam, Port Moresby - West Pacific Standard Time", "(UTC+10:00) Hobart - Tasmania Standard Time", "(UTC+10:00) Vladivostok - Vladivostok Standard Time", "(UTC+10:30) Lord Howe Island - Lord Howe Standard Time", "(UTC+11:00) Bougainville Island - Bougainville Standard Time", "(UTC+11:00) Chokurdakh - Russia Time Zone 10", "(UTC+11:00) Magadan - Magadan Standard Time", "(UTC+11:00) Norfolk Island - Norfolk Standard Time", "(UTC+11:00) Sakhalin - Sakhalin Standard Time", "(UTC+11:00) Solomon Is., New Caledonia - Central Pacific Standard Time", "(UTC+12:00) Anadyr, Petropavlovsk-Kamchatsky - Russia Time Zone 11", "(UTC+12:00) Auckland, Wellington - New Zealand Standard Time", "(UTC+12:00) Coordinated Universal Time+12 - UTC+12", "(UTC+12:00) Fiji - Fiji Standard Time", "(UTC+12:45) Chatham Islands - Chatham Islands Standard Time", "(UTC+13:00) Coordinated Universal Time+13 - UTC+13", "(UTC+13:00) Nuku'alofa - Tonga Standard Time", "(UTC+13:00) Samoa - Samoa Standard Time", "(UTC+14:00) Kiritimati Island - Line Islands Standard Time"})
        Me.cbSelector.Location = New System.Drawing.Point(3, 22)
        Me.cbSelector.Name = "cbSelector"
        Me.cbSelector.Size = New System.Drawing.Size(594, 24)
        Me.cbSelector.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.closeBtn)
        Me.GroupBox2.Controls.Add(Me.applyBtn)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.GroupBox2.Location = New System.Drawing.Point(12, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(600, 85)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controls"
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.closeBtn.FlatAppearance.BorderSize = 0
        Me.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.closeBtn.Location = New System.Drawing.Point(320, 26)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(240, 40)
        Me.closeBtn.TabIndex = 1
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = False
        '
        'applyBtn
        '
        Me.applyBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.applyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.applyBtn.FlatAppearance.BorderSize = 0
        Me.applyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.applyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.applyBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.applyBtn.Location = New System.Drawing.Point(40, 26)
        Me.applyBtn.Name = "applyBtn"
        Me.applyBtn.Size = New System.Drawing.Size(240, 40)
        Me.applyBtn.TabIndex = 0
        Me.applyBtn.Text = "Apply"
        Me.applyBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(30, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.Label1.Size = New System.Drawing.Size(475, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Time Zone setting utilty for Windows 7/8/10/11"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(511, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(623, 274)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TZSetter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbSelector As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents closeBtn As Button
    Friend WithEvents applyBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

Public Class Form1

    ' Publisher: ラプトル Software
    ' Author: Jason B. Darling

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSelector.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles applyBtn.Click
        Select Case cbSelector.SelectedItem.ToString()
            Case "(UTC-12:00) International Date Line West - Dateline Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Dateline Standard Time""")
            Case "(UTC-11:00) Coordinated Universal Time-11 - UTC-11"
                Process.Start("cmd.exe", "/c tzutil /s ""UTC-11""")
            Case "(UTC-10:00) Aleutian Islands - Aleutian Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Aleutian Standard Time""")
            Case "(UTC-10:00) Hawaii - Hawaiian Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Hawaiian Standard Time""")
            Case "(UTC-09:30) Marquesas Islands - Marquesas Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Marquesas Standard Time""")
            Case "(UTC-09:00) Alaska - Alaskan Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Alaskan Standard Time""")
            Case "(UTC-09:00) Coordinated Universal Time-09 - UTC-09"
                Process.Start("cmd.exe", "/c tzutil /s ""UTC-09""")
            Case "(UTC-08:00) Baja California - Pacific Standard Time (Mexico)"
                Process.Start("cmd.exe", "/c tzutil /s ""Pacific Standard Time (Mexico)""")
            Case "(UTC-08:00) Coordinated Universal Time-08 - UTC-08"
                Process.Start("cmd.exe", "/c tzutil /s ""UTC-08""")
            Case "(UTC-08:00) Pacific Time (US & Canada) - Pacific Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Pacific Standard Time""")
            Case "(UTC-07:00) Arizona - US Mountain Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""US Mountain Standard Time""")
            Case "(UTC-07:00) La Paz, Mazatlan - Mountain Standard Time (Mexico)"
                Process.Start("cmd.exe", "/c tzutil /s ""Mountain Standard Time (Mexico)""")
            Case "(UTC-07:00) Mountain Time (US & Canada) - Mountain Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Mountain Standard Time""")
            Case "(UTC-07:00) Yukon - Yukon Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Yukon Standard Time""")
            Case "(UTC-06:00) Central America - Central America Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Central America Standard Time""")
            Case "(UTC-06:00) Central Time (US & Canada) - Central Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Central Standard Time""")
            Case "(UTC-06:00) Easter Island - Easter Island Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Easter Island Standard Time""")
            Case "(UTC-06:00) Guadalajara, Mexico City, Monterrey - Central Standard Time (Mexico)"
                Process.Start("cmd.exe", "/c tzutil /s ""Central Standard Time (Mexico)""")
            Case "(UTC-06:00) Saskatchewan - Canada Central Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Canada Central Standard Time""")
            Case "(UTC-05:00) Bogota, Lima, Quito, Rio Branco - SA Pacific Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""SA Pacific Standard Time""")
            Case "(UTC-05:00) Chetumal - Eastern Standard Time (Mexico)"
                Process.Start("cmd.exe", "/c tzutil /s ""Eastern Standard Time (Mexico)""")
            Case "(UTC-05:00) Eastern Time (US & Canada) - Eastern Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Eastern Standard Time""")
            Case "(UTC-05:00) Haiti - Haiti Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Haiti Standard Time""")
            Case "(UTC-05:00) Havana - Cuba Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Cuba Standard Time""")
            Case "(UTC-05:00) Indiana (East) - US Eastern Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""US Eastern Standard Time""")
            Case "(UTC-05:00) Turks and Caicos - Turks And Caicos Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Turks And Caicos Standard Time""")
            Case "(UTC-04:00) Asuncion - Paraguay Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Paraguay Standard Time""")
            Case "(UTC-04:00) Atlantic Time (Canada) - Atlantic Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Atlantic Standard Time""")
            Case "(UTC-04:00) Caracas - Venezuela Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Venezuela Standard Time""")
            Case "(UTC-04:00) Cuiaba - Central Brazilian Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Central Brazilian Standard Time""")
            Case "(UTC-04:00) Georgetown, La Paz, Manaus, San Juan - SA Western Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""SA Western Standard Time""")
            Case "(UTC-04:00) Santiago - Pacific SA Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Pacific SA Standard Time""")
            Case "(UTC-03:30) Newfoundland - Newfoundland Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Newfoundland Standard Time""")
            Case "(UTC-03:00) Araguaina - Tocantins Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Tocantins Standard Time""")
            Case "(UTC-03:00) Brasilia - E. South America Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""E. South America Standard Time""")
            Case "(UTC-03:00) Cayenne, Fortaleza - SA Eastern Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""SA Eastern Standard Time""")
            Case "(UTC-03:00) City of Buenos Aires - Argentina Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Argentina Standard Time""")
            Case "(UTC-03:00) Montevideo - Montevideo Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Montevideo Standard Time""")
            Case "(UTC-03:00) Punta Arenas - Magallanes Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Magallanes Standard Time""")
            Case "(UTC-03:00) Saint Pierre and Miquelon - Saint Pierre Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Saint Pierre Standard Time""")
            Case "(UTC-03:00) Salvador - Bahia Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Bahia Standard Time""")
            Case "(UTC-02:00) Coordinated Universal Time-02 - UTC-02"
                Process.Start("cmd.exe", "/c tzutil /s ""UTC-02""")
            Case "(UTC-02:00) Greenland - Greenland Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Greenland Standard Time""")
            Case "(UTC-01:00) Azores - Azores Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Azores Standard Time""")
            Case "(UTC-01:00) Cabo Verde Is. - Cape Verde Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Cape Verde Standard Time""")
            Case "(UTC) Coordinated Universal Time - UTC"
                Process.Start("cmd.exe", "/c tzutil /s ""UTC""")
            Case "(UTC+00:00) Dublin, Edinburgh, Lisbon, London - GMT Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""GMT Standard Time""")
            Case "(UTC+00:00) Monrovia, Reykjavik - Greenwich Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Greenwich Standard Time""")
            Case "(UTC+00:00) Sao Tome - Sao Tome Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Sao Tome Standard Time""")
            Case "(UTC+01:00) Casablanca - Morocco Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Morocco Standard Time""")
            Case "(UTC+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna - W. Europe Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""W. Europe Standard Time""")
            Case "(UTC+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague - Central Europe Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Central Europe Standard Time""")
            Case "(UTC+01:00) Brussels, Copenhagen, Madrid, Paris - Romance Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Romance Standard Time""")
            Case "(UTC+01:00) Sarajevo, Skopje, Warsaw, Zagreb - Central European Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Central European Standard Time""")
            Case "(UTC+01:00) West Central Africa - W. Central Africa Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""W. Central Africa Standard Time""")
            Case "(UTC+02:00) Athens, Bucharest - GTB Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""GTB Standard Time""")
            Case "(UTC+02:00) Beirut - Middle East Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Middle East Standard Time""")
            Case "(UTC+02:00) Cairo - Egypt Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Egypt Standard Time""")
            Case "(UTC+02:00) Chisinau - E. Europe Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""E. Europe Standard Time""")
            Case "(UTC+02:00) Gaza, Hebron - West Bank Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""West Bank Standard Time""")
            Case "(UTC+02:00) Harare, Pretoria - South Africa Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""South Africa Standard Time""")
            Case "(UTC+02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius - FLE Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""FLE Standard Time""")
            Case "(UTC+02:00) Jerusalem - Israel Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Israel Standard Time""")
            Case "(UTC+02:00) Juba - South Sudan Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""South Sudan Standard Time""")
            Case "(UTC+02:00) Kaliningrad - Kaliningrad Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Kaliningrad Standard Time""")
            Case "(UTC+02:00) Khartoum - Sudan Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Sudan Standard Time""")
            Case "(UTC+02:00) Tripoli - Libya Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Libya Standard Time""")
            Case "(UTC+02:00) Windhoek - Namibia Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Namibia Standard Time""")
            Case "(UTC+03:00) Amman - Jordan Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Jordan Standard Time""")
            Case "(UTC+03:00) Baghdad - Arabic Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Arabic Standard Time""")
            Case "(UTC+03:00) Damascus - Syria Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Syria Standard Time""")
            Case "(UTC+03:00) Istanbul - Turkey Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Turkey Standard Time""")
            Case "(UTC+03:00) Kuwait, Riyadh - Arab Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Arab Standard Time""")
            Case "(UTC+03:00) Minsk - Belarus Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Belarus Standard Time""")
            Case "(UTC+03:00) Moscow, St. Petersburg - Russian Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Russian Standard Time""")
            Case "(UTC+03:00) Nairobi - E. Africa Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""E. Africa Standard Time""")
            Case "(UTC+03:00) Volgograd - Volgograd Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Volgograd Standard Time""")
            Case "(UTC+03:30) Tehran - Iran Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Iran Standard Time""")
            Case "(UTC+04:00) Abu Dhabi, Muscat - Arabian Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Arabian Standard Time""")
            Case "(UTC+04:00) Astrakhan, Ulyanovsk - Astrakhan Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Astrakhan Standard Time""")
            Case "(UTC+04:00) Baku - Azerbaijan Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Azerbaijan Standard Time""")
            Case "(UTC+04:00) Izhevsk, Samara - Russia Time Zone 3"
                Process.Start("cmd.exe", "/c tzutil /s ""Russia Time Zone 3""")
            Case "(UTC+04:00) Port Louis - Mauritius Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Mauritius Standard Time""")
            Case "(UTC+04:00) Saratov - Saratov Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Saratov Standard Time""")
            Case "(UTC+04:00) Tbilisi - Georgian Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Georgian Standard Time""")
            Case "(UTC+04:00) Yerevan - Caucasus Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Caucasus Standard Time""")
            Case "(UTC+04:30) Kabul - Afghanistan Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Afghanistan Standard Time""")
            Case "(UTC+05:00) Ashgabat, Tashkent - West Asia Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""West Asia Standard Time""")
            Case "(UTC+05:00) Astana - Qyzylorda Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Qyzylorda Standard Time""")
            Case "(UTC+05:00) Ekaterinburg - Ekaterinburg Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Ekaterinburg Standard Time""")
            Case "(UTC+05:00) Islamabad, Karachi - Pakistan Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Pakistan Standard Time""")
            Case "(UTC+05:30) Chennai, Kolkata, Mumbai, New Delhi - India Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""India Standard Time""")
            Case "(UTC+05:30) Sri Jayawardenepura - Sri Lanka Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Sri Lanka Standard Time""")
            Case "(UTC+05:45) Kathmandu - Nepal Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Nepal Standard Time""")
            Case "(UTC+06:00) Bishkek - Central Asia Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Central Asia Standard Time""")
            Case "(UTC+06:00) Dhaka - Bangladesh Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Bangladesh Standard Time""")
            Case "(UTC+06:00) Omsk - Omsk Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Omsk Standard Time""")
            Case "(UTC+06:30) Yangon (Rangoon) - Myanmar Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Myanmar Standard Time""")
            Case "(UTC+07:00) Bangkok, Hanoi, Jakarta - SE Asia Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""SE Asia Standard Time""")
            Case "(UTC+07:00) Barnaul, Gorno-Altaysk - Altai Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Altai Standard Time""")
            Case "(UTC+07:00) Hovd - W. Mongolia Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""W. Mongolia Standard Time""")
            Case "(UTC+07:00) Krasnoyarsk - North Asia Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""North Asia Standard Time""")
            Case "(UTC+07:00) Novosibirsk - N. Central Asia Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""N. Central Asia Standard Time""")
            Case "(UTC+07:00) Tomsk - Tomsk Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Tomsk Standard Time""")
            Case "(UTC+08:00) Beijing, Chongqing, Hong Kong, Urumqi - China Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""China Standard Time""")
            Case "(UTC+08:00) Irkutsk - North Asia East Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""North Asia East Standard Time""")
            Case "(UTC+08:00) Kuala Lumpur, Singapore - Singapore Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Singapore Standard Time""")
            Case "(UTC+08:00) Perth - W. Australia Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""W. Australia Standard Time""")
            Case "(UTC+08:00) Taipei - Taipei Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Taipei Standard Time""")
            Case "(UTC+08:00) Ulaanbaatar - Ulaanbaatar Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Ulaanbaatar Standard Time""")
            Case "(UTC+08:45) Eucla - Aus Central W. Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Aus Central W. Standard Time""")
            Case "(UTC+09:00) Chita - Transbaikal Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Transbaikal Standard Time""")
            Case "(UTC+09:00) Osaka, Sapporo, Tokyo - Tokyo Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Tokyo Standard Time""")
            Case "(UTC+09:00) Pyongyang - North Korea Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""North Korea Standard Time""")
            Case "(UTC+09:00) Seoul - Korea Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Korea Standard Time""")
            Case "(UTC+09:00) Yakutsk - Yakutsk Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Yakutsk Standard Time""")
            Case "(UTC+09:30) Adelaide - Cen. Australia Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Cen. Australia Standard Time""")
            Case "(UTC+09:30) Darwin - AUS Central Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""AUS Central Standard Time""")
            Case "(UTC+10:00) Brisbane - E. Australia Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""E. Australia Standard Time""")
            Case "(UTC+10:00) Canberra, Melbourne, Sydney - AUS Eastern Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""AUS Eastern Standard Time""")
            Case "(UTC+10:00) Guam, Port Moresby - West Pacific Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""West Pacific Standard Time""")
            Case "(UTC+10:00) Hobart - Tasmania Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Tasmania Standard Time""")
            Case "(UTC+10:00) Vladivostok - Vladivostok Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Vladivostok Standard Time""")
            Case "(UTC+10:30) Lord Howe Island - Lord Howe Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Lord Howe Standard Time""")
            Case "(UTC+11:00) Bougainville Island - Bougainville Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Bougainville Standard Time""")
            Case "(UTC+11:00) Chokurdakh - Russia Time Zone 10"
                Process.Start("cmd.exe", "/c tzutil /s ""Russia Time Zone 10""")
            Case "(UTC+11:00) Magadan - Magadan Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Magadan Standard Time""")
            Case "(UTC+11:00) Norfolk Island - Norfolk Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Norfolk Standard Time""")
            Case "(UTC+11:00) Sakhalin - Sakhalin Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Sakhalin Standard Time""")
            Case "(UTC+11:00) Solomon Is., New Caledonia - Central Pacific Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Central Pacific Standard Time""")
            Case "(UTC+12:00) Anadyr, Petropavlovsk-Kamchatsky - Russia Time Zone 11"
                Process.Start("cmd.exe", "/c tzutil /s ""Russia Time Zone 11""")
            Case "(UTC+12:00) Auckland, Wellington - New Zealand Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""New Zealand Standard Time""")
            Case "(UTC+12:00) Coordinated Universal Time+12 - UTC+12"
                Process.Start("cmd.exe", "/c tzutil /s ""UTC+12""")
            Case "(UTC+12:00) Fiji - Fiji Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Fiji Standard Time""")
            Case "(UTC+12:45) Chatham Islands - Chatham Islands Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Chatham Islands Standard Time""")
            Case "(UTC+13:00) Coordinated Universal Time+13 - UTC+13"
                Process.Start("cmd.exe", "/c tzutil /s ""UTC+13""")
            Case "(UTC+13:00) Nuku'alofa - Tonga Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Tonga Standard Time""")
            Case "(UTC+13:00) Samoa - Samoa Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Samoa Standard Time""")
            Case "(UTC+14:00) Kiritimati Island - Line Islands Standard Time"
                Process.Start("cmd.exe", "/c tzutil /s ""Line Islands Standard Time""")
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class

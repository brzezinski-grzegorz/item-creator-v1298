Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        ComboBox4.SelectedIndex = 0
        ComboBox5.SelectedIndex = 0
        ComboBox6.SelectedIndex = 0
        ComboBox7.SelectedIndex = 3
        ComboBox8.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            ' Create method of writing item values into text.
            Dim objWriter As New System.IO.StreamWriter(Application.StartupPath & "/Item_Org.txt", True)
            ' Item_org Line
            objWriter.WriteLine(TextBox1.Text & "_" & TextBox2.Text & "_" & TextBox3.Text & "_" & TextBox4.Text & "_" & TextBox5.Text & "_" & TextBox6.Text & "_" & TextBox7.Text & "_" & TextBox8.Text & "_" & TextBox9.Text & "_" & TextBox10.Text & "_" & ComboBox2.SelectedIndex & "_" & TextBox11.Text & "_" & ComboBox8.SelectedIndex & "_" & ComboBox3.SelectedIndex & "_" & ComboBox4.SelectedIndex & "_" & TextBox13.Text & "_" & TextBox14.Text & "_" & TextBox15.Text & "_" & TextBox16.Text & "_" & TextBox17.Text & "_" & TextBox18.Text & "_" & TextBox19.Text & "_" & TextBox20.Text & "_" & TextBox21.Text & "_" & TextBox22.Text & "_" & TextBox23.Text & "_" & TextBox24.Text & "_" & TextBox25.Text & "_" & ComboBox5.SelectedIndex & "_" & ComboBox6.SelectedIndex & "_" & TextBox26.Text & "_" & TextBox27.Text & "_" & TextBox28.Text & "_" & TextBox29.Text & "_" & TextBox30.Text & "_" & TextBox31.Text & "_" & ComboBox7.SelectedIndex)
            TextBox12.Text = TextBox1.Text.Substring(0, 6)
            objWriter.Close()
        Catch ex As Exception
            MsgBox("File has been updated!")
        Finally
            MsgBox("Item_ext trable has been created")
        End Try

        ' Hide this form, write the ext file as .txt and then show ITEM_EXT section of program.
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Created 14 pre-sets that define items characteristics. Combobox Index 0-13

        ' Daggers preset
        If ComboBox1.SelectedIndex = 1 Then
            ' Item Ext
            TextBox2.Text = "0"
            ' Item Kind
            ComboBox2.SelectedIndex = 1
            ' R Delay
            TextBox14.Text = "109"
            ' Weapon Range
            TextBox15.Text = "15"
            ' Weight
            TextBox16.Text = "50"
        End If

        ' One-handed Sword
        If ComboBox1.SelectedIndex = 2 Then
            ' Item Ext
            TextBox2.Text = "1"
            ' Item Kind
            ComboBox2.SelectedIndex = 2
            ' R Delay
            TextBox14.Text = "114"
            ' Weapon Range
            TextBox15.Text = "10"
            ' Weight
            TextBox16.Text = "70"
        End If

        ' Two-handed Sword
        If ComboBox1.SelectedIndex = 3 Then
            ' Item Ext
            TextBox2.Text = "2"
            ' Item Kind
            ComboBox2.SelectedIndex = 3
            ' R Delay
            TextBox14.Text = "139"
            ' Weapon Range
            TextBox15.Text = "15"
            ' Weight
            TextBox16.Text = "80"
        End If

        ' One-handed Axe
        If ComboBox1.SelectedIndex = 4 Then
            ' Item Ext
            TextBox2.Text = "3"
            ' Item Kind
            ComboBox2.SelectedIndex = 4
            ' R Delay
            TextBox14.Text = "114"
            ' Weapon Range
            TextBox15.Text = "10"
            ' Weight
            TextBox16.Text = "30"
        End If

        ' Two-handed Axe
        If ComboBox1.SelectedIndex = 5 Then
            ' Item Ext
            TextBox2.Text = "4"
            ' Item Kind
            ComboBox2.SelectedIndex = 5
            ' R Delay
            TextBox14.Text = "139"
            ' Weapon Range
            TextBox15.Text = "15"
            ' Weight
            TextBox16.Text = "120"
        End If

        ' One-handed Club
        If ComboBox1.SelectedIndex = 6 Then
            ' Item Ext
            TextBox2.Text = "5"
            ' Item Kind
            ComboBox2.SelectedIndex = 6
            ' R Delay
            TextBox14.Text = "119"
            ' Weapon Range
            TextBox15.Text = "10"
            ' Weight
            TextBox16.Text = "60"
        End If

        ' Two-handed Club
        If ComboBox1.SelectedIndex = 7 Then
            ' Item Ext
            TextBox2.Text = "6"
            ' Item Kind
            ComboBox2.SelectedIndex = 7
            ' R Delay
            TextBox14.Text = "149"
            ' Weapon Range
            TextBox15.Text = "15"
            ' Weight
            TextBox16.Text = "140"
        End If

        ' One-handed Spear
        If ComboBox1.SelectedIndex = 8 Then
            ' Item Ext
            TextBox2.Text = "7"
            ' Item Kind
            ComboBox2.SelectedIndex = 8
            ' R Delay
            TextBox14.Text = "129"
            ' Weapon Range
            TextBox15.Text = "20"
            ' Weight
            TextBox16.Text = "60"
        End If

        ' Two-handed spear
        If ComboBox1.SelectedIndex = 9 Then
            ' Item Ext
            TextBox2.Text = "8"
            ' Item Kind
            ComboBox2.SelectedIndex = 9
            ' R Delay
            TextBox14.Text = "164"
            ' Weapon Range
            TextBox15.Text = "20"
            ' Weight
            TextBox16.Text = "150"
        End If

        ' Shield
        If ComboBox1.SelectedIndex = 10 Then
            ' Item Ext
            TextBox2.Text = "9"
            ' Item Kind
            ComboBox2.SelectedIndex = 10
            ' R Delay
            TextBox14.Text = "100"
            ' Weapon Range
            TextBox15.Text = "20"
            ' Weight
            TextBox16.Text = "70"
        End If

        ' Bow
        If ComboBox1.SelectedIndex = 11 Then
            ' Item Ext
            TextBox2.Text = "10"
            ' Item Kind
            ComboBox2.SelectedIndex = 11
            ' R Delay
            TextBox14.Text = "150"
            ' Weapon Range
            TextBox15.Text = "400"
            ' Weight
            TextBox16.Text = "40"
        End If

        ' Crossbow
        If ComboBox1.SelectedIndex = 12 Then
            ' Item Ext
            TextBox2.Text = "11"
            ' Item Kind
            ComboBox2.SelectedIndex = 12
            ' R Delay
            TextBox14.Text = "150"
            ' Weapon Range
            TextBox15.Text = "400"
            ' Weight
            TextBox16.Text = "45"
        End If

        ' Staff
        If ComboBox1.SelectedIndex = 13 Then
            ' Item Ext
            TextBox2.Text = "12"
            ' Item Kind
            ComboBox2.SelectedIndex = 17
            ' R Delay
            TextBox14.Text = "200"
            ' Weapon Range
            TextBox15.Text = "10"
            ' Weight
            TextBox16.Text = "30"
        End If

    End Sub

End Class
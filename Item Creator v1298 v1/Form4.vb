﻿Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBox1.Text = Form2.TextBox1.Text
        TextBox2.Text = Form2.TextBox2.Text
        ComboBox1.SelectedIndex = Form3.ComboBox2.SelectedIndex
        ComboBox5.SelectedIndex = Form3.ComboBox8.SelectedIndex
        ComboBox7.SelectedIndex = Form2.ComboBox3.SelectedIndex
        ComboBox6.SelectedIndex = Form2.ComboBox4.SelectedIndex
        TextBox4.Text = Form3.TextBox14.Text
        TextBox9.Text = Form3.TextBox15.Text
        TextBox365.Text = Form3.TextBox16.Text
        TextBox8.Text = Form2.TextBox8.Text
        TextBox5.Text = Form3.TextBox18.Text
        TextBox6.Text = Form3.TextBox19.Text
        TextBox7.Text = Form3.TextBox20.Text
        TextBox366.Text = Form3.TextBox21.Text
        TextBox12.Text = Form3.TextBox24.Text
        TextBox367.Text = Form3.TextBox25.Text
        ComboBox3.SelectedIndex = Form3.ComboBox5.SelectedIndex
        ComboBox4.SelectedIndex = Form3.ComboBox6.SelectedIndex
        TextBox368.Text = Form3.TextBox26.Text
        TextBox369.Text = Form3.TextBox27.Text
        TextBox370.Text = Form3.TextBox28.Text
        TextBox371.Text = Form3.TextBox29.Text
        TextBox372.Text = Form3.TextBox30.Text
        TextBox373.Text = Form3.TextBox31.Text
        ComboBox2.SelectedIndex = Form2.ComboBox2.SelectedIndex
        TextBox13.Text = Form3.TextBox12.Text + Form2.TextBox13.Text
        TextBox14.Text = Form3.TextBox12.Text + Form2.TextBox60.Text
        TextBox15.Text = Form3.TextBox12.Text + Form2.TextBox76.Text
        TextBox16.Text = Form3.TextBox12.Text + Form2.TextBox92.Text
        TextBox17.Text = Form3.TextBox12.Text + Form2.TextBox108.Text
        TextBox18.Text = Form3.TextBox12.Text + Form2.TextBox124.Text
        TextBox19.Text = Form3.TextBox12.Text + Form2.TextBox140.Text
        TextBox20.Text = Form3.TextBox12.Text + Form2.TextBox156.Text
        TextBox21.Text = Form3.TextBox12.Text + Form2.TextBox172.Text
        TextBox22.Text = Form3.TextBox12.Text + Form2.TextBox188.Text
        TextBox23.Text = Form3.TextBox12.Text + Form2.TextBox204.Text

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            ' Create method of writing item values into text.
            Dim objWriter As New System.IO.StreamWriter(Application.StartupPath & "/ITEM.sql", True)
            ' Item_ext Line +0
            objWriter.WriteLine("Insert Into ITEM Values(" & TextBox13.Text & ",'" & TextBox1.Text & "'," & ComboBox1.SelectedIndex & "," & ComboBox5.SelectedIndex & "," & ComboBox7.SelectedIndex & "," & ComboBox6.SelectedIndex & "," & TextBox3.Text & "," & TextBox4.Text & "," & TextBox9.Text & "," & TextBox365.Text & "," & TextBox8.Text & "," & TextBox5.Text & "," & TextBox6.Text & "," & TextBox7.Text & "," & TextBox366.Text & "," & TextBox10.Text & "," & TextBox11.Text & "," & TextBox12.Text & "," & TextBox367.Text & "," & ComboBox3.SelectedIndex & "," & ComboBox4.SelectedIndex & "," & TextBox368.Text & "," & TextBox369.Text & "," & TextBox370.Text & "," & TextBox371.Text & "," & TextBox372.Text & "," & TextBox373.Text & "," & ComboBox2.SelectedIndex & "," & TextBox374.Text & "," & TextBox375.Text & "," & Form2.TextBox18.Text & "," & Form2.TextBox19.Text & "," & Form2.TextBox20.Text & "," & Form2.TextBox21.Text & "," & Form2.TextBox22.Text & "," & Form2.TextBox23.Text & "," & Form2.TextBox24.Text & "," & Form2.TextBox25.Text & "," & Form2.TextBox26.Text & "," & Form2.TextBox27.Text & "," & Form2.TextBox28.Text & "," & Form2.TextBox29.Text & "," & Form2.TextBox30.Text & "," & Form2.TextBox31.Text & "," & TextBox376.Text & "," & Form2.TextBox32.Text & "," & Form2.TextBox33.Text & "," & Form2.TextBox34.Text & "," & Form2.TextBox35.Text & "," & Form2.TextBox36.Text & "," & Form2.TextBox37.Text & "," & Form2.TextBox38.Text & "," & Form2.TextBox39.Text & "," & Form2.TextBox40.Text & "," & Form2.TextBox41.Text & "," & Form2.TextBox42.Text & "," & Form2.TextBox43.Text & "," & Form2.TextBox44.Text & ")")
            '+1
            objWriter.WriteLine("Insert Into ITEM Values(" & TextBox14.Text & ",'" & TextBox1.Text & " (+1)" & "'," & ComboBox1.SelectedIndex & "," & ComboBox5.SelectedIndex & "," & ComboBox7.SelectedIndex & "," & ComboBox6.SelectedIndex & "," & TextBox3.Text & "," & TextBox4.Text & "," & TextBox9.Text & "," & TextBox365.Text & "," & TextBox8.Text & "," & TextBox5.Text & "," & TextBox6.Text & "," & TextBox7.Text & "," & TextBox366.Text & "," & TextBox10.Text & "," & TextBox11.Text & "," & TextBox12.Text & "," & TextBox367.Text & "," & ComboBox3.SelectedIndex & "," & ComboBox4.SelectedIndex & "," & TextBox368.Text & "," & TextBox369.Text & "," & TextBox370.Text & "," & TextBox371.Text & "," & TextBox372.Text & "," & TextBox373.Text & "," & ComboBox2.SelectedIndex & "," & TextBox374.Text & "," & TextBox375.Text & "," & Form2.TextBox55.Text & "," & Form2.TextBox54.Text & "," & Form2.TextBox53.Text & "," & Form2.TextBox52.Text & "," & Form2.TextBox51.Text & "," & Form2.TextBox50.Text & "," & Form2.TextBox49.Text & "," & Form2.TextBox48.Text & "," & Form2.TextBox47.Text & "," & Form2.TextBox46.Text & "," & Form2.TextBox45.Text & "," & Form2.TextBox220.Text & "," & Form2.TextBox219.Text & "," & Form2.TextBox218.Text & "," & TextBox376.Text & "," & Form2.TextBox217.Text & "," & Form2.TextBox216.Text & "," & Form2.TextBox215.Text & "," & Form2.TextBox214.Text & "," & Form2.TextBox213.Text & "," & Form2.TextBox212.Text & "," & Form2.TextBox211.Text & "," & Form2.TextBox210.Text & "," & Form2.TextBox209.Text & "," & Form2.TextBox208.Text & "," & Form2.TextBox207.Text & "," & Form2.TextBox206.Text & "," & Form2.TextBox205.Text & ")")
            '+2
            objWriter.WriteLine("Insert Into ITEM Values(" & TextBox15.Text & ",'" & TextBox1.Text & " (+2)" & "'," & ComboBox1.SelectedIndex & "," & ComboBox5.SelectedIndex & "," & ComboBox7.SelectedIndex & "," & ComboBox6.SelectedIndex & "," & TextBox3.Text & "," & TextBox4.Text & "," & TextBox9.Text & "," & TextBox365.Text & "," & TextBox8.Text & "," & TextBox5.Text & "," & TextBox6.Text & "," & TextBox7.Text & "," & TextBox366.Text & "," & TextBox10.Text & "," & TextBox11.Text & "," & TextBox12.Text & "," & TextBox367.Text & "," & ComboBox3.SelectedIndex & "," & ComboBox4.SelectedIndex & "," & TextBox368.Text & "," & TextBox369.Text & "," & TextBox370.Text & "," & TextBox371.Text & "," & TextBox372.Text & "," & TextBox373.Text & "," & ComboBox2.SelectedIndex & "," & TextBox374.Text & "," & TextBox375.Text & "," & Form2.TextBox71.Text & "," & Form2.TextBox70.Text & "," & Form2.TextBox69.Text & "," & Form2.TextBox68.Text & "," & Form2.TextBox67.Text & "," & Form2.TextBox66.Text & "," & Form2.TextBox65.Text & "," & Form2.TextBox64.Text & "," & Form2.TextBox63.Text & "," & Form2.TextBox62.Text & "," & Form2.TextBox61.Text & "," & Form2.TextBox236.Text & "," & Form2.TextBox235.Text & "," & Form2.TextBox234.Text & "," & TextBox376.Text & "," & Form2.TextBox233.Text & "," & Form2.TextBox232.Text & "," & Form2.TextBox231.Text & "," & Form2.TextBox230.Text & "," & Form2.TextBox229.Text & "," & Form2.TextBox228.Text & "," & Form2.TextBox227.Text & "," & Form2.TextBox226.Text & "," & Form2.TextBox225.Text & "," & Form2.TextBox224.Text & "," & Form2.TextBox223.Text & "," & Form2.TextBox222.Text & "," & Form2.TextBox221.Text & ")")
            '+3
            objWriter.WriteLine("Insert Into ITEM Values(" & TextBox16.Text & ",'" & TextBox1.Text & " (+3)" & "'," & ComboBox1.SelectedIndex & "," & ComboBox5.SelectedIndex & "," & ComboBox7.SelectedIndex & "," & ComboBox6.SelectedIndex & "," & TextBox3.Text & "," & TextBox4.Text & "," & TextBox9.Text & "," & TextBox365.Text & "," & TextBox8.Text & "," & TextBox5.Text & "," & TextBox6.Text & "," & TextBox7.Text & "," & TextBox366.Text & "," & TextBox10.Text & "," & TextBox11.Text & "," & TextBox12.Text & "," & TextBox367.Text & "," & ComboBox3.SelectedIndex & "," & ComboBox4.SelectedIndex & "," & TextBox368.Text & "," & TextBox369.Text & "," & TextBox370.Text & "," & TextBox371.Text & "," & TextBox372.Text & "," & TextBox373.Text & "," & ComboBox2.SelectedIndex & "," & TextBox374.Text & "," & TextBox375.Text & "," & Form2.TextBox87.Text & "," & Form2.TextBox86.Text & "," & Form2.TextBox85.Text & "," & Form2.TextBox84.Text & "," & Form2.TextBox83.Text & "," & Form2.TextBox82.Text & "," & Form2.TextBox81.Text & "," & Form2.TextBox80.Text & "," & Form2.TextBox79.Text & "," & Form2.TextBox78.Text & "," & Form2.TextBox77.Text & "," & Form2.TextBox252.Text & "," & Form2.TextBox251.Text & "," & Form2.TextBox250.Text & "," & TextBox376.Text & "," & Form2.TextBox249.Text & "," & Form2.TextBox248.Text & "," & Form2.TextBox247.Text & "," & Form2.TextBox246.Text & "," & Form2.TextBox245.Text & "," & Form2.TextBox244.Text & "," & Form2.TextBox243.Text & "," & Form2.TextBox242.Text & "," & Form2.TextBox241.Text & "," & Form2.TextBox240.Text & "," & Form2.TextBox239.Text & "," & Form2.TextBox238.Text & "," & Form2.TextBox237.Text & ")")
            '+4
            objWriter.WriteLine("Insert Into ITEM Values(" & TextBox17.Text & ",'" & TextBox1.Text & " (+4)" & "'," & ComboBox1.SelectedIndex & "," & ComboBox5.SelectedIndex & "," & ComboBox7.SelectedIndex & "," & ComboBox6.SelectedIndex & "," & TextBox3.Text & "," & TextBox4.Text & "," & TextBox9.Text & "," & TextBox365.Text & "," & TextBox8.Text & "," & TextBox5.Text & "," & TextBox6.Text & "," & TextBox7.Text & "," & TextBox366.Text & "," & TextBox10.Text & "," & TextBox11.Text & "," & TextBox12.Text & "," & TextBox367.Text & "," & ComboBox3.SelectedIndex & "," & ComboBox4.SelectedIndex & "," & TextBox368.Text & "," & TextBox369.Text & "," & TextBox370.Text & "," & TextBox371.Text & "," & TextBox372.Text & "," & TextBox373.Text & "," & ComboBox2.SelectedIndex & "," & TextBox374.Text & "," & TextBox375.Text & "," & Form2.TextBox103.Text & "," & Form2.TextBox102.Text & "," & Form2.TextBox101.Text & "," & Form2.TextBox100.Text & "," & Form2.TextBox99.Text & "," & Form2.TextBox98.Text & "," & Form2.TextBox97.Text & "," & Form2.TextBox96.Text & "," & Form2.TextBox95.Text & "," & Form2.TextBox94.Text & "," & Form2.TextBox93.Text & "," & Form2.TextBox268.Text & "," & Form2.TextBox267.Text & "," & Form2.TextBox266.Text & "," & TextBox376.Text & "," & Form2.TextBox265.Text & "," & Form2.TextBox264.Text & "," & Form2.TextBox263.Text & "," & Form2.TextBox262.Text & "," & Form2.TextBox261.Text & "," & Form2.TextBox260.Text & "," & Form2.TextBox259.Text & "," & Form2.TextBox258.Text & "," & Form2.TextBox257.Text & "," & Form2.TextBox256.Text & "," & Form2.TextBox255.Text & "," & Form2.TextBox254.Text & "," & Form2.TextBox253.Text & ")")
            '+5
            objWriter.WriteLine("Insert Into ITEM Values(" & TextBox18.Text & ",'" & TextBox1.Text & " (+5)" & "'," & ComboBox1.SelectedIndex & "," & ComboBox5.SelectedIndex & "," & ComboBox7.SelectedIndex & "," & ComboBox6.SelectedIndex & "," & TextBox3.Text & "," & TextBox4.Text & "," & TextBox9.Text & "," & TextBox365.Text & "," & TextBox8.Text & "," & TextBox5.Text & "," & TextBox6.Text & "," & TextBox7.Text & "," & TextBox366.Text & "," & TextBox10.Text & "," & TextBox11.Text & "," & TextBox12.Text & "," & TextBox367.Text & "," & ComboBox3.SelectedIndex & "," & ComboBox4.SelectedIndex & "," & TextBox368.Text & "," & TextBox369.Text & "," & TextBox370.Text & "," & TextBox371.Text & "," & TextBox372.Text & "," & TextBox373.Text & "," & ComboBox2.SelectedIndex & "," & TextBox374.Text & "," & TextBox375.Text & "," & Form2.TextBox119.Text & "," & Form2.TextBox118.Text & "," & Form2.TextBox117.Text & "," & Form2.TextBox116.Text & "," & Form2.TextBox115.Text & "," & Form2.TextBox114.Text & "," & Form2.TextBox113.Text & "," & Form2.TextBox112.Text & "," & Form2.TextBox111.Text & "," & Form2.TextBox110.Text & "," & Form2.TextBox109.Text & "," & Form2.TextBox284.Text & "," & Form2.TextBox283.Text & "," & Form2.TextBox282.Text & "," & TextBox376.Text & "," & Form2.TextBox281.Text & "," & Form2.TextBox280.Text & "," & Form2.TextBox279.Text & "," & Form2.TextBox278.Text & "," & Form2.TextBox277.Text & "," & Form2.TextBox276.Text & "," & Form2.TextBox275.Text & "," & Form2.TextBox274.Text & "," & Form2.TextBox273.Text & "," & Form2.TextBox272.Text & "," & Form2.TextBox271.Text & "," & Form2.TextBox270.Text & "," & Form2.TextBox269.Text & ")")
            '+6
            objWriter.WriteLine("Insert Into ITEM Values(" & TextBox19.Text & ",'" & TextBox1.Text & " (+6)" & "'," & ComboBox1.SelectedIndex & "," & ComboBox5.SelectedIndex & "," & ComboBox7.SelectedIndex & "," & ComboBox6.SelectedIndex & "," & TextBox3.Text & "," & TextBox4.Text & "," & TextBox9.Text & "," & TextBox365.Text & "," & TextBox8.Text & "," & TextBox5.Text & "," & TextBox6.Text & "," & TextBox7.Text & "," & TextBox366.Text & "," & TextBox10.Text & "," & TextBox11.Text & "," & TextBox12.Text & "," & TextBox367.Text & "," & ComboBox3.SelectedIndex & "," & ComboBox4.SelectedIndex & "," & TextBox368.Text & "," & TextBox369.Text & "," & TextBox370.Text & "," & TextBox371.Text & "," & TextBox372.Text & "," & TextBox373.Text & "," & ComboBox2.SelectedIndex & "," & TextBox374.Text & "," & TextBox375.Text & "," & Form2.TextBox135.Text & "," & Form2.TextBox134.Text & "," & Form2.TextBox133.Text & "," & Form2.TextBox132.Text & "," & Form2.TextBox131.Text & "," & Form2.TextBox130.Text & "," & Form2.TextBox129.Text & "," & Form2.TextBox128.Text & "," & Form2.TextBox127.Text & "," & Form2.TextBox126.Text & "," & Form2.TextBox125.Text & "," & Form2.TextBox300.Text & "," & Form2.TextBox299.Text & "," & Form2.TextBox298.Text & "," & TextBox376.Text & "," & Form2.TextBox297.Text & "," & Form2.TextBox296.Text & "," & Form2.TextBox295.Text & "," & Form2.TextBox294.Text & "," & Form2.TextBox293.Text & "," & Form2.TextBox292.Text & "," & Form2.TextBox291.Text & "," & Form2.TextBox290.Text & "," & Form2.TextBox289.Text & "," & Form2.TextBox288.Text & "," & Form2.TextBox287.Text & "," & Form2.TextBox286.Text & "," & Form2.TextBox285.Text & ")")
            '+7
            objWriter.WriteLine("Insert Into ITEM Values(" & TextBox20.Text & ",'" & TextBox1.Text & " (+7)" & "'," & ComboBox1.SelectedIndex & "," & ComboBox5.SelectedIndex & "," & ComboBox7.SelectedIndex & "," & ComboBox6.SelectedIndex & "," & TextBox3.Text & "," & TextBox4.Text & "," & TextBox9.Text & "," & TextBox365.Text & "," & TextBox8.Text & "," & TextBox5.Text & "," & TextBox6.Text & "," & TextBox7.Text & "," & TextBox366.Text & "," & TextBox10.Text & "," & TextBox11.Text & "," & TextBox12.Text & "," & TextBox367.Text & "," & ComboBox3.SelectedIndex & "," & ComboBox4.SelectedIndex & "," & TextBox368.Text & "," & TextBox369.Text & "," & TextBox370.Text & "," & TextBox371.Text & "," & TextBox372.Text & "," & TextBox373.Text & "," & ComboBox2.SelectedIndex & "," & TextBox374.Text & "," & TextBox375.Text & "," & Form2.TextBox151.Text & "," & Form2.TextBox150.Text & "," & Form2.TextBox149.Text & "," & Form2.TextBox148.Text & "," & Form2.TextBox147.Text & "," & Form2.TextBox146.Text & "," & Form2.TextBox145.Text & "," & Form2.TextBox144.Text & "," & Form2.TextBox143.Text & "," & Form2.TextBox142.Text & "," & Form2.TextBox141.Text & "," & Form2.TextBox316.Text & "," & Form2.TextBox315.Text & "," & Form2.TextBox314.Text & "," & TextBox376.Text & "," & Form2.TextBox313.Text & "," & Form2.TextBox312.Text & "," & Form2.TextBox311.Text & "," & Form2.TextBox310.Text & "," & Form2.TextBox309.Text & "," & Form2.TextBox308.Text & "," & Form2.TextBox307.Text & "," & Form2.TextBox306.Text & "," & Form2.TextBox305.Text & "," & Form2.TextBox304.Text & "," & Form2.TextBox303.Text & "," & Form2.TextBox302.Text & "," & Form2.TextBox301.Text & ")")
            '+8
            objWriter.WriteLine("Insert Into ITEM Values(" & TextBox21.Text & ",'" & TextBox1.Text & " (+8)" & "'," & ComboBox1.SelectedIndex & "," & ComboBox5.SelectedIndex & "," & ComboBox7.SelectedIndex & "," & ComboBox6.SelectedIndex & "," & TextBox3.Text & "," & TextBox4.Text & "," & TextBox9.Text & "," & TextBox365.Text & "," & TextBox8.Text & "," & TextBox5.Text & "," & TextBox6.Text & "," & TextBox7.Text & "," & TextBox366.Text & "," & TextBox10.Text & "," & TextBox11.Text & "," & TextBox12.Text & "," & TextBox367.Text & "," & ComboBox3.SelectedIndex & "," & ComboBox4.SelectedIndex & "," & TextBox368.Text & "," & TextBox369.Text & "," & TextBox370.Text & "," & TextBox371.Text & "," & TextBox372.Text & "," & TextBox373.Text & "," & ComboBox2.SelectedIndex & "," & TextBox374.Text & "," & TextBox375.Text & "," & Form2.TextBox167.Text & "," & Form2.TextBox166.Text & "," & Form2.TextBox165.Text & "," & Form2.TextBox164.Text & "," & Form2.TextBox163.Text & "," & Form2.TextBox162.Text & "," & Form2.TextBox161.Text & "," & Form2.TextBox160.Text & "," & Form2.TextBox159.Text & "," & Form2.TextBox158.Text & "," & Form2.TextBox157.Text & "," & Form2.TextBox332.Text & "," & Form2.TextBox331.Text & "," & Form2.TextBox330.Text & "," & TextBox376.Text & "," & Form2.TextBox329.Text & "," & Form2.TextBox328.Text & "," & Form2.TextBox327.Text & "," & Form2.TextBox326.Text & "," & Form2.TextBox325.Text & "," & Form2.TextBox324.Text & "," & Form2.TextBox323.Text & "," & Form2.TextBox322.Text & "," & Form2.TextBox321.Text & "," & Form2.TextBox320.Text & "," & Form2.TextBox319.Text & "," & Form2.TextBox318.Text & "," & Form2.TextBox317.Text & ")")
            '+9
            objWriter.WriteLine("Insert Into ITEM Values(" & TextBox22.Text & ",'" & TextBox1.Text & " (+9)" & "'," & ComboBox1.SelectedIndex & "," & ComboBox5.SelectedIndex & "," & ComboBox7.SelectedIndex & "," & ComboBox6.SelectedIndex & "," & TextBox3.Text & "," & TextBox4.Text & "," & TextBox9.Text & "," & TextBox365.Text & "," & TextBox8.Text & "," & TextBox5.Text & "," & TextBox6.Text & "," & TextBox7.Text & "," & TextBox366.Text & "," & TextBox10.Text & "," & TextBox11.Text & "," & TextBox12.Text & "," & TextBox367.Text & "," & ComboBox3.SelectedIndex & "," & ComboBox4.SelectedIndex & "," & TextBox368.Text & "," & TextBox369.Text & "," & TextBox370.Text & "," & TextBox371.Text & "," & TextBox372.Text & "," & TextBox373.Text & "," & ComboBox2.SelectedIndex & "," & TextBox374.Text & "," & TextBox375.Text & "," & Form2.TextBox183.Text & "," & Form2.TextBox182.Text & "," & Form2.TextBox181.Text & "," & Form2.TextBox180.Text & "," & Form2.TextBox179.Text & "," & Form2.TextBox178.Text & "," & Form2.TextBox177.Text & "," & Form2.TextBox176.Text & "," & Form2.TextBox175.Text & "," & Form2.TextBox174.Text & "," & Form2.TextBox173.Text & "," & Form2.TextBox348.Text & "," & Form2.TextBox347.Text & "," & Form2.TextBox346.Text & "," & TextBox376.Text & "," & Form2.TextBox345.Text & "," & Form2.TextBox344.Text & "," & Form2.TextBox343.Text & "," & Form2.TextBox342.Text & "," & Form2.TextBox341.Text & "," & Form2.TextBox340.Text & "," & Form2.TextBox339.Text & "," & Form2.TextBox338.Text & "," & Form2.TextBox337.Text & "," & Form2.TextBox336.Text & "," & Form2.TextBox335.Text & "," & Form2.TextBox334.Text & "," & Form2.TextBox333.Text & ")")
            '+10
            objWriter.WriteLine("Insert Into ITEM Values(" & TextBox23.Text & ",'" & TextBox1.Text & " (+10)" & "'," & ComboBox1.SelectedIndex & "," & ComboBox5.SelectedIndex & "," & ComboBox7.SelectedIndex & "," & ComboBox6.SelectedIndex & "," & TextBox3.Text & "," & TextBox4.Text & "," & TextBox9.Text & "," & TextBox365.Text & "," & TextBox8.Text & "," & TextBox5.Text & "," & TextBox6.Text & "," & TextBox7.Text & "," & TextBox366.Text & "," & TextBox10.Text & "," & TextBox11.Text & "," & TextBox12.Text & "," & TextBox367.Text & "," & ComboBox3.SelectedIndex & "," & ComboBox4.SelectedIndex & "," & TextBox368.Text & "," & TextBox369.Text & "," & TextBox370.Text & "," & TextBox371.Text & "," & TextBox372.Text & "," & TextBox373.Text & "," & ComboBox2.SelectedIndex & "," & TextBox374.Text & "," & TextBox375.Text & "," & "," & Form2.TextBox199.Text & "," & Form2.TextBox198.Text & "," & Form2.TextBox197.Text & "," & Form2.TextBox196.Text & "," & Form2.TextBox195.Text & "," & Form2.TextBox194.Text & "," & Form2.TextBox193.Text & "," & Form2.TextBox192.Text & "," & Form2.TextBox191.Text & "," & Form2.TextBox190.Text & "," & Form2.TextBox189.Text & "," & Form2.TextBox364.Text & "," & Form2.TextBox363.Text & "," & Form2.TextBox362.Text & "," & TextBox376.Text & "," & Form2.TextBox361.Text & "," & Form2.TextBox360.Text & "," & Form2.TextBox359.Text & "," & Form2.TextBox358.Text & "," & Form2.TextBox357.Text & "," & Form2.TextBox356.Text & "," & Form2.TextBox355.Text & "," & Form2.TextBox354.Text & "," & Form2.TextBox353.Text & "," & Form2.TextBox352.Text & "," & Form2.TextBox351.Text & "," & Form2.TextBox350.Text & "," & Form2.TextBox349.Text & ")")

            objWriter.Close()
        Catch ex As Exception
            MsgBox("File has been updated!")
        Finally
            MsgBox("Item_org table has been created!")
        End Try

        ' Hide this form, write the ext file as .txt and then show ITEM section of program.
        Me.Hide()
        Form5.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Hide()
        Form2.Show()

    End Sub

End Class
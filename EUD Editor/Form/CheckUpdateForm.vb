﻿Public Class CheckUpdateForm
    Private Sub CheckUpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = My.Settings.IgnoreUpdate
        RichTextBox1.Text = GetPatchNote()
        If CheckUpdateAble() Then
            Button1.Enabled = True
            Button1.Text = lastver & " 업데이트"
        Else
            Button1.Enabled = False
            Button1.Text = "현재 최신버전입니다."
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        My.Settings.IgnoreUpdate = CheckBox1.Checked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateEUDEditor()
    End Sub
    ' 
End Class
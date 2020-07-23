﻿Imports System.Runtime.InteropServices

Public Class Login
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub IconPictureBox2_Click(sender As Object, e As EventArgs) Handles IconPictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class
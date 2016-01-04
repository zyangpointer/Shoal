﻿Imports Microsoft.VisualBasic.Scripting.ShoalShell

Public Class FormIDEMain

    Dim Plugins As PlugIn.PlugInManager

    Private Sub DocumentToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call MultipleTabpagePanel1.AddTabPage("New Document.shl", New Global.Dev.Shl.DocumentEditor.DocumentEditor)
    End Sub

    Private Sub FormIdeMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'On Error Resume Next

        'Caption1.Icon = My.Resources.ShellScript
        'Plugins = PlugIn.PlugInManager.LoadPlugins(Me.MenuStrip, My.Application.Info.DirectoryPath & "/Plugins", My.Application.Info.DirectoryPath & "/Settings/dev_plugins.xml")

        'If Not String.IsNullOrEmpty(Program.ShellOpenFile) Then
        '    Dim Editor = New DocumentEditor.DocumentEditor
        '    Call MultipleTabpagePanel1.AddTabPage(FileIO.FileSystem.GetFileInfo(ShellOpenFile).Name, Editor)
        '    Call Editor.LoadFile(ShellOpenFile)
        'Else
        '    Call MultipleTabpagePanel1.AddTabPage("Start", New IDEStartpage)
        'End If

        'Caption1.SubCaption = "ShoalShell"
        'Caption1.Text = "Lans Shoal Shell Studio"
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call Plugins.Save()
        Me.Close()
        Call Program.Finalize()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        Process.Start(Program.Settings.Debugger)
    End Sub

    Private Sub ShellScriptToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Using File As New OpenFileDialog
            If File.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Dim FileName As String = FileIO.FileSystem.GetName(File.FileName)
                Dim Editor As New DocumentEditor.DocumentEditor

                Call MultipleTabpagePanel1.AddTabPage(FileName, Editor)
                Call Editor.LoadFile(File.FileName)
            End If
        End Using
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        If TypeOf MultipleTabpagePanel1.CurrentTab Is DocumentEditor.DocumentEditor Then
            Dim Editor = DirectCast(MultipleTabpagePanel1.CurrentTab, DocumentEditor.DocumentEditor)
            Dim FilePath = String.Format("{0}/{1}.txt", My.Computer.FileSystem.SpecialDirectories.Temp, Rnd)

            Call VBMath.Randomize()
            Call Editor.SaveFile(FilePath)

            If Not String.Equals(IO.File.ReadLines(FilePath).Last.Trim, "pause", StringComparison.OrdinalIgnoreCase) Then
                Call FileIO.FileSystem.WriteAllText(FilePath, "pause", True)
            End If

            If Not Program.Settings.Debugger.FileExists Then
                Program.Settings.Debugger = SelectFile("Program File(*.exe)|*.exe")
                Program.ScriptDebugger = New Runtime.Debugging.DebuggerListener(Program.Settings.Debugger, "")
            End If

            Call Program.ScriptDebugger.PushScript(FilePath)
        Else
            Call Program.ScriptDebugger.SendMessage("[DEBUGGER_MESSAGE] Debugging source is not avaliable!")
        End If
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call MultipleTabpagePanel1.AddTabPage("Preferences", New Global.Dev.Shl.Preferences)
    End Sub

    Private Sub PluginToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call Plugins.ShowDialog()
    End Sub

    Private Sub PropertyToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call MultipleTabpagePanel1.AddTabPage("Property", New Global.Dev.Shl.ProjectPropertyPage)
    End Sub

    Private Sub ProjectHomeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call MultipleTabpagePanel1.AddTabPage("Shoal Shell Project Home", New Global.Dev.Shl.Browser)
    End Sub
End Class
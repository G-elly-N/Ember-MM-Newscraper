﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVideoPlayer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlPlayer = New System.Windows.Forms.Panel()
        Me.myVlcControl = New Vlc.DotNet.Forms.VlcControl()
        Me.pnlPlayer.SuspendLayout()
        CType(Me.myVlcControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPlayer
        '
        Me.pnlPlayer.Controls.Add(Me.myVlcControl)
        Me.pnlPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPlayer.Location = New System.Drawing.Point(0, 0)
        Me.pnlPlayer.Name = "pnlPlayer"
        Me.pnlPlayer.Size = New System.Drawing.Size(898, 471)
        Me.pnlPlayer.TabIndex = 3
        '
        'myVlcControl
        '
        Me.myVlcControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.myVlcControl.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.myVlcControl.Location = New System.Drawing.Point(27, 39)
        Me.myVlcControl.Name = "myVlcControl"
        Me.myVlcControl.Size = New System.Drawing.Size(564, 338)
        Me.myVlcControl.Spu = -1
        Me.myVlcControl.TabIndex = 1
        Me.myVlcControl.Text = "vlcRincewindControl1"
        Me.myVlcControl.VlcLibDirectory = Nothing
        Me.myVlcControl.VlcMediaplayerOptions = Nothing
        '
        'frmVideoPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(898, 471)
        Me.Controls.Add(Me.pnlPlayer)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVideoPlayer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "VideoPlayer"
        Me.pnlPlayer.ResumeLayout(False)
        CType(Me.myVlcControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlPlayer As System.Windows.Forms.Panel
    Private WithEvents myVlcControl As Vlc.DotNet.Forms.VlcControl
End Class

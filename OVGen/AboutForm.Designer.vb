<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelInformation = New System.Windows.Forms.Label()
        Me.LinkLabelWebsite = New System.Windows.Forms.LinkLabel()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(118, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelInformation
        '
        Me.LabelInformation.Location = New System.Drawing.Point(12, 9)
        Me.LabelInformation.Name = "LabelInformation"
        Me.LabelInformation.Size = New System.Drawing.Size(193, 88)
        Me.LabelInformation.TabIndex = 1
        Me.LabelInformation.Text = "A software you can put WAV files and make oscilloscope view thing." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Creator: Ze" &
    "inok"
        '
        'LinkLabelWebsite
        '
        Me.LinkLabelWebsite.AutoSize = True
        Me.LinkLabelWebsite.Location = New System.Drawing.Point(12, 97)
        Me.LinkLabelWebsite.Name = "LinkLabelWebsite"
        Me.LinkLabelWebsite.Size = New System.Drawing.Size(153, 15)
        Me.LinkLabelWebsite.TabIndex = 2
        Me.LinkLabelWebsite.TabStop = True
        Me.LinkLabelWebsite.Text = "https://zeinok.blogspot.tw"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Location = New System.Drawing.Point(12, 138)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(64, 15)
        Me.LabelVersion.TabIndex = 3
        Me.LabelVersion.Text = "<version>"
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 171)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.LinkLabelWebsite)
        Me.Controls.Add(Me.LabelInformation)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LabelInformation As System.Windows.Forms.Label
    Friend WithEvents LinkLabelWebsite As System.Windows.Forms.LinkLabel
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
End Class

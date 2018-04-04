<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoAmplifyWorkerForm
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
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelPleaseWait = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.BackgroundWorkerAutoAmplify = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'LabelPleaseWait
        '
        Me.LabelPleaseWait.AutoSize = True
        Me.LabelPleaseWait.Location = New System.Drawing.Point(74, 9)
        Me.LabelPleaseWait.Name = "LabelPleaseWait"
        Me.LabelPleaseWait.Size = New System.Drawing.Size(85, 15)
        Me.LabelPleaseWait.TabIndex = 0
        Me.LabelPleaseWait.Text = "Please Wait..."
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(79, 27)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 26)
        Me.ButtonCancel.TabIndex = 2
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'BackgroundWorkerAutoAmplify
        '
        Me.BackgroundWorkerAutoAmplify.WorkerReportsProgress = True
        Me.BackgroundWorkerAutoAmplify.WorkerSupportsCancellation = True
        '
        'AutoAmplifyWorkerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(232, 62)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.LabelPleaseWait)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AutoAmplifyWorkerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Auto Amplify"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelPleaseWait As Label
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents BackgroundWorkerAutoAmplify As System.ComponentModel.BackgroundWorker
End Class

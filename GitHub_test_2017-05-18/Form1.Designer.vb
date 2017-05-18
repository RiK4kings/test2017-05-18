<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GitHub
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdButton = New System.Windows.Forms.Button()
        Me.lblAnzeige = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdButton
        '
        Me.cmdButton.Location = New System.Drawing.Point(48, 33)
        Me.cmdButton.Name = "cmdButton"
        Me.cmdButton.Size = New System.Drawing.Size(400, 90)
        Me.cmdButton.TabIndex = 0
        Me.cmdButton.Text = "DRÜCK MICH"
        Me.cmdButton.UseVisualStyleBackColor = True
        '
        'lblAnzeige
        '
        Me.lblAnzeige.AutoSize = True
        Me.lblAnzeige.Location = New System.Drawing.Point(172, 189)
        Me.lblAnzeige.Name = "lblAnzeige"
        Me.lblAnzeige.Size = New System.Drawing.Size(0, 17)
        Me.lblAnzeige.TabIndex = 1
        '
        'GitHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 341)
        Me.Controls.Add(Me.lblAnzeige)
        Me.Controls.Add(Me.cmdButton)
        Me.Name = "GitHub"
        Me.Text = "GitHub Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdButton As Button
    Friend WithEvents lblAnzeige As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnExit1 = New System.Windows.Forms.Button()
        Me.btnExit2 = New System.Windows.Forms.Button()
        Me.btnWTF = New System.Windows.Forms.Button()
        Me.btnExit3 = New System.Windows.Forms.Button()
        Me.btnExit4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit1
        '
        Me.btnExit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit1.Location = New System.Drawing.Point(16, 15)
        Me.btnExit1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit1.Name = "btnExit1"
        Me.btnExit1.Size = New System.Drawing.Size(247, 82)
        Me.btnExit1.TabIndex = 0
        Me.btnExit1.Text = "Exit"
        Me.btnExit1.UseVisualStyleBackColor = True
        '
        'btnExit2
        '
        Me.btnExit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit2.Location = New System.Drawing.Point(271, 15)
        Me.btnExit2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit2.Name = "btnExit2"
        Me.btnExit2.Size = New System.Drawing.Size(247, 82)
        Me.btnExit2.TabIndex = 1
        Me.btnExit2.Text = "Exit"
        Me.btnExit2.UseVisualStyleBackColor = True
        '
        'btnWTF
        '
        Me.btnWTF.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnWTF.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWTF.Location = New System.Drawing.Point(526, 15)
        Me.btnWTF.Margin = New System.Windows.Forms.Padding(4)
        Me.btnWTF.Name = "btnWTF"
        Me.btnWTF.Size = New System.Drawing.Size(247, 82)
        Me.btnWTF.TabIndex = 2
        Me.btnWTF.Text = "WTF?"
        Me.btnWTF.UseVisualStyleBackColor = True
        '
        'btnExit3
        '
        Me.btnExit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit3.Location = New System.Drawing.Point(781, 13)
        Me.btnExit3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit3.Name = "btnExit3"
        Me.btnExit3.Size = New System.Drawing.Size(247, 82)
        Me.btnExit3.TabIndex = 3
        Me.btnExit3.Text = "Exit"
        Me.btnExit3.UseVisualStyleBackColor = True
        '
        'btnExit4
        '
        Me.btnExit4.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit4.Location = New System.Drawing.Point(1037, 13)
        Me.btnExit4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit4.Name = "btnExit4"
        Me.btnExit4.Size = New System.Drawing.Size(247, 82)
        Me.btnExit4.TabIndex = 4
        Me.btnExit4.Text = "Exit"
        Me.btnExit4.UseVisualStyleBackColor = True
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1297, 112)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit4)
        Me.Controls.Add(Me.btnExit3)
        Me.Controls.Add(Me.btnWTF)
        Me.Controls.Add(Me.btnExit2)
        Me.Controls.Add(Me.btnExit1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGame"
        Me.ShowInTaskbar = False
        Me.Text = "Wanna Play A Game?"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit1 As Button
    Friend WithEvents btnExit2 As Button
    Friend WithEvents btnWTF As Button
    Friend WithEvents btnExit3 As Button
    Friend WithEvents btnExit4 As Button
End Class

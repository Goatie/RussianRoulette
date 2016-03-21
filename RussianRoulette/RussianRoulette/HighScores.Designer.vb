<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighScores
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
        Me.dgHighScores = New System.Windows.Forms.DataGridView()
        Me.dgScore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.dgHighScores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgHighScores
        '
        Me.dgHighScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgHighScores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgScore, Me.dgName})
        Me.dgHighScores.Location = New System.Drawing.Point(168, 77)
        Me.dgHighScores.Name = "dgHighScores"
        Me.dgHighScores.Size = New System.Drawing.Size(245, 238)
        Me.dgHighScores.TabIndex = 0
        '
        'dgScore
        '
        Me.dgScore.HeaderText = "Score"
        Me.dgScore.Name = "dgScore"
        '
        'dgName
        '
        Me.dgName.HeaderText = "Name"
        Me.dgName.Name = "dgName"
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(256, 374)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(85, 35)
        Me.btnMenu.TabIndex = 1
        Me.btnMenu.Text = "Back to Main Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(256, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 35)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'HighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 485)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.dgHighScores)
        Me.Name = "HighScores"
        Me.Text = "HighScores"
        CType(Me.dgHighScores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgHighScores As System.Windows.Forms.DataGridView
    Friend WithEvents dgScore As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class

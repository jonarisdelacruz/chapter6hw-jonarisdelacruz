<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCornMaze
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCornMaze))
        Me.picMazeEntrance = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblaverage = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnEnterTime = New System.Windows.Forms.Button()
        CType(Me.picMazeEntrance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picMazeEntrance
        '
        Me.picMazeEntrance.Image = CType(resources.GetObject("picMazeEntrance.Image"), System.Drawing.Image)
        Me.picMazeEntrance.Location = New System.Drawing.Point(408, 38)
        Me.picMazeEntrance.Name = "picMazeEntrance"
        Me.picMazeEntrance.Size = New System.Drawing.Size(248, 413)
        Me.picMazeEntrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMazeEntrance.TabIndex = 0
        Me.picMazeEntrance.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Location = New System.Drawing.Point(84, 38)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(190, 17)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Race through the Corn Maze"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(81, 153)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(165, 100)
        Me.ListBox1.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(679, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(118, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(118, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblaverage
        '
        Me.lblaverage.AutoSize = True
        Me.lblaverage.Location = New System.Drawing.Point(41, 341)
        Me.lblaverage.Name = "lblaverage"
        Me.lblaverage.Size = New System.Drawing.Size(205, 17)
        Me.lblaverage.TabIndex = 5
        Me.lblaverage.Text = "The average completion time is"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(96, 270)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(107, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnEnterTime
        '
        Me.btnEnterTime.Location = New System.Drawing.Point(15, 97)
        Me.btnEnterTime.Name = "btnEnterTime"
        Me.btnEnterTime.Size = New System.Drawing.Size(321, 23)
        Me.btnEnterTime.TabIndex = 7
        Me.btnEnterTime.Text = "Please Enter up to 10 corn maze completion times"
        Me.btnEnterTime.UseVisualStyleBackColor = True
        '
        'frmCornMaze
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 487)
        Me.Controls.Add(Me.btnEnterTime)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblaverage)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picMazeEntrance)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCornMaze"
        Me.Text = "Corn Maze Average Time"
        CType(Me.picMazeEntrance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMazeEntrance As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblaverage As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnEnterTime As Button
End Class

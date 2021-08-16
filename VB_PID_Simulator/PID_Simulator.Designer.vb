<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PID_Simulator
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AlarmView = New System.Windows.Forms.ListView()
        Me.SimulationStartPb = New System.Windows.Forms.Button()
        Me.SimulationStopPb = New System.Windows.Forms.Button()
        Me.SimulationSpeedSet = New System.Windows.Forms.TrackBar()
        Me.SimulationTrend = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SimulationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SimulationSpeedSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimulationTrend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 1012)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1478, 32)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'MenuStrip
        '
        Me.MenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1478, 33)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(73, 29)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(60, 25)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SimulationSpeedSet)
        Me.Panel1.Controls.Add(Me.SimulationStopPb)
        Me.Panel1.Controls.Add(Me.SimulationStartPb)
        Me.Panel1.Location = New System.Drawing.Point(15, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 150)
        Me.Panel1.TabIndex = 2
        '
        'AlarmView
        '
        Me.AlarmView.HideSelection = False
        Me.AlarmView.Location = New System.Drawing.Point(400, 50)
        Me.AlarmView.Name = "AlarmView"
        Me.AlarmView.Size = New System.Drawing.Size(1050, 150)
        Me.AlarmView.TabIndex = 3
        Me.AlarmView.UseCompatibleStateImageBehavior = False
        '
        'SimulationStartPb
        '
        Me.SimulationStartPb.Location = New System.Drawing.Point(15, 15)
        Me.SimulationStartPb.Name = "SimulationStartPb"
        Me.SimulationStartPb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SimulationStartPb.Size = New System.Drawing.Size(150, 50)
        Me.SimulationStartPb.TabIndex = 0
        Me.SimulationStartPb.Text = "Start"
        Me.SimulationStartPb.UseVisualStyleBackColor = True
        '
        'SimulationStopPb
        '
        Me.SimulationStopPb.Location = New System.Drawing.Point(185, 15)
        Me.SimulationStopPb.Name = "SimulationStopPb"
        Me.SimulationStopPb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SimulationStopPb.Size = New System.Drawing.Size(150, 50)
        Me.SimulationStopPb.TabIndex = 0
        Me.SimulationStopPb.Text = "Stop"
        Me.SimulationStopPb.UseVisualStyleBackColor = True
        '
        'SimulationSpeedSet
        '
        Me.SimulationSpeedSet.Location = New System.Drawing.Point(15, 70)
        Me.SimulationSpeedSet.Name = "SimulationSpeedSet"
        Me.SimulationSpeedSet.Size = New System.Drawing.Size(320, 69)
        Me.SimulationSpeedSet.TabIndex = 1
        '
        'SimulationTrend
        '
        ChartArea3.Name = "ChartArea1"
        Me.SimulationTrend.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.SimulationTrend.Legends.Add(Legend3)
        Me.SimulationTrend.Location = New System.Drawing.Point(400, 229)
        Me.SimulationTrend.Name = "SimulationTrend"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.SimulationTrend.Series.Add(Series3)
        Me.SimulationTrend.Size = New System.Drawing.Size(1050, 500)
        Me.SimulationTrend.TabIndex = 4
        Me.SimulationTrend.Text = "Chart1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 229)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 500)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Process Model"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ItemSize = New System.Drawing.Size(85, 25)
        Me.TabControl1.Location = New System.Drawing.Point(15, 750)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1435, 250)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1427, 217)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tuning"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1427, 217)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Advanced"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Process Input"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(170, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "50.00"
        '
        'PID_Simulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1478, 1044)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SimulationTrend)
        Me.Controls.Add(Me.AlarmView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "PID_Simulator"
        Me.Text = "PID Simulator - Visual Basic"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SimulationSpeedSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimulationTrend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SimulationStartPb As Button
    Friend WithEvents AlarmView As ListView
    Friend WithEvents SimulationStopPb As Button
    Friend WithEvents SimulationSpeedSet As TrackBar
    Friend WithEvents SimulationTrend As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SimulationTimer As Timer
End Class

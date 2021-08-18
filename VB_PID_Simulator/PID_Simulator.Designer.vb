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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SimulationSpeedSet = New System.Windows.Forms.TrackBar()
        Me.SimulationStopPb = New System.Windows.Forms.Button()
        Me.SimulationStartPb = New System.Windows.Forms.Button()
        Me.SimulationTrend = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProcessSettingTimeTb = New System.Windows.Forms.TextBox()
        Me.ProcessGainTb = New System.Windows.Forms.TextBox()
        Me.ProcessOutputTb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProcessInputTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SimulationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.AlarmView = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ControllerModeCb = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SimulationSpeedSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimulationTrend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 1013)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(2, 0, 14, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1478, 32)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(60, 25)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip
        '
        Me.MenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(6, 2, 0, 2)
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
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SimulationSpeedSet)
        Me.Panel1.Controls.Add(Me.SimulationStopPb)
        Me.Panel1.Controls.Add(Me.SimulationStartPb)
        Me.Panel1.Location = New System.Drawing.Point(15, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 149)
        Me.Panel1.TabIndex = 2
        '
        'SimulationSpeedSet
        '
        Me.SimulationSpeedSet.LargeChange = 1
        Me.SimulationSpeedSet.Location = New System.Drawing.Point(15, 69)
        Me.SimulationSpeedSet.Name = "SimulationSpeedSet"
        Me.SimulationSpeedSet.Size = New System.Drawing.Size(320, 69)
        Me.SimulationSpeedSet.TabIndex = 1
        '
        'SimulationStopPb
        '
        Me.SimulationStopPb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimulationStopPb.Location = New System.Drawing.Point(184, 15)
        Me.SimulationStopPb.Name = "SimulationStopPb"
        Me.SimulationStopPb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SimulationStopPb.Size = New System.Drawing.Size(150, 49)
        Me.SimulationStopPb.TabIndex = 0
        Me.SimulationStopPb.Text = "Stop"
        Me.SimulationStopPb.UseVisualStyleBackColor = True
        '
        'SimulationStartPb
        '
        Me.SimulationStartPb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimulationStartPb.Location = New System.Drawing.Point(15, 15)
        Me.SimulationStartPb.Name = "SimulationStartPb"
        Me.SimulationStartPb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SimulationStartPb.Size = New System.Drawing.Size(150, 49)
        Me.SimulationStartPb.TabIndex = 0
        Me.SimulationStartPb.Text = "Start"
        Me.SimulationStartPb.UseVisualStyleBackColor = True
        '
        'SimulationTrend
        '
        ChartArea2.Name = "ChartArea1"
        Me.SimulationTrend.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.SimulationTrend.Legends.Add(Legend2)
        Me.SimulationTrend.Location = New System.Drawing.Point(400, 229)
        Me.SimulationTrend.Name = "SimulationTrend"
        Series4.BorderWidth = 2
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series4.Color = System.Drawing.Color.Blue
        Series4.Legend = "Legend1"
        Series4.Name = "PV"
        Series5.BorderWidth = 2
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series5.Color = System.Drawing.Color.Green
        Series5.Legend = "Legend1"
        Series5.Name = "SP"
        Series6.BorderWidth = 2
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series6.Color = System.Drawing.Color.Red
        Series6.Legend = "Legend1"
        Series6.Name = "OP"
        Me.SimulationTrend.Series.Add(Series4)
        Me.SimulationTrend.Series.Add(Series5)
        Me.SimulationTrend.Series.Add(Series6)
        Me.SimulationTrend.Size = New System.Drawing.Size(1050, 500)
        Me.SimulationTrend.TabIndex = 4
        Me.SimulationTrend.Text = "TrendChart"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProcessSettingTimeTb)
        Me.GroupBox1.Controls.Add(Me.ProcessGainTb)
        Me.GroupBox1.Controls.Add(Me.ProcessOutputTb)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ProcessInputTb)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 229)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 222)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Process Model - First Order"
        '
        'ProcessSettingTimeTb
        '
        Me.ProcessSettingTimeTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessSettingTimeTb.Location = New System.Drawing.Point(232, 160)
        Me.ProcessSettingTimeTb.Name = "ProcessSettingTimeTb"
        Me.ProcessSettingTimeTb.Size = New System.Drawing.Size(100, 30)
        Me.ProcessSettingTimeTb.TabIndex = 1
        Me.ProcessSettingTimeTb.Text = "10.00"
        '
        'ProcessGainTb
        '
        Me.ProcessGainTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessGainTb.Location = New System.Drawing.Point(232, 120)
        Me.ProcessGainTb.Name = "ProcessGainTb"
        Me.ProcessGainTb.Size = New System.Drawing.Size(100, 30)
        Me.ProcessGainTb.TabIndex = 1
        Me.ProcessGainTb.Text = "1.00"
        '
        'ProcessOutputTb
        '
        Me.ProcessOutputTb.BackColor = System.Drawing.Color.White
        Me.ProcessOutputTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessOutputTb.ForeColor = System.Drawing.Color.Black
        Me.ProcessOutputTb.Location = New System.Drawing.Point(232, 80)
        Me.ProcessOutputTb.Name = "ProcessOutputTb"
        Me.ProcessOutputTb.ReadOnly = True
        Me.ProcessOutputTb.Size = New System.Drawing.Size(100, 30)
        Me.ProcessOutputTb.TabIndex = 1
        Me.ProcessOutputTb.Text = "50.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Settling Time (secs)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Process Gain"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Process Output"
        '
        'ProcessInputTb
        '
        Me.ProcessInputTb.BackColor = System.Drawing.Color.White
        Me.ProcessInputTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessInputTb.ForeColor = System.Drawing.Color.Black
        Me.ProcessInputTb.Location = New System.Drawing.Point(232, 40)
        Me.ProcessInputTb.Name = "ProcessInputTb"
        Me.ProcessInputTb.Size = New System.Drawing.Size(100, 30)
        Me.ProcessInputTb.TabIndex = 1
        Me.ProcessInputTb.Text = "50.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Process Input"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ItemSize = New System.Drawing.Size(85, 25)
        Me.TabControl1.Location = New System.Drawing.Point(15, 749)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1446, 249)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(1438, 216)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tuning"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(1438, 216)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Advanced"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SimulationTimer
        '
        Me.SimulationTimer.Interval = 1000
        '
        'AlarmView
        '
        Me.AlarmView.Location = New System.Drawing.Point(400, 49)
        Me.AlarmView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AlarmView.Name = "AlarmView"
        Me.AlarmView.Size = New System.Drawing.Size(1048, 147)
        Me.AlarmView.TabIndex = 7
        Me.AlarmView.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ControllerModeCb)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 462)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 249)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controller"
        '
        'ControllerModeCb
        '
        Me.ControllerModeCb.FormattingEnabled = True
        Me.ControllerModeCb.Items.AddRange(New Object() {"Man", "Auto"})
        Me.ControllerModeCb.Location = New System.Drawing.Point(232, 163)
        Me.ControllerModeCb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ControllerModeCb.Name = "ControllerModeCb"
        Me.ControllerModeCb.Size = New System.Drawing.Size(100, 28)
        Me.ControllerModeCb.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(232, 120)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 30)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "50.00"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(232, 80)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 30)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = "50.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Mode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Output (OP)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Setpoint (SP)"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Black
        Me.TextBox4.Location = New System.Drawing.Point(232, 40)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 30)
        Me.TextBox4.TabIndex = 1
        Me.TextBox4.Text = "50.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Process Value (PV)"
        '
        'PID_Simulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1478, 1045)
        Me.Controls.Add(Me.AlarmView)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SimulationTrend)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "PID_Simulator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents SimulationStopPb As Button
    Friend WithEvents SimulationSpeedSet As TrackBar
    Friend WithEvents SimulationTrend As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ProcessInputTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SimulationTimer As Timer
    Friend WithEvents ProcessOutputTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ProcessGainTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ProcessSettingTimeTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AlarmView As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ControllerModeCb As ComboBox
End Class

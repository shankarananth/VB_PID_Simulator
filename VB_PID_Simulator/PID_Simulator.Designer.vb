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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusSimulation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusDummy1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusSpeed = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimulationControlPanel = New System.Windows.Forms.Panel()
        Me.SimulationSpeedSet = New System.Windows.Forms.TrackBar()
        Me.SimulationStopPb = New System.Windows.Forms.Button()
        Me.SimulationStartPb = New System.Windows.Forms.Button()
        Me.SimulationTrend = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ProcessModelGroupBox = New System.Windows.Forms.GroupBox()
        Me.ProcessSettingTimeTb = New System.Windows.Forms.TextBox()
        Me.ProcessGainTb = New System.Windows.Forms.TextBox()
        Me.ProcessOutputTb = New System.Windows.Forms.TextBox()
        Me.ProcessModelSettlingTimeLabel = New System.Windows.Forms.Label()
        Me.ProcessModelGainLabel = New System.Windows.Forms.Label()
        Me.ProcessModelOutputLabel = New System.Windows.Forms.Label()
        Me.ProcessInputTb = New System.Windows.Forms.TextBox()
        Me.ProcessModelInputLabel = New System.Windows.Forms.Label()
        Me.TuningTabControl = New System.Windows.Forms.TabControl()
        Me.TuningTabPage = New System.Windows.Forms.TabPage()
        Me.TuningAdvancedTabPage = New System.Windows.Forms.TabPage()
        Me.SimulationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MessageView = New System.Windows.Forms.RichTextBox()
        Me.ControllerGroupBox = New System.Windows.Forms.GroupBox()
        Me.ControllerModeCb = New System.Windows.Forms.ComboBox()
        Me.ControllerOpTb = New System.Windows.Forms.TextBox()
        Me.ControllerSpTb = New System.Windows.Forms.TextBox()
        Me.ControllerModeLabel = New System.Windows.Forms.Label()
        Me.ControllerOpLabel = New System.Windows.Forms.Label()
        Me.ControllerSpLabel = New System.Windows.Forms.Label()
        Me.ControllerPvTb = New System.Windows.Forms.TextBox()
        Me.ControllerPvLabel = New System.Windows.Forms.Label()
        Me.MessageViewClearPb = New System.Windows.Forms.Button()
        Me.ControllerGainLabel = New System.Windows.Forms.Label()
        Me.ControllerGainTb = New System.Windows.Forms.TextBox()
        Me.ControllerIntegralTb = New System.Windows.Forms.TextBox()
        Me.ControllerIntegralLabel = New System.Windows.Forms.Label()
        Me.ControllerDerivativeTb = New System.Windows.Forms.TextBox()
        Me.ControllerDerivativeLabel = New System.Windows.Forms.Label()
        Me.ControllerPvTracking = New System.Windows.Forms.TrackBar()
        Me.ControllerDirection = New System.Windows.Forms.TrackBar()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SimulationControlPanel.SuspendLayout()
        CType(Me.SimulationSpeedSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimulationTrend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProcessModelGroupBox.SuspendLayout()
        Me.TuningTabControl.SuspendLayout()
        Me.TuningTabPage.SuspendLayout()
        Me.ControllerGroupBox.SuspendLayout()
        CType(Me.ControllerPvTracking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControllerDirection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusSimulation, Me.ToolStripStatusDummy1, Me.ToolStripStatusSpeed})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 657)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(985, 22)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusSimulation
        '
        Me.ToolStripStatusSimulation.Name = "ToolStripStatusSimulation"
        Me.ToolStripStatusSimulation.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusSimulation.Text = "Status"
        '
        'ToolStripStatusDummy1
        '
        Me.ToolStripStatusDummy1.Name = "ToolStripStatusDummy1"
        Me.ToolStripStatusDummy1.Size = New System.Drawing.Size(73, 17)
        Me.ToolStripStatusDummy1.Text = "                      "
        '
        'ToolStripStatusSpeed
        '
        Me.ToolStripStatusSpeed.Name = "ToolStripStatusSpeed"
        Me.ToolStripStatusSpeed.Size = New System.Drawing.Size(176, 17)
        Me.ToolStripStatusSpeed.Text = "Simulation Speed = 1x (1000ms)"
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip.Size = New System.Drawing.Size(985, 24)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 22)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SimulationControlPanel
        '
        Me.SimulationControlPanel.Controls.Add(Me.SimulationSpeedSet)
        Me.SimulationControlPanel.Controls.Add(Me.SimulationStopPb)
        Me.SimulationControlPanel.Controls.Add(Me.SimulationStartPb)
        Me.SimulationControlPanel.Location = New System.Drawing.Point(10, 32)
        Me.SimulationControlPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SimulationControlPanel.Name = "SimulationControlPanel"
        Me.SimulationControlPanel.Size = New System.Drawing.Size(233, 97)
        Me.SimulationControlPanel.TabIndex = 2
        '
        'SimulationSpeedSet
        '
        Me.SimulationSpeedSet.LargeChange = 1
        Me.SimulationSpeedSet.Location = New System.Drawing.Point(10, 45)
        Me.SimulationSpeedSet.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SimulationSpeedSet.Minimum = 1
        Me.SimulationSpeedSet.Name = "SimulationSpeedSet"
        Me.SimulationSpeedSet.Size = New System.Drawing.Size(213, 45)
        Me.SimulationSpeedSet.TabIndex = 1
        Me.SimulationSpeedSet.Value = 1
        '
        'SimulationStopPb
        '
        Me.SimulationStopPb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimulationStopPb.Location = New System.Drawing.Point(123, 10)
        Me.SimulationStopPb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SimulationStopPb.Name = "SimulationStopPb"
        Me.SimulationStopPb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SimulationStopPb.Size = New System.Drawing.Size(100, 32)
        Me.SimulationStopPb.TabIndex = 0
        Me.SimulationStopPb.Text = "Stop"
        Me.SimulationStopPb.UseVisualStyleBackColor = True
        '
        'SimulationStartPb
        '
        Me.SimulationStartPb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimulationStartPb.Location = New System.Drawing.Point(10, 10)
        Me.SimulationStartPb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SimulationStartPb.Name = "SimulationStartPb"
        Me.SimulationStartPb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SimulationStartPb.Size = New System.Drawing.Size(100, 32)
        Me.SimulationStartPb.TabIndex = 0
        Me.SimulationStartPb.Text = "Start"
        Me.SimulationStartPb.UseVisualStyleBackColor = True
        '
        'SimulationTrend
        '
        ChartArea1.Name = "ChartArea1"
        Me.SimulationTrend.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.SimulationTrend.Legends.Add(Legend1)
        Me.SimulationTrend.Location = New System.Drawing.Point(265, 150)
        Me.SimulationTrend.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SimulationTrend.Name = "SimulationTrend"
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series1.Color = System.Drawing.Color.Blue
        Series1.Legend = "Legend1"
        Series1.Name = "PV"
        Series2.BorderWidth = 2
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series2.Color = System.Drawing.Color.Green
        Series2.Legend = "Legend1"
        Series2.Name = "SP"
        Series3.BorderWidth = 2
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series3.Color = System.Drawing.Color.Red
        Series3.Legend = "Legend1"
        Series3.Name = "OP"
        Me.SimulationTrend.Series.Add(Series1)
        Me.SimulationTrend.Series.Add(Series2)
        Me.SimulationTrend.Series.Add(Series3)
        Me.SimulationTrend.Size = New System.Drawing.Size(700, 325)
        Me.SimulationTrend.TabIndex = 4
        Me.SimulationTrend.Text = "TrendChart"
        '
        'ProcessModelGroupBox
        '
        Me.ProcessModelGroupBox.Controls.Add(Me.ProcessSettingTimeTb)
        Me.ProcessModelGroupBox.Controls.Add(Me.ProcessGainTb)
        Me.ProcessModelGroupBox.Controls.Add(Me.ProcessOutputTb)
        Me.ProcessModelGroupBox.Controls.Add(Me.ProcessModelSettlingTimeLabel)
        Me.ProcessModelGroupBox.Controls.Add(Me.ProcessModelGainLabel)
        Me.ProcessModelGroupBox.Controls.Add(Me.ProcessModelOutputLabel)
        Me.ProcessModelGroupBox.Controls.Add(Me.ProcessInputTb)
        Me.ProcessModelGroupBox.Controls.Add(Me.ProcessModelInputLabel)
        Me.ProcessModelGroupBox.Location = New System.Drawing.Point(10, 150)
        Me.ProcessModelGroupBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProcessModelGroupBox.Name = "ProcessModelGroupBox"
        Me.ProcessModelGroupBox.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProcessModelGroupBox.Size = New System.Drawing.Size(233, 144)
        Me.ProcessModelGroupBox.TabIndex = 5
        Me.ProcessModelGroupBox.TabStop = False
        Me.ProcessModelGroupBox.Text = "Process Model - First Order"
        '
        'ProcessSettingTimeTb
        '
        Me.ProcessSettingTimeTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessSettingTimeTb.Location = New System.Drawing.Point(155, 104)
        Me.ProcessSettingTimeTb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProcessSettingTimeTb.Name = "ProcessSettingTimeTb"
        Me.ProcessSettingTimeTb.Size = New System.Drawing.Size(68, 23)
        Me.ProcessSettingTimeTb.TabIndex = 1
        Me.ProcessSettingTimeTb.Text = "10"
        '
        'ProcessGainTb
        '
        Me.ProcessGainTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessGainTb.Location = New System.Drawing.Point(155, 78)
        Me.ProcessGainTb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProcessGainTb.Name = "ProcessGainTb"
        Me.ProcessGainTb.Size = New System.Drawing.Size(68, 23)
        Me.ProcessGainTb.TabIndex = 1
        Me.ProcessGainTb.Text = "1.00"
        '
        'ProcessOutputTb
        '
        Me.ProcessOutputTb.BackColor = System.Drawing.Color.White
        Me.ProcessOutputTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessOutputTb.ForeColor = System.Drawing.Color.Black
        Me.ProcessOutputTb.Location = New System.Drawing.Point(155, 52)
        Me.ProcessOutputTb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProcessOutputTb.Name = "ProcessOutputTb"
        Me.ProcessOutputTb.ReadOnly = True
        Me.ProcessOutputTb.Size = New System.Drawing.Size(68, 23)
        Me.ProcessOutputTb.TabIndex = 1
        Me.ProcessOutputTb.Text = "50.00"
        '
        'ProcessModelSettlingTimeLabel
        '
        Me.ProcessModelSettlingTimeLabel.AutoSize = True
        Me.ProcessModelSettlingTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessModelSettlingTimeLabel.Location = New System.Drawing.Point(7, 104)
        Me.ProcessModelSettlingTimeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ProcessModelSettlingTimeLabel.Name = "ProcessModelSettlingTimeLabel"
        Me.ProcessModelSettlingTimeLabel.Size = New System.Drawing.Size(133, 17)
        Me.ProcessModelSettlingTimeLabel.TabIndex = 0
        Me.ProcessModelSettlingTimeLabel.Text = "Settling Time (secs)"
        '
        'ProcessModelGainLabel
        '
        Me.ProcessModelGainLabel.AutoSize = True
        Me.ProcessModelGainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessModelGainLabel.Location = New System.Drawing.Point(7, 78)
        Me.ProcessModelGainLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ProcessModelGainLabel.Name = "ProcessModelGainLabel"
        Me.ProcessModelGainLabel.Size = New System.Drawing.Size(93, 17)
        Me.ProcessModelGainLabel.TabIndex = 0
        Me.ProcessModelGainLabel.Text = "Process Gain"
        '
        'ProcessModelOutputLabel
        '
        Me.ProcessModelOutputLabel.AutoSize = True
        Me.ProcessModelOutputLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessModelOutputLabel.Location = New System.Drawing.Point(7, 52)
        Me.ProcessModelOutputLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ProcessModelOutputLabel.Name = "ProcessModelOutputLabel"
        Me.ProcessModelOutputLabel.Size = New System.Drawing.Size(106, 17)
        Me.ProcessModelOutputLabel.TabIndex = 0
        Me.ProcessModelOutputLabel.Text = "Process Output"
        '
        'ProcessInputTb
        '
        Me.ProcessInputTb.BackColor = System.Drawing.Color.White
        Me.ProcessInputTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessInputTb.ForeColor = System.Drawing.Color.Black
        Me.ProcessInputTb.Location = New System.Drawing.Point(155, 26)
        Me.ProcessInputTb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProcessInputTb.Name = "ProcessInputTb"
        Me.ProcessInputTb.ReadOnly = True
        Me.ProcessInputTb.Size = New System.Drawing.Size(68, 23)
        Me.ProcessInputTb.TabIndex = 1
        Me.ProcessInputTb.Text = "50.00"
        '
        'ProcessModelInputLabel
        '
        Me.ProcessModelInputLabel.AutoSize = True
        Me.ProcessModelInputLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessModelInputLabel.Location = New System.Drawing.Point(7, 26)
        Me.ProcessModelInputLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ProcessModelInputLabel.Name = "ProcessModelInputLabel"
        Me.ProcessModelInputLabel.Size = New System.Drawing.Size(94, 17)
        Me.ProcessModelInputLabel.TabIndex = 0
        Me.ProcessModelInputLabel.Text = "Process Input"
        '
        'TuningTabControl
        '
        Me.TuningTabControl.Controls.Add(Me.TuningTabPage)
        Me.TuningTabControl.Controls.Add(Me.TuningAdvancedTabPage)
        Me.TuningTabControl.ItemSize = New System.Drawing.Size(85, 25)
        Me.TuningTabControl.Location = New System.Drawing.Point(10, 487)
        Me.TuningTabControl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TuningTabControl.Name = "TuningTabControl"
        Me.TuningTabControl.SelectedIndex = 0
        Me.TuningTabControl.Size = New System.Drawing.Size(964, 162)
        Me.TuningTabControl.TabIndex = 6
        '
        'TuningTabPage
        '
        Me.TuningTabPage.Controls.Add(Me.ControllerPvTracking)
        Me.TuningTabPage.Controls.Add(Me.ControllerDirection)
        Me.TuningTabPage.Controls.Add(Me.ControllerDerivativeLabel)
        Me.TuningTabPage.Controls.Add(Me.ControllerIntegralLabel)
        Me.TuningTabPage.Controls.Add(Me.ControllerGainLabel)
        Me.TuningTabPage.Controls.Add(Me.ControllerDerivativeTb)
        Me.TuningTabPage.Controls.Add(Me.ControllerIntegralTb)
        Me.TuningTabPage.Controls.Add(Me.ControllerGainTb)
        Me.TuningTabPage.Location = New System.Drawing.Point(4, 29)
        Me.TuningTabPage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TuningTabPage.Name = "TuningTabPage"
        Me.TuningTabPage.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TuningTabPage.Size = New System.Drawing.Size(956, 129)
        Me.TuningTabPage.TabIndex = 0
        Me.TuningTabPage.Text = "Tuning"
        Me.TuningTabPage.UseVisualStyleBackColor = True
        '
        'TuningAdvancedTabPage
        '
        Me.TuningAdvancedTabPage.Location = New System.Drawing.Point(4, 29)
        Me.TuningAdvancedTabPage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TuningAdvancedTabPage.Name = "TuningAdvancedTabPage"
        Me.TuningAdvancedTabPage.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TuningAdvancedTabPage.Size = New System.Drawing.Size(956, 129)
        Me.TuningAdvancedTabPage.TabIndex = 1
        Me.TuningAdvancedTabPage.Text = "Advanced"
        Me.TuningAdvancedTabPage.UseVisualStyleBackColor = True
        '
        'SimulationTimer
        '
        Me.SimulationTimer.Interval = 1000
        '
        'MessageView
        '
        Me.MessageView.Location = New System.Drawing.Point(265, 32)
        Me.MessageView.Name = "MessageView"
        Me.MessageView.Size = New System.Drawing.Size(580, 100)
        Me.MessageView.TabIndex = 7
        Me.MessageView.Text = ""
        '
        'ControllerGroupBox
        '
        Me.ControllerGroupBox.Controls.Add(Me.ControllerModeCb)
        Me.ControllerGroupBox.Controls.Add(Me.ControllerOpTb)
        Me.ControllerGroupBox.Controls.Add(Me.ControllerSpTb)
        Me.ControllerGroupBox.Controls.Add(Me.ControllerModeLabel)
        Me.ControllerGroupBox.Controls.Add(Me.ControllerOpLabel)
        Me.ControllerGroupBox.Controls.Add(Me.ControllerSpLabel)
        Me.ControllerGroupBox.Controls.Add(Me.ControllerPvTb)
        Me.ControllerGroupBox.Controls.Add(Me.ControllerPvLabel)
        Me.ControllerGroupBox.Location = New System.Drawing.Point(10, 300)
        Me.ControllerGroupBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ControllerGroupBox.Name = "ControllerGroupBox"
        Me.ControllerGroupBox.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ControllerGroupBox.Size = New System.Drawing.Size(233, 174)
        Me.ControllerGroupBox.TabIndex = 5
        Me.ControllerGroupBox.TabStop = False
        Me.ControllerGroupBox.Text = "Controller"
        '
        'ControllerModeCb
        '
        Me.ControllerModeCb.FormattingEnabled = True
        Me.ControllerModeCb.Items.AddRange(New Object() {"Auto", "Man"})
        Me.ControllerModeCb.Location = New System.Drawing.Point(155, 104)
        Me.ControllerModeCb.Name = "ControllerModeCb"
        Me.ControllerModeCb.Size = New System.Drawing.Size(68, 21)
        Me.ControllerModeCb.TabIndex = 2
        '
        'ControllerOpTb
        '
        Me.ControllerOpTb.BackColor = System.Drawing.Color.Gold
        Me.ControllerOpTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerOpTb.Location = New System.Drawing.Point(155, 78)
        Me.ControllerOpTb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ControllerOpTb.Name = "ControllerOpTb"
        Me.ControllerOpTb.Size = New System.Drawing.Size(68, 23)
        Me.ControllerOpTb.TabIndex = 1
        Me.ControllerOpTb.Text = "50.00"
        '
        'ControllerSpTb
        '
        Me.ControllerSpTb.BackColor = System.Drawing.Color.Gold
        Me.ControllerSpTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerSpTb.ForeColor = System.Drawing.Color.Black
        Me.ControllerSpTb.Location = New System.Drawing.Point(155, 52)
        Me.ControllerSpTb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ControllerSpTb.Name = "ControllerSpTb"
        Me.ControllerSpTb.Size = New System.Drawing.Size(68, 23)
        Me.ControllerSpTb.TabIndex = 1
        Me.ControllerSpTb.Text = "50.00"
        '
        'ControllerModeLabel
        '
        Me.ControllerModeLabel.AutoSize = True
        Me.ControllerModeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerModeLabel.Location = New System.Drawing.Point(7, 104)
        Me.ControllerModeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ControllerModeLabel.Name = "ControllerModeLabel"
        Me.ControllerModeLabel.Size = New System.Drawing.Size(43, 17)
        Me.ControllerModeLabel.TabIndex = 0
        Me.ControllerModeLabel.Text = "Mode"
        '
        'ControllerOpLabel
        '
        Me.ControllerOpLabel.AutoSize = True
        Me.ControllerOpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerOpLabel.Location = New System.Drawing.Point(7, 78)
        Me.ControllerOpLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ControllerOpLabel.Name = "ControllerOpLabel"
        Me.ControllerOpLabel.Size = New System.Drawing.Size(85, 17)
        Me.ControllerOpLabel.TabIndex = 0
        Me.ControllerOpLabel.Text = "Output (OP)"
        '
        'ControllerSpLabel
        '
        Me.ControllerSpLabel.AutoSize = True
        Me.ControllerSpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerSpLabel.Location = New System.Drawing.Point(7, 52)
        Me.ControllerSpLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ControllerSpLabel.Name = "ControllerSpLabel"
        Me.ControllerSpLabel.Size = New System.Drawing.Size(92, 17)
        Me.ControllerSpLabel.TabIndex = 0
        Me.ControllerSpLabel.Text = "Setpoint (SP)"
        '
        'ControllerPvTb
        '
        Me.ControllerPvTb.BackColor = System.Drawing.Color.White
        Me.ControllerPvTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerPvTb.ForeColor = System.Drawing.Color.Black
        Me.ControllerPvTb.Location = New System.Drawing.Point(155, 26)
        Me.ControllerPvTb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ControllerPvTb.Name = "ControllerPvTb"
        Me.ControllerPvTb.ReadOnly = True
        Me.ControllerPvTb.Size = New System.Drawing.Size(68, 23)
        Me.ControllerPvTb.TabIndex = 1
        Me.ControllerPvTb.Text = "50.00"
        '
        'ControllerPvLabel
        '
        Me.ControllerPvLabel.AutoSize = True
        Me.ControllerPvLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerPvLabel.Location = New System.Drawing.Point(7, 26)
        Me.ControllerPvLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ControllerPvLabel.Name = "ControllerPvLabel"
        Me.ControllerPvLabel.Size = New System.Drawing.Size(131, 17)
        Me.ControllerPvLabel.TabIndex = 0
        Me.ControllerPvLabel.Text = "Process Value (PV)"
        '
        'MessageViewClearPb
        '
        Me.MessageViewClearPb.Location = New System.Drawing.Point(860, 100)
        Me.MessageViewClearPb.Name = "MessageViewClearPb"
        Me.MessageViewClearPb.Size = New System.Drawing.Size(100, 25)
        Me.MessageViewClearPb.TabIndex = 8
        Me.MessageViewClearPb.Text = "Clear Messages"
        Me.MessageViewClearPb.UseVisualStyleBackColor = True
        '
        'ControllerGainLabel
        '
        Me.ControllerGainLabel.AutoSize = True
        Me.ControllerGainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerGainLabel.Location = New System.Drawing.Point(7, 16)
        Me.ControllerGainLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ControllerGainLabel.Name = "ControllerGainLabel"
        Me.ControllerGainLabel.Size = New System.Drawing.Size(119, 17)
        Me.ControllerGainLabel.TabIndex = 0
        Me.ControllerGainLabel.Text = "Proportional Gain"
        '
        'ControllerGainTb
        '
        Me.ControllerGainTb.BackColor = System.Drawing.Color.White
        Me.ControllerGainTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerGainTb.ForeColor = System.Drawing.Color.Black
        Me.ControllerGainTb.Location = New System.Drawing.Point(151, 13)
        Me.ControllerGainTb.Margin = New System.Windows.Forms.Padding(2)
        Me.ControllerGainTb.Name = "ControllerGainTb"
        Me.ControllerGainTb.ReadOnly = True
        Me.ControllerGainTb.Size = New System.Drawing.Size(50, 23)
        Me.ControllerGainTb.TabIndex = 1
        Me.ControllerGainTb.Text = "1"
        '
        'ControllerIntegralTb
        '
        Me.ControllerIntegralTb.BackColor = System.Drawing.Color.White
        Me.ControllerIntegralTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerIntegralTb.ForeColor = System.Drawing.Color.Black
        Me.ControllerIntegralTb.Location = New System.Drawing.Point(151, 53)
        Me.ControllerIntegralTb.Margin = New System.Windows.Forms.Padding(2)
        Me.ControllerIntegralTb.Name = "ControllerIntegralTb"
        Me.ControllerIntegralTb.ReadOnly = True
        Me.ControllerIntegralTb.Size = New System.Drawing.Size(50, 23)
        Me.ControllerIntegralTb.TabIndex = 1
        Me.ControllerIntegralTb.Text = "10"
        '
        'ControllerIntegralLabel
        '
        Me.ControllerIntegralLabel.AutoSize = True
        Me.ControllerIntegralLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerIntegralLabel.Location = New System.Drawing.Point(7, 56)
        Me.ControllerIntegralLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ControllerIntegralLabel.Name = "ControllerIntegralLabel"
        Me.ControllerIntegralLabel.Size = New System.Drawing.Size(90, 17)
        Me.ControllerIntegralLabel.TabIndex = 0
        Me.ControllerIntegralLabel.Text = "Integral Time"
        '
        'ControllerDerivativeTb
        '
        Me.ControllerDerivativeTb.BackColor = System.Drawing.Color.White
        Me.ControllerDerivativeTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerDerivativeTb.ForeColor = System.Drawing.Color.Black
        Me.ControllerDerivativeTb.Location = New System.Drawing.Point(151, 93)
        Me.ControllerDerivativeTb.Margin = New System.Windows.Forms.Padding(2)
        Me.ControllerDerivativeTb.Name = "ControllerDerivativeTb"
        Me.ControllerDerivativeTb.ReadOnly = True
        Me.ControllerDerivativeTb.Size = New System.Drawing.Size(50, 23)
        Me.ControllerDerivativeTb.TabIndex = 1
        Me.ControllerDerivativeTb.Text = "0"
        '
        'ControllerDerivativeLabel
        '
        Me.ControllerDerivativeLabel.AutoSize = True
        Me.ControllerDerivativeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerDerivativeLabel.Location = New System.Drawing.Point(7, 96)
        Me.ControllerDerivativeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ControllerDerivativeLabel.Name = "ControllerDerivativeLabel"
        Me.ControllerDerivativeLabel.Size = New System.Drawing.Size(106, 17)
        Me.ControllerDerivativeLabel.TabIndex = 0
        Me.ControllerDerivativeLabel.Text = "Derivative Time"
        '
        'ControllerPvTracking
        '
        Me.ControllerPvTracking.LargeChange = 1
        Me.ControllerPvTracking.Location = New System.Drawing.Point(251, 70)
        Me.ControllerPvTracking.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ControllerPvTracking.Maximum = 2
        Me.ControllerPvTracking.Minimum = 1
        Me.ControllerPvTracking.Name = "ControllerPvTracking"
        Me.ControllerPvTracking.Size = New System.Drawing.Size(57, 45)
        Me.ControllerPvTracking.TabIndex = 6
        Me.ControllerPvTracking.Value = 1
        '
        'ControllerDirection
        '
        Me.ControllerDirection.LargeChange = 2
        Me.ControllerDirection.Location = New System.Drawing.Point(251, 13)
        Me.ControllerDirection.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ControllerDirection.Maximum = 1
        Me.ControllerDirection.Minimum = -1
        Me.ControllerDirection.Name = "ControllerDirection"
        Me.ControllerDirection.Size = New System.Drawing.Size(57, 45)
        Me.ControllerDirection.SmallChange = 2
        Me.ControllerDirection.TabIndex = 7
        Me.ControllerDirection.Value = 1
        '
        'PID_Simulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 679)
        Me.Controls.Add(Me.MessageViewClearPb)
        Me.Controls.Add(Me.MessageView)
        Me.Controls.Add(Me.TuningTabControl)
        Me.Controls.Add(Me.ControllerGroupBox)
        Me.Controls.Add(Me.ProcessModelGroupBox)
        Me.Controls.Add(Me.SimulationTrend)
        Me.Controls.Add(Me.SimulationControlPanel)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "PID_Simulator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " PID Simulator"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.SimulationControlPanel.ResumeLayout(False)
        Me.SimulationControlPanel.PerformLayout()
        CType(Me.SimulationSpeedSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimulationTrend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProcessModelGroupBox.ResumeLayout(False)
        Me.ProcessModelGroupBox.PerformLayout()
        Me.TuningTabControl.ResumeLayout(False)
        Me.TuningTabPage.ResumeLayout(False)
        Me.TuningTabPage.PerformLayout()
        Me.ControllerGroupBox.ResumeLayout(False)
        Me.ControllerGroupBox.PerformLayout()
        CType(Me.ControllerPvTracking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControllerDirection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusSimulation As ToolStripStatusLabel
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimulationControlPanel As Panel
    Friend WithEvents SimulationStartPb As Button
    Friend WithEvents SimulationStopPb As Button
    Friend WithEvents SimulationSpeedSet As TrackBar
    Friend WithEvents SimulationTrend As DataVisualization.Charting.Chart
    Friend WithEvents ProcessModelGroupBox As GroupBox
    Friend WithEvents TuningTabControl As TabControl
    Friend WithEvents TuningTabPage As TabPage
    Friend WithEvents TuningAdvancedTabPage As TabPage
    Friend WithEvents ProcessInputTb As TextBox
    Friend WithEvents ProcessModelInputLabel As Label
    Friend WithEvents SimulationTimer As Timer
    Friend WithEvents ProcessOutputTb As TextBox
    Friend WithEvents ProcessModelOutputLabel As Label
    Friend WithEvents ProcessGainTb As TextBox
    Friend WithEvents ProcessModelGainLabel As Label
    Friend WithEvents ProcessSettingTimeTb As TextBox
    Friend WithEvents ProcessModelSettlingTimeLabel As Label
    Friend WithEvents MessageView As RichTextBox
    Friend WithEvents ControllerGroupBox As GroupBox
    Friend WithEvents ControllerOpTb As TextBox
    Friend WithEvents ControllerSpTb As TextBox
    Friend WithEvents ControllerModeLabel As Label
    Friend WithEvents ControllerOpLabel As Label
    Friend WithEvents ControllerSpLabel As Label
    Friend WithEvents ControllerPvTb As TextBox
    Friend WithEvents ControllerPvLabel As Label
    Friend WithEvents ControllerModeCb As ComboBox
    Friend WithEvents MessageViewClearPb As Button
    Friend WithEvents ToolStripStatusDummy1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusSpeed As ToolStripStatusLabel
    Friend WithEvents ControllerGainLabel As Label
    Friend WithEvents ControllerGainTb As TextBox
    Friend WithEvents ControllerDerivativeLabel As Label
    Friend WithEvents ControllerIntegralLabel As Label
    Friend WithEvents ControllerDerivativeTb As TextBox
    Friend WithEvents ControllerIntegralTb As TextBox
    Friend WithEvents ControllerPvTracking As TrackBar
    Friend WithEvents ControllerDirection As TrackBar
End Class

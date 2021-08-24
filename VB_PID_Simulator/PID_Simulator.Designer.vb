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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PID_Simulator))
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
        Me.ControllerPvTrackingTrkb = New System.Windows.Forms.TrackBar()
        Me.ControllerDirectionTrkb = New System.Windows.Forms.TrackBar()
        Me.ControllerDerivativeLabel = New System.Windows.Forms.Label()
        Me.ControllerOpHighLabel = New System.Windows.Forms.Label()
        Me.ControllerSpHighLabel = New System.Windows.Forms.Label()
        Me.ControllerIntegralLabel = New System.Windows.Forms.Label()
        Me.ControllerOpLowLabel = New System.Windows.Forms.Label()
        Me.ControllerSpLowLabel = New System.Windows.Forms.Label()
        Me.ControllerDirectionLabel = New System.Windows.Forms.Label()
        Me.ControllerPVTrackingLabel = New System.Windows.Forms.Label()
        Me.ControllerGainLabel = New System.Windows.Forms.Label()
        Me.ControllerOpHighTb = New System.Windows.Forms.TextBox()
        Me.ControllerSpHighTb = New System.Windows.Forms.TextBox()
        Me.ControllerOpLowTb = New System.Windows.Forms.TextBox()
        Me.ControllerDerivativeTb = New System.Windows.Forms.TextBox()
        Me.ControllerSpLowTb = New System.Windows.Forms.TextBox()
        Me.ControllerIntegralTb = New System.Windows.Forms.TextBox()
        Me.ControllerGainTb = New System.Windows.Forms.TextBox()
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
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SimulationControlPanel.SuspendLayout()
        CType(Me.SimulationSpeedSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimulationTrend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProcessModelGroupBox.SuspendLayout()
        Me.TuningTabControl.SuspendLayout()
        Me.TuningTabPage.SuspendLayout()
        CType(Me.ControllerPvTrackingTrkb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControllerDirectionTrkb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ControllerGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusSimulation, Me.ToolStripStatusDummy1, Me.ToolStripStatusSpeed})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 1013)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(2, 0, 14, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1478, 32)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusSimulation
        '
        Me.ToolStripStatusSimulation.Name = "ToolStripStatusSimulation"
        Me.ToolStripStatusSimulation.Size = New System.Drawing.Size(60, 25)
        Me.ToolStripStatusSimulation.Text = "Status"
        '
        'ToolStripStatusDummy1
        '
        Me.ToolStripStatusDummy1.Name = "ToolStripStatusDummy1"
        Me.ToolStripStatusDummy1.Size = New System.Drawing.Size(122, 25)
        Me.ToolStripStatusDummy1.Text = "                      "
        '
        'ToolStripStatusSpeed
        '
        Me.ToolStripStatusSpeed.Name = "ToolStripStatusSpeed"
        Me.ToolStripStatusSpeed.Size = New System.Drawing.Size(270, 25)
        Me.ToolStripStatusSpeed.Text = "Simulation Speed = 1x (1000ms)"
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
        'SimulationControlPanel
        '
        Me.SimulationControlPanel.Controls.Add(Me.SimulationSpeedSet)
        Me.SimulationControlPanel.Controls.Add(Me.SimulationStopPb)
        Me.SimulationControlPanel.Controls.Add(Me.SimulationStartPb)
        Me.SimulationControlPanel.Location = New System.Drawing.Point(15, 49)
        Me.SimulationControlPanel.Name = "SimulationControlPanel"
        Me.SimulationControlPanel.Size = New System.Drawing.Size(350, 149)
        Me.SimulationControlPanel.TabIndex = 2
        '
        'SimulationSpeedSet
        '
        Me.SimulationSpeedSet.LargeChange = 1
        Me.SimulationSpeedSet.Location = New System.Drawing.Point(15, 69)
        Me.SimulationSpeedSet.Minimum = 1
        Me.SimulationSpeedSet.Name = "SimulationSpeedSet"
        Me.SimulationSpeedSet.Size = New System.Drawing.Size(320, 69)
        Me.SimulationSpeedSet.TabIndex = 1
        Me.SimulationSpeedSet.Value = 1
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
        ChartArea1.Name = "ChartArea1"
        Me.SimulationTrend.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.SimulationTrend.Legends.Add(Legend1)
        Me.SimulationTrend.Location = New System.Drawing.Point(398, 231)
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
        Me.SimulationTrend.Size = New System.Drawing.Size(1050, 500)
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
        Me.ProcessModelGroupBox.Location = New System.Drawing.Point(15, 231)
        Me.ProcessModelGroupBox.Name = "ProcessModelGroupBox"
        Me.ProcessModelGroupBox.Size = New System.Drawing.Size(350, 222)
        Me.ProcessModelGroupBox.TabIndex = 5
        Me.ProcessModelGroupBox.TabStop = False
        Me.ProcessModelGroupBox.Text = "Process Model - First Order"
        '
        'ProcessSettingTimeTb
        '
        Me.ProcessSettingTimeTb.BackColor = System.Drawing.Color.Gold
        Me.ProcessSettingTimeTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessSettingTimeTb.Location = New System.Drawing.Point(232, 160)
        Me.ProcessSettingTimeTb.Name = "ProcessSettingTimeTb"
        Me.ProcessSettingTimeTb.Size = New System.Drawing.Size(100, 30)
        Me.ProcessSettingTimeTb.TabIndex = 1
        Me.ProcessSettingTimeTb.Text = "10"
        '
        'ProcessGainTb
        '
        Me.ProcessGainTb.BackColor = System.Drawing.Color.Gold
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
        'ProcessModelSettlingTimeLabel
        '
        Me.ProcessModelSettlingTimeLabel.AutoSize = True
        Me.ProcessModelSettlingTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessModelSettlingTimeLabel.Location = New System.Drawing.Point(10, 160)
        Me.ProcessModelSettlingTimeLabel.Name = "ProcessModelSettlingTimeLabel"
        Me.ProcessModelSettlingTimeLabel.Size = New System.Drawing.Size(186, 25)
        Me.ProcessModelSettlingTimeLabel.TabIndex = 0
        Me.ProcessModelSettlingTimeLabel.Text = "Settling Time (secs)"
        '
        'ProcessModelGainLabel
        '
        Me.ProcessModelGainLabel.AutoSize = True
        Me.ProcessModelGainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessModelGainLabel.Location = New System.Drawing.Point(10, 120)
        Me.ProcessModelGainLabel.Name = "ProcessModelGainLabel"
        Me.ProcessModelGainLabel.Size = New System.Drawing.Size(129, 25)
        Me.ProcessModelGainLabel.TabIndex = 0
        Me.ProcessModelGainLabel.Text = "Process Gain"
        '
        'ProcessModelOutputLabel
        '
        Me.ProcessModelOutputLabel.AutoSize = True
        Me.ProcessModelOutputLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessModelOutputLabel.Location = New System.Drawing.Point(10, 80)
        Me.ProcessModelOutputLabel.Name = "ProcessModelOutputLabel"
        Me.ProcessModelOutputLabel.Size = New System.Drawing.Size(147, 25)
        Me.ProcessModelOutputLabel.TabIndex = 0
        Me.ProcessModelOutputLabel.Text = "Process Output"
        '
        'ProcessInputTb
        '
        Me.ProcessInputTb.BackColor = System.Drawing.Color.White
        Me.ProcessInputTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessInputTb.ForeColor = System.Drawing.Color.Black
        Me.ProcessInputTb.Location = New System.Drawing.Point(232, 40)
        Me.ProcessInputTb.Name = "ProcessInputTb"
        Me.ProcessInputTb.ReadOnly = True
        Me.ProcessInputTb.Size = New System.Drawing.Size(100, 30)
        Me.ProcessInputTb.TabIndex = 1
        Me.ProcessInputTb.Text = "50.00"
        '
        'ProcessModelInputLabel
        '
        Me.ProcessModelInputLabel.AutoSize = True
        Me.ProcessModelInputLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessModelInputLabel.Location = New System.Drawing.Point(10, 40)
        Me.ProcessModelInputLabel.Name = "ProcessModelInputLabel"
        Me.ProcessModelInputLabel.Size = New System.Drawing.Size(131, 25)
        Me.ProcessModelInputLabel.TabIndex = 0
        Me.ProcessModelInputLabel.Text = "Process Input"
        '
        'TuningTabControl
        '
        Me.TuningTabControl.Controls.Add(Me.TuningTabPage)
        Me.TuningTabControl.Controls.Add(Me.TuningAdvancedTabPage)
        Me.TuningTabControl.ItemSize = New System.Drawing.Size(85, 25)
        Me.TuningTabControl.Location = New System.Drawing.Point(15, 749)
        Me.TuningTabControl.Name = "TuningTabControl"
        Me.TuningTabControl.SelectedIndex = 0
        Me.TuningTabControl.Size = New System.Drawing.Size(1446, 249)
        Me.TuningTabControl.TabIndex = 6
        '
        'TuningTabPage
        '
        Me.TuningTabPage.Controls.Add(Me.ControllerPvTrackingTrkb)
        Me.TuningTabPage.Controls.Add(Me.ControllerDirectionTrkb)
        Me.TuningTabPage.Controls.Add(Me.ControllerDerivativeLabel)
        Me.TuningTabPage.Controls.Add(Me.ControllerOpHighLabel)
        Me.TuningTabPage.Controls.Add(Me.ControllerSpHighLabel)
        Me.TuningTabPage.Controls.Add(Me.ControllerIntegralLabel)
        Me.TuningTabPage.Controls.Add(Me.ControllerOpLowLabel)
        Me.TuningTabPage.Controls.Add(Me.ControllerSpLowLabel)
        Me.TuningTabPage.Controls.Add(Me.ControllerDirectionLabel)
        Me.TuningTabPage.Controls.Add(Me.ControllerPVTrackingLabel)
        Me.TuningTabPage.Controls.Add(Me.ControllerGainLabel)
        Me.TuningTabPage.Controls.Add(Me.ControllerOpHighTb)
        Me.TuningTabPage.Controls.Add(Me.ControllerSpHighTb)
        Me.TuningTabPage.Controls.Add(Me.ControllerOpLowTb)
        Me.TuningTabPage.Controls.Add(Me.ControllerDerivativeTb)
        Me.TuningTabPage.Controls.Add(Me.ControllerSpLowTb)
        Me.TuningTabPage.Controls.Add(Me.ControllerIntegralTb)
        Me.TuningTabPage.Controls.Add(Me.ControllerGainTb)
        Me.TuningTabPage.Location = New System.Drawing.Point(4, 29)
        Me.TuningTabPage.Name = "TuningTabPage"
        Me.TuningTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TuningTabPage.Size = New System.Drawing.Size(1438, 216)
        Me.TuningTabPage.TabIndex = 0
        Me.TuningTabPage.Text = "Tuning"
        Me.TuningTabPage.UseVisualStyleBackColor = True
        '
        'ControllerPvTrackingTrkb
        '
        Me.ControllerPvTrackingTrkb.LargeChange = 1
        Me.ControllerPvTrackingTrkb.Location = New System.Drawing.Point(500, 109)
        Me.ControllerPvTrackingTrkb.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ControllerPvTrackingTrkb.Maximum = 2
        Me.ControllerPvTrackingTrkb.Minimum = 1
        Me.ControllerPvTrackingTrkb.Name = "ControllerPvTrackingTrkb"
        Me.ControllerPvTrackingTrkb.Size = New System.Drawing.Size(86, 69)
        Me.ControllerPvTrackingTrkb.TabIndex = 6
        Me.ControllerPvTrackingTrkb.Value = 2
        '
        'ControllerDirectionTrkb
        '
        Me.ControllerDirectionTrkb.LargeChange = 2
        Me.ControllerDirectionTrkb.Location = New System.Drawing.Point(500, 20)
        Me.ControllerDirectionTrkb.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ControllerDirectionTrkb.Maximum = 1
        Me.ControllerDirectionTrkb.Minimum = -1
        Me.ControllerDirectionTrkb.Name = "ControllerDirectionTrkb"
        Me.ControllerDirectionTrkb.Size = New System.Drawing.Size(86, 69)
        Me.ControllerDirectionTrkb.SmallChange = 2
        Me.ControllerDirectionTrkb.TabIndex = 7
        Me.ControllerDirectionTrkb.Value = 1
        '
        'ControllerDerivativeLabel
        '
        Me.ControllerDerivativeLabel.AutoSize = True
        Me.ControllerDerivativeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerDerivativeLabel.Location = New System.Drawing.Point(10, 148)
        Me.ControllerDerivativeLabel.Name = "ControllerDerivativeLabel"
        Me.ControllerDerivativeLabel.Size = New System.Drawing.Size(147, 25)
        Me.ControllerDerivativeLabel.TabIndex = 0
        Me.ControllerDerivativeLabel.Text = "Derivative Time"
        '
        'ControllerOpHighLabel
        '
        Me.ControllerOpHighLabel.AutoSize = True
        Me.ControllerOpHighLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerOpHighLabel.Location = New System.Drawing.Point(620, 163)
        Me.ControllerOpHighLabel.Name = "ControllerOpHighLabel"
        Me.ControllerOpHighLabel.Size = New System.Drawing.Size(86, 25)
        Me.ControllerOpHighLabel.TabIndex = 0
        Me.ControllerOpHighLabel.Text = "OP High"
        '
        'ControllerSpHighLabel
        '
        Me.ControllerSpHighLabel.AutoSize = True
        Me.ControllerSpHighLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerSpHighLabel.Location = New System.Drawing.Point(620, 63)
        Me.ControllerSpHighLabel.Name = "ControllerSpHighLabel"
        Me.ControllerSpHighLabel.Size = New System.Drawing.Size(84, 25)
        Me.ControllerSpHighLabel.TabIndex = 0
        Me.ControllerSpHighLabel.Text = "SP High"
        '
        'ControllerIntegralLabel
        '
        Me.ControllerIntegralLabel.AutoSize = True
        Me.ControllerIntegralLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerIntegralLabel.Location = New System.Drawing.Point(10, 86)
        Me.ControllerIntegralLabel.Name = "ControllerIntegralLabel"
        Me.ControllerIntegralLabel.Size = New System.Drawing.Size(125, 25)
        Me.ControllerIntegralLabel.TabIndex = 0
        Me.ControllerIntegralLabel.Text = "Integral Time"
        '
        'ControllerOpLowLabel
        '
        Me.ControllerOpLowLabel.AutoSize = True
        Me.ControllerOpLowLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerOpLowLabel.Location = New System.Drawing.Point(620, 112)
        Me.ControllerOpLowLabel.Name = "ControllerOpLowLabel"
        Me.ControllerOpLowLabel.Size = New System.Drawing.Size(82, 25)
        Me.ControllerOpLowLabel.TabIndex = 0
        Me.ControllerOpLowLabel.Text = "OP Low"
        '
        'ControllerSpLowLabel
        '
        Me.ControllerSpLowLabel.AutoSize = True
        Me.ControllerSpLowLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerSpLowLabel.Location = New System.Drawing.Point(620, 12)
        Me.ControllerSpLowLabel.Name = "ControllerSpLowLabel"
        Me.ControllerSpLowLabel.Size = New System.Drawing.Size(80, 25)
        Me.ControllerSpLowLabel.TabIndex = 0
        Me.ControllerSpLowLabel.Text = "SP Low"
        '
        'ControllerDirectionLabel
        '
        Me.ControllerDirectionLabel.AutoSize = True
        Me.ControllerDirectionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerDirectionLabel.Location = New System.Drawing.Point(314, 20)
        Me.ControllerDirectionLabel.Name = "ControllerDirectionLabel"
        Me.ControllerDirectionLabel.Size = New System.Drawing.Size(177, 25)
        Me.ControllerDirectionLabel.TabIndex = 0
        Me.ControllerDirectionLabel.Text = "Controller Direction"
        '
        'ControllerPVTrackingLabel
        '
        Me.ControllerPVTrackingLabel.AutoSize = True
        Me.ControllerPVTrackingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerPVTrackingLabel.Location = New System.Drawing.Point(314, 109)
        Me.ControllerPVTrackingLabel.Name = "ControllerPVTrackingLabel"
        Me.ControllerPVTrackingLabel.Size = New System.Drawing.Size(120, 25)
        Me.ControllerPVTrackingLabel.TabIndex = 0
        Me.ControllerPVTrackingLabel.Text = "PV Tracking"
        '
        'ControllerGainLabel
        '
        Me.ControllerGainLabel.AutoSize = True
        Me.ControllerGainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerGainLabel.Location = New System.Drawing.Point(10, 25)
        Me.ControllerGainLabel.Name = "ControllerGainLabel"
        Me.ControllerGainLabel.Size = New System.Drawing.Size(162, 25)
        Me.ControllerGainLabel.TabIndex = 0
        Me.ControllerGainLabel.Text = "Proportional Gain"
        '
        'ControllerOpHighTb
        '
        Me.ControllerOpHighTb.BackColor = System.Drawing.Color.White
        Me.ControllerOpHighTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerOpHighTb.ForeColor = System.Drawing.Color.Black
        Me.ControllerOpHighTb.Location = New System.Drawing.Point(735, 157)
        Me.ControllerOpHighTb.Name = "ControllerOpHighTb"
        Me.ControllerOpHighTb.Size = New System.Drawing.Size(73, 30)
        Me.ControllerOpHighTb.TabIndex = 1
        Me.ControllerOpHighTb.Text = "100"
        '
        'ControllerSpHighTb
        '
        Me.ControllerSpHighTb.BackColor = System.Drawing.Color.White
        Me.ControllerSpHighTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerSpHighTb.ForeColor = System.Drawing.Color.Black
        Me.ControllerSpHighTb.Location = New System.Drawing.Point(735, 57)
        Me.ControllerSpHighTb.Name = "ControllerSpHighTb"
        Me.ControllerSpHighTb.Size = New System.Drawing.Size(73, 30)
        Me.ControllerSpHighTb.TabIndex = 1
        Me.ControllerSpHighTb.Text = "100"
        '
        'ControllerOpLowTb
        '
        Me.ControllerOpLowTb.BackColor = System.Drawing.Color.White
        Me.ControllerOpLowTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerOpLowTb.ForeColor = System.Drawing.Color.Black
        Me.ControllerOpLowTb.Location = New System.Drawing.Point(735, 108)
        Me.ControllerOpLowTb.Name = "ControllerOpLowTb"
        Me.ControllerOpLowTb.Size = New System.Drawing.Size(73, 30)
        Me.ControllerOpLowTb.TabIndex = 1
        Me.ControllerOpLowTb.Text = "0"
        '
        'ControllerDerivativeTb
        '
        Me.ControllerDerivativeTb.BackColor = System.Drawing.Color.White
        Me.ControllerDerivativeTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerDerivativeTb.ForeColor = System.Drawing.Color.Black
        Me.ControllerDerivativeTb.Location = New System.Drawing.Point(210, 143)
        Me.ControllerDerivativeTb.Name = "ControllerDerivativeTb"
        Me.ControllerDerivativeTb.Size = New System.Drawing.Size(73, 30)
        Me.ControllerDerivativeTb.TabIndex = 1
        Me.ControllerDerivativeTb.Text = "0"
        '
        'ControllerSpLowTb
        '
        Me.ControllerSpLowTb.BackColor = System.Drawing.Color.White
        Me.ControllerSpLowTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerSpLowTb.ForeColor = System.Drawing.Color.Black
        Me.ControllerSpLowTb.Location = New System.Drawing.Point(735, 8)
        Me.ControllerSpLowTb.Name = "ControllerSpLowTb"
        Me.ControllerSpLowTb.Size = New System.Drawing.Size(73, 30)
        Me.ControllerSpLowTb.TabIndex = 1
        Me.ControllerSpLowTb.Text = "0"
        '
        'ControllerIntegralTb
        '
        Me.ControllerIntegralTb.BackColor = System.Drawing.Color.White
        Me.ControllerIntegralTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerIntegralTb.ForeColor = System.Drawing.Color.Black
        Me.ControllerIntegralTb.Location = New System.Drawing.Point(210, 82)
        Me.ControllerIntegralTb.Name = "ControllerIntegralTb"
        Me.ControllerIntegralTb.Size = New System.Drawing.Size(73, 30)
        Me.ControllerIntegralTb.TabIndex = 1
        Me.ControllerIntegralTb.Text = "10"
        '
        'ControllerGainTb
        '
        Me.ControllerGainTb.BackColor = System.Drawing.Color.White
        Me.ControllerGainTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerGainTb.ForeColor = System.Drawing.Color.Black
        Me.ControllerGainTb.Location = New System.Drawing.Point(210, 20)
        Me.ControllerGainTb.Name = "ControllerGainTb"
        Me.ControllerGainTb.Size = New System.Drawing.Size(73, 30)
        Me.ControllerGainTb.TabIndex = 1
        Me.ControllerGainTb.Text = "0.3"
        '
        'TuningAdvancedTabPage
        '
        Me.TuningAdvancedTabPage.Location = New System.Drawing.Point(4, 29)
        Me.TuningAdvancedTabPage.Name = "TuningAdvancedTabPage"
        Me.TuningAdvancedTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TuningAdvancedTabPage.Size = New System.Drawing.Size(1438, 216)
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
        Me.MessageView.Location = New System.Drawing.Point(398, 49)
        Me.MessageView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MessageView.Name = "MessageView"
        Me.MessageView.Size = New System.Drawing.Size(868, 152)
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
        Me.ControllerGroupBox.Location = New System.Drawing.Point(15, 462)
        Me.ControllerGroupBox.Name = "ControllerGroupBox"
        Me.ControllerGroupBox.Size = New System.Drawing.Size(350, 268)
        Me.ControllerGroupBox.TabIndex = 5
        Me.ControllerGroupBox.TabStop = False
        Me.ControllerGroupBox.Text = "Controller"
        '
        'ControllerModeCb
        '
        Me.ControllerModeCb.FormattingEnabled = True
        Me.ControllerModeCb.Items.AddRange(New Object() {"Auto", "Man"})
        Me.ControllerModeCb.Location = New System.Drawing.Point(232, 160)
        Me.ControllerModeCb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ControllerModeCb.Name = "ControllerModeCb"
        Me.ControllerModeCb.Size = New System.Drawing.Size(100, 28)
        Me.ControllerModeCb.TabIndex = 2
        '
        'ControllerOpTb
        '
        Me.ControllerOpTb.BackColor = System.Drawing.Color.White
        Me.ControllerOpTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerOpTb.Location = New System.Drawing.Point(232, 120)
        Me.ControllerOpTb.Name = "ControllerOpTb"
        Me.ControllerOpTb.ReadOnly = True
        Me.ControllerOpTb.Size = New System.Drawing.Size(100, 30)
        Me.ControllerOpTb.TabIndex = 1
        Me.ControllerOpTb.Text = "50.00"
        '
        'ControllerSpTb
        '
        Me.ControllerSpTb.BackColor = System.Drawing.Color.Gold
        Me.ControllerSpTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerSpTb.ForeColor = System.Drawing.Color.Black
        Me.ControllerSpTb.Location = New System.Drawing.Point(232, 80)
        Me.ControllerSpTb.Name = "ControllerSpTb"
        Me.ControllerSpTb.Size = New System.Drawing.Size(100, 30)
        Me.ControllerSpTb.TabIndex = 1
        Me.ControllerSpTb.Text = "50.00"
        '
        'ControllerModeLabel
        '
        Me.ControllerModeLabel.AutoSize = True
        Me.ControllerModeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerModeLabel.Location = New System.Drawing.Point(10, 160)
        Me.ControllerModeLabel.Name = "ControllerModeLabel"
        Me.ControllerModeLabel.Size = New System.Drawing.Size(62, 25)
        Me.ControllerModeLabel.TabIndex = 0
        Me.ControllerModeLabel.Text = "Mode"
        '
        'ControllerOpLabel
        '
        Me.ControllerOpLabel.AutoSize = True
        Me.ControllerOpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerOpLabel.Location = New System.Drawing.Point(10, 120)
        Me.ControllerOpLabel.Name = "ControllerOpLabel"
        Me.ControllerOpLabel.Size = New System.Drawing.Size(119, 25)
        Me.ControllerOpLabel.TabIndex = 0
        Me.ControllerOpLabel.Text = "Output (OP)"
        '
        'ControllerSpLabel
        '
        Me.ControllerSpLabel.AutoSize = True
        Me.ControllerSpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerSpLabel.Location = New System.Drawing.Point(10, 80)
        Me.ControllerSpLabel.Name = "ControllerSpLabel"
        Me.ControllerSpLabel.Size = New System.Drawing.Size(130, 25)
        Me.ControllerSpLabel.TabIndex = 0
        Me.ControllerSpLabel.Text = "Setpoint (SP)"
        '
        'ControllerPvTb
        '
        Me.ControllerPvTb.BackColor = System.Drawing.Color.White
        Me.ControllerPvTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerPvTb.ForeColor = System.Drawing.Color.Black
        Me.ControllerPvTb.Location = New System.Drawing.Point(232, 40)
        Me.ControllerPvTb.Name = "ControllerPvTb"
        Me.ControllerPvTb.ReadOnly = True
        Me.ControllerPvTb.Size = New System.Drawing.Size(100, 30)
        Me.ControllerPvTb.TabIndex = 1
        Me.ControllerPvTb.Text = "50.00"
        '
        'ControllerPvLabel
        '
        Me.ControllerPvLabel.AutoSize = True
        Me.ControllerPvLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControllerPvLabel.Location = New System.Drawing.Point(10, 40)
        Me.ControllerPvLabel.Name = "ControllerPvLabel"
        Me.ControllerPvLabel.Size = New System.Drawing.Size(185, 25)
        Me.ControllerPvLabel.TabIndex = 0
        Me.ControllerPvLabel.Text = "Process Value (PV)"
        '
        'MessageViewClearPb
        '
        Me.MessageViewClearPb.Location = New System.Drawing.Point(1290, 154)
        Me.MessageViewClearPb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MessageViewClearPb.Name = "MessageViewClearPb"
        Me.MessageViewClearPb.Size = New System.Drawing.Size(150, 38)
        Me.MessageViewClearPb.TabIndex = 8
        Me.MessageViewClearPb.Text = "Clear Messages"
        Me.MessageViewClearPb.UseVisualStyleBackColor = True
        '
        'PID_Simulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1478, 1045)
        Me.Controls.Add(Me.MessageViewClearPb)
        Me.Controls.Add(Me.MessageView)
        Me.Controls.Add(Me.TuningTabControl)
        Me.Controls.Add(Me.ControllerGroupBox)
        Me.Controls.Add(Me.ProcessModelGroupBox)
        Me.Controls.Add(Me.SimulationTrend)
        Me.Controls.Add(Me.SimulationControlPanel)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
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
        CType(Me.ControllerPvTrackingTrkb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControllerDirectionTrkb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ControllerGroupBox.ResumeLayout(False)
        Me.ControllerGroupBox.PerformLayout()
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
    Friend WithEvents ControllerPvTrackingTrkb As TrackBar
    Friend WithEvents ControllerDirectionTrkb As TrackBar
    Friend WithEvents ControllerSpHighLabel As Label
    Friend WithEvents ControllerSpLowLabel As Label
    Friend WithEvents ControllerSpHighTb As TextBox
    Friend WithEvents ControllerSpLowTb As TextBox
    Friend WithEvents ControllerOpHighLabel As Label
    Friend WithEvents ControllerOpLowLabel As Label
    Friend WithEvents ControllerOpHighTb As TextBox
    Friend WithEvents ControllerOpLowTb As TextBox
    Friend WithEvents ControllerDirectionLabel As Label
    Friend WithEvents ControllerPVTrackingLabel As Label
End Class

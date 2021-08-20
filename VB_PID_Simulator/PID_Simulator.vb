Public Class PID_Simulator

    'Defining Process Model Variables
    Public ProcessModelInput As Double
    Public ProcessModelOutput As Double
    Public ProcessModelGain As Double
    Public ProcessModelSettlingTime As Double
    Public ProcessModelOutputPrevious As Double

    'Defining Controller Variables
    Public ControllerPV As Double
    Public ControllerSP As Double
    Public ControllerOP As Double
    Public ControllerCOUT As Double
    Public ControllerDeltaMove As Double

    'Defining other variables
    Public SimulationtimerInterval As Double
    Public TrendValueInitializeArray As Double
    Public TrendSpan As Double
    'Executes on UI Form Load
    Private Sub PID_Simulator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            'Initialize Simulation Timer
            SimulationtimerInterval = SimulationTimer.Interval / 1000

            'Initialize Process Model Variables
            ProcessModelInput = Val(ProcessInputTb.Text)
            ProcessModelOutput = Val(ProcessOutputTb.Text)
            ProcessModelGain = Val(ProcessGainTb.Text)
            ProcessModelSettlingTime = Val(ProcessSettingTimeTb.Text)
            ProcessModelOutputPrevious = ProcessModelOutput

            'Initialize Controller Variables
            ControllerModeCb.SelectedIndex = 1
            ControllerPV = Val(ControllerPvTb.Text)
            ControllerSP = Val(ControllerSpTb.Text)
            ControllerOP = Val(ControllerOpTb.Text)
            ControllerCOUT = ControllerOP

            'Initialize Trend
            TrendValueInitializeArray = 50
            SimulationTrend.ChartAreas(0).AxisY.Minimum = 0
            SimulationTrend.ChartAreas(0).AxisY.Maximum = 100
            SimulationTrend.ChartAreas(0).AxisX.Minimum = 0
            SimulationTrend.ChartAreas(0).AxisX.Maximum = 100

            'Populate trend with data for initial load
            For i = 1 To 300
                SimulationTrend.Series(0).Points.AddY(TrendValueInitializeArray)
                SimulationTrend.Series(1).Points.AddY(TrendValueInitializeArray)
                SimulationTrend.Series(2).Points.AddY(TrendValueInitializeArray)
            Next i

            'Initialize Trend Span
            TrendSpan = 300

        Catch ex As Exception

            'Quit application on Error
            MessageBox.Show("Error loading Application. Application will quit")
            End

        End Try

    End Sub
    'Executes when Start button clicked
    Private Sub SimulationStartPb_Click(sender As Object, e As EventArgs) Handles SimulationStartPb.Click

        'Start Simulation Timer
        SimulationTimer.Start()

        'Update Status Label 
        ToolStripStatusSimulation.Text = "Simulation Running"

        'Update Listbox
        MessageView.AppendText("Simulation Started" & vbNewLine)
        MessageView.ScrollToCaret()

    End Sub
    'Executes when Stop button clicked
    Private Sub SimulationStopPb_Click(sender As Object, e As EventArgs) Handles SimulationStopPb.Click

        'Start Simulation Timer
        SimulationTimer.Stop()

        'Update Status Label 
        ToolStripStatusSimulation.Text = "Simulation Stopped"

        'Update Listbox
        MessageView.AppendText("Simulation Stopped" & vbNewLine)
        MessageView.ScrollToCaret()

    End Sub
    'Executes during integrator(timer) active
    Private Sub SimulationTimer_Tick(sender As Object, e As EventArgs) Handles SimulationTimer.Tick

        Try

            'Process Model Read Parameters from UI

            ProcessModelInput = Val(ProcessInputTb.Text)
            ProcessModelOutput = Val(ProcessOutputTb.Text)
            ProcessModelGain = Val(ProcessGainTb.Text)
            ProcessModelSettlingTime = Val(ProcessSettingTimeTb.Text)

            'Controller - Process Model Connect
            ProcessModelInput = ControllerOP

            ' Dynamic Process Model Equation
            ' ModelOut = exp(-TimeInterval / tau) * ModelOutPrev + (1 - exp(-TimeInterval / tau)) * ModelInput * ModelGain
            ProcessModelOutput = (Math.Exp(-SimulationtimerInterval / ProcessModelSettlingTime) * ProcessModelOutputPrevious) +
                ((1 - Math.Exp(-SimulationtimerInterval / ProcessModelSettlingTime)) * ProcessModelInput * ProcessModelGain)
            ProcessModelOutputPrevious = ProcessModelOutput

            'ProcessModel LimitBounds
            If ProcessModelOutput <= 0 Then
                ProcessModelOutput = 0
                MessageView.AppendText("Process Model Output hit Low Limit. Reset Simulation" & vbNewLine)
                MessageView.ScrollToCaret()
            ElseIf ProcessModelOutput >= 100 Then
                ProcessModelOutput = 100
                MessageView.AppendText("Process Model Output hit High Limit. Reset Simulation" & vbNewLine)
                MessageView.ScrollToCaret()
            End If

            'ControllerEquation
            ControllerDeltaMove = (ControllerPV - ControllerSP)


            'Update UI - Process Model
            ProcessOutputTb.Text = Math.Round(ProcessModelOutput, 4)

            'Update Trends

            SimulationTrend.ChartAreas(0).AxisX.Maximum = TrendSpan

            If SimulationTrend.Series(0).Points.Count > TrendSpan Then
                SimulationTrend.Series(0).Points.RemoveAt(0)
            End If
            SimulationTrend.Series(0).Points.AddY(CDbl(ProcessModelOutput))

            If SimulationTrend.Series(1).Points.Count > TrendSpan Then
                SimulationTrend.Series(1).Points.RemoveAt(0)
            End If
            SimulationTrend.Series(1).Points.AddY(CDbl(ProcessModelInput))

            'If SimulationTrend.Series(2).Points.Count > TrendSpan Then
            '    SimulationTrend.Series(2).Points.RemoveAt(0)
            'End If
            'SimulationTrend.Series(2).Points.AddY(CDbl(FirstOrderPidOp))

        Catch ex As Exception

            'Quit application on Error
            MessageBox.Show("Error in Integrator. Application will quit")
            End

        End Try

    End Sub
    'Executes when exit menu item clicked
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
    'Executes when simulation speed changed
    Private Sub SimulationSpeedSet_Scroll(sender As Object, e As EventArgs) Handles SimulationSpeedSet.Scroll
        SimulationTimer.Interval = 1000 / Val(SimulationSpeedSet.Value)
        ToolStripStatusSpeed.Text = "Simulation Speed = " & SimulationSpeedSet.Value & "x (" & SimulationTimer.Interval & "ms)"
    End Sub
    'Executes when messages clear clicked
    Private Sub MessageViewClearPb_Click(sender As Object, e As EventArgs) Handles MessageViewClearPb.Click
        MessageView.Clear()
    End Sub

    Private Sub SimulationTrend_Click(sender As Object, e As EventArgs) Handles SimulationTrend.Click

    End Sub
End Class
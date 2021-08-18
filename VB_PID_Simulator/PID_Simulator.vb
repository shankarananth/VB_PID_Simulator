Public Class PID_Simulator

    'Initializing Variables
    Public ProcessModelInput As Double
    Public ProcessModelOutput As Double
    Public ProcessModelGain As Double
    Public ProcessModelSettlingTime As Double
    Public ProcessModelOutputPrevious As Double
    Public SimulationtimerInterval As Double
    Public TrendValueInitializeArray As Double
    Public TrendSpan As Double

    Private Sub PID_Simulator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initialize mode to Auto
        ControllerModeCb.SelectedIndex = 1

        'Initialize Simulation Timer
        SimulationtimerInterval = SimulationTimer.Interval / 1000

        'Initialize Process Model Variables
        ProcessModelInput = Val(ProcessInputTb.Text)
        ProcessModelOutput = Val(ProcessOutputTb.Text)
        ProcessModelGain = Val(ProcessGainTb.Text)
        ProcessModelSettlingTime = Val(ProcessSettingTimeTb.Text)
        ProcessModelOutputPrevious = ProcessModelOutput




        'Initialize Trend
        TrendValueInitializeArray = 50
        SimulationTrend.ChartAreas(0).AxisY.Minimum = 0
        SimulationTrend.ChartAreas(0).AxisY.Maximum = 100
        SimulationTrend.ChartAreas(0).AxisX.Minimum = 0
        SimulationTrend.ChartAreas(0).AxisX.Maximum = 100
        'SimulationTrend.ChartAreas(0).AxisY2.Minimum = 0
        'SimulationTrend.ChartAreas(0).AxisY2.Maximum = 100
        'SimulationTrend.ChartAreas(0).AxisX2.Minimum = 0
        'SimulationTrend.ChartAreas(0).AxisX2.Maximum = 100

        For i = 1 To 300
            SimulationTrend.Series(0).Points.AddY(TrendValueInitializeArray)
            SimulationTrend.Series(1).Points.AddY(TrendValueInitializeArray)
            SimulationTrend.Series(2).Points.AddY(TrendValueInitializeArray)
        Next i

        TrendSpan = 300

    End Sub

    Private Sub SimulationStartPb_Click(sender As Object, e As EventArgs) Handles SimulationStartPb.Click

        'Start Simulation Timer
        SimulationTimer.Start()

        'Update Status Label 
        ToolStripStatusLabel.Text = "Simulation Running"

        'Update Listbox
        AlarmView.AppendText("Simulation Started" & vbNewLine)
        AlarmView.ScrollToCaret()

    End Sub

    Private Sub SimulationStopPb_Click(sender As Object, e As EventArgs) Handles SimulationStopPb.Click

        'Start Simulation Timer
        SimulationTimer.Stop()

        'Update Status Label 
        ToolStripStatusLabel.Text = "Simulation Stopped"

        'Update Listbox
        AlarmView.AppendText("Simulation Stopped" & vbNewLine)
        AlarmView.ScrollToCaret()

    End Sub

    Private Sub SimulationTimer_Tick(sender As Object, e As EventArgs) Handles SimulationTimer.Tick

        Try

            'Process Model Read Parameters

            ProcessModelInput = Val(ProcessInputTb.Text)
            ProcessModelOutput = Val(ProcessOutputTb.Text)
            ProcessModelGain = Val(ProcessGainTb.Text)
            ProcessModelSettlingTime = Val(ProcessSettingTimeTb.Text)

            ' Dynamics Process Model Equation
            ' ModelOut = exp(-TimeInterval / tau) * ModelOutPrev + (1 - exp(-TimeInterval / tau)) * ModelInput * ModelGain
            ProcessModelOutput = (Math.Exp(-SimulationtimerInterval / ProcessModelSettlingTime) * ProcessModelOutputPrevious) +
                ((1 - Math.Exp(-SimulationtimerInterval / ProcessModelSettlingTime)) * ProcessModelInput * ProcessModelGain)
            ProcessModelOutputPrevious = ProcessModelOutput

            'ProcessModel LimitBounds
            If ProcessModelOutput <= 0 Then
                ProcessModelOutput = 0
                AlarmView.AppendText("Process Model Output hit Low Limit. Reset Simulation" & vbNewLine)
                AlarmView.ScrollToCaret()
            ElseIf ProcessModelOutput >= 100 Then
                ProcessModelOutput = 100
                AlarmView.AppendText("Process Model Output hit High Limit. Reset Simulation" & vbNewLine)
                AlarmView.ScrollToCaret()
            End If

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

            MessageBox.Show("Error in Integrator. Application will quit")

        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub SimulationSpeedSet_Scroll(sender As Object, e As EventArgs) Handles SimulationSpeedSet.Scroll
        SimulationTimer.Interval = 1000 / Val(SimulationSpeedSet.Value)
    End Sub
End Class
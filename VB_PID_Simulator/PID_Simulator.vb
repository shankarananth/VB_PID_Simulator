Public Class PID_Simulator

    'Defining Process Model Variables
    Public ProcessModelInput As Double
    Public ProcessModelOutput As Double
    Public ProcessModelGain As Double
    Public ProcessModelSettlingTime As Double
    Public ProcessModelOutputPrevious As Double
    Public ProcessNoise As Double
    Public ProcessNoiseFactor As Double
    Public ProcessModelDisturbance As Double

    'Defining Controller Variables
    Public ControllerPV As Double
    Public ControllerSP As Double
    Public ControllerOP As Double
    Public ControllerCOUT As Double
    Public ControllerDeltaMove As Double

    'Defining Controller Tuning Parameter Variables
    Public ControllerGain As Double
    Public ControllerIntegral As Double
    Public ControllerDerivative As Double
    Public ControllerSpLo As Double
    Public ControllerSpHi As Double
    Public ControllerOpLo As Double
    Public ControllerOpHi As Double
    Public ControllerDirection As Integer
    Public ControllerPvTracking As Integer
    Public ControllerPidAlgorithm As Integer

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
            ProcessNoiseFactor = Val(NoiseFactorTb.Text)
            ProcessModelDisturbance = Val(ProcessModelDisturbanceTb.Text)
            ProcessModelOutputPrevious = ProcessModelOutput

            'Initialize Controller Variables
            ControllerModeCb.SelectedIndex = 0
            ControllerPV = Val(ControllerPvTb.Text)
            ControllerSP = Val(ControllerSpTb.Text)
            ControllerOP = Val(ControllerOpTb.Text)
            ControllerCOUT = ControllerOP
            PidAlgorithmChoice.SelectedIndex = 0
            ControllerPidAlgorithm = PidAlgorithmChoice.SelectedIndex

            'Initialize Controller Tuning Parameter Variables
            ControllerGain = Val(ControllerGainTb.Text)
            ControllerIntegral = Val(ControllerIntegralTb.Text)
            ControllerDerivative = Val(ControllerDerivativeTb.Text)
            ControllerSpLo = Val(ControllerSpLowTb.Text)
            ControllerSpHi = Val(ControllerSpHighTb.Text)
            ControllerOpLo = Val(ControllerOpLowTb.Text)
            ControllerOpHi = Val(ControllerOpHighTb.Text)
            ControllerDirection = ControllerDirectionTrkb.Value
            ControllerPvTracking = ControllerPvTrackingTrkb.Value

            'Initialize PID Algorithm 1 Variables
            PidAlg1Err = 0
            PidAlg1PrevErr = 0
            PidAlg1Prev2Err = 0

            'Initialize PID Algorithm 2 Variables
            PidAlg2Err = 0
            PidAlg2PrevErr = 0
            PidAlg2Prev2Err = 0
            PidAlg2PrevPv = 50
            PidAlg2Prev2Pv = 50

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
        Try

            'Start Simulation Timer
            SimulationTimer.Start()

            'Update Status Label 
            ToolStripStatusSimulation.Text = "Simulation Running"

            'Update Listbox
            MessageView.AppendText("Simulation Started" & vbNewLine)
            MessageView.ScrollToCaret()

        Catch ex As Exception

            MsgBox("Simulation Start Push Button Error")

        End Try

    End Sub
    'Executes when Stop button clicked
    Private Sub SimulationStopPb_Click(sender As Object, e As EventArgs) Handles SimulationStopPb.Click
        Try

            'Start Simulation Timer
            SimulationTimer.Stop()

            'Update Status Label 
            ToolStripStatusSimulation.Text = "Simulation Stopped"

            'Update Listbox
            MessageView.AppendText("Simulation Stopped" & vbNewLine)
            MessageView.ScrollToCaret()

        Catch ex As Exception

            MsgBox("Simulation Stop Push Button Error")

        End Try

    End Sub
    'Executes during integrator(timer) active
    Private Sub SimulationTimer_Tick(sender As Object, e As EventArgs) Handles SimulationTimer.Tick

        Try

            'Process Model Read Parameters from UI
            ProcessModelInput = Val(ProcessInputTb.Text)
            ProcessModelOutput = Val(ProcessOutputTb.Text)
            ProcessModelGain = Val(ProcessGainTb.Text)
            ProcessModelSettlingTime = Val(ProcessSettingTimeTb.Text)
            ProcessNoiseFactor = Val(NoiseFactorTb.Text)
            ProcessModelDisturbance = Val(ProcessModelDisturbanceTb.Text)

            'Controller Read Parameters from UI
            ControllerPV = Val(ControllerPvTb.Text)
            ControllerSP = Val(ControllerSpTb.Text)
            ControllerOP = Val(ControllerOpTb.Text)

            'Controller Tuning Read Parameters from UI
            ControllerGain = Val(ControllerGainTb.Text)
            ControllerIntegral = Val(ControllerIntegralTb.Text)
            ControllerDerivative = Val(ControllerDerivativeTb.Text)
            ControllerSpLo = Val(ControllerSpLowTb.Text)
            ControllerSpHi = Val(ControllerSpHighTb.Text)
            ControllerOpLo = Val(ControllerOpLowTb.Text)
            ControllerOpHi = Val(ControllerOpHighTb.Text)
            ControllerDirection = ControllerDirectionTrkb.Value
            ControllerPvTracking = ControllerPvTrackingTrkb.Value
            ControllerPidAlgorithm = PidAlgorithmChoice.SelectedIndex

            ' Dynamic Process Model Equation
            ' ModelOut = exp(-TimeInterval / tau) * ModelOutPrev + (1 - exp(-TimeInterval / tau)) * ModelInput * ModelGain
            ProcessModelOutput = (Math.Exp(-SimulationtimerInterval / ProcessModelSettlingTime) * ProcessModelOutputPrevious) +
                ((1 - Math.Exp(-SimulationtimerInterval / ProcessModelSettlingTime)) * ProcessModelInput * ProcessModelGain)
            ProcessModelOutputPrevious = ProcessModelOutput

            'Noise Model
            ProcessNoise = ProcessNoiseFactor * Rnd()
            ProcessModelOutput = ProcessModelOutput + ProcessNoise

            'Disturbance Model
            ProcessModelOutput = ProcessModelOutput + ProcessModelDisturbance

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

            'Controller - Process Model Connect
            ControllerPV = ProcessModelOutput

            'ControllerEquation

            If ControllerModeCb.SelectedIndex = 0 Then  'Auto
                ControllerSpTb.ReadOnly = False
                ControllerSpTb.BackColor = Color.Gold
                ControllerOpTb.ReadOnly = True
                ControllerOpTb.BackColor = Color.White
                'Choose PID Algorithm
                If ControllerPidAlgorithm = 0 Then
                    ControllerCOUT = PidAlgorithm1(ControllerPV, ControllerSP, ControllerCOUT, ControllerGain,
                                             ControllerIntegral, ControllerDerivative, ControllerDirection,
                                             ControllerOpHi, ControllerOpLo)
                ElseIf ControllerPidAlgorithm = 1 Then
                    ControllerCOUT = PidAlgorithm2(ControllerPV, ControllerSP, ControllerCOUT, ControllerGain,
                                             ControllerIntegral, ControllerDerivative, ControllerDirection,
                                             ControllerOpHi, ControllerOpLo)
                Else
                    SimulationTimer.Stop()
                    MsgBox("Algorithm Error" & " - Debug PID=" & ControllerPidAlgorithm)
                    End
                End If
            ElseIf ControllerModeCb.SelectedIndex = 1 Then 'Manual
                ControllerCOUT = ControllerOP
                ControllerOpTb.ReadOnly = False
                ControllerOpTb.BackColor = Color.Gold
                If ControllerPvTrackingTrkb.Value = 2 Then
                    ControllerSpTb.ReadOnly = True
                    ControllerSpTb.BackColor = Color.White
                    ControllerSP = Math.Round(ControllerPV, 3)
                End If
            End If

            'Pass Controller Output to destination. Validate against Output limits
            If ControllerCOUT < ControllerOpLo Then
                ControllerOP = ControllerOpLo
                MessageView.AppendText("Controller Output - Low Limited" & vbNewLine)
                MessageView.ScrollToCaret()
            ElseIf ControllerCOUT > ControllerOpHi Then
                ControllerOP = ControllerOpHi
                MessageView.AppendText("Controller Output - High Limited" & vbNewLine)
                MessageView.ScrollToCaret()
            Else
                ControllerOP = ControllerCOUT
            End If

            'Update UI - Process Model
            ProcessOutputTb.Text = Math.Round(ProcessModelOutput, 4)
            ProcessInputTb.Text = Math.Round(ControllerOP, 4) 'Note: Process and Controller connection

            'Update UI - Controller
            ControllerPvTb.Text = Math.Round(ControllerPV, 4)
            ControllerSpTb.Text = Math.Round(ControllerSP, 4)
            ControllerOpTb.Text = Math.Round(ControllerOP, 4)

            'Update UI - Controller Labels in Trend
            ControllerPVLabelHMI.Text = "PV = " & Math.Round(ControllerPV, 2)
            ControllerSPLabelHMI.Text = "SP = " & Math.Round(ControllerSP, 2)
            ControllerOPLabelHMI.Text = "OP = " & Math.Round(ControllerOP, 2)
            ControllerCOLabelHMI.Text = "CO = " & Math.Round(ControllerCOUT, 2)

            'Update Trends

            SimulationTrend.ChartAreas(0).AxisX.Maximum = TrendSpan

            If SimulationTrend.Series(0).Points.Count > TrendSpan Then
                SimulationTrend.Series(0).Points.RemoveAt(0)
            End If
            SimulationTrend.Series(0).Points.AddY(CDbl(ControllerPV))

            If SimulationTrend.Series(1).Points.Count > TrendSpan Then
                SimulationTrend.Series(1).Points.RemoveAt(0)
            End If
            SimulationTrend.Series(1).Points.AddY(CDbl(ControllerSP))

            If SimulationTrend.Series(2).Points.Count > TrendSpan Then
                SimulationTrend.Series(2).Points.RemoveAt(0)
            End If
            SimulationTrend.Series(2).Points.AddY(CDbl(ControllerOP))

        Catch ex As Exception

            'Quit application on Error
            MessageBox.Show("Error in Integrator. Application will quit")
            SimulationTimer.Stop()
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
    'Display About Box
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub


    Private Sub PidAlgorithmChoice_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles PidAlgorithmChoice.SelectionChangeCommitted
        ControllerModeCb.SelectedIndex = 1
        MessageView.AppendText("Control Algorithm Changed. Controller forced to manual" & vbNewLine)
        MessageView.ScrollToCaret()
    End Sub
End Class
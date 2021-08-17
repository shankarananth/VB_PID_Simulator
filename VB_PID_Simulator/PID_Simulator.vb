Public Class PID_Simulator

    'Initializing Variables
    Public ProcessModelInput As Double
    Public ProcessModelOutput As Double
    Public ProcessModelGain As Double
    Public ProcessModelSettlingTime As Double

    Private Sub PID_Simulator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initialize mode to Auto
        ControllerModeCb.SelectedIndex = 1

    End Sub

    Private Sub SimulationStartPb_Click(sender As Object, e As EventArgs) Handles SimulationStartPb.Click

        'Start Simulation Timer
        SimulationTimer.Start()

        'Update Status Label 
        ToolStripStatusLabel.Text = "Simulation Running"

        'Update Listbox
        AlarmView.AppendText("Simulation Started" & vbNewLine)

    End Sub

    Private Sub SimulationStopPb_Click(sender As Object, e As EventArgs) Handles SimulationStopPb.Click

        'Start Simulation Timer
        SimulationTimer.Stop()

        'Update Status Label 
        ToolStripStatusLabel.Text = "Simulation Stopped"

        'Update Listbox
        AlarmView.AppendText("Simulation Stopped" & vbNewLine)

    End Sub

    Private Sub SimulationTimer_Tick(sender As Object, e As EventArgs) Handles SimulationTimer.Tick


        'Process Model Read Parameters

        ProcessModelInput = Val(ProcessInputTb.Text)
        ProcessModelOutput = Val(ProcessOutputTb.Text)
        ProcessModelGain = Val(ProcessGainTb.Text)
        ProcessModelSettlingTime = Val(ProcessSettingTimeTb.Text)


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub


End Class
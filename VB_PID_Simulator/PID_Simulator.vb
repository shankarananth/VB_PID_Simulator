Public Class PID_Simulator
    Private Sub SimulationStartPb_Click(sender As Object, e As EventArgs) Handles SimulationStartPb.Click

        'Start Simulation Timer
        SimulationTimer.Start()

        'Update Status Label 
        ToolStripStatusLabel.Text = "Simulation Running"

    End Sub

    Private Sub SimulationStopPb_Click(sender As Object, e As EventArgs) Handles SimulationStopPb.Click

        'Start Simulation Timer
        SimulationTimer.Stop()

        'Update Status Label 
        ToolStripStatusLabel.Text = "Simulation Stopped"


    End Sub
End Class
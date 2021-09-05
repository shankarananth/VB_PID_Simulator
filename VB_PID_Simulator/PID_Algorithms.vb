Module PID_Algorithms

    'PID Algorithm 1 - Ideal P,I,D on Error with no ARW 
    'PID Algorithm 2 - Ideal I on Error and P,D on Delta PV with no ARW

    'Define PID Algorithm 1 Variables
    Public PidAlg1Pv
    Public PidAlg1Sp
    Public PidAlg1Op
    Public PidAlg1Cgain
    Public PidAlg1Cintg
    Public PidAlg1Cderv
    Public PidAlg1Cdir
    Public PidAlg1MvHi
    Public PidAlg1MvLo
    Public PidAlg1Err
    Public PidAlg1PrevErr
    Public PidAlg1Prev2Err
    Public PidAlg1DeltaErr
    Public PidAlg1DeltaOp
    Public PidAlg1DeltaPidOp

    'Define PID Algorithm 2 Variables
    Public PidAlg2Pv
    Public PidAlg2PrevPv
    Public PidAlg2Prev2Pv
    Public PidAlg2DeltaPv
    Public PidAlg2Sp
    Public PidAlg2Op
    Public PidAlg2Cgain
    Public PidAlg2Cintg
    Public PidAlg2Cderv
    Public PidAlg2Cdir
    Public PidAlg2MvHi
    Public PidAlg2MvLo
    Public PidAlg2Err
    Public PidAlg2PrevErr
    Public PidAlg2Prev2Err
    Public PidAlg2DeltaErr
    Public PidAlg2DeltaOp
    Public PidAlg2DeltaPidOp


    Function PidAlgorithm1(ByVal PV, ByVal SP, ByVal OP, ByVal CGAIN, ByVal CINTG, ByVal CDERV, ByVal CDIR, ByVal MVHI, ByVal MVLO)

        'PIDAlgorithm1 - Ideal P,I,D on Error with no ARW 

        PidAlg1Pv = PV
        PidAlg1Sp = SP
        PidAlg1Op = OP
        PidAlg1Cgain = CGAIN
        PidAlg1Cintg = CINTG
        PidAlg1Cderv = CDERV
        PidAlg1Cdir = CDIR
        PidAlg1MvHi = MVHI
        PidAlg1MvLo = MVLO

        'PID Error Computation
        PidAlg1Err = PidAlg1Sp - PidAlg1Pv

        'PID Delta Error Computation
        PidAlg1DeltaErr = PidAlg1Err - PidAlg1PrevErr

        'PID Algorithm
        PidAlg1DeltaPidOp = (PidAlg1Cgain * (PidAlg1DeltaErr)) +
                            (PidAlg1Cgain * (PidAlg1Err / PidAlg1Cintg)) +
                            (PidAlg1Cgain * (PidAlg1Cderv * (PidAlg1Err - 2 * PidAlg1PrevErr + PidAlg1Prev2Err)))

        'Debug
        'PID_Simulator.MessageView.AppendText("PAct=" & (PidAlg1Cgain * (PidAlg1DeltaErr)) &
        '                       " IAct=" & (PidAlg1Cgain * (PidAlg1Err / PidAlg1Cintg)) &
        '                       " DAct=" & (PidAlg1Cgain * (PidAlg1Cderv * (PidAlg1Err - 2 * PidAlg1PrevErr + PidAlg1Prev2Err))) &
        '                       vbNewLine)
        'PID_Simulator.MessageView.ScrollToCaret()

        'Controller Direction
        PidAlg1DeltaOp = PidAlg1DeltaPidOp * PidAlg1Cdir

        PidAlg1Prev2Err = PidAlg1PrevErr
        PidAlg1PrevErr = PidAlg1Err
        PidAlg1Op += PidAlg1DeltaOp

        Return PidAlg1Op

    End Function

    Function PidAlgorithm2(ByVal PV, ByVal SP, ByVal OP, ByVal CGAIN, ByVal CINTG, ByVal CDERV, ByVal CDIR, ByVal MVHI, ByVal MVLO)

        'PIDAlgorithm2 - Ideal I on Error and P,D on Delta PV with no ARW

        PidAlg2Pv = PV
        PidAlg2Sp = SP
        PidAlg2Op = OP
        PidAlg2Cgain = CGAIN
        PidAlg2Cintg = CINTG
        PidAlg2Cderv = CDERV
        PidAlg2Cdir = CDIR
        PidAlg2MvHi = MVHI
        PidAlg2MvLo = MVLO

        'PID Error Computation
        PidAlg2Err = PidAlg2Sp - PidAlg2Pv

        'PID Delta Error Computation (not used in this Alg Type)
        PidAlg2DeltaErr = PidAlg2Err - PidAlg2PrevErr

        'PID Delta PV Computation
        PidAlg2DeltaPv = PidAlg2PrevPv - PidAlg2Pv

        'PID Algorithm
        PidAlg2DeltaPidOp = (PidAlg2Cgain * (PidAlg2DeltaPv)) +
                            (PidAlg2Cgain * (PidAlg2Err / PidAlg2Cintg)) +
                            (PidAlg2Cgain * (PidAlg2Cderv * (PidAlg2Pv - 2 * PidAlg2PrevPv + PidAlg2Prev2Pv)))

        'Debug
        'PID_Simulator.MessageView.AppendText("PAct=" & (PidAlg2Cgain * (PidAlg2DeltaPv)) &
        '                       " IAct=" & (PidAlg2Cgain * (PidAlg2Err / PidAlg2Cintg)) &
        '                       " DAct=" & (PidAlg2Cgain * (PidAlg2Cderv * (PidAlg2Pv - 2 * PidAlg2PrevPv + PidAlg2Prev2Pv))) &
        '                       vbNewLine)
        'PID_Simulator.MessageView.AppendText("Delta=" & PidAlg2DeltaPv & "  " & PidAlg2Pv & "  " & PidAlg2PrevPv & vbNewLine)
        'PID_Simulator.MessageView.ScrollToCaret()

        'Controller Direction
        PidAlg2DeltaOp = PidAlg2DeltaPidOp * PidAlg2Cdir

        PidAlg2Prev2Err = PidAlg2PrevErr
        PidAlg2PrevErr = PidAlg2Err
        PidAlg2Prev2Pv = PidAlg2PrevPv
        PidAlg2PrevPv = PidAlg2Pv
        PidAlg2Op += PidAlg2DeltaOp

        Return PidAlg2Op

    End Function

End Module

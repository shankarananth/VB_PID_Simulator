Module PID_Algorithms

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


    Function PidAlgorithm1(ByVal PV, ByVal SP, ByVal OP, ByVal CGAIN, ByVal CINTG, ByVal CDERV, ByVal CDIR, ByVal MVHI, ByVal MVLO)

        'PIDAlgorithm1 - P,I,D on Error

        PidAlg1Pv = PV
        PidAlg1Sp = SP
        PidAlg1Op = OP
        PidAlg1Cgain = CGAIN
        PidAlg1Cintg = CINTG
        PidAlg1Cderv = CDERV
        PidAlg1Cdir = CDIR
        PidAlg1MvHi = MVHI
        PidAlg1MvLo = MVLO


        PidAlg1Err = PidAlg1Sp - PidAlg1Pv

        'Error Computation
        PidAlg1DeltaErr = PidAlg1Err - PidAlg1PrevErr

        'PID Algorithm
        PidAlg1DeltaPidOp = PidAlg1Cgain * (PidAlg1DeltaErr + (PidAlg1Err / PidAlg1Cintg) +
            (PidAlg1Cderv * (PidAlg1Err - PidAlg1PrevErr + PidAlg1Prev2Err)))

        PidAlg1DeltaOp = PidAlg1DeltaPidOp * PidAlg1Cdir

        PidAlg1Prev2Err = PidAlg1PrevErr
        PidAlg1PrevErr = PidAlg1Err
        PidAlg1Op += PidAlg1DeltaOp


        'If PidAlg1Op > PidAlg1MvHi Then
        '    PidAlg1Op = PidAlg1MvHi
        'End If

        'If PidAlg1Op < PidAlg1MvLo Then
        '    PidAlg1Op = PidAlg1MvLo
        'End If

        Return PidAlg1Op

    End Function

End Module

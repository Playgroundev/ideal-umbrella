Public Class FrmQuadratic


    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub BtnSolution_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSolution.Click
        Dim A As Double
        Dim B As Double
        Dim C As Double
        Dim Result1 As Double
        Dim Result2 As Double
        A = Val(TxtA.Text)
        B = Val(TxtB.Text)
        C = Val(TxtB.Text)     
        Result1 = (-B + (Math.Sqrt(Math.Abs(B ^ 2 - 4 * A * C)) / (2 * A)))
        Result2 = (-B - (Math.Sqrt(Math.Abs(B ^ 2 - 4 * A * C)) / (2 * A)))
        TxtResult1.Text = Result1
        TxtResult2.Text = Result2
    End Sub
End Class

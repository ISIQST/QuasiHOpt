Public Class frmSampleStatus

    Public ownerObj As Sample1

    'Private Sub chkHaltCounter_CheckedChanged(sender As System.Object, e As System.EventArgs)
    '    ownerObj.HaltCounter = chkHaltCounter.Checked
    'End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        If (e.KeyCode <> Windows.Forms.Keys.Enter) Then Return
        Try
            TextBox1.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

End Class
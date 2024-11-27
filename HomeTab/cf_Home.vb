Namespace HomeTab
    Partial Public Class cf_Home
        Inherits Form

        ' Method to update the Date and Time label
        Public Sub UpdateDateTime()
            lbl_DateTimeDisplay.Text = DateTime.Now.ToString("MM/dd/yyyy") & vbCrLf & DateTime.Now.ToString("HH:mm:ss")
        End Sub

    End Class
End Namespace

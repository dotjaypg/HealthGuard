Imports System.Windows.Forms

Public Class AdminParent
    Private lastPressedButton As Button

    ' Method to show child forms
    Public Sub ShowChildForm(childForm As Form)
        Try
            pnl_MainPage.Controls.Clear()

            With childForm
                .TopLevel = False
                .FormBorderStyle = FormBorderStyle.None
                .Dock = DockStyle.Fill
            End With

            pnl_MainPage.Controls.Add(childForm)
            childForm.Show()
        Catch ex As ArgumentException
            MessageBox.Show($"Error: {ex.Message}", "MDI Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Button click handler to highlight the selected button
    Private Sub HighlightButton(clickedButton As Button)
        If lastPressedButton IsNot Nothing Then
            lastPressedButton.BackColor = SystemColors.Control
        End If
        clickedButton.BackColor = Color.LightBlue
        lastPressedButton = clickedButton
    End Sub

    ' Event handlers for navigation buttons
    Private Sub btn_Home_Click(sender As Object, e As EventArgs) Handles btn_Home.Click
        HighlightButton(btn_Home)
        Dim homeForm As New HomeTab.cf_Home()
        ShowChildForm(homeForm)
    End Sub

    Private Sub btn_PatientList_Click(sender As Object, e As EventArgs) Handles btn_PatientList.Click
        HighlightButton(btn_PatientList)
        Dim patientListForm As New PatientTab.cf_PatientList()
        ShowChildForm(patientListForm)
    End Sub

    ' Load event to initialize the home form
    Private Sub AdminParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim homeForm As New HomeTab.cf_Home()
        ShowChildForm(homeForm)
        HighlightButton(btn_Home)
    End Sub
End Class

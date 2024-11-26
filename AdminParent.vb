Imports System.Windows.Forms
Imports System.Drawing

Public Class AdminParent
    ' Class-level variable to store the last pressed button
    Private lastPressedButton As Button = Nothing

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initially set the first button (btn_Home) as "pressed"
        btn_Home.BackColor = ColorTranslator.FromHtml("#2d9364") ' Set the pressed color
        lastPressedButton = btn_Home ' Mark btn_Home as the last pressed button
    End Sub

    ' Method to handle button clicks and change the background color
    Private Sub Button_Click(sender As Object, e As EventArgs)
        ' If there is a previously pressed button, reset its background color
        If lastPressedButton IsNot Nothing Then
            lastPressedButton.BackColor = ColorTranslator.FromHtml("#13c18e") ' Default color
        End If

        ' Change the background color of the clicked button
        Dim clickedButton As Button = CType(sender, Button)
        clickedButton.BackColor = ColorTranslator.FromHtml("#2d9364") ' Color when pressed

        ' Update the last pressed button to the current one
        lastPressedButton = clickedButton
    End Sub

    Private Sub btn_Home_Click(sender As Object, e As EventArgs) Handles btn_Home.Click
        Button_Click(sender, e)
    End Sub

    Private Sub btn_Patients_Click(sender As Object, e As EventArgs) Handles btn_Patients.Click
        Button_Click(sender, e)
    End Sub

    Private Sub btn_Accounts_Click(sender As Object, e As EventArgs) Handles btn_Accounts.Click
        Button_Click(sender, e)
    End Sub

    Private Sub btn_Schedules_Click(sender As Object, e As EventArgs) Handles btn_Schedules.Click
        Button_Click(sender, e)
    End Sub

End Class

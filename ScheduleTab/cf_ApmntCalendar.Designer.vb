Namespace ScheduleTab
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class cf_ApmntCalendar
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Label1 = New Label()
            pnl_MainHeader = New Panel()
            Button1 = New Button()
            btn_patientAddNew = New Button()
            txt_homeSearch = New TextBox()
            Label2 = New Label()
            Label6 = New Label()
            lbl_homeDateTime = New Label()
            pnl_MainHeader.SuspendLayout()
            SuspendLayout()
            ' 
            ' Label1
            ' 
            Label1.AutoSize = True
            Label1.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            Label1.Location = New Point(156, 322)
            Label1.Name = "Label1"
            Label1.Size = New Size(0, 86)
            Label1.TabIndex = 0
            ' 
            ' pnl_MainHeader
            ' 
            pnl_MainHeader.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
            pnl_MainHeader.Controls.Add(Button1)
            pnl_MainHeader.Controls.Add(btn_patientAddNew)
            pnl_MainHeader.Controls.Add(txt_homeSearch)
            pnl_MainHeader.Controls.Add(Label2)
            pnl_MainHeader.Controls.Add(Label6)
            pnl_MainHeader.Controls.Add(lbl_homeDateTime)
            pnl_MainHeader.Dock = DockStyle.Top
            pnl_MainHeader.Location = New Point(0, 0)
            pnl_MainHeader.Margin = New Padding(3, 2, 3, 2)
            pnl_MainHeader.Name = "pnl_MainHeader"
            pnl_MainHeader.Size = New Size(1232, 69)
            pnl_MainHeader.TabIndex = 4
            ' 
            ' Button1
            ' 
            Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            Button1.Location = New Point(1029, 17)
            Button1.Name = "Button1"
            Button1.Size = New Size(186, 34)
            Button1.TabIndex = 5
            Button1.Text = "Add new appointment"
            Button1.UseVisualStyleBackColor = True
            ' 
            ' btn_patientAddNew
            ' 
            btn_patientAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_patientAddNew.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            btn_patientAddNew.Location = New Point(2087, 17)
            btn_patientAddNew.Name = "btn_patientAddNew"
            btn_patientAddNew.Size = New Size(160, 34)
            btn_patientAddNew.TabIndex = 4
            btn_patientAddNew.Text = "Add new patient"
            btn_patientAddNew.UseVisualStyleBackColor = True
            ' 
            ' txt_homeSearch
            ' 
            txt_homeSearch.Anchor = AnchorStyles.Top
            txt_homeSearch.BorderStyle = BorderStyle.None
            txt_homeSearch.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_homeSearch.Location = New Point(397, 20)
            txt_homeSearch.Margin = New Padding(3, 2, 3, 2)
            txt_homeSearch.Name = "txt_homeSearch"
            txt_homeSearch.PlaceholderText = "Search for an appointment"
            txt_homeSearch.Size = New Size(493, 29)
            txt_homeSearch.TabIndex = 4
            ' 
            ' Label2
            ' 
            Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            Label2.AutoSize = True
            Label2.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            Label2.ForeColor = Color.White
            Label2.Location = New Point(3161, 14)
            Label2.Name = "Label2"
            Label2.Size = New Size(108, 44)
            Label2.TabIndex = 3
            Label2.Text = "MM/DD/YY" & vbCrLf & "00:00 AM"
            ' 
            ' Label6
            ' 
            Label6.AutoSize = True
            Label6.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            Label6.ForeColor = Color.White
            Label6.Location = New Point(12, 21)
            Label6.Name = "Label6"
            Label6.Size = New Size(217, 22)
            Label6.TabIndex = 1
            Label6.Text = "Appointment Calendar"
            ' 
            ' lbl_homeDateTime
            ' 
            lbl_homeDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            lbl_homeDateTime.AutoSize = True
            lbl_homeDateTime.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            lbl_homeDateTime.ForeColor = Color.White
            lbl_homeDateTime.Location = New Point(4210, 14)
            lbl_homeDateTime.Name = "lbl_homeDateTime"
            lbl_homeDateTime.Size = New Size(108, 44)
            lbl_homeDateTime.TabIndex = 1
            lbl_homeDateTime.Text = "MM/DD/YY" & vbCrLf & "00:00 AM"
            ' 
            ' cf_ApmntCalendar
            ' 
            AutoScaleDimensions = New SizeF(7F, 15F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
            ClientSize = New Size(1232, 799)
            Controls.Add(pnl_MainHeader)
            Controls.Add(Label1)
            Name = "cf_ApmntCalendar"
            Text = "cf_ApmntCalendar"
            pnl_MainHeader.ResumeLayout(False)
            pnl_MainHeader.PerformLayout()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents Label1 As Label
        Friend WithEvents pnl_MainHeader As Panel
        Friend WithEvents btn_patientAddNew As Button
        Friend WithEvents txt_homeSearch As TextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents lbl_homeDateTime As Label
        Friend WithEvents Button1 As Button
    End Class
End Namespace
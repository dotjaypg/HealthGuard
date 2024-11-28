Namespace PatientTab
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class cf_AddPatient
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
            Label6 = New Label()
            btn_Back = New Button()
            btn_ClearFields = New Button()
            btn_patientAddNew = New Button()
            Label2 = New Label()
            lbl_homeDateTime = New Label()
            pnl_AddPatient = New Panel()
            pnl_FirstName = New Panel()
            txt_FirstName = New TextBox()
            pnl_MainHeader.SuspendLayout()
            pnl_AddPatient.SuspendLayout()
            pnl_FirstName.SuspendLayout()
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
            pnl_MainHeader.BorderStyle = BorderStyle.FixedSingle
            pnl_MainHeader.Controls.Add(Label6)
            pnl_MainHeader.Controls.Add(btn_Back)
            pnl_MainHeader.Controls.Add(btn_ClearFields)
            pnl_MainHeader.Controls.Add(btn_patientAddNew)
            pnl_MainHeader.Controls.Add(Label2)
            pnl_MainHeader.Controls.Add(lbl_homeDateTime)
            pnl_MainHeader.Dock = DockStyle.Top
            pnl_MainHeader.Location = New Point(0, 0)
            pnl_MainHeader.Margin = New Padding(3, 2, 3, 2)
            pnl_MainHeader.Name = "pnl_MainHeader"
            pnl_MainHeader.Size = New Size(1192, 69)
            pnl_MainHeader.TabIndex = 4
            ' 
            ' Label6
            ' 
            Label6.AutoSize = True
            Label6.FlatStyle = FlatStyle.Flat
            Label6.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            Label6.ForeColor = Color.White
            Label6.Location = New Point(232, 24)
            Label6.Name = "Label6"
            Label6.Size = New Size(118, 22)
            Label6.TabIndex = 5
            Label6.Text = "New Patient"
            ' 
            ' btn_Back
            ' 
            btn_Back.BackColor = Color.FromArgb(CByte(71), CByte(102), CByte(59))
            btn_Back.FlatAppearance.BorderSize = 0
            btn_Back.FlatStyle = FlatStyle.Flat
            btn_Back.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btn_Back.ForeColor = Color.White
            btn_Back.Location = New Point(11, 17)
            btn_Back.Name = "btn_Back"
            btn_Back.Size = New Size(186, 34)
            btn_Back.TabIndex = 5
            btn_Back.Text = "Back"
            btn_Back.UseVisualStyleBackColor = False
            ' 
            ' btn_ClearFields
            ' 
            btn_ClearFields.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_ClearFields.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            btn_ClearFields.Location = New Point(987, 17)
            btn_ClearFields.Name = "btn_ClearFields"
            btn_ClearFields.Size = New Size(186, 34)
            btn_ClearFields.TabIndex = 5
            btn_ClearFields.Text = "Clear all fields"
            btn_ClearFields.UseVisualStyleBackColor = True
            ' 
            ' btn_patientAddNew
            ' 
            btn_patientAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_patientAddNew.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            btn_patientAddNew.Location = New Point(2045, 17)
            btn_patientAddNew.Name = "btn_patientAddNew"
            btn_patientAddNew.Size = New Size(160, 34)
            btn_patientAddNew.TabIndex = 4
            btn_patientAddNew.Text = "Add new patient"
            btn_patientAddNew.UseVisualStyleBackColor = True
            ' 
            ' Label2
            ' 
            Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            Label2.AutoSize = True
            Label2.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            Label2.ForeColor = Color.White
            Label2.Location = New Point(3119, 14)
            Label2.Name = "Label2"
            Label2.Size = New Size(108, 44)
            Label2.TabIndex = 3
            Label2.Text = "MM/DD/YY" & vbCrLf & "00:00 AM"
            ' 
            ' lbl_homeDateTime
            ' 
            lbl_homeDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            lbl_homeDateTime.AutoSize = True
            lbl_homeDateTime.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            lbl_homeDateTime.ForeColor = Color.White
            lbl_homeDateTime.Location = New Point(4168, 14)
            lbl_homeDateTime.Name = "lbl_homeDateTime"
            lbl_homeDateTime.Size = New Size(108, 44)
            lbl_homeDateTime.TabIndex = 1
            lbl_homeDateTime.Text = "MM/DD/YY" & vbCrLf & "00:00 AM"
            ' 
            ' pnl_AddPatient
            ' 
            pnl_AddPatient.BackColor = Color.White
            pnl_AddPatient.BorderStyle = BorderStyle.FixedSingle
            pnl_AddPatient.Controls.Add(pnl_FirstName)
            pnl_AddPatient.Dock = DockStyle.Fill
            pnl_AddPatient.Location = New Point(0, 69)
            pnl_AddPatient.Name = "pnl_AddPatient"
            pnl_AddPatient.Size = New Size(1192, 621)
            pnl_AddPatient.TabIndex = 5
            ' 
            ' pnl_FirstName
            ' 
            pnl_FirstName.BackColor = Color.FromArgb(CByte(192), CByte(251), CByte(204))
            pnl_FirstName.BorderStyle = BorderStyle.FixedSingle
            pnl_FirstName.Controls.Add(txt_FirstName)
            pnl_FirstName.Location = New Point(118, 54)
            pnl_FirstName.Name = "pnl_FirstName"
            pnl_FirstName.Padding = New Padding(8)
            pnl_FirstName.Size = New Size(339, 58)
            pnl_FirstName.TabIndex = 3
            ' 
            ' txt_FirstName
            ' 
            txt_FirstName.BackColor = Color.FromArgb(CByte(192), CByte(251), CByte(204))
            txt_FirstName.BorderStyle = BorderStyle.FixedSingle
            txt_FirstName.Dock = DockStyle.Fill
            txt_FirstName.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_FirstName.Location = New Point(8, 8)
            txt_FirstName.Multiline = True
            txt_FirstName.Name = "txt_FirstName"
            txt_FirstName.Size = New Size(321, 40)
            txt_FirstName.TabIndex = 2
            ' 
            ' cf_AddPatient
            ' 
            AutoScaleDimensions = New SizeF(7F, 15F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
            ClientSize = New Size(1192, 690)
            Controls.Add(pnl_AddPatient)
            Controls.Add(pnl_MainHeader)
            Controls.Add(Label1)
            FormBorderStyle = FormBorderStyle.None
            Name = "cf_AddPatient"
            Text = "cf_ApmntWeek"
            pnl_MainHeader.ResumeLayout(False)
            pnl_MainHeader.PerformLayout()
            pnl_AddPatient.ResumeLayout(False)
            pnl_FirstName.ResumeLayout(False)
            pnl_FirstName.PerformLayout()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents Label1 As Label
        Friend WithEvents pnl_MainHeader As Panel
        Friend WithEvents btn_patientAddNew As Button
        Friend WithEvents Label2 As Label
        Friend WithEvents lbl_homeDateTime As Label
        Friend WithEvents btn_ClearFields As Button
        Friend WithEvents btn_Back As Button
        Friend WithEvents Label6 As Label
        Friend WithEvents pnl_AddPatient As Panel
        Friend WithEvents txt_FirstName As TextBox
        Friend WithEvents pnl_FirstName As Panel
    End Class

End Namespace
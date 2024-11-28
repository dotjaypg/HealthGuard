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
            btn_AddPatient = New Button()
            btn_patientAddNew = New Button()
            Label2 = New Label()
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
            pnl_MainHeader.Controls.Add(Label6)
            pnl_MainHeader.Controls.Add(btn_Back)
            pnl_MainHeader.Controls.Add(btn_AddPatient)
            pnl_MainHeader.Controls.Add(btn_patientAddNew)
            pnl_MainHeader.Controls.Add(Label2)
            pnl_MainHeader.Controls.Add(lbl_homeDateTime)
            pnl_MainHeader.Dock = DockStyle.Top
            pnl_MainHeader.Location = New Point(0, 0)
            pnl_MainHeader.Margin = New Padding(3, 2, 3, 2)
            pnl_MainHeader.Name = "pnl_MainHeader"
            pnl_MainHeader.Size = New Size(1232, 69)
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
            btn_Back.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_Back.BackColor = Color.FromArgb(CByte(71), CByte(102), CByte(59))
            btn_Back.FlatAppearance.BorderSize = 0
            btn_Back.FlatStyle = FlatStyle.Flat
            btn_Back.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btn_Back.ForeColor = Color.White
            btn_Back.Location = New Point(22, 17)
            btn_Back.Name = "btn_Back"
            btn_Back.Size = New Size(186, 34)
            btn_Back.TabIndex = 5
            btn_Back.Text = "Back"
            btn_Back.UseVisualStyleBackColor = False
            ' 
            ' btn_AddPatient
            ' 
            btn_AddPatient.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_AddPatient.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            btn_AddPatient.Location = New Point(1029, 17)
            btn_AddPatient.Name = "btn_AddPatient"
            btn_AddPatient.Size = New Size(186, 34)
            btn_AddPatient.TabIndex = 5
            btn_AddPatient.Text = "Add new appointment"
            btn_AddPatient.UseVisualStyleBackColor = True
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
            ' cf_AddPatient
            ' 
            AutoScaleDimensions = New SizeF(7F, 15F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
            ClientSize = New Size(1232, 799)
            Controls.Add(pnl_MainHeader)
            Controls.Add(Label1)
            Name = "cf_AddPatient"
            Text = "cf_ApmntWeek"
            pnl_MainHeader.ResumeLayout(False)
            pnl_MainHeader.PerformLayout()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents Label1 As Label
        Friend WithEvents pnl_MainHeader As Panel
        Friend WithEvents btn_patientAddNew As Button
        Friend WithEvents Label2 As Label
        Friend WithEvents lbl_homeDateTime As Label
        Friend WithEvents btn_AddPatient As Button
        Friend WithEvents btn_Back As Button
        Friend WithEvents Label6 As Label
    End Class

End Namespace
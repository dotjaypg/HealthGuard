Namespace PatientTab

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class cf_PatientData
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
            btn_ResetData = New Button()
            btn_SaveData = New Button()
            btn_Back = New Button()
            btn_patientAddNew = New Button()
            Label2 = New Label()
            lbl_PatientID = New Label()
            lbl_homeDateTime = New Label()
            pnl_PatientData = New Panel()
            pnl_MainHeader.SuspendLayout()
            SuspendLayout()
            ' 
            ' Label1
            ' 
            Label1.AutoSize = True
            Label1.Font = New Font("Segoe UI", 48.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            Label1.Location = New Point(156, 322)
            Label1.Name = "Label1"
            Label1.Size = New Size(0, 86)
            Label1.TabIndex = 0
            ' 
            ' pnl_MainHeader
            ' 
            pnl_MainHeader.BackColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
            pnl_MainHeader.BorderStyle = BorderStyle.FixedSingle
            pnl_MainHeader.Controls.Add(btn_ResetData)
            pnl_MainHeader.Controls.Add(btn_SaveData)
            pnl_MainHeader.Controls.Add(btn_Back)
            pnl_MainHeader.Controls.Add(btn_patientAddNew)
            pnl_MainHeader.Controls.Add(Label2)
            pnl_MainHeader.Controls.Add(lbl_PatientID)
            pnl_MainHeader.Controls.Add(lbl_homeDateTime)
            pnl_MainHeader.Dock = DockStyle.Top
            pnl_MainHeader.Location = New Point(0, 0)
            pnl_MainHeader.Margin = New Padding(3, 2, 3, 2)
            pnl_MainHeader.Name = "pnl_MainHeader"
            pnl_MainHeader.Size = New Size(1232, 69)
            pnl_MainHeader.TabIndex = 4
            ' 
            ' btn_ResetData
            ' 
            btn_ResetData.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_ResetData.BackColor = Color.Silver
            btn_ResetData.FlatStyle = FlatStyle.Flat
            btn_ResetData.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btn_ResetData.Location = New Point(1153, 16)
            btn_ResetData.Name = "btn_ResetData"
            btn_ResetData.Size = New Size(65, 34)
            btn_ResetData.TabIndex = 7
            btn_ResetData.Text = "Reset"
            btn_ResetData.UseVisualStyleBackColor = False
            ' 
            ' btn_SaveData
            ' 
            btn_SaveData.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_SaveData.BackColor = Color.Silver
            btn_SaveData.FlatStyle = FlatStyle.Flat
            btn_SaveData.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btn_SaveData.Location = New Point(1021, 16)
            btn_SaveData.Name = "btn_SaveData"
            btn_SaveData.Size = New Size(126, 34)
            btn_SaveData.TabIndex = 7
            btn_SaveData.Text = "Save Changes"
            btn_SaveData.UseVisualStyleBackColor = False
            ' 
            ' btn_Back
            ' 
            btn_Back.BackColor = Color.FromArgb(CByte(255), CByte(137), CByte(140))
            btn_Back.FlatStyle = FlatStyle.Flat
            btn_Back.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btn_Back.ForeColor = Color.Black
            btn_Back.Location = New Point(15, 16)
            btn_Back.Name = "btn_Back"
            btn_Back.Size = New Size(37, 34)
            btn_Back.TabIndex = 7
            btn_Back.Text = "X"
            btn_Back.UseVisualStyleBackColor = False
            ' 
            ' btn_patientAddNew
            ' 
            btn_patientAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_patientAddNew.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            btn_patientAddNew.Location = New Point(2085, 17)
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
            Label2.Location = New Point(3159, 14)
            Label2.Name = "Label2"
            Label2.Size = New Size(108, 44)
            Label2.TabIndex = 3
            Label2.Text = "MM/DD/YY" & vbCrLf & "00:00 AM"
            ' 
            ' lbl_PatientID
            ' 
            lbl_PatientID.AutoSize = True
            lbl_PatientID.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            lbl_PatientID.ForeColor = Color.Black
            lbl_PatientID.Location = New Point(63, 22)
            lbl_PatientID.Name = "lbl_PatientID"
            lbl_PatientID.Size = New Size(78, 22)
            lbl_PatientID.TabIndex = 1
            lbl_PatientID.Text = "P00000"
            ' 
            ' lbl_homeDateTime
            ' 
            lbl_homeDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            lbl_homeDateTime.AutoSize = True
            lbl_homeDateTime.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            lbl_homeDateTime.ForeColor = Color.White
            lbl_homeDateTime.Location = New Point(4208, 14)
            lbl_homeDateTime.Name = "lbl_homeDateTime"
            lbl_homeDateTime.Size = New Size(108, 44)
            lbl_homeDateTime.TabIndex = 1
            lbl_homeDateTime.Text = "MM/DD/YY" & vbCrLf & "00:00 AM"
            ' 
            ' pnl_PatientData
            ' 
            pnl_PatientData.BorderStyle = BorderStyle.FixedSingle
            pnl_PatientData.Dock = DockStyle.Fill
            pnl_PatientData.Location = New Point(0, 69)
            pnl_PatientData.Name = "pnl_PatientData"
            pnl_PatientData.Size = New Size(1232, 730)
            pnl_PatientData.TabIndex = 5
            ' 
            ' cf_PatientData
            ' 
            AutoScaleDimensions = New SizeF(7.0F, 15.0F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.White
            ClientSize = New Size(1232, 799)
            Controls.Add(pnl_PatientData)
            Controls.Add(pnl_MainHeader)
            Controls.Add(Label1)
            Name = "cf_PatientData"
            Text = "View Patient Data"
            TopMost = True
            pnl_MainHeader.ResumeLayout(False)
            pnl_MainHeader.PerformLayout()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents Label1 As Label
        Friend WithEvents pnl_MainHeader As Panel
        Friend WithEvents btn_patientAddNew As Button
        Friend WithEvents Label2 As Label
        Friend WithEvents lbl_PatientID As Label
        Friend WithEvents lbl_homeDateTime As Label
        Friend WithEvents btn_Back As Button
        Friend WithEvents btn_ResetData As Button
        Friend WithEvents btn_SaveData As Button
        Friend WithEvents pnl_PatientData As Panel
    End Class
End Namespace
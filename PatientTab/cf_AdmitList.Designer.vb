﻿Namespace PatientTab
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class cf_AdmitList
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
            pnl_MainHeader = New Panel()
            btn_patientAddNew = New Button()
            txt_homeSearch = New TextBox()
            Label2 = New Label()
            Label6 = New Label()
            lbl_homeDateTime = New Label()
            pnl_MainHeader.SuspendLayout()
            SuspendLayout()
            ' 
            ' pnl_MainHeader
            ' 
            pnl_MainHeader.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
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
            pnl_MainHeader.TabIndex = 3
            ' 
            ' btn_patientAddNew
            ' 
            btn_patientAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_patientAddNew.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            btn_patientAddNew.Location = New Point(1055, 17)
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
            txt_homeSearch.PlaceholderText = "Search for a patient"
            txt_homeSearch.Size = New Size(493, 29)
            txt_homeSearch.TabIndex = 4
            ' 
            ' Label2
            ' 
            Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            Label2.AutoSize = True
            Label2.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            Label2.ForeColor = Color.White
            Label2.Location = New Point(2129, 14)
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
            Label6.Size = New Size(172, 22)
            Label6.TabIndex = 1
            Label6.Text = "Admitted Patients"
            ' 
            ' lbl_homeDateTime
            ' 
            lbl_homeDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            lbl_homeDateTime.AutoSize = True
            lbl_homeDateTime.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            lbl_homeDateTime.ForeColor = Color.White
            lbl_homeDateTime.Location = New Point(3178, 14)
            lbl_homeDateTime.Name = "lbl_homeDateTime"
            lbl_homeDateTime.Size = New Size(108, 44)
            lbl_homeDateTime.TabIndex = 1
            lbl_homeDateTime.Text = "MM/DD/YY" & vbCrLf & "00:00 AM"
            ' 
            ' cf_AdmitList
            ' 
            AutoScaleDimensions = New SizeF(7F, 15F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
            ClientSize = New Size(1232, 799)
            Controls.Add(pnl_MainHeader)
            Name = "cf_AdmitList"
            Text = "cf_AdmitList"
            pnl_MainHeader.ResumeLayout(False)
            pnl_MainHeader.PerformLayout()
            ResumeLayout(False)
        End Sub

        Friend WithEvents pnl_MainHeader As Panel
        Friend WithEvents Label2 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents lbl_homeDateTime As Label
        Friend WithEvents txt_homeSearch As TextBox
        Friend WithEvents btn_patientAddNew As Button
    End Class
End Namespace
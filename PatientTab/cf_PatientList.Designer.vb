Namespace PatientTab
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class cf_PatientList
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
            components = New ComponentModel.Container()
            Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
            pnl_MainHeader = New Panel()
            btn_AddPatient = New Button()
            txt_homeSearch = New TextBox()
            Label2 = New Label()
            Label6 = New Label()
            lbl_homeDateTime = New Label()
            DBConnectionBindingSource = New BindingSource(components)
            dgv_PatientTable = New DataGridView()
            pnl_PatientList = New Panel()
            pnl_MainHeader.SuspendLayout()
            CType(DBConnectionBindingSource, ComponentModel.ISupportInitialize).BeginInit()
            CType(dgv_PatientTable, ComponentModel.ISupportInitialize).BeginInit()
            pnl_PatientList.SuspendLayout()
            SuspendLayout()
            ' 
            ' pnl_MainHeader
            ' 
            pnl_MainHeader.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
            pnl_MainHeader.BorderStyle = BorderStyle.FixedSingle
            pnl_MainHeader.Controls.Add(btn_AddPatient)
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
            ' btn_AddPatient
            ' 
            btn_AddPatient.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_AddPatient.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            btn_AddPatient.Location = New Point(1053, 17)
            btn_AddPatient.Name = "btn_AddPatient"
            btn_AddPatient.Size = New Size(160, 34)
            btn_AddPatient.TabIndex = 4
            btn_AddPatient.Text = "Add new patient"
            btn_AddPatient.UseVisualStyleBackColor = True
            ' 
            ' txt_homeSearch
            ' 
            txt_homeSearch.Anchor = AnchorStyles.Top
            txt_homeSearch.BorderStyle = BorderStyle.None
            txt_homeSearch.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_homeSearch.Location = New Point(396, 20)
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
            Label2.Location = New Point(2127, 14)
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
            Label6.Size = New Size(124, 22)
            Label6.TabIndex = 1
            Label6.Text = "Patients List"
            ' 
            ' lbl_homeDateTime
            ' 
            lbl_homeDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            lbl_homeDateTime.AutoSize = True
            lbl_homeDateTime.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            lbl_homeDateTime.ForeColor = Color.White
            lbl_homeDateTime.Location = New Point(3176, 14)
            lbl_homeDateTime.Name = "lbl_homeDateTime"
            lbl_homeDateTime.Size = New Size(108, 44)
            lbl_homeDateTime.TabIndex = 1
            lbl_homeDateTime.Text = "MM/DD/YY" & vbCrLf & "00:00 AM"
            ' 
            ' DBConnectionBindingSource
            ' 
            DBConnectionBindingSource.DataSource = GetType(DBConnection)
            ' 
            ' dgv_PatientTable
            ' 
            dgv_PatientTable.AllowUserToAddRows = False
            dgv_PatientTable.AllowUserToDeleteRows = False
            dgv_PatientTable.AllowUserToResizeColumns = False
            dgv_PatientTable.AllowUserToResizeRows = False
            DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
            dgv_PatientTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
            dgv_PatientTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgv_PatientTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgv_PatientTable.BackgroundColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
            dgv_PatientTable.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
            DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
            DataGridViewCellStyle10.Font = New Font("Segoe UI", 9F)
            DataGridViewCellStyle10.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle10.SelectionBackColor = Color.DimGray
            DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
            dgv_PatientTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
            dgv_PatientTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = SystemColors.Window
            DataGridViewCellStyle11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            DataGridViewCellStyle11.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle11.Padding = New Padding(5)
            DataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(CByte(161), CByte(243), CByte(175))
            DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = DataGridViewTriState.False
            dgv_PatientTable.DefaultCellStyle = DataGridViewCellStyle11
            dgv_PatientTable.Dock = DockStyle.Fill
            dgv_PatientTable.EditMode = DataGridViewEditMode.EditProgrammatically
            dgv_PatientTable.EnableHeadersVisualStyles = False
            dgv_PatientTable.Location = New Point(20, 20)
            dgv_PatientTable.Name = "dgv_PatientTable"
            dgv_PatientTable.ReadOnly = True
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
            DataGridViewCellStyle12.Font = New Font("Segoe UI", 9F)
            DataGridViewCellStyle12.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = Color.Transparent
            DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
            dgv_PatientTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
            dgv_PatientTable.RowTemplate.ReadOnly = True
            dgv_PatientTable.Size = New Size(1192, 690)
            dgv_PatientTable.TabIndex = 4
            ' 
            ' pnl_PatientList
            ' 
            pnl_PatientList.Controls.Add(dgv_PatientTable)
            pnl_PatientList.Dock = DockStyle.Fill
            pnl_PatientList.Location = New Point(0, 69)
            pnl_PatientList.Name = "pnl_PatientList"
            pnl_PatientList.Padding = New Padding(20)
            pnl_PatientList.Size = New Size(1232, 730)
            pnl_PatientList.TabIndex = 5
            ' 
            ' cf_PatientList
            ' 
            AutoScaleDimensions = New SizeF(7F, 15F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
            ClientSize = New Size(1232, 799)
            Controls.Add(pnl_PatientList)
            Controls.Add(pnl_MainHeader)
            Name = "cf_PatientList"
            Text = "cf_PatientList"
            pnl_MainHeader.ResumeLayout(False)
            pnl_MainHeader.PerformLayout()
            CType(DBConnectionBindingSource, ComponentModel.ISupportInitialize).EndInit()
            CType(dgv_PatientTable, ComponentModel.ISupportInitialize).EndInit()
            pnl_PatientList.ResumeLayout(False)
            ResumeLayout(False)
        End Sub

        Friend WithEvents pnl_MainHeader As Panel
        Friend WithEvents Label2 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents lbl_homeDateTime As Label
        Friend WithEvents txt_homeSearch As TextBox
        Friend WithEvents btn_AddPatient As Button
        Friend WithEvents DBConnectionBindingSource As BindingSource
        Friend WithEvents dgv_PatientTable As DataGridView
        Friend WithEvents pnl_PatientList As Panel
    End Class
End Namespace
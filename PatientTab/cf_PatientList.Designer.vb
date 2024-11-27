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
            Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
            pnl_MainHeader = New Panel()
            btn_patientAddNew = New Button()
            txt_homeSearch = New TextBox()
            Label2 = New Label()
            Label6 = New Label()
            lbl_homeDateTime = New Label()
            DBConnectionBindingSource = New BindingSource(components)
            dgv_PatientTable = New DataGridView()
            pnl_PatientList = New Panel()
            PatientId = New DataGridViewTextBoxColumn()
            FirstName = New DataGridViewTextBoxColumn()
            MiddleName = New DataGridViewTextBoxColumn()
            LastName = New DataGridViewTextBoxColumn()
            Sex = New DataGridViewTextBoxColumn()
            DateOfBirth = New DataGridViewTextBoxColumn()
            Actions = New DataGridViewTextBoxColumn()
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
            btn_patientAddNew.Location = New Point(1053, 17)
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
            dgv_PatientTable.AllowUserToOrderColumns = True
            dgv_PatientTable.AllowUserToResizeColumns = False
            dgv_PatientTable.AllowUserToResizeRows = False
            dgv_PatientTable.BackgroundColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
            dgv_PatientTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dgv_PatientTable.Columns.AddRange(New DataGridViewColumn() {PatientId, FirstName, MiddleName, LastName, Sex, DateOfBirth, Actions})
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = SystemColors.Window
            DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
            dgv_PatientTable.DefaultCellStyle = DataGridViewCellStyle1
            dgv_PatientTable.Dock = DockStyle.Fill
            dgv_PatientTable.Location = New Point(30, 30)
            dgv_PatientTable.Name = "dgv_PatientTable"
            dgv_PatientTable.Size = New Size(1172, 670)
            dgv_PatientTable.TabIndex = 4
            ' 
            ' pnl_PatientList
            ' 
            pnl_PatientList.Controls.Add(dgv_PatientTable)
            pnl_PatientList.Dock = DockStyle.Fill
            pnl_PatientList.Location = New Point(0, 69)
            pnl_PatientList.Name = "pnl_PatientList"
            pnl_PatientList.Padding = New Padding(30)
            pnl_PatientList.Size = New Size(1232, 730)
            pnl_PatientList.TabIndex = 5
            ' 
            ' PatientId
            ' 
            PatientId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            PatientId.HeaderText = "Patient ID"
            PatientId.Name = "PatientId"
            ' 
            ' FirstName
            ' 
            FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            FirstName.HeaderText = "First Name"
            FirstName.Name = "FirstName"
            ' 
            ' MiddleName
            ' 
            MiddleName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            MiddleName.HeaderText = "Middle Name"
            MiddleName.Name = "MiddleName"
            ' 
            ' LastName
            ' 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            LastName.HeaderText = "Last Name"
            LastName.Name = "LastName"
            ' 
            ' Sex
            ' 
            Sex.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Sex.HeaderText = "Sex"
            Sex.Name = "Sex"
            ' 
            ' DateOfBirth
            ' 
            DateOfBirth.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            DateOfBirth.HeaderText = "Date of Birth"
            DateOfBirth.Name = "DateOfBirth"
            ' 
            ' Actions
            ' 
            Actions.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Actions.HeaderText = "Actions"
            Actions.Name = "Actions"
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
        Friend WithEvents btn_patientAddNew As Button
        Friend WithEvents DBConnectionBindingSource As BindingSource
        Friend WithEvents dgv_PatientTable As DataGridView
        Friend WithEvents pnl_PatientList As Panel
        Friend WithEvents PatientId As DataGridViewTextBoxColumn
        Friend WithEvents FirstName As DataGridViewTextBoxColumn
        Friend WithEvents MiddleName As DataGridViewTextBoxColumn
        Friend WithEvents LastName As DataGridViewTextBoxColumn
        Friend WithEvents Sex As DataGridViewTextBoxColumn
        Friend WithEvents DateOfBirth As DataGridViewTextBoxColumn
        Friend WithEvents Actions As DataGridViewTextBoxColumn
    End Class
End Namespace
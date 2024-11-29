Namespace AccountTab

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class cf_AccData
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
            pnl_MainHeader = New Panel()
            btn_ResetData = New Button()
            btn_SaveData = New Button()
            btn_Back = New Button()
            btn_patientAddNew = New Button()
            Label2 = New Label()
            lbl_EditPatient = New Label()
            lbl_PatientID = New Label()
            lbl_homeDateTime = New Label()
            lbl_Name = New Label()
            pnl_FirstName = New Panel()
            txt_FirstName = New TextBox()
            Label1 = New Label()
            Panel1 = New Panel()
            txt_MiddleName = New TextBox()
            Label3 = New Label()
            Panel3 = New Panel()
            txt_LastName = New TextBox()
            Label4 = New Label()
            Panel4 = New Panel()
            txt_Sex = New TextBox()
            Label5 = New Label()
            Panel5 = New Panel()
            dtp_DateOfBirth = New DateTimePicker()
            Label6 = New Label()
            Panel6 = New Panel()
            txt_Age = New TextBox()
            pnl_PatientData = New Panel()
            Label8 = New Label()
            Panel9 = New Panel()
            txt_ParentGuardian = New TextBox()
            Panel11 = New Panel()
            txt_Address = New TextBox()
            Panel10 = New Panel()
            txt_Email = New TextBox()
            Panel8 = New Panel()
            txt_Phone = New TextBox()
            Panel7 = New Panel()
            cmb_BloodType = New ComboBox()
            lbl_Address = New Label()
            lbl_ParentGuardian = New Label()
            lbl_Email = New Label()
            lbl_Phone = New Label()
            Label7 = New Label()
            Panel2 = New Panel()
            txt_PrimaryDiagnoses = New TextBox()
            DBConnectionBindingSource = New BindingSource(components)
            pnl_MainHeader.SuspendLayout()
            pnl_FirstName.SuspendLayout()
            Panel1.SuspendLayout()
            Panel3.SuspendLayout()
            Panel4.SuspendLayout()
            Panel5.SuspendLayout()
            Panel6.SuspendLayout()
            pnl_PatientData.SuspendLayout()
            Panel9.SuspendLayout()
            Panel11.SuspendLayout()
            Panel10.SuspendLayout()
            Panel8.SuspendLayout()
            Panel7.SuspendLayout()
            Panel2.SuspendLayout()
            CType(DBConnectionBindingSource, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' pnl_MainHeader
            ' 
            pnl_MainHeader.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
            pnl_MainHeader.BorderStyle = BorderStyle.FixedSingle
            pnl_MainHeader.Controls.Add(btn_ResetData)
            pnl_MainHeader.Controls.Add(btn_SaveData)
            pnl_MainHeader.Controls.Add(btn_Back)
            pnl_MainHeader.Controls.Add(btn_patientAddNew)
            pnl_MainHeader.Controls.Add(Label2)
            pnl_MainHeader.Controls.Add(lbl_EditPatient)
            pnl_MainHeader.Controls.Add(lbl_PatientID)
            pnl_MainHeader.Controls.Add(lbl_homeDateTime)
            pnl_MainHeader.Dock = DockStyle.Top
            pnl_MainHeader.Location = New Point(0, 0)
            pnl_MainHeader.Margin = New Padding(3, 2, 3, 2)
            pnl_MainHeader.Name = "pnl_MainHeader"
            pnl_MainHeader.Size = New Size(596, 69)
            pnl_MainHeader.TabIndex = 4
            ' 
            ' btn_ResetData
            ' 
            btn_ResetData.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_ResetData.BackColor = Color.Silver
            btn_ResetData.FlatStyle = FlatStyle.Flat
            btn_ResetData.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btn_ResetData.Location = New Point(517, 17)
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
            btn_SaveData.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btn_SaveData.Location = New Point(370, 17)
            btn_SaveData.Name = "btn_SaveData"
            btn_SaveData.Size = New Size(132, 34)
            btn_SaveData.TabIndex = 7
            btn_SaveData.Text = "Save Changes"
            btn_SaveData.UseVisualStyleBackColor = False
            ' 
            ' btn_Back
            ' 
            btn_Back.BackColor = Color.FromArgb(CByte(255), CByte(137), CByte(140))
            btn_Back.FlatStyle = FlatStyle.Flat
            btn_Back.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
            btn_patientAddNew.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            btn_patientAddNew.Location = New Point(1449, 17)
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
            Label2.Location = New Point(2523, 14)
            Label2.Name = "Label2"
            Label2.Size = New Size(108, 44)
            Label2.TabIndex = 3
            Label2.Text = "MM/DD/YY" & vbCrLf & "00:00 AM"
            ' 
            ' lbl_EditPatient
            ' 
            lbl_EditPatient.AutoSize = True
            lbl_EditPatient.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            lbl_EditPatient.ForeColor = Color.White
            lbl_EditPatient.ImageAlign = ContentAlignment.MiddleLeft
            lbl_EditPatient.Location = New Point(65, 22)
            lbl_EditPatient.Name = "lbl_EditPatient"
            lbl_EditPatient.Size = New Size(127, 22)
            lbl_EditPatient.TabIndex = 1
            lbl_EditPatient.Text = "Edit Account"
            ' 
            ' lbl_PatientID
            ' 
            lbl_PatientID.AutoSize = True
            lbl_PatientID.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            lbl_PatientID.ForeColor = Color.White
            lbl_PatientID.Location = New Point(201, 18)
            lbl_PatientID.Name = "lbl_PatientID"
            lbl_PatientID.Size = New Size(95, 29)
            lbl_PatientID.TabIndex = 1
            lbl_PatientID.Text = "A00000"
            ' 
            ' lbl_homeDateTime
            ' 
            lbl_homeDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            lbl_homeDateTime.AutoSize = True
            lbl_homeDateTime.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            lbl_homeDateTime.ForeColor = Color.White
            lbl_homeDateTime.Location = New Point(3572, 14)
            lbl_homeDateTime.Name = "lbl_homeDateTime"
            lbl_homeDateTime.Size = New Size(108, 44)
            lbl_homeDateTime.TabIndex = 1
            lbl_homeDateTime.Text = "MM/DD/YY" & vbCrLf & "00:00 AM"
            ' 
            ' lbl_Name
            ' 
            lbl_Name.AutoSize = True
            lbl_Name.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            lbl_Name.ForeColor = Color.Black
            lbl_Name.ImageAlign = ContentAlignment.MiddleLeft
            lbl_Name.Location = New Point(25, 97)
            lbl_Name.Name = "lbl_Name"
            lbl_Name.Size = New Size(112, 24)
            lbl_Name.TabIndex = 5
            lbl_Name.Text = "First Name"
            lbl_Name.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' pnl_FirstName
            ' 
            pnl_FirstName.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            pnl_FirstName.Controls.Add(txt_FirstName)
            pnl_FirstName.Location = New Point(168, 85)
            pnl_FirstName.Name = "pnl_FirstName"
            pnl_FirstName.Padding = New Padding(5)
            pnl_FirstName.Size = New Size(401, 47)
            pnl_FirstName.TabIndex = 7
            ' 
            ' txt_FirstName
            ' 
            txt_FirstName.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            txt_FirstName.BorderStyle = BorderStyle.None
            txt_FirstName.Dock = DockStyle.Fill
            txt_FirstName.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_FirstName.Location = New Point(5, 5)
            txt_FirstName.Margin = New Padding(3, 2, 3, 2)
            txt_FirstName.Multiline = True
            txt_FirstName.Name = "txt_FirstName"
            txt_FirstName.Size = New Size(391, 37)
            txt_FirstName.TabIndex = 6
            ' 
            ' Label1
            ' 
            Label1.AutoSize = True
            Label1.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            Label1.ForeColor = Color.Black
            Label1.ImageAlign = ContentAlignment.MiddleLeft
            Label1.Location = New Point(25, 159)
            Label1.Name = "Label1"
            Label1.Size = New Size(130, 24)
            Label1.TabIndex = 5
            Label1.Text = "Middle Name"
            Label1.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' Panel1
            ' 
            Panel1.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            Panel1.Controls.Add(txt_MiddleName)
            Panel1.Location = New Point(168, 147)
            Panel1.Name = "Panel1"
            Panel1.Padding = New Padding(5)
            Panel1.Size = New Size(401, 47)
            Panel1.TabIndex = 7
            ' 
            ' txt_MiddleName
            ' 
            txt_MiddleName.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            txt_MiddleName.BorderStyle = BorderStyle.None
            txt_MiddleName.Dock = DockStyle.Fill
            txt_MiddleName.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_MiddleName.Location = New Point(5, 5)
            txt_MiddleName.Margin = New Padding(3, 2, 3, 2)
            txt_MiddleName.Multiline = True
            txt_MiddleName.Name = "txt_MiddleName"
            txt_MiddleName.Size = New Size(391, 37)
            txt_MiddleName.TabIndex = 6
            ' 
            ' Label3
            ' 
            Label3.AutoSize = True
            Label3.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            Label3.ForeColor = Color.Black
            Label3.ImageAlign = ContentAlignment.MiddleLeft
            Label3.Location = New Point(25, 219)
            Label3.Name = "Label3"
            Label3.Size = New Size(111, 24)
            Label3.TabIndex = 5
            Label3.Text = "Last Name"
            Label3.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' Panel3
            ' 
            Panel3.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            Panel3.Controls.Add(txt_LastName)
            Panel3.Location = New Point(168, 207)
            Panel3.Name = "Panel3"
            Panel3.Padding = New Padding(5)
            Panel3.Size = New Size(401, 47)
            Panel3.TabIndex = 7
            ' 
            ' txt_LastName
            ' 
            txt_LastName.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            txt_LastName.BorderStyle = BorderStyle.None
            txt_LastName.Dock = DockStyle.Fill
            txt_LastName.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_LastName.Location = New Point(5, 5)
            txt_LastName.Margin = New Padding(3, 2, 3, 2)
            txt_LastName.Multiline = True
            txt_LastName.Name = "txt_LastName"
            txt_LastName.Size = New Size(391, 37)
            txt_LastName.TabIndex = 6
            ' 
            ' Label4
            ' 
            Label4.AutoSize = True
            Label4.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            Label4.ForeColor = Color.Black
            Label4.ImageAlign = ContentAlignment.MiddleLeft
            Label4.Location = New Point(25, 279)
            Label4.Name = "Label4"
            Label4.Size = New Size(46, 24)
            Label4.TabIndex = 5
            Label4.Text = "Sex"
            Label4.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' Panel4
            ' 
            Panel4.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            Panel4.Controls.Add(txt_Sex)
            Panel4.Location = New Point(168, 267)
            Panel4.Name = "Panel4"
            Panel4.Padding = New Padding(5)
            Panel4.Size = New Size(401, 47)
            Panel4.TabIndex = 7
            ' 
            ' txt_Sex
            ' 
            txt_Sex.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            txt_Sex.BorderStyle = BorderStyle.None
            txt_Sex.Dock = DockStyle.Fill
            txt_Sex.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_Sex.Location = New Point(5, 5)
            txt_Sex.Margin = New Padding(3, 2, 3, 2)
            txt_Sex.Multiline = True
            txt_Sex.Name = "txt_Sex"
            txt_Sex.Size = New Size(391, 37)
            txt_Sex.TabIndex = 6
            ' 
            ' Label5
            ' 
            Label5.AutoSize = True
            Label5.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            Label5.ForeColor = Color.Black
            Label5.ImageAlign = ContentAlignment.MiddleLeft
            Label5.Location = New Point(25, 339)
            Label5.Name = "Label5"
            Label5.Size = New Size(128, 24)
            Label5.TabIndex = 5
            Label5.Text = "Date of Birth"
            Label5.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' Panel5
            ' 
            Panel5.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            Panel5.Controls.Add(dtp_DateOfBirth)
            Panel5.Location = New Point(168, 327)
            Panel5.Name = "Panel5"
            Panel5.Padding = New Padding(5)
            Panel5.Size = New Size(401, 47)
            Panel5.TabIndex = 7
            ' 
            ' dtp_DateOfBirth
            ' 
            dtp_DateOfBirth.CalendarMonthBackground = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            dtp_DateOfBirth.CalendarTitleBackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            dtp_DateOfBirth.Checked = False
            dtp_DateOfBirth.CustomFormat = "MM/DD/YYYY"
            dtp_DateOfBirth.Dock = DockStyle.Fill
            dtp_DateOfBirth.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            dtp_DateOfBirth.Format = DateTimePickerFormat.Short
            dtp_DateOfBirth.Location = New Point(5, 5)
            dtp_DateOfBirth.MaxDate = New Date(2024, 12, 31, 0, 0, 0, 0)
            dtp_DateOfBirth.Name = "dtp_DateOfBirth"
            dtp_DateOfBirth.Size = New Size(391, 35)
            dtp_DateOfBirth.TabIndex = 9
            dtp_DateOfBirth.Value = New Date(2024, 1, 1, 0, 0, 0, 0)
            ' 
            ' Label6
            ' 
            Label6.AutoSize = True
            Label6.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            Label6.ForeColor = Color.Black
            Label6.ImageAlign = ContentAlignment.MiddleLeft
            Label6.Location = New Point(26, 399)
            Label6.Name = "Label6"
            Label6.Size = New Size(46, 24)
            Label6.TabIndex = 5
            Label6.Text = "Age"
            Label6.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' Panel6
            ' 
            Panel6.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            Panel6.Controls.Add(txt_Age)
            Panel6.Location = New Point(168, 387)
            Panel6.Name = "Panel6"
            Panel6.Padding = New Padding(5)
            Panel6.Size = New Size(401, 47)
            Panel6.TabIndex = 7
            ' 
            ' txt_Age
            ' 
            txt_Age.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            txt_Age.BorderStyle = BorderStyle.None
            txt_Age.Dock = DockStyle.Fill
            txt_Age.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_Age.Location = New Point(5, 5)
            txt_Age.Margin = New Padding(3, 2, 3, 2)
            txt_Age.Multiline = True
            txt_Age.Name = "txt_Age"
            txt_Age.ReadOnly = True
            txt_Age.Size = New Size(391, 37)
            txt_Age.TabIndex = 6
            ' 
            ' pnl_PatientData
            ' 
            pnl_PatientData.Controls.Add(Label8)
            pnl_PatientData.Controls.Add(lbl_Name)
            pnl_PatientData.Controls.Add(Panel5)
            pnl_PatientData.Controls.Add(Label1)
            pnl_PatientData.Controls.Add(Panel9)
            pnl_PatientData.Controls.Add(Panel11)
            pnl_PatientData.Controls.Add(Panel10)
            pnl_PatientData.Controls.Add(Panel8)
            pnl_PatientData.Controls.Add(Panel7)
            pnl_PatientData.Controls.Add(Panel6)
            pnl_PatientData.Controls.Add(Label3)
            pnl_PatientData.Controls.Add(Panel4)
            pnl_PatientData.Controls.Add(Label4)
            pnl_PatientData.Controls.Add(Panel3)
            pnl_PatientData.Controls.Add(lbl_Address)
            pnl_PatientData.Controls.Add(lbl_ParentGuardian)
            pnl_PatientData.Controls.Add(lbl_Email)
            pnl_PatientData.Controls.Add(lbl_Phone)
            pnl_PatientData.Controls.Add(Label5)
            pnl_PatientData.Controls.Add(Label7)
            pnl_PatientData.Controls.Add(Panel1)
            pnl_PatientData.Controls.Add(Panel2)
            pnl_PatientData.Controls.Add(Label6)
            pnl_PatientData.Controls.Add(pnl_FirstName)
            pnl_PatientData.Dock = DockStyle.Fill
            pnl_PatientData.Location = New Point(0, 69)
            pnl_PatientData.Name = "pnl_PatientData"
            pnl_PatientData.Size = New Size(596, 789)
            pnl_PatientData.TabIndex = 9
            ' 
            ' Label8
            ' 
            Label8.AutoSize = True
            Label8.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            Label8.ForeColor = Color.Black
            Label8.ImageAlign = ContentAlignment.MiddleLeft
            Label8.Location = New Point(25, 36)
            Label8.Name = "Label8"
            Label8.Size = New Size(141, 18)
            Label8.TabIndex = 5
            Label8.Text = "Primary Diagnosis:"
            Label8.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' Panel9
            ' 
            Panel9.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            Panel9.Controls.Add(txt_ParentGuardian)
            Panel9.Location = New Point(168, 573)
            Panel9.Name = "Panel9"
            Panel9.Padding = New Padding(5)
            Panel9.Size = New Size(401, 47)
            Panel9.TabIndex = 7
            ' 
            ' txt_ParentGuardian
            ' 
            txt_ParentGuardian.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            txt_ParentGuardian.BorderStyle = BorderStyle.None
            txt_ParentGuardian.Dock = DockStyle.Fill
            txt_ParentGuardian.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_ParentGuardian.Location = New Point(5, 5)
            txt_ParentGuardian.Margin = New Padding(3, 2, 3, 2)
            txt_ParentGuardian.Multiline = True
            txt_ParentGuardian.Name = "txt_ParentGuardian"
            txt_ParentGuardian.Size = New Size(391, 37)
            txt_ParentGuardian.TabIndex = 6
            ' 
            ' Panel11
            ' 
            Panel11.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            Panel11.Controls.Add(txt_Address)
            Panel11.Location = New Point(168, 693)
            Panel11.Name = "Panel11"
            Panel11.Padding = New Padding(5)
            Panel11.Size = New Size(401, 75)
            Panel11.TabIndex = 7
            ' 
            ' txt_Address
            ' 
            txt_Address.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            txt_Address.BorderStyle = BorderStyle.None
            txt_Address.Dock = DockStyle.Fill
            txt_Address.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_Address.Location = New Point(5, 5)
            txt_Address.Margin = New Padding(3, 2, 3, 2)
            txt_Address.Multiline = True
            txt_Address.Name = "txt_Address"
            txt_Address.Size = New Size(391, 65)
            txt_Address.TabIndex = 6
            ' 
            ' Panel10
            ' 
            Panel10.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            Panel10.Controls.Add(txt_Email)
            Panel10.Location = New Point(168, 633)
            Panel10.Name = "Panel10"
            Panel10.Padding = New Padding(5)
            Panel10.Size = New Size(401, 47)
            Panel10.TabIndex = 7
            ' 
            ' txt_Email
            ' 
            txt_Email.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            txt_Email.BorderStyle = BorderStyle.None
            txt_Email.Dock = DockStyle.Fill
            txt_Email.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_Email.Location = New Point(5, 5)
            txt_Email.Margin = New Padding(3, 2, 3, 2)
            txt_Email.Multiline = True
            txt_Email.Name = "txt_Email"
            txt_Email.Size = New Size(391, 37)
            txt_Email.TabIndex = 6
            ' 
            ' Panel8
            ' 
            Panel8.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            Panel8.Controls.Add(txt_Phone)
            Panel8.Location = New Point(168, 511)
            Panel8.Name = "Panel8"
            Panel8.Padding = New Padding(5)
            Panel8.Size = New Size(401, 47)
            Panel8.TabIndex = 7
            ' 
            ' txt_Phone
            ' 
            txt_Phone.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            txt_Phone.BorderStyle = BorderStyle.None
            txt_Phone.Dock = DockStyle.Fill
            txt_Phone.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_Phone.Location = New Point(5, 5)
            txt_Phone.Margin = New Padding(3, 2, 3, 2)
            txt_Phone.MaxLength = 12
            txt_Phone.Multiline = True
            txt_Phone.Name = "txt_Phone"
            txt_Phone.Size = New Size(391, 37)
            txt_Phone.TabIndex = 6
            ' 
            ' Panel7
            ' 
            Panel7.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            Panel7.Controls.Add(cmb_BloodType)
            Panel7.Location = New Point(168, 449)
            Panel7.Name = "Panel7"
            Panel7.Padding = New Padding(5)
            Panel7.Size = New Size(401, 47)
            Panel7.TabIndex = 7
            ' 
            ' cmb_BloodType
            ' 
            cmb_BloodType.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            cmb_BloodType.Dock = DockStyle.Fill
            cmb_BloodType.FlatStyle = FlatStyle.Flat
            cmb_BloodType.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            cmb_BloodType.FormattingEnabled = True
            cmb_BloodType.Items.AddRange(New Object() {"A+", "A -", "B+", "B -", "O+", "O -", "AB+", "AB -"})
            cmb_BloodType.Location = New Point(5, 5)
            cmb_BloodType.Name = "cmb_BloodType"
            cmb_BloodType.Size = New Size(391, 38)
            cmb_BloodType.TabIndex = 9
            ' 
            ' lbl_Address
            ' 
            lbl_Address.AutoSize = True
            lbl_Address.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            lbl_Address.ForeColor = Color.Black
            lbl_Address.ImageAlign = ContentAlignment.MiddleLeft
            lbl_Address.Location = New Point(25, 705)
            lbl_Address.Name = "lbl_Address"
            lbl_Address.Size = New Size(86, 24)
            lbl_Address.TabIndex = 5
            lbl_Address.Text = "Address"
            lbl_Address.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lbl_ParentGuardian
            ' 
            lbl_ParentGuardian.AutoSize = True
            lbl_ParentGuardian.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            lbl_ParentGuardian.ForeColor = Color.Black
            lbl_ParentGuardian.ImageAlign = ContentAlignment.MiddleLeft
            lbl_ParentGuardian.Location = New Point(26, 587)
            lbl_ParentGuardian.Name = "lbl_ParentGuardian"
            lbl_ParentGuardian.Size = New Size(130, 18)
            lbl_ParentGuardian.TabIndex = 5
            lbl_ParentGuardian.Text = "Parent / Guardian"
            lbl_ParentGuardian.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lbl_Email
            ' 
            lbl_Email.AutoSize = True
            lbl_Email.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            lbl_Email.ForeColor = Color.Black
            lbl_Email.ImageAlign = ContentAlignment.MiddleLeft
            lbl_Email.Location = New Point(25, 645)
            lbl_Email.Name = "lbl_Email"
            lbl_Email.Size = New Size(61, 24)
            lbl_Email.TabIndex = 5
            lbl_Email.Text = "Email"
            lbl_Email.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lbl_Phone
            ' 
            lbl_Phone.AutoSize = True
            lbl_Phone.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            lbl_Phone.ForeColor = Color.Black
            lbl_Phone.ImageAlign = ContentAlignment.MiddleLeft
            lbl_Phone.Location = New Point(25, 523)
            lbl_Phone.Name = "lbl_Phone"
            lbl_Phone.Size = New Size(70, 24)
            lbl_Phone.TabIndex = 5
            lbl_Phone.Text = "Phone"
            lbl_Phone.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' Label7
            ' 
            Label7.AutoSize = True
            Label7.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            Label7.ForeColor = Color.Black
            Label7.ImageAlign = ContentAlignment.MiddleLeft
            Label7.Location = New Point(25, 461)
            Label7.Name = "Label7"
            Label7.Size = New Size(114, 24)
            Label7.TabIndex = 5
            Label7.Text = "Blood Type"
            Label7.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' Panel2
            ' 
            Panel2.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            Panel2.Controls.Add(txt_PrimaryDiagnoses)
            Panel2.Location = New Point(168, 22)
            Panel2.Name = "Panel2"
            Panel2.Padding = New Padding(5)
            Panel2.Size = New Size(401, 47)
            Panel2.TabIndex = 7
            ' 
            ' txt_PrimaryDiagnoses
            ' 
            txt_PrimaryDiagnoses.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            txt_PrimaryDiagnoses.BorderStyle = BorderStyle.None
            txt_PrimaryDiagnoses.Dock = DockStyle.Fill
            txt_PrimaryDiagnoses.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_PrimaryDiagnoses.Location = New Point(5, 5)
            txt_PrimaryDiagnoses.Margin = New Padding(3, 2, 3, 2)
            txt_PrimaryDiagnoses.Multiline = True
            txt_PrimaryDiagnoses.Name = "txt_PrimaryDiagnoses"
            txt_PrimaryDiagnoses.Size = New Size(391, 37)
            txt_PrimaryDiagnoses.TabIndex = 6
            ' 
            ' DBConnectionBindingSource
            ' 
            DBConnectionBindingSource.DataSource = GetType(DBConnection)
            ' 
            ' cf_AccData
            ' 
            AutoScaleDimensions = New SizeF(7F, 15F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.White
            ClientSize = New Size(596, 858)
            Controls.Add(pnl_PatientData)
            Controls.Add(pnl_MainHeader)
            Name = "cf_AccData"
            Text = "View Patient Data"
            TopMost = True
            pnl_MainHeader.ResumeLayout(False)
            pnl_MainHeader.PerformLayout()
            pnl_FirstName.ResumeLayout(False)
            pnl_FirstName.PerformLayout()
            Panel1.ResumeLayout(False)
            Panel1.PerformLayout()
            Panel3.ResumeLayout(False)
            Panel3.PerformLayout()
            Panel4.ResumeLayout(False)
            Panel4.PerformLayout()
            Panel5.ResumeLayout(False)
            Panel6.ResumeLayout(False)
            Panel6.PerformLayout()
            pnl_PatientData.ResumeLayout(False)
            pnl_PatientData.PerformLayout()
            Panel9.ResumeLayout(False)
            Panel9.PerformLayout()
            Panel11.ResumeLayout(False)
            Panel11.PerformLayout()
            Panel10.ResumeLayout(False)
            Panel10.PerformLayout()
            Panel8.ResumeLayout(False)
            Panel8.PerformLayout()
            Panel7.ResumeLayout(False)
            Panel2.ResumeLayout(False)
            Panel2.PerformLayout()
            CType(DBConnectionBindingSource, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub
        Friend WithEvents pnl_MainHeader As Panel
        Friend WithEvents btn_patientAddNew As Button
        Friend WithEvents Label2 As Label
        Friend WithEvents lbl_PatientID As Label
        Friend WithEvents lbl_homeDateTime As Label
        Friend WithEvents btn_Back As Button
        Friend WithEvents btn_ResetData As Button
        Friend WithEvents btn_SaveData As Button
        Friend WithEvents lbl_EditPatient As Label
        Friend WithEvents lbl_Name As Label
        Friend WithEvents pnl_FirstName As Panel
        Friend WithEvents txt_FirstName As TextBox
        Friend WithEvents Label1 As Label
        Friend WithEvents Panel1 As Panel
        Friend WithEvents txt_MiddleName As TextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents Panel3 As Panel
        Friend WithEvents txt_LastName As TextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents Panel4 As Panel
        Friend WithEvents txt_Sex As TextBox
        Friend WithEvents Label5 As Label
        Friend WithEvents Panel5 As Panel
        Friend WithEvents dtp_DateOfBirth As DateTimePicker
        Friend WithEvents Label6 As Label
        Friend WithEvents Panel6 As Panel
        Friend WithEvents txt_Age As TextBox
        Friend WithEvents pnl_PatientData As Panel
        Friend WithEvents Panel7 As Panel
        Friend WithEvents Label7 As Label
        Friend WithEvents cmb_BloodType As ComboBox
        Friend WithEvents DBConnectionBindingSource As BindingSource
        Friend WithEvents Panel8 As Panel
        Friend WithEvents txt_Phone As TextBox
        Friend WithEvents lbl_Phone As Label
        Friend WithEvents Panel9 As Panel
        Friend WithEvents txt_ParentGuardian As TextBox
        Friend WithEvents lbl_ParentGuardian As Label
        Friend WithEvents Panel10 As Panel
        Friend WithEvents txt_Email As TextBox
        Friend WithEvents lbl_Email As Label
        Friend WithEvents Panel11 As Panel
        Friend WithEvents txt_Address As TextBox
        Friend WithEvents lbl_Address As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents Panel2 As Panel
        Friend WithEvents txt_PrimaryDiagnoses As TextBox
    End Class
End Namespace
Namespace ScheduleTab

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class cf_ApmntData
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
            lbl_ScheduleID = New Label()
            lbl_homeDateTime = New Label()
            lbl_Name = New Label()
            pnl_FirstName = New Panel()
            dtp_StartDate = New DateTimePicker()
            txt_FirstName = New TextBox()
            Label1 = New Label()
            Panel1 = New Panel()
            dtp_EndDate = New DateTimePicker()
            txt_MiddleName = New TextBox()
            Label3 = New Label()
            Panel3 = New Panel()
            dtp_StartTime = New DateTimePicker()
            txt_LastName = New TextBox()
            Label4 = New Label()
            Panel4 = New Panel()
            dtp_EndTime = New DateTimePicker()
            txt_Sex = New TextBox()
            pnl_PatientData = New Panel()
            Panel5 = New Panel()
            txt_PatientName = New TextBox()
            Label6 = New Label()
            Panel2 = New Panel()
            txt_DoctorName = New TextBox()
            Label5 = New Label()
            cbx_AllDay = New CheckBox()
            Panel6 = New Panel()
            txt_Status = New TextBox()
            Panel7 = New Panel()
            cmb_RequestStatus = New ComboBox()
            Label8 = New Label()
            Label7 = New Label()
            DBConnectionBindingSource = New BindingSource(components)
            pnl_MainHeader.SuspendLayout()
            pnl_FirstName.SuspendLayout()
            Panel1.SuspendLayout()
            Panel3.SuspendLayout()
            Panel4.SuspendLayout()
            pnl_PatientData.SuspendLayout()
            Panel5.SuspendLayout()
            Panel2.SuspendLayout()
            Panel6.SuspendLayout()
            Panel7.SuspendLayout()
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
            pnl_MainHeader.Controls.Add(lbl_ScheduleID)
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
            lbl_EditPatient.Size = New Size(168, 22)
            lbl_EditPatient.TabIndex = 1
            lbl_EditPatient.Text = "Edit Appointment"
            ' 
            ' lbl_ScheduleID
            ' 
            lbl_ScheduleID.AutoSize = True
            lbl_ScheduleID.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            lbl_ScheduleID.ForeColor = Color.White
            lbl_ScheduleID.Location = New Point(252, 18)
            lbl_ScheduleID.Name = "lbl_ScheduleID"
            lbl_ScheduleID.Size = New Size(42, 29)
            lbl_ScheduleID.TabIndex = 1
            lbl_ScheduleID.Text = "S0"
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
            lbl_Name.Location = New Point(25, 156)
            lbl_Name.Name = "lbl_Name"
            lbl_Name.Size = New Size(106, 24)
            lbl_Name.TabIndex = 5
            lbl_Name.Text = "Start Date"
            lbl_Name.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' pnl_FirstName
            ' 
            pnl_FirstName.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            pnl_FirstName.Controls.Add(dtp_StartDate)
            pnl_FirstName.Controls.Add(txt_FirstName)
            pnl_FirstName.Location = New Point(168, 144)
            pnl_FirstName.Name = "pnl_FirstName"
            pnl_FirstName.Padding = New Padding(5)
            pnl_FirstName.Size = New Size(401, 47)
            pnl_FirstName.TabIndex = 7
            ' 
            ' dtp_StartDate
            ' 
            dtp_StartDate.CalendarMonthBackground = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            dtp_StartDate.CalendarTitleBackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            dtp_StartDate.Checked = False
            dtp_StartDate.CustomFormat = "YYYY-"
            dtp_StartDate.Dock = DockStyle.Fill
            dtp_StartDate.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            dtp_StartDate.Format = DateTimePickerFormat.Short
            dtp_StartDate.Location = New Point(5, 5)
            dtp_StartDate.MaxDate = New Date(2024, 12, 31, 0, 0, 0, 0)
            dtp_StartDate.Name = "dtp_StartDate"
            dtp_StartDate.Size = New Size(391, 35)
            dtp_StartDate.TabIndex = 10
            dtp_StartDate.Value = New Date(2024, 1, 1, 0, 0, 0, 0)
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
            Label1.Location = New Point(25, 218)
            Label1.Name = "Label1"
            Label1.Size = New Size(97, 24)
            Label1.TabIndex = 5
            Label1.Text = "End Date"
            Label1.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' Panel1
            ' 
            Panel1.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            Panel1.Controls.Add(dtp_EndDate)
            Panel1.Controls.Add(txt_MiddleName)
            Panel1.Location = New Point(168, 206)
            Panel1.Name = "Panel1"
            Panel1.Padding = New Padding(5)
            Panel1.Size = New Size(401, 47)
            Panel1.TabIndex = 7
            ' 
            ' dtp_EndDate
            ' 
            dtp_EndDate.CalendarMonthBackground = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            dtp_EndDate.CalendarTitleBackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            dtp_EndDate.Checked = False
            dtp_EndDate.CustomFormat = "MM/DD/YYYY"
            dtp_EndDate.Dock = DockStyle.Fill
            dtp_EndDate.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            dtp_EndDate.Format = DateTimePickerFormat.Short
            dtp_EndDate.Location = New Point(5, 5)
            dtp_EndDate.MaxDate = New Date(2024, 12, 31, 0, 0, 0, 0)
            dtp_EndDate.Name = "dtp_EndDate"
            dtp_EndDate.Size = New Size(391, 35)
            dtp_EndDate.TabIndex = 10
            dtp_EndDate.Value = New Date(2024, 1, 1, 0, 0, 0, 0)
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
            Label3.Location = New Point(25, 321)
            Label3.Name = "Label3"
            Label3.Size = New Size(105, 24)
            Label3.TabIndex = 5
            Label3.Text = "Start Time"
            Label3.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' Panel3
            ' 
            Panel3.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            Panel3.Controls.Add(dtp_StartTime)
            Panel3.Controls.Add(txt_LastName)
            Panel3.Location = New Point(168, 309)
            Panel3.Name = "Panel3"
            Panel3.Padding = New Padding(5)
            Panel3.Size = New Size(401, 47)
            Panel3.TabIndex = 7
            ' 
            ' dtp_StartTime
            ' 
            dtp_StartTime.CalendarMonthBackground = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            dtp_StartTime.CalendarTitleBackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            dtp_StartTime.Checked = False
            dtp_StartTime.CustomFormat = "HH:mm"
            dtp_StartTime.Dock = DockStyle.Fill
            dtp_StartTime.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            dtp_StartTime.Format = DateTimePickerFormat.Time
            dtp_StartTime.Location = New Point(5, 5)
            dtp_StartTime.MaxDate = New Date(2024, 12, 31, 0, 0, 0, 0)
            dtp_StartTime.Name = "dtp_StartTime"
            dtp_StartTime.Size = New Size(391, 35)
            dtp_StartTime.TabIndex = 11
            dtp_StartTime.Value = New Date(2024, 11, 30, 0, 0, 0, 0)
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
            Label4.Location = New Point(25, 381)
            Label4.Name = "Label4"
            Label4.Size = New Size(96, 24)
            Label4.TabIndex = 5
            Label4.Text = "End Time"
            Label4.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' Panel4
            ' 
            Panel4.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            Panel4.Controls.Add(dtp_EndTime)
            Panel4.Controls.Add(txt_Sex)
            Panel4.Location = New Point(168, 369)
            Panel4.Name = "Panel4"
            Panel4.Padding = New Padding(5)
            Panel4.Size = New Size(401, 47)
            Panel4.TabIndex = 7
            ' 
            ' dtp_EndTime
            ' 
            dtp_EndTime.CalendarMonthBackground = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            dtp_EndTime.CalendarTitleBackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            dtp_EndTime.Checked = False
            dtp_EndTime.CustomFormat = "HH:mm"
            dtp_EndTime.Dock = DockStyle.Fill
            dtp_EndTime.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            dtp_EndTime.Format = DateTimePickerFormat.Time
            dtp_EndTime.Location = New Point(5, 5)
            dtp_EndTime.MaxDate = New Date(2024, 12, 31, 0, 0, 0, 0)
            dtp_EndTime.Name = "dtp_EndTime"
            dtp_EndTime.Size = New Size(391, 35)
            dtp_EndTime.TabIndex = 12
            dtp_EndTime.Value = New Date(2024, 11, 30, 12, 0, 0, 0)
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
            ' pnl_PatientData
            ' 
            pnl_PatientData.Controls.Add(Panel5)
            pnl_PatientData.Controls.Add(Label6)
            pnl_PatientData.Controls.Add(Panel2)
            pnl_PatientData.Controls.Add(Label5)
            pnl_PatientData.Controls.Add(cbx_AllDay)
            pnl_PatientData.Controls.Add(lbl_Name)
            pnl_PatientData.Controls.Add(Label1)
            pnl_PatientData.Controls.Add(Panel6)
            pnl_PatientData.Controls.Add(Panel7)
            pnl_PatientData.Controls.Add(Label3)
            pnl_PatientData.Controls.Add(Panel4)
            pnl_PatientData.Controls.Add(Label4)
            pnl_PatientData.Controls.Add(Label8)
            pnl_PatientData.Controls.Add(Panel3)
            pnl_PatientData.Controls.Add(Label7)
            pnl_PatientData.Controls.Add(Panel1)
            pnl_PatientData.Controls.Add(pnl_FirstName)
            pnl_PatientData.Dock = DockStyle.Fill
            pnl_PatientData.Location = New Point(0, 69)
            pnl_PatientData.Name = "pnl_PatientData"
            pnl_PatientData.Size = New Size(596, 560)
            pnl_PatientData.TabIndex = 9
            ' 
            ' Panel5
            ' 
            Panel5.BackColor = Color.White
            Panel5.BorderStyle = BorderStyle.FixedSingle
            Panel5.Controls.Add(txt_PatientName)
            Panel5.Location = New Point(168, 24)
            Panel5.Name = "Panel5"
            Panel5.Padding = New Padding(5)
            Panel5.Size = New Size(401, 47)
            Panel5.TabIndex = 10
            ' 
            ' txt_PatientName
            ' 
            txt_PatientName.BackColor = Color.White
            txt_PatientName.BorderStyle = BorderStyle.None
            txt_PatientName.Dock = DockStyle.Fill
            txt_PatientName.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_PatientName.Location = New Point(5, 5)
            txt_PatientName.Margin = New Padding(3, 2, 3, 2)
            txt_PatientName.Multiline = True
            txt_PatientName.Name = "txt_PatientName"
            txt_PatientName.ReadOnly = True
            txt_PatientName.Size = New Size(389, 35)
            txt_PatientName.TabIndex = 6
            ' 
            ' Label6
            ' 
            Label6.AutoSize = True
            Label6.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            Label6.ForeColor = Color.Black
            Label6.ImageAlign = ContentAlignment.MiddleLeft
            Label6.Location = New Point(25, 36)
            Label6.Name = "Label6"
            Label6.Size = New Size(76, 24)
            Label6.TabIndex = 9
            Label6.Text = "Patient"
            Label6.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' Panel2
            ' 
            Panel2.BackColor = Color.White
            Panel2.BorderStyle = BorderStyle.FixedSingle
            Panel2.Controls.Add(txt_DoctorName)
            Panel2.Location = New Point(168, 84)
            Panel2.Name = "Panel2"
            Panel2.Padding = New Padding(5)
            Panel2.Size = New Size(401, 47)
            Panel2.TabIndex = 10
            ' 
            ' txt_DoctorName
            ' 
            txt_DoctorName.BackColor = Color.White
            txt_DoctorName.BorderStyle = BorderStyle.None
            txt_DoctorName.Dock = DockStyle.Fill
            txt_DoctorName.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_DoctorName.Location = New Point(5, 5)
            txt_DoctorName.Margin = New Padding(3, 2, 3, 2)
            txt_DoctorName.Multiline = True
            txt_DoctorName.Name = "txt_DoctorName"
            txt_DoctorName.ReadOnly = True
            txt_DoctorName.Size = New Size(389, 35)
            txt_DoctorName.TabIndex = 6
            ' 
            ' Label5
            ' 
            Label5.AutoSize = True
            Label5.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            Label5.ForeColor = Color.Black
            Label5.ImageAlign = ContentAlignment.MiddleLeft
            Label5.Location = New Point(25, 96)
            Label5.Name = "Label5"
            Label5.Size = New Size(73, 24)
            Label5.TabIndex = 9
            Label5.Text = "Doctor"
            Label5.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' cbx_AllDay
            ' 
            cbx_AllDay.AutoSize = True
            cbx_AllDay.Font = New Font("Arial", 15.75F)
            cbx_AllDay.Location = New Point(180, 269)
            cbx_AllDay.Name = "cbx_AllDay"
            cbx_AllDay.Size = New Size(94, 28)
            cbx_AllDay.TabIndex = 8
            cbx_AllDay.Text = "All Day"
            cbx_AllDay.UseVisualStyleBackColor = True
            ' 
            ' Panel6
            ' 
            Panel6.BackColor = Color.White
            Panel6.BorderStyle = BorderStyle.FixedSingle
            Panel6.Controls.Add(txt_Status)
            Panel6.Location = New Point(168, 489)
            Panel6.Name = "Panel6"
            Panel6.Padding = New Padding(5)
            Panel6.Size = New Size(401, 47)
            Panel6.TabIndex = 7
            ' 
            ' txt_Status
            ' 
            txt_Status.BackColor = Color.White
            txt_Status.BorderStyle = BorderStyle.None
            txt_Status.Dock = DockStyle.Fill
            txt_Status.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_Status.Location = New Point(5, 5)
            txt_Status.Margin = New Padding(3, 2, 3, 2)
            txt_Status.Multiline = True
            txt_Status.Name = "txt_Status"
            txt_Status.ReadOnly = True
            txt_Status.Size = New Size(389, 35)
            txt_Status.TabIndex = 7
            ' 
            ' Panel7
            ' 
            Panel7.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            Panel7.Controls.Add(cmb_RequestStatus)
            Panel7.Location = New Point(168, 429)
            Panel7.Name = "Panel7"
            Panel7.Padding = New Padding(5)
            Panel7.Size = New Size(401, 47)
            Panel7.TabIndex = 7
            ' 
            ' cmb_RequestStatus
            ' 
            cmb_RequestStatus.BackColor = Color.FromArgb(CByte(191), CByte(251), CByte(200))
            cmb_RequestStatus.Dock = DockStyle.Fill
            cmb_RequestStatus.DropDownStyle = ComboBoxStyle.DropDownList
            cmb_RequestStatus.FlatStyle = FlatStyle.Flat
            cmb_RequestStatus.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            cmb_RequestStatus.FormattingEnabled = True
            cmb_RequestStatus.Items.AddRange(New Object() {"Pending", "Accepted", "Declined"})
            cmb_RequestStatus.Location = New Point(5, 5)
            cmb_RequestStatus.Name = "cmb_RequestStatus"
            cmb_RequestStatus.Size = New Size(391, 38)
            cmb_RequestStatus.TabIndex = 9
            ' 
            ' Label8
            ' 
            Label8.AutoSize = True
            Label8.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            Label8.ForeColor = Color.Black
            Label8.ImageAlign = ContentAlignment.MiddleLeft
            Label8.Location = New Point(25, 501)
            Label8.Name = "Label8"
            Label8.Size = New Size(70, 24)
            Label8.TabIndex = 5
            Label8.Text = "Status"
            Label8.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' Label7
            ' 
            Label7.AutoSize = True
            Label7.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            Label7.ForeColor = Color.Black
            Label7.ImageAlign = ContentAlignment.MiddleLeft
            Label7.Location = New Point(25, 441)
            Label7.Name = "Label7"
            Label7.Size = New Size(88, 24)
            Label7.TabIndex = 5
            Label7.Text = "Request"
            Label7.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' DBConnectionBindingSource
            ' 
            DBConnectionBindingSource.DataSource = GetType(DBConnection)
            ' 
            ' cf_ApmntData
            ' 
            AutoScaleDimensions = New SizeF(7F, 15F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.White
            ClientSize = New Size(596, 629)
            Controls.Add(pnl_PatientData)
            Controls.Add(pnl_MainHeader)
            Name = "cf_ApmntData"
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
            pnl_PatientData.ResumeLayout(False)
            pnl_PatientData.PerformLayout()
            Panel5.ResumeLayout(False)
            Panel5.PerformLayout()
            Panel2.ResumeLayout(False)
            Panel2.PerformLayout()
            Panel6.ResumeLayout(False)
            Panel6.PerformLayout()
            Panel7.ResumeLayout(False)
            CType(DBConnectionBindingSource, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub
        Friend WithEvents pnl_MainHeader As Panel
        Friend WithEvents btn_patientAddNew As Button
        Friend WithEvents Label2 As Label
        Friend WithEvents lbl_ScheduleID As Label
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
        Friend WithEvents txt_Age As TextBox
        Friend WithEvents pnl_PatientData As Panel
        Friend WithEvents Panel7 As Panel
        Friend WithEvents Label7 As Label
        Friend WithEvents cmb_RequestStatus As ComboBox
        Friend WithEvents DBConnectionBindingSource As BindingSource
        Friend WithEvents Panel8 As Panel
        Friend WithEvents txt_Phone As TextBox
        Friend WithEvents lbl_Phone As Label
        Friend WithEvents Panel9 As Panel
        Friend WithEvents txt_ParentGuardian As TextBox
        Friend WithEvents lbl_ParentGuardian As Label
        Friend WithEvents dtp_StartDate As DateTimePicker
        Friend WithEvents dtp_EndDate As DateTimePicker
        Friend WithEvents dtp_StartTime As DateTimePicker
        Friend WithEvents dtp_EndTime As DateTimePicker
        Friend WithEvents cbx_AllDay As CheckBox
        Friend WithEvents Panel2 As Panel
        Friend WithEvents txt_DoctorName As TextBox
        Friend WithEvents Label5 As Label
        Friend WithEvents Panel5 As Panel
        Friend WithEvents txt_PatientName As TextBox
        Friend WithEvents Label6 As Label
        Friend WithEvents Panel6 As Panel
        Friend WithEvents Label8 As Label
        Friend WithEvents txt_Status As TextBox
    End Class
End Namespace
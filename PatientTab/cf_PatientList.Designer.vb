﻿Namespace PatientTab
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
            Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
            pnl_MainHeader = New Panel()
            txt_Search = New TextBox()
            Label2 = New Label()
            Label6 = New Label()
            lbl_homeDateTime = New Label()
            DBConnectionBindingSource = New BindingSource(components)
            dgv_PatientTable = New DataGridView()
            pnl_PatientList = New Panel()
            btn_View = New Button()
            btn_Delete = New Button()
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
            pnl_MainHeader.Controls.Add(btn_Delete)
            pnl_MainHeader.Controls.Add(btn_View)
            pnl_MainHeader.Controls.Add(txt_Search)
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
            ' txt_Search
            ' 
            txt_Search.Anchor = AnchorStyles.Top
            txt_Search.BorderStyle = BorderStyle.None
            txt_Search.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_Search.Location = New Point(396, 20)
            txt_Search.Margin = New Padding(3, 2, 3, 2)
            txt_Search.Name = "txt_Search"
            txt_Search.PlaceholderText = "Search for a patient"
            txt_Search.Size = New Size(493, 29)
            txt_Search.TabIndex = 4
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
            DataGridViewCellStyle13.BackColor = Color.WhiteSmoke
            dgv_PatientTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
            dgv_PatientTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgv_PatientTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgv_PatientTable.BackgroundColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
            dgv_PatientTable.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
            DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle14.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
            DataGridViewCellStyle14.Font = New Font("Segoe UI", 9F)
            DataGridViewCellStyle14.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle14.SelectionBackColor = Color.DimGray
            DataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle14.WrapMode = DataGridViewTriState.True
            dgv_PatientTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
            dgv_PatientTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle15.BackColor = SystemColors.Window
            DataGridViewCellStyle15.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            DataGridViewCellStyle15.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle15.Padding = New Padding(5)
            DataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(CByte(161), CByte(243), CByte(175))
            DataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle15.WrapMode = DataGridViewTriState.False
            dgv_PatientTable.DefaultCellStyle = DataGridViewCellStyle15
            dgv_PatientTable.Dock = DockStyle.Fill
            dgv_PatientTable.EditMode = DataGridViewEditMode.EditProgrammatically
            dgv_PatientTable.EnableHeadersVisualStyles = False
            dgv_PatientTable.Location = New Point(20, 20)
            dgv_PatientTable.Name = "dgv_PatientTable"
            dgv_PatientTable.ReadOnly = True
            DataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle16.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
            DataGridViewCellStyle16.Font = New Font("Segoe UI", 9F)
            DataGridViewCellStyle16.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle16.SelectionBackColor = Color.Transparent
            DataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = DataGridViewTriState.True
            dgv_PatientTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
            dgv_PatientTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
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
            ' btn_View
            ' 
            btn_View.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_View.BackColor = Color.Silver
            btn_View.FlatAppearance.BorderSize = 2
            btn_View.FlatStyle = FlatStyle.Flat
            btn_View.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btn_View.Location = New Point(1000, 16)
            btn_View.Name = "btn_View"
            btn_View.Size = New Size(101, 34)
            btn_View.TabIndex = 6
            btn_View.Text = "View"
            btn_View.UseVisualStyleBackColor = False
            ' 
            ' btn_Delete
            ' 
            btn_Delete.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_Delete.BackColor = Color.FromArgb(CByte(255), CByte(137), CByte(140))
            btn_Delete.FlatAppearance.BorderSize = 2
            btn_Delete.FlatStyle = FlatStyle.Flat
            btn_Delete.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btn_Delete.Location = New Point(1115, 16)
            btn_Delete.Name = "btn_Delete"
            btn_Delete.Size = New Size(101, 34)
            btn_Delete.TabIndex = 6
            btn_Delete.Text = "Delete"
            btn_Delete.UseVisualStyleBackColor = False
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
        Friend WithEvents txt_Search As TextBox
        Friend WithEvents DBConnectionBindingSource As BindingSource
        Friend WithEvents dgv_PatientTable As DataGridView
        Friend WithEvents pnl_PatientList As Panel
        Friend WithEvents btn_Delete As Button
        Friend WithEvents btn_View As Button
    End Class
End Namespace
﻿namespace PAG_Manager
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable. 
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabAwardPag = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelAwardPag = new System.Windows.Forms.TableLayoutPanel();
            this.treeViewYearSelect = new System.Windows.Forms.TreeView();
            this.treeViewPagSelect = new System.Windows.Forms.TreeView();
            this.groupBoxAwardPag = new System.Windows.Forms.GroupBox();
            this.labelAwardPagSelectedAbsent = new System.Windows.Forms.Label();
            this.buttonAwardPagClearSelection = new System.Windows.Forms.Button();
            this.labelAwardPagSelectedFailedSkills = new System.Windows.Forms.Label();
            this.labelAwardPagSelectedPag = new System.Windows.Forms.Label();
            this.labelAwardPagSelectedStudents = new System.Windows.Forms.Label();
            this.buttonAwardPag = new System.Windows.Forms.Button();
            this.labelPagAwardSettingsSelectDate = new System.Windows.Forms.Label();
            this.dateTimePickerAwardPag = new System.Windows.Forms.DateTimePicker();
            this.tabLookup = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelLookup = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxLookupSearch = new System.Windows.Forms.GroupBox();
            this.buttonLookupSubmitModifications = new System.Windows.Forms.Button();
            this.checkBoxArchives = new System.Windows.Forms.CheckBox();
            this.textBoxLookupName = new System.Windows.Forms.TextBox();
            this.labelLookupName = new System.Windows.Forms.Label();
            this.listBoxStudentNames = new System.Windows.Forms.ListBox();
            this.dataGridViewStudentLookup = new System.Windows.Forms.DataGridView();
            this.tabPagDates = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelPagView = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelPAGSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPagViewFilter = new System.Windows.Forms.Label();
            this.textBoxPagSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewPag = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSkills = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelSkillView = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelSkillSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSkillFilter = new System.Windows.Forms.Label();
            this.textBoxSkillSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewSkills = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelStudentReport = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.progressBarStudentReport = new System.Windows.Forms.ProgressBar();
            this.dataGridViewStudentReport = new System.Windows.Forms.DataGridView();
            this.StudentReportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentReportFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentReportSName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentReportYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentReportClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentReportCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelReportSettings = new System.Windows.Forms.Label();
            this.flowLayoutPanelStudentReportSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFilterBy = new System.Windows.Forms.Label();
            this.radioButtonReportComplete = new System.Windows.Forms.RadioButton();
            this.radioButtonReportNotComplete = new System.Windows.Forms.RadioButton();
            this.radioButtonReportAll = new System.Windows.Forms.RadioButton();
            this.buttonExportReport = new System.Windows.Forms.Button();
            this.tabActivitySelection = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelActivitySelection = new System.Windows.Forms.TableLayoutPanel();
            this.labelActivitySelectionSkill = new System.Windows.Forms.Label();
            this.dataGridViewActivitySelectionSkills = new System.Windows.Forms.DataGridView();
            this.SkillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedListBoxActivitySelectionPag = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanelActivitySelectionToolbar = new System.Windows.Forms.TableLayoutPanel();
            this.labelActivitySelectionPag = new System.Windows.Forms.Label();
            this.buttonActivitySelectResetSelection = new System.Windows.Forms.Button();
            this.tabContentSelection = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelContentSelection = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewContentSelectionPag = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedListBoxContentSelectionSkill = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutContentSelectionSkill = new System.Windows.Forms.TableLayoutPanel();
            this.labelContentSelectionSkill = new System.Windows.Forms.Label();
            this.buttonContentSelectionSelectionReset = new System.Windows.Forms.Button();
            this.tableLayoutPanelContentSelectionActivitySelection = new System.Windows.Forms.TableLayoutPanel();
            this.labelContentSelectionPag = new System.Windows.Forms.Label();
            this.listBoxContentSelectionInclusion = new System.Windows.Forms.ListBox();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabSkillPagList = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelPagSkillList = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxSkillList = new System.Windows.Forms.ListBox();
            this.toolStripSkillList = new System.Windows.Forms.ToolStrip();
            this.skillListToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.skillListToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.skillListToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.skillListToolStripButtonAddRecord = new System.Windows.Forms.ToolStripButton();
            this.skillListToolStripButtonRemovePag = new System.Windows.Forms.ToolStripButton();
            this.skillListToolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripPagList = new System.Windows.Forms.ToolStrip();
            this.pagListToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.pagListToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pagListToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.pagListToolStripButtonAddRecord = new System.Windows.Forms.ToolStripButton();
            this.pagListToolStripButtonRemovePag = new System.Windows.Forms.ToolStripButton();
            this.pagListToolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.listBoxPagList = new System.Windows.Forms.ListBox();
            this.tabPagSkillRelation = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelPagSkillRelation = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBuildPagSkillRelation = new System.Windows.Forms.Button();
            this.listBoxPagRelation = new System.Windows.Forms.ListBox();
            this.checkedListBoxSkillRelation = new System.Windows.Forms.CheckedListBox();
            this.tabSkillRequirements = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelSkillRequirement = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewSkillRequirement = new System.Windows.Forms.DataGridView();
            this.SkillRequirementsTableSkillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkillRequirementsTableRequiredAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSaveSkillRequirement = new System.Windows.Forms.Button();
            this.tabGroup = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelPagGroup = new System.Windows.Forms.TableLayoutPanel();
            this.pagGroupToolStrip = new System.Windows.Forms.ToolStrip();
            this.pagGroupToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.pagGroupToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pagGroupToolStripSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.pagGroupToolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.pagGroupToolStripRemove = new System.Windows.Forms.ToolStripButton();
            this.pagGroupToolStripSave = new System.Windows.Forms.ToolStripButton();
            this.listBoxGroupList = new System.Windows.Forms.ListBox();
            this.checkedListBoxPagList = new System.Windows.Forms.CheckedListBox();
            this.tabStudentImport = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelImportStudents = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelImportStudents = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonImportCSV = new System.Windows.Forms.Button();
            this.buttonAddStudentRecord = new System.Windows.Forms.Button();
            this.labelImportStudents = new System.Windows.Forms.Label();
            this.dataGridViewStudentImport = new System.Windows.Forms.DataGridView();
            this.tabStudentManagement = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelStudentManagement = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelStudentInfo = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStudentManagementDeleteStudent = new System.Windows.Forms.Button();
            this.textBoxStudentLName = new System.Windows.Forms.TextBox();
            this.textBoxStudentFName = new System.Windows.Forms.TextBox();
            this.labelStudentManagementFName = new System.Windows.Forms.Label();
            this.labelStudentManagementLName = new System.Windows.Forms.Label();
            this.labelStudentManagementYear = new System.Windows.Forms.Label();
            this.labelStudentManagementClass = new System.Windows.Forms.Label();
            this.textBoxStudentYear = new System.Windows.Forms.TextBox();
            this.textBoxStudentClass = new System.Windows.Forms.TextBox();
            this.buttonStudentManagementSaveChanges = new System.Windows.Forms.Button();
            this.buttonStudentManagementAddStudent = new System.Windows.Forms.Button();
            this.buttonClearAllChanges = new System.Windows.Forms.Button();
            this.tableLayoutPanelStudentMassMove = new System.Windows.Forms.TableLayoutPanel();
            this.labelStudentManagement1 = new System.Windows.Forms.Label();
            this.labelStudentManagement2 = new System.Windows.Forms.Label();
            this.comboBoxInputType = new System.Windows.Forms.ComboBox();
            this.comboBoxInputName = new System.Windows.Forms.ComboBox();
            this.comboBoxOutputName = new System.Windows.Forms.ComboBox();
            this.buttonMoveStudents = new System.Windows.Forms.Button();
            this.labelNewItem = new System.Windows.Forms.Label();
            this.labelUnsavedChanges = new System.Windows.Forms.Label();
            this.listBoxStudentManagementList = new System.Windows.Forms.ListBox();
            this.textBoxStudentFilter = new System.Windows.Forms.TextBox();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.labelImportData = new System.Windows.Forms.Label();
            this.buttonImportData = new System.Windows.Forms.Button();
            this.labelExportData = new System.Windows.Forms.Label();
            this.buttonExportData = new System.Windows.Forms.Button();
            this.labelDefaultPresets = new System.Windows.Forms.Label();
            this.buttonAddPresets = new System.Windows.Forms.Button();
            this.labelAdminDeleteData = new System.Windows.Forms.Label();
            this.labelAdminProgramDirectory = new System.Windows.Forms.Label();
            this.labelAdminStudentID = new System.Windows.Forms.Label();
            this.buttonResetToDefault = new System.Windows.Forms.Button();
            this.checkBoxShowStudentID = new System.Windows.Forms.CheckBox();
            this.buttonGetDirectory = new System.Windows.Forms.Button();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.backupRestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxBackupName = new System.Windows.Forms.ToolStripTextBox();
            this.backupWithNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PAGPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPAGPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxCreatePreset = new System.Windows.Forms.ToolStripTextBox();
            this.createPresetWithNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPAGPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePAGPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hidePagViewColumnsWithoutPAGDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogImportCSV = new System.Windows.Forms.OpenFileDialog();
            this.heightDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialogExportReport = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogExportData = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogImportData = new System.Windows.Forms.OpenFileDialog();
            this.tabControlMain.SuspendLayout();
            this.tabAwardPag.SuspendLayout();
            this.tableLayoutPanelAwardPag.SuspendLayout();
            this.groupBoxAwardPag.SuspendLayout();
            this.tabLookup.SuspendLayout();
            this.tableLayoutPanelLookup.SuspendLayout();
            this.groupBoxLookupSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentLookup)).BeginInit();
            this.tabPagDates.SuspendLayout();
            this.tableLayoutPanelPagView.SuspendLayout();
            this.flowLayoutPanelPAGSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPag)).BeginInit();
            this.tabSkills.SuspendLayout();
            this.tableLayoutPanelSkillView.SuspendLayout();
            this.flowLayoutPanelSkillSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkills)).BeginInit();
            this.tabReport.SuspendLayout();
            this.tableLayoutPanelStudentReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentReport)).BeginInit();
            this.flowLayoutPanelStudentReportSettings.SuspendLayout();
            this.tabActivitySelection.SuspendLayout();
            this.tableLayoutPanelActivitySelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivitySelectionSkills)).BeginInit();
            this.tableLayoutPanelActivitySelectionToolbar.SuspendLayout();
            this.tabContentSelection.SuspendLayout();
            this.tableLayoutPanelContentSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContentSelectionPag)).BeginInit();
            this.tableLayoutContentSelectionSkill.SuspendLayout();
            this.tableLayoutPanelContentSelectionActivitySelection.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.tabControlAdmin.SuspendLayout();
            this.tabSkillPagList.SuspendLayout();
            this.tableLayoutPanelPagSkillList.SuspendLayout();
            this.toolStripSkillList.SuspendLayout();
            this.toolStripPagList.SuspendLayout();
            this.tabPagSkillRelation.SuspendLayout();
            this.tableLayoutPanelPagSkillRelation.SuspendLayout();
            this.tabSkillRequirements.SuspendLayout();
            this.tableLayoutPanelSkillRequirement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkillRequirement)).BeginInit();
            this.tabGroup.SuspendLayout();
            this.tableLayoutPanelPagGroup.SuspendLayout();
            this.pagGroupToolStrip.SuspendLayout();
            this.tabStudentImport.SuspendLayout();
            this.tableLayoutPanelImportStudents.SuspendLayout();
            this.flowLayoutPanelImportStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentImport)).BeginInit();
            this.tabStudentManagement.SuspendLayout();
            this.tableLayoutPanelStudentManagement.SuspendLayout();
            this.tableLayoutPanelStudentInfo.SuspendLayout();
            this.tableLayoutPanelStudentMassMove.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabAwardPag);
            this.tabControlMain.Controls.Add(this.tabLookup);
            this.tabControlMain.Controls.Add(this.tabPagDates);
            this.tabControlMain.Controls.Add(this.tabSkills);
            this.tabControlMain.Controls.Add(this.tabReport);
            this.tabControlMain.Controls.Add(this.tabActivitySelection);
            this.tabControlMain.Controls.Add(this.tabContentSelection);
            this.tabControlMain.Controls.Add(this.tabAdmin);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(784, 537);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabAwardPag
            // 
            this.tabAwardPag.Controls.Add(this.tableLayoutPanelAwardPag);
            this.tabAwardPag.Location = new System.Drawing.Point(4, 22);
            this.tabAwardPag.Name = "tabAwardPag";
            this.tabAwardPag.Padding = new System.Windows.Forms.Padding(3);
            this.tabAwardPag.Size = new System.Drawing.Size(776, 511);
            this.tabAwardPag.TabIndex = 6;
            this.tabAwardPag.Text = "Award PAG";
            this.tabAwardPag.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelAwardPag
            // 
            this.tableLayoutPanelAwardPag.ColumnCount = 3;
            this.tableLayoutPanelAwardPag.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAwardPag.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAwardPag.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanelAwardPag.Controls.Add(this.treeViewYearSelect, 0, 0);
            this.tableLayoutPanelAwardPag.Controls.Add(this.treeViewPagSelect, 1, 0);
            this.tableLayoutPanelAwardPag.Controls.Add(this.groupBoxAwardPag, 2, 0);
            this.tableLayoutPanelAwardPag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAwardPag.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelAwardPag.Name = "tableLayoutPanelAwardPag";
            this.tableLayoutPanelAwardPag.RowCount = 1;
            this.tableLayoutPanelAwardPag.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAwardPag.Size = new System.Drawing.Size(770, 505);
            this.tableLayoutPanelAwardPag.TabIndex = 0;
            // 
            // treeViewYearSelect
            // 
            this.treeViewYearSelect.CheckBoxes = true;
            this.treeViewYearSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewYearSelect.Location = new System.Drawing.Point(3, 3);
            this.treeViewYearSelect.Name = "treeViewYearSelect";
            this.treeViewYearSelect.Size = new System.Drawing.Size(288, 499);
            this.treeViewYearSelect.TabIndex = 0;
            this.treeViewYearSelect.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewYearSelect_AfterCheck);
            // 
            // treeViewPagSelect
            // 
            this.treeViewPagSelect.CheckBoxes = true;
            this.treeViewPagSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewPagSelect.Location = new System.Drawing.Point(297, 3);
            this.treeViewPagSelect.Name = "treeViewPagSelect";
            this.treeViewPagSelect.Size = new System.Drawing.Size(288, 499);
            this.treeViewPagSelect.TabIndex = 1;
            this.treeViewPagSelect.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPagSelect_AfterCheck);
            // 
            // groupBoxAwardPag
            // 
            this.groupBoxAwardPag.Controls.Add(this.labelAwardPagSelectedAbsent);
            this.groupBoxAwardPag.Controls.Add(this.buttonAwardPagClearSelection);
            this.groupBoxAwardPag.Controls.Add(this.labelAwardPagSelectedFailedSkills);
            this.groupBoxAwardPag.Controls.Add(this.labelAwardPagSelectedPag);
            this.groupBoxAwardPag.Controls.Add(this.labelAwardPagSelectedStudents);
            this.groupBoxAwardPag.Controls.Add(this.buttonAwardPag);
            this.groupBoxAwardPag.Controls.Add(this.labelPagAwardSettingsSelectDate);
            this.groupBoxAwardPag.Controls.Add(this.dateTimePickerAwardPag);
            this.groupBoxAwardPag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAwardPag.Location = new System.Drawing.Point(591, 3);
            this.groupBoxAwardPag.Name = "groupBoxAwardPag";
            this.groupBoxAwardPag.Size = new System.Drawing.Size(176, 499);
            this.groupBoxAwardPag.TabIndex = 2;
            this.groupBoxAwardPag.TabStop = false;
            this.groupBoxAwardPag.Text = "PAG Award Settings";
            // 
            // labelAwardPagSelectedAbsent
            // 
            this.labelAwardPagSelectedAbsent.Location = new System.Drawing.Point(6, 114);
            this.labelAwardPagSelectedAbsent.Name = "labelAwardPagSelectedAbsent";
            this.labelAwardPagSelectedAbsent.Size = new System.Drawing.Size(164, 31);
            this.labelAwardPagSelectedAbsent.TabIndex = 11;
            this.labelAwardPagSelectedAbsent.Text = "0 students within the selected class will be marked as absent";
            // 
            // buttonAwardPagClearSelection
            // 
            this.buttonAwardPagClearSelection.Location = new System.Drawing.Point(6, 19);
            this.buttonAwardPagClearSelection.Name = "buttonAwardPagClearSelection";
            this.buttonAwardPagClearSelection.Size = new System.Drawing.Size(164, 23);
            this.buttonAwardPagClearSelection.TabIndex = 10;
            this.buttonAwardPagClearSelection.Text = "Clear Selection";
            this.buttonAwardPagClearSelection.UseVisualStyleBackColor = true;
            this.buttonAwardPagClearSelection.Click += new System.EventHandler(this.buttonAwardPagClearSelection_Click);
            // 
            // labelAwardPagSelectedFailedSkills
            // 
            this.labelAwardPagSelectedFailedSkills.Location = new System.Drawing.Point(6, 173);
            this.labelAwardPagSelectedFailedSkills.Name = "labelAwardPagSelectedFailedSkills";
            this.labelAwardPagSelectedFailedSkills.Size = new System.Drawing.Size(164, 31);
            this.labelAwardPagSelectedFailedSkills.TabIndex = 9;
            this.labelAwardPagSelectedFailedSkills.Text = "0 skills within the selected PAG\'s will be marked as failed";
            // 
            // labelAwardPagSelectedPag
            // 
            this.labelAwardPagSelectedPag.AutoSize = true;
            this.labelAwardPagSelectedPag.Location = new System.Drawing.Point(6, 148);
            this.labelAwardPagSelectedPag.Name = "labelAwardPagSelectedPag";
            this.labelAwardPagSelectedPag.Size = new System.Drawing.Size(131, 13);
            this.labelAwardPagSelectedPag.TabIndex = 8;
            this.labelAwardPagSelectedPag.Text = "You are awarding 0 PAG\'s";
            // 
            // labelAwardPagSelectedStudents
            // 
            this.labelAwardPagSelectedStudents.AutoSize = true;
            this.labelAwardPagSelectedStudents.Location = new System.Drawing.Point(6, 94);
            this.labelAwardPagSelectedStudents.Name = "labelAwardPagSelectedStudents";
            this.labelAwardPagSelectedStudents.Size = new System.Drawing.Size(148, 13);
            this.labelAwardPagSelectedStudents.TabIndex = 7;
            this.labelAwardPagSelectedStudents.Text = "You have selected 0 students";
            // 
            // buttonAwardPag
            // 
            this.buttonAwardPag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAwardPag.Location = new System.Drawing.Point(3, 473);
            this.buttonAwardPag.Name = "buttonAwardPag";
            this.buttonAwardPag.Size = new System.Drawing.Size(170, 23);
            this.buttonAwardPag.TabIndex = 6;
            this.buttonAwardPag.Text = "Award PAG";
            this.buttonAwardPag.UseVisualStyleBackColor = true;
            this.buttonAwardPag.Click += new System.EventHandler(this.buttonAwardPag_Click);
            // 
            // labelPagAwardSettingsSelectDate
            // 
            this.labelPagAwardSettingsSelectDate.AutoSize = true;
            this.labelPagAwardSettingsSelectDate.Location = new System.Drawing.Point(1, 46);
            this.labelPagAwardSettingsSelectDate.Name = "labelPagAwardSettingsSelectDate";
            this.labelPagAwardSettingsSelectDate.Size = new System.Drawing.Size(161, 13);
            this.labelPagAwardSettingsSelectDate.TabIndex = 4;
            this.labelPagAwardSettingsSelectDate.Text = "Select the PAG completion date:";
            // 
            // dateTimePickerAwardPag
            // 
            this.dateTimePickerAwardPag.CustomFormat = "d/M/yyyy";
            this.dateTimePickerAwardPag.Location = new System.Drawing.Point(3, 62);
            this.dateTimePickerAwardPag.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAwardPag.Name = "dateTimePickerAwardPag";
            this.dateTimePickerAwardPag.Size = new System.Drawing.Size(170, 20);
            this.dateTimePickerAwardPag.TabIndex = 3;
            this.dateTimePickerAwardPag.ValueChanged += new System.EventHandler(this.dateTimePickerAwardPag_ValueChanged);
            // 
            // tabLookup
            // 
            this.tabLookup.Controls.Add(this.tableLayoutPanelLookup);
            this.tabLookup.Location = new System.Drawing.Point(4, 22);
            this.tabLookup.Name = "tabLookup";
            this.tabLookup.Padding = new System.Windows.Forms.Padding(3);
            this.tabLookup.Size = new System.Drawing.Size(776, 511);
            this.tabLookup.TabIndex = 3;
            this.tabLookup.Text = "Student Lookup";
            this.tabLookup.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelLookup
            // 
            this.tableLayoutPanelLookup.ColumnCount = 2;
            this.tableLayoutPanelLookup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanelLookup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLookup.Controls.Add(this.groupBoxLookupSearch, 0, 0);
            this.tableLayoutPanelLookup.Controls.Add(this.listBoxStudentNames, 0, 1);
            this.tableLayoutPanelLookup.Controls.Add(this.dataGridViewStudentLookup, 1, 1);
            this.tableLayoutPanelLookup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLookup.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLookup.Name = "tableLayoutPanelLookup";
            this.tableLayoutPanelLookup.RowCount = 2;
            this.tableLayoutPanelLookup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelLookup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLookup.Size = new System.Drawing.Size(770, 505);
            this.tableLayoutPanelLookup.TabIndex = 0;
            // 
            // groupBoxLookupSearch
            // 
            this.tableLayoutPanelLookup.SetColumnSpan(this.groupBoxLookupSearch, 2);
            this.groupBoxLookupSearch.Controls.Add(this.buttonLookupSubmitModifications);
            this.groupBoxLookupSearch.Controls.Add(this.checkBoxArchives);
            this.groupBoxLookupSearch.Controls.Add(this.textBoxLookupName);
            this.groupBoxLookupSearch.Controls.Add(this.labelLookupName);
            this.groupBoxLookupSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLookupSearch.Location = new System.Drawing.Point(3, 3);
            this.groupBoxLookupSearch.Name = "groupBoxLookupSearch";
            this.groupBoxLookupSearch.Size = new System.Drawing.Size(764, 54);
            this.groupBoxLookupSearch.TabIndex = 0;
            this.groupBoxLookupSearch.TabStop = false;
            this.groupBoxLookupSearch.Text = "Student Lookup";
            // 
            // buttonLookupSubmitModifications
            // 
            this.buttonLookupSubmitModifications.Location = new System.Drawing.Point(567, 19);
            this.buttonLookupSubmitModifications.Name = "buttonLookupSubmitModifications";
            this.buttonLookupSubmitModifications.Size = new System.Drawing.Size(92, 23);
            this.buttonLookupSubmitModifications.TabIndex = 6;
            this.buttonLookupSubmitModifications.Text = "Save Changes";
            this.buttonLookupSubmitModifications.UseVisualStyleBackColor = true;
            this.buttonLookupSubmitModifications.Click += new System.EventHandler(this.buttonLookupSubmitModifications_Click);
            // 
            // checkBoxArchives
            // 
            this.checkBoxArchives.AutoSize = true;
            this.checkBoxArchives.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxArchives.Location = new System.Drawing.Point(321, 23);
            this.checkBoxArchives.Name = "checkBoxArchives";
            this.checkBoxArchives.Size = new System.Drawing.Size(104, 17);
            this.checkBoxArchives.TabIndex = 4;
            this.checkBoxArchives.Text = "Search Archives";
            this.checkBoxArchives.UseVisualStyleBackColor = true;
            this.checkBoxArchives.CheckedChanged += new System.EventHandler(this.checkBoxArchives_CheckedChanged);
            // 
            // textBoxLookupName
            // 
            this.textBoxLookupName.Location = new System.Drawing.Point(124, 21);
            this.textBoxLookupName.Name = "textBoxLookupName";
            this.textBoxLookupName.Size = new System.Drawing.Size(191, 20);
            this.textBoxLookupName.TabIndex = 1;
            this.textBoxLookupName.TextChanged += new System.EventHandler(this.textBoxLookupName_TextChanged);
            // 
            // labelLookupName
            // 
            this.labelLookupName.AutoSize = true;
            this.labelLookupName.Location = new System.Drawing.Point(6, 24);
            this.labelLookupName.Name = "labelLookupName";
            this.labelLookupName.Size = new System.Drawing.Size(112, 13);
            this.labelLookupName.TabIndex = 0;
            this.labelLookupName.Text = "Search name or class:";
            // 
            // listBoxStudentNames
            // 
            this.listBoxStudentNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxStudentNames.FormattingEnabled = true;
            this.listBoxStudentNames.Location = new System.Drawing.Point(3, 63);
            this.listBoxStudentNames.Name = "listBoxStudentNames";
            this.listBoxStudentNames.Size = new System.Drawing.Size(174, 463);
            this.listBoxStudentNames.TabIndex = 1;
            this.listBoxStudentNames.SelectedIndexChanged += new System.EventHandler(this.listBoxStudentNames_SelectedIndexChanged);
            // 
            // dataGridViewStudentLookup
            // 
            this.dataGridViewStudentLookup.AllowUserToAddRows = false;
            this.dataGridViewStudentLookup.AllowUserToDeleteRows = false;
            this.dataGridViewStudentLookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudentLookup.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudentLookup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudentLookup.Location = new System.Drawing.Point(183, 63);
            this.dataGridViewStudentLookup.Name = "dataGridViewStudentLookup";
            this.dataGridViewStudentLookup.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewStudentLookup.Size = new System.Drawing.Size(584, 463);
            this.dataGridViewStudentLookup.TabIndex = 2;
            this.dataGridViewStudentLookup.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewStudentLookup_CellEndEdit);
            this.dataGridViewStudentLookup.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentLookup_CellValueChanged);
            this.dataGridViewStudentLookup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewStudentLookup_KeyDown);
            // 
            // tabPagDates
            // 
            this.tabPagDates.Controls.Add(this.tableLayoutPanelPagView);
            this.tabPagDates.Location = new System.Drawing.Point(4, 22);
            this.tabPagDates.Margin = new System.Windows.Forms.Padding(2);
            this.tabPagDates.Name = "tabPagDates";
            this.tabPagDates.Padding = new System.Windows.Forms.Padding(2);
            this.tabPagDates.Size = new System.Drawing.Size(776, 511);
            this.tabPagDates.TabIndex = 2;
            this.tabPagDates.Text = "PAG View";
            // 
            // tableLayoutPanelPagView
            // 
            this.tableLayoutPanelPagView.ColumnCount = 1;
            this.tableLayoutPanelPagView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPagView.Controls.Add(this.flowLayoutPanelPAGSearch, 0, 0);
            this.tableLayoutPanelPagView.Controls.Add(this.dataGridViewPag, 0, 1);
            this.tableLayoutPanelPagView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPagView.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanelPagView.Name = "tableLayoutPanelPagView";
            this.tableLayoutPanelPagView.RowCount = 2;
            this.tableLayoutPanelPagView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPagView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPagView.Size = new System.Drawing.Size(772, 507);
            this.tableLayoutPanelPagView.TabIndex = 2;
            // 
            // flowLayoutPanelPAGSearch
            // 
            this.flowLayoutPanelPAGSearch.Controls.Add(this.labelPagViewFilter);
            this.flowLayoutPanelPAGSearch.Controls.Add(this.textBoxPagSearch);
            this.flowLayoutPanelPAGSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPAGSearch.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelPAGSearch.Name = "flowLayoutPanelPAGSearch";
            this.flowLayoutPanelPAGSearch.Size = new System.Drawing.Size(766, 29);
            this.flowLayoutPanelPAGSearch.TabIndex = 2;
            // 
            // labelPagViewFilter
            // 
            this.labelPagViewFilter.Location = new System.Drawing.Point(3, 0);
            this.labelPagViewFilter.Name = "labelPagViewFilter";
            this.labelPagViewFilter.Size = new System.Drawing.Size(145, 25);
            this.labelPagViewFilter.TabIndex = 3;
            this.labelPagViewFilter.Text = "Filter by Name, Year or Class:";
            this.labelPagViewFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPagSearch
            // 
            this.textBoxPagSearch.Location = new System.Drawing.Point(154, 3);
            this.textBoxPagSearch.Name = "textBoxPagSearch";
            this.textBoxPagSearch.Size = new System.Drawing.Size(184, 20);
            this.textBoxPagSearch.TabIndex = 4;
            this.textBoxPagSearch.TextChanged += new System.EventHandler(this.TextBoxPagSearch_TextChanged);
            // 
            // dataGridViewPag
            // 
            this.dataGridViewPag.AllowUserToAddRows = false;
            this.dataGridViewPag.AllowUserToDeleteRows = false;
            this.dataGridViewPag.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewPag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPag.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPag.Location = new System.Drawing.Point(3, 38);
            this.dataGridViewPag.Name = "dataGridViewPag";
            this.dataGridViewPag.ReadOnly = true;
            this.dataGridViewPag.RowHeadersVisible = false;
            this.dataGridViewPag.Size = new System.Drawing.Size(766, 466);
            this.dataGridViewPag.TabIndex = 1;
            this.dataGridViewPag.SelectionChanged += new System.EventHandler(this.DataGridViewPag_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Year";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Class";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // tabSkills
            // 
            this.tabSkills.Controls.Add(this.tableLayoutPanelSkillView);
            this.tabSkills.Location = new System.Drawing.Point(4, 22);
            this.tabSkills.Name = "tabSkills";
            this.tabSkills.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkills.Size = new System.Drawing.Size(776, 511);
            this.tabSkills.TabIndex = 0;
            this.tabSkills.Text = "Skills View";
            // 
            // tableLayoutPanelSkillView
            // 
            this.tableLayoutPanelSkillView.ColumnCount = 1;
            this.tableLayoutPanelSkillView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSkillView.Controls.Add(this.flowLayoutPanelSkillSearch, 0, 0);
            this.tableLayoutPanelSkillView.Controls.Add(this.dataGridViewSkills, 0, 1);
            this.tableLayoutPanelSkillView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSkillView.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelSkillView.Name = "tableLayoutPanelSkillView";
            this.tableLayoutPanelSkillView.RowCount = 2;
            this.tableLayoutPanelSkillView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelSkillView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSkillView.Size = new System.Drawing.Size(770, 505);
            this.tableLayoutPanelSkillView.TabIndex = 1;
            // 
            // flowLayoutPanelSkillSearch
            // 
            this.flowLayoutPanelSkillSearch.Controls.Add(this.labelSkillFilter);
            this.flowLayoutPanelSkillSearch.Controls.Add(this.textBoxSkillSearch);
            this.flowLayoutPanelSkillSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSkillSearch.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelSkillSearch.Name = "flowLayoutPanelSkillSearch";
            this.flowLayoutPanelSkillSearch.Size = new System.Drawing.Size(764, 29);
            this.flowLayoutPanelSkillSearch.TabIndex = 0;
            // 
            // labelSkillFilter
            // 
            this.labelSkillFilter.Location = new System.Drawing.Point(3, 0);
            this.labelSkillFilter.Name = "labelSkillFilter";
            this.labelSkillFilter.Size = new System.Drawing.Size(145, 25);
            this.labelSkillFilter.TabIndex = 5;
            this.labelSkillFilter.Text = "Filter by Name, Year or Class:";
            this.labelSkillFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSkillSearch
            // 
            this.textBoxSkillSearch.Location = new System.Drawing.Point(154, 3);
            this.textBoxSkillSearch.Name = "textBoxSkillSearch";
            this.textBoxSkillSearch.Size = new System.Drawing.Size(184, 20);
            this.textBoxSkillSearch.TabIndex = 6;
            this.textBoxSkillSearch.TextChanged += new System.EventHandler(this.TextBoxSkillSearch_TextChanged);
            // 
            // dataGridViewSkills
            // 
            this.dataGridViewSkills.AllowUserToAddRows = false;
            this.dataGridViewSkills.AllowUserToDeleteRows = false;
            this.dataGridViewSkills.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSkills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSkills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentFName,
            this.StudentLName,
            this.StudentYear,
            this.StudentClass});
            this.dataGridViewSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSkills.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSkills.Location = new System.Drawing.Point(3, 38);
            this.dataGridViewSkills.Name = "dataGridViewSkills";
            this.dataGridViewSkills.ReadOnly = true;
            this.dataGridViewSkills.RowHeadersVisible = false;
            this.dataGridViewSkills.Size = new System.Drawing.Size(764, 464);
            this.dataGridViewSkills.TabIndex = 0;
            this.dataGridViewSkills.SelectionChanged += new System.EventHandler(this.DataGridViewSkills_SelectionChanged);
            // 
            // StudentID
            // 
            this.StudentID.Frozen = true;
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // StudentFName
            // 
            this.StudentFName.Frozen = true;
            this.StudentFName.HeaderText = "First Name";
            this.StudentFName.Name = "StudentFName";
            this.StudentFName.ReadOnly = true;
            // 
            // StudentLName
            // 
            this.StudentLName.Frozen = true;
            this.StudentLName.HeaderText = "Last Name";
            this.StudentLName.Name = "StudentLName";
            this.StudentLName.ReadOnly = true;
            // 
            // StudentYear
            // 
            this.StudentYear.Frozen = true;
            this.StudentYear.HeaderText = "Year";
            this.StudentYear.Name = "StudentYear";
            this.StudentYear.ReadOnly = true;
            // 
            // StudentClass
            // 
            this.StudentClass.Frozen = true;
            this.StudentClass.HeaderText = "Class";
            this.StudentClass.Name = "StudentClass";
            this.StudentClass.ReadOnly = true;
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.tableLayoutPanelStudentReport);
            this.tabReport.Location = new System.Drawing.Point(4, 22);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(776, 511);
            this.tabReport.TabIndex = 7;
            this.tabReport.Text = "Student Report";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelStudentReport
            // 
            this.tableLayoutPanelStudentReport.ColumnCount = 3;
            this.tableLayoutPanelStudentReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelStudentReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelStudentReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelStudentReport.Controls.Add(this.buttonGenerateReport, 0, 0);
            this.tableLayoutPanelStudentReport.Controls.Add(this.progressBarStudentReport, 1, 0);
            this.tableLayoutPanelStudentReport.Controls.Add(this.dataGridViewStudentReport, 0, 1);
            this.tableLayoutPanelStudentReport.Controls.Add(this.labelReportSettings, 2, 0);
            this.tableLayoutPanelStudentReport.Controls.Add(this.flowLayoutPanelStudentReportSettings, 2, 1);
            this.tableLayoutPanelStudentReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelStudentReport.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelStudentReport.Name = "tableLayoutPanelStudentReport";
            this.tableLayoutPanelStudentReport.RowCount = 2;
            this.tableLayoutPanelStudentReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanelStudentReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelStudentReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelStudentReport.Size = new System.Drawing.Size(770, 505);
            this.tableLayoutPanelStudentReport.TabIndex = 0;
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGenerateReport.Location = new System.Drawing.Point(3, 3);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(94, 22);
            this.buttonGenerateReport.TabIndex = 0;
            this.buttonGenerateReport.Text = "Generate Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // progressBarStudentReport
            // 
            this.progressBarStudentReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarStudentReport.Location = new System.Drawing.Point(103, 3);
            this.progressBarStudentReport.Name = "progressBarStudentReport";
            this.progressBarStudentReport.Size = new System.Drawing.Size(464, 22);
            this.progressBarStudentReport.TabIndex = 1;
            // 
            // dataGridViewStudentReport
            // 
            this.dataGridViewStudentReport.AllowUserToAddRows = false;
            this.dataGridViewStudentReport.AllowUserToDeleteRows = false;
            this.dataGridViewStudentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentReportID,
            this.StudentReportFName,
            this.StudentReportSName,
            this.StudentReportYear,
            this.StudentReportClass,
            this.StudentReportCondition});
            this.tableLayoutPanelStudentReport.SetColumnSpan(this.dataGridViewStudentReport, 2);
            this.dataGridViewStudentReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudentReport.Location = new System.Drawing.Point(3, 31);
            this.dataGridViewStudentReport.Name = "dataGridViewStudentReport";
            this.dataGridViewStudentReport.ReadOnly = true;
            this.dataGridViewStudentReport.Size = new System.Drawing.Size(564, 471);
            this.dataGridViewStudentReport.TabIndex = 2;
            this.dataGridViewStudentReport.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentReport_CellEnter);
            // 
            // StudentReportID
            // 
            this.StudentReportID.HeaderText = "ID";
            this.StudentReportID.Name = "StudentReportID";
            this.StudentReportID.ReadOnly = true;
            this.StudentReportID.Visible = false;
            // 
            // StudentReportFName
            // 
            this.StudentReportFName.HeaderText = "First Name";
            this.StudentReportFName.Name = "StudentReportFName";
            this.StudentReportFName.ReadOnly = true;
            this.StudentReportFName.Width = 85;
            // 
            // StudentReportSName
            // 
            this.StudentReportSName.HeaderText = "Last Name";
            this.StudentReportSName.Name = "StudentReportSName";
            this.StudentReportSName.ReadOnly = true;
            this.StudentReportSName.Width = 85;
            // 
            // StudentReportYear
            // 
            this.StudentReportYear.HeaderText = "Year";
            this.StudentReportYear.Name = "StudentReportYear";
            this.StudentReportYear.ReadOnly = true;
            this.StudentReportYear.Width = 50;
            // 
            // StudentReportClass
            // 
            this.StudentReportClass.HeaderText = "Class";
            this.StudentReportClass.Name = "StudentReportClass";
            this.StudentReportClass.ReadOnly = true;
            this.StudentReportClass.Width = 50;
            // 
            // StudentReportCondition
            // 
            this.StudentReportCondition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentReportCondition.DefaultCellStyle = dataGridViewCellStyle2;
            this.StudentReportCondition.HeaderText = "Condition";
            this.StudentReportCondition.Name = "StudentReportCondition";
            this.StudentReportCondition.ReadOnly = true;
            // 
            // labelReportSettings
            // 
            this.labelReportSettings.AutoSize = true;
            this.labelReportSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReportSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportSettings.Location = new System.Drawing.Point(573, 0);
            this.labelReportSettings.Name = "labelReportSettings";
            this.labelReportSettings.Size = new System.Drawing.Size(194, 28);
            this.labelReportSettings.TabIndex = 3;
            this.labelReportSettings.Text = "Report Settings";
            this.labelReportSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelStudentReportSettings
            // 
            this.flowLayoutPanelStudentReportSettings.Controls.Add(this.labelFilterBy);
            this.flowLayoutPanelStudentReportSettings.Controls.Add(this.radioButtonReportComplete);
            this.flowLayoutPanelStudentReportSettings.Controls.Add(this.radioButtonReportNotComplete);
            this.flowLayoutPanelStudentReportSettings.Controls.Add(this.radioButtonReportAll);
            this.flowLayoutPanelStudentReportSettings.Controls.Add(this.buttonExportReport);
            this.flowLayoutPanelStudentReportSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelStudentReportSettings.Location = new System.Drawing.Point(573, 31);
            this.flowLayoutPanelStudentReportSettings.Name = "flowLayoutPanelStudentReportSettings";
            this.flowLayoutPanelStudentReportSettings.Size = new System.Drawing.Size(194, 471);
            this.flowLayoutPanelStudentReportSettings.TabIndex = 6;
            // 
            // labelFilterBy
            // 
            this.labelFilterBy.Location = new System.Drawing.Point(3, 0);
            this.labelFilterBy.Name = "labelFilterBy";
            this.labelFilterBy.Size = new System.Drawing.Size(189, 23);
            this.labelFilterBy.TabIndex = 8;
            this.labelFilterBy.Text = "Filter by:";
            this.labelFilterBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButtonReportComplete
            // 
            this.radioButtonReportComplete.Enabled = false;
            this.radioButtonReportComplete.Location = new System.Drawing.Point(3, 26);
            this.radioButtonReportComplete.Name = "radioButtonReportComplete";
            this.radioButtonReportComplete.Size = new System.Drawing.Size(191, 17);
            this.radioButtonReportComplete.TabIndex = 5;
            this.radioButtonReportComplete.Text = "Complete";
            this.radioButtonReportComplete.UseVisualStyleBackColor = true;
            this.radioButtonReportComplete.CheckedChanged += new System.EventHandler(this.radioButtonReportComplete_CheckedChanged);
            // 
            // radioButtonReportNotComplete
            // 
            this.radioButtonReportNotComplete.Enabled = false;
            this.radioButtonReportNotComplete.Location = new System.Drawing.Point(3, 49);
            this.radioButtonReportNotComplete.Name = "radioButtonReportNotComplete";
            this.radioButtonReportNotComplete.Size = new System.Drawing.Size(189, 17);
            this.radioButtonReportNotComplete.TabIndex = 5;
            this.radioButtonReportNotComplete.Text = "Not Complete";
            this.radioButtonReportNotComplete.UseVisualStyleBackColor = true;
            this.radioButtonReportNotComplete.CheckedChanged += new System.EventHandler(this.radioButtonReportNotComplete_CheckedChanged);
            // 
            // radioButtonReportAll
            // 
            this.radioButtonReportAll.Checked = true;
            this.radioButtonReportAll.Enabled = false;
            this.radioButtonReportAll.Location = new System.Drawing.Point(3, 72);
            this.radioButtonReportAll.Name = "radioButtonReportAll";
            this.radioButtonReportAll.Size = new System.Drawing.Size(189, 19);
            this.radioButtonReportAll.TabIndex = 5;
            this.radioButtonReportAll.TabStop = true;
            this.radioButtonReportAll.Text = "All";
            this.radioButtonReportAll.UseVisualStyleBackColor = true;
            this.radioButtonReportAll.CheckedChanged += new System.EventHandler(this.radioButtonReportAll_CheckedChanged);
            // 
            // buttonExportReport
            // 
            this.buttonExportReport.Location = new System.Drawing.Point(3, 97);
            this.buttonExportReport.Name = "buttonExportReport";
            this.buttonExportReport.Size = new System.Drawing.Size(113, 23);
            this.buttonExportReport.TabIndex = 9;
            this.buttonExportReport.Text = "Export to Excel";
            this.buttonExportReport.UseVisualStyleBackColor = true;
            this.buttonExportReport.Click += new System.EventHandler(this.buttonExportReport_Click);
            // 
            // tabActivitySelection
            // 
            this.tabActivitySelection.Controls.Add(this.tableLayoutPanelActivitySelection);
            this.tabActivitySelection.Location = new System.Drawing.Point(4, 22);
            this.tabActivitySelection.Name = "tabActivitySelection";
            this.tabActivitySelection.Padding = new System.Windows.Forms.Padding(3);
            this.tabActivitySelection.Size = new System.Drawing.Size(776, 511);
            this.tabActivitySelection.TabIndex = 4;
            this.tabActivitySelection.Text = "Activity Selection";
            this.tabActivitySelection.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelActivitySelection
            // 
            this.tableLayoutPanelActivitySelection.ColumnCount = 2;
            this.tableLayoutPanelActivitySelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelActivitySelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelActivitySelection.Controls.Add(this.labelActivitySelectionSkill, 1, 0);
            this.tableLayoutPanelActivitySelection.Controls.Add(this.dataGridViewActivitySelectionSkills, 1, 1);
            this.tableLayoutPanelActivitySelection.Controls.Add(this.checkedListBoxActivitySelectionPag, 0, 1);
            this.tableLayoutPanelActivitySelection.Controls.Add(this.tableLayoutPanelActivitySelectionToolbar, 0, 0);
            this.tableLayoutPanelActivitySelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelActivitySelection.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelActivitySelection.Name = "tableLayoutPanelActivitySelection";
            this.tableLayoutPanelActivitySelection.RowCount = 2;
            this.tableLayoutPanelActivitySelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelActivitySelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelActivitySelection.Size = new System.Drawing.Size(770, 505);
            this.tableLayoutPanelActivitySelection.TabIndex = 0;
            // 
            // labelActivitySelectionSkill
            // 
            this.labelActivitySelectionSkill.AutoSize = true;
            this.labelActivitySelectionSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelActivitySelectionSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivitySelectionSkill.Location = new System.Drawing.Point(388, 0);
            this.labelActivitySelectionSkill.Name = "labelActivitySelectionSkill";
            this.labelActivitySelectionSkill.Size = new System.Drawing.Size(379, 34);
            this.labelActivitySelectionSkill.TabIndex = 3;
            this.labelActivitySelectionSkill.Text = "Specification Content:";
            this.labelActivitySelectionSkill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewActivitySelectionSkills
            // 
            this.dataGridViewActivitySelectionSkills.AllowUserToAddRows = false;
            this.dataGridViewActivitySelectionSkills.AllowUserToDeleteRows = false;
            this.dataGridViewActivitySelectionSkills.AllowUserToResizeColumns = false;
            this.dataGridViewActivitySelectionSkills.AllowUserToResizeRows = false;
            this.dataGridViewActivitySelectionSkills.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewActivitySelectionSkills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewActivitySelectionSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivitySelectionSkills.ColumnHeadersVisible = false;
            this.dataGridViewActivitySelectionSkills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkillName});
            this.dataGridViewActivitySelectionSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewActivitySelectionSkills.Location = new System.Drawing.Point(388, 37);
            this.dataGridViewActivitySelectionSkills.MultiSelect = false;
            this.dataGridViewActivitySelectionSkills.Name = "dataGridViewActivitySelectionSkills";
            this.dataGridViewActivitySelectionSkills.ReadOnly = true;
            this.dataGridViewActivitySelectionSkills.RowHeadersVisible = false;
            this.dataGridViewActivitySelectionSkills.RowHeadersWidth = 61;
            this.dataGridViewActivitySelectionSkills.RowTemplate.Height = 20;
            this.dataGridViewActivitySelectionSkills.Size = new System.Drawing.Size(379, 465);
            this.dataGridViewActivitySelectionSkills.TabIndex = 0;
            this.dataGridViewActivitySelectionSkills.SelectionChanged += new System.EventHandler(this.dataGridViewActivitySelectionSkills_SelectionChanged);
            // 
            // SkillName
            // 
            this.SkillName.HeaderText = "SkillName";
            this.SkillName.Name = "SkillName";
            this.SkillName.ReadOnly = true;
            // 
            // checkedListBoxActivitySelectionPag
            // 
            this.checkedListBoxActivitySelectionPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxActivitySelectionPag.CheckOnClick = true;
            this.checkedListBoxActivitySelectionPag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxActivitySelectionPag.FormattingEnabled = true;
            this.checkedListBoxActivitySelectionPag.Location = new System.Drawing.Point(3, 37);
            this.checkedListBoxActivitySelectionPag.Name = "checkedListBoxActivitySelectionPag";
            this.checkedListBoxActivitySelectionPag.Size = new System.Drawing.Size(379, 465);
            this.checkedListBoxActivitySelectionPag.TabIndex = 4;
            this.checkedListBoxActivitySelectionPag.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxActivitySelectionPag_ItemCheck);
            // 
            // tableLayoutPanelActivitySelectionToolbar
            // 
            this.tableLayoutPanelActivitySelectionToolbar.ColumnCount = 2;
            this.tableLayoutPanelActivitySelectionToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanelActivitySelectionToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelActivitySelectionToolbar.Controls.Add(this.labelActivitySelectionPag, 0, 0);
            this.tableLayoutPanelActivitySelectionToolbar.Controls.Add(this.buttonActivitySelectResetSelection, 1, 0);
            this.tableLayoutPanelActivitySelectionToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelActivitySelectionToolbar.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelActivitySelectionToolbar.Name = "tableLayoutPanelActivitySelectionToolbar";
            this.tableLayoutPanelActivitySelectionToolbar.RowCount = 1;
            this.tableLayoutPanelActivitySelectionToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelActivitySelectionToolbar.Size = new System.Drawing.Size(379, 28);
            this.tableLayoutPanelActivitySelectionToolbar.TabIndex = 5;
            // 
            // labelActivitySelectionPag
            // 
            this.labelActivitySelectionPag.AutoSize = true;
            this.labelActivitySelectionPag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelActivitySelectionPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivitySelectionPag.Location = new System.Drawing.Point(3, 0);
            this.labelActivitySelectionPag.Name = "labelActivitySelectionPag";
            this.labelActivitySelectionPag.Size = new System.Drawing.Size(117, 28);
            this.labelActivitySelectionPag.TabIndex = 4;
            this.labelActivitySelectionPag.Text = "Activity Selection:";
            this.labelActivitySelectionPag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonActivitySelectResetSelection
            // 
            this.buttonActivitySelectResetSelection.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonActivitySelectResetSelection.Location = new System.Drawing.Point(278, 3);
            this.buttonActivitySelectResetSelection.Name = "buttonActivitySelectResetSelection";
            this.buttonActivitySelectResetSelection.Size = new System.Drawing.Size(98, 22);
            this.buttonActivitySelectResetSelection.TabIndex = 5;
            this.buttonActivitySelectResetSelection.Text = "Reset Selection";
            this.buttonActivitySelectResetSelection.UseVisualStyleBackColor = true;
            this.buttonActivitySelectResetSelection.Click += new System.EventHandler(this.buttonActivitySelectResetSelection_Click);
            // 
            // tabContentSelection
            // 
            this.tabContentSelection.Controls.Add(this.tableLayoutPanelContentSelection);
            this.tabContentSelection.Location = new System.Drawing.Point(4, 22);
            this.tabContentSelection.Name = "tabContentSelection";
            this.tabContentSelection.Padding = new System.Windows.Forms.Padding(3);
            this.tabContentSelection.Size = new System.Drawing.Size(776, 511);
            this.tabContentSelection.TabIndex = 5;
            this.tabContentSelection.Text = "Specification Content Selection";
            this.tabContentSelection.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelContentSelection
            // 
            this.tableLayoutPanelContentSelection.ColumnCount = 2;
            this.tableLayoutPanelContentSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContentSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContentSelection.Controls.Add(this.dataGridViewContentSelectionPag, 0, 1);
            this.tableLayoutPanelContentSelection.Controls.Add(this.checkedListBoxContentSelectionSkill, 1, 1);
            this.tableLayoutPanelContentSelection.Controls.Add(this.tableLayoutContentSelectionSkill, 1, 0);
            this.tableLayoutPanelContentSelection.Controls.Add(this.tableLayoutPanelContentSelectionActivitySelection, 0, 0);
            this.tableLayoutPanelContentSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContentSelection.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelContentSelection.Name = "tableLayoutPanelContentSelection";
            this.tableLayoutPanelContentSelection.RowCount = 2;
            this.tableLayoutPanelContentSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanelContentSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContentSelection.Size = new System.Drawing.Size(770, 505);
            this.tableLayoutPanelContentSelection.TabIndex = 1;
            // 
            // dataGridViewContentSelectionPag
            // 
            this.dataGridViewContentSelectionPag.AllowUserToAddRows = false;
            this.dataGridViewContentSelectionPag.AllowUserToDeleteRows = false;
            this.dataGridViewContentSelectionPag.AllowUserToResizeColumns = false;
            this.dataGridViewContentSelectionPag.AllowUserToResizeRows = false;
            this.dataGridViewContentSelectionPag.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewContentSelectionPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewContentSelectionPag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContentSelectionPag.ColumnHeadersVisible = false;
            this.dataGridViewContentSelectionPag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewContentSelectionPag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewContentSelectionPag.Location = new System.Drawing.Point(3, 45);
            this.dataGridViewContentSelectionPag.MultiSelect = false;
            this.dataGridViewContentSelectionPag.Name = "dataGridViewContentSelectionPag";
            this.dataGridViewContentSelectionPag.ReadOnly = true;
            this.dataGridViewContentSelectionPag.RowHeadersVisible = false;
            this.dataGridViewContentSelectionPag.RowHeadersWidth = 61;
            this.dataGridViewContentSelectionPag.RowTemplate.Height = 20;
            this.dataGridViewContentSelectionPag.Size = new System.Drawing.Size(379, 457);
            this.dataGridViewContentSelectionPag.TabIndex = 0;
            this.dataGridViewContentSelectionPag.SelectionChanged += new System.EventHandler(this.dataGridViewContentSelectionPag_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "SkillName";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // checkedListBoxContentSelectionSkill
            // 
            this.checkedListBoxContentSelectionSkill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxContentSelectionSkill.CheckOnClick = true;
            this.checkedListBoxContentSelectionSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxContentSelectionSkill.FormattingEnabled = true;
            this.checkedListBoxContentSelectionSkill.Location = new System.Drawing.Point(388, 45);
            this.checkedListBoxContentSelectionSkill.Name = "checkedListBoxContentSelectionSkill";
            this.checkedListBoxContentSelectionSkill.Size = new System.Drawing.Size(379, 457);
            this.checkedListBoxContentSelectionSkill.TabIndex = 4;
            this.checkedListBoxContentSelectionSkill.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxContentSelectionSkill_ItemCheck);
            // 
            // tableLayoutContentSelectionSkill
            // 
            this.tableLayoutContentSelectionSkill.ColumnCount = 2;
            this.tableLayoutContentSelectionSkill.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutContentSelectionSkill.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutContentSelectionSkill.Controls.Add(this.labelContentSelectionSkill, 0, 0);
            this.tableLayoutContentSelectionSkill.Controls.Add(this.buttonContentSelectionSelectionReset, 1, 0);
            this.tableLayoutContentSelectionSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutContentSelectionSkill.Location = new System.Drawing.Point(388, 3);
            this.tableLayoutContentSelectionSkill.Name = "tableLayoutContentSelectionSkill";
            this.tableLayoutContentSelectionSkill.RowCount = 1;
            this.tableLayoutContentSelectionSkill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutContentSelectionSkill.Size = new System.Drawing.Size(379, 36);
            this.tableLayoutContentSelectionSkill.TabIndex = 5;
            // 
            // labelContentSelectionSkill
            // 
            this.labelContentSelectionSkill.AutoSize = true;
            this.labelContentSelectionSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelContentSelectionSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContentSelectionSkill.Location = new System.Drawing.Point(3, 0);
            this.labelContentSelectionSkill.Name = "labelContentSelectionSkill";
            this.labelContentSelectionSkill.Size = new System.Drawing.Size(136, 36);
            this.labelContentSelectionSkill.TabIndex = 4;
            this.labelContentSelectionSkill.Text = "Specification Content:";
            this.labelContentSelectionSkill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonContentSelectionSelectionReset
            // 
            this.buttonContentSelectionSelectionReset.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonContentSelectionSelectionReset.Location = new System.Drawing.Point(278, 3);
            this.buttonContentSelectionSelectionReset.Name = "buttonContentSelectionSelectionReset";
            this.buttonContentSelectionSelectionReset.Size = new System.Drawing.Size(98, 30);
            this.buttonContentSelectionSelectionReset.TabIndex = 5;
            this.buttonContentSelectionSelectionReset.Text = "Reset Selection";
            this.buttonContentSelectionSelectionReset.UseVisualStyleBackColor = true;
            this.buttonContentSelectionSelectionReset.Click += new System.EventHandler(this.buttonContentSelectionSelectionReset_Click);
            // 
            // tableLayoutPanelContentSelectionActivitySelection
            // 
            this.tableLayoutPanelContentSelectionActivitySelection.ColumnCount = 2;
            this.tableLayoutPanelContentSelectionActivitySelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanelContentSelectionActivitySelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tableLayoutPanelContentSelectionActivitySelection.Controls.Add(this.labelContentSelectionPag, 0, 0);
            this.tableLayoutPanelContentSelectionActivitySelection.Controls.Add(this.listBoxContentSelectionInclusion, 1, 0);
            this.tableLayoutPanelContentSelectionActivitySelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContentSelectionActivitySelection.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelContentSelectionActivitySelection.Name = "tableLayoutPanelContentSelectionActivitySelection";
            this.tableLayoutPanelContentSelectionActivitySelection.RowCount = 1;
            this.tableLayoutPanelContentSelectionActivitySelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContentSelectionActivitySelection.Size = new System.Drawing.Size(379, 36);
            this.tableLayoutPanelContentSelectionActivitySelection.TabIndex = 6;
            // 
            // labelContentSelectionPag
            // 
            this.labelContentSelectionPag.AutoSize = true;
            this.labelContentSelectionPag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelContentSelectionPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContentSelectionPag.Location = new System.Drawing.Point(3, 0);
            this.labelContentSelectionPag.Name = "labelContentSelectionPag";
            this.labelContentSelectionPag.Size = new System.Drawing.Size(112, 36);
            this.labelContentSelectionPag.TabIndex = 4;
            this.labelContentSelectionPag.Text = "Activity Selection:";
            this.labelContentSelectionPag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxContentSelectionInclusion
            // 
            this.listBoxContentSelectionInclusion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxContentSelectionInclusion.FormattingEnabled = true;
            this.listBoxContentSelectionInclusion.Items.AddRange(new object[] {
            "PAG\'s must contain at least 1 selected skill",
            "PAG\'s must contain all selected skills"});
            this.listBoxContentSelectionInclusion.Location = new System.Drawing.Point(121, 3);
            this.listBoxContentSelectionInclusion.Name = "listBoxContentSelectionInclusion";
            this.listBoxContentSelectionInclusion.Size = new System.Drawing.Size(255, 30);
            this.listBoxContentSelectionInclusion.TabIndex = 5;
            this.listBoxContentSelectionInclusion.SelectedIndexChanged += new System.EventHandler(this.listBoxContentSelectionInclusion_SelectedIndexChanged);
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabControlAdmin);
            this.tabAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(776, 511);
            this.tabAdmin.TabIndex = 1;
            this.tabAdmin.Text = "Admin";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabSkillPagList);
            this.tabControlAdmin.Controls.Add(this.tabPagSkillRelation);
            this.tabControlAdmin.Controls.Add(this.tabSkillRequirements);
            this.tabControlAdmin.Controls.Add(this.tabGroup);
            this.tabControlAdmin.Controls.Add(this.tabStudentImport);
            this.tabControlAdmin.Controls.Add(this.tabStudentManagement);
            this.tabControlAdmin.Controls.Add(this.tabGeneral);
            this.tabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdmin.Location = new System.Drawing.Point(3, 3);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(770, 505);
            this.tabControlAdmin.TabIndex = 3;
            this.tabControlAdmin.Resize += new System.EventHandler(this.tabControlAdmin_Resize);
            // 
            // tabSkillPagList
            // 
            this.tabSkillPagList.Controls.Add(this.tableLayoutPanelPagSkillList);
            this.tabSkillPagList.Location = new System.Drawing.Point(4, 22);
            this.tabSkillPagList.Name = "tabSkillPagList";
            this.tabSkillPagList.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkillPagList.Size = new System.Drawing.Size(762, 479);
            this.tabSkillPagList.TabIndex = 1;
            this.tabSkillPagList.Text = "List of PAG\'s and Skills";
            this.tabSkillPagList.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelPagSkillList
            // 
            this.tableLayoutPanelPagSkillList.ColumnCount = 2;
            this.tableLayoutPanelPagSkillList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPagSkillList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPagSkillList.Controls.Add(this.listBoxSkillList, 0, 1);
            this.tableLayoutPanelPagSkillList.Controls.Add(this.toolStripSkillList, 1, 0);
            this.tableLayoutPanelPagSkillList.Controls.Add(this.toolStripPagList, 0, 0);
            this.tableLayoutPanelPagSkillList.Controls.Add(this.listBoxPagList, 0, 1);
            this.tableLayoutPanelPagSkillList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPagSkillList.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelPagSkillList.Name = "tableLayoutPanelPagSkillList";
            this.tableLayoutPanelPagSkillList.RowCount = 2;
            this.tableLayoutPanelPagSkillList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelPagSkillList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPagSkillList.Size = new System.Drawing.Size(756, 473);
            this.tableLayoutPanelPagSkillList.TabIndex = 0;
            // 
            // listBoxSkillList
            // 
            this.listBoxSkillList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSkillList.FormattingEnabled = true;
            this.listBoxSkillList.Location = new System.Drawing.Point(381, 28);
            this.listBoxSkillList.Name = "listBoxSkillList";
            this.listBoxSkillList.Size = new System.Drawing.Size(372, 442);
            this.listBoxSkillList.TabIndex = 3;
            this.listBoxSkillList.SelectedIndexChanged += new System.EventHandler(this.listBoxSkillList_SelectedIndexChanged);
            // 
            // toolStripSkillList
            // 
            this.toolStripSkillList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skillListToolStripLabel,
            this.skillListToolStripTextBox,
            this.skillListToolStripSeparator,
            this.skillListToolStripButtonAddRecord,
            this.skillListToolStripButtonRemovePag,
            this.skillListToolStripButtonSave});
            this.toolStripSkillList.Location = new System.Drawing.Point(378, 0);
            this.toolStripSkillList.Name = "toolStripSkillList";
            this.toolStripSkillList.Size = new System.Drawing.Size(378, 25);
            this.toolStripSkillList.TabIndex = 2;
            this.toolStripSkillList.Text = "PAG list tool strip";
            // 
            // skillListToolStripLabel
            // 
            this.skillListToolStripLabel.Name = "skillListToolStripLabel";
            this.skillListToolStripLabel.Size = new System.Drawing.Size(36, 22);
            this.skillListToolStripLabel.Text = "Skills:";
            // 
            // skillListToolStripTextBox
            // 
            this.skillListToolStripTextBox.Enabled = false;
            this.skillListToolStripTextBox.Name = "skillListToolStripTextBox";
            this.skillListToolStripTextBox.Size = new System.Drawing.Size(237, 25);
            this.skillListToolStripTextBox.TextChanged += new System.EventHandler(this.skillListToolStripTextBox_TextChanged);
            // 
            // skillListToolStripSeparator
            // 
            this.skillListToolStripSeparator.Name = "skillListToolStripSeparator";
            this.skillListToolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // skillListToolStripButtonAddRecord
            // 
            this.skillListToolStripButtonAddRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.skillListToolStripButtonAddRecord.Image = ((System.Drawing.Image)(resources.GetObject("skillListToolStripButtonAddRecord.Image")));
            this.skillListToolStripButtonAddRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.skillListToolStripButtonAddRecord.Name = "skillListToolStripButtonAddRecord";
            this.skillListToolStripButtonAddRecord.Size = new System.Drawing.Size(23, 22);
            this.skillListToolStripButtonAddRecord.Text = "Add Record";
            this.skillListToolStripButtonAddRecord.Click += new System.EventHandler(this.skillListToolStripButtonAddRecord_Click);
            // 
            // skillListToolStripButtonRemovePag
            // 
            this.skillListToolStripButtonRemovePag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.skillListToolStripButtonRemovePag.Image = ((System.Drawing.Image)(resources.GetObject("skillListToolStripButtonRemovePag.Image")));
            this.skillListToolStripButtonRemovePag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.skillListToolStripButtonRemovePag.Name = "skillListToolStripButtonRemovePag";
            this.skillListToolStripButtonRemovePag.Size = new System.Drawing.Size(23, 22);
            this.skillListToolStripButtonRemovePag.Text = "Remove Record";
            this.skillListToolStripButtonRemovePag.Click += new System.EventHandler(this.skillListToolStripButtonRemovePag_Click);
            // 
            // skillListToolStripButtonSave
            // 
            this.skillListToolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.skillListToolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("skillListToolStripButtonSave.Image")));
            this.skillListToolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.skillListToolStripButtonSave.Name = "skillListToolStripButtonSave";
            this.skillListToolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.skillListToolStripButtonSave.Text = "Save Data";
            this.skillListToolStripButtonSave.Click += new System.EventHandler(this.skillListToolStripButtonSave_Click);
            // 
            // toolStripPagList
            // 
            this.toolStripPagList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagListToolStripLabel,
            this.pagListToolStripTextBox,
            this.pagListToolStripSeparator,
            this.pagListToolStripButtonAddRecord,
            this.pagListToolStripButtonRemovePag,
            this.pagListToolStripButtonSave});
            this.toolStripPagList.Location = new System.Drawing.Point(0, 0);
            this.toolStripPagList.Name = "toolStripPagList";
            this.toolStripPagList.Size = new System.Drawing.Size(378, 25);
            this.toolStripPagList.TabIndex = 0;
            this.toolStripPagList.Text = "PAG list tool strip";
            // 
            // pagListToolStripLabel
            // 
            this.pagListToolStripLabel.Name = "pagListToolStripLabel";
            this.pagListToolStripLabel.Size = new System.Drawing.Size(37, 22);
            this.pagListToolStripLabel.Text = "PAGs:";
            // 
            // pagListToolStripTextBox
            // 
            this.pagListToolStripTextBox.Enabled = false;
            this.pagListToolStripTextBox.Name = "pagListToolStripTextBox";
            this.pagListToolStripTextBox.Size = new System.Drawing.Size(237, 25);
            this.pagListToolStripTextBox.TextChanged += new System.EventHandler(this.pagListToolStripTextBox_TextChanged);
            // 
            // pagListToolStripSeparator
            // 
            this.pagListToolStripSeparator.Name = "pagListToolStripSeparator";
            this.pagListToolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // pagListToolStripButtonAddRecord
            // 
            this.pagListToolStripButtonAddRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pagListToolStripButtonAddRecord.Image = ((System.Drawing.Image)(resources.GetObject("pagListToolStripButtonAddRecord.Image")));
            this.pagListToolStripButtonAddRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pagListToolStripButtonAddRecord.Name = "pagListToolStripButtonAddRecord";
            this.pagListToolStripButtonAddRecord.Size = new System.Drawing.Size(23, 22);
            this.pagListToolStripButtonAddRecord.Text = "Add Record";
            this.pagListToolStripButtonAddRecord.Click += new System.EventHandler(this.pagListToolStripButtonAddRecord_Click);
            // 
            // pagListToolStripButtonRemovePag
            // 
            this.pagListToolStripButtonRemovePag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pagListToolStripButtonRemovePag.Image = ((System.Drawing.Image)(resources.GetObject("pagListToolStripButtonRemovePag.Image")));
            this.pagListToolStripButtonRemovePag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pagListToolStripButtonRemovePag.Name = "pagListToolStripButtonRemovePag";
            this.pagListToolStripButtonRemovePag.Size = new System.Drawing.Size(23, 22);
            this.pagListToolStripButtonRemovePag.Text = "Remove Record";
            this.pagListToolStripButtonRemovePag.Click += new System.EventHandler(this.pagListToolStripButtonRemovePag_Click);
            // 
            // pagListToolStripButtonSave
            // 
            this.pagListToolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pagListToolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("pagListToolStripButtonSave.Image")));
            this.pagListToolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pagListToolStripButtonSave.Name = "pagListToolStripButtonSave";
            this.pagListToolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.pagListToolStripButtonSave.Text = "Save Data";
            this.pagListToolStripButtonSave.Click += new System.EventHandler(this.pagListToolStripButtonSave_Click);
            // 
            // listBoxPagList
            // 
            this.listBoxPagList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPagList.FormattingEnabled = true;
            this.listBoxPagList.Location = new System.Drawing.Point(3, 28);
            this.listBoxPagList.Name = "listBoxPagList";
            this.listBoxPagList.Size = new System.Drawing.Size(372, 442);
            this.listBoxPagList.TabIndex = 1;
            this.listBoxPagList.SelectedIndexChanged += new System.EventHandler(this.listBoxPagList_SelectedIndexChanged);
            // 
            // tabPagSkillRelation
            // 
            this.tabPagSkillRelation.Controls.Add(this.tableLayoutPanelPagSkillRelation);
            this.tabPagSkillRelation.Location = new System.Drawing.Point(4, 22);
            this.tabPagSkillRelation.Name = "tabPagSkillRelation";
            this.tabPagSkillRelation.Size = new System.Drawing.Size(762, 479);
            this.tabPagSkillRelation.TabIndex = 2;
            this.tabPagSkillRelation.Text = "PAG and Skill Relations";
            this.tabPagSkillRelation.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelPagSkillRelation
            // 
            this.tableLayoutPanelPagSkillRelation.ColumnCount = 2;
            this.tableLayoutPanelPagSkillRelation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPagSkillRelation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPagSkillRelation.Controls.Add(this.buttonBuildPagSkillRelation, 0, 0);
            this.tableLayoutPanelPagSkillRelation.Controls.Add(this.listBoxPagRelation, 0, 1);
            this.tableLayoutPanelPagSkillRelation.Controls.Add(this.checkedListBoxSkillRelation, 1, 1);
            this.tableLayoutPanelPagSkillRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPagSkillRelation.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPagSkillRelation.Name = "tableLayoutPanelPagSkillRelation";
            this.tableLayoutPanelPagSkillRelation.RowCount = 2;
            this.tableLayoutPanelPagSkillRelation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPagSkillRelation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPagSkillRelation.Size = new System.Drawing.Size(762, 479);
            this.tableLayoutPanelPagSkillRelation.TabIndex = 0;
            // 
            // buttonBuildPagSkillRelation
            // 
            this.buttonBuildPagSkillRelation.Location = new System.Drawing.Point(3, 3);
            this.buttonBuildPagSkillRelation.Name = "buttonBuildPagSkillRelation";
            this.buttonBuildPagSkillRelation.Size = new System.Drawing.Size(148, 23);
            this.buttonBuildPagSkillRelation.TabIndex = 2;
            this.buttonBuildPagSkillRelation.Text = "Save PAG-Skill Relations";
            this.buttonBuildPagSkillRelation.UseVisualStyleBackColor = true;
            this.buttonBuildPagSkillRelation.Click += new System.EventHandler(this.buttonBuildPagSkillRelation_Click);
            // 
            // listBoxPagRelation
            // 
            this.listBoxPagRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPagRelation.FormattingEnabled = true;
            this.listBoxPagRelation.Location = new System.Drawing.Point(3, 33);
            this.listBoxPagRelation.Name = "listBoxPagRelation";
            this.listBoxPagRelation.Size = new System.Drawing.Size(375, 443);
            this.listBoxPagRelation.TabIndex = 0;
            this.listBoxPagRelation.SelectedIndexChanged += new System.EventHandler(this.listBoxPagRelation_SelectedIndexChanged);
            // 
            // checkedListBoxSkillRelation
            // 
            this.checkedListBoxSkillRelation.CheckOnClick = true;
            this.checkedListBoxSkillRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxSkillRelation.FormattingEnabled = true;
            this.checkedListBoxSkillRelation.Location = new System.Drawing.Point(384, 33);
            this.checkedListBoxSkillRelation.Name = "checkedListBoxSkillRelation";
            this.checkedListBoxSkillRelation.Size = new System.Drawing.Size(375, 443);
            this.checkedListBoxSkillRelation.TabIndex = 1;
            this.checkedListBoxSkillRelation.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxSkillRelation_ItemCheck);
            // 
            // tabSkillRequirements
            // 
            this.tabSkillRequirements.Controls.Add(this.tableLayoutPanelSkillRequirement);
            this.tabSkillRequirements.Location = new System.Drawing.Point(4, 22);
            this.tabSkillRequirements.Name = "tabSkillRequirements";
            this.tabSkillRequirements.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkillRequirements.Size = new System.Drawing.Size(762, 479);
            this.tabSkillRequirements.TabIndex = 3;
            this.tabSkillRequirements.Text = "Skill Requirements";
            this.tabSkillRequirements.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelSkillRequirement
            // 
            this.tableLayoutPanelSkillRequirement.ColumnCount = 1;
            this.tableLayoutPanelSkillRequirement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSkillRequirement.Controls.Add(this.dataGridViewSkillRequirement, 0, 1);
            this.tableLayoutPanelSkillRequirement.Controls.Add(this.buttonSaveSkillRequirement, 0, 0);
            this.tableLayoutPanelSkillRequirement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSkillRequirement.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelSkillRequirement.Name = "tableLayoutPanelSkillRequirement";
            this.tableLayoutPanelSkillRequirement.RowCount = 2;
            this.tableLayoutPanelSkillRequirement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelSkillRequirement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSkillRequirement.Size = new System.Drawing.Size(756, 473);
            this.tableLayoutPanelSkillRequirement.TabIndex = 0;
            // 
            // dataGridViewSkillRequirement
            // 
            this.dataGridViewSkillRequirement.AllowUserToAddRows = false;
            this.dataGridViewSkillRequirement.AllowUserToDeleteRows = false;
            this.dataGridViewSkillRequirement.AllowUserToResizeRows = false;
            this.dataGridViewSkillRequirement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSkillRequirement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkillRequirementsTableSkillName,
            this.SkillRequirementsTableRequiredAmount});
            this.dataGridViewSkillRequirement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSkillRequirement.Location = new System.Drawing.Point(3, 33);
            this.dataGridViewSkillRequirement.Name = "dataGridViewSkillRequirement";
            this.dataGridViewSkillRequirement.RowHeadersVisible = false;
            this.dataGridViewSkillRequirement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSkillRequirement.Size = new System.Drawing.Size(750, 437);
            this.dataGridViewSkillRequirement.TabIndex = 0;
            this.dataGridViewSkillRequirement.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSkillRequirement_CellEndEdit);
            // 
            // SkillRequirementsTableSkillName
            // 
            this.SkillRequirementsTableSkillName.HeaderText = "Skill Name";
            this.SkillRequirementsTableSkillName.Name = "SkillRequirementsTableSkillName";
            this.SkillRequirementsTableSkillName.ReadOnly = true;
            this.SkillRequirementsTableSkillName.Width = 630;
            // 
            // SkillRequirementsTableRequiredAmount
            // 
            this.SkillRequirementsTableRequiredAmount.HeaderText = "Times Required to Show Proficiency";
            this.SkillRequirementsTableRequiredAmount.Name = "SkillRequirementsTableRequiredAmount";
            // 
            // buttonSaveSkillRequirement
            // 
            this.buttonSaveSkillRequirement.Location = new System.Drawing.Point(3, 3);
            this.buttonSaveSkillRequirement.Name = "buttonSaveSkillRequirement";
            this.buttonSaveSkillRequirement.Size = new System.Drawing.Size(138, 23);
            this.buttonSaveSkillRequirement.TabIndex = 1;
            this.buttonSaveSkillRequirement.Text = "Save Skill Requirements";
            this.buttonSaveSkillRequirement.UseVisualStyleBackColor = true;
            this.buttonSaveSkillRequirement.Click += new System.EventHandler(this.buttonSaveSkillRequirement_Click);
            // 
            // tabGroup
            // 
            this.tabGroup.Controls.Add(this.tableLayoutPanelPagGroup);
            this.tabGroup.Location = new System.Drawing.Point(4, 22);
            this.tabGroup.Name = "tabGroup";
            this.tabGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tabGroup.Size = new System.Drawing.Size(762, 479);
            this.tabGroup.TabIndex = 5;
            this.tabGroup.Text = "PAG Groups";
            this.tabGroup.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelPagGroup
            // 
            this.tableLayoutPanelPagGroup.ColumnCount = 2;
            this.tableLayoutPanelPagGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPagGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPagGroup.Controls.Add(this.pagGroupToolStrip, 0, 0);
            this.tableLayoutPanelPagGroup.Controls.Add(this.listBoxGroupList, 0, 1);
            this.tableLayoutPanelPagGroup.Controls.Add(this.checkedListBoxPagList, 1, 1);
            this.tableLayoutPanelPagGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPagGroup.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelPagGroup.Name = "tableLayoutPanelPagGroup";
            this.tableLayoutPanelPagGroup.RowCount = 2;
            this.tableLayoutPanelPagGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelPagGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPagGroup.Size = new System.Drawing.Size(756, 473);
            this.tableLayoutPanelPagGroup.TabIndex = 1;
            // 
            // pagGroupToolStrip
            // 
            this.pagGroupToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagGroupToolStripLabel,
            this.pagGroupToolStripTextBox,
            this.pagGroupToolStripSeperator,
            this.pagGroupToolStripButtonAdd,
            this.pagGroupToolStripRemove,
            this.pagGroupToolStripSave});
            this.pagGroupToolStrip.Location = new System.Drawing.Point(0, 0);
            this.pagGroupToolStrip.Name = "pagGroupToolStrip";
            this.pagGroupToolStrip.Size = new System.Drawing.Size(378, 25);
            this.pagGroupToolStrip.TabIndex = 0;
            this.pagGroupToolStrip.Text = "PAG list tool strip";
            // 
            // pagGroupToolStripLabel
            // 
            this.pagGroupToolStripLabel.Name = "pagGroupToolStripLabel";
            this.pagGroupToolStripLabel.Size = new System.Drawing.Size(48, 22);
            this.pagGroupToolStripLabel.Text = "Groups:";
            // 
            // pagGroupToolStripTextBox
            // 
            this.pagGroupToolStripTextBox.Name = "pagGroupToolStripTextBox";
            this.pagGroupToolStripTextBox.Size = new System.Drawing.Size(226, 25);
            this.pagGroupToolStripTextBox.TextChanged += new System.EventHandler(this.pagGroupToolStripTextBox_TextChanged);
            // 
            // pagGroupToolStripSeperator
            // 
            this.pagGroupToolStripSeperator.Name = "pagGroupToolStripSeperator";
            this.pagGroupToolStripSeperator.Size = new System.Drawing.Size(6, 25);
            // 
            // pagGroupToolStripButtonAdd
            // 
            this.pagGroupToolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pagGroupToolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("pagGroupToolStripButtonAdd.Image")));
            this.pagGroupToolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pagGroupToolStripButtonAdd.Name = "pagGroupToolStripButtonAdd";
            this.pagGroupToolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.pagGroupToolStripButtonAdd.Text = "Add Record";
            this.pagGroupToolStripButtonAdd.Click += new System.EventHandler(this.pagGroupToolStripButtonAdd_Click);
            // 
            // pagGroupToolStripRemove
            // 
            this.pagGroupToolStripRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pagGroupToolStripRemove.Image = ((System.Drawing.Image)(resources.GetObject("pagGroupToolStripRemove.Image")));
            this.pagGroupToolStripRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pagGroupToolStripRemove.Name = "pagGroupToolStripRemove";
            this.pagGroupToolStripRemove.Size = new System.Drawing.Size(23, 22);
            this.pagGroupToolStripRemove.Text = "Remove Record";
            this.pagGroupToolStripRemove.Click += new System.EventHandler(this.pagGroupToolStripRemove_Click);
            // 
            // pagGroupToolStripSave
            // 
            this.pagGroupToolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pagGroupToolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("pagGroupToolStripSave.Image")));
            this.pagGroupToolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pagGroupToolStripSave.Name = "pagGroupToolStripSave";
            this.pagGroupToolStripSave.Size = new System.Drawing.Size(23, 22);
            this.pagGroupToolStripSave.Text = "Save Data";
            this.pagGroupToolStripSave.Click += new System.EventHandler(this.pagGroupToolStripSave_Click);
            // 
            // listBoxGroupList
            // 
            this.listBoxGroupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxGroupList.FormattingEnabled = true;
            this.listBoxGroupList.Location = new System.Drawing.Point(3, 28);
            this.listBoxGroupList.Name = "listBoxGroupList";
            this.listBoxGroupList.Size = new System.Drawing.Size(372, 442);
            this.listBoxGroupList.TabIndex = 1;
            this.listBoxGroupList.SelectedIndexChanged += new System.EventHandler(this.listBoxGroupList_SelectedIndexChanged);
            // 
            // checkedListBoxPagList
            // 
            this.checkedListBoxPagList.CheckOnClick = true;
            this.checkedListBoxPagList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxPagList.Enabled = false;
            this.checkedListBoxPagList.FormattingEnabled = true;
            this.checkedListBoxPagList.Location = new System.Drawing.Point(381, 28);
            this.checkedListBoxPagList.Name = "checkedListBoxPagList";
            this.checkedListBoxPagList.Size = new System.Drawing.Size(372, 442);
            this.checkedListBoxPagList.TabIndex = 2;
            this.checkedListBoxPagList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxPagList_ItemCheck);
            // 
            // tabStudentImport
            // 
            this.tabStudentImport.Controls.Add(this.tableLayoutPanelImportStudents);
            this.tabStudentImport.Location = new System.Drawing.Point(4, 22);
            this.tabStudentImport.Name = "tabStudentImport";
            this.tabStudentImport.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentImport.Size = new System.Drawing.Size(762, 479);
            this.tabStudentImport.TabIndex = 4;
            this.tabStudentImport.Text = "Import Students";
            this.tabStudentImport.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelImportStudents
            // 
            this.tableLayoutPanelImportStudents.ColumnCount = 1;
            this.tableLayoutPanelImportStudents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelImportStudents.Controls.Add(this.flowLayoutPanelImportStudents, 0, 0);
            this.tableLayoutPanelImportStudents.Controls.Add(this.dataGridViewStudentImport, 0, 1);
            this.tableLayoutPanelImportStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelImportStudents.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelImportStudents.Name = "tableLayoutPanelImportStudents";
            this.tableLayoutPanelImportStudents.RowCount = 2;
            this.tableLayoutPanelImportStudents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelImportStudents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelImportStudents.Size = new System.Drawing.Size(756, 473);
            this.tableLayoutPanelImportStudents.TabIndex = 1;
            // 
            // flowLayoutPanelImportStudents
            // 
            this.flowLayoutPanelImportStudents.Controls.Add(this.buttonImportCSV);
            this.flowLayoutPanelImportStudents.Controls.Add(this.buttonAddStudentRecord);
            this.flowLayoutPanelImportStudents.Controls.Add(this.labelImportStudents);
            this.flowLayoutPanelImportStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelImportStudents.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelImportStudents.Name = "flowLayoutPanelImportStudents";
            this.flowLayoutPanelImportStudents.Size = new System.Drawing.Size(750, 24);
            this.flowLayoutPanelImportStudents.TabIndex = 2;
            // 
            // buttonImportCSV
            // 
            this.buttonImportCSV.Location = new System.Drawing.Point(3, 3);
            this.buttonImportCSV.Name = "buttonImportCSV";
            this.buttonImportCSV.Size = new System.Drawing.Size(75, 21);
            this.buttonImportCSV.TabIndex = 1;
            this.buttonImportCSV.Text = "Import CSV";
            this.buttonImportCSV.UseVisualStyleBackColor = true;
            this.buttonImportCSV.Click += new System.EventHandler(this.buttonImportCSV_Click);
            // 
            // buttonAddStudentRecord
            // 
            this.buttonAddStudentRecord.Enabled = false;
            this.buttonAddStudentRecord.Location = new System.Drawing.Point(84, 3);
            this.buttonAddStudentRecord.Name = "buttonAddStudentRecord";
            this.buttonAddStudentRecord.Size = new System.Drawing.Size(113, 21);
            this.buttonAddStudentRecord.TabIndex = 2;
            this.buttonAddStudentRecord.Text = "Add Records to list";
            this.buttonAddStudentRecord.UseVisualStyleBackColor = true;
            this.buttonAddStudentRecord.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // labelImportStudents
            // 
            this.labelImportStudents.AutoSize = true;
            this.labelImportStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelImportStudents.Location = new System.Drawing.Point(203, 0);
            this.labelImportStudents.Name = "labelImportStudents";
            this.labelImportStudents.Size = new System.Drawing.Size(442, 27);
            this.labelImportStudents.TabIndex = 3;
            this.labelImportStudents.Text = "Columns must be in order (First Name, Last Name, Year, Class). Extra columns will" +
    " be ignored";
            this.labelImportStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewStudentImport
            // 
            this.dataGridViewStudentImport.AllowUserToOrderColumns = true;
            this.dataGridViewStudentImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudentImport.Location = new System.Drawing.Point(3, 33);
            this.dataGridViewStudentImport.Name = "dataGridViewStudentImport";
            this.dataGridViewStudentImport.Size = new System.Drawing.Size(750, 437);
            this.dataGridViewStudentImport.TabIndex = 0;
            this.dataGridViewStudentImport.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewStudentImport_CellEndEdit);
            // 
            // tabStudentManagement
            // 
            this.tabStudentManagement.Controls.Add(this.tableLayoutPanelStudentManagement);
            this.tabStudentManagement.Location = new System.Drawing.Point(4, 22);
            this.tabStudentManagement.Name = "tabStudentManagement";
            this.tabStudentManagement.Size = new System.Drawing.Size(762, 479);
            this.tabStudentManagement.TabIndex = 6;
            this.tabStudentManagement.Text = "Student Management";
            this.tabStudentManagement.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelStudentManagement
            // 
            this.tableLayoutPanelStudentManagement.ColumnCount = 2;
            this.tableLayoutPanelStudentManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanelStudentManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelStudentManagement.Controls.Add(this.tableLayoutPanelStudentInfo, 1, 0);
            this.tableLayoutPanelStudentManagement.Controls.Add(this.tableLayoutPanelStudentMassMove, 1, 2);
            this.tableLayoutPanelStudentManagement.Controls.Add(this.listBoxStudentManagementList, 0, 1);
            this.tableLayoutPanelStudentManagement.Controls.Add(this.textBoxStudentFilter, 0, 0);
            this.tableLayoutPanelStudentManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelStudentManagement.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelStudentManagement.Name = "tableLayoutPanelStudentManagement";
            this.tableLayoutPanelStudentManagement.RowCount = 3;
            this.tableLayoutPanelStudentManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelStudentManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelStudentManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelStudentManagement.Size = new System.Drawing.Size(762, 479);
            this.tableLayoutPanelStudentManagement.TabIndex = 0;
            // 
            // tableLayoutPanelStudentInfo
            // 
            this.tableLayoutPanelStudentInfo.ColumnCount = 3;
            this.tableLayoutPanelStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanelStudentInfo.Controls.Add(this.buttonStudentManagementDeleteStudent, 2, 1);
            this.tableLayoutPanelStudentInfo.Controls.Add(this.textBoxStudentLName, 1, 1);
            this.tableLayoutPanelStudentInfo.Controls.Add(this.textBoxStudentFName, 1, 0);
            this.tableLayoutPanelStudentInfo.Controls.Add(this.labelStudentManagementFName, 0, 0);
            this.tableLayoutPanelStudentInfo.Controls.Add(this.labelStudentManagementLName, 0, 1);
            this.tableLayoutPanelStudentInfo.Controls.Add(this.labelStudentManagementYear, 0, 2);
            this.tableLayoutPanelStudentInfo.Controls.Add(this.labelStudentManagementClass, 0, 3);
            this.tableLayoutPanelStudentInfo.Controls.Add(this.textBoxStudentYear, 1, 2);
            this.tableLayoutPanelStudentInfo.Controls.Add(this.textBoxStudentClass, 1, 3);
            this.tableLayoutPanelStudentInfo.Controls.Add(this.buttonStudentManagementSaveChanges, 2, 3);
            this.tableLayoutPanelStudentInfo.Controls.Add(this.buttonStudentManagementAddStudent, 2, 0);
            this.tableLayoutPanelStudentInfo.Controls.Add(this.buttonClearAllChanges, 2, 2);
            this.tableLayoutPanelStudentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelStudentInfo.Location = new System.Drawing.Point(183, 3);
            this.tableLayoutPanelStudentInfo.Name = "tableLayoutPanelStudentInfo";
            this.tableLayoutPanelStudentInfo.RowCount = 4;
            this.tableLayoutPanelStudentManagement.SetRowSpan(this.tableLayoutPanelStudentInfo, 2);
            this.tableLayoutPanelStudentInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudentInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudentInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudentInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudentInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelStudentInfo.Size = new System.Drawing.Size(576, 119);
            this.tableLayoutPanelStudentInfo.TabIndex = 2;
            // 
            // buttonStudentManagementDeleteStudent
            // 
            this.buttonStudentManagementDeleteStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStudentManagementDeleteStudent.Location = new System.Drawing.Point(439, 32);
            this.buttonStudentManagementDeleteStudent.Name = "buttonStudentManagementDeleteStudent";
            this.buttonStudentManagementDeleteStudent.Size = new System.Drawing.Size(134, 23);
            this.buttonStudentManagementDeleteStudent.TabIndex = 6;
            this.buttonStudentManagementDeleteStudent.Text = "Delete Student";
            this.buttonStudentManagementDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonStudentManagementDeleteStudent.Click += new System.EventHandler(this.buttonStudentManagementDeleteStudent_Click);
            // 
            // textBoxStudentLName
            // 
            this.textBoxStudentLName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStudentLName.Location = new System.Drawing.Point(83, 33);
            this.textBoxStudentLName.Name = "textBoxStudentLName";
            this.textBoxStudentLName.Size = new System.Drawing.Size(350, 20);
            this.textBoxStudentLName.TabIndex = 2;
            this.textBoxStudentLName.TextChanged += new System.EventHandler(this.textBoxStudentLName_TextChanged);
            // 
            // textBoxStudentFName
            // 
            this.textBoxStudentFName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStudentFName.Location = new System.Drawing.Point(83, 4);
            this.textBoxStudentFName.Name = "textBoxStudentFName";
            this.textBoxStudentFName.Size = new System.Drawing.Size(350, 20);
            this.textBoxStudentFName.TabIndex = 1;
            this.textBoxStudentFName.TextChanged += new System.EventHandler(this.textBoxStudentFName_TextChanged);
            // 
            // labelStudentManagementFName
            // 
            this.labelStudentManagementFName.Location = new System.Drawing.Point(3, 0);
            this.labelStudentManagementFName.Name = "labelStudentManagementFName";
            this.labelStudentManagementFName.Size = new System.Drawing.Size(74, 28);
            this.labelStudentManagementFName.TabIndex = 0;
            this.labelStudentManagementFName.Text = "First Name: ";
            this.labelStudentManagementFName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelStudentManagementLName
            // 
            this.labelStudentManagementLName.Location = new System.Drawing.Point(3, 29);
            this.labelStudentManagementLName.Name = "labelStudentManagementLName";
            this.labelStudentManagementLName.Size = new System.Drawing.Size(74, 28);
            this.labelStudentManagementLName.TabIndex = 2;
            this.labelStudentManagementLName.Text = "Last Name: ";
            this.labelStudentManagementLName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelStudentManagementYear
            // 
            this.labelStudentManagementYear.Location = new System.Drawing.Point(3, 58);
            this.labelStudentManagementYear.Name = "labelStudentManagementYear";
            this.labelStudentManagementYear.Size = new System.Drawing.Size(74, 28);
            this.labelStudentManagementYear.TabIndex = 3;
            this.labelStudentManagementYear.Text = "Year: ";
            this.labelStudentManagementYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelStudentManagementClass
            // 
            this.labelStudentManagementClass.Location = new System.Drawing.Point(3, 87);
            this.labelStudentManagementClass.Name = "labelStudentManagementClass";
            this.labelStudentManagementClass.Size = new System.Drawing.Size(74, 28);
            this.labelStudentManagementClass.TabIndex = 4;
            this.labelStudentManagementClass.Text = "Class: ";
            this.labelStudentManagementClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxStudentYear
            // 
            this.textBoxStudentYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStudentYear.Location = new System.Drawing.Point(83, 62);
            this.textBoxStudentYear.Name = "textBoxStudentYear";
            this.textBoxStudentYear.Size = new System.Drawing.Size(350, 20);
            this.textBoxStudentYear.TabIndex = 3;
            this.textBoxStudentYear.TextChanged += new System.EventHandler(this.textBoxStudentYear_TextChanged);
            // 
            // textBoxStudentClass
            // 
            this.textBoxStudentClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStudentClass.Location = new System.Drawing.Point(83, 93);
            this.textBoxStudentClass.Name = "textBoxStudentClass";
            this.textBoxStudentClass.Size = new System.Drawing.Size(350, 20);
            this.textBoxStudentClass.TabIndex = 4;
            this.textBoxStudentClass.TextChanged += new System.EventHandler(this.textBoxStudentClass_TextChanged);
            // 
            // buttonStudentManagementSaveChanges
            // 
            this.buttonStudentManagementSaveChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStudentManagementSaveChanges.Location = new System.Drawing.Point(439, 90);
            this.buttonStudentManagementSaveChanges.Name = "buttonStudentManagementSaveChanges";
            this.buttonStudentManagementSaveChanges.Size = new System.Drawing.Size(134, 26);
            this.buttonStudentManagementSaveChanges.TabIndex = 7;
            this.buttonStudentManagementSaveChanges.Text = "Save Changes";
            this.buttonStudentManagementSaveChanges.UseVisualStyleBackColor = true;
            this.buttonStudentManagementSaveChanges.Click += new System.EventHandler(this.buttonStudentManagementSaveChanges_Click);
            // 
            // buttonStudentManagementAddStudent
            // 
            this.buttonStudentManagementAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStudentManagementAddStudent.Location = new System.Drawing.Point(439, 3);
            this.buttonStudentManagementAddStudent.Name = "buttonStudentManagementAddStudent";
            this.buttonStudentManagementAddStudent.Size = new System.Drawing.Size(134, 23);
            this.buttonStudentManagementAddStudent.TabIndex = 5;
            this.buttonStudentManagementAddStudent.Text = "Add Student";
            this.buttonStudentManagementAddStudent.UseVisualStyleBackColor = true;
            this.buttonStudentManagementAddStudent.Click += new System.EventHandler(this.buttonStudentManagementAddStudent_Click);
            // 
            // buttonClearAllChanges
            // 
            this.buttonClearAllChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearAllChanges.Location = new System.Drawing.Point(439, 61);
            this.buttonClearAllChanges.Name = "buttonClearAllChanges";
            this.buttonClearAllChanges.Size = new System.Drawing.Size(134, 23);
            this.buttonClearAllChanges.TabIndex = 8;
            this.buttonClearAllChanges.Text = "Reset Changes";
            this.buttonClearAllChanges.UseVisualStyleBackColor = true;
            this.buttonClearAllChanges.Click += new System.EventHandler(this.buttonClearAllChanges_Click);
            // 
            // tableLayoutPanelStudentMassMove
            // 
            this.tableLayoutPanelStudentMassMove.ColumnCount = 6;
            this.tableLayoutPanelStudentMassMove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelStudentMassMove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudentMassMove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudentMassMove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanelStudentMassMove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudentMassMove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudentMassMove.Controls.Add(this.labelStudentManagement1, 0, 1);
            this.tableLayoutPanelStudentMassMove.Controls.Add(this.labelStudentManagement2, 3, 1);
            this.tableLayoutPanelStudentMassMove.Controls.Add(this.comboBoxInputType, 1, 1);
            this.tableLayoutPanelStudentMassMove.Controls.Add(this.comboBoxInputName, 2, 1);
            this.tableLayoutPanelStudentMassMove.Controls.Add(this.comboBoxOutputName, 4, 1);
            this.tableLayoutPanelStudentMassMove.Controls.Add(this.buttonMoveStudents, 5, 1);
            this.tableLayoutPanelStudentMassMove.Controls.Add(this.labelNewItem, 4, 2);
            this.tableLayoutPanelStudentMassMove.Controls.Add(this.labelUnsavedChanges, 2, 0);
            this.tableLayoutPanelStudentMassMove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelStudentMassMove.Location = new System.Drawing.Point(183, 128);
            this.tableLayoutPanelStudentMassMove.Name = "tableLayoutPanelStudentMassMove";
            this.tableLayoutPanelStudentMassMove.RowCount = 3;
            this.tableLayoutPanelStudentMassMove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelStudentMassMove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelStudentMassMove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelStudentMassMove.Size = new System.Drawing.Size(576, 348);
            this.tableLayoutPanelStudentMassMove.TabIndex = 3;
            // 
            // labelStudentManagement1
            // 
            this.labelStudentManagement1.AutoSize = true;
            this.labelStudentManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStudentManagement1.Location = new System.Drawing.Point(3, 154);
            this.labelStudentManagement1.Name = "labelStudentManagement1";
            this.labelStudentManagement1.Size = new System.Drawing.Size(114, 40);
            this.labelStudentManagement1.TabIndex = 0;
            this.labelStudentManagement1.Text = "Move all students from";
            this.labelStudentManagement1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStudentManagement2
            // 
            this.labelStudentManagement2.AutoSize = true;
            this.labelStudentManagement2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStudentManagement2.Location = new System.Drawing.Point(339, 154);
            this.labelStudentManagement2.Name = "labelStudentManagement2";
            this.labelStudentManagement2.Size = new System.Drawing.Size(17, 40);
            this.labelStudentManagement2.TabIndex = 1;
            this.labelStudentManagement2.Text = "to";
            this.labelStudentManagement2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxInputType
            // 
            this.comboBoxInputType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxInputType.AutoCompleteCustomSource.AddRange(new string[] {
            "Year",
            "Class"});
            this.comboBoxInputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInputType.FormattingEnabled = true;
            this.comboBoxInputType.Items.AddRange(new object[] {
            "Year",
            "Class"});
            this.comboBoxInputType.Location = new System.Drawing.Point(123, 163);
            this.comboBoxInputType.Name = "comboBoxInputType";
            this.comboBoxInputType.Size = new System.Drawing.Size(102, 21);
            this.comboBoxInputType.TabIndex = 2;
            this.comboBoxInputType.SelectedIndexChanged += new System.EventHandler(this.comboBoxInputType_SelectedIndexChanged);
            // 
            // comboBoxInputName
            // 
            this.comboBoxInputName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxInputName.AutoCompleteCustomSource.AddRange(new string[] {
            "Year",
            "Class"});
            this.comboBoxInputName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInputName.FormattingEnabled = true;
            this.comboBoxInputName.Location = new System.Drawing.Point(231, 163);
            this.comboBoxInputName.Name = "comboBoxInputName";
            this.comboBoxInputName.Size = new System.Drawing.Size(102, 21);
            this.comboBoxInputName.TabIndex = 3;
            // 
            // comboBoxOutputName
            // 
            this.comboBoxOutputName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOutputName.AutoCompleteCustomSource.AddRange(new string[] {
            "Year",
            "Class"});
            this.comboBoxOutputName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutputName.FormattingEnabled = true;
            this.comboBoxOutputName.Location = new System.Drawing.Point(362, 163);
            this.comboBoxOutputName.Name = "comboBoxOutputName";
            this.comboBoxOutputName.Size = new System.Drawing.Size(102, 21);
            this.comboBoxOutputName.TabIndex = 4;
            this.comboBoxOutputName.SelectedValueChanged += new System.EventHandler(this.comboBoxOutputName_SelectedIndexChanged);
            // 
            // buttonMoveStudents
            // 
            this.buttonMoveStudents.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMoveStudents.Location = new System.Drawing.Point(484, 157);
            this.buttonMoveStudents.Name = "buttonMoveStudents";
            this.buttonMoveStudents.Size = new System.Drawing.Size(89, 34);
            this.buttonMoveStudents.TabIndex = 5;
            this.buttonMoveStudents.Text = "Move Students";
            this.buttonMoveStudents.UseVisualStyleBackColor = true;
            this.buttonMoveStudents.Click += new System.EventHandler(this.buttonMoveStudents_Click);
            // 
            // labelNewItem
            // 
            this.labelNewItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNewItem.AutoSize = true;
            this.labelNewItem.Location = new System.Drawing.Point(413, 194);
            this.labelNewItem.Name = "labelNewItem";
            this.labelNewItem.Size = new System.Drawing.Size(0, 13);
            this.labelNewItem.TabIndex = 6;
            this.labelNewItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelUnsavedChanges
            // 
            this.labelUnsavedChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUnsavedChanges.AutoSize = true;
            this.tableLayoutPanelStudentMassMove.SetColumnSpan(this.labelUnsavedChanges, 4);
            this.labelUnsavedChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnsavedChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelUnsavedChanges.Location = new System.Drawing.Point(309, 0);
            this.labelUnsavedChanges.Name = "labelUnsavedChanges";
            this.labelUnsavedChanges.Size = new System.Drawing.Size(264, 13);
            this.labelUnsavedChanges.TabIndex = 7;
            this.labelUnsavedChanges.Text = "WARNING: YOU HAVE UNSAVED CHANGES";
            this.labelUnsavedChanges.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelUnsavedChanges.Visible = false;
            // 
            // listBoxStudentManagementList
            // 
            this.listBoxStudentManagementList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxStudentManagementList.FormattingEnabled = true;
            this.listBoxStudentManagementList.Location = new System.Drawing.Point(3, 28);
            this.listBoxStudentManagementList.Name = "listBoxStudentManagementList";
            this.tableLayoutPanelStudentManagement.SetRowSpan(this.listBoxStudentManagementList, 2);
            this.listBoxStudentManagementList.Size = new System.Drawing.Size(174, 448);
            this.listBoxStudentManagementList.TabIndex = 0;
            this.listBoxStudentManagementList.SelectedIndexChanged += new System.EventHandler(this.listBoxStudentManagementList_SelectedIndexChanged);
            // 
            // textBoxStudentFilter
            // 
            this.textBoxStudentFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStudentFilter.Location = new System.Drawing.Point(3, 3);
            this.textBoxStudentFilter.Name = "textBoxStudentFilter";
            this.textBoxStudentFilter.Size = new System.Drawing.Size(174, 20);
            this.textBoxStudentFilter.TabIndex = 4;
            this.textBoxStudentFilter.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.labelImportData);
            this.tabGeneral.Controls.Add(this.buttonImportData);
            this.tabGeneral.Controls.Add(this.labelExportData);
            this.tabGeneral.Controls.Add(this.buttonExportData);
            this.tabGeneral.Controls.Add(this.labelDefaultPresets);
            this.tabGeneral.Controls.Add(this.buttonAddPresets);
            this.tabGeneral.Controls.Add(this.labelAdminDeleteData);
            this.tabGeneral.Controls.Add(this.labelAdminProgramDirectory);
            this.tabGeneral.Controls.Add(this.labelAdminStudentID);
            this.tabGeneral.Controls.Add(this.buttonResetToDefault);
            this.tabGeneral.Controls.Add(this.checkBoxShowStudentID);
            this.tabGeneral.Controls.Add(this.buttonGetDirectory);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(762, 479);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "Other Settings";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // labelImportData
            // 
            this.labelImportData.AutoSize = true;
            this.labelImportData.Location = new System.Drawing.Point(146, 121);
            this.labelImportData.Name = "labelImportData";
            this.labelImportData.Size = new System.Drawing.Size(413, 13);
            this.labelImportData.TabIndex = 14;
            this.labelImportData.Text = "Imports data from a .PAG file that has been obtained from another copy of this pr" +
    "ogram";
            // 
            // buttonImportData
            // 
            this.buttonImportData.Location = new System.Drawing.Point(8, 116);
            this.buttonImportData.Name = "buttonImportData";
            this.buttonImportData.Size = new System.Drawing.Size(125, 23);
            this.buttonImportData.TabIndex = 13;
            this.buttonImportData.Text = "Import Data";
            this.buttonImportData.UseVisualStyleBackColor = true;
            this.buttonImportData.Click += new System.EventHandler(this.ButtonImportData_Click);
            // 
            // labelExportData
            // 
            this.labelExportData.AutoSize = true;
            this.labelExportData.Location = new System.Drawing.Point(146, 92);
            this.labelExportData.Name = "labelExportData";
            this.labelExportData.Size = new System.Drawing.Size(347, 13);
            this.labelExportData.TabIndex = 12;
            this.labelExportData.Text = "Exports data into a .PAG file so that it can be imported or sent elsewhere";
            // 
            // buttonExportData
            // 
            this.buttonExportData.Location = new System.Drawing.Point(7, 87);
            this.buttonExportData.Name = "buttonExportData";
            this.buttonExportData.Size = new System.Drawing.Size(125, 23);
            this.buttonExportData.TabIndex = 11;
            this.buttonExportData.Text = "Export Data";
            this.buttonExportData.UseVisualStyleBackColor = true;
            this.buttonExportData.Click += new System.EventHandler(this.ButtonExportData_Click);
            // 
            // labelDefaultPresets
            // 
            this.labelDefaultPresets.AutoSize = true;
            this.labelDefaultPresets.Location = new System.Drawing.Point(146, 63);
            this.labelDefaultPresets.Name = "labelDefaultPresets";
            this.labelDefaultPresets.Size = new System.Drawing.Size(614, 13);
            this.labelDefaultPresets.TabIndex = 10;
            this.labelDefaultPresets.Text = "Adds presets for OCR Biology (H420), Chemistry (H432) and Physics (H556) PAG\'s in" +
    " line with Version 1 of the OCR PAG Tracker";
            // 
            // buttonAddPresets
            // 
            this.buttonAddPresets.Location = new System.Drawing.Point(6, 58);
            this.buttonAddPresets.Name = "buttonAddPresets";
            this.buttonAddPresets.Size = new System.Drawing.Size(126, 23);
            this.buttonAddPresets.TabIndex = 9;
            this.buttonAddPresets.Text = "Add Default Presets";
            this.buttonAddPresets.UseVisualStyleBackColor = true;
            this.buttonAddPresets.Click += new System.EventHandler(this.ButtonAddPresets_Click);
            // 
            // labelAdminDeleteData
            // 
            this.labelAdminDeleteData.AutoSize = true;
            this.labelAdminDeleteData.Location = new System.Drawing.Point(146, 150);
            this.labelAdminDeleteData.Name = "labelAdminDeleteData";
            this.labelAdminDeleteData.Size = new System.Drawing.Size(237, 13);
            this.labelAdminDeleteData.TabIndex = 8;
            this.labelAdminDeleteData.Text = "Deletes all data (Excluding backups and presets)";
            // 
            // labelAdminProgramDirectory
            // 
            this.labelAdminProgramDirectory.AutoSize = true;
            this.labelAdminProgramDirectory.Location = new System.Drawing.Point(146, 34);
            this.labelAdminProgramDirectory.Name = "labelAdminProgramDirectory";
            this.labelAdminProgramDirectory.Size = new System.Drawing.Size(356, 13);
            this.labelAdminProgramDirectory.TabIndex = 7;
            this.labelAdminProgramDirectory.Text = "Shows the directory where the program is stored, then opens that directory";
            // 
            // labelAdminStudentID
            // 
            this.labelAdminStudentID.AutoSize = true;
            this.labelAdminStudentID.Location = new System.Drawing.Point(146, 7);
            this.labelAdminStudentID.Name = "labelAdminStudentID";
            this.labelAdminStudentID.Size = new System.Drawing.Size(383, 13);
            this.labelAdminStudentID.TabIndex = 6;
            this.labelAdminStudentID.Text = "Shows the column with student ID in PAG view, Skills view, and Student Report";
            // 
            // buttonResetToDefault
            // 
            this.buttonResetToDefault.BackColor = System.Drawing.Color.Red;
            this.buttonResetToDefault.Location = new System.Drawing.Point(6, 145);
            this.buttonResetToDefault.Name = "buttonResetToDefault";
            this.buttonResetToDefault.Size = new System.Drawing.Size(126, 23);
            this.buttonResetToDefault.TabIndex = 5;
            this.buttonResetToDefault.Text = "Delete All Data";
            this.buttonResetToDefault.UseVisualStyleBackColor = false;
            this.buttonResetToDefault.Click += new System.EventHandler(this.buttonResetToDefault_Click);
            // 
            // checkBoxShowStudentID
            // 
            this.checkBoxShowStudentID.AutoSize = true;
            this.checkBoxShowStudentID.Location = new System.Drawing.Point(6, 6);
            this.checkBoxShowStudentID.Name = "checkBoxShowStudentID";
            this.checkBoxShowStudentID.Size = new System.Drawing.Size(107, 17);
            this.checkBoxShowStudentID.TabIndex = 4;
            this.checkBoxShowStudentID.Text = "Show Student ID";
            this.checkBoxShowStudentID.UseVisualStyleBackColor = true;
            this.checkBoxShowStudentID.CheckedChanged += new System.EventHandler(this.checkBoxShowStudentID_CheckedChanged);
            // 
            // buttonGetDirectory
            // 
            this.buttonGetDirectory.Location = new System.Drawing.Point(6, 29);
            this.buttonGetDirectory.Name = "buttonGetDirectory";
            this.buttonGetDirectory.Size = new System.Drawing.Size(126, 23);
            this.buttonGetDirectory.TabIndex = 1;
            this.buttonGetDirectory.Text = "Get Program Directory";
            this.buttonGetDirectory.UseVisualStyleBackColor = true;
            this.buttonGetDirectory.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupRestoreToolStripMenuItem,
            this.PAGPresetToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(784, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // backupRestoreToolStripMenuItem
            // 
            this.backupRestoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupDataToolStripMenuItem,
            this.restoreDataToolStripMenuItem,
            this.deleteBackupToolStripMenuItem});
            this.backupRestoreToolStripMenuItem.Name = "backupRestoreToolStripMenuItem";
            this.backupRestoreToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.backupRestoreToolStripMenuItem.Text = "Backup and Restore";
            this.backupRestoreToolStripMenuItem.DropDownOpened += new System.EventHandler(this.BackupRestoreToolStripMenuItem_DropDownOpened);
            // 
            // backupDataToolStripMenuItem
            // 
            this.backupDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxBackupName,
            this.backupWithNameToolStripMenuItem});
            this.backupDataToolStripMenuItem.Name = "backupDataToolStripMenuItem";
            this.backupDataToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.backupDataToolStripMenuItem.Text = "Backup Data";
            this.backupDataToolStripMenuItem.DropDownOpened += new System.EventHandler(this.backupDataToolStripMenuItem_DropDownOpened);
            // 
            // toolStripTextBoxBackupName
            // 
            this.toolStripTextBoxBackupName.Name = "toolStripTextBoxBackupName";
            this.toolStripTextBoxBackupName.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxBackupName.Enter += new System.EventHandler(this.backupWithNameToolStripMenuItem_Click);
            this.toolStripTextBoxBackupName.TextChanged += new System.EventHandler(this.toolStripTextBoxBackupName_TextChanged);
            // 
            // backupWithNameToolStripMenuItem
            // 
            this.backupWithNameToolStripMenuItem.Name = "backupWithNameToolStripMenuItem";
            this.backupWithNameToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.backupWithNameToolStripMenuItem.Text = "Backup With Name: ";
            this.backupWithNameToolStripMenuItem.Click += new System.EventHandler(this.backupWithNameToolStripMenuItem_Click);
            // 
            // restoreDataToolStripMenuItem
            // 
            this.restoreDataToolStripMenuItem.Name = "restoreDataToolStripMenuItem";
            this.restoreDataToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.restoreDataToolStripMenuItem.Text = "Restore Data";
            this.restoreDataToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.restoreDataToolStripMenuItem_DropDownItemClicked);
            // 
            // deleteBackupToolStripMenuItem
            // 
            this.deleteBackupToolStripMenuItem.Name = "deleteBackupToolStripMenuItem";
            this.deleteBackupToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.deleteBackupToolStripMenuItem.Text = "Delete Backup";
            this.deleteBackupToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.deleteBackupToolStripMenuItem_DropDownItemClicked);
            // 
            // PAGPresetToolStripMenuItem
            // 
            this.PAGPresetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPAGPresetToolStripMenuItem,
            this.loadPAGPresetToolStripMenuItem,
            this.deletePAGPresetToolStripMenuItem});
            this.PAGPresetToolStripMenuItem.Name = "PAGPresetToolStripMenuItem";
            this.PAGPresetToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.PAGPresetToolStripMenuItem.Text = "PAG Presets";
            this.PAGPresetToolStripMenuItem.DropDownOpened += new System.EventHandler(this.PAGPresetToolStripMenuItem_DropDownOpened);
            // 
            // createPAGPresetToolStripMenuItem
            // 
            this.createPAGPresetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxCreatePreset,
            this.createPresetWithNameToolStripMenuItem});
            this.createPAGPresetToolStripMenuItem.Name = "createPAGPresetToolStripMenuItem";
            this.createPAGPresetToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.createPAGPresetToolStripMenuItem.Text = "Create PAG Preset";
            this.createPAGPresetToolStripMenuItem.DropDownOpened += new System.EventHandler(this.createPAGPresetToolStripMenuItem_DropDownOpened);
            // 
            // toolStripTextBoxCreatePreset
            // 
            this.toolStripTextBoxCreatePreset.Name = "toolStripTextBoxCreatePreset";
            this.toolStripTextBoxCreatePreset.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxCreatePreset.TextChanged += new System.EventHandler(this.toolStripTextBoxCreatePreset_TextChanged);
            // 
            // createPresetWithNameToolStripMenuItem
            // 
            this.createPresetWithNameToolStripMenuItem.Name = "createPresetWithNameToolStripMenuItem";
            this.createPresetWithNameToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.createPresetWithNameToolStripMenuItem.Text = "Create Preset With Name: ";
            this.createPresetWithNameToolStripMenuItem.Click += new System.EventHandler(this.createPresetWithNameToolStripMenuItem_Click);
            // 
            // loadPAGPresetToolStripMenuItem
            // 
            this.loadPAGPresetToolStripMenuItem.Name = "loadPAGPresetToolStripMenuItem";
            this.loadPAGPresetToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.loadPAGPresetToolStripMenuItem.Text = "Load PAG Preset";
            this.loadPAGPresetToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.loadPAGPresetToolStripMenuItem_DropDownItemClicked);
            // 
            // deletePAGPresetToolStripMenuItem
            // 
            this.deletePAGPresetToolStripMenuItem.Name = "deletePAGPresetToolStripMenuItem";
            this.deletePAGPresetToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deletePAGPresetToolStripMenuItem.Text = "Delete PAG Preset";
            this.deletePAGPresetToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.deletePAGPresetToolStripMenuItem_DropDownItemClicked);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hidePagViewColumnsWithoutPAGDataToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // hidePagViewColumnsWithoutPAGDataToolStripMenuItem
            // 
            this.hidePagViewColumnsWithoutPAGDataToolStripMenuItem.CheckOnClick = true;
            this.hidePagViewColumnsWithoutPAGDataToolStripMenuItem.Name = "hidePagViewColumnsWithoutPAGDataToolStripMenuItem";
            this.hidePagViewColumnsWithoutPAGDataToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.hidePagViewColumnsWithoutPAGDataToolStripMenuItem.Text = "Hide Pag View Columns without PAG data";
            this.hidePagViewColumnsWithoutPAGDataToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.hidePagViewColumnsWithoutPAGDataToolStripMenuItem_CheckStateChanged);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.adminToolStripMenuItem.Text = "Enable Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openManualToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openManualToolStripMenuItem
            // 
            this.openManualToolStripMenuItem.Name = "openManualToolStripMenuItem";
            this.openManualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openManualToolStripMenuItem.Text = "Open Manual";
            this.openManualToolStripMenuItem.Click += new System.EventHandler(this.OpenManualToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialogImportCSV
            // 
            this.openFileDialogImportCSV.Filter = "CSV files (*.csv)|*.csv";
            this.openFileDialogImportCSV.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogImportCSV_FileOk);
            this.openFileDialogImportCSV.HelpRequest += new System.EventHandler(this.openFileDialogImportCSV_HelpRequest);
            // 
            // heightDataGridViewTextBoxColumn1
            // 
            this.heightDataGridViewTextBoxColumn1.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn1.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn1.Name = "heightDataGridViewTextBoxColumn1";
            // 
            // sizeTypeDataGridViewTextBoxColumn1
            // 
            this.sizeTypeDataGridViewTextBoxColumn1.DataPropertyName = "SizeType";
            this.sizeTypeDataGridViewTextBoxColumn1.HeaderText = "SizeType";
            this.sizeTypeDataGridViewTextBoxColumn1.Name = "sizeTypeDataGridViewTextBoxColumn1";
            // 
            // saveFileDialogExportReport
            // 
            this.saveFileDialogExportReport.Filter = "Excel Spreadsheet (*.xlsx)|*.xlsx";
            this.saveFileDialogExportReport.Title = "Export Report";
            this.saveFileDialogExportReport.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogExportReport_FileOk);
            // 
            // saveFileDialogExportData
            // 
            this.saveFileDialogExportData.Filter = "PAG Manager File (*.PAG)|*.PAG";
            this.saveFileDialogExportData.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialogExportData_FileOk);
            // 
            // openFileDialogImportData
            // 
            this.openFileDialogImportData.Filter = "PAG Manager File (*.PAG)|*.PAG";
            this.openFileDialogImportData.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialogImportData_FileOk);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMain";
            this.Text = "PAG Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabAwardPag.ResumeLayout(false);
            this.tableLayoutPanelAwardPag.ResumeLayout(false);
            this.groupBoxAwardPag.ResumeLayout(false);
            this.groupBoxAwardPag.PerformLayout();
            this.tabLookup.ResumeLayout(false);
            this.tableLayoutPanelLookup.ResumeLayout(false);
            this.groupBoxLookupSearch.ResumeLayout(false);
            this.groupBoxLookupSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentLookup)).EndInit();
            this.tabPagDates.ResumeLayout(false);
            this.tableLayoutPanelPagView.ResumeLayout(false);
            this.flowLayoutPanelPAGSearch.ResumeLayout(false);
            this.flowLayoutPanelPAGSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPag)).EndInit();
            this.tabSkills.ResumeLayout(false);
            this.tableLayoutPanelSkillView.ResumeLayout(false);
            this.flowLayoutPanelSkillSearch.ResumeLayout(false);
            this.flowLayoutPanelSkillSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkills)).EndInit();
            this.tabReport.ResumeLayout(false);
            this.tableLayoutPanelStudentReport.ResumeLayout(false);
            this.tableLayoutPanelStudentReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentReport)).EndInit();
            this.flowLayoutPanelStudentReportSettings.ResumeLayout(false);
            this.tabActivitySelection.ResumeLayout(false);
            this.tableLayoutPanelActivitySelection.ResumeLayout(false);
            this.tableLayoutPanelActivitySelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivitySelectionSkills)).EndInit();
            this.tableLayoutPanelActivitySelectionToolbar.ResumeLayout(false);
            this.tableLayoutPanelActivitySelectionToolbar.PerformLayout();
            this.tabContentSelection.ResumeLayout(false);
            this.tableLayoutPanelContentSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContentSelectionPag)).EndInit();
            this.tableLayoutContentSelectionSkill.ResumeLayout(false);
            this.tableLayoutContentSelectionSkill.PerformLayout();
            this.tableLayoutPanelContentSelectionActivitySelection.ResumeLayout(false);
            this.tableLayoutPanelContentSelectionActivitySelection.PerformLayout();
            this.tabAdmin.ResumeLayout(false);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabSkillPagList.ResumeLayout(false);
            this.tableLayoutPanelPagSkillList.ResumeLayout(false);
            this.tableLayoutPanelPagSkillList.PerformLayout();
            this.toolStripSkillList.ResumeLayout(false);
            this.toolStripSkillList.PerformLayout();
            this.toolStripPagList.ResumeLayout(false);
            this.toolStripPagList.PerformLayout();
            this.tabPagSkillRelation.ResumeLayout(false);
            this.tableLayoutPanelPagSkillRelation.ResumeLayout(false);
            this.tabSkillRequirements.ResumeLayout(false);
            this.tableLayoutPanelSkillRequirement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkillRequirement)).EndInit();
            this.tabGroup.ResumeLayout(false);
            this.tableLayoutPanelPagGroup.ResumeLayout(false);
            this.tableLayoutPanelPagGroup.PerformLayout();
            this.pagGroupToolStrip.ResumeLayout(false);
            this.pagGroupToolStrip.PerformLayout();
            this.tabStudentImport.ResumeLayout(false);
            this.tableLayoutPanelImportStudents.ResumeLayout(false);
            this.flowLayoutPanelImportStudents.ResumeLayout(false);
            this.flowLayoutPanelImportStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentImport)).EndInit();
            this.tabStudentManagement.ResumeLayout(false);
            this.tableLayoutPanelStudentManagement.ResumeLayout(false);
            this.tableLayoutPanelStudentManagement.PerformLayout();
            this.tableLayoutPanelStudentInfo.ResumeLayout(false);
            this.tableLayoutPanelStudentInfo.PerformLayout();
            this.tableLayoutPanelStudentMassMove.ResumeLayout(false);
            this.tableLayoutPanelStudentMassMove.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabSkills;
        private System.Windows.Forms.TabPage tabAdmin;
        public System.Windows.Forms.DataGridView dataGridViewSkills;
        private System.Windows.Forms.Button buttonGetDirectory;
        private System.Windows.Forms.TabPage tabPagDates;
        public System.Windows.Forms.DataGridView dataGridViewPag;
        private System.Windows.Forms.TabPage tabLookup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLookup;
        private System.Windows.Forms.GroupBox groupBoxLookupSearch;
        private System.Windows.Forms.CheckBox checkBoxArchives;
        private System.Windows.Forms.TextBox textBoxLookupName;
        private System.Windows.Forms.Label labelLookupName;
        private System.Windows.Forms.ListBox listBoxStudentNames;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabSkillPagList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPagSkillList;
        private System.Windows.Forms.TabPage tabPagSkillRelation;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripPagList;
        private System.Windows.Forms.ToolStripTextBox pagListToolStripTextBox;
        private System.Windows.Forms.ToolStripButton pagListToolStripButtonAddRecord;
        private System.Windows.Forms.ToolStripButton pagListToolStripButtonRemovePag;
        private System.Windows.Forms.ToolStripSeparator pagListToolStripSeparator;
        private System.Windows.Forms.ToolStripLabel pagListToolStripLabel;
        private System.Windows.Forms.ListBox listBoxPagList;
        private System.Windows.Forms.ToolStrip toolStripSkillList;
        private System.Windows.Forms.ToolStripLabel skillListToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox skillListToolStripTextBox;
        private System.Windows.Forms.ToolStripSeparator skillListToolStripSeparator;
        private System.Windows.Forms.ToolStripButton skillListToolStripButtonAddRecord;
        private System.Windows.Forms.ToolStripButton skillListToolStripButtonRemovePag;
        private System.Windows.Forms.ListBox listBoxSkillList;
        private System.Windows.Forms.ToolStripButton pagListToolStripButtonSave;
        private System.Windows.Forms.ToolStripButton skillListToolStripButtonSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPagSkillRelation;
        private System.Windows.Forms.ListBox listBoxPagRelation;
        private System.Windows.Forms.CheckedListBox checkedListBoxSkillRelation;
        private System.Windows.Forms.Button buttonBuildPagSkillRelation;
        private System.Windows.Forms.TabPage tabActivitySelection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelActivitySelection;
        private System.Windows.Forms.DataGridView dataGridViewActivitySelectionSkills;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillName;
        private System.Windows.Forms.Label labelActivitySelectionSkill;
        private System.Windows.Forms.CheckedListBox checkedListBoxActivitySelectionPag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelActivitySelectionToolbar;
        private System.Windows.Forms.Label labelActivitySelectionPag;
        private System.Windows.Forms.Button buttonActivitySelectResetSelection;
        private System.Windows.Forms.TabPage tabContentSelection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContentSelection;
        private System.Windows.Forms.DataGridView dataGridViewContentSelectionPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.CheckedListBox checkedListBoxContentSelectionSkill;
        private System.Windows.Forms.TableLayoutPanel tableLayoutContentSelectionSkill;
        private System.Windows.Forms.Label labelContentSelectionSkill;
        private System.Windows.Forms.Button buttonContentSelectionSelectionReset;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContentSelectionActivitySelection;
        private System.Windows.Forms.Label labelContentSelectionPag;
        private System.Windows.Forms.ListBox listBoxContentSelectionInclusion;
        private System.Windows.Forms.TabPage tabAwardPag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAwardPag;
        private System.Windows.Forms.TreeView treeViewYearSelect;
        private System.Windows.Forms.TreeView treeViewPagSelect;
        private System.Windows.Forms.GroupBox groupBoxAwardPag;
        private System.Windows.Forms.Label labelPagAwardSettingsSelectDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerAwardPag;
        private System.Windows.Forms.Button buttonAwardPag;
        private System.Windows.Forms.Label labelAwardPagSelectedFailedSkills;
        private System.Windows.Forms.Label labelAwardPagSelectedPag;
        private System.Windows.Forms.Label labelAwardPagSelectedStudents;
        private System.Windows.Forms.Button buttonAwardPagClearSelection;
        private System.Windows.Forms.TabPage tabSkillRequirements;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSkillRequirement;
        private System.Windows.Forms.DataGridView dataGridViewSkillRequirement;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillRequirementsTableSkillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillRequirementsTableRequiredAmount;
        private System.Windows.Forms.Button buttonSaveSkillRequirement;
        private System.Windows.Forms.TabPage tabStudentImport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelImportStudents;
        private System.Windows.Forms.DataGridView dataGridViewStudentImport;
        private System.Windows.Forms.Button buttonImportCSV;
        private System.Windows.Forms.OpenFileDialog openFileDialogImportCSV;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelImportStudents;
        private System.Windows.Forms.Button buttonAddStudentRecord;
        private System.Windows.Forms.Label labelImportStudents;
        private System.Windows.Forms.Label labelAwardPagSelectedAbsent;
        private System.Windows.Forms.ToolStripMenuItem hidePagViewColumnsWithoutPAGDataToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxShowStudentID;
        private System.Windows.Forms.DataGridView dataGridViewStudentLookup;
        private System.Windows.Forms.Button buttonLookupSubmitModifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.TabPage tabGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPagGroup;
        private System.Windows.Forms.ToolStrip pagGroupToolStrip;
        private System.Windows.Forms.ToolStripLabel pagGroupToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox pagGroupToolStripTextBox;
        private System.Windows.Forms.ToolStripSeparator pagGroupToolStripSeperator;
        private System.Windows.Forms.ToolStripButton pagGroupToolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton pagGroupToolStripRemove;
        private System.Windows.Forms.ToolStripButton pagGroupToolStripSave;
        private System.Windows.Forms.ListBox listBoxGroupList;
        private System.Windows.Forms.CheckedListBox checkedListBoxPagList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStudentReport;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.ProgressBar progressBarStudentReport;
        private System.Windows.Forms.DataGridView dataGridViewStudentReport;
        private System.Windows.Forms.Label labelReportSettings;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStudentReportSettings;
        private System.Windows.Forms.Label labelFilterBy;
        private System.Windows.Forms.RadioButton radioButtonReportComplete;
        private System.Windows.Forms.RadioButton radioButtonReportNotComplete;
        private System.Windows.Forms.RadioButton radioButtonReportAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabStudentManagement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStudentManagement;
        private System.Windows.Forms.Button buttonExportReport;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExportReport;
        private System.Windows.Forms.ListBox listBoxStudentManagementList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStudentInfo;
        private System.Windows.Forms.TextBox textBoxStudentFName;
        private System.Windows.Forms.Label labelStudentManagementFName;
        private System.Windows.Forms.TextBox textBoxStudentLName;
        private System.Windows.Forms.Label labelStudentManagementLName;
        private System.Windows.Forms.Label labelStudentManagementYear;
        private System.Windows.Forms.Label labelStudentManagementClass;
        private System.Windows.Forms.TextBox textBoxStudentYear;
        private System.Windows.Forms.TextBox textBoxStudentClass;
        private System.Windows.Forms.Button buttonStudentManagementSaveChanges;
        private System.Windows.Forms.Button buttonStudentManagementDeleteStudent;
        private System.Windows.Forms.Button buttonStudentManagementAddStudent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStudentMassMove;
        private System.Windows.Forms.Label labelStudentManagement1;
        private System.Windows.Forms.Label labelStudentManagement2;
        private System.Windows.Forms.ComboBox comboBoxInputType;
        private System.Windows.Forms.ComboBox comboBoxInputName;
        private System.Windows.Forms.ComboBox comboBoxOutputName;
        private System.Windows.Forms.Button buttonMoveStudents;
        private System.Windows.Forms.Label labelNewItem;
        private System.Windows.Forms.ToolStripMenuItem backupRestoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxBackupName;
        private System.Windows.Forms.ToolStripMenuItem backupWithNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PAGPresetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPAGPresetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPAGPresetToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxCreatePreset;
        private System.Windows.Forms.ToolStripMenuItem createPresetWithNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePAGPresetToolStripMenuItem;
        private System.Windows.Forms.Button buttonResetToDefault;
        private System.Windows.Forms.Button buttonClearAllChanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentReportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentReportFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentReportSName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentReportYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentReportClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentReportCondition;
        private System.Windows.Forms.TextBox textBoxStudentFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPagView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPAGSearch;
        private System.Windows.Forms.Label labelPagViewFilter;
        private System.Windows.Forms.TextBox textBoxPagSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSkillView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSkillSearch;
        private System.Windows.Forms.Label labelSkillFilter;
        private System.Windows.Forms.TextBox textBoxSkillSearch;
        private System.Windows.Forms.Label labelUnsavedChanges;
        private System.Windows.Forms.Label labelAdminDeleteData;
        private System.Windows.Forms.Label labelAdminProgramDirectory;
        private System.Windows.Forms.Label labelAdminStudentID;
        private System.Windows.Forms.Button buttonAddPresets;
        private System.Windows.Forms.Label labelDefaultPresets;
        private System.Windows.Forms.Label labelImportData;
        private System.Windows.Forms.Button buttonImportData;
        private System.Windows.Forms.Label labelExportData;
        private System.Windows.Forms.Button buttonExportData;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExportData;
        private System.Windows.Forms.OpenFileDialog openFileDialogImportData;
    }
}


namespace ImagePropertyEditor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pictureViewTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageViewControlPanel = new System.Windows.Forms.Panel();
            this.preset4DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.preset3DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commitChangesButton = new System.Windows.Forms.Button();
            this.preset2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.preset1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.gridViewTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.FileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTakenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewDateTakenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasBeenUpdatedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LastModifiedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewLastModifiedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rootTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainControlsPanel = new System.Windows.Forms.Panel();
            this.onlyIncludeDateTakenNeededCheckBox = new System.Windows.Forms.CheckBox();
            this.fileNameFilterTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loadImagesButton = new System.Windows.Forms.Button();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.selectedDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.applyDateButton = new System.Windows.Forms.Button();
            this.incAndApplyPreset1Button = new System.Windows.Forms.Button();
            this.applyPreset1Button = new System.Windows.Forms.Button();
            this.storeAsPreset1Button = new System.Windows.Forms.Button();
            this.decAndApplyPreset1Button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.decAndApplyPreset2Button = new System.Windows.Forms.Button();
            this.storeAsPreset2Button = new System.Windows.Forms.Button();
            this.applyPreset2Button = new System.Windows.Forms.Button();
            this.incAndApplyPreset2Button = new System.Windows.Forms.Button();
            this.decAndApplyPreset4Button = new System.Windows.Forms.Button();
            this.storeAsPreset4Button = new System.Windows.Forms.Button();
            this.applyPreset4Button = new System.Windows.Forms.Button();
            this.incAndApplyPreset4Button = new System.Windows.Forms.Button();
            this.decAndApplyPreset3Button = new System.Windows.Forms.Button();
            this.storeAsPreset3Button = new System.Windows.Forms.Button();
            this.applyPreset3Button = new System.Windows.Forms.Button();
            this.incAndApplyPreset3Button = new System.Windows.Forms.Button();
            this.pictureViewDateEditor = new ImagePropertyEditor.DateEditor();
            this.dateEditor1 = new ImagePropertyEditor.DateEditor();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pictureViewTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.imageViewControlPanel.SuspendLayout();
            this.gridViewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.rootTableLayoutPanel.SuspendLayout();
            this.mainControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPictureBox.Location = new System.Drawing.Point(3, 78);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(1873, 765);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1899, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDirectoryToolStripMenuItem,
            this.showEditorToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setDirectoryToolStripMenuItem
            // 
            this.setDirectoryToolStripMenuItem.Name = "setDirectoryToolStripMenuItem";
            this.setDirectoryToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.setDirectoryToolStripMenuItem.Text = "Set Directory";
            this.setDirectoryToolStripMenuItem.Click += new System.EventHandler(this.setDirectoryToolStripMenuItem_Click);
            // 
            // showEditorToolStripMenuItem
            // 
            this.showEditorToolStripMenuItem.Name = "showEditorToolStripMenuItem";
            this.showEditorToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.showEditorToolStripMenuItem.Text = "Show Editor";
            this.showEditorToolStripMenuItem.Click += new System.EventHandler(this.showEditorToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pictureViewTabPage);
            this.tabControl1.Controls.Add(this.gridViewTabPage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 103);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1893, 878);
            this.tabControl1.TabIndex = 2;
            // 
            // pictureViewTabPage
            // 
            this.pictureViewTabPage.Controls.Add(this.tableLayoutPanel1);
            this.pictureViewTabPage.Location = new System.Drawing.Point(4, 22);
            this.pictureViewTabPage.Name = "pictureViewTabPage";
            this.pictureViewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pictureViewTabPage.Size = new System.Drawing.Size(1885, 852);
            this.pictureViewTabPage.TabIndex = 0;
            this.pictureViewTabPage.Text = "Picture View";
            this.pictureViewTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.imageViewControlPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainPictureBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1879, 846);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // imageViewControlPanel
            // 
            this.imageViewControlPanel.Controls.Add(this.decAndApplyPreset4Button);
            this.imageViewControlPanel.Controls.Add(this.storeAsPreset4Button);
            this.imageViewControlPanel.Controls.Add(this.applyPreset4Button);
            this.imageViewControlPanel.Controls.Add(this.incAndApplyPreset4Button);
            this.imageViewControlPanel.Controls.Add(this.decAndApplyPreset3Button);
            this.imageViewControlPanel.Controls.Add(this.storeAsPreset3Button);
            this.imageViewControlPanel.Controls.Add(this.applyPreset3Button);
            this.imageViewControlPanel.Controls.Add(this.incAndApplyPreset3Button);
            this.imageViewControlPanel.Controls.Add(this.decAndApplyPreset2Button);
            this.imageViewControlPanel.Controls.Add(this.storeAsPreset2Button);
            this.imageViewControlPanel.Controls.Add(this.applyPreset2Button);
            this.imageViewControlPanel.Controls.Add(this.incAndApplyPreset2Button);
            this.imageViewControlPanel.Controls.Add(this.decAndApplyPreset1Button);
            this.imageViewControlPanel.Controls.Add(this.storeAsPreset1Button);
            this.imageViewControlPanel.Controls.Add(this.applyPreset1Button);
            this.imageViewControlPanel.Controls.Add(this.incAndApplyPreset1Button);
            this.imageViewControlPanel.Controls.Add(this.applyDateButton);
            this.imageViewControlPanel.Controls.Add(this.preset4DateTimePicker);
            this.imageViewControlPanel.Controls.Add(this.preset3DateTimePicker);
            this.imageViewControlPanel.Controls.Add(this.commitChangesButton);
            this.imageViewControlPanel.Controls.Add(this.preset2DateTimePicker);
            this.imageViewControlPanel.Controls.Add(this.preset1DateTimePicker);
            this.imageViewControlPanel.Controls.Add(this.nextButton);
            this.imageViewControlPanel.Controls.Add(this.prevButton);
            this.imageViewControlPanel.Controls.Add(this.pictureViewDateEditor);
            this.imageViewControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewControlPanel.Location = new System.Drawing.Point(3, 3);
            this.imageViewControlPanel.Name = "imageViewControlPanel";
            this.imageViewControlPanel.Size = new System.Drawing.Size(1873, 69);
            this.imageViewControlPanel.TabIndex = 3;
            // 
            // preset4DateTimePicker
            // 
            this.preset4DateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preset4DateTimePicker.CustomFormat = "yyyy-MM-dd h:mm:ss tt";
            this.preset4DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preset4DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.preset4DateTimePicker.Location = new System.Drawing.Point(1356, 38);
            this.preset4DateTimePicker.Name = "preset4DateTimePicker";
            this.preset4DateTimePicker.Size = new System.Drawing.Size(176, 23);
            this.preset4DateTimePicker.TabIndex = 11;
            // 
            // preset3DateTimePicker
            // 
            this.preset3DateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preset3DateTimePicker.CustomFormat = "yyyy-MM-dd h:mm:ss tt";
            this.preset3DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preset3DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.preset3DateTimePicker.Location = new System.Drawing.Point(1356, 9);
            this.preset3DateTimePicker.Name = "preset3DateTimePicker";
            this.preset3DateTimePicker.Size = new System.Drawing.Size(176, 23);
            this.preset3DateTimePicker.TabIndex = 9;
            // 
            // commitChangesButton
            // 
            this.commitChangesButton.Location = new System.Drawing.Point(1629, 8);
            this.commitChangesButton.Name = "commitChangesButton";
            this.commitChangesButton.Size = new System.Drawing.Size(143, 53);
            this.commitChangesButton.TabIndex = 0;
            this.commitChangesButton.Text = "Commit All Changes";
            this.commitChangesButton.UseVisualStyleBackColor = true;
            this.commitChangesButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // preset2DateTimePicker
            // 
            this.preset2DateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preset2DateTimePicker.CustomFormat = "yyyy-MM-dd h:mm:ss tt";
            this.preset2DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preset2DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.preset2DateTimePicker.Location = new System.Drawing.Point(998, 38);
            this.preset2DateTimePicker.Name = "preset2DateTimePicker";
            this.preset2DateTimePicker.Size = new System.Drawing.Size(176, 23);
            this.preset2DateTimePicker.TabIndex = 7;
            // 
            // preset1DateTimePicker
            // 
            this.preset1DateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preset1DateTimePicker.CustomFormat = "yyyy-MM-dd h:mm:ss tt";
            this.preset1DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preset1DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.preset1DateTimePicker.Location = new System.Drawing.Point(998, 9);
            this.preset1DateTimePicker.Name = "preset1DateTimePicker";
            this.preset1DateTimePicker.Size = new System.Drawing.Size(176, 23);
            this.preset1DateTimePicker.TabIndex = 5;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(57, 16);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(38, 38);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "&>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(12, 16);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(38, 38);
            this.prevButton.TabIndex = 3;
            this.prevButton.Text = "&<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // gridViewTabPage
            // 
            this.gridViewTabPage.Controls.Add(this.dataGridView);
            this.gridViewTabPage.Location = new System.Drawing.Point(4, 22);
            this.gridViewTabPage.Name = "gridViewTabPage";
            this.gridViewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gridViewTabPage.Size = new System.Drawing.Size(1885, 852);
            this.gridViewTabPage.TabIndex = 1;
            this.gridViewTabPage.Text = "Grid View";
            this.gridViewTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileColumn,
            this.DateTakenColumn,
            this.NewDateTakenColumn,
            this.HasBeenUpdatedColumn,
            this.LastModifiedColumn,
            this.NewLastModifiedColumn});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1879, 846);
            this.dataGridView.TabIndex = 3;
            // 
            // FileColumn
            // 
            this.FileColumn.DataPropertyName = "FullName";
            this.FileColumn.HeaderText = "File";
            this.FileColumn.Name = "FileColumn";
            this.FileColumn.ReadOnly = true;
            this.FileColumn.Width = 48;
            // 
            // DateTakenColumn
            // 
            this.DateTakenColumn.DataPropertyName = "DateTaken";
            this.DateTakenColumn.HeaderText = "Date Taken";
            this.DateTakenColumn.Name = "DateTakenColumn";
            this.DateTakenColumn.ReadOnly = true;
            this.DateTakenColumn.Width = 89;
            // 
            // NewDateTakenColumn
            // 
            this.NewDateTakenColumn.DataPropertyName = "NewDateTaken";
            this.NewDateTakenColumn.HeaderText = "New Date Taken";
            this.NewDateTakenColumn.Name = "NewDateTakenColumn";
            this.NewDateTakenColumn.ReadOnly = true;
            this.NewDateTakenColumn.Width = 105;
            // 
            // HasBeenUpdatedColumn
            // 
            this.HasBeenUpdatedColumn.DataPropertyName = "HasBeenUpdated";
            this.HasBeenUpdatedColumn.HeaderText = "Updated";
            this.HasBeenUpdatedColumn.Name = "HasBeenUpdatedColumn";
            this.HasBeenUpdatedColumn.ReadOnly = true;
            this.HasBeenUpdatedColumn.Width = 54;
            // 
            // LastModifiedColumn
            // 
            this.LastModifiedColumn.DataPropertyName = "LastModifiedTime";
            this.LastModifiedColumn.HeaderText = "Last Modified";
            this.LastModifiedColumn.Name = "LastModifiedColumn";
            this.LastModifiedColumn.ReadOnly = true;
            this.LastModifiedColumn.Width = 88;
            // 
            // NewLastModifiedColumn
            // 
            this.NewLastModifiedColumn.DataPropertyName = "NewLastModifiedTime";
            this.NewLastModifiedColumn.HeaderText = "New Last Modified";
            this.NewLastModifiedColumn.Name = "NewLastModifiedColumn";
            this.NewLastModifiedColumn.ReadOnly = true;
            this.NewLastModifiedColumn.Width = 110;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateEditor1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1885, 852);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rootTableLayoutPanel
            // 
            this.rootTableLayoutPanel.ColumnCount = 1;
            this.rootTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTableLayoutPanel.Controls.Add(this.tabControl1, 0, 1);
            this.rootTableLayoutPanel.Controls.Add(this.mainControlsPanel, 0, 0);
            this.rootTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.rootTableLayoutPanel.Name = "rootTableLayoutPanel";
            this.rootTableLayoutPanel.RowCount = 2;
            this.rootTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.rootTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTableLayoutPanel.Size = new System.Drawing.Size(1899, 984);
            this.rootTableLayoutPanel.TabIndex = 3;
            // 
            // mainControlsPanel
            // 
            this.mainControlsPanel.Controls.Add(this.onlyIncludeDateTakenNeededCheckBox);
            this.mainControlsPanel.Controls.Add(this.fileNameFilterTextBox);
            this.mainControlsPanel.Controls.Add(this.label2);
            this.mainControlsPanel.Controls.Add(this.loadImagesButton);
            this.mainControlsPanel.Controls.Add(this.selectFolderButton);
            this.mainControlsPanel.Controls.Add(this.selectedDirectoryTextBox);
            this.mainControlsPanel.Controls.Add(this.label1);
            this.mainControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainControlsPanel.Location = new System.Drawing.Point(3, 3);
            this.mainControlsPanel.Name = "mainControlsPanel";
            this.mainControlsPanel.Size = new System.Drawing.Size(1893, 94);
            this.mainControlsPanel.TabIndex = 3;
            // 
            // onlyIncludeDateTakenNeededCheckBox
            // 
            this.onlyIncludeDateTakenNeededCheckBox.AutoSize = true;
            this.onlyIncludeDateTakenNeededCheckBox.Location = new System.Drawing.Point(932, 61);
            this.onlyIncludeDateTakenNeededCheckBox.Name = "onlyIncludeDateTakenNeededCheckBox";
            this.onlyIncludeDateTakenNeededCheckBox.Size = new System.Drawing.Size(256, 17);
            this.onlyIncludeDateTakenNeededCheckBox.TabIndex = 6;
            this.onlyIncludeDateTakenNeededCheckBox.Text = "Only include files without Date Taken set already";
            this.onlyIncludeDateTakenNeededCheckBox.UseVisualStyleBackColor = true;
            // 
            // fileNameFilterTextBox
            // 
            this.fileNameFilterTextBox.Location = new System.Drawing.Point(932, 27);
            this.fileNameFilterTextBox.Name = "fileNameFilterTextBox";
            this.fileNameFilterTextBox.Size = new System.Drawing.Size(454, 20);
            this.fileNameFilterTextBox.TabIndex = 5;
            this.fileNameFilterTextBox.Text = "*.jpg, *.heic, *.png";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(929, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "File Name Filter";
            // 
            // loadImagesButton
            // 
            this.loadImagesButton.Location = new System.Drawing.Point(700, 27);
            this.loadImagesButton.Name = "loadImagesButton";
            this.loadImagesButton.Size = new System.Drawing.Size(104, 52);
            this.loadImagesButton.TabIndex = 3;
            this.loadImagesButton.Text = "Load Images";
            this.loadImagesButton.UseVisualStyleBackColor = true;
            this.loadImagesButton.Click += new System.EventHandler(this.loadImagesButton_Click);
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(472, 11);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(111, 35);
            this.selectFolderButton.TabIndex = 2;
            this.selectFolderButton.Text = "Select Directory";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // selectedDirectoryTextBox
            // 
            this.selectedDirectoryTextBox.Location = new System.Drawing.Point(12, 27);
            this.selectedDirectoryTextBox.Name = "selectedDirectoryTextBox";
            this.selectedDirectoryTextBox.Size = new System.Drawing.Size(454, 20);
            this.selectedDirectoryTextBox.TabIndex = 1;
            this.selectedDirectoryTextBox.Text = "C:\\temp\\NewPicsTest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // applyDateButton
            // 
            this.applyDateButton.Location = new System.Drawing.Point(656, 11);
            this.applyDateButton.Name = "applyDateButton";
            this.applyDateButton.Size = new System.Drawing.Size(54, 43);
            this.applyDateButton.TabIndex = 13;
            this.applyDateButton.Text = "&Apply";
            this.applyDateButton.UseVisualStyleBackColor = true;
            this.applyDateButton.Click += new System.EventHandler(this.applyDateButton_Click);
            // 
            // incAndApplyPreset1Button
            // 
            this.incAndApplyPreset1Button.Image = ((System.Drawing.Image)(resources.GetObject("incAndApplyPreset1Button.Image")));
            this.incAndApplyPreset1Button.Location = new System.Drawing.Point(898, 8);
            this.incAndApplyPreset1Button.Name = "incAndApplyPreset1Button";
            this.incAndApplyPreset1Button.Size = new System.Drawing.Size(26, 26);
            this.incAndApplyPreset1Button.TabIndex = 14;
            this.toolTip1.SetToolTip(this.incAndApplyPreset1Button, "Increment Time and Apply");
            this.incAndApplyPreset1Button.UseVisualStyleBackColor = true;
            this.incAndApplyPreset1Button.Click += new System.EventHandler(this.incAndApplyPreset1Button_Click);
            // 
            // applyPreset1Button
            // 
            this.applyPreset1Button.Image = ((System.Drawing.Image)(resources.GetObject("applyPreset1Button.Image")));
            this.applyPreset1Button.Location = new System.Drawing.Point(866, 8);
            this.applyPreset1Button.Name = "applyPreset1Button";
            this.applyPreset1Button.Size = new System.Drawing.Size(26, 26);
            this.applyPreset1Button.TabIndex = 15;
            this.toolTip1.SetToolTip(this.applyPreset1Button, "Apply to Image");
            this.applyPreset1Button.UseVisualStyleBackColor = true;
            this.applyPreset1Button.Click += new System.EventHandler(this.applyPreset1Button_Click);
            // 
            // storeAsPreset1Button
            // 
            this.storeAsPreset1Button.Image = ((System.Drawing.Image)(resources.GetObject("storeAsPreset1Button.Image")));
            this.storeAsPreset1Button.Location = new System.Drawing.Point(962, 8);
            this.storeAsPreset1Button.Name = "storeAsPreset1Button";
            this.storeAsPreset1Button.Size = new System.Drawing.Size(26, 26);
            this.storeAsPreset1Button.TabIndex = 16;
            this.toolTip1.SetToolTip(this.storeAsPreset1Button, "Store as Preset");
            this.storeAsPreset1Button.UseVisualStyleBackColor = true;
            this.storeAsPreset1Button.Click += new System.EventHandler(this.storeAsPreset1Button_Click);
            // 
            // decAndApplyPreset1Button
            // 
            this.decAndApplyPreset1Button.Image = ((System.Drawing.Image)(resources.GetObject("decAndApplyPreset1Button.Image")));
            this.decAndApplyPreset1Button.Location = new System.Drawing.Point(930, 8);
            this.decAndApplyPreset1Button.Name = "decAndApplyPreset1Button";
            this.decAndApplyPreset1Button.Size = new System.Drawing.Size(26, 26);
            this.decAndApplyPreset1Button.TabIndex = 17;
            this.toolTip1.SetToolTip(this.decAndApplyPreset1Button, "Decrement Time and Apply");
            this.decAndApplyPreset1Button.UseVisualStyleBackColor = true;
            this.decAndApplyPreset1Button.Click += new System.EventHandler(this.decAndApplyPreset1Button_Click);
            // 
            // decAndApplyPreset2Button
            // 
            this.decAndApplyPreset2Button.Image = ((System.Drawing.Image)(resources.GetObject("decAndApplyPreset2Button.Image")));
            this.decAndApplyPreset2Button.Location = new System.Drawing.Point(930, 35);
            this.decAndApplyPreset2Button.Name = "decAndApplyPreset2Button";
            this.decAndApplyPreset2Button.Size = new System.Drawing.Size(26, 26);
            this.decAndApplyPreset2Button.TabIndex = 21;
            this.toolTip1.SetToolTip(this.decAndApplyPreset2Button, "Decrement Time and Apply");
            this.decAndApplyPreset2Button.UseVisualStyleBackColor = true;
            this.decAndApplyPreset2Button.Click += new System.EventHandler(this.decAndApplyPreset2Button_Click);
            // 
            // storeAsPreset2Button
            // 
            this.storeAsPreset2Button.Image = ((System.Drawing.Image)(resources.GetObject("storeAsPreset2Button.Image")));
            this.storeAsPreset2Button.Location = new System.Drawing.Point(962, 35);
            this.storeAsPreset2Button.Name = "storeAsPreset2Button";
            this.storeAsPreset2Button.Size = new System.Drawing.Size(26, 26);
            this.storeAsPreset2Button.TabIndex = 20;
            this.toolTip1.SetToolTip(this.storeAsPreset2Button, "Store as Preset");
            this.storeAsPreset2Button.UseVisualStyleBackColor = true;
            this.storeAsPreset2Button.Click += new System.EventHandler(this.storeAsPreset2Button_Click);
            // 
            // applyPreset2Button
            // 
            this.applyPreset2Button.Image = ((System.Drawing.Image)(resources.GetObject("applyPreset2Button.Image")));
            this.applyPreset2Button.Location = new System.Drawing.Point(866, 35);
            this.applyPreset2Button.Name = "applyPreset2Button";
            this.applyPreset2Button.Size = new System.Drawing.Size(26, 26);
            this.applyPreset2Button.TabIndex = 19;
            this.toolTip1.SetToolTip(this.applyPreset2Button, "Apply to Image");
            this.applyPreset2Button.UseVisualStyleBackColor = true;
            this.applyPreset2Button.Click += new System.EventHandler(this.applyPreset2Button_Click);
            // 
            // incAndApplyPreset2Button
            // 
            this.incAndApplyPreset2Button.Image = ((System.Drawing.Image)(resources.GetObject("incAndApplyPreset2Button.Image")));
            this.incAndApplyPreset2Button.Location = new System.Drawing.Point(898, 35);
            this.incAndApplyPreset2Button.Name = "incAndApplyPreset2Button";
            this.incAndApplyPreset2Button.Size = new System.Drawing.Size(26, 26);
            this.incAndApplyPreset2Button.TabIndex = 18;
            this.toolTip1.SetToolTip(this.incAndApplyPreset2Button, "Increment Time and Apply");
            this.incAndApplyPreset2Button.UseVisualStyleBackColor = true;
            this.incAndApplyPreset2Button.Click += new System.EventHandler(this.incAndApplyPreset2Button_Click);
            // 
            // decAndApplyPreset4Button
            // 
            this.decAndApplyPreset4Button.Image = ((System.Drawing.Image)(resources.GetObject("decAndApplyPreset4Button.Image")));
            this.decAndApplyPreset4Button.Location = new System.Drawing.Point(1287, 35);
            this.decAndApplyPreset4Button.Name = "decAndApplyPreset4Button";
            this.decAndApplyPreset4Button.Size = new System.Drawing.Size(26, 26);
            this.decAndApplyPreset4Button.TabIndex = 29;
            this.toolTip1.SetToolTip(this.decAndApplyPreset4Button, "Decrement Time and Apply");
            this.decAndApplyPreset4Button.UseVisualStyleBackColor = true;
            this.decAndApplyPreset4Button.Click += new System.EventHandler(this.decAndApplyPreset4Button_Click);
            // 
            // storeAsPreset4Button
            // 
            this.storeAsPreset4Button.Image = ((System.Drawing.Image)(resources.GetObject("storeAsPreset4Button.Image")));
            this.storeAsPreset4Button.Location = new System.Drawing.Point(1319, 35);
            this.storeAsPreset4Button.Name = "storeAsPreset4Button";
            this.storeAsPreset4Button.Size = new System.Drawing.Size(26, 26);
            this.storeAsPreset4Button.TabIndex = 28;
            this.toolTip1.SetToolTip(this.storeAsPreset4Button, "Store as Preset");
            this.storeAsPreset4Button.UseVisualStyleBackColor = true;
            this.storeAsPreset4Button.Click += new System.EventHandler(this.storeAsPreset4Button_Click);
            // 
            // applyPreset4Button
            // 
            this.applyPreset4Button.Image = ((System.Drawing.Image)(resources.GetObject("applyPreset4Button.Image")));
            this.applyPreset4Button.Location = new System.Drawing.Point(1223, 35);
            this.applyPreset4Button.Name = "applyPreset4Button";
            this.applyPreset4Button.Size = new System.Drawing.Size(26, 26);
            this.applyPreset4Button.TabIndex = 27;
            this.toolTip1.SetToolTip(this.applyPreset4Button, "Apply to Image");
            this.applyPreset4Button.UseVisualStyleBackColor = true;
            this.applyPreset4Button.Click += new System.EventHandler(this.applyPreset4Button_Click);
            // 
            // incAndApplyPreset4Button
            // 
            this.incAndApplyPreset4Button.Image = ((System.Drawing.Image)(resources.GetObject("incAndApplyPreset4Button.Image")));
            this.incAndApplyPreset4Button.Location = new System.Drawing.Point(1255, 35);
            this.incAndApplyPreset4Button.Name = "incAndApplyPreset4Button";
            this.incAndApplyPreset4Button.Size = new System.Drawing.Size(26, 26);
            this.incAndApplyPreset4Button.TabIndex = 26;
            this.toolTip1.SetToolTip(this.incAndApplyPreset4Button, "Increment Time and Apply");
            this.incAndApplyPreset4Button.UseVisualStyleBackColor = true;
            this.incAndApplyPreset4Button.Click += new System.EventHandler(this.incAndApplyPreset4Button_Click);
            // 
            // decAndApplyPreset3Button
            // 
            this.decAndApplyPreset3Button.Image = ((System.Drawing.Image)(resources.GetObject("decAndApplyPreset3Button.Image")));
            this.decAndApplyPreset3Button.Location = new System.Drawing.Point(1287, 8);
            this.decAndApplyPreset3Button.Name = "decAndApplyPreset3Button";
            this.decAndApplyPreset3Button.Size = new System.Drawing.Size(26, 26);
            this.decAndApplyPreset3Button.TabIndex = 25;
            this.toolTip1.SetToolTip(this.decAndApplyPreset3Button, "Decrement Time and Apply");
            this.decAndApplyPreset3Button.UseVisualStyleBackColor = true;
            this.decAndApplyPreset3Button.Click += new System.EventHandler(this.decAndApplyPreset3Button_Click);
            // 
            // storeAsPreset3Button
            // 
            this.storeAsPreset3Button.Image = ((System.Drawing.Image)(resources.GetObject("storeAsPreset3Button.Image")));
            this.storeAsPreset3Button.Location = new System.Drawing.Point(1319, 8);
            this.storeAsPreset3Button.Name = "storeAsPreset3Button";
            this.storeAsPreset3Button.Size = new System.Drawing.Size(26, 26);
            this.storeAsPreset3Button.TabIndex = 24;
            this.toolTip1.SetToolTip(this.storeAsPreset3Button, "Store as Preset");
            this.storeAsPreset3Button.UseVisualStyleBackColor = true;
            this.storeAsPreset3Button.Click += new System.EventHandler(this.storeAsPreset3Button_Click);
            // 
            // applyPreset3Button
            // 
            this.applyPreset3Button.Image = ((System.Drawing.Image)(resources.GetObject("applyPreset3Button.Image")));
            this.applyPreset3Button.Location = new System.Drawing.Point(1223, 8);
            this.applyPreset3Button.Name = "applyPreset3Button";
            this.applyPreset3Button.Size = new System.Drawing.Size(26, 26);
            this.applyPreset3Button.TabIndex = 23;
            this.toolTip1.SetToolTip(this.applyPreset3Button, "Apply to Image");
            this.applyPreset3Button.UseVisualStyleBackColor = true;
            this.applyPreset3Button.Click += new System.EventHandler(this.applyPreset3Button_Click);
            // 
            // incAndApplyPreset3Button
            // 
            this.incAndApplyPreset3Button.Image = ((System.Drawing.Image)(resources.GetObject("incAndApplyPreset3Button.Image")));
            this.incAndApplyPreset3Button.Location = new System.Drawing.Point(1255, 8);
            this.incAndApplyPreset3Button.Name = "incAndApplyPreset3Button";
            this.incAndApplyPreset3Button.Size = new System.Drawing.Size(26, 26);
            this.incAndApplyPreset3Button.TabIndex = 22;
            this.toolTip1.SetToolTip(this.incAndApplyPreset3Button, "Increment Time and Apply");
            this.incAndApplyPreset3Button.UseVisualStyleBackColor = true;
            this.incAndApplyPreset3Button.Click += new System.EventHandler(this.incAndApplyPreset3Button_Click);
            // 
            // pictureViewDateEditor
            // 
            this.pictureViewDateEditor.AllowTimeEditing = true;
            this.pictureViewDateEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureViewDateEditor.Location = new System.Drawing.Point(120, 16);
            this.pictureViewDateEditor.Name = "pictureViewDateEditor";
            this.pictureViewDateEditor.Size = new System.Drawing.Size(532, 38);
            this.pictureViewDateEditor.TabIndex = 1;
            this.pictureViewDateEditor.Load += new System.EventHandler(this.pictureViewDateEditor_Load);
            // 
            // dateEditor1
            // 
            this.dateEditor1.AllowTimeEditing = true;
            this.dateEditor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditor1.Location = new System.Drawing.Point(373, 57);
            this.dateEditor1.Name = "dateEditor1";
            this.dateEditor1.Size = new System.Drawing.Size(571, 38);
            this.dateEditor1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 1008);
            this.Controls.Add(this.rootTableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.pictureViewTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.imageViewControlPanel.ResumeLayout(false);
            this.gridViewTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.rootTableLayoutPanel.ResumeLayout(false);
            this.mainControlsPanel.ResumeLayout(false);
            this.mainControlsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEditorToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pictureViewTabPage;
        private System.Windows.Forms.TabPage gridViewTabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel imageViewControlPanel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabPage tabPage1;
        private DateEditor dateEditor1;
        private System.Windows.Forms.TableLayoutPanel rootTableLayoutPanel;
        private System.Windows.Forms.Panel mainControlsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox selectedDirectoryTextBox;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.TextBox fileNameFilterTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadImagesButton;
        private System.Windows.Forms.Button commitChangesButton;
        private DateEditor pictureViewDateEditor;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTakenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewDateTakenColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HasBeenUpdatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastModifiedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewLastModifiedColumn;
        private System.Windows.Forms.DateTimePicker preset1DateTimePicker;
        private System.Windows.Forms.DateTimePicker preset4DateTimePicker;
        private System.Windows.Forms.DateTimePicker preset3DateTimePicker;
        private System.Windows.Forms.DateTimePicker preset2DateTimePicker;
        private System.Windows.Forms.CheckBox onlyIncludeDateTakenNeededCheckBox;
        private System.Windows.Forms.Button applyDateButton;
        private System.Windows.Forms.Button incAndApplyPreset1Button;
        private System.Windows.Forms.Button decAndApplyPreset1Button;
        private System.Windows.Forms.Button storeAsPreset1Button;
        private System.Windows.Forms.Button applyPreset1Button;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button decAndApplyPreset2Button;
        private System.Windows.Forms.Button storeAsPreset2Button;
        private System.Windows.Forms.Button applyPreset2Button;
        private System.Windows.Forms.Button incAndApplyPreset2Button;
        private System.Windows.Forms.Button decAndApplyPreset4Button;
        private System.Windows.Forms.Button storeAsPreset4Button;
        private System.Windows.Forms.Button applyPreset4Button;
        private System.Windows.Forms.Button incAndApplyPreset4Button;
        private System.Windows.Forms.Button decAndApplyPreset3Button;
        private System.Windows.Forms.Button storeAsPreset3Button;
        private System.Windows.Forms.Button applyPreset3Button;
        private System.Windows.Forms.Button incAndApplyPreset3Button;
    }
}


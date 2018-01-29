namespace MakePlaylist
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSNew = new System.Windows.Forms.ToolStripMenuItem();
            this.TSExit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.TSNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.TSTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSPRoot = new System.Windows.Forms.ToolStripMenuItem();
            this.TSPPath = new System.Windows.Forms.ToolStripMenuItem();
            this.TSType = new System.Windows.Forms.ToolStripMenuItem();
            this.TSLPath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSCustSort = new System.Windows.Forms.ToolStripMenuItem();
            this.TSExtInf = new System.Windows.Forms.ToolStripMenuItem();
            this.TSDup = new System.Windows.Forms.ToolStripMenuItem();
            this.aboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAssume = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblItemSelected = new System.Windows.Forms.Label();
            this.TBFilename = new System.Windows.Forms.TextBox();
            this.LblItemCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPlaylistRoot = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColPlaylistPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLocalPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCustom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColExtInf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.extPathBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extPathBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1087, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSNew,
            this.TSExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // TSNew
            // 
            this.TSNew.Name = "TSNew";
            this.TSNew.Size = new System.Drawing.Size(108, 24);
            this.TSNew.Text = "New";
            this.TSNew.Click += new System.EventHandler(this.LblItemCount_Click);
            // 
            // TSExit
            // 
            this.TSExit.Name = "TSExit";
            this.TSExit.Size = new System.Drawing.Size(108, 24);
            this.TSExit.Text = "Exit";
            this.TSExit.Click += new System.EventHandler(this.TSExit_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.CheckOnClick = true;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSColumns,
            this.toolStripSeparator1,
            this.TSCustSort,
            this.TSExtInf,
            this.TSDup});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // TSColumns
            // 
            this.TSColumns.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSNumber,
            this.TSTitle,
            this.TSPRoot,
            this.TSPPath,
            this.TSType,
            this.TSLPath});
            this.TSColumns.Name = "TSColumns";
            this.TSColumns.Size = new System.Drawing.Size(205, 24);
            this.TSColumns.Text = "Columns";
            // 
            // TSNumber
            // 
            this.TSNumber.Checked = true;
            this.TSNumber.CheckOnClick = true;
            this.TSNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSNumber.Name = "TSNumber";
            this.TSNumber.Size = new System.Drawing.Size(160, 24);
            this.TSNumber.Text = "#";
            this.TSNumber.Click += new System.EventHandler(this.TSNumber_Click);
            // 
            // TSTitle
            // 
            this.TSTitle.Checked = true;
            this.TSTitle.CheckOnClick = true;
            this.TSTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSTitle.Name = "TSTitle";
            this.TSTitle.Size = new System.Drawing.Size(160, 24);
            this.TSTitle.Text = "Title";
            this.TSTitle.Click += new System.EventHandler(this.TSTitle_Click);
            // 
            // TSPRoot
            // 
            this.TSPRoot.Checked = true;
            this.TSPRoot.CheckOnClick = true;
            this.TSPRoot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSPRoot.Name = "TSPRoot";
            this.TSPRoot.Size = new System.Drawing.Size(160, 24);
            this.TSPRoot.Text = "Playlist Root";
            this.TSPRoot.Click += new System.EventHandler(this.TSPRoot_Click);
            // 
            // TSPPath
            // 
            this.TSPPath.Checked = true;
            this.TSPPath.CheckOnClick = true;
            this.TSPPath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSPPath.Name = "TSPPath";
            this.TSPPath.Size = new System.Drawing.Size(160, 24);
            this.TSPPath.Text = "Playlist Path";
            this.TSPPath.Click += new System.EventHandler(this.TSPPath_Click);
            // 
            // TSType
            // 
            this.TSType.Checked = true;
            this.TSType.CheckOnClick = true;
            this.TSType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSType.Name = "TSType";
            this.TSType.Size = new System.Drawing.Size(160, 24);
            this.TSType.Text = "Type";
            this.TSType.Click += new System.EventHandler(this.TSType_Click);
            // 
            // TSLPath
            // 
            this.TSLPath.Checked = true;
            this.TSLPath.CheckOnClick = true;
            this.TSLPath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSLPath.Name = "TSLPath";
            this.TSLPath.Size = new System.Drawing.Size(160, 24);
            this.TSLPath.Text = "Local Path";
            this.TSLPath.Click += new System.EventHandler(this.TSLPath_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // TSCustSort
            // 
            this.TSCustSort.Checked = true;
            this.TSCustSort.CheckOnClick = true;
            this.TSCustSort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSCustSort.Name = "TSCustSort";
            this.TSCustSort.Size = new System.Drawing.Size(205, 24);
            this.TSCustSort.Text = "Custom sort";
            this.TSCustSort.Click += new System.EventHandler(this.TSCustSort_Click);
            // 
            // TSExtInf
            // 
            this.TSExtInf.Checked = true;
            this.TSExtInf.CheckOnClick = true;
            this.TSExtInf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSExtInf.Name = "TSExtInf";
            this.TSExtInf.Size = new System.Drawing.Size(205, 24);
            this.TSExtInf.Text = "Extended M3U info";
            this.TSExtInf.Click += new System.EventHandler(this.TSExtInf_Click);
            // 
            // TSDup
            // 
            this.TSDup.CheckOnClick = true;
            this.TSDup.Name = "TSDup";
            this.TSDup.Size = new System.Drawing.Size(205, 24);
            this.TSDup.Text = "Find duplicates";
            this.TSDup.Click += new System.EventHandler(this.TSDup_Click);
            // 
            // aboToolStripMenuItem
            // 
            this.aboToolStripMenuItem.Name = "aboToolStripMenuItem";
            this.aboToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboToolStripMenuItem.Text = "About";
            this.aboToolStripMenuItem.Click += new System.EventHandler(this.aboToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1087, 555);
            this.label1.TabIndex = 5;
            this.label1.Text = "Drag and drop files or \r\nplaylist here to begin.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 555);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 555);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Controls.Add(this.BtnExport);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(928, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(159, 555);
            this.panel4.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnAssume, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnRemove, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnEdit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnSelect, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(159, 428);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // BtnAssume
            // 
            this.BtnAssume.Location = new System.Drawing.Point(3, 3);
            this.BtnAssume.Name = "BtnAssume";
            this.BtnAssume.Size = new System.Drawing.Size(151, 52);
            this.BtnAssume.TabIndex = 13;
            this.BtnAssume.Text = "Assume playlist path";
            this.BtnAssume.UseVisualStyleBackColor = true;
            this.BtnAssume.Click += new System.EventHandler(this.BtnAssume_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Enabled = false;
            this.BtnRemove.Location = new System.Drawing.Point(4, 150);
            this.BtnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(151, 52);
            this.BtnRemove.TabIndex = 11;
            this.BtnRemove.Text = "Remove selected";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Enabled = false;
            this.BtnEdit.Location = new System.Drawing.Point(4, 91);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(151, 51);
            this.BtnEdit.TabIndex = 10;
            this.BtnEdit.Text = "Edit selected";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(4, 244);
            this.BtnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(151, 52);
            this.BtnSelect.TabIndex = 12;
            this.BtnSelect.Text = "Custom select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExport.Location = new System.Drawing.Point(32, 445);
            this.BtnExport.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(100, 89);
            this.BtnExport.TabIndex = 13;
            this.BtnExport.Text = "Make Playlist";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.LblItemSelected);
            this.panel3.Controls.Add(this.TBFilename);
            this.panel3.Controls.Add(this.LblItemCount);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 463);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(920, 91);
            this.panel3.TabIndex = 9;
            // 
            // LblItemSelected
            // 
            this.LblItemSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblItemSelected.AutoSize = true;
            this.LblItemSelected.Location = new System.Drawing.Point(810, 10);
            this.LblItemSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblItemSelected.Name = "LblItemSelected";
            this.LblItemSelected.Size = new System.Drawing.Size(110, 17);
            this.LblItemSelected.TabIndex = 4;
            this.LblItemSelected.Text = "0 Items selected";
            // 
            // TBFilename
            // 
            this.TBFilename.Location = new System.Drawing.Point(95, 46);
            this.TBFilename.Margin = new System.Windows.Forms.Padding(4);
            this.TBFilename.Name = "TBFilename";
            this.TBFilename.Size = new System.Drawing.Size(289, 22);
            this.TBFilename.TabIndex = 2;
            // 
            // LblItemCount
            // 
            this.LblItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblItemCount.AutoSize = true;
            this.LblItemCount.Location = new System.Drawing.Point(622, 10);
            this.LblItemCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblItemCount.Name = "LblItemCount";
            this.LblItemCount.Size = new System.Drawing.Size(93, 17);
            this.LblItemCount.TabIndex = 3;
            this.LblItemCount.Text = "0 Items found";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Playlist title";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCheck,
            this.ColNumber,
            this.ColTitle,
            this.ColPlaylistRoot,
            this.ColPlaylistPath,
            this.ColExtension,
            this.ColLocalPath,
            this.ColCustom,
            this.ColExtInf,
            this.IsDup});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(920, 455);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragOver);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColCheck
            // 
            this.ColCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColCheck.FalseValue = "false";
            this.ColCheck.HeaderText = "";
            this.ColCheck.Name = "ColCheck";
            this.ColCheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCheck.TrueValue = "true";
            this.ColCheck.Width = 30;
            // 
            // ColNumber
            // 
            this.ColNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColNumber.HeaderText = "#";
            this.ColNumber.Name = "ColNumber";
            this.ColNumber.ReadOnly = true;
            this.ColNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColNumber.Width = 50;
            // 
            // ColTitle
            // 
            this.ColTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTitle.HeaderText = "Title";
            this.ColTitle.Name = "ColTitle";
            // 
            // ColPlaylistRoot
            // 
            this.ColPlaylistRoot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColPlaylistRoot.HeaderText = "Playlist Root";
            this.ColPlaylistRoot.Name = "ColPlaylistRoot";
            this.ColPlaylistRoot.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColPlaylistRoot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColPlaylistRoot.Width = 111;
            // 
            // ColPlaylistPath
            // 
            this.ColPlaylistPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPlaylistPath.HeaderText = "Playlist Path";
            this.ColPlaylistPath.Name = "ColPlaylistPath";
            // 
            // ColExtension
            // 
            this.ColExtension.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColExtension.FillWeight = 50F;
            this.ColExtension.HeaderText = "Type";
            this.ColExtension.Name = "ColExtension";
            this.ColExtension.ReadOnly = true;
            this.ColExtension.Width = 65;
            // 
            // ColLocalPath
            // 
            this.ColLocalPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColLocalPath.HeaderText = "Local Path";
            this.ColLocalPath.Name = "ColLocalPath";
            this.ColLocalPath.ReadOnly = true;
            // 
            // ColCustom
            // 
            this.ColCustom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCustom.HeaderText = "Sort Name";
            this.ColCustom.Name = "ColCustom";
            // 
            // ColExtInf
            // 
            this.ColExtInf.HeaderText = "ExtInf";
            this.ColExtInf.Name = "ColExtInf";
            this.ColExtInf.ReadOnly = true;
            this.ColExtInf.Visible = false;
            // 
            // IsDup
            // 
            this.IsDup.HeaderText = "IsDup";
            this.IsDup.Name = "IsDup";
            this.IsDup.ReadOnly = true;
            this.IsDup.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem,
            this.moveToToolStripMenuItem,
            this.toolStripMenuItem1,
            this.duplicateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 130);
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.moveUpToolStripMenuItem.Text = "Move up";
            this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.moveUpToolStripMenuItem_Click);
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.moveDownToolStripMenuItem.Text = "Move down";
            this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.moveDownToolStripMenuItem_Click);
            // 
            // moveToToolStripMenuItem
            // 
            this.moveToToolStripMenuItem.Name = "moveToToolStripMenuItem";
            this.moveToToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.moveToToolStripMenuItem.Text = "Move to";
            this.moveToToolStripMenuItem.Click += new System.EventHandler(this.moveToToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.duplicateToolStripMenuItem.Text = "Duplicate";
            this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.duplicateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.deleteToolStripMenuItem.Text = "Remove";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // extPathBindingSource
            // 
            this.extPathBindingSource.DataSource = typeof(MakePlaylist.ExtPath);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 583);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.extPathBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSNew;
        private System.Windows.Forms.ToolStripMenuItem TSExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblItemSelected;
        private System.Windows.Forms.TextBox TBFilename;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblItemCount;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.BindingSource extPathBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnAssume;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSCustSort;
        private System.Windows.Forms.ToolStripMenuItem TSExtInf;
        private System.Windows.Forms.ToolStripMenuItem TSColumns;
        private System.Windows.Forms.ToolStripMenuItem TSNumber;
        private System.Windows.Forms.ToolStripMenuItem TSTitle;
        private System.Windows.Forms.ToolStripMenuItem TSPRoot;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSPPath;
        private System.Windows.Forms.ToolStripMenuItem TSType;
        private System.Windows.Forms.ToolStripMenuItem TSLPath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSDup;
        private System.Windows.Forms.ToolStripMenuItem aboToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitle;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColPlaylistRoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlaylistPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLocalPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCustom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColExtInf;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDup;

    }
}


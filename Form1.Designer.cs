namespace SearchDocs
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
            this.btnChooseFilePath = new System.Windows.Forms.Button();
            this.txbFilePath = new System.Windows.Forms.TextBox();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.txbSearch1 = new System.Windows.Forms.TextBox();
            this.txbSearch2 = new System.Windows.Forms.TextBox();
            this.txbSearch3 = new System.Windows.Forms.TextBox();
            this.txbSearch4 = new System.Windows.Forms.TextBox();
            this.txbSearch5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx1 = new System.Windows.Forms.ComboBox();
            this.cbx2 = new System.Windows.Forms.ComboBox();
            this.cbx3 = new System.Windows.Forms.ComboBox();
            this.cbx4 = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabDocs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdioMess = new System.Windows.Forms.RadioButton();
            this.rdioSentence = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLogicSearch1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkFile3 = new System.Windows.Forms.LinkLabel();
            this.linkFile2 = new System.Windows.Forms.LinkLabel();
            this.linkFile1 = new System.Windows.Forms.LinkLabel();
            this.lbLogicRTitle = new System.Windows.Forms.Label();
            this.txbLogic = new System.Windows.Forms.TextBox();
            this.btnAddLogic = new System.Windows.Forms.Button();
            this.btnLogicEdit = new System.Windows.Forms.Button();
            this.btnLogicDelete = new System.Windows.Forms.Button();
            this.datagrdLogicR = new System.Windows.Forms.DataGridView();
            this.treeviewR = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.txbTest = new System.Windows.Forms.TextBox();
            this.lbTest = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.tabDocs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdLogicR)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChooseFilePath
            // 
            this.btnChooseFilePath.Location = new System.Drawing.Point(1068, 16);
            this.btnChooseFilePath.Name = "btnChooseFilePath";
            this.btnChooseFilePath.Size = new System.Drawing.Size(102, 23);
            this.btnChooseFilePath.TabIndex = 10;
            this.btnChooseFilePath.TabStop = false;
            this.btnChooseFilePath.Text = "参照";
            this.btnChooseFilePath.UseVisualStyleBackColor = true;
            this.btnChooseFilePath.Click += new System.EventHandler(this.BrowseFilePath);
            // 
            // txbFilePath
            // 
            this.txbFilePath.Enabled = false;
            this.txbFilePath.Location = new System.Drawing.Point(77, 19);
            this.txbFilePath.Name = "txbFilePath";
            this.txbFilePath.Size = new System.Drawing.Size(954, 19);
            this.txbFilePath.TabIndex = 9;
            this.txbFilePath.TabStop = false;
            this.txbFilePath.TextChanged += new System.EventHandler(this.TxbFilePath_TextChanged);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(1226, 17);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(93, 23);
            this.btnReadFile.TabIndex = 8;
            this.btnReadFile.TabStop = false;
            this.btnReadFile.Text = "ファイル取込";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Visible = false;
            this.btnReadFile.Click += new System.EventHandler(this.BtnReadFile_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1067, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 48);
            this.button3.TabIndex = 7;
            this.button3.TabStop = false;
            this.button3.Text = "DB取得";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnLoadDB);
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(6, 210);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowTemplate.Height = 21;
            this.datagrid.Size = new System.Drawing.Size(1164, 433);
            this.datagrid.TabIndex = 6;
            this.datagrid.TabStop = false;
            // 
            // txbSearch1
            // 
            this.txbSearch1.Location = new System.Drawing.Point(13, 25);
            this.txbSearch1.Name = "txbSearch1";
            this.txbSearch1.Size = new System.Drawing.Size(120, 19);
            this.txbSearch1.TabIndex = 1;
            this.txbSearch1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxbSearch_KeyUp);
            // 
            // txbSearch2
            // 
            this.txbSearch2.Location = new System.Drawing.Point(200, 26);
            this.txbSearch2.Name = "txbSearch2";
            this.txbSearch2.Size = new System.Drawing.Size(120, 19);
            this.txbSearch2.TabIndex = 2;
            this.txbSearch2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxbSearch2_KeyUp);
            // 
            // txbSearch3
            // 
            this.txbSearch3.Location = new System.Drawing.Point(385, 26);
            this.txbSearch3.Name = "txbSearch3";
            this.txbSearch3.Size = new System.Drawing.Size(120, 19);
            this.txbSearch3.TabIndex = 3;
            this.txbSearch3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxbSearch3_KeyUp);
            // 
            // txbSearch4
            // 
            this.txbSearch4.Location = new System.Drawing.Point(570, 26);
            this.txbSearch4.Name = "txbSearch4";
            this.txbSearch4.Size = new System.Drawing.Size(120, 19);
            this.txbSearch4.TabIndex = 4;
            this.txbSearch4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxbSearch4_KeyUp);
            // 
            // txbSearch5
            // 
            this.txbSearch5.Location = new System.Drawing.Point(755, 27);
            this.txbSearch5.Name = "txbSearch5";
            this.txbSearch5.Size = new System.Drawing.Size(120, 19);
            this.txbSearch5.TabIndex = 5;
            this.txbSearch5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxbSearch5_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "ファイル";
            // 
            // cbx1
            // 
            this.cbx1.FormattingEnabled = true;
            this.cbx1.Items.AddRange(new object[] {
            "and",
            "or"});
            this.cbx1.Location = new System.Drawing.Point(141, 25);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(53, 20);
            this.cbx1.TabIndex = 11;
            this.cbx1.SelectedIndexChanged += new System.EventHandler(this.Cbx1_SelectedIndexChanged);
            // 
            // cbx2
            // 
            this.cbx2.FormattingEnabled = true;
            this.cbx2.Items.AddRange(new object[] {
            "and",
            "or"});
            this.cbx2.Location = new System.Drawing.Point(326, 26);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(53, 20);
            this.cbx2.TabIndex = 12;
            this.cbx2.SelectedIndexChanged += new System.EventHandler(this.Cbx2_SelectedIndexChanged);
            // 
            // cbx3
            // 
            this.cbx3.FormattingEnabled = true;
            this.cbx3.Items.AddRange(new object[] {
            "and",
            "or"});
            this.cbx3.Location = new System.Drawing.Point(511, 26);
            this.cbx3.Name = "cbx3";
            this.cbx3.Size = new System.Drawing.Size(53, 20);
            this.cbx3.TabIndex = 13;
            this.cbx3.SelectedIndexChanged += new System.EventHandler(this.Cbx3_SelectedIndexChanged);
            // 
            // cbx4
            // 
            this.cbx4.FormattingEnabled = true;
            this.cbx4.Items.AddRange(new object[] {
            "and",
            "or"});
            this.cbx4.Location = new System.Drawing.Point(696, 26);
            this.cbx4.Name = "cbx4";
            this.cbx4.Size = new System.Drawing.Size(53, 20);
            this.cbx4.TabIndex = 14;
            this.cbx4.SelectedIndexChanged += new System.EventHandler(this.Cbx4_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1067, 121);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 54);
            this.btnClear.TabIndex = 16;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "取消";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // tabDocs
            // 
            this.tabDocs.Controls.Add(this.tabPage1);
            this.tabDocs.Controls.Add(this.tabPage2);
            this.tabDocs.Controls.Add(this.tabPage3);
            this.tabDocs.Location = new System.Drawing.Point(-3, 12);
            this.tabDocs.Name = "tabDocs";
            this.tabDocs.SelectedIndex = 0;
            this.tabDocs.Size = new System.Drawing.Size(1289, 701);
            this.tabDocs.TabIndex = 17;
            this.tabDocs.SelectedIndexChanged += new System.EventHandler(this.TabDocs_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.datagrid);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txbFilePath);
            this.tabPage1.Controls.Add(this.btnChooseFilePath);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnReadFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1281, 675);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "例文参照";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdioMess);
            this.groupBox2.Controls.Add(this.rdioSentence);
            this.groupBox2.Location = new System.Drawing.Point(77, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(954, 57);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DB取得";
            // 
            // rdioMess
            // 
            this.rdioMess.AutoSize = true;
            this.rdioMess.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdioMess.Location = new System.Drawing.Point(95, 28);
            this.rdioMess.Name = "rdioMess";
            this.rdioMess.Size = new System.Drawing.Size(99, 16);
            this.rdioMess.TabIndex = 18;
            this.rdioMess.Text = "メッセージ例文";
            this.rdioMess.UseVisualStyleBackColor = true;
            this.rdioMess.CheckedChanged += new System.EventHandler(this.RdioMess_CheckedChanged);
            // 
            // rdioSentence
            // 
            this.rdioSentence.AutoSize = true;
            this.rdioSentence.Checked = true;
            this.rdioSentence.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdioSentence.Location = new System.Drawing.Point(13, 28);
            this.rdioSentence.Name = "rdioSentence";
            this.rdioSentence.Size = new System.Drawing.Size(75, 16);
            this.rdioSentence.TabIndex = 17;
            this.rdioSentence.TabStop = true;
            this.rdioSentence.Text = "設計例文";
            this.rdioSentence.UseVisualStyleBackColor = true;
            this.rdioSentence.CheckedChanged += new System.EventHandler(this.RdioSentence_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1229, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 40);
            this.button4.TabIndex = 22;
            this.button4.Text = "delete message data (test)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1229, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 44);
            this.button2.TabIndex = 21;
            this.button2.Text = "delete sentence data (test)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1229, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "delete all data (test)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbSearch5);
            this.groupBox1.Controls.Add(this.cbx1);
            this.groupBox1.Controls.Add(this.cbx4);
            this.groupBox1.Controls.Add(this.txbSearch4);
            this.groupBox1.Controls.Add(this.cbx3);
            this.groupBox1.Controls.Add(this.cbx2);
            this.groupBox1.Controls.Add(this.txbSearch3);
            this.groupBox1.Controls.Add(this.txbSearch2);
            this.groupBox1.Controls.Add(this.txbSearch1);
            this.groupBox1.Location = new System.Drawing.Point(77, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 60);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索条件";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txbLogicSearch1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.btnAddLogic);
            this.tabPage2.Controls.Add(this.btnLogicEdit);
            this.tabPage2.Controls.Add(this.btnLogicDelete);
            this.tabPage2.Controls.Add(this.datagrdLogicR);
            this.tabPage2.Controls.Add(this.treeviewR);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1281, 675);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ロジック参照";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(637, 599);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 40);
            this.button5.TabIndex = 9;
            this.button5.Text = "削除";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(241, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "絞込";
            // 
            // txbLogicSearch1
            // 
            this.txbLogicSearch1.Location = new System.Drawing.Point(276, 20);
            this.txbLogicSearch1.Name = "txbLogicSearch1";
            this.txbLogicSearch1.Size = new System.Drawing.Size(355, 19);
            this.txbLogicSearch1.TabIndex = 7;
            this.txbLogicSearch1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbLogicSearch1_KeyUp);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.linkFile3);
            this.panel1.Controls.Add(this.linkFile2);
            this.panel1.Controls.Add(this.linkFile1);
            this.panel1.Controls.Add(this.lbLogicRTitle);
            this.panel1.Controls.Add(this.txbLogic);
            this.panel1.Location = new System.Drawing.Point(637, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 571);
            this.panel1.TabIndex = 4;
            // 
            // linkFile3
            // 
            this.linkFile3.AutoSize = true;
            this.linkFile3.Location = new System.Drawing.Point(4, 534);
            this.linkFile3.Name = "linkFile3";
            this.linkFile3.Size = new System.Drawing.Size(56, 12);
            this.linkFile3.TabIndex = 15;
            this.linkFile3.TabStop = true;
            this.linkFile3.Text = "linkLabel1";
            this.linkFile3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkFile3_LinkClicked);
            // 
            // linkFile2
            // 
            this.linkFile2.AutoSize = true;
            this.linkFile2.Location = new System.Drawing.Point(4, 508);
            this.linkFile2.Name = "linkFile2";
            this.linkFile2.Size = new System.Drawing.Size(56, 12);
            this.linkFile2.TabIndex = 14;
            this.linkFile2.TabStop = true;
            this.linkFile2.Text = "linkLabel1";
            this.linkFile2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkFile2_LinkClicked);
            // 
            // linkFile1
            // 
            this.linkFile1.AutoSize = true;
            this.linkFile1.Location = new System.Drawing.Point(4, 483);
            this.linkFile1.Name = "linkFile1";
            this.linkFile1.Size = new System.Drawing.Size(56, 12);
            this.linkFile1.TabIndex = 13;
            this.linkFile1.TabStop = true;
            this.linkFile1.Text = "linkLabel1";
            this.linkFile1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkFile1_LinkClicked);
            // 
            // lbLogicRTitle
            // 
            this.lbLogicRTitle.AutoSize = true;
            this.lbLogicRTitle.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbLogicRTitle.Location = new System.Drawing.Point(3, 7);
            this.lbLogicRTitle.Name = "lbLogicRTitle";
            this.lbLogicRTitle.Size = new System.Drawing.Size(635, 12);
            this.lbLogicRTitle.TabIndex = 4;
            this.lbLogicRTitle.Text = "１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０";
            // 
            // txbLogic
            // 
            this.txbLogic.Location = new System.Drawing.Point(9, 24);
            this.txbLogic.Multiline = true;
            this.txbLogic.Name = "txbLogic";
            this.txbLogic.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbLogic.Size = new System.Drawing.Size(629, 450);
            this.txbLogic.TabIndex = 3;
            // 
            // btnAddLogic
            // 
            this.btnAddLogic.Location = new System.Drawing.Point(276, 599);
            this.btnAddLogic.Name = "btnAddLogic";
            this.btnAddLogic.Size = new System.Drawing.Size(89, 40);
            this.btnAddLogic.TabIndex = 6;
            this.btnAddLogic.Text = "追加";
            this.btnAddLogic.UseVisualStyleBackColor = true;
            this.btnAddLogic.Click += new System.EventHandler(this.BtnAddLogic_Click);
            // 
            // button6
            // 
            this.btnLogicEdit.Location = new System.Drawing.Point(402, 599);
            this.btnLogicEdit.Name = "button6";
            this.btnLogicEdit.Size = new System.Drawing.Size(84, 40);
            this.btnLogicEdit.TabIndex = 3;
            this.btnLogicEdit.Text = "修正";
            this.btnLogicEdit.UseVisualStyleBackColor = true;
            this.btnLogicEdit.Click += new System.EventHandler(this.BtnEditLogic);
            // 
            // btnDelete
            // 
            this.btnLogicDelete.Location = new System.Drawing.Point(521, 599);
            this.btnLogicDelete.Name = "btnDelete";
            this.btnLogicDelete.Size = new System.Drawing.Size(84, 40);
            this.btnLogicDelete.TabIndex = 2;
            this.btnLogicDelete.Text = "削除";
            this.btnLogicDelete.UseVisualStyleBackColor = true;
            this.btnLogicDelete.Click += new System.EventHandler(this.BtnLogicDelete);
            // 
            // datagrdLogicR
            // 
            this.datagrdLogicR.AllowUserToAddRows = false;
            this.datagrdLogicR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagrdLogicR.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrdLogicR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdLogicR.Location = new System.Drawing.Point(241, 45);
            this.datagrdLogicR.MultiSelect = false;
            this.datagrdLogicR.Name = "datagrdLogicR";
            this.datagrdLogicR.ReadOnly = true;
            this.datagrdLogicR.RowTemplate.Height = 21;
            this.datagrdLogicR.Size = new System.Drawing.Size(390, 532);
            this.datagrdLogicR.TabIndex = 1;
            this.datagrdLogicR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagrdLogicR_CellClick);
            this.datagrdLogicR.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrdLogicR_CellEnter_1);
            this.datagrdLogicR.SelectionChanged += new System.EventHandler(this.DatagrdLogicR_SelectionChanged);
            // 
            // treeviewR
            // 
            this.treeviewR.Location = new System.Drawing.Point(6, 6);
            this.treeviewR.Name = "treeviewR";
            this.treeviewR.Size = new System.Drawing.Size(229, 633);
            this.treeviewR.TabIndex = 0;
            this.treeviewR.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TreeviewR_AfterCollapse);
            this.treeviewR.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeviewR_AfterExpand);
            this.treeviewR.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeviewR_AfterSelect);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txbResult);
            this.tabPage3.Controls.Add(this.txbTest);
            this.tabPage3.Controls.Add(this.lbTest);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1281, 675);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(556, 27);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(258, 19);
            this.txbResult.TabIndex = 3;
            // 
            // txbTest
            // 
            this.txbTest.Location = new System.Drawing.Point(425, 27);
            this.txbTest.Name = "txbTest";
            this.txbTest.Size = new System.Drawing.Size(100, 19);
            this.txbTest.TabIndex = 2;
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Location = new System.Drawing.Point(354, 30);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(35, 12);
            this.lbTest.TabIndex = 1;
            this.lbTest.Text = "label2";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(256, 25);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 685);
            this.Controls.Add(this.tabDocs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "検索ツール";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.tabDocs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdLogicR)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFilePath;
        private System.Windows.Forms.TextBox txbFilePath;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.TextBox txbSearch1;
        private System.Windows.Forms.TextBox txbSearch2;
        private System.Windows.Forms.TextBox txbSearch3;
        private System.Windows.Forms.TextBox txbSearch4;
        private System.Windows.Forms.TextBox txbSearch5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx1;
        private System.Windows.Forms.ComboBox cbx2;
        private System.Windows.Forms.ComboBox cbx3;
        private System.Windows.Forms.ComboBox cbx4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabControl tabDocs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rdioMess;
        private System.Windows.Forms.RadioButton rdioSentence;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView treeviewR;
        private System.Windows.Forms.DataGridView datagrdLogicR;
        private System.Windows.Forms.Button btnLogicEdit;
        private System.Windows.Forms.Button btnLogicDelete;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txbTest;
        private System.Windows.Forms.Label lbTest;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.TextBox txbLogic;
        private System.Windows.Forms.Button btnAddLogic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbLogicRTitle;
        private System.Windows.Forms.TextBox txbLogicSearch1;
        private System.Windows.Forms.LinkLabel linkFile1;
        private System.Windows.Forms.LinkLabel linkFile3;
        private System.Windows.Forms.LinkLabel linkFile2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
    }
}


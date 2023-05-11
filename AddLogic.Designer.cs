namespace SearchDocs
{
    partial class AddLogic
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
            this.txbAddTitle = new System.Windows.Forms.TextBox();
            this.btnAddFilePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbLogic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddRegister = new System.Windows.Forms.Button();
            this.cbxAddGroup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxAddSubGroup = new System.Windows.Forms.ComboBox();
            this.cbxAddAssembly = new System.Windows.Forms.ComboBox();
            this.lblUploadFile1 = new System.Windows.Forms.Label();
            this.lblUploadFile2 = new System.Windows.Forms.Label();
            this.lblUploadFile3 = new System.Windows.Forms.Label();
            this.btndeleteFile1 = new System.Windows.Forms.Button();
            this.btndeleteFile2 = new System.Windows.Forms.Button();
            this.btndeleteFile3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbAddTitle
            // 
            this.txbAddTitle.Location = new System.Drawing.Point(81, 101);
            this.txbAddTitle.Name = "txbAddTitle";
            this.txbAddTitle.Size = new System.Drawing.Size(601, 19);
            this.txbAddTitle.TabIndex = 4;
            // 
            // btnAddFilePath
            // 
            this.btnAddFilePath.Location = new System.Drawing.Point(81, 450);
            this.btnAddFilePath.Name = "btnAddFilePath";
            this.btnAddFilePath.Size = new System.Drawing.Size(62, 71);
            this.btnAddFilePath.TabIndex = 6;
            this.btnAddFilePath.Text = "参照";
            this.btnAddFilePath.UseVisualStyleBackColor = true;
            this.btnAddFilePath.Click += new System.EventHandler(this.BrowseFilePath);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "タイトル";
            // 
            // txbLogic
            // 
            this.txbLogic.Location = new System.Drawing.Point(81, 126);
            this.txbLogic.Multiline = true;
            this.txbLogic.Name = "txbLogic";
            this.txbLogic.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbLogic.Size = new System.Drawing.Size(601, 318);
            this.txbLogic.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "内容";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "ファイル";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(244, 560);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddCancel.TabIndex = 7;
            this.btnAddCancel.TabStop = false;
            this.btnAddCancel.Text = "キャンセル";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.BtnAddCancel_Click);
            // 
            // btnAddRegister
            // 
            this.btnAddRegister.Location = new System.Drawing.Point(381, 560);
            this.btnAddRegister.Name = "btnAddRegister";
            this.btnAddRegister.Size = new System.Drawing.Size(75, 23);
            this.btnAddRegister.TabIndex = 8;
            this.btnAddRegister.TabStop = false;
            this.btnAddRegister.Text = "登録";
            this.btnAddRegister.UseVisualStyleBackColor = true;
            this.btnAddRegister.Click += new System.EventHandler(this.BtnAddRegister_Click);
            // 
            // cbxAddGroup
            // 
            this.cbxAddGroup.FormattingEnabled = true;
            this.cbxAddGroup.Location = new System.Drawing.Point(81, 13);
            this.cbxAddGroup.Name = "cbxAddGroup";
            this.cbxAddGroup.Size = new System.Drawing.Size(238, 20);
            this.cbxAddGroup.TabIndex = 1;
            this.cbxAddGroup.SelectedIndexChanged += new System.EventHandler(this.CbxAddGroup_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "大分類";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "中分類";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "画面";
            // 
            // cbxAddSubGroup
            // 
            this.cbxAddSubGroup.FormattingEnabled = true;
            this.cbxAddSubGroup.Location = new System.Drawing.Point(81, 39);
            this.cbxAddSubGroup.Name = "cbxAddSubGroup";
            this.cbxAddSubGroup.Size = new System.Drawing.Size(238, 20);
            this.cbxAddSubGroup.TabIndex = 2;
            this.cbxAddSubGroup.SelectedIndexChanged += new System.EventHandler(this.CbxAddSubGroup_SelectedIndexChanged);
            // 
            // cbxAddAssembly
            // 
            this.cbxAddAssembly.FormattingEnabled = true;
            this.cbxAddAssembly.Location = new System.Drawing.Point(81, 69);
            this.cbxAddAssembly.Name = "cbxAddAssembly";
            this.cbxAddAssembly.Size = new System.Drawing.Size(238, 20);
            this.cbxAddAssembly.TabIndex = 3;
            // 
            // lblUploadFile1
            // 
            this.lblUploadFile1.AutoSize = true;
            this.lblUploadFile1.Location = new System.Drawing.Point(185, 455);
            this.lblUploadFile1.Name = "lblUploadFile1";
            this.lblUploadFile1.Size = new System.Drawing.Size(35, 12);
            this.lblUploadFile1.TabIndex = 16;
            this.lblUploadFile1.Text = "label7";
            // 
            // lblUploadFile2
            // 
            this.lblUploadFile2.AutoSize = true;
            this.lblUploadFile2.Location = new System.Drawing.Point(185, 479);
            this.lblUploadFile2.Name = "lblUploadFile2";
            this.lblUploadFile2.Size = new System.Drawing.Size(35, 12);
            this.lblUploadFile2.TabIndex = 17;
            this.lblUploadFile2.Text = "label8";
            // 
            // lblUploadFile3
            // 
            this.lblUploadFile3.AutoSize = true;
            this.lblUploadFile3.Location = new System.Drawing.Point(185, 503);
            this.lblUploadFile3.Name = "lblUploadFile3";
            this.lblUploadFile3.Size = new System.Drawing.Size(35, 12);
            this.lblUploadFile3.TabIndex = 18;
            this.lblUploadFile3.Text = "label9";
            // 
            // btndeleteFile1
            // 
            this.btndeleteFile1.Location = new System.Drawing.Point(153, 450);
            this.btndeleteFile1.Name = "btndeleteFile1";
            this.btndeleteFile1.Size = new System.Drawing.Size(26, 23);
            this.btndeleteFile1.TabIndex = 19;
            this.btndeleteFile1.TabStop = false;
            this.btndeleteFile1.Text = "X";
            this.btndeleteFile1.UseVisualStyleBackColor = true;
            this.btndeleteFile1.Click += new System.EventHandler(this.BtndeleteFile1_Click);
            // 
            // btndeleteFile2
            // 
            this.btndeleteFile2.Location = new System.Drawing.Point(153, 474);
            this.btndeleteFile2.Name = "btndeleteFile2";
            this.btndeleteFile2.Size = new System.Drawing.Size(26, 23);
            this.btndeleteFile2.TabIndex = 20;
            this.btndeleteFile2.TabStop = false;
            this.btndeleteFile2.Text = "X";
            this.btndeleteFile2.UseVisualStyleBackColor = true;
            this.btndeleteFile2.Click += new System.EventHandler(this.BtndeleteFile2_Click);
            // 
            // btndeleteFile3
            // 
            this.btndeleteFile3.Location = new System.Drawing.Point(153, 498);
            this.btndeleteFile3.Name = "btndeleteFile3";
            this.btndeleteFile3.Size = new System.Drawing.Size(26, 23);
            this.btndeleteFile3.TabIndex = 21;
            this.btndeleteFile3.TabStop = false;
            this.btndeleteFile3.Text = "X";
            this.btndeleteFile3.UseVisualStyleBackColor = true;
            this.btndeleteFile3.Click += new System.EventHandler(this.BtndeleteFile3_Click);
            // 
            // AddLogic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 606);
            this.Controls.Add(this.btndeleteFile3);
            this.Controls.Add(this.btndeleteFile2);
            this.Controls.Add(this.btndeleteFile1);
            this.Controls.Add(this.lblUploadFile3);
            this.Controls.Add(this.lblUploadFile2);
            this.Controls.Add(this.lblUploadFile1);
            this.Controls.Add(this.cbxAddAssembly);
            this.Controls.Add(this.cbxAddSubGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxAddGroup);
            this.Controls.Add(this.btnAddRegister);
            this.Controls.Add(this.btnAddCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbLogic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddFilePath);
            this.Controls.Add(this.txbAddTitle);
            this.MaximizeBox = false;
            this.Name = "AddLogic";
            this.Text = "ロジック追加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbAddTitle;
        private System.Windows.Forms.Button btnAddFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbLogic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAddRegister;
        private System.Windows.Forms.ComboBox cbxAddGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxAddSubGroup;
        private System.Windows.Forms.ComboBox cbxAddAssembly;
        private System.Windows.Forms.Label lblUploadFile1;
        private System.Windows.Forms.Label lblUploadFile2;
        private System.Windows.Forms.Label lblUploadFile3;
        private System.Windows.Forms.Button btndeleteFile1;
        private System.Windows.Forms.Button btndeleteFile2;
        private System.Windows.Forms.Button btndeleteFile3;
    }
}
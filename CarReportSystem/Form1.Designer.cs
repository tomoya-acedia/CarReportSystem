namespace CarReportSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateDate = new System.Windows.Forms.DateTimePicker();
            this.RecordName = new System.Windows.Forms.ComboBox();
            this.toyota = new System.Windows.Forms.RadioButton();
            this.honda = new System.Windows.Forms.RadioButton();
            this.nissan = new System.Windows.Forms.RadioButton();
            this.subaru = new System.Windows.Forms.RadioButton();
            this.gaisya = new System.Windows.Forms.RadioButton();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.dgvCarData = new System.Windows.Forms.DataGridView();
            this.btKiziHiraku = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btOpenImage_Click = new System.Windows.Forms.Button();
            this.rtReport = new System.Windows.Forms.RichTextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btClearImage = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.snota = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ofdOpenData = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveData = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.すべて保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.名前を付けて保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.label2.Location = new System.Drawing.Point(44, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "メーカー";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.label3.Location = new System.Drawing.Point(44, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "記録者";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.label4.Location = new System.Drawing.Point(44, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "車名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.label5.Location = new System.Drawing.Point(44, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "レポート";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.label6.Location = new System.Drawing.Point(44, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "記事一覧";
            // 
            // CreateDate
            // 
            this.CreateDate.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.CreateDate.Location = new System.Drawing.Point(149, 39);
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Size = new System.Drawing.Size(200, 26);
            this.CreateDate.TabIndex = 1;
            // 
            // RecordName
            // 
            this.RecordName.FormattingEnabled = true;
            this.RecordName.Location = new System.Drawing.Point(149, 97);
            this.RecordName.Name = "RecordName";
            this.RecordName.Size = new System.Drawing.Size(121, 20);
            this.RecordName.TabIndex = 3;
            // 
            // toyota
            // 
            this.toyota.AutoSize = true;
            this.toyota.Location = new System.Drawing.Point(149, 156);
            this.toyota.Name = "toyota";
            this.toyota.Size = new System.Drawing.Size(47, 16);
            this.toyota.TabIndex = 4;
            this.toyota.TabStop = true;
            this.toyota.Text = "トヨタ";
            this.toyota.UseVisualStyleBackColor = true;
            // 
            // honda
            // 
            this.honda.AutoSize = true;
            this.honda.Location = new System.Drawing.Point(255, 156);
            this.honda.Name = "honda";
            this.honda.Size = new System.Drawing.Size(51, 16);
            this.honda.TabIndex = 5;
            this.honda.TabStop = true;
            this.honda.Text = "ホンダ";
            this.honda.UseVisualStyleBackColor = true;
            // 
            // nissan
            // 
            this.nissan.AutoSize = true;
            this.nissan.Location = new System.Drawing.Point(202, 156);
            this.nissan.Name = "nissan";
            this.nissan.Size = new System.Drawing.Size(47, 16);
            this.nissan.TabIndex = 7;
            this.nissan.TabStop = true;
            this.nissan.Text = "日産";
            this.nissan.UseVisualStyleBackColor = true;
            // 
            // subaru
            // 
            this.subaru.AutoSize = true;
            this.subaru.Location = new System.Drawing.Point(312, 156);
            this.subaru.Name = "subaru";
            this.subaru.Size = new System.Drawing.Size(52, 16);
            this.subaru.TabIndex = 8;
            this.subaru.TabStop = true;
            this.subaru.Text = "スバル";
            this.subaru.UseVisualStyleBackColor = true;
            // 
            // gaisya
            // 
            this.gaisya.AutoSize = true;
            this.gaisya.Location = new System.Drawing.Point(370, 156);
            this.gaisya.Name = "gaisya";
            this.gaisya.Size = new System.Drawing.Size(47, 16);
            this.gaisya.TabIndex = 10;
            this.gaisya.TabStop = true;
            this.gaisya.Text = "外車";
            this.gaisya.UseVisualStyleBackColor = true;
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(149, 206);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(121, 20);
            this.cbCarName.TabIndex = 3;
            // 
            // dgvCarData
            // 
            this.dgvCarData.AllowUserToAddRows = false;
            this.dgvCarData.AllowUserToDeleteRows = false;
            this.dgvCarData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarData.Location = new System.Drawing.Point(135, 364);
            this.dgvCarData.MultiSelect = false;
            this.dgvCarData.Name = "dgvCarData";
            this.dgvCarData.ReadOnly = true;
            this.dgvCarData.RowTemplate.Height = 21;
            this.dgvCarData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarData.Size = new System.Drawing.Size(713, 243);
            this.dgvCarData.TabIndex = 11;
            this.dgvCarData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarData_Click);
            this.dgvCarData.Click += new System.EventHandler(this.dgvCarData_Click);
            // 
            // btKiziHiraku
            // 
            this.btKiziHiraku.Location = new System.Drawing.Point(54, 405);
            this.btKiziHiraku.Name = "btKiziHiraku";
            this.btKiziHiraku.Size = new System.Drawing.Size(58, 23);
            this.btKiziHiraku.TabIndex = 12;
            this.btKiziHiraku.Text = "開く";
            this.btKiziHiraku.UseVisualStyleBackColor = true;
            this.btKiziHiraku.Click += new System.EventHandler(this.btKiziHiraku_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(54, 446);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(58, 23);
            this.btSave.TabIndex = 13;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(553, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "画像";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.label8.Location = new System.Drawing.Point(1152, -340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "画像";
            // 
            // btOpenImage_Click
            // 
            this.btOpenImage_Click.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btOpenImage_Click.Location = new System.Drawing.Point(609, 39);
            this.btOpenImage_Click.Name = "btOpenImage_Click";
            this.btOpenImage_Click.Size = new System.Drawing.Size(75, 23);
            this.btOpenImage_Click.TabIndex = 12;
            this.btOpenImage_Click.Text = "開く";
            this.btOpenImage_Click.UseVisualStyleBackColor = false;
            this.btOpenImage_Click.Click += new System.EventHandler(this.button3_Click);
            // 
            // rtReport
            // 
            this.rtReport.Location = new System.Drawing.Point(139, 250);
            this.rtReport.Name = "rtReport";
            this.rtReport.Size = new System.Drawing.Size(709, 96);
            this.rtReport.TabIndex = 15;
            this.rtReport.Text = "";
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(574, 72);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(247, 143);
            this.pbImage.TabIndex = 16;
            this.pbImage.TabStop = false;
            // 
            // btClearImage
            // 
            this.btClearImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btClearImage.Location = new System.Drawing.Point(690, 39);
            this.btClearImage.Name = "btClearImage";
            this.btClearImage.Size = new System.Drawing.Size(75, 23);
            this.btClearImage.TabIndex = 17;
            this.btClearImage.Text = "削除";
            this.btClearImage.UseVisualStyleBackColor = false;
            this.btClearImage.Click += new System.EventHandler(this.btClearImage_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btAdd.Location = new System.Drawing.Point(584, 221);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btModify
            // 
            this.btModify.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btModify.Location = new System.Drawing.Point(665, 221);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(75, 23);
            this.btModify.TabIndex = 17;
            this.btModify.Text = "修正";
            this.btModify.UseVisualStyleBackColor = false;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btDelete.Location = new System.Drawing.Point(746, 221);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 18;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btExit.Location = new System.Drawing.Point(746, 613);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 19;
            this.btExit.Text = "終了";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // ofdOpenImage
            // 
            this.ofdOpenImage.FileName = "openFileDialog1";
            // 
            // snota
            // 
            this.snota.AutoSize = true;
            this.snota.Location = new System.Drawing.Point(423, 156);
            this.snota.Name = "snota";
            this.snota.Size = new System.Drawing.Size(54, 16);
            this.snota.TabIndex = 20;
            this.snota.TabStop = true;
            this.snota.Text = "その他";
            this.snota.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(139, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 43);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ofdOpenData
            // 
            this.ofdOpenData.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1053, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規作成ToolStripMenuItem,
            this.toolStripSeparator2,
            this.開くToolStripMenuItem,
            this.toolStripSeparator4,
            this.すべて保存ToolStripMenuItem,
            this.toolStripSeparator3,
            this.名前を付けて保存ToolStripMenuItem,
            this.toolStripSeparator1,
            this.終了XToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 新規作成ToolStripMenuItem
            // 
            this.新規作成ToolStripMenuItem.Name = "新規作成ToolStripMenuItem";
            this.新規作成ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新規作成ToolStripMenuItem.Text = "新規作成";
            this.新規作成ToolStripMenuItem.Click += new System.EventHandler(this.新規作成ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.開くToolStripMenuItem.Text = "開く";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // すべて保存ToolStripMenuItem
            // 
            this.すべて保存ToolStripMenuItem.Enabled = false;
            this.すべて保存ToolStripMenuItem.Name = "すべて保存ToolStripMenuItem";
            this.すべて保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.すべて保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.すべて保存ToolStripMenuItem.Text = "保存";
            this.すべて保存ToolStripMenuItem.Click += new System.EventHandler(this.すべて保存ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // 名前を付けて保存ToolStripMenuItem
            // 
            this.名前を付けて保存ToolStripMenuItem.Name = "名前を付けて保存ToolStripMenuItem";
            this.名前を付けて保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.名前を付けて保存ToolStripMenuItem.Text = "名前を付けて保存(A)";
            this.名前を付けて保存ToolStripMenuItem.Click += new System.EventHandler(this.名前を付けて保存ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 656);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.snota);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.btClearImage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.rtReport);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpenImage_Click);
            this.Controls.Add(this.btKiziHiraku);
            this.Controls.Add(this.dgvCarData);
            this.Controls.Add(this.gaisya);
            this.Controls.Add(this.subaru);
            this.Controls.Add(this.nissan);
            this.Controls.Add(this.honda);
            this.Controls.Add(this.toyota);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.RecordName);
            this.Controls.Add(this.CreateDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker CreateDate;
        private System.Windows.Forms.ComboBox RecordName;
        private System.Windows.Forms.RadioButton toyota;
        private System.Windows.Forms.RadioButton honda;
        private System.Windows.Forms.RadioButton nissan;
        private System.Windows.Forms.RadioButton subaru;
        private System.Windows.Forms.RadioButton gaisya;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.DataGridView dgvCarData;
        private System.Windows.Forms.Button btKiziHiraku;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btOpenImage_Click;
        private System.Windows.Forms.RichTextBox rtReport;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btClearImage;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.RadioButton snota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog ofdOpenData;
        private System.Windows.Forms.SaveFileDialog sfdSaveData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新規作成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem すべて保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}


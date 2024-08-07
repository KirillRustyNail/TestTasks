namespace BDApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ExucProcBut = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPersent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Choosetable = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpdateBut = new System.Windows.Forms.Button();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.searchtext = new System.Windows.Forms.TextBox();
            this.CreateBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(33, 153);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(521, 207);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.TabStop = false;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // ExucProcBut
            // 
            this.ExucProcBut.Location = new System.Drawing.Point(25, 97);
            this.ExucProcBut.Name = "ExucProcBut";
            this.ExucProcBut.Size = new System.Drawing.Size(150, 23);
            this.ExucProcBut.TabIndex = 2;
            this.ExucProcBut.Text = "Выполнить процедуру";
            this.ExucProcBut.UseVisualStyleBackColor = true;
            this.ExucProcBut.Click += new System.EventHandler(this.ExucProcBut_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(22, 30);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "ID:";
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(22, 59);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(47, 13);
            this.labelPercent.TabIndex = 3;
            this.labelPercent.Text = "Percent:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(75, 27);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 4;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // textBoxPersent
            // 
            this.textBoxPersent.Location = new System.Drawing.Point(75, 56);
            this.textBoxPersent.Name = "textBoxPersent";
            this.textBoxPersent.Size = new System.Drawing.Size(100, 20);
            this.textBoxPersent.TabIndex = 4;
            this.textBoxPersent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.textBoxPersent);
            this.groupBox1.Controls.Add(this.ExucProcBut);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.labelPercent);
            this.groupBox1.Location = new System.Drawing.Point(344, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Процедура увеличение зарплаты";
            // 
            // Choosetable
            // 
            this.Choosetable.FormattingEnabled = true;
            this.Choosetable.Items.AddRange(new object[] {
            "Department",
            "Employee"});
            this.Choosetable.Location = new System.Drawing.Point(34, 38);
            this.Choosetable.Name = "Choosetable";
            this.Choosetable.Size = new System.Drawing.Size(121, 21);
            this.Choosetable.TabIndex = 6;
            this.Choosetable.SelectedIndexChanged += new System.EventHandler(this.Choosetable_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(294, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateBut
            // 
            this.UpdateBut.Location = new System.Drawing.Point(115, 80);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.Size = new System.Drawing.Size(75, 23);
            this.UpdateBut.TabIndex = 10;
            this.UpdateBut.Text = "Update";
            this.UpdateBut.UseVisualStyleBackColor = true;
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(196, 79);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(75, 23);
            this.DeleteBut.TabIndex = 9;
            this.DeleteBut.Text = "Delete";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // searchtext
            // 
            this.searchtext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.searchtext.Location = new System.Drawing.Point(174, 39);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(114, 20);
            this.searchtext.TabIndex = 8;
            this.searchtext.TextChanged += new System.EventHandler(this.searchtext_TextChanged);
            // 
            // CreateBut
            // 
            this.CreateBut.Location = new System.Drawing.Point(34, 80);
            this.CreateBut.Name = "CreateBut";
            this.CreateBut.Size = new System.Drawing.Size(75, 23);
            this.CreateBut.TabIndex = 7;
            this.CreateBut.Text = "Create";
            this.CreateBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CreateBut.UseVisualStyleBackColor = true;
            this.CreateBut.Click += new System.EventHandler(this.CreateBut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 408);
            this.Controls.Add(this.Choosetable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.searchtext);
            this.Controls.Add(this.CreateBut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "WorkersDB";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ExucProcBut;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPersent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Choosetable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UpdateBut;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.TextBox searchtext;
        private System.Windows.Forms.Button CreateBut;
    }
}


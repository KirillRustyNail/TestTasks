namespace BDApplication.Forms
{
    partial class AddEmployee
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.Department_id_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Chief_id_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Salary_text = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Controls.Add(this.Salary_text);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Name_text);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Chief_id_text);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Department_id_text);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(25, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 298);
            this.panel2.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(93, 219);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Department_id_text
            // 
            this.Department_id_text.Location = new System.Drawing.Point(119, 28);
            this.Department_id_text.Name = "Department_id_text";
            this.Department_id_text.Size = new System.Drawing.Size(111, 20);
            this.Department_id_text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEPARTMENT_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CHIEF_ID";
            // 
            // Chief_id_text
            // 
            this.Chief_id_text.Location = new System.Drawing.Point(119, 54);
            this.Chief_id_text.Name = "Chief_id_text";
            this.Chief_id_text.Size = new System.Drawing.Size(111, 20);
            this.Chief_id_text.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "NAME";
            // 
            // Name_text
            // 
            this.Name_text.Location = new System.Drawing.Point(119, 80);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(111, 20);
            this.Name_text.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "SALARY";
            // 
            // Salary_text
            // 
            this.Salary_text.Location = new System.Drawing.Point(119, 106);
            this.Salary_text.Name = "Salary_text";
            this.Salary_text.Size = new System.Drawing.Size(111, 20);
            this.Salary_text.TabIndex = 1;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 337);
            this.Controls.Add(this.panel2);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox Department_id_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Salary_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Name_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Chief_id_text;
        private System.Windows.Forms.Label label2;
    }
}
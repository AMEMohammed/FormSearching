namespace FrmSearching
{
    partial class FormSearching
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labTitleSearch = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comBoxColumn4 = new System.Windows.Forms.ComboBox();
            this.comBoxLogic4 = new System.Windows.Forms.ComboBox();
            this.txtSearching4 = new System.Windows.Forms.TextBox();
            this.comBoxOprat4 = new System.Windows.Forms.ComboBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearching3 = new System.Windows.Forms.TextBox();
            this.comBoxLogic3 = new System.Windows.Forms.ComboBox();
            this.comBoxColumn3 = new System.Windows.Forms.ComboBox();
            this.comBoxOprat3 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comBoxColumn2 = new System.Windows.Forms.ComboBox();
            this.comBoxLogic2 = new System.Windows.Forms.ComboBox();
            this.txtSearching2 = new System.Windows.Forms.TextBox();
            this.comBoxOprat2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comBoxLogic1 = new System.Windows.Forms.ComboBox();
            this.comBoxColumn1 = new System.Windows.Forms.ComboBox();
            this.comBoxOprat1 = new System.Windows.Forms.ComboBox();
            this.txtSearching1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labResult = new System.Windows.Forms.Label();
            this.btnExite = new System.Windows.Forms.Button();
            this.btnNewSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labTitleSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 40);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // labTitleSearch
            // 
            this.labTitleSearch.AutoSize = true;
            this.labTitleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitleSearch.Location = new System.Drawing.Point(183, 14);
            this.labTitleSearch.Name = "labTitleSearch";
            this.labTitleSearch.Size = new System.Drawing.Size(66, 17);
            this.labTitleSearch.TabIndex = 0;
            this.labTitleSearch.Text = "عنوان البحث";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "شروط البحث ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(399, 107);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comBoxColumn4);
            this.panel4.Controls.Add(this.comBoxLogic4);
            this.panel4.Controls.Add(this.txtSearching4);
            this.panel4.Controls.Add(this.comBoxOprat4);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(3, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 31);
            this.panel4.TabIndex = 23;
            // 
            // comBoxColumn4
            // 
            this.comBoxColumn4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxColumn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxColumn4.FormattingEnabled = true;
            this.comBoxColumn4.Location = new System.Drawing.Point(231, 3);
            this.comBoxColumn4.Name = "comBoxColumn4";
            this.comBoxColumn4.Size = new System.Drawing.Size(124, 24);
            this.comBoxColumn4.TabIndex = 11;
            // 
            // comBoxLogic4
            // 
            this.comBoxLogic4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLogic4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxLogic4.FormattingEnabled = true;
            this.comBoxLogic4.Items.AddRange(new object[] {
            "و",
            "او"});
            this.comBoxLogic4.Location = new System.Drawing.Point(358, 3);
            this.comBoxLogic4.Name = "comBoxLogic4";
            this.comBoxLogic4.Size = new System.Drawing.Size(32, 24);
            this.comBoxLogic4.TabIndex = 6;
            // 
            // txtSearching4
            // 
            this.txtSearching4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearching4.Location = new System.Drawing.Point(6, 3);
            this.txtSearching4.Name = "txtSearching4";
            this.txtSearching4.Size = new System.Drawing.Size(148, 23);
            this.txtSearching4.TabIndex = 19;
            // 
            // comBoxOprat4
            // 
            this.comBoxOprat4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxOprat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxOprat4.FormattingEnabled = true;
            this.comBoxOprat4.Items.AddRange(new object[] {
            "يحتوي",
            "يساوي",
            "لايساوي"});
            this.comBoxOprat4.Location = new System.Drawing.Point(160, 3);
            this.comBoxOprat4.Name = "comBoxOprat4";
            this.comBoxOprat4.Size = new System.Drawing.Size(68, 24);
            this.comBoxOprat4.TabIndex = 15;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(399, 144);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSearching3);
            this.panel3.Controls.Add(this.comBoxLogic3);
            this.panel3.Controls.Add(this.comBoxColumn3);
            this.panel3.Controls.Add(this.comBoxOprat3);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(6, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 32);
            this.panel3.TabIndex = 22;
            // 
            // txtSearching3
            // 
            this.txtSearching3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearching3.Location = new System.Drawing.Point(3, 4);
            this.txtSearching3.Name = "txtSearching3";
            this.txtSearching3.Size = new System.Drawing.Size(148, 23);
            this.txtSearching3.TabIndex = 18;
            // 
            // comBoxLogic3
            // 
            this.comBoxLogic3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLogic3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxLogic3.FormattingEnabled = true;
            this.comBoxLogic3.Items.AddRange(new object[] {
            "و",
            "او"});
            this.comBoxLogic3.Location = new System.Drawing.Point(355, 4);
            this.comBoxLogic3.Name = "comBoxLogic3";
            this.comBoxLogic3.Size = new System.Drawing.Size(32, 24);
            this.comBoxLogic3.TabIndex = 4;
            // 
            // comBoxColumn3
            // 
            this.comBoxColumn3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxColumn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxColumn3.FormattingEnabled = true;
            this.comBoxColumn3.Location = new System.Drawing.Point(228, 4);
            this.comBoxColumn3.Name = "comBoxColumn3";
            this.comBoxColumn3.Size = new System.Drawing.Size(124, 24);
            this.comBoxColumn3.TabIndex = 10;
            // 
            // comBoxOprat3
            // 
            this.comBoxOprat3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxOprat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxOprat3.FormattingEnabled = true;
            this.comBoxOprat3.Items.AddRange(new object[] {
            "يحتوي",
            "يساوي",
            "لايساوي"});
            this.comBoxOprat3.Location = new System.Drawing.Point(157, 4);
            this.comBoxOprat3.Name = "comBoxOprat3";
            this.comBoxOprat3.Size = new System.Drawing.Size(68, 24);
            this.comBoxOprat3.TabIndex = 14;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(399, 69);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comBoxColumn2);
            this.panel2.Controls.Add(this.comBoxLogic2);
            this.panel2.Controls.Add(this.txtSearching2);
            this.panel2.Controls.Add(this.comBoxOprat2);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(6, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 34);
            this.panel2.TabIndex = 21;
            // 
            // comBoxColumn2
            // 
            this.comBoxColumn2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxColumn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxColumn2.FormattingEnabled = true;
            this.comBoxColumn2.Location = new System.Drawing.Point(228, 5);
            this.comBoxColumn2.Name = "comBoxColumn2";
            this.comBoxColumn2.Size = new System.Drawing.Size(124, 24);
            this.comBoxColumn2.TabIndex = 9;
            // 
            // comBoxLogic2
            // 
            this.comBoxLogic2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLogic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxLogic2.FormattingEnabled = true;
            this.comBoxLogic2.Items.AddRange(new object[] {
            "و",
            "او"});
            this.comBoxLogic2.Location = new System.Drawing.Point(355, 5);
            this.comBoxLogic2.Name = "comBoxLogic2";
            this.comBoxLogic2.Size = new System.Drawing.Size(32, 24);
            this.comBoxLogic2.TabIndex = 2;
            // 
            // txtSearching2
            // 
            this.txtSearching2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearching2.Location = new System.Drawing.Point(3, 5);
            this.txtSearching2.Name = "txtSearching2";
            this.txtSearching2.Size = new System.Drawing.Size(148, 23);
            this.txtSearching2.TabIndex = 17;
            // 
            // comBoxOprat2
            // 
            this.comBoxOprat2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxOprat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxOprat2.FormattingEnabled = true;
            this.comBoxOprat2.Items.AddRange(new object[] {
            "يحتوي",
            "يساوي",
            "لايساوي"});
            this.comBoxOprat2.Location = new System.Drawing.Point(157, 5);
            this.comBoxOprat2.Name = "comBoxOprat2";
            this.comBoxOprat2.Size = new System.Drawing.Size(68, 24);
            this.comBoxOprat2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.comBoxLogic1);
            this.panel1.Controls.Add(this.comBoxColumn1);
            this.panel1.Controls.Add(this.comBoxOprat1);
            this.panel1.Controls.Add(this.txtSearching1);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 34);
            this.panel1.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(393, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comBoxLogic1
            // 
            this.comBoxLogic1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLogic1.Enabled = false;
            this.comBoxLogic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxLogic1.FormattingEnabled = true;
            this.comBoxLogic1.Items.AddRange(new object[] {
            "و\t",
            "او"});
            this.comBoxLogic1.Location = new System.Drawing.Point(355, 5);
            this.comBoxLogic1.Name = "comBoxLogic1";
            this.comBoxLogic1.Size = new System.Drawing.Size(32, 24);
            this.comBoxLogic1.TabIndex = 0;
            // 
            // comBoxColumn1
            // 
            this.comBoxColumn1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxColumn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxColumn1.FormattingEnabled = true;
            this.comBoxColumn1.Location = new System.Drawing.Point(228, 5);
            this.comBoxColumn1.Name = "comBoxColumn1";
            this.comBoxColumn1.Size = new System.Drawing.Size(124, 24);
            this.comBoxColumn1.TabIndex = 8;
            // 
            // comBoxOprat1
            // 
            this.comBoxOprat1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxOprat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxOprat1.FormattingEnabled = true;
            this.comBoxOprat1.Items.AddRange(new object[] {
            "يحتوي",
            "يساوي",
            "لايساوي"});
            this.comBoxOprat1.Location = new System.Drawing.Point(157, 5);
            this.comBoxOprat1.Name = "comBoxOprat1";
            this.comBoxOprat1.Size = new System.Drawing.Size(68, 24);
            this.comBoxOprat1.TabIndex = 12;
            // 
            // txtSearching1
            // 
            this.txtSearching1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearching1.Location = new System.Drawing.Point(3, 6);
            this.txtSearching1.Name = "txtSearching1";
            this.txtSearching1.Size = new System.Drawing.Size(148, 23);
            this.txtSearching1.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labResult);
            this.groupBox3.Controls.Add(this.btnExite);
            this.groupBox3.Controls.Add(this.btnNewSearch);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Location = new System.Drawing.Point(12, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 73);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResult.Location = new System.Drawing.Point(153, 26);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(64, 17);
            this.labResult.TabIndex = 3;
            this.labResult.Text = "عدد النتائج: ";
            // 
            // btnExite
            // 
            this.btnExite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExite.Image = global::FrmSearching.Properties.Resources.logout__1_;
            this.btnExite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExite.Location = new System.Drawing.Point(6, 19);
            this.btnExite.Name = "btnExite";
            this.btnExite.Size = new System.Drawing.Size(82, 30);
            this.btnExite.TabIndex = 2;
            this.btnExite.Text = "خروج";
            this.btnExite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExite.UseVisualStyleBackColor = true;
            this.btnExite.Click += new System.EventHandler(this.btnExite_Click);
            // 
            // btnNewSearch
            // 
            this.btnNewSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSearch.Image = global::FrmSearching.Properties.Resources.search;
            this.btnNewSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewSearch.Location = new System.Drawing.Point(237, 19);
            this.btnNewSearch.Name = "btnNewSearch";
            this.btnNewSearch.Size = new System.Drawing.Size(99, 30);
            this.btnNewSearch.TabIndex = 1;
            this.btnNewSearch.Text = "بحث جديد";
            this.btnNewSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewSearch.UseVisualStyleBackColor = true;
            this.btnNewSearch.Click += new System.EventHandler(this.btnNewSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::FrmSearching.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(342, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "بحث";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormSearching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 310);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSearching";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "                                                        بحث";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labTitleSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comBoxColumn1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ComboBox comBoxLogic4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox comBoxLogic3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comBoxLogic2;
        private System.Windows.Forms.ComboBox comBoxLogic1;
        private System.Windows.Forms.TextBox txtSearching4;
        private System.Windows.Forms.TextBox txtSearching3;
        private System.Windows.Forms.TextBox txtSearching2;
        private System.Windows.Forms.TextBox txtSearching1;
        private System.Windows.Forms.ComboBox comBoxOprat4;
        private System.Windows.Forms.ComboBox comBoxOprat3;
        private System.Windows.Forms.ComboBox comBoxOprat2;
        private System.Windows.Forms.ComboBox comBoxOprat1;
        private System.Windows.Forms.ComboBox comBoxColumn4;
        private System.Windows.Forms.ComboBox comBoxColumn3;
        private System.Windows.Forms.ComboBox comBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Button btnExite;
        private System.Windows.Forms.Button btnNewSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}


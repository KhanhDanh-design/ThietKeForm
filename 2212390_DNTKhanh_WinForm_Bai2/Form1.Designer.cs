namespace _2212390_DNTKhanh_WinForm_Bai2
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
            this.gbGioiTinh = new System.Windows.Forms.GroupBox();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.gbChonMau = new System.Windows.Forms.GroupBox();
            this.rbDo = new System.Windows.Forms.RadioButton();
            this.rbXanh = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtToMau = new System.Windows.Forms.TextBox();
            this.gbGioiTinh.SuspendLayout();
            this.gbChonMau.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGioiTinh
            // 
            this.gbGioiTinh.Controls.Add(this.rbNu);
            this.gbGioiTinh.Controls.Add(this.rbNam);
            this.gbGioiTinh.Location = new System.Drawing.Point(82, 34);
            this.gbGioiTinh.Name = "gbGioiTinh";
            this.gbGioiTinh.Size = new System.Drawing.Size(200, 100);
            this.gbGioiTinh.TabIndex = 0;
            this.gbGioiTinh.TabStop = false;
            this.gbGioiTinh.Text = "Chọn giới tính";
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(18, 30);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 0;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(18, 65);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 1;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            this.rbNu.CheckedChanged += new System.EventHandler(this.rbNu_CheckedChanged);
            // 
            // gbChonMau
            // 
            this.gbChonMau.Controls.Add(this.btnOK);
            this.gbChonMau.Controls.Add(this.rbXanh);
            this.gbChonMau.Controls.Add(this.rbDo);
            this.gbChonMau.Location = new System.Drawing.Point(82, 201);
            this.gbChonMau.Name = "gbChonMau";
            this.gbChonMau.Size = new System.Drawing.Size(208, 100);
            this.gbChonMau.TabIndex = 1;
            this.gbChonMau.TabStop = false;
            this.gbChonMau.Text = "Chọn màu";
            // 
            // rbDo
            // 
            this.rbDo.AutoSize = true;
            this.rbDo.Location = new System.Drawing.Point(18, 33);
            this.rbDo.Name = "rbDo";
            this.rbDo.Size = new System.Drawing.Size(63, 17);
            this.rbDo.TabIndex = 0;
            this.rbDo.Text = "Màu Đỏ";
            this.rbDo.UseVisualStyleBackColor = true;
            // 
            // rbXanh
            // 
            this.rbXanh.AutoSize = true;
            this.rbXanh.Location = new System.Drawing.Point(18, 68);
            this.rbXanh.Name = "rbXanh";
            this.rbXanh.Size = new System.Drawing.Size(74, 17);
            this.rbXanh.TabIndex = 1;
            this.rbXanh.Text = "Màu Xanh";
            this.rbXanh.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(109, 47);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Đổi màu";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtToMau
            // 
            this.txtToMau.Location = new System.Drawing.Point(314, 201);
            this.txtToMau.Multiline = true;
            this.txtToMau.Name = "txtToMau";
            this.txtToMau.ReadOnly = true;
            this.txtToMau.Size = new System.Drawing.Size(220, 100);
            this.txtToMau.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtToMau);
            this.Controls.Add(this.gbChonMau);
            this.Controls.Add(this.gbGioiTinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbGioiTinh.ResumeLayout(false);
            this.gbGioiTinh.PerformLayout();
            this.gbChonMau.ResumeLayout(false);
            this.gbChonMau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGioiTinh;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.GroupBox gbChonMau;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rbXanh;
        private System.Windows.Forms.RadioButton rbDo;
        private System.Windows.Forms.TextBox txtToMau;
    }
}


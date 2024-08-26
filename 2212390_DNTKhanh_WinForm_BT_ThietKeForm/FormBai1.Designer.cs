namespace _2212390_DNTKhanh_WinForm_BT_ThietKeForm
{
    partial class FormBai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBai1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbChonMau = new System.Windows.Forms.GroupBox();
            this.rbTrang = new System.Windows.Forms.RadioButton();
            this.rbDo = new System.Windows.Forms.RadioButton();
            this.rbXanh = new System.Windows.Forms.RadioButton();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbDVT = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbTong = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbChonMau.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 195);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbChonMau
            // 
            this.gbChonMau.Controls.Add(this.rbXanh);
            this.gbChonMau.Controls.Add(this.rbDo);
            this.gbChonMau.Controls.Add(this.rbTrang);
            this.gbChonMau.Location = new System.Drawing.Point(434, 39);
            this.gbChonMau.Name = "gbChonMau";
            this.gbChonMau.Size = new System.Drawing.Size(151, 167);
            this.gbChonMau.TabIndex = 1;
            this.gbChonMau.TabStop = false;
            this.gbChonMau.Text = "Chọn màu xe";
            // 
            // rbTrang
            // 
            this.rbTrang.AutoSize = true;
            this.rbTrang.Location = new System.Drawing.Point(17, 32);
            this.rbTrang.Name = "rbTrang";
            this.rbTrang.Size = new System.Drawing.Size(53, 17);
            this.rbTrang.TabIndex = 0;
            this.rbTrang.Text = "Trắng";
            this.rbTrang.UseVisualStyleBackColor = true;
            this.rbTrang.CheckedChanged += new System.EventHandler(this.rbTrang_CheckedChanged);
            // 
            // rbDo
            // 
            this.rbDo.AutoSize = true;
            this.rbDo.Location = new System.Drawing.Point(17, 75);
            this.rbDo.Name = "rbDo";
            this.rbDo.Size = new System.Drawing.Size(39, 17);
            this.rbDo.TabIndex = 1;
            this.rbDo.Text = "Đỏ";
            this.rbDo.UseVisualStyleBackColor = true;
            this.rbDo.CheckedChanged += new System.EventHandler(this.rbDo_CheckedChanged);
            // 
            // rbXanh
            // 
            this.rbXanh.AutoSize = true;
            this.rbXanh.Location = new System.Drawing.Point(17, 115);
            this.rbXanh.Name = "rbXanh";
            this.rbXanh.Size = new System.Drawing.Size(50, 17);
            this.rbXanh.TabIndex = 2;
            this.rbXanh.Text = "Xanh";
            this.rbXanh.UseVisualStyleBackColor = true;
            this.rbXanh.CheckedChanged += new System.EventHandler(this.rbXanh_CheckedChanged);
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.Location = new System.Drawing.Point(388, 235);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(68, 20);
            this.lbDonGia.TabIndex = 3;
            this.lbDonGia.Text = "Đơn Giá";
            // 
            // lbDVT
            // 
            this.lbDVT.AutoSize = true;
            this.lbDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDVT.Location = new System.Drawing.Point(650, 235);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(18, 20);
            this.lbDVT.TabIndex = 4;
            this.lbDVT.Text = "$";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(388, 272);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(78, 20);
            this.lbSoLuong.TabIndex = 5;
            this.lbSoLuong.Text = "Số Lượng";
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.Location = new System.Drawing.Point(265, 321);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(209, 24);
            this.lbTong.TabIndex = 6;
            this.lbTong.Text = "Tổng tiền thanh toán:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(460, 235);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(184, 26);
            this.txtDonGia.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(472, 272);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 26);
            this.txtSoLuong.TabIndex = 8;
            // 
            // txtTong
            // 
            this.txtTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(481, 321);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(163, 29);
            this.txtTong.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(650, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "$";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(606, 275);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTien.TabIndex = 11;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // FormBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 388);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbDVT);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.gbChonMau);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormBai1";
            this.Text = "FormBai1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbChonMau.ResumeLayout(false);
            this.gbChonMau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbChonMau;
        private System.Windows.Forms.RadioButton rbXanh;
        private System.Windows.Forms.RadioButton rbDo;
        private System.Windows.Forms.RadioButton rbTrang;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbDVT;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinhTien;
    }
}
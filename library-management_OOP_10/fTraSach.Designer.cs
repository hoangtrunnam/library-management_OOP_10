
namespace library_management_OOP_10
{
    partial class fTraSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTraSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTraTienTong = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLamMoiThoat = new System.Windows.Forms.Button();
            this.btnLamMoiTraSach = new System.Windows.Forms.Button();
            this.btnTimKiemTraSach = new System.Windows.Forms.Button();
            this.txtMssvTraSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subFormTraSach = new System.Windows.Forms.DataGridView();
            this.panelTraSach = new System.Windows.Forms.Panel();
            this.btnDongPhat = new System.Windows.Forms.Button();
            this.txtNgayTra = new System.Windows.Forms.TextBox();
            this.txtTienPhat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNgayQuaHan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNgayHen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaSachTra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuyTraSach = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.txtNgayMuon = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subFormTraSach)).BeginInit();
            this.panelTraSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.btnTraTienTong);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnLamMoiThoat);
            this.panel1.Controls.Add(this.btnLamMoiTraSach);
            this.panel1.Controls.Add(this.btnTimKiemTraSach);
            this.panel1.Controls.Add(this.txtMssvTraSach);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 597);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnTraTienTong
            // 
            this.btnTraTienTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraTienTong.Location = new System.Drawing.Point(82, 501);
            this.btnTraTienTong.Name = "btnTraTienTong";
            this.btnTraTienTong.Size = new System.Drawing.Size(123, 46);
            this.btnTraTienTong.TabIndex = 12;
            this.btnTraTienTong.Text = "Đóng Phạt Hết";
            this.btnTraTienTong.UseVisualStyleBackColor = true;
            this.btnTraTienTong.Click += new System.EventHandler(this.btnTraTienTong_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(45, 443);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(191, 22);
            this.txtTongTien.TabIndex = 11;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(89, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tổng Tiền Phạt";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnLamMoiThoat
            // 
            this.btnLamMoiThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiThoat.Location = new System.Drawing.Point(161, 322);
            this.btnLamMoiThoat.Name = "btnLamMoiThoat";
            this.btnLamMoiThoat.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoiThoat.TabIndex = 5;
            this.btnLamMoiThoat.Text = "Thoát";
            this.btnLamMoiThoat.UseVisualStyleBackColor = true;
            this.btnLamMoiThoat.Click += new System.EventHandler(this.btnLamMoiThoat_Click);
            // 
            // btnLamMoiTraSach
            // 
            this.btnLamMoiTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiTraSach.Location = new System.Drawing.Point(45, 322);
            this.btnLamMoiTraSach.Name = "btnLamMoiTraSach";
            this.btnLamMoiTraSach.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoiTraSach.TabIndex = 4;
            this.btnLamMoiTraSach.Text = "Làm Mới ";
            this.btnLamMoiTraSach.UseVisualStyleBackColor = true;
            this.btnLamMoiTraSach.Click += new System.EventHandler(this.btnLamMoiTraSach_Click);
            // 
            // btnTimKiemTraSach
            // 
            this.btnTimKiemTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemTraSach.Location = new System.Drawing.Point(82, 238);
            this.btnTimKiemTraSach.Name = "btnTimKiemTraSach";
            this.btnTimKiemTraSach.Size = new System.Drawing.Size(123, 43);
            this.btnTimKiemTraSach.TabIndex = 3;
            this.btnTimKiemTraSach.Text = "Tìm Kiếm";
            this.btnTimKiemTraSach.UseVisualStyleBackColor = true;
            this.btnTimKiemTraSach.Click += new System.EventHandler(this.btnTimKiemTraSach_Click);
            // 
            // txtMssvTraSach
            // 
            this.txtMssvTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMssvTraSach.Location = new System.Drawing.Point(45, 198);
            this.txtMssvTraSach.Name = "txtMssvTraSach";
            this.txtMssvTraSach.Size = new System.Drawing.Size(191, 22);
            this.txtMssvTraSach.TabIndex = 2;
            this.txtMssvTraSach.TextChanged += new System.EventHandler(this.txtMssvTraSach_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Số Sinh Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // subFormTraSach
            // 
            this.subFormTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subFormTraSach.Location = new System.Drawing.Point(286, 1);
            this.subFormTraSach.Name = "subFormTraSach";
            this.subFormTraSach.RowHeadersWidth = 51;
            this.subFormTraSach.Size = new System.Drawing.Size(719, 368);
            this.subFormTraSach.TabIndex = 1;
            this.subFormTraSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subFormTraSach_CellClick);
            this.subFormTraSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subFormTraSach_CellContentClick);
            // 
            // panelTraSach
            // 
            this.panelTraSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelTraSach.Controls.Add(this.btnDongPhat);
            this.panelTraSach.Controls.Add(this.txtNgayTra);
            this.panelTraSach.Controls.Add(this.txtTienPhat);
            this.panelTraSach.Controls.Add(this.label8);
            this.panelTraSach.Controls.Add(this.txtNgayQuaHan);
            this.panelTraSach.Controls.Add(this.label7);
            this.panelTraSach.Controls.Add(this.txtNgayHen);
            this.panelTraSach.Controls.Add(this.label6);
            this.panelTraSach.Controls.Add(this.txtMaSachTra);
            this.panelTraSach.Controls.Add(this.label5);
            this.panelTraSach.Controls.Add(this.btnHuyTraSach);
            this.panelTraSach.Controls.Add(this.btnTraSach);
            this.panelTraSach.Controls.Add(this.txtNgayMuon);
            this.panelTraSach.Controls.Add(this.txtTenSach);
            this.panelTraSach.Controls.Add(this.label4);
            this.panelTraSach.Controls.Add(this.label3);
            this.panelTraSach.Controls.Add(this.label2);
            this.panelTraSach.Location = new System.Drawing.Point(286, 375);
            this.panelTraSach.Name = "panelTraSach";
            this.panelTraSach.Size = new System.Drawing.Size(702, 223);
            this.panelTraSach.TabIndex = 2;
            this.panelTraSach.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTraSach_Paint);
            // 
            // btnDongPhat
            // 
            this.btnDongPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongPhat.Location = new System.Drawing.Point(391, 175);
            this.btnDongPhat.Name = "btnDongPhat";
            this.btnDongPhat.Size = new System.Drawing.Size(90, 23);
            this.btnDongPhat.TabIndex = 18;
            this.btnDongPhat.Text = "Đóng Phạt";
            this.btnDongPhat.UseVisualStyleBackColor = true;
            this.btnDongPhat.Click += new System.EventHandler(this.btnDongPhat_Click);
            // 
            // txtNgayTra
            // 
            this.txtNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayTra.Location = new System.Drawing.Point(167, 104);
            this.txtNgayTra.Name = "txtNgayTra";
            this.txtNgayTra.Size = new System.Drawing.Size(201, 22);
            this.txtNgayTra.TabIndex = 17;
            this.txtNgayTra.TextChanged += new System.EventHandler(this.txtNgayTra_TextChanged);
            // 
            // txtTienPhat
            // 
            this.txtTienPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienPhat.Location = new System.Drawing.Point(492, 102);
            this.txtTienPhat.Name = "txtTienPhat";
            this.txtTienPhat.Size = new System.Drawing.Size(201, 22);
            this.txtTienPhat.TabIndex = 15;
            this.txtTienPhat.TextChanged += new System.EventHandler(this.txtTienPhat_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(396, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tiền Phạt";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtNgayQuaHan
            // 
            this.txtNgayQuaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayQuaHan.Location = new System.Drawing.Point(167, 144);
            this.txtNgayQuaHan.Name = "txtNgayQuaHan";
            this.txtNgayQuaHan.Size = new System.Drawing.Size(201, 22);
            this.txtNgayQuaHan.TabIndex = 13;
            this.txtNgayQuaHan.TextChanged += new System.EventHandler(this.txtNgayQuaHan_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày Quá Hạn";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNgayHen
            // 
            this.txtNgayHen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayHen.Location = new System.Drawing.Point(492, 65);
            this.txtNgayHen.Name = "txtNgayHen";
            this.txtNgayHen.Size = new System.Drawing.Size(201, 22);
            this.txtNgayHen.TabIndex = 11;
            this.txtNgayHen.TextChanged += new System.EventHandler(this.txtNgayHen_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày Hẹn";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtMaSachTra
            // 
            this.txtMaSachTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSachTra.Location = new System.Drawing.Point(167, 26);
            this.txtMaSachTra.Name = "txtMaSachTra";
            this.txtMaSachTra.Size = new System.Drawing.Size(201, 22);
            this.txtMaSachTra.TabIndex = 9;
            this.txtMaSachTra.TextChanged += new System.EventHandler(this.txtMaSachTra_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã Sách";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnHuyTraSach
            // 
            this.btnHuyTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyTraSach.Location = new System.Drawing.Point(612, 175);
            this.btnHuyTraSach.Name = "btnHuyTraSach";
            this.btnHuyTraSach.Size = new System.Drawing.Size(81, 23);
            this.btnHuyTraSach.TabIndex = 7;
            this.btnHuyTraSach.Text = "Hủy ";
            this.btnHuyTraSach.UseVisualStyleBackColor = true;
            this.btnHuyTraSach.Click += new System.EventHandler(this.btnHuyTraSach_Click);
            // 
            // btnTraSach
            // 
            this.btnTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraSach.Location = new System.Drawing.Point(508, 176);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(81, 23);
            this.btnTraSach.TabIndex = 6;
            this.btnTraSach.Text = "Trả Sách ";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // txtNgayMuon
            // 
            this.txtNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayMuon.Location = new System.Drawing.Point(166, 67);
            this.txtNgayMuon.Name = "txtNgayMuon";
            this.txtNgayMuon.Size = new System.Drawing.Size(201, 22);
            this.txtNgayMuon.TabIndex = 4;
            this.txtNgayMuon.TextChanged += new System.EventHandler(this.txtNgayMuon_TextChanged);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(492, 24);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(201, 22);
            this.txtTenSach.TabIndex = 3;
            this.txtTenSach.TextChanged += new System.EventHandler(this.txtTenSach_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày Trả ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày Mượn ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sách";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1008, 610);
            this.Controls.Add(this.panelTraSach);
            this.Controls.Add(this.subFormTraSach);
            this.Controls.Add(this.panel1);
            this.Name = "fTraSach";
            this.Text = "Mã Sách";
            this.Load += new System.EventHandler(this.fTraSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subFormTraSach)).EndInit();
            this.panelTraSach.ResumeLayout(false);
            this.panelTraSach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView subFormTraSach;
        private System.Windows.Forms.Panel panelTraSach;
        private System.Windows.Forms.Button btnLamMoiThoat;
        private System.Windows.Forms.Button btnLamMoiTraSach;
        private System.Windows.Forms.Button btnTimKiemTraSach;
        private System.Windows.Forms.TextBox txtMssvTraSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHuyTraSach;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.TextBox txtNgayMuon;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNgayHen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaSachTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgayQuaHan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTienPhat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNgayTra;
        private System.Windows.Forms.Button btnDongPhat;
        private System.Windows.Forms.Button btnTraTienTong;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label9;
    }
}
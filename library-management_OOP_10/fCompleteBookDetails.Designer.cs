namespace library_management_OOP_10
{
    partial class fCompleteBookDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTuNgay = new System.Windows.Forms.TextBox();
            this.txtDenNgay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThongKeTheoThang = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.subformMatSach = new System.Windows.Forms.DataGridView();
            this.btnExportDaMuon = new System.Windows.Forms.Button();
            this.btnExportDangMuon = new System.Windows.Forms.Button();
            this.btnExportMatSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subformMatSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(571, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đã Mượn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1381, 256);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 416);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1381, 238);
            this.dataGridView2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(571, 383);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đang Mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ Ngày";
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.AccessibleDescription = "dd/mm/yyyy";
            this.txtTuNgay.Location = new System.Drawing.Point(320, 28);
            this.txtTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Size = new System.Drawing.Size(233, 22);
            this.txtTuNgay.TabIndex = 5;
            this.txtTuNgay.Text = "dd/mm/yyyy";
            this.txtTuNgay.MouseEnter += new System.EventHandler(this.txtTuNgay_MouseEnter);
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.AccessibleDescription = "";
            this.txtDenNgay.Location = new System.Drawing.Point(756, 30);
            this.txtDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.Size = new System.Drawing.Size(233, 22);
            this.txtDenNgay.TabIndex = 7;
            this.txtDenNgay.Text = "dd/mm/yyyy";
            this.txtDenNgay.MouseEnter += new System.EventHandler(this.txtDenNgay_MouseEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(640, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đến Ngày";
            // 
            // btnThongKeTheoThang
            // 
            this.btnThongKeTheoThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTheoThang.Location = new System.Drawing.Point(1072, 30);
            this.btnThongKeTheoThang.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKeTheoThang.Name = "btnThongKeTheoThang";
            this.btnThongKeTheoThang.Size = new System.Drawing.Size(117, 28);
            this.btnThongKeTheoThang.TabIndex = 8;
            this.btnThongKeTheoThang.Text = "Thống Kê";
            this.btnThongKeTheoThang.UseVisualStyleBackColor = true;
            this.btnThongKeTheoThang.Click += new System.EventHandler(this.btnThongKeTheoThang_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(571, 657);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mất Sách";
            // 
            // subformMatSach
            // 
            this.subformMatSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subformMatSach.Location = new System.Drawing.Point(16, 690);
            this.subformMatSach.Margin = new System.Windows.Forms.Padding(4);
            this.subformMatSach.Name = "subformMatSach";
            this.subformMatSach.RowHeadersWidth = 51;
            this.subformMatSach.Size = new System.Drawing.Size(1381, 223);
            this.subformMatSach.TabIndex = 10;
            // 
            // btnExportDaMuon
            // 
            this.btnExportDaMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportDaMuon.Location = new System.Drawing.Point(1072, 87);
            this.btnExportDaMuon.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportDaMuon.Name = "btnExportDaMuon";
            this.btnExportDaMuon.Size = new System.Drawing.Size(117, 28);
            this.btnExportDaMuon.TabIndex = 11;
            this.btnExportDaMuon.Text = "Export Excel";
            this.btnExportDaMuon.UseVisualStyleBackColor = true;
            this.btnExportDaMuon.Click += new System.EventHandler(this.btnExportDaMuon_Click);
            // 
            // btnExportDangMuon
            // 
            this.btnExportDangMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportDangMuon.Location = new System.Drawing.Point(1072, 387);
            this.btnExportDangMuon.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportDangMuon.Name = "btnExportDangMuon";
            this.btnExportDangMuon.Size = new System.Drawing.Size(117, 28);
            this.btnExportDangMuon.TabIndex = 12;
            this.btnExportDangMuon.Text = "Export Excel";
            this.btnExportDangMuon.UseVisualStyleBackColor = true;
            this.btnExportDangMuon.Click += new System.EventHandler(this.btnExportDangMuon_Click);
            // 
            // btnExportMatSach
            // 
            this.btnExportMatSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportMatSach.Location = new System.Drawing.Point(1072, 658);
            this.btnExportMatSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportMatSach.Name = "btnExportMatSach";
            this.btnExportMatSach.Size = new System.Drawing.Size(117, 28);
            this.btnExportMatSach.TabIndex = 13;
            this.btnExportMatSach.Text = "Export Excel";
            this.btnExportMatSach.UseVisualStyleBackColor = true;
            this.btnExportMatSach.Click += new System.EventHandler(this.btnExportMatSach_Click);
            // 
            // fCompleteBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1413, 614);
            this.Controls.Add(this.btnExportMatSach);
            this.Controls.Add(this.btnExportDangMuon);
            this.Controls.Add(this.btnExportDaMuon);
            this.Controls.Add(this.subformMatSach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThongKeTheoThang);
            this.Controls.Add(this.txtDenNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTuNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fCompleteBookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCompleteBookDetails";
            this.Load += new System.EventHandler(this.fCompleteBookDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subformMatSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTuNgay;
        private System.Windows.Forms.TextBox txtDenNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThongKeTheoThang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView subformMatSach;
        private System.Windows.Forms.Button btnExportDaMuon;
        private System.Windows.Forms.Button btnExportDangMuon;
        private System.Windows.Forms.Button btnExportMatSach;
    }
}
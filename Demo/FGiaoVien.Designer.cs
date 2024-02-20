namespace Demo
{
    partial class FGiaoVien
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnChuyen = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.gvGiaoVien = new System.Windows.Forms.DataGridView();
            this.lblHovaTen = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(79, 662);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 50);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(594, 662);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 50);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "XOA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSua.Location = new System.Drawing.Point(1075, 662);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 50);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "SUA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnChuyen
            // 
            this.btnChuyen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChuyen.Location = new System.Drawing.Point(12, 12);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(96, 53);
            this.btnChuyen.TabIndex = 13;
            this.btnChuyen.Text = "Chuyen";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(1124, 487);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(101, 52);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Lam moi";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // gvGiaoVien
            // 
            this.gvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGiaoVien.Location = new System.Drawing.Point(594, 45);
            this.gvGiaoVien.Name = "gvGiaoVien";
            this.gvGiaoVien.RowHeadersWidth = 51;
            this.gvGiaoVien.RowTemplate.Height = 24;
            this.gvGiaoVien.Size = new System.Drawing.Size(631, 435);
            this.gvGiaoVien.TabIndex = 15;
            // 
            // lblHovaTen
            // 
            this.lblHovaTen.AutoSize = true;
            this.lblHovaTen.Location = new System.Drawing.Point(76, 111);
            this.lblHovaTen.Name = "lblHovaTen";
            this.lblHovaTen.Size = new System.Drawing.Size(70, 16);
            this.lblHovaTen.TabIndex = 16;
            this.lblHovaTen.Text = "Ho va Ten";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(76, 161);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(44, 16);
            this.lblCCCD.TabIndex = 17;
            this.lblCCCD.Text = "CCCD";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(76, 214);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(48, 16);
            this.lblDiaChi.TabIndex = 18;
            this.lblDiaChi.Text = "Dia chi";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(76, 270);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(67, 16);
            this.lblNgaySinh.TabIndex = 19;
            this.lblNgaySinh.Text = "Ngay sinh";
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Location = new System.Drawing.Point(184, 111);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.Size = new System.Drawing.Size(200, 22);
            this.txtHovaTen.TabIndex = 20;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(184, 161);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(200, 22);
            this.txtCCCD.TabIndex = 21;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(184, 214);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 22);
            this.txtDiaChi.TabIndex = 22;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(184, 270);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.TabIndex = 23;
            // 
            // FGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Demo.Properties.Resources.quy_trinh_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 731);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtHovaTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.lblHovaTen);
            this.Controls.Add(this.gvGiaoVien);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "FGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FGiaoVien";
            this.Load += new System.EventHandler(this.FGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView gvGiaoVien;
        private System.Windows.Forms.Label lblHovaTen;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    }
}
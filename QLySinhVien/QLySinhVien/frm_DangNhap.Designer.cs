namespace QLySinhVien
{
    partial class frm_DangNhap
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
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.lbl_TenDN = new System.Windows.Forms.Label();
            this.txt_TenDN = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Location = new System.Drawing.Point(260, 139);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(56, 13);
            this.lbl_MatKhau.TabIndex = 8;
            this.lbl_MatKhau.Text = "Mật Khẩu:";
            this.lbl_MatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_MatKhau.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(332, 136);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(187, 20);
            this.txt_MatKhau.TabIndex = 7;
            this.txt_MatKhau.TextChanged += new System.EventHandler(this.txt_TenSV_TextChanged);
            // 
            // lbl_TenDN
            // 
            this.lbl_TenDN.AutoSize = true;
            this.lbl_TenDN.Location = new System.Drawing.Point(229, 113);
            this.lbl_TenDN.Name = "lbl_TenDN";
            this.lbl_TenDN.Size = new System.Drawing.Size(87, 13);
            this.lbl_TenDN.TabIndex = 6;
            this.lbl_TenDN.Text = "Tên Đăng Nhập:";
            this.lbl_TenDN.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Location = new System.Drawing.Point(332, 110);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Size = new System.Drawing.Size(187, 20);
            this.txt_TenDN.TabIndex = 5;
            this.txt_TenDN.TextChanged += new System.EventHandler(this.txt_MaSV_TextChanged);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Location = new System.Drawing.Point(201, 186);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(115, 50);
            this.btn_DangNhap.TabIndex = 9;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(343, 186);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(115, 50);
            this.btn_Reset.TabIndex = 10;
            this.btn_Reset.Text = "Nhập Lại";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(491, 186);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(115, 50);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoat";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_DangNhap
            // 
            this.AcceptButton = this.btn_DangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.lbl_TenDN);
            this.Controls.Add(this.txt_TenDN);
            this.Name = "frm_DangNhap";
            this.Text = "Nhap";
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label lbl_TenDN;
        private System.Windows.Forms.TextBox txt_TenDN;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_thoat;
    }
}
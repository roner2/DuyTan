namespace QLySinhVien
{
    partial class frm_GiaiPTBat2
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
            this.txt_HeSoB = new System.Windows.Forms.TextBox();
            this.lbl_TenDN = new System.Windows.Forms.Label();
            this.txt_HeSoA = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_HeSoC = new System.Windows.Forms.TextBox();
            this.txt_DapAn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Location = new System.Drawing.Point(225, 54);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(79, 13);
            this.lbl_MatKhau.TabIndex = 8;
            this.lbl_MatKhau.Text = "Nhap He So B:";
            this.lbl_MatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_MatKhau.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_HeSoB
            // 
            this.txt_HeSoB.Location = new System.Drawing.Point(332, 51);
            this.txt_HeSoB.Name = "txt_HeSoB";
            this.txt_HeSoB.Size = new System.Drawing.Size(187, 20);
            this.txt_HeSoB.TabIndex = 7;
            this.txt_HeSoB.TextChanged += new System.EventHandler(this.txt_TenSV_TextChanged);
            // 
            // lbl_TenDN
            // 
            this.lbl_TenDN.AutoSize = true;
            this.lbl_TenDN.Location = new System.Drawing.Point(229, 15);
            this.lbl_TenDN.Name = "lbl_TenDN";
            this.lbl_TenDN.Size = new System.Drawing.Size(75, 13);
            this.lbl_TenDN.TabIndex = 6;
            this.lbl_TenDN.Text = "Nhap he so A:";
            this.lbl_TenDN.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_HeSoA
            // 
            this.txt_HeSoA.Location = new System.Drawing.Point(332, 12);
            this.txt_HeSoA.Name = "txt_HeSoA";
            this.txt_HeSoA.Size = new System.Drawing.Size(187, 20);
            this.txt_HeSoA.TabIndex = 5;
            this.txt_HeSoA.TextChanged += new System.EventHandler(this.txt_MaSV_TextChanged);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Location = new System.Drawing.Point(109, 295);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(115, 50);
            this.btn_DangNhap.TabIndex = 9;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(319, 295);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(115, 50);
            this.btn_Reset.TabIndex = 10;
            this.btn_Reset.Text = "Nhập Lại";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(537, 295);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(115, 50);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoat";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nhap He So C:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_HeSoC
            // 
            this.txt_HeSoC.Location = new System.Drawing.Point(332, 99);
            this.txt_HeSoC.Name = "txt_HeSoC";
            this.txt_HeSoC.Size = new System.Drawing.Size(187, 20);
            this.txt_HeSoC.TabIndex = 12;
            // 
            // txt_DapAn
            // 
            this.txt_DapAn.Location = new System.Drawing.Point(228, 146);
            this.txt_DapAn.Multiline = true;
            this.txt_DapAn.Name = "txt_DapAn";
            this.txt_DapAn.Size = new System.Drawing.Size(291, 119);
            this.txt_DapAn.TabIndex = 14;
            // 
            // frm_GiaiPTBat2
            // 
            this.AcceptButton = this.btn_DangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_DapAn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_HeSoC);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.txt_HeSoB);
            this.Controls.Add(this.lbl_TenDN);
            this.Controls.Add(this.txt_HeSoA);
            this.Name = "frm_GiaiPTBat2";
            this.Text = "Nhap";
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.TextBox txt_HeSoB;
        private System.Windows.Forms.Label lbl_TenDN;
        private System.Windows.Forms.TextBox txt_HeSoA;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_HeSoC;
        private System.Windows.Forms.TextBox txt_DapAn;
    }
}
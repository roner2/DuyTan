namespace QLySinhVien
{
    partial class frm_NhapBac
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
            this.btn_bat = new System.Windows.Forms.Button();
            this.txt_bac = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_bat
            // 
            this.btn_bat.Location = new System.Drawing.Point(309, 128);
            this.btn_bat.Name = "btn_bat";
            this.btn_bat.Size = new System.Drawing.Size(75, 23);
            this.btn_bat.TabIndex = 0;
            this.btn_bat.Text = "button1";
            this.btn_bat.UseVisualStyleBackColor = true;
            this.btn_bat.Click += new System.EventHandler(this.btn_bat_Click);
            // 
            // txt_bac
            // 
            this.txt_bac.Location = new System.Drawing.Point(197, 66);
            this.txt_bac.Name = "txt_bac";
            this.txt_bac.Size = new System.Drawing.Size(268, 20);
            this.txt_bac.TabIndex = 1;
            // 
            // frm_NhapBac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_bac);
            this.Controls.Add(this.btn_bat);
            this.Name = "frm_NhapBac";
            this.Text = "frm_NhapBac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bat;
        private System.Windows.Forms.TextBox txt_bac;
    }
}
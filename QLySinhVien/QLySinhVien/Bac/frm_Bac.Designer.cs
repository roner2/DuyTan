namespace QLySinhVien
{
    partial class frm_Bac
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
            this.btn_giai = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lb_show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_giai
            // 
            this.btn_giai.Location = new System.Drawing.Point(187, 476);
            this.btn_giai.Name = "btn_giai";
            this.btn_giai.Size = new System.Drawing.Size(75, 23);
            this.btn_giai.TabIndex = 0;
            this.btn_giai.Text = "Giai";
            this.btn_giai.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(451, 476);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Thoat";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lb_show
            // 
            this.lb_show.AutoSize = true;
            this.lb_show.Location = new System.Drawing.Point(248, 9);
            this.lb_show.Name = "lb_show";
            this.lb_show.Size = new System.Drawing.Size(114, 13);
            this.lb_show.TabIndex = 2;
            this.lb_show.Text = "Giai phuong trinh bac: ";
            // 
            // frm_Bac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.lb_show);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_giai);
            this.Name = "frm_Bac";
            this.Text = "frm_Bac";
            this.Load += new System.EventHandler(this.frm_Bac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giai;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lb_show;
    }
}
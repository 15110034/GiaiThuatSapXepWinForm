namespace DoAn1Final
{
    partial class Form3
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
            this.txtChiSo = new System.Windows.Forms.TextBox();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.btnThoatFrm3 = new System.Windows.Forms.Button();
            this.btnNhapFrm3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtChiSo
            // 
            this.txtChiSo.Location = new System.Drawing.Point(119, 96);
            this.txtChiSo.Name = "txtChiSo";
            this.txtChiSo.Size = new System.Drawing.Size(41, 22);
            this.txtChiSo.TabIndex = 0;
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(213, 96);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(190, 22);
            this.txtGiaTri.TabIndex = 1;
            // 
            // btnThoatFrm3
            // 
            this.btnThoatFrm3.Location = new System.Drawing.Point(303, 153);
            this.btnThoatFrm3.Name = "btnThoatFrm3";
            this.btnThoatFrm3.Size = new System.Drawing.Size(100, 28);
            this.btnThoatFrm3.TabIndex = 7;
            this.btnThoatFrm3.Text = "Thoát";
            this.btnThoatFrm3.UseVisualStyleBackColor = true;
            this.btnThoatFrm3.Click += new System.EventHandler(this.btnThoatFrm3_Click);
            // 
            // btnNhapFrm3
            // 
            this.btnNhapFrm3.Location = new System.Drawing.Point(119, 153);
            this.btnNhapFrm3.Name = "btnNhapFrm3";
            this.btnNhapFrm3.Size = new System.Drawing.Size(105, 28);
            this.btnNhapFrm3.TabIndex = 6;
            this.btnNhapFrm3.Text = "Nhập";
            this.btnNhapFrm3.UseVisualStyleBackColor = true;
            this.btnNhapFrm3.Click += new System.EventHandler(this.btnNhapFrm3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Phần tử thứ ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoatFrm3);
            this.Controls.Add(this.btnNhapFrm3);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.txtChiSo);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChiSo;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Button btnThoatFrm3;
        private System.Windows.Forms.Button btnNhapFrm3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
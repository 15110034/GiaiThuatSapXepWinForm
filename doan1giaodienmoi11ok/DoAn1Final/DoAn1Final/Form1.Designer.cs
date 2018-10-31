namespace DoAn1Final
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
            this.raBubble = new System.Windows.Forms.RadioButton();
            this.raSelection = new System.Windows.Forms.RadioButton();
            this.raQuick = new System.Windows.Forms.RadioButton();
            this.raInsertion = new System.Windows.Forms.RadioButton();
            this.raMerge = new System.Windows.Forms.RadioButton();
            this.raInterchange = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNhapTay = new System.Windows.Forms.Button();
            this.btnNhapMang = new System.Windows.Forms.Button();
            this.btnNgauNhien = new System.Windows.Forms.Button();
            this.txtSoPtu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.raGiam = new System.Windows.Forms.RadioButton();
            this.raTang = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lstCode = new System.Windows.Forms.ListBox();
            this.lbChiSo2 = new System.Windows.Forms.Label();
            this.lbChiSo1 = new System.Windows.Forms.Label();
            this.lbRight = new System.Windows.Forms.Label();
            this.lbLeft = new System.Windows.Forms.Label();
            this.lbPosK = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // raBubble
            // 
            this.raBubble.AutoSize = true;
            this.raBubble.Location = new System.Drawing.Point(19, 62);
            this.raBubble.Name = "raBubble";
            this.raBubble.Size = new System.Drawing.Size(103, 21);
            this.raBubble.TabIndex = 0;
            this.raBubble.TabStop = true;
            this.raBubble.Text = "Bubble Sort";
            this.raBubble.UseVisualStyleBackColor = true;
            this.raBubble.CheckedChanged += new System.EventHandler(this.raBubble_CheckedChanged);
            // 
            // raSelection
            // 
            this.raSelection.AutoSize = true;
            this.raSelection.Location = new System.Drawing.Point(137, 62);
            this.raSelection.Name = "raSelection";
            this.raSelection.Size = new System.Drawing.Size(121, 21);
            this.raSelection.TabIndex = 1;
            this.raSelection.TabStop = true;
            this.raSelection.Text = "Selection Sort ";
            this.raSelection.UseVisualStyleBackColor = true;
            this.raSelection.CheckedChanged += new System.EventHandler(this.raSelection_CheckedChanged);
            // 
            // raQuick
            // 
            this.raQuick.AutoSize = true;
            this.raQuick.Location = new System.Drawing.Point(19, 113);
            this.raQuick.Name = "raQuick";
            this.raQuick.Size = new System.Drawing.Size(95, 21);
            this.raQuick.TabIndex = 2;
            this.raQuick.TabStop = true;
            this.raQuick.Text = "Quick Sort";
            this.raQuick.UseVisualStyleBackColor = true;
            this.raQuick.CheckedChanged += new System.EventHandler(this.raQuick_CheckedChanged);
            // 
            // raInsertion
            // 
            this.raInsertion.AutoSize = true;
            this.raInsertion.Location = new System.Drawing.Point(137, 113);
            this.raInsertion.Name = "raInsertion";
            this.raInsertion.Size = new System.Drawing.Size(113, 21);
            this.raInsertion.TabIndex = 3;
            this.raInsertion.TabStop = true;
            this.raInsertion.Text = "Insertion Sort";
            this.raInsertion.UseVisualStyleBackColor = true;
            this.raInsertion.CheckedChanged += new System.EventHandler(this.raInsertion_CheckedChanged);
            // 
            // raMerge
            // 
            this.raMerge.AutoSize = true;
            this.raMerge.Location = new System.Drawing.Point(19, 169);
            this.raMerge.Name = "raMerge";
            this.raMerge.Size = new System.Drawing.Size(99, 21);
            this.raMerge.TabIndex = 4;
            this.raMerge.TabStop = true;
            this.raMerge.Text = "Merge Sort";
            this.raMerge.UseVisualStyleBackColor = true;
            this.raMerge.CheckedChanged += new System.EventHandler(this.raMerge_CheckedChanged);
            // 
            // raInterchange
            // 
            this.raInterchange.AutoSize = true;
            this.raInterchange.Location = new System.Drawing.Point(137, 169);
            this.raInterchange.Name = "raInterchange";
            this.raInterchange.Size = new System.Drawing.Size(134, 21);
            this.raInterchange.TabIndex = 5;
            this.raInterchange.TabStop = true;
            this.raInterchange.Text = "Interchange Sort";
            this.raInterchange.UseVisualStyleBackColor = true;
            this.raInterchange.CheckedChanged += new System.EventHandler(this.raInterchange_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raBubble);
            this.groupBox1.Controls.Add(this.raInterchange);
            this.groupBox1.Controls.Add(this.raSelection);
            this.groupBox1.Controls.Add(this.raMerge);
            this.groupBox1.Controls.Add(this.raQuick);
            this.groupBox1.Controls.Add(this.raInsertion);
            this.groupBox1.Location = new System.Drawing.Point(763, 502);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 260);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thuật toán";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNhapTay);
            this.groupBox2.Controls.Add(this.btnNhapMang);
            this.groupBox2.Controls.Add(this.btnNgauNhien);
            this.groupBox2.Controls.Add(this.txtSoPtu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(494, 502);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 260);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khởi tạo";
            // 
            // btnNhapTay
            // 
            this.btnNhapTay.Location = new System.Drawing.Point(65, 169);
            this.btnNhapTay.Name = "btnNhapTay";
            this.btnNhapTay.Size = new System.Drawing.Size(126, 30);
            this.btnNhapTay.TabIndex = 4;
            this.btnNhapTay.Text = "nhập tay";
            this.btnNhapTay.UseVisualStyleBackColor = true;
            this.btnNhapTay.Click += new System.EventHandler(this.btnNhapTay_Click);
            // 
            // btnNhapMang
            // 
            this.btnNhapMang.Location = new System.Drawing.Point(65, 120);
            this.btnNhapMang.Name = "btnNhapMang";
            this.btnNhapMang.Size = new System.Drawing.Size(126, 33);
            this.btnNhapMang.TabIndex = 3;
            this.btnNhapMang.Text = "nhập mảng";
            this.btnNhapMang.UseVisualStyleBackColor = true;
            this.btnNhapMang.Click += new System.EventHandler(this.btnNhapMang_Click);
            // 
            // btnNgauNhien
            // 
            this.btnNgauNhien.Location = new System.Drawing.Point(65, 76);
            this.btnNgauNhien.Name = "btnNgauNhien";
            this.btnNgauNhien.Size = new System.Drawing.Size(126, 30);
            this.btnNgauNhien.TabIndex = 2;
            this.btnNgauNhien.Text = "ngẫu nhiên";
            this.btnNgauNhien.UseVisualStyleBackColor = true;
            this.btnNgauNhien.Click += new System.EventHandler(this.btnNgauNhien_Click);
            // 
            // txtSoPtu
            // 
            this.txtSoPtu.Location = new System.Drawing.Point(116, 29);
            this.txtSoPtu.Name = "txtSoPtu";
            this.txtSoPtu.Size = new System.Drawing.Size(100, 22);
            this.txtSoPtu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phần tử :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPause);
            this.groupBox3.Controls.Add(this.btnHuy);
            this.groupBox3.Controls.Add(this.btnSapXep);
            this.groupBox3.Location = new System.Drawing.Point(1199, 502);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 260);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Điều khiển";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(34, 103);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(100, 31);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Tạm dừng";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(35, 164);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(99, 31);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(34, 45);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(96, 31);
            this.btnSapXep.TabIndex = 0;
            this.btnSapXep.Text = "Sắp Xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.raGiam);
            this.groupBox4.Controls.Add(this.raTang);
            this.groupBox4.Location = new System.Drawing.Point(1052, 502);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(129, 260);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kiểu sắp xếp ";
            // 
            // raGiam
            // 
            this.raGiam.AutoSize = true;
            this.raGiam.Location = new System.Drawing.Point(27, 120);
            this.raGiam.Name = "raGiam";
            this.raGiam.Size = new System.Drawing.Size(62, 21);
            this.raGiam.TabIndex = 1;
            this.raGiam.TabStop = true;
            this.raGiam.Text = "Giảm";
            this.raGiam.UseVisualStyleBackColor = true;
            this.raGiam.CheckedChanged += new System.EventHandler(this.raGiam_CheckedChanged);
            // 
            // raTang
            // 
            this.raTang.AutoSize = true;
            this.raTang.Location = new System.Drawing.Point(27, 76);
            this.raTang.Name = "raTang";
            this.raTang.Size = new System.Drawing.Size(62, 21);
            this.raTang.TabIndex = 0;
            this.raTang.TabStop = true;
            this.raTang.Text = "Tăng";
            this.raTang.UseVisualStyleBackColor = true;
            this.raTang.CheckedChanged += new System.EventHandler(this.raTang_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1376, 502);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 260);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lstCode
            // 
            this.lstCode.FormattingEnabled = true;
            this.lstCode.ItemHeight = 16;
            this.lstCode.Location = new System.Drawing.Point(23, 515);
            this.lstCode.Name = "lstCode";
            this.lstCode.Size = new System.Drawing.Size(465, 260);
            this.lstCode.TabIndex = 11;
            // 
            // lbChiSo2
            // 
            this.lbChiSo2.AutoSize = true;
            this.lbChiSo2.Location = new System.Drawing.Point(1102, 18);
            this.lbChiSo2.Name = "lbChiSo2";
            this.lbChiSo2.Size = new System.Drawing.Size(49, 17);
            this.lbChiSo2.TabIndex = 18;
            this.lbChiSo2.Text = "chiso2";
            this.lbChiSo2.Visible = false;
            // 
            // lbChiSo1
            // 
            this.lbChiSo1.AutoSize = true;
            this.lbChiSo1.Location = new System.Drawing.Point(1047, 18);
            this.lbChiSo1.Name = "lbChiSo1";
            this.lbChiSo1.Size = new System.Drawing.Size(49, 17);
            this.lbChiSo1.TabIndex = 17;
            this.lbChiSo1.Text = "chiso1";
            this.lbChiSo1.Visible = false;
            // 
            // lbRight
            // 
            this.lbRight.AutoSize = true;
            this.lbRight.Location = new System.Drawing.Point(1257, 18);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(36, 17);
            this.lbRight.TabIndex = 16;
            this.lbRight.Text = "right";
            this.lbRight.Visible = false;
            // 
            // lbLeft
            // 
            this.lbLeft.AutoSize = true;
            this.lbLeft.Location = new System.Drawing.Point(1196, 18);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(27, 17);
            this.lbLeft.TabIndex = 15;
            this.lbLeft.Text = "left";
            this.lbLeft.Visible = false;
            // 
            // lbPosK
            // 
            this.lbPosK.AutoSize = true;
            this.lbPosK.Location = new System.Drawing.Point(1353, 18);
            this.lbPosK.Name = "lbPosK";
            this.lbPosK.Size = new System.Drawing.Size(40, 17);
            this.lbPosK.TabIndex = 14;
            this.lbPosK.Text = "posK";
            this.lbPosK.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 785);
            this.Controls.Add(this.lbChiSo2);
            this.Controls.Add(this.lbChiSo1);
            this.Controls.Add(this.lbRight);
            this.Controls.Add(this.lbLeft);
            this.Controls.Add(this.lbPosK);
            this.Controls.Add(this.lstCode);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton raBubble;
        private System.Windows.Forms.RadioButton raSelection;
        private System.Windows.Forms.RadioButton raQuick;
        private System.Windows.Forms.RadioButton raInsertion;
        private System.Windows.Forms.RadioButton raMerge;
        private System.Windows.Forms.RadioButton raInterchange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNhapTay;
        private System.Windows.Forms.Button btnNhapMang;
        private System.Windows.Forms.Button btnNgauNhien;
        private System.Windows.Forms.TextBox txtSoPtu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton raGiam;
        private System.Windows.Forms.RadioButton raTang;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ListBox lstCode;
        private System.Windows.Forms.Label lbChiSo2;
        private System.Windows.Forms.Label lbChiSo1;
        private System.Windows.Forms.Label lbRight;
        private System.Windows.Forms.Label lbLeft;
        private System.Windows.Forms.Label lbPosK;
    }
}


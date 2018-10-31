using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1Final
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public int i;
        Boolean kTra = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnNhapFrm3_Click(object sender, EventArgs e)
        {
            kTra = true;
            int giaTri;
            try
            {
                i = Convert.ToInt32(txtChiSo.Text);
            }
            catch
            {
                MessageBox.Show("chỉ số không hợp lệ ");
                return;
            }
            if (i > Form1.soPhanTu - 1)
            {
                MessageBox.Show("không có phần tử thứ " + i);
                return;
            }
            try
            {
                giaTri = Convert.ToInt32(txtGiaTri.Text);

            }
            catch
            {
                MessageBox.Show("giá trị nhập vào không hợp lệ");
                return;
            }
            if (giaTri < 0 || giaTri > 100)
            {
                MessageBox.Show(" 0 <= giá trị <=100");
                this.txtGiaTri.Clear();
                kTra = false;
            }
            if (kTra == true)
            {
                Form1.a[i] = giaTri;
                Form1.mangNhap[i].Text = Form1.a[i].ToString();
                Form1.mangChiSo[i].Text = i.ToString();
                Form1.mangNhap[i].ForeColor = Color.Red;

                //this.txtChiSo.Focus();
                this.txtChiSo.Text = (i + 1).ToString();
                //txtChiSo.SelectAll();
                txtGiaTri.Focus();
                txtGiaTri.SelectAll();
            }
        }

        private void btnThoatFrm3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

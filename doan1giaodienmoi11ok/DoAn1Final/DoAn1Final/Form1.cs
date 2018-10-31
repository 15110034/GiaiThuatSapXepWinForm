using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace DoAn1Final
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static Button[] mangNhap, mangKetQua;  // tao nhung mang de hien so len mang hinh
        public Button[] MangB, MangC; // dung cho mergesort
        public static int soPhanTu = 0;
        public static Label[] mangChiSo; // tao mang chi so cua tung phan tu 
        public static int[] a, b, c, h, chuaxep;
        int khoangCach; // khoang cach 2 button cua mangNhap 
        int kichThuoc; // kich thuoc cua button trong mangNhap
        int coChu; // co chu trong button.text ; 
        int canhLe; // vi tri so voi le ben trai 
        int i;
        int tocDo;// toc do di chuyen cua button ... dung cho ham Tre();
        public static TextBox txtNhapTay;
        public int viTriNhapTay;
        Boolean nhapSoptuTC = false, daTaoMang = false;  // da nhap so phan tu thanh cong hay chua , da tao mang button thanh cong hay chua

        Code code = new Code(); // cais nayf de hien code 
        bool tang = true; // cai nay de hien code 
        public bool testPause = false;
        /// <phần tạo mảng >



        private void btnNhapMang_Click(object sender, EventArgs e)
        {
            Xoa_mang(mangNhap);
            soPhanTu = 0;//mới sửa ngày 20/11
            txtSoPtu.Text = "";
            lbChiSo1.Visible = false;
            lbChiSo2.Visible = false;
            lbLeft.Visible = false;
            lbRight.Visible = false;
            lbPosK.Visible = false;
            Form2 frm = new Form2();
            frm.ShowDialog();
            taoMang(150);
            try // sau khi da nhap mang vao mang a at form2 thi nhap vao trong mang button
            {
                for (i = 0; i < a.Length; i++)
                {
                    mangNhap[i].ForeColor = Color.White;

                    mangNhap[i].Text = a[i].ToString();
                }
               // daTaoMang = true; // thêm ngày 21/11: khi nhập mảng xong thì dataomang= true

            }
            catch
            {

            }
        }

        private void btnNhapTay_Click(object sender, EventArgs e) // 3.nhap tung so vo mang text box
        {
            soPhanTu = 0; //mới thêm ngày 20/11
            Xoa_mang(mangNhap);// xoa mang cu truoc khi tao mang moi
            try
            {
                soPhanTu = Convert.ToInt32(txtSoPtu.Text); // lay so phan tu ra

                if (soPhanTu > 15 || soPhanTu <= 2)
                {
                    MessageBox.Show("số phần tử không vượt quá 15");
                    return; // mới sửa ngày 20/11
                }
                else
                {
                    nhapSoptuTC = true;
                    MessageBox.Show(soPhanTu.ToString());

                }

            }
            catch
            {
                MessageBox.Show(" số phần tử không hợp lệ");
                return; // mới thêm ngày 20/11
            }

            if (nhapSoptuTC == true) // so phan tu thoa mang
            {

                a = new int[soPhanTu];
                taoMang(150);
                Form3 fr3 = new Form3();
                fr3.ShowDialog();
            }

        }

        private void btnNgauNhien_Click(object sender, EventArgs e)
        {
            Xoa_mang(mangNhap);// xoa mang cu truoc khi tao mang moi
            soPhanTu = 0; // mới sửa ngày 20/11
            lbChiSo1.Visible = false;
            lbChiSo2.Visible = false;
            lbLeft.Visible = false;
            lbRight.Visible = false;
            lbPosK.Visible = false;
            
           
            try
            {
                soPhanTu = Convert.ToInt32(txtSoPtu.Text); // lay so phan tu ra

                if (soPhanTu > 15 || soPhanTu <= 2)
                {
                    MessageBox.Show("2<số phần tử <=15");
                    return; /// mới sửa ngày 20/11
                }
                else
                {
                    //nhapSoptuTC = true;
                    // MessageBox.Show(soPhanTu.ToString());
                    a = new int[soPhanTu];
                    taoMang(150);
                    Random r = new Random();
                    for (i = 0; i < soPhanTu; i++)
                    {

                        mangNhap[i].ForeColor = Color.White;
                        a[i] = r.Next(100);
                        mangNhap[i].Text = a[i].ToString();
                       // daTaoMang = true;
                    }

                }

            }
            catch
            {
                MessageBox.Show(" số phần tử không hợp lệ");
                return;
            }

            //if (nhapSoptuTC == true) // so phan tu thoa mang //// sửa ngày 21/11 : đưa lên bên trên
            //{

            //    a = new int[soPhanTu];
            //    taoMang(150);
            //    Random r = new Random();
            //    for (i = 0; i < soPhanTu; i++)
            //    {
                    
            //        mangNhap[i].ForeColor = Color.White;
            //        a[i] = r.Next(100);
            //        mangNhap[i].Text = a[i].ToString();
            //    }

            //}
        }
        public void taoMang(int kc) //  1.viet ham tao mang 
        {
            switch (soPhanTu)
            {
                case 15:
                case 14:
                case 13:
                case 12:
                case 11:
                    kichThuoc = 50;
                    coChu = 18;
                    khoangCach = 18;
                    canhLe = (this.Width - kichThuoc * soPhanTu - khoangCach * (soPhanTu - 1)) / 2;
                    break;
                case 10:
                case 9:
                case 8:
                case 7:
                case 6:
                case 5:
                case 4:
                case 3:
                case 2:
                    kichThuoc = 65;
                    coChu = 23;
                    khoangCach = 30;//40
                    canhLe = (this.Width - kichThuoc * soPhanTu - khoangCach * (soPhanTu - 1)) / 2;
                    break;
            }


            // khoi tao cac mang chua cac so va chi so 
            mangChiSo = new Label[soPhanTu];
            mangNhap = new Button[soPhanTu];

            // tao cac mang 
            for (i = 0; i < soPhanTu; i++)
            {
                // mangNhap
                mangNhap[i] = new Button();
                mangNhap[i].Text = a[i].ToString();

                mangNhap[i].Width = kichThuoc;
                mangNhap[i].Height = kichThuoc;
                mangNhap[i].Location = new Point(canhLe + (kichThuoc + khoangCach) * i, kc);
                mangNhap[i].ForeColor = Color.White;
                mangNhap[i].FlatStyle = FlatStyle.Flat; // kiểu button 
               // mangNhap[i].FlatAppearance.BorderColor = Color.Green; // màu viền
                mangNhap[i].Font = new Font(this.Font, FontStyle.Bold);
                mangNhap[i].Font = new System.Drawing.Font("Arial", coChu, FontStyle.Bold);
                mangNhap[i].BackColor = Color.Green;
                mangNhap[i].TextAlign = ContentAlignment.MiddleCenter;
              //  mangNhap[i].BackgroundImageLayout = ImageLayout.Stretch;


                this.Controls.Add(mangNhap[i]);
                // mang chi so
                mangChiSo[i] = new Label();
                mangChiSo[i].TextAlign = ContentAlignment.MiddleCenter;
                mangChiSo[i].Text = i.ToString();
                mangChiSo[i].Width = kichThuoc;
                mangChiSo[i].Height = kichThuoc;
                mangChiSo[i].ForeColor = SystemColors.MenuHighlight;
                mangChiSo[i].Location = new Point(canhLe + (kichThuoc + khoangCach) * i, 150 + 3 * kichThuoc);
                if (soPhanTu <= 10)
                {
                    mangChiSo[i].Font = new System.Drawing.Font("Arial", coChu - 10, FontStyle.Regular);
                }
                else
                {
                    mangChiSo[i].Font = new System.Drawing.Font("Arial", coChu, FontStyle.Regular);
                }
                this.Controls.Add(mangChiSo[i]);
            }
            daTaoMang = true;
        }
        public void Xoa_mang(Button[] mangXoa) //2.viet ham xoa mang 
        {

            if (daTaoMang == true)
            {
                for (i = 0; i < soPhanTu; i++)
                {
                    this.Controls.Remove(mangXoa[i]);
                    this.Controls.Remove(mangChiSo[i]);

                }
                daTaoMang = false;
            }

        }

        /// <end phần tạo mảng>
        
         /// <các hàm di chuyển >
        //4. Hàm swap 2 button có thể hiện
        public void DiChuyenHaiButton(Control t1, Control t2)
        {
            

            
            Point p1 = t1.Location; //lưu vị trí ban đầu của t1
            Point p2 = t2.Location; //lưu vị trí ban đầu của t2
            if (p1 != p2)
            {
                // t1 lên, t2 xuống
                while ((t1.Location.Y > p1.Y - (kichThuoc + 5)) || (t2.Location.Y < p2.Y + (kichThuoc + 5)))
                {
                    
                    t1.Top -= 8;
                    t2.Top += 8;
                    Tre(tocDo);

                }
                t1.Top= p1.Y - (kichThuoc + 5); // sua ngay 21/11
                t2.Top = p2.Y + (kichThuoc + 5);// sua ngay 21/11
                // t1 dịch phải, t2 dịch trái
                if (t1.Location.X < t2.Location.X)
                {

                    while ((t1.Location.X < p2.X) || (t2.Location.X > p1.X))
                    {
                        
                        t1.Left += 8;
                        t2.Left -= 8;
                        Tre(tocDo);


                    }
                    t1.Left = p2.X;//sua ngay 21/11
                    t2.Left = p1.X;//sua ngay 21/11
                }
                // t1 dịch trái, t2 dịch phải
                else
                {

                    while ((t1.Location.X > p2.X) || (t2.Location.X < p1.X))
                    {
                        
                        t1.Left -= 8;
                        t2.Left += 8;
                        Tre(tocDo);

                    }
                    t1.Left = p2.X;//sua ngay 21/11
                    t2.Left = p1.X;//sua ngay 21/11

                }
                // t1 xuống, t2 lên
                while ((t1.Location.Y < p2.Y) || (t2.Location.Y > p1.Y))
                {
                    
                    t1.Top += 8;
                    t2.Top -= 8;
                    Tre(tocDo);

                }
                t1.Top = p2.Y ; // sua ngay 21/11
                t2.Top = p1.Y ;// sua ngay 21/11
                t1.Refresh();
                t2.Refresh();
            }
            

        }
        // t dịch chuyển sang Phải Step Node
        public void button_qua_phai(Control t, int Step)
        {

            
            int canhlevitriden = t.Left + ((kichThuoc + khoangCach)) * Step; // vi tri cach le trai mk t di chuyen den 
            while (canhlevitriden > t.Left)
            {
                t.Left += 8;
                Tre(tocDo);
            }
            t.Left = canhlevitriden; //21/11
            t.Refresh();

        }
        // t dịch chuyển sang trai Step Node
        public void button_qua_trai(Control t, int Step)
        {
            
            int canhlevitriden = t.Left - ((kichThuoc + khoangCach)) * Step; // vi tri cach le trai mk t di chuyen den 
            while (canhlevitriden < t.Left)
            {
                t.Left -= 8;
                Tre(tocDo);
            }
            t.Left = canhlevitriden; //21/11/2017
            t.Refresh();


        }
        // t dịch chuyển lên với quãng đường S
        public void button_di_len(Control t, int S)
        {
            //

            //    int loop_Count = S;
            //    //t xuống
            //    while (loop_Count > 0)
            //    {
            //        
            //        t.Top -= 1;
            //        Tre(1);
            //        loop_Count--;
            //    }
            //    t.Refresh();
            
            int canhlevitriden = t.Top - S; // vi tri cach le ben tren mk t di chuyen den 
            while (canhlevitriden < t.Top)
            {
                t.Top -= 8;
                Tre(tocDo);
            }
            t.Top = canhlevitriden; //21/11/2017
            t.Refresh();

        }
        // t dịch chuyển xuống với quãng đường S
        public void button_di_xuong(Control t, int S)
        {
            //

            //    int loop_Count = S;
            //    // t lên
            //    while (loop_Count > 0)
            //    {
            //        
            //        t.Top += 1;
            //        Tre(1);
            //        loop_Count--;
            //    }
            //    t.Refresh();
            
            int canhlevitriden = t.Top + S; // vi tri cach le ben tren mk t di chuyen den 
            while (canhlevitriden > t.Top)
            {
                t.Top += 8;
                Tre(tocDo);
            }
            t.Top = canhlevitriden;
            t.Refresh();

        }

        public void Den_vitri_button(Control t, int i) // đến vị trí button thứ i
        {
            Point p1 = t.Location; // lưu lại vị trí của t
            Point p2 = new Point(canhLe + (kichThuoc + khoangCach) * i, 150);//vị trí của button thứ i
            

            // Di chuyển button lên hoặc xuống nữa đường
            if (p1.Y < p2.Y)
            {
                while (t.Location.Y < p2.Y - ((p2.Y - p1.Y) / 2))
                {
                    
                    t.Top += 8;
                    t.Refresh();
                    Tre(tocDo);

                }
                t.Top = p2.Y - ((p2.Y - p1.Y) / 2);
            }
            else
            {
                while (t.Location.Y > p2.Y + ((p1.Y - p2.Y) / 2))
                {
                    
                    t.Top -= 8;
                    t.Refresh();
                    Tre(tocDo);

                }
                t.Top = p2.Y + ((p1.Y - p2.Y) / 2);
            }
            // Di chuyển button qua phải hoặc trái
            if (p1.X < p2.X)
            {
                while (t.Location.X < p2.X)
                {
                    
                    t.Left += 8;
                    t.Refresh();
                    Tre(tocDo);
                }
                t.Left = p2.X;
            }
            else
            {
                while (t.Location.X > p2.X)
                {
                    
                    t.Left -= 8;
                    t.Refresh();
                    Tre(tocDo);
                }
                t.Left = p2.X;
            }
            // Tiếp tục di chuyển button lên hoặc xuống nữa đường còn lại
            if (p1.Y < p2.Y)
            {
                while (t.Location.Y < p2.Y)
                {
                    
                    t.Top += 8;
                    t.Refresh();
                    Tre(tocDo);

                }
                t.Top = p2.Y;
            }
            else
            {
                while (t.Location.Y > p2.Y)
                {
                    
                    t.Top -= 8;
                    t.Refresh();
                    Tre(tocDo);
                }
                t.Top = p2.Y;
            }

        }
        // Dịch chuyển 1 button về vị trí bằng với X của mangnhap[i]
        public void Den_toado_x_button(Control t, int i)
        {
            Point p1 = t.Location; // lưu lại vị trí của t
            Point p2 = new Point(canhLe + (kichThuoc + khoangCach) * i, 150-2*kichThuoc);//vị trí của button i , p2.Y không quan trọng 
            

            // Di chuyển nút qua phải hoặc trái
            if (p1.X < p2.X)
            {
                while (t.Location.X < p2.X)
                {
                    
                    t.Left += 8;
                    t.Refresh();
                    Tre(tocDo);
                }
                t.Left = p2.X;
            }
            else
            {
                while (t.Location.X > p2.X)
                {
                    
                    t.Left -= 8;
                    t.Refresh();
                    Tre(tocDo);
                }
                t.Left = p2.X;
            }

        }
       
        //Hàm Trễ
        public void Tre(int milisecond)
        {
            ////Nếu tốc độ max thì ko sleep
            int i;
            for (i = 0; i < milisecond; i++)
            {
                //  
                Thread.Sleep(1);
            }
            // 
            //
            //Thread.Sleep(milisecond);
            //
        }
        /// <end các hàm di chuyển >

        /// <các hàm sắp xếp  >
        //Hàm tìm Min trong 2 số a và b
        int min(int a, int b)
        {
            if (a > b)
                return b;
            else
                return a;
        }
        // hoan vi 2 gia tri 
        public void Hoan_vi(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;

        }
        // Hàm hoán vị 2 button
        public void Hoan_vi_Button(int i, int j)
        {
            Button temp = mangNhap[i];
            mangNhap[i] = mangNhap[j];
            mangNhap[j] = temp;

        }
        // quickSort
        void QuickSortTang(int left, int right)
        {
            //5 label
            int i, j, x;
            lstCode.SelectedIndex = 3;
            x = a[(left + right) / 2];
            int chiSoX;
            chiSoX = (left + right) / 2;
            i = left; j = right;
            lbLeft.Visible = true;

            // lb chỉ bị trí left right
            lbLeft.Text = "Left =" + left;
            lbLeft.Location = new Point(mangNhap[left].Location.X, mangNhap[left].Location.Y - 2 * kichThuoc);
            lbRight.Visible = true;
            lbRight.Text = "Right =" + right;
            lbRight.Location = new Point(mangNhap[right].Location.X, mangNhap[right].Location.Y - 2 * kichThuoc);
            // lb chỉ vị trí chỉ số 
            lbChiSo1.Visible = true;
            lbChiSo1.Location = new Point(mangNhap[i].Location.X, mangNhap[i].Location.Y + 2 * kichThuoc);
            lbChiSo1.Text = "i=" + i;
            lbChiSo2.Visible = true;
            lbChiSo2.Location = new Point(mangNhap[j].Location.X, mangNhap[j].Location.Y + 2 * kichThuoc);
            lbChiSo2.Text = "j =" + j;
            // chỉ vị trí của x
            lbPosK.Text = "x = a[" + chiSoX + "]";
            lbPosK.Visible = true;
            lbPosK.Location = new Point(mangNhap[chiSoX].Location.X, mangNhap[chiSoX].Location.Y + kichThuoc);
            do
            {
                lstCode.SelectedIndex = 7;
                while (a[i] < x)
                {
                    i++;

                    lbChiSo1.Visible = true;
                    lbChiSo1.Location = new Point(mangNhap[i].Location.X, mangNhap[i].Location.Y + 2 * kichThuoc);
                    lbChiSo1.Text = "i=" + i;
                    Tre(tocDo*10);

                }
                lstCode.SelectedIndex = 8;
                while (a[j] > x)
                {
                    j--;

                    lbChiSo2.Visible = true;
                    lbChiSo2.Location = new Point(mangNhap[j].Location.X, mangNhap[j].Location.Y + 2 * kichThuoc);
                    lbChiSo2.Text = "j =" + j;
                    Tre(tocDo*10);
                }
                if (i <= j)
                {
                    //mangNhap[i].BackColor = Color.Cyan;
                    //mangNhap[j].BackColor = Color.Cyan;
                    lstCode.SelectedIndex = 11;
                    Hoan_vi(ref a[i], ref a[j]); // hoan doi 2 gia tri
                                                 //Tìm vị trí mới của x
                    if (i == chiSoX)
                    {
                        chiSoX = j;
                    }
                    else if (j == chiSoX)
                    {
                        chiSoX = i;
                    }
                    mangNhap[i].BackColor = Color.Black;
                    mangNhap[j].BackColor = Color.Black;
                    DiChuyenHaiButton(mangNhap[i], mangNhap[j]); // doi cho vi tri 2 button co the hien 
                    Hoan_vi_Button(i, j); // doi cho vi tri  2 button
                    mangNhap[i].BackColor = Color.Green;
                    mangNhap[j].BackColor = Color.Green; // doi mau lại sau khi di chuyển 
                    lbPosK.Text = "x = a[" + chiSoX + "]";
                    lbPosK.Visible = true;
                    lbPosK.Location = new Point(mangNhap[chiSoX].Location.X, mangNhap[chiSoX].Location.Y + kichThuoc);
                    i++; j--;
                    //lbChiSo1.Visible = true;
                    //lbChiSo1.Location = new Point(mangNhap[i].Location.X, mangNhap[i].Location.Y + 2 * kichThuoc);
                    //lbChiSo1.Text = "i=" + i;
                    //Tre(40);
                    //lbChiSo2.Visible = true;
                    //lbChiSo2.Location = new Point(mangNhap[j].Location.X, mangNhap[j].Location.Y + 2 * kichThuoc);
                    //lbChiSo2.Text = "j =" + j;
                    //Tre(40);
                }
            } while (i <= j);

            lstCode.SelectedIndex = 16;
            Tre(tocDo*10);
            if (left < j) 
            {
                QuickSortTang(left, j);
            }
            lstCode.SelectedIndex = 18;
            Tre(tocDo*10);
            if (i < right)
            {
                QuickSortTang(i, right);
            }

        }

        void QuickSortGiam(int left, int right)
        {
            //5 label
            int i, j, x;
            x = a[(left + right) / 2];
            int chiSoX;
            chiSoX = (left + right) / 2;
            i = left; j = right;
            lbLeft.Visible = true;

            // lb chỉ bị trí left right
            lbLeft.Text = "Left =" + left;
            lbLeft.Location = new Point(mangNhap[left].Location.X, mangNhap[left].Location.Y - 2 * kichThuoc);
            lbRight.Visible = true;
            lbRight.Text = "Right =" + right;
            lbRight.Location = new Point(mangNhap[right].Location.X, mangNhap[right].Location.Y - 2 * kichThuoc);
            // lb chỉ vị trí chỉ số 
            lbChiSo1.Visible = true;
            lbChiSo1.Location = new Point(mangNhap[i].Location.X, mangNhap[i].Location.Y + 2 * kichThuoc);
            lbChiSo1.Text = "i=" + i;
            lbChiSo2.Visible = true;
            lbChiSo2.Location = new Point(mangNhap[j].Location.X, mangNhap[j].Location.Y + 2 * kichThuoc);
            lbChiSo2.Text = "j =" + j;
            // chỉ vị trí của x
            lbPosK.Text = "x = a[" + chiSoX + "]";
            lbPosK.Visible = true;
            lbPosK.Location = new Point(mangNhap[chiSoX].Location.X, mangNhap[chiSoX].Location.Y + kichThuoc);
            do
            {
                while (a[i] > x)
                {
                    i++;

                    lbChiSo1.Visible = true;
                    lbChiSo1.Location = new Point(mangNhap[i].Location.X, mangNhap[i].Location.Y + 2 * kichThuoc);
                    lbChiSo1.Text = "i=" + i;
                    Tre(tocDo*10);

                }
                while (a[j] < x)
                {
                    j--;

                    lbChiSo2.Visible = true;
                    lbChiSo2.Location = new Point(mangNhap[j].Location.X, mangNhap[j].Location.Y + 2 * kichThuoc);
                    lbChiSo2.Text = "j =" + j;
                    Tre(tocDo*10);
                }
                if (i <= j)
                {
                    //mangNhap[i].BackColor = Color.Cyan;
                    //mangNhap[j].BackColor = Color.Cyan;
                    Hoan_vi(ref a[i], ref a[j]); // hoan doi 2 gia tri
                                                 //Tìm vị trí mới của x
                    if (i == chiSoX)
                    {
                        chiSoX = j;
                    }
                    else if (j == chiSoX)
                    {
                        chiSoX = i;
                    }
                    mangNhap[i].BackColor = Color.Black;
                    mangNhap[j].BackColor = Color.Black;
                    DiChuyenHaiButton(mangNhap[i], mangNhap[j]); // doi cho vi tri 2 button co the hien 
                    Hoan_vi_Button(i, j); // doi cho vi tri  2 button
                    mangNhap[i].BackColor = Color.Green;
                    mangNhap[j].BackColor = Color.Green; // doi mau lại sau khi di chuyển 
                    lbPosK.Text = "x = a[" + chiSoX + "]";
                    lbPosK.Visible = true;
                    lbPosK.Location = new Point(mangNhap[chiSoX].Location.X, mangNhap[chiSoX].Location.Y + kichThuoc);
                    i++; j--;
                    //lbChiSo1.Visible = true;
                    //lbChiSo1.Location = new Point(mangNhap[i].Location.X, mangNhap[i].Location.Y + 2 * kichThuoc);
                    //lbChiSo1.Text = "i=" + i;
                    //Tre(40);
                    //lbChiSo2.Visible = true;
                    //lbChiSo2.Location = new Point(mangNhap[j].Location.X, mangNhap[j].Location.Y + 2 * kichThuoc);
                    //lbChiSo2.Text = "j =" + j;
                    //Tre(40);
                }
            } while (i <= j);

            if (left < j)
            {
                QuickSortGiam(left, j);
            }
            if (i < right)
            {
                QuickSortGiam(i, right);
            }

        }

        void InterchangeSortTang()
        {
            if (daTaoMang == true)
            {

                for (int k = 0; k < soPhanTu - 1; k++)
                {
                    // lb chỉ vị trí chỉ số 
                    lbChiSo1.Visible = true;
                    lbChiSo1.Location = new Point(mangNhap[k].Location.X, mangNhap[k].Location.Y + 2 * kichThuoc);
                    lbChiSo1.Text = "i=" + k;
                    Tre(tocDo*10);
                    for (int j = k + 1; j < soPhanTu; j++)
                    {
                        lbChiSo2.Visible = true;
                        lbChiSo2.Location = new Point(mangNhap[j].Location.X, mangNhap[j].Location.Y + 2 * kichThuoc);
                        lbChiSo2.Text = "j=" + j;
                        Tre(tocDo*10);
                        //if (Convert.ToInt32(mangNhap[j].Text) < Convert.ToInt32(mangNhap[k].Text))
                        if (a[j] < a[k])
                        {

                            
                            //doi cho hai so va doi cho 2 button
                            int temp = a[k];
                            a[k] = a[j];
                            a[j] = temp;
                            mangNhap[k].BackColor = Color.Black;
                            mangNhap[j].BackColor = Color.Black;
                            DiChuyenHaiButton(mangNhap[k], mangNhap[j]);
                            Tre(tocDo*10); //////////////////////xem lai cho nay 
                            Hoan_vi_Button(k, j);
                            mangNhap[k].BackColor = Color.Green;
                            mangNhap[j].BackColor = Color.Green;
                        }
                    }
                }

            }
        }

        void InterchangeSortGiam()
        {
            if (daTaoMang == true)
            {

                for (int k = 0; k < soPhanTu - 1; k++)
                {
                    // lb chỉ vị trí chỉ số 
                    lbChiSo1.Visible = true;
                    lbChiSo1.Location = new Point(mangNhap[k].Location.X, mangNhap[k].Location.Y + 2 * kichThuoc);
                    lbChiSo1.Text = "i=" + k;
                    Tre(tocDo*10);
                    for (int j = k + 1; j < soPhanTu; j++)
                    {
                        lbChiSo2.Visible = true;
                        lbChiSo2.Location = new Point(mangNhap[j].Location.X, mangNhap[j].Location.Y + 2 * kichThuoc);
                        lbChiSo2.Text = "j=" + j;
                        Tre(tocDo*10);
                        //if (Convert.ToInt32(mangNhap[j].Text) < Convert.ToInt32(mangNhap[k].Text))
                        if (a[j] > a[k])
                        {

                            
                            //doi cho hai so va doi cho 2 button
                            int temp = a[k];
                            a[k] = a[j];
                            a[j] = temp;
                            mangNhap[k].BackColor = Color.Black;
                            mangNhap[j].BackColor = Color.Black;
                            DiChuyenHaiButton(mangNhap[k], mangNhap[j]);
                            Tre(tocDo*10); //////////////////////xem lai cho nay 
                            Hoan_vi_Button(k, j);
                            mangNhap[k].BackColor = Color.Green;
                            mangNhap[j].BackColor = Color.Green;
                        }
                    }
                }

            }
        }

        void InsertionSortGiam()
        {
            if (daTaoMang == true)
            {
                // 2 label
                int i, pos, x;
                Button Node_tam;
                int Chi_so_tam;
                int Dem_node;
                

                for (i = 1; i < soPhanTu; i++)
                {
                    // lb chỉ vị trí chỉ số 
                    lbChiSo1.Visible = true;
                    lbChiSo1.Location = new Point(mangNhap[i].Location.X, mangNhap[i].Location.Y + 2 * kichThuoc);
                    lbChiSo1.Text = "i=" + i;
                    Tre(tocDo*10);
                    //đếm số bước dịch chuyển 1 button
                    Dem_node = 0;
                    x = a[i];
                    Node_tam = mangNhap[i];
                    Chi_so_tam = i;
                    pos = i - 1;
                    lbPosK.Visible = true;
                    lbPosK.Location = new Point(mangNhap[pos].Location.X, mangNhap[pos].Location.Y + 2 * kichThuoc);
                    lbPosK.Text = "pos=" + pos;

                    //Di chuyển button cần chèn lên
                    
                    mangNhap[i].BackColor = Color.Black;
                    button_di_len(Node_tam, (kichThuoc + 5));

                    // Tam_dung();
                    while ((pos >= 0) && (a[pos] < x))
                    {
                        
                        //Tre(40 * 3);
                        //Dịch chuyển button qua phải
                        a[pos + 1] = a[pos];
                        Dem_node++;
                        

                        button_qua_phai(mangNhap[pos], 1);

                        Hoan_vi_Button(pos + 1, pos);
                        pos--;

                        if (pos >= 0)
                        {
                            lbPosK.Visible = true;
                            lbPosK.Location = new Point(mangNhap[pos].Location.X, mangNhap[pos].Location.Y + 2 * kichThuoc);
                            lbPosK.Text = "pos=" + pos;
                            Tre(tocDo*10);
                        }

                        //Tam_dung();
                    }
                    a[pos + 1] = x;
                    
                    button_qua_trai(Node_tam, Dem_node);


                    

                    button_di_xuong(Node_tam, (kichThuoc + 5));
                    mangNhap[i].BackColor = Color.Green; ////////////////////// ?????????
                    Node_tam.BackColor = Color.Green;
                    mangNhap[pos + 1] = Node_tam;
                    //Tam_dung();
                }
            }
        }
        void InsertionSortTang()
        {
            if (daTaoMang == true)
            {
                // 2 label
                int i, pos, x;
                Button Node_tam;
                int Chi_so_tam;
                int Dem_node;
                

                for (i = 1; i < soPhanTu; i++)
                {
                    // lb chỉ vị trí chỉ số 
                    lbChiSo1.Visible = true;
                    lbChiSo1.Location = new Point(mangNhap[i].Location.X, mangNhap[i].Location.Y + 2 * kichThuoc);
                    lbChiSo1.Text = "i=" + i;
                    Tre(tocDo*10);
                    //đếm số bước dịch chuyển 1 button
                    Dem_node = 0;
                    x = a[i];
                    Node_tam = mangNhap[i];
                    Chi_so_tam = i;
                    pos = i - 1;
                    lbPosK.Visible = true;
                    lbPosK.Location = new Point(mangNhap[pos].Location.X, mangNhap[pos].Location.Y + 2 * kichThuoc);
                    lbPosK.Text = "pos=" + pos;

                    //Di chuyển button cần chèn lên
                    
                    mangNhap[i].BackColor = Color.Black;
                    button_di_len(Node_tam, (kichThuoc + 5));

                    // Tam_dung();
                    while ((pos >= 0) && (a[pos] > x))
                    {
                        
                        //Tre(40 * 3);
                        //Dịch chuyển button qua phải
                        a[pos + 1] = a[pos];
                        Dem_node++;
                        

                        button_qua_phai(mangNhap[pos], 1);

                        Hoan_vi_Button(pos + 1, pos);
                        pos--;

                        if (pos >= 0)
                        {
                            lbPosK.Visible = true;
                            lbPosK.Location = new Point(mangNhap[pos].Location.X, mangNhap[pos].Location.Y + 2 * kichThuoc);
                            lbPosK.Text = "pos=" + pos;
                            Tre(tocDo*10);
                        }

                        //Tam_dung();
                    }
                    a[pos + 1] = x;
                    
                    button_qua_trai(Node_tam, Dem_node);


                    

                    button_di_xuong(Node_tam, (kichThuoc + 5));
                    mangNhap[i].BackColor = Color.Green;
                    Node_tam.BackColor = Color.Green;
                    mangNhap[pos + 1] = Node_tam;
                    //Tam_dung();
                }
            }
        }

        // selection sort 
        void SelectionSortTang()
        {
            //2 label
            int min, i, j;
            lstCode.SelectedIndex = 3;
            for (i = 0; i < soPhanTu - 1; i++)
            {
                // cho chỉ số hiện lên 
                lbChiSo1.Visible = true;
                lbChiSo1.Location = new Point(mangNhap[i].Location.X, mangNhap[i].Location.Y + 2 * kichThuoc);
                lbChiSo1.Text = "i=" + i;
                Tre(tocDo*10);
                // gán min=i
                min = i;
                lbPosK.Visible = true;
                lbPosK.Location = new Point(mangNhap[min].Location.X, mangNhap[min].Location.Y + kichThuoc);
                lbPosK.Text = "min=" + min;
                Tre(tocDo*10);


                for (j = i + 1; j < soPhanTu; j++)
                {
                    // hiện chỉ số 
                    lbChiSo2.Visible = true;
                    lbChiSo2.Location = new Point(mangNhap[j].Location.X, mangNhap[j].Location.Y + 2 * kichThuoc);
                    lbChiSo2.Text = "j=" + j;
                    Tre(tocDo*10);

                    if (a[j] < a[min])
                    {
                        min = j;
                        lbPosK.Visible = true;
                        lbPosK.Location = new Point(mangNhap[min].Location.X, mangNhap[min].Location.Y + kichThuoc);
                        lbPosK.Text = "min=" + min;
                        Tre(tocDo*10);

                    }

                }
                Hoan_vi(ref a[min], ref a[i]);
                mangNhap[min].BackColor = Color.Black;
                mangNhap[i].BackColor = Color.Black;
                DiChuyenHaiButton(mangNhap[min], mangNhap[i]);
                mangNhap[min].BackColor = Color.Green;
                mangNhap[i].BackColor = Color.Green;
                Hoan_vi_Button(min, i);
            }
        }
        void SelectionSortGiam()
        {
            //2 label
            int min, i, j;
            for (i = 0; i < soPhanTu - 1; i++)
            {
                // cho chỉ số hiện lên 
                lbChiSo1.Visible = true;
                lbChiSo1.Location = new Point(mangNhap[i].Location.X, mangNhap[i].Location.Y + 2 * kichThuoc);
                lbChiSo1.Text = "i=" + i;
                Tre(tocDo*10);
                // gán min=i
                min = i;
                lbPosK.Visible = true;
                lbPosK.Location = new Point(mangNhap[min].Location.X, mangNhap[min].Location.Y + kichThuoc);
                lbPosK.Text = "min=" + min;
                Tre(tocDo*10);


                for (j = i + 1; j < soPhanTu; j++)
                {
                    // hiện chỉ số 
                    lbChiSo2.Visible = true;
                    lbChiSo2.Location = new Point(mangNhap[j].Location.X, mangNhap[j].Location.Y + 2 * kichThuoc);
                    lbChiSo2.Text = "j=" + j;
                    Tre(tocDo*10);

                    if (a[j] > a[min])
                    {
                        min = j;
                        lbPosK.Visible = true;
                        lbPosK.Location = new Point(mangNhap[min].Location.X, mangNhap[min].Location.Y + kichThuoc);
                        lbPosK.Text = "min=" + min;
                        Tre(tocDo*10);

                    }

                }
                Hoan_vi(ref a[min], ref a[i]);
                mangNhap[min].BackColor = Color.Black;
                mangNhap[i].BackColor = Color.Black;
                DiChuyenHaiButton(mangNhap[min], mangNhap[i]);
                mangNhap[min].BackColor = Color.Green;
                mangNhap[i].BackColor = Color.Green;
                Hoan_vi_Button(min, i);
            }
        }
        //Bubble sort
        void BubbleSortTang()
        {
            // 2 label
            int i, j;
            for (i = 0; i < soPhanTu - 1; i++)
            {
                // cho chỉ số hiện lên 
                lbChiSo1.Visible = true;
                lbChiSo1.Location = new Point(mangNhap[i].Location.X, mangNhap[i].Location.Y + 2 * kichThuoc);
                lbChiSo1.Text = "i=" + i;
                Tre(tocDo*10);
                for (j = soPhanTu - 1; j > i; j--)
                {
                    // cho chỉ số hiện lên 
                    lbChiSo2.Visible = true;
                    lbChiSo2.Location = new Point(mangNhap[j].Location.X, mangNhap[j].Location.Y + 2 * kichThuoc);
                    lbChiSo2.Text = "j=" + j;
                    Tre(tocDo*10);
                    if (a[j] < a[j - 1])
                    {
                        Hoan_vi(ref a[j], ref a[j - 1]);
                        mangNhap[j].BackColor = Color.Black;
                        mangNhap[j-1].BackColor = Color.Black;
                        DiChuyenHaiButton(mangNhap[j], mangNhap[j - 1]);
                        // Tam_dung();
                        mangNhap[j].BackColor = Color.Green;
                        mangNhap[j-1].BackColor = Color.Green;
                        Hoan_vi_Button(j, j - 1);

                    }
                }

            }
        }
        void BubbleSortGiam()
        {
            // 2 label
            int i, j;
            for (i = 0; i < soPhanTu - 1; i++)
            {
                // cho chỉ số hiện lên 
                lbChiSo1.Visible = true;
                lbChiSo1.Location = new Point(mangNhap[i].Location.X, mangNhap[i].Location.Y + 2 * kichThuoc);
                lbChiSo1.Text = "i=" + i;
                Tre(tocDo*10);
                for (j = soPhanTu - 1; j > i; j--)
                {
                    // cho chỉ số hiện lên 
                    lbChiSo2.Visible = true;
                    lbChiSo2.Location = new Point(mangNhap[j].Location.X, mangNhap[j].Location.Y + 2 * kichThuoc);
                    lbChiSo2.Text = "j=" + j;
                    Tre(tocDo*10);
                    if (a[j] > a[j - 1])
                    {
                        Hoan_vi(ref a[j], ref a[j - 1]);
                        mangNhap[j].BackColor = Color.Black;
                        mangNhap[j - 1].BackColor = Color.Black;
                        DiChuyenHaiButton(mangNhap[j], mangNhap[j - 1]);
                        // Tam_dung();
                        mangNhap[j].BackColor = Color.Green;
                        mangNhap[j - 1].BackColor = Color.Green;
                        Hoan_vi_Button(j, j - 1);

                    }
                }

            }
        }

        // ham phan phoi a cho b va c 
        void Distribute(ref int nb, ref int nc, int k)
        {
            // 1 label
            for (int x = 0; x < soPhanTu; x++)
            {
                mangChiSo[x].Visible = false;
            }
            int i, pa, pb, pc;
            pa = pb = pc = 0;
            while (pa < soPhanTu) //duyet tat ca cac so trong mang
            {
                for (i = 0; (pa < soPhanTu) && (i < k); i++, pa++, pb++) // k se chay tu 1 2 4 8 ....
                {
                    b[pb] = a[pa]; // dua gia tri vao mang b theo chi so  
                    MangB[pb] = mangNhap[pa];
                    button_di_len(MangB[pb], 2 * kichThuoc);
                    Den_toado_x_button(MangB[pb], pb);
                    //Tam_dung();


                }
                for (i = 0; (pa < soPhanTu) && (i < k); i++, pa++, pc++)
                {
                    c[pc] = a[pa]; // dua gia tri tu mang a vao mang c theo chi so 
                    MangC[pc] = mangNhap[pa];
                    button_di_xuong(MangC[pc], 2*kichThuoc);
                    Den_toado_x_button(MangC[pc], pc);
                    //Tam_dung();

                }
                // qua cac vong lap thi gia tri pa,pb ,pc duoc luu lai
            }
            nb = pb;
            nc = pc;
        }

        // sap xep tron tang 
        void MergeTang(int nb, int nc, int k)
        {
            int pa, pb, pc, ib, ic, kb, kc, lennb, lennc;
            //lưu những giá trị để đếm Node dư   
            lennb = nb; // số phần tử ban đầu mảng b
            lennc = nc;
            //lennb -nb,lennc-nc là vị trí node dư còn lại của mảng b,mảng c sau khi sử dụng while((nb > 0) && (nc > 0))
            pa = pb = pc = 0; ib = ic = 0; // pb,pc la vi trí bắt đầu xét tiếp sau mỗi lần có k*2 phần tử  di chuyển về mảng a ,ví dụ khi k =2 , mình di chuyển 2 nút từ mảng b xuống mảng a thì phần tử xét tiếp là mangb[pb]
            while ((nb > 0) && (nc > 0))//điều kiện sai là nb =0 hoặc nc=0 :)),nb,nc sẽ là số phần tử còn lại khi sử dụng hết while
            {
                kb = min(k, nb);
                kc = min(k, nc);
                if (b[pb + ib] <= c[pc + ic])
                {
                    a[pa] = b[pb + ib];
                    
                        Den_vitri_button(MangB[pb + ib], pa);
                    

                    //Tam_dung();
                    mangNhap[pa] = MangB[pb + ib];
                    pa++;
                    ib++;
                    if (ib == kb)
                    {
                        for (; ic < kc; ic++)
                        {
                            a[pa] = c[pc + ic];
                            
                            
                                Den_vitri_button(MangC[pc + ic], pa);
                            

                            //Tam_dung();
                            mangNhap[pa] = MangC[pc + ic];
                            pa++;

                        }
                        pb += kb; //kb ban đầu = 0 ,sau mỗi lần di chuyển 2 node trên dưới ,4 node trên dưới hoặc 8 node trên dưới thì cộng vào để so sánh ở bị trí kế tiếp ... :)) giang cmt 
                        pc += kc;
                        ib = ic = 0;
                        nb -= kb;//sau moi lan di chuyen ve mảng a thì số phần tử mảng b giảm kb :))
                        nc -= kc;
                    }

                }
                else
                {
                    a[pa] = c[pc + ic];
                    
                    
                        Den_vitri_button(MangC[pc + ic], pa);
                        //Tam_dung();
                    

                    mangNhap[pa] = MangC[pc + ic];
                    pa++;
                    ic++;
                    if (ic == kc)
                    {
                        for (; ib < kb; ib++)
                        {
                            a[pa] = b[pb + ib];
                            
                            
                                Den_vitri_button(MangB[pb + ib], pa);
                            

                            //Tam_dung();
                            mangNhap[pa] = MangB[pb + ib];
                            pa++;

                        }
                        pb += kb;
                        pc += kc;
                        ib = ic = 0;
                        nb -= kb;
                        nc -= kc; // nb, nc la so phan tu con lai , dung để đếm node dư 
                    }
                }
            }
            //di chuyen node thua vao vi tri 
            for (; nb > 0; nb--)
            {
                
                
                
                    Den_vitri_button(MangB[lennb - nb], pa);
              

                //Tam_dung();
                pa++;
            }
            for (; nc > 0; nc--)
            {
                
                
                    Den_vitri_button(MangC[lennc - nc], pa);
                

                //Tam_dung();
                pa++;
            }
        }

        void MergeGiam(int nb, int nc, int k)
        {
            int pa, pb, pc, ib, ic, kb, kc, lennb, lennc;
            //lưu những giá trị để đếm Node dư   
            lennb = nb;
            lennc = nc;
            pa = pb = pc = 0; ib = ic = 0; // pb,pc la vi trí bắt đầu xét tiếp sau mỗi lần di chuyển về mảng a 
            while ((nb > 0) && (nc > 0))//điều kiện sai là nb =0 hoặc nc=0 :))
            {
                kb = min(k, nb);
                kc = min(k, nc);
                if (b[pb + ib] >= c[pc + ic])
                {
                    a[pa] = b[pb + ib];
                    
                        Den_vitri_button(MangB[pb + ib], pa);
                    

                    //Tam_dung();
                    mangNhap[pa] = MangB[pb + ib];
                    pa++;
                    ib++;
                    if (ib == kb)
                    {
                        for (; ic < kc; ic++)
                        {
                            a[pa] = c[pc + ic];
                            
                            
                                Den_vitri_button(MangC[pc + ic], pa);
                          

                            //Tam_dung();
                            mangNhap[pa] = MangC[pc + ic];
                            pa++;

                        }
                        pb += kb; //kb ban đầu = 0 ,sau mỗi lần di chuyển 2 node trên dưới ,4 node trên dưới hoặc 8 node trên dưới thì cộng vào để so sánh ở bị trí kế tiếp ... :)) giang cmt 
                        pc += kc;
                        ib = ic = 0;
                        nb -= kb;//sau moi lan di chuyen ve mảng a thì số phần tử mảng b giảm kb :))
                        nc -= kc;
                    }

                }
                else
                {
                    a[pa] = c[pc + ic];
                    
                    
                        Den_vitri_button(MangC[pc + ic], pa);
                        //Tam_dung();
                   

                    mangNhap[pa] = MangC[pc + ic];
                    pa++;
                    ic++;
                    if (ic == kc)
                    {
                        for (; ib < kb; ib++)
                        {
                            a[pa] = b[pb + ib];
                            
                            
                                Den_vitri_button(MangB[pb + ib], pa);
                            

                            //Tam_dung();
                            mangNhap[pa] = MangB[pb + ib];
                            pa++;

                        }
                        pb += kb;
                        pc += kc;
                        ib = ic = 0;
                        nb -= kb;
                        nc -= kc;
                    }
                }
            }
            //di chuyen node thua vao vi tri 
            for (; nb > 0; nb--)
            {
                
                
                    Den_vitri_button(MangB[lennb - nb], pa);
                

                //Tam_dung();
                pa++;
            }
            for (; nc > 0; nc--)
            {
                
                
                    Den_vitri_button(MangC[lennc - nc], pa);
                

                //Tam_dung();
                pa++;
            }
        }

        // ham chua distribute va merge tang 

        void MergeSortTang(int n)
        {
            int k, nc = 0, nb = 0;
            for (k = 1; k < n; k *= 2)
            {
                lbPosK.Text = "k = " + k;
                lbPosK.Visible = true;
                lbPosK.Location = new Point(this.Width / 2, 20);

                Distribute(ref nb, ref nc, k);
                MergeTang(nb, nc, k);

            }
        }
        void MergeSortGiam(int n)
        {
            int k, nc = 0, nb = 0;
            for (k = 1; k < n; k *= 2)
            {
                lbPosK.Text = "k = " + k;
                lbPosK.Visible = true;
                lbPosK.Location = new Point(this.Width / 2, 20);

                Distribute(ref nb, ref nc, k);
                MergeGiam(nb, nc, k);

            }
        }

       
        /// <end các hàm sắp xếp  >
        
            // sử lý thread để hủy tiến trình khi muốn đổi hủy quá trình 

        Thread TestThread;

         Action hamSapXep;
        

        public void BatDauSapXep()
        {


            if (TestThread != null)   // Hủy thread nếu vẫn đang chạy
            {
                TestThread.Abort();
            }


            TestThread = new Thread(new ThreadStart(hamSapXep));
            TestThread.Start();

            // Dùng thread vì : có thể abort khi nào cần, task k làm đc
            
        }
        public void giang()////////////////////////////
        {
            btnSapXep.Enabled = false;
            lbChiSo1.Visible = false;
            lbChiSo2.Visible = false;
            lbLeft.Visible = false;
            lbRight.Visible = false;
            lbPosK.Visible = false;
            // tocDo = 4;
            if (raBubble.Checked == true && raTang.Checked == true)
                {
                    
                    BubbleSortTang();
                
            }
                else if (raBubble.Checked == true && raGiam.Checked == true) // dùng else if để tránh khi nó đang chạy tăng mà mình chọn rad giảm thì nó sắp tăng rồi nó lại sắp giảm 
                {
                    
                    BubbleSortGiam();
                   
            }
            else if (raQuick.Checked == true && raTang.Checked == true)
                {
                lbChiSo1.Visible = false;
                lbChiSo2.Visible = false;
                QuickSortTang(0, soPhanTu - 1);
                    
            }
            else if(raQuick.Checked == true && raGiam.Checked == true)
                {
                lbChiSo1.Visible = false;
                lbChiSo2.Visible = false;
                QuickSortGiam(0, soPhanTu - 1);
                    
            }
            else if (raSelection.Checked == true && raTang.Checked == true)
                {
                    lbLeft.Visible = false;
                    lbRight.Visible = false;
                    
                    SelectionSortTang();
                    
            }
            else if (raSelection.Checked == true && raGiam.Checked == true)
                {
                lbLeft.Visible = false;
                lbRight.Visible = false;
                SelectionSortGiam();
                    
            }
            else if (raInsertion.Checked == true && raTang.Checked == true)
                {
                lbLeft.Visible = false;
                lbRight.Visible = false;
                lbChiSo2.Visible = false;
                InsertionSortTang();
                
            }
            else if (raInsertion.Checked == true && raGiam.Checked == true)
                {
                lbLeft.Visible = false;
                lbRight.Visible = false;
                lbChiSo2.Visible = false;
                InsertionSortGiam();
                
            }
            else if (raMerge.Checked == true && raTang.Checked == true)
                {
                lbLeft.Visible = false;
                lbRight.Visible = false;
                lbChiSo2.Visible = false;
                lbChiSo1.Visible = false;
                b = new int[soPhanTu];
                    c = new int[soPhanTu];
                    MangB = new Button[soPhanTu];
                    MangC = new Button[soPhanTu];
                    MergeSortTang(soPhanTu);
                
            }
            else if (raMerge.Checked == true && raGiam.Checked == true)
                {
                lbLeft.Visible = false;
                lbRight.Visible = false;
                lbChiSo2.Visible = false;
                lbChiSo1.Visible = false;
                b = new int[soPhanTu];
                    c = new int[soPhanTu];
                    MangB = new Button[soPhanTu];
                    MangC = new Button[soPhanTu];
                    MergeSortGiam(soPhanTu);
                
            }
            else if (raInterchange.Checked == true && raTang.Checked == true)
                {
                lbLeft.Visible = false;
                lbRight.Visible = false;
                lbPosK.Visible = false;
                InterchangeSortTang();
              
            }
            else if (raInterchange.Checked == true && raGiam.Checked == true)
                {
                lbLeft.Visible = false;
                lbRight.Visible = false;
                lbPosK.Visible = false;
                InterchangeSortGiam();
               
            }
            btnSapXep.Enabled = true;
            btnPause.Enabled = false;
            btnNgauNhien.Enabled =true;
            btnNhapMang.Enabled = true;
            btnNhapTay.Enabled = true;
            
        }

        
        /// <chạy các nút sắp xếp và hủy >
        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (daTaoMang == true)
            {
                
                btnNgauNhien.Enabled = false;
                btnNhapMang.Enabled = false;
                btnNhapTay.Enabled = false;
                btnPause.Enabled = true;
                hamSapXep = giang;
                //trackBar1.Value = 5; // cho track bar chay ve giua 
                BatDauSapXep();
                lbChiSo1.Visible = true;
                lbChiSo2.Visible = true;
                lbLeft.Visible = true;
                lbRight.Visible = true;
                lbPosK.Visible = true;// chạy xong cho hiện text lên 


            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (daTaoMang == true)
            {
                //Xoa_mang(mangNhap);
                //daTaoMang = false;
               
                if (testPause == true) // khi mà nó đang tạm dừng thì thread.abort không được , phải chạy tiếp thread 
                {
                    TestThread.Resume();
                    //Tre(30);
                    if (TestThread != null)   // Hủy thread nếu vẫn đang chạy
                    {
                        TestThread.Abort();
                    }

                }
                else 
                {
                    if (TestThread != null)   // Hủy thread nếu vẫn đang chạy
                    {
                        TestThread.Abort();
                    }
                    
                        

                }

                Xoa_mang(mangNhap);
                daTaoMang = false;
                lbChiSo1.Visible = false; // cho nay co the dư
                lbChiSo2.Visible = false;
                lbLeft.Visible = false;
                lbRight.Visible = false;
                lbPosK.Visible = false;
                btnSapXep.Enabled = true;
                btnPause.Text = "Tạm dừng";
                btnPause.Enabled = false;
                btnNgauNhien.Enabled = true;
                btnNhapTay.Enabled = true;
                btnNhapMang.Enabled = true;
                testPause = false; // khi ngẫu nhiên -> sắp xếp -> tạm dừng thì biến testpause nó = true ,nên khi hủy thì biến testpause nó vẫn true nên  nhấn ngẫu nhiên -> hủy thì nó vào trường hợp if(testpause == true) mà trong đó thread chưa chạy nên nó bị lỗi , nên sau khi nhấn hủy thì phải đưa testpause = false luôn 
            }
        }
        
        private void btnPause_Click(object sender, EventArgs e)
        {
            
                if (btnPause.Text == "Tạm dừng")
                {
                    btnPause.Text = "Tiếp tục";

                    TestThread.Suspend(); // dung tam thoi thread 
                    testPause = true;
                }
                else
                {
                    btnPause.Text = "Tạm dừng";

                    TestThread.Resume();
                    testPause = false;
                }
            
        }
        private void trackBar1_Scroll(object sender, EventArgs e) // chon toc do 
        {
            if (trackBar1.Value == 10)
            {
                tocDo = 0;
            }
            else if (trackBar1.Value == 9)
            {
                tocDo = 1;
            }
            else if (trackBar1.Value == 8)
            {
                tocDo = 2;
            }
            else if (trackBar1.Value == 7)
            {
                tocDo = 3;
            }
            else if (trackBar1.Value == 6)
            {
                tocDo = 4;
            }
            else if (trackBar1.Value == 5)
            {
                tocDo = 5;
            }
            else if (trackBar1.Value == 4)
            {
                tocDo = 6;
            }
            else if (trackBar1.Value == 3)
            {
                tocDo = 7;
            }
            else if (trackBar1.Value == 2)
            {
                tocDo = 8;
            }
            else if (trackBar1.Value == 1)
            {
                tocDo = 9;
            }
            else
                tocDo = 10;
        }

        ///  < end chạy các nút sắp xếp và hủy >

        ///  < khi chọn các radiobtn khác >
        private void raSelection_CheckedChanged(object sender, EventArgs e)
        {
            if(raSelection.Checked == true && raTang.Checked == true)
            {
                lstCode.Items.Clear();
                code.SelectionSort(lstCode, tang);
            }
            if (raSelection.Checked == true && raGiam.Checked == true)
            {
                lstCode.Items.Clear();
                code.SelectionSort(lstCode, false);
            }



        }

        private void raBubble_CheckedChanged(object sender, EventArgs e)
        {
            if (raBubble.Checked == true && raTang.Checked == true)
            {
                lstCode.Items.Clear();
                code.Bubblesort(lstCode, tang);
            }
            if (raBubble.Checked == true && raGiam.Checked == true)
            {
                lstCode.Items.Clear();
                code.Bubblesort(lstCode, false);
            }


        }

        private void raQuick_CheckedChanged(object sender, EventArgs e)
        {
            if (raQuick.Checked == true && raTang.Checked == true)
            {
                lstCode.Items.Clear();
                code.quicksort(lstCode, tang);
            }
            if (raQuick.Checked == true && raGiam.Checked == true)
            {
                lstCode.Items.Clear();
                code.quicksort(lstCode, false);
            }

        }

        private void raInsertion_CheckedChanged(object sender, EventArgs e)
        {

            if (raInsertion.Checked == true && raTang.Checked == true)
            {
                lstCode.Items.Clear();
                code.insertionsort(lstCode, tang);
            }
            if (raInsertion.Checked == true && raGiam.Checked == true)
            {
                lstCode.Items.Clear();
                code.insertionsort(lstCode, false);
            }
        } 

        private void raInterchange_CheckedChanged(object sender, EventArgs e)
        {
            if (raInterchange.Checked == true && raTang.Checked == true)
            {
                lstCode.Items.Clear();
                code.interchangesort(lstCode, tang);
            }
            if (raInterchange.Checked == true && raGiam.Checked == true)
            {
                lstCode.Items.Clear();
                code.interchangesort(lstCode, false);
            }

        }

        private void raMerge_CheckedChanged(object sender, EventArgs e)
        {
            if (raMerge.Checked == true && raTang.Checked == true)
            {
                lstCode.Items.Clear();
                code.Mergesort(lstCode, tang);
            }
            if (raMerge.Checked == true && raGiam.Checked == true)
            {
                lstCode.Items.Clear();
                code.Mergesort(lstCode, false);
            }

        }

        private void raGiam_CheckedChanged(object sender, EventArgs e)
        {
            if (raGiam.Checked == true)
            {
                tang = false;

            }
            else
                tang = true;
            lstCode.Items.Clear();
            if (raInsertion.Checked == true)
                code.insertionsort(lstCode, tang);
            if (raQuick.Checked == true)
                code.quicksort(lstCode, tang);
            if (raMerge.Checked == true)
                code.quicksort(lstCode, tang);
            if (raInterchange.Checked == true)
                code.interchangesort(lstCode, tang);
            if (raSelection.Checked == true)
                code.SelectionSort(lstCode, tang);
            if (raBubble.Checked == true)
                code.Bubblesort(lstCode, tang);
             

        }

        private void raTang_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        ///  < end khi chọn các radiobtn khác >

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tocDo = 5;
            raTang.Checked = true;
            raBubble.Checked = true;
            btnPause.Enabled = false;
           lstCode.Font = new System.Drawing.Font("Times New Roman", 12, FontStyle.Regular); // chỉnh bên trong listcode
        }

        
    }
}

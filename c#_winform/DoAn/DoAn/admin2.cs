using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTO;
using BUS;

namespace DoAn
{
    public partial class admin2 : UserControl
    {
        public admin2()
        {
            InitializeComponent();
        }
        FormOk ok = new FormOk();
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if(taikhoan.Text==""||matkhautb.Text==""||emailtb.Text==""||chucvutb.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!!!");
            }
            else
            {
                try
                {
                    TaiKhoan_BUS.insertTK(taikhoan.Text, matkhautb.Text, emailtb.Text, chucvutb.Text);
                    ok.Show();
                }
                catch (Exception)
                {
                        MessageBox.Show("Tài khoản đã được sử dụng!!!");

                }
                
            }
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            taikhoan.Text = "";
            matkhautb.Text = "";
            emailtb.Text = "";
            chucvutb.Text = "";
        }
    }    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace DoAn
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
             
        }
       
        public static string taikhoan="";
        Form2 frm2 = new Form2();
        Form3 frm3 = new Form3();
        Form5 frm5 = new Form5();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            
        }



        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }


        private void bunifuTextbox1_KeyDown(object sender, EventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    bunifuThinButton21_Click(sender, e);
            //}
            if (textbox1.text == "Nhập Username")
            {
                textbox1._TextBox.Clear();
            }


        }
        private void bunifuTextbox2_KeyDown(object sender, EventArgs e)
        {
            
            if (textbox2.text == "Nhập Password")
            {
                textbox2._TextBox.Clear();
            }
            textbox2._TextBox.PasswordChar = '*';
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            frm2.Close();
            this.Close();
            
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            
            frm2.Show();
            timer1.Start();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            this.TopMost = true;
            frm2.TopMost = false;
            frm2.Show();
            frm2.Left += 10;
            if (frm2.Left >= 830)
            {
               
                timer1.Stop();
                this.TopMost = false;
                frm2.TopMost = true;
                timer2.Start();
            }

            //if (kt ==1)
            //{
            //    frm2.Show();
            //    timer2.Start();
            //}

        }

        private void timer2_Tick(object sender, EventArgs e)
        {


            frm2.Left -= 10;
            if (frm2.Left <= 510)
            {
                timer2.Stop();
                //this.Hide();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(TaiKhoan_BUS.dangnhap(textbox1.text,textbox2.text)==null)
            {
                baoloi.Text = "Đăng Nhập Thất Bại!!!";
            }
            else
            {
                TaiKhoan_DTO tk = new TaiKhoan_DTO();
                tk = TaiKhoan_BUS.dangnhap(textbox1.text, textbox2.text);
                taikhoan = textbox1.text;
                if(tk.Chucvu=="admin")
                {
                    this.Hide();
                    frm5.Show();                 
                }
                if (tk.Chucvu == "giaovien")
                {
                    this.Hide();
                    frm3.Show();
                }
            }
                
        }
    }
}

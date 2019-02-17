using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using BUS;
namespace DoAn
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //Form1 frm1 = new Form1();
        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

       

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            //frm1.Show();
            this.Hide();
           
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            //frm1.Show();
            this.Hide();
        }
        private string RandomString()
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < 8; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                string a = RandomString();
                string mailmk = "Mật khẩu mới của bạn là:" + a + "";
                string email = TaiKhoan_BUS.layEmail(bunifuTextbox1.text);
                TaiKhoan_BUS.resetPass(bunifuTextbox1.text, a);
                MailMessage mail = new MailMessage("cuonganh365@gmail.com", email, "MAIL KHTN", mailmk);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("cuonganh365@gmail.com", "1234567890qwertyu");
                client.EnableSsl = true;
                client.Send(mail);
                baoloi.Text = "Thành Công!!";
            }
            catch (Exception)
            {
                baoloi.Text = "Thất Bại!!";
            }
        }

        private void bunifuTextbox1_KeyDown(object sender, EventArgs e)
        {
            if (bunifuTextbox1.text == "Nhập Username")
            {
                bunifuTextbox1._TextBox.Clear();
            }
        }

        

       
    }
}

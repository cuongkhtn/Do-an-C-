using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace DoAn
{
    public partial class gv2 : UserControl
    {
        public  gv2()
        {
            InitializeComponent();
        }
        public static int namhoc2;
        public static int hocky2;
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int k = 1;
            if(comboBox1.Text =="" && bunifuMetroTextbox2.Text=="")
            {
                MessageBox.Show("Nhap ma chuyen de hoac ten chuyen de");
                k = 0;
            }
            if (comboBox2.Text == "" && bunifuMetroTextbox1.Text == "")
            {
                MessageBox.Show("Nhap ma sinh vien hoac ten sinh vien");
                k = 0;
            }
            if (comboBox1.Text == "" && bunifuMetroTextbox2.Text != "")
            {
                comboBox1.Text = ChuyenDe_BUS.laymacd(bunifuMetroTextbox2.Text).ToString();
            }
            if (comboBox2.Text == "" && bunifuMetroTextbox1.Text != "")
            {
                comboBox2.Text = SinhVien_BUS.layMaSV(bunifuMetroTextbox1.Text).ToString();
            }
            if (k == 1)
            {
                List<KetQua_DTO> listKQ = KetQua_BUS.loadKetQua(int.Parse(comboBox2.Text), int.Parse(comboBox1.Text), HocKy_BUS.layMaHK(namhoc.selectedValue, bunifuDropdown2.selectedIndex + 1));
                thongtintracuudtgd.AutoGenerateColumns = false;
                thongtintracuudtgd.DataSource = listKQ;
            }
        }
    
       
        //private void comboBox1_Click(object sender, EventArgs e)
        //{
        //    gv2_Load_1(sender, e);

        //}

        private void gv2_Load_1(object sender, EventArgs e)
        {
            if (gv1.mcd.ToString() != "-1")
                comboBox1.Text = gv1.mcd.ToString();
            //MessageBox.Show(gv1.mcd.ToString());
            if (gv1.tencd.ToString() != "")
                bunifuMetroTextbox2.Text = gv1.tencd.ToString();
            List<ChuyenDe_DTO> listCD = ChuyenDe_BUS.loadChuyenDe1();
            List<string> items;
            items = HocKy_BUS.loadNamHoc();
            int n = items.Count, i = 0;
            string[] a = new string[n];
            foreach (String it in items)
            {
                a[i] = it;
                i++;

            }
            namhoc.Items = a;
            namhoc.selectedIndex = gv1.namhoc1;
            String[] itemshk = { "1", "2" };
            bunifuDropdown2.Items = itemshk;

            bunifuDropdown2.selectedIndex = gv1.hocky1;
        }

        private void gv2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if(gv1.blev==true)
            {
                gv2_Load_1(sender, e);
                gv1.blev = false;
            }          
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (gv1.blev == true)
            {
                gv2_Load_1(sender, e);
                gv1.blev = false;
            }          
        }

        private void bunifuCustomDataGrid1_MouseMove(object sender, MouseEventArgs e)
        {
            if (gv1.blev == true)
            {
                gv2_Load_1(sender, e);
                gv1.blev = false;
            }          
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            int k = 1;
            if (comboBox1.Text == "" && bunifuMetroTextbox2.Text == "")
            {
                MessageBox.Show("Nhap ma chuyen de hoac ten chuyen de");
                k = 0;
            }
            if (comboBox1.Text == "" && bunifuMetroTextbox2.Text != "")
            {
                comboBox1.Text = ChuyenDe_BUS.laymacd(bunifuMetroTextbox2.Text).ToString();
            }
            if (k == 1)
            {
                List<KetQua_DTO> listKQ = KetQua_BUS.loadKetQuaAll(int.Parse(comboBox1.Text), HocKy_BUS.layMaHK(namhoc.selectedValue, bunifuDropdown2.selectedIndex + 1));
                thongtintracuudtgd.AutoGenerateColumns = false;
                thongtintracuudtgd.DataSource = listKQ;
            }
        }
    }
}

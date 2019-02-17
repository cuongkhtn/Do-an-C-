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
    public partial class admin1 : UserControl
    {
        public admin1()
        {
            InitializeComponent();
        }
        FormOk ok = new FormOk();
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
        public void loadThongTinChuyenDe()
        {
            List<ChuyenDe_DTO> listCD = ChuyenDe_BUS.loadChuyenDe();
            dtgv2.AutoGenerateColumns = false;
            dtgv2.DataSource = listCD;
            //for (int i = 0; i < dtgv2.Rows.Count; i++)
            //{
            //    if(dtgv2.Rows[i].Cells[4].Value.ToString()=="MỞ")
            //    {
            //        dtgv2.Rows[i].Cells[5].ReadOnly = true;
            //    }
            //    else
            //    {
            //        dtgv2.Rows[i].Cells[6].ReadOnly = true;
            //    }
            //}
            //dtgv2.Rows[1].Cells[4].Text = "aa";
            //dtgv2.Columns[8].Visible = false;

        }
        private void admin1_Load(object sender, EventArgs e)
        {
            loadThongTinChuyenDe();
            textbox1.Text = "AUTO";
            textbox1.Enabled = true;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                ChuyenDe_BUS.insertCD(textbox2.Text, int.Parse(textbox3.Text), DateTime.Parse(textbox4.Text));
                List<ChuyenDe_DTO> listCD = ChuyenDe_BUS.loadChuyenDe();
                dtgv2.AutoGenerateColumns = false;
                dtgv2.DataSource = listCD;
                 ok.Show();
            }
            catch ( Exception)
            {
                if (textbox2.Text == "" || textbox3.Text == "" || textbox4.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu!");
                }
                else 
                {
                    MessageBox.Show("Loi kieu du lieu!");
                }
                
            }
           
        }
        private void textbox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            MessageBox.Show("Mã được thêm tự động");
            textbox1.Text = "AUTO";
           
        }

        private void dtgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int x = e.RowIndex;
            int y = e.ColumnIndex;
            if (y == 5)
            {
                ChuyenDe_BUS.updateCDM(int.Parse(dtgv2.Rows[e.RowIndex].Cells[0].Value.ToString()));
                dtgv2.Rows[e.RowIndex].Cells[4].Value ="MỞ";
                ok.Show();
            }
            if (y == 6)
            {
                ChuyenDe_BUS.updateCDĐ(int.Parse(dtgv2.Rows[e.RowIndex].Cells[0].Value.ToString()));
                dtgv2.Rows[e.RowIndex].Cells[4].Value = "ĐÓNG";
                ok.Show();
            }
            if (y == 7)
            {

                try
                {
                    ChuyenDe_BUS.updateCDUD(int.Parse(dtgv2.Rows[e.RowIndex].Cells[0].Value.ToString()), dtgv2.Rows[e.RowIndex].Cells[1].Value.ToString(), int.Parse(dtgv2.Rows[e.RowIndex].Cells[2].Value.ToString()), DateTime.Parse(dtgv2.Rows[e.RowIndex].Cells[3].Value.ToString()));
                    ok.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Loi kieu du lieu!");
                }
           
                
            }
            if (y == 8)
            {
                ChuyenDe_BUS.xoaCD(int.Parse(dtgv2.Rows[e.RowIndex].Cells[0].Value.ToString()));
                //dtgv2.Rows.RemoveAt(2); 
                List<ChuyenDe_DTO> listCD = ChuyenDe_BUS.loadChuyenDe();
                dtgv2.AutoGenerateColumns = false;
                dtgv2.DataSource = listCD;
                ok.Show();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            textbox2.Text = "";
            textbox3.Text = "";
            textbox4.Text = "";
        }
        
    }
}

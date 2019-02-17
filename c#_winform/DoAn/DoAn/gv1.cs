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
    public partial class gv1 : UserControl
    {
        public gv1()
        {
            InitializeComponent();
        }

        //voer.edu.vn/c/delegate-va-event/9f00d32d/56bd675f
        public static int mcd=-1;
        public static string tencd="";
        public static int namhoc1;
        public static int hocky1;
        public static bool blev=true;
        string namhoc11;
        FormOk ok = new FormOk();
        public event EventHandler ButtonClick = null;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
       
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
        public void loadThongTinChuyenDe()
        {
            List<ChuyenDe_DTO> listCD = ChuyenDe_BUS.loadChuyenDe1();
            ttcd_dtgv.AutoGenerateColumns = false;
            ttcd_dtgv.DataSource = listCD;
            List<string> items;
            items = HocKy_BUS.loadNamHoc();
            int n = items.Count,i=0 ;
            string[] a = new string[n];
            foreach (String it in items)
            {
                    a[i] = it;
                    i++;
               
            }
            namhoc.Items = a;
                namhoc.selectedIndex = items.Count() - 1;
                namhoc1 = items.Count() - 1;
                namhoc11 = namhoc.selectedValue;
                hocky1 = 0;
            String[] itemshk = { "1", "2" };
            bunifuDropdown2.Items = itemshk;
            if(n%2==0)
            {
                bunifuDropdown2.selectedIndex = 1;
                hocky1 = 1;
            }           
            else
            {
                bunifuDropdown2.selectedIndex = 0;
                hocky1 = 0;
            }
            
            string taikhoan = Form1.taikhoan;
            int magv = ChuyenDe_BUS.layMaGV(taikhoan);
            List<ChuyenDe_DTO> listCD2 = ChuyenDe_BUS.loadChuyenDe2(magv, namhoc11, (hocky1+1));
            bunifuCustomDataGrid1.AutoGenerateColumns = false;
            bunifuCustomDataGrid1.DataSource = listCD2;
        }
        private void gv1_Load_1(object sender, EventArgs e)
        {
            loadThongTinChuyenDe();
        }

        private void ttcd_dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.ColumnIndex;
            int x = e.RowIndex;
            string taikhoan = Form1.taikhoan;
            int magv = ChuyenDe_BUS.layMaGV(taikhoan);
            if (y == 7)
            {
                ChuyenDe_BUS.phutrachCD(int.Parse(ttcd_dtgv.Rows[x].Cells[0].Value.ToString()), magv);
                ok.Show();
            }
            
        }

        
        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int y = e.ColumnIndex;
            int x = e.RowIndex;
            if (y == 6)
            {
                try
                {
                    ChuyenDe_BUS.updateCD(int.Parse(bunifuCustomDataGrid1.Rows[x].Cells[0].Value.ToString()), int.Parse(bunifuCustomDataGrid1.Rows[x].Cells[2].Value.ToString()), int.Parse(bunifuCustomDataGrid1.Rows[x].Cells[4].Value.ToString()), DateTime.Parse(bunifuCustomDataGrid1.Rows[x].Cells[3].Value.ToString()));
                    ok.Show();
                }
                catch (Exception)
                {                   
                        MessageBox.Show("Loi kieu du lieu!");
                }
           
               
            }
            if(y==7)
            {
                
                mcd=int.Parse(bunifuCustomDataGrid1.Rows[x].Cells[0].Value.ToString());
                tencd = bunifuCustomDataGrid1.Rows[x].Cells[1].Value.ToString();
                //this.SendToBack();
                //bunifuImageButton3_Click(sender, e);
                //frm3.Show();
                if (ButtonClick != null) ButtonClick(sender, e);
                
                blev = true;
            }
        }

     

        private void xem_Click(object sender, EventArgs e)
        {
            
            namhoc1 = namhoc.selectedIndex;
            hocky1 = bunifuDropdown2.selectedIndex;
            List<ChuyenDe_DTO> listCD = ChuyenDe_BUS.loadChuyenDeXem(bunifuDropdown2.selectedIndex+1, namhoc.selectedValue); 
            ttcd_dtgv.AutoGenerateColumns = false;
            ttcd_dtgv.DataSource = listCD;
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
            //namhoc.selectedIndex = namhoc.selectedIndex;
            namhoc.selectedIndex = namhoc1;

            String[] itemshk = { "1", "2" };
            bunifuDropdown2.Items = itemshk;
            //bunifuDropdown2.selectedIndex = bunifuDropdown2.selectedIndex;
            bunifuDropdown2.selectedIndex = hocky1;
            string taikhoan = Form1.taikhoan;
            int magv = ChuyenDe_BUS.layMaGV(taikhoan);
            List<ChuyenDe_DTO> listCD2 = ChuyenDe_BUS.loadChuyenDe2(magv, namhoc.selectedValue, (hocky1 + 1));
            bunifuCustomDataGrid1.AutoGenerateColumns = false;
            bunifuCustomDataGrid1.DataSource = listCD2;
           //ttcd_dtgv.Show();
        }
    }    
}
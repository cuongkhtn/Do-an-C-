using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace DoAn
{
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
            this.CenterToScreen();
            //panel1.Height = bunifuImageButton4.Height;
            //panel1.Top = bunifuImageButton4.Top;
            g1.BringToFront();
        }

        gv1 g1 = new gv1();
        gv2 g2 = new gv2();
        private void Form3_Load(object sender, EventArgs e)
        {
            bunifuFlatButton1.BackColor = Color.SeaGreen;
            bunifuFlatButton1.IconZoom = 80;
            bunifuFlatButton2.BackColor = Transparent;
            bunifuFlatButton2.IconZoom = 80;
            bunifuFlatButton3.BackColor = Transparent;
            bunifuFlatButton3.IconZoom = 80;
            bunifuFlatButton4.BackColor = Transparent;
            bunifuFlatButton4.IconZoom = 70;
            g1.ButtonClick += new EventHandler(bunifuFlatButton2_Click);
            panel1.Controls.Add(g1);
            panel1.Controls.Add(g2);

        }

        public void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuFlatButton1.Normalcolor = Color.Transparent;
            bunifuFlatButton2.Normalcolor = Color.SeaGreen;
            bunifuFlatButton3.Normalcolor = Color.Transparent;
            bunifuFlatButton4.Normalcolor = Color.Transparent;
            g2.BringToFront();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuFlatButton1.Normalcolor = Color.SeaGreen;
            bunifuFlatButton2.Normalcolor = Color.Transparent;
            bunifuFlatButton3.Normalcolor = Color.Transparent;
            bunifuFlatButton4.Normalcolor = Color.Transparent;
            g1.BringToFront();
        }

        public Color Transparent { get; set; }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
            
        } 
    }
}

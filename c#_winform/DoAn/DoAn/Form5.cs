using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            
            InitializeComponent();
           

            admin2.BringToFront();
            
            this.CenterToScreen();
            //panel1.Top = bunifuFlatButton1.Top;
            //panel1.Height = bunifuFlatButton1.Height-1;
            //panel1.Width = 21;
            //bunifuTransition2.HideSync(bunifuImageButton6);
            //bunifuImageButton2.Location = new Point(9, 22);

            //bunifuGradientPanel2.Visible = false;
            //bunifuGradientPanel2.Width = 50;
            //bunifuTransition1.ShowSync(bunifuGradientPanel2);


        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
        }
        private void admin2_Load(object sender, EventArgs e)
        {
            
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //panel1.Height = bunifuFlatButton1.Height-1;
            //panel1.Width = 21;
            //panel1.Top = bunifuFlatButton1.Top;
            //bunifuFlatButton1.BackColor = Color.SeaGreen;
            bunifuFlatButton1.Normalcolor = Color.SeaGreen;
            bunifuFlatButton2.Normalcolor = Color.Transparent;
            bunifuFlatButton3.Normalcolor = Color.Transparent;
            bunifuFlatButton4.Normalcolor = Color.Transparent;
            admin2.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //panel1.Height = bunifuFlatButton1.Height-1;
            //panel1.Width = 21;
            //panel1.Top = bunifuFlatButton2.Top;
            //bunifuFlatButton2.BackColor = Color.SeaGreen;
            bunifuFlatButton2.Normalcolor = Color.SeaGreen;
            bunifuFlatButton1.Normalcolor = Color.Transparent;
            bunifuFlatButton3.Normalcolor = Color.Transparent;
            bunifuFlatButton4.Normalcolor = Color.Transparent;
            admin1.BringToFront();
        }



        public Color Transparent { get; set; }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        //private void bunifuImageButton2_Click(object sender, EventArgs e)
        //{
            
        //    if(bunifuGradientPanel2.Width==50)
        //    {
        //        bunifuImageButton2.Location = new Point(222, 22);
        //        bunifuGradientPanel2.Visible = false;
        //        bunifuGradientPanel2.Width = 260;
        //        bunifuTransition1.ShowSync(bunifuGradientPanel2);
        //        bunifuTransition2.ShowSync(bunifuImageButton6);
        //    }
        //    else if(bunifuGradientPanel2.Width == 260)
        //    {
        //        bunifuTransition2.HideSync(bunifuImageButton6);
        //        bunifuImageButton2.Location = new Point(9, 22);
                
        //        bunifuGradientPanel2.Visible = false;
        //        bunifuGradientPanel2.Width = 50;
        //        bunifuTransition1.ShowSync(bunifuGradientPanel2);
               
        //    }
        //}

       
    }
}

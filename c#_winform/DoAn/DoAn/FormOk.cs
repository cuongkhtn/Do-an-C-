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
    public partial class FormOk : Form
    {
        public FormOk()
        {

            InitializeComponent();
            this.CenterToScreen();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void FormOk_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            //timer1.Start();
            //bunifuImageButton1.Enabled = true;
            bunifuFlatButton1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // bunifuImageButton1.Enabled = false;
            //timer1.Stop();
            //bunifuFlatButton1.Visible = true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}

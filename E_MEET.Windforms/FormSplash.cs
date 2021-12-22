using E_MEET.Windforms.OutilsWindforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_MEET.Windforms
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Panel2.Width += 3;
            if (Panel2.Width >= 713)
            {
                timer1.Stop();
                MyMessageBox fmr = new MyMessageBox();
                fmr.Show();
                this.Hide();
            }
        }
    }
}

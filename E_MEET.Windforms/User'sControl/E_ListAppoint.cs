using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_MEET.Windforms.User_sControl
{
    public partial class E_ListAppoint : UserControl
    {
        public E_ListAppoint()
        {
            InitializeComponent();
        }

        private void E_ListAppoint_Load(object sender, EventArgs e)
        {

        }

        private void Mybutton1_Click(object sender, EventArgs e)
        {
            var form = new SetRdv();
            form.ShowDialog();
        }
    }
}

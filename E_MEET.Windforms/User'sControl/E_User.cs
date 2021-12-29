using E_MEET.Windforms.OutilsWindforms;
using System;
using System.Windows.Forms;

namespace E_MEET.Windforms.User_sControl
{
    public partial class E_User : UserControl
    {
        public E_User()
        {
            InitializeComponent();
        }

        private void Guna2CircleButton1_Click(object sender, EventArgs e)
        {
            AskUserAppoint form = new AskUserAppoint();
            form.ShowDialog();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Search form = new Search();
            form.ShowDialog();
        }
    }
}

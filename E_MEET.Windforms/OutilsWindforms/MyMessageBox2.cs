using E_MEET.BO;
using System;
using System.Windows.Forms;

namespace E_MEET.Windforms.OutilsWindforms
{
    public partial class MyMessageBox2 : Form
    {
        private Utilisateur user;
        public MyMessageBox2(Utilisateur us)
        {
            InitializeComponent();
            user = us;
        }

        private void MyMessageBox2_Load(object sender, EventArgs e)
        {
            Label2.Text = user.Nom;
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            var form = new AddInfoClientUser(user);
            form.ShowDialog();
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

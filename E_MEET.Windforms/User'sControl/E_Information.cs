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
    public partial class E_Information : UserControl
    {
        public E_Information()
        {
            InitializeComponent();
        }
        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            var form = new SetUser();
            form.ShowDialog();
        }
        private void E_Information_Load(object sender, EventArgs e)
        {
            Retour();
        }
        private void Retour()
        {
            PictureUser.ImageLocation = Program.CurrentUser.Photo;
            Label1.Text = Program.CurrentUser.Nom;
            Label2.Text = Program.CurrentUser.Prenom;
            Label3.Text = Program.CurrentUser.Email;
            Label4.Text = Program.CurrentUser.Contact.ToString();
            Label5.Text = Program.CurrentUser.Sexe;
            Label6.Text = Program.CurrentUser.Profession;
            Label7.Text = Program.CurrentUser.Localisation;
        }
    }
}

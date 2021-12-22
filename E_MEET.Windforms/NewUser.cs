using E_MEET.BLL;
using E_MEET.BO;
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
    public partial class NewUser : Form
    {
        private bool ExitApp = true;
        private Loading loading;
        private string Personne;
        Utilisateur EditUser;
        private UtilisateurManager userManager;
        public NewUser()
        {
            InitializeComponent();
            loading = new Loading();
            EditUser = new Utilisateur();
            userManager = new UtilisateurManager();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            if (ExitApp)
                Environment.Exit(0);
        }

        private void Label10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Clear()
        {
            TxtName.Clear();
            TxtEmail.Clear();
            TxtFullname.Clear();
            TxtContact.Clear();
            TxtLocalisation.Clear();
            TxtProfession.Clear();
            TxtPassword.Clear();
            Guna2RadioButton1.Checked.ToString();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Guna2RadioButton1.Checked)
            {
                Personne = "Homme";
            }
            else
            {
                Personne = "Femme";
            }
            if (TxtEmail.Text.Contains('@') && TxtEmail.Text.Contains('.'))
            {
                try
                {
                    var user = new Utilisateur(TxtEmail.Text, TxtPassword.Text, PictureBox.ImageLocation, TxtName.Text, TxtFullname.Text, int.Parse(TxtContact.Text), TxtProfession.Text, TxtLocalisation.Text, Personne);
                    if (EditUser == null)
                    {
                        userManager.AddUser(user);
                    }
                    else
                    {
                        userManager.EditUser(EditUser, user);
                    }
                    loading.ShowDialog();
                    MessageBox.Show($"Save done!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    Clear();
                    var form = new Authenticate();
                    form.Show();
                    ExitApp = false;
                    EditUser = null;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Email doesn't Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            var form = new MyMessageBox();
            form.Show();
            ExitApp= false;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Panel2.Width += 3;
            if (Panel2.Width >= 360)
            {
                timer1.Stop();
                loading.Close();
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "images (*.jpg ;*.jpeg; *.png; *.gif; *.tiff)|*.jpg;*.jpeg;*.gif;*.tiff;*.png";
            ofd.ShowDialog();
            PictureBox.ImageLocation = ofd.FileName;
        }
    }
}

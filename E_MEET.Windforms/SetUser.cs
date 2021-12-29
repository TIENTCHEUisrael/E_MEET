using E_MEET.BLL;
using E_MEET.BO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace E_MEET.Windforms
{
    public partial class SetUser : Form
    {
        private Utilisateur Oldutilisateur;
        private UtilisateurManager Utilisateurmanager;
        private ClientManager clientManager;
        //private Loading loading;
        private string Personne;
        public SetUser(Utilisateur us)
        {
            InitializeComponent();
            Oldutilisateur = us;
            //loading = new Loading();
            Utilisateurmanager = new UtilisateurManager();
            clientManager = new ClientManager();
        }

        private void SetUser_Load(object sender, EventArgs e)
        {
            Old();
        }

        private void Old()
        {
            TxtContact.Text = Oldutilisateur.Contact.ToString();
            TxtEmail.Text = Oldutilisateur.Email;
            TxtFull.Text = Oldutilisateur.Prenom;
            TxtLocalisation.Text = Oldutilisateur.Localisation;
            TxtName.Text = Oldutilisateur.Nom;
            TXtPassword.Text = Oldutilisateur.Password;
            TXtProfession.Text = Oldutilisateur.Profession;
            Guna2RadioButton1.Checked = true;
            Guna2CirclePictureBox1.ImageLocation = Oldutilisateur.Photo;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           /* Panel1.Width += 3;
            if(Panel1.Width>=225)
            {
                timer1.Stop();
                loading.Close();
            }*/
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            TxtContact.Clear();
            TxtEmail.Clear();
            TxtFull.Clear();
            TxtLocalisation.Clear();
            TxtName.Clear();
            TXtPassword.Clear();
            TXtProfession.Clear();
            Guna2CirclePictureBox1.Visible = false;
            Guna2RadioButton1.Checked = true;
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            try
            {
                if(Guna2RadioButton1.Checked)
                {
                    Personne = "Homme";
                }
                else
                {
                    Personne = "Femme";
                }
                var newUser = new Utilisateur(TxtEmail.Text, TXtPassword.Text, Guna2CirclePictureBox1.ImageLocation, TxtName.Text, TxtFull.Text, int.Parse(TxtContact.Text), TXtProfession.Text, TxtLocalisation.Text, Personne);
                try
                {
                    if(newUser==Oldutilisateur)
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var clts = Oldutilisateur.GetClient();                        
                        Utilisateurmanager.EditUser(Oldutilisateur, newUser);
                        modificationClientUser(clts);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               // loading.ShowDialog();
                MessageBox.Show
                (
                    "User's Information changed",
                    "Good",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch(Exception ex)
            {
                MessageBox.Show
                (
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
           
        }

        private void modificationClientUser(List<Client> us)
        {
            foreach(var c in us)
            {
                Oldutilisateur.AddClient(c);
            }
        }

        private void Guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "images (*.jpg ;*.jpeg; *.png; *.gif; *.tiff)|*.jpg;*.jpeg;*.gif;*.tiff;*.png";
            ofd.ShowDialog();
            Guna2CirclePictureBox1.ImageLocation = ofd.FileName;
        }
    }
}

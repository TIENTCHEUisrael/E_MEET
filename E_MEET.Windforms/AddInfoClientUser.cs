using E_MEET.BLL;
using E_MEET.BO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace E_MEET.Windforms
{
    public partial class AddInfoClientUser : Form
    {
        private Utilisateur utilisateur;
        private UtilisateurManager utilisateurManager;
        public ClientManager clientManager;
        private string Personne;
        public AddInfoClientUser(Utilisateur us)
        {
            InitializeComponent();
            utilisateur = us;
            utilisateurManager = new UtilisateurManager();
            clientManager = new ClientManager();
        }


        private void AddInfoClientUser_Load(object sender, EventArgs e)
        {

        }

        private void Mybutton1_Click(object sender, EventArgs e)
        {
            choix1();
            if (TxtEmail.Text.Contains('@') && TxtEmail.Text.Contains('.'))
            {
                try
                {
                    var client = new Client(TxtEmail.Text, TxtName.Text, TxtFull.Text, PictureClient.ImageLocation, int.Parse(TxtAge.Text), int.Parse(TxtContact.Text), Personne, TxtLocalisation.Text);

                    clientManager.AddClient(client);
                    utilisateurManager.AddUserClient(utilisateur, client);
                    MessageBox.Show($"Your are added for {utilisateur.Nom}");
                    Clear();
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

        private void Clear()
        {
            TxtAge.Clear();
            TxtContact.Clear();
            TxtEmail.Clear();
            TxtFull.Clear();
            TxtLocalisation.Clear();
            TxtName.Clear();
            RdHomme.Checked.ToString();
        }

        private void choix1()
        {
            if (RdHomme.Checked)
            {
                Personne = "Homme";
            }
            else
            {
                Personne = "Femme";
            }
        }

        private void Mybutton2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void PictureClient_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images (*.jpg ;*.jpeg; *.png; *.gif; *.tiff)|*.jpg;*.jpeg;*.gif;*.tiff;*.png";
            ofd.ShowDialog();
            PictureClient.ImageLocation = ofd.FileName;

        }
    }
}

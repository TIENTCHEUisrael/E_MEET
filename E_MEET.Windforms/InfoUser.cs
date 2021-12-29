using E_MEET.BO;
using System.Windows.Forms;

namespace E_MEET.Windforms
{
    public partial class InfoUser : Form
    {
        private Utilisateur utilisateur;
        public InfoUser(Utilisateur us)
        {
            InitializeComponent();
            utilisateur = us;
        }
        public void Affiche()
        {
            Guna2CirclePictureBox1.ImageLocation = utilisateur.Photo;
            LblContact.Text = utilisateur.Contact.ToString();
            LblEmail.Text = utilisateur.Email;
            LblLocalisation.Text = utilisateur.Localisation;
            LblNom.Text = utilisateur.Nom;
            LblPrenom.Text = utilisateur.Prenom;
            LblProfession.Text = utilisateur.Profession;
        }
        private void InfoUser_Load(object sender, System.EventArgs e)
        {
            Affiche();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}

using E_MEET.BLL;
using E_MEET.BO;
using E_MEET.Windforms.OutilsWindforms;
using System;
using System.Windows.Forms;

namespace E_MEET.Windforms
{
    public partial class SetClient : Form
    {
        private Client OldClient;
        private Client newClient;
        private ClientManager clientManager;
        Loading loading = new Loading();
        public string Personne { get; set; }
        public SetClient(Client client)
        {
            InitializeComponent();
            OldClient = client;
            clientManager = new ClientManager();
        }
        private void SetClient_Load(object sender, EventArgs e)
        {
            Correspondance();
        }

        private void Correspondance()
        {
            TxtAge.Text = OldClient.Age.ToString();
            TxtContact.Text = OldClient.Contact.ToString();
            TxtEmail.Text = OldClient.Email;
            TxtFull.Text = OldClient.Prenom;
            TxtLocalisation.Text = OldClient.Localisation;
            TxtName.Text = OldClient.Nom;
            RdHomme.Checked.ToString();
            PictureClient.ImageLocation = OldClient.Photo;
        }

        private void Mybutton1_Click_1(object sender, EventArgs e)
        {
            if (RdHomme.Checked)
            {
                Personne = "Homme";
            }
            else
            {
                Personne = "Femme";
            }
            try
            {
                newClient = new Client(TxtEmail.Text, TxtName.Text, TxtFull.Text, PictureClient.ImageLocation, int.Parse(TxtAge.Text), int.Parse(TxtContact.Text), Personne, TxtLocalisation.Text);
                if (OldClient == newClient)
                {
                    MessageBox.Show
                    (
                        " Client is already exist",
                        " Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else
                {
                    clientManager.EditClient(OldClient, newClient);
                    loading.ShowDialog();
                    MessageBox.Show
                    (
                        " Client Modified",
                        " Good",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Panel1.Width += 3;
            if(Panel1.Width>=244)
            {
                timer1.Stop();
                loading.Close();
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

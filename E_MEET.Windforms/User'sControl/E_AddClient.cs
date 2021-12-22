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

namespace E_MEET.Windforms.User_sControl
{
    public partial class E_AddClient : UserControl
    {
        private ClientManager clientManager;
        private UtilisateurManager utilisateurManager;
        private string Personne;
        private Client Editclt;
        private Loading loading;
        public E_AddClient()
        {
            InitializeComponent();
            clientManager = new ClientManager();
            Editclt = new Client();
            utilisateurManager = new UtilisateurManager();
            loading = new Loading();
        }
        private void Clear()
        {
            TxtAge.Clear();
            TxtContact.Clear();
            TxtEmail.Clear();
            TxtFull.Clear();
            TxtLocalisation.Clear();
            TxtName.Clear();
            TxtProfession.Clear();
            RdHomme.Checked.ToString();
        }
        private void Mybutton2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Mybutton1_Click(object sender, EventArgs e)
        {
            if (RdHomme.Checked)
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
                    var client = new Client(TxtEmail.Text, TxtName.Text, TxtFull.Text, PictureClient.ImageLocation, int.Parse(TxtAge.Text), int.Parse(TxtContact.Text), Personne, TxtLocalisation.Text);
                    if (Editclt == null)
                    {
                        Program.CurrentClients = client;
                        clientManager.AddClient(client);
                        utilisateurManager.AddUserClient(Program.CurrentUser, client);
                    }
                    else
                    {
                        clientManager.EditClient(Editclt, client);
                    }
                    loading.ShowDialog();
                    MessageBox.Show($"Client added for {Program.CurrentUser.Nom}");
                    Clear();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Panel1.Width += 3;
            if(Panel1.Width>=356)
            {
                timer1.Stop();
                loading.Close();
            }
        }

        private void PictureClient_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "images (*.jpg ;*.jpeg; *.png; *.gif; *.tiff)|*.jpg;*.jpeg;*.gif;*.tiff;*.png";
            ofd.ShowDialog();
            PictureClient.ImageLocation = ofd.FileName;
        }
    }
}

using E_MEET.BLL;
using E_MEET.BO;
using System;
using System.Windows.Forms;

namespace E_MEET.Windforms.User_sControl
{
    public partial class E_ListAppoint : UserControl
    {
        private Utilisateur utilisateur;
        private RendezVous EditRdv;
        private Client clt;
        private RendezVousManager manager;
        private ClientManager manager1;
        public E_ListAppoint(Utilisateur user)
        {
            InitializeComponent();
            manager = new RendezVousManager();
            manager1 = new ClientManager();
            utilisateur = user;
            EditRdv = new RendezVous();
            clt = new Client();
        }

        private void E_ListAppoint_Load(object sender, EventArgs e)
        {
            LoadInfoRdv();
        }

        private void LoadInfoRdv()
        {
            foreach(var c in utilisateur.Clients)
            {
                var rdv = c.GetRDv();
                foreach(var r in rdv)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { r.Id, utilisateur.Nom, r.ClientsNom, r.DateDebut.ToString(), r.HeureDebut,r.Temps.ToString(), r.ChoixPeriodicite1, r.Motif, c.Contact.ToString() });
                    lvi.Tag = r;
                    ListView1.Items.Add(lvi);
                }
            }            
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListView1.SelectedItems.Count == 0)
                return;
            var rdv = ListView1.SelectedItems[0].Tag as RendezVous;
            InfoRdv form = new InfoRdv(rdv);
            form.ShowDialog();
            EditRdv = rdv;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListView1.SelectedItems.Count == 0)
                    return;
                var rdv = ListView1.SelectedItems[0].Tag as RendezVous;
                var rd = clt.GetRDv();
                foreach(var r in rd)
                {
                    var rd1 = manager.AuthenticateRdv(r.Id);
                    var clt = manager1.Authenticate(r.ClientsNom);
                    if(rdv.Id==rd1.Id)
                    {
                        SetRdv form = new SetRdv(clt,rdv);
                        form.ShowDialog();
                        EditRdv = rdv;
                    }
                    else
                    {
                        MessageBox.Show("Error !", "Error !! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }         
            }
            catch(Exception ex)
            {
                MessageBox.Show
                (
                    ex.Message,
                    "Error !!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }              
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            E_ListAppoint_Load(sender, e);
        }
    }
}

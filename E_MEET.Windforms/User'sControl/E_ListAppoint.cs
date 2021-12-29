using E_MEET.BLL;
using E_MEET.BO;
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
    public partial class E_ListAppoint : UserControl
    {
        private Utilisateur utilisateur;
        private Client client;
        public E_ListAppoint(Utilisateur user)
        {
            InitializeComponent();
            utilisateur = user;
            client = new Client();
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

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

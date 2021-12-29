using E_MEET.BO;
using System;
using System.Windows.Forms;

namespace E_MEET.Windforms
{
    public partial class InfoRdv : Form
    {
        private RendezVous rendezVous;
        public InfoRdv(RendezVous rdv)
        {
            InitializeComponent();
            rendezVous =rdv;
        }

        private void InfoRdv_Load(object sender, EventArgs e)
        {
            Affiche();
        }

        private void Affiche()
        {
            TxtMotif.Text = rendezVous.Motif;
            TxtMotif.Enabled = false;
            LblNomClient.Text = rendezVous.ClientsNom;
            LblDateDebut.Text = rendezVous.DateDebut.ToString();
            LblDateFin.Text = rendezVous.DateFin.ToString();
            LblHeureFin.Text = rendezVous.HeureFin.ToString();
            Lblidentifiant.Text = rendezVous.Id;
            LblPeriodicité.Text = rendezVous.ChoixPeriodicite1;            
        }
    }
}

using E_MEET.BLL;
using E_MEET.BO;
using System;
using System.Windows.Forms;

namespace E_MEET.Windforms
{
    public partial class SetRdv : Form
    {
        private RendezVous Rendezvous;
        private RendezVousManager RendezvousManager;
        private ClientManager Clientmanager;
        private UtilisateurManager utilisateurManager;
        private Client Oldclient;
        private string ChoixPeriodicite1;
        private string ChoixPeriodicite2;
        private string ChoixDeFin;

        public SetRdv(Client clt,RendezVous rdv)
        {
            InitializeComponent();
            Oldclient = clt;
            Rendezvous = rdv;
            RendezvousManager = new RendezVousManager();
            Clientmanager = new ClientManager();
            utilisateurManager = new UtilisateurManager();
        }

        private void SetRdv_Load(object sender, EventArgs e)
        {
            Plagia();
        }

        private void Plagia()
        {
            TxtId.Text = Rendezvous.Id;
            LabelName.Text = Oldclient.Nom;
        }

        private void AddModifyUserClient(Client clt)
        {
            var client = Program.CurrentUser.GetClient();
            try
            {
                foreach (var p in client)
                {
                    if (p.Email == clt.Email)
                    {
                        var clt1 = Clientmanager.AuthenticateClt(p.Email);
                        Program.CurrentUser.DeleteClient(clt1);
                        utilisateurManager.AddUserClient(Program.CurrentUser, clt);
                    }
                    else
                    {
                        MessageBox.Show
                        (
                            "Client is not already exist",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }
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
        private void AddModifyClientRdv(RendezVous rdv)
        {
            var rendezvous = Oldclient.GetRDv();
            try
            {
                foreach(var r in rendezvous)
                {
                    if(r.Id==rdv.Id)
                    {
                        var rd1 = RendezvousManager.AuthenticateRdv(r.Id);
                        Oldclient.DeleteRDv(rd1);
                        Clientmanager.AddClientRdv(Oldclient,rdv);
                    }
                    else
                    {
                        MessageBox.Show(" Appointment is already exist !", "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Periodicite1()
        {
            if (RdQuoti.Checked)
            {
                ChoixPeriodicite1 = "RendezVous quotidient!";
                Periodicite2();
            }
            else if (RdHebdo.Checked)
            {
                ChoixPeriodicite1 = "RendezVous Hebdomadaire !";
                Periodicite2();
            }
            else if (RdMensu.Checked)
            {
                ChoixPeriodicite1 = "RendezVous Mensuel !";
                Periodicite2();
            }
            else
            {
                ChoixPeriodicite1 = "RendezVous Annuel !";
                if (panel1.Visible == true)
                    panel1.Visible = false;
            }
        }

        private void Periodicite2()
        {
            if (Rddfinition.Checked)
            {
                ChoixPeriodicite2 = "Le " + ComboBox4.Text + " tout les " + ComboBox5.Text + " Mois !";
            }
            else
            {
                ChoixPeriodicite2 = "Le " + comboBox1.Text + " " + comboBox2.Text + " tout les " + ComboBox6.Text + " mois !";
            }
        }

        private void Plage()
        {
            if (RdPasdefin.Checked)
            {
                ChoixDeFin = "Pas de date de fin !";
            }
            else if (RdOccurences.Checked)
            {
                ChoixDeFin = "Fin apres " + ComboBox3.Text + " Occurrences !";
            }
            else
            {
                ChoixDeFin = "Fin le :" + DateFin.Value;
            }
        }

        private void Mybutton1_Click(object sender, EventArgs e)
        {
            try
            {
                Periodicite1();
                Plage();
                var rdv = new RendezVous(Oldclient.Nom, CmdDebut.Text, CmdFin.Text, TrackBar1.Value, ChoixPeriodicite1, ChoixPeriodicite2, ChoixDeFin, DateDebut.Value, DateFin.Value, TxtMotif.Text, TxtId.Text);
                if (Rendezvous == rdv)
                {
                    MessageBox.Show
                    (
                        " Appointment is already exist",
                        " Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else
                {
                    RendezvousManager.EditRdv(Rendezvous, rdv);
                    var rdvous = RendezvousManager.AuthenticateRdv(Rendezvous.Id);
                    AddModifyClientRdv(rdvous);
                    var clt = Clientmanager.AuthenticateClt(Oldclient.Email);
                    AddModifyUserClient(clt);                    
                    MessageBox.Show
                    (
                        " Appointment is Modified",
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
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            TrackBar1.Value = ((int)Math.Round((Double)TrackBar1.Value / 30, 0)) * 30;
            LblDuree.Text = "Durée: " + TrackBar1.Value + " minutes";
        }

        private void RdOccurences_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox3.Enabled = true;
            DateFin.Enabled = false;
        }

        private void RdFinle_CheckedChanged(object sender, EventArgs e)
        {
            DateFin.Enabled = true;
            ComboBox3.Enabled = false;
        }

        private void RdPasdefin_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox3.Enabled = false;
            DateFin.Enabled = false;
        }

        private void Rddfinition_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox4.Enabled = true;
            ComboBox5.Enabled = true;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            ComboBox6.Enabled = false;
        }

        private void Rdautre_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            ComboBox6.Enabled = true;
            ComboBox4.Enabled = false;
            ComboBox5.Enabled = false;
        }

        private void RdAnnu_CheckedChanged(object sender, EventArgs e)
        {
            PanelPeriodiciter.Visible = false;
        }

        private void RdMensu_CheckedChanged(object sender, EventArgs e)
        {
            PanelPeriodiciter.Visible = true;
        }

        private void RdHebdo_CheckedChanged(object sender, EventArgs e)
        {
            PanelPeriodiciter.Visible = true;
        }

        private void RdQuoti_CheckedChanged(object sender, EventArgs e)
        {
            PanelPeriodiciter.Visible = true;
        }
    }
}

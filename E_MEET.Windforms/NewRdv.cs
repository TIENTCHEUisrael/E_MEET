using E_MEET.BLL;
using E_MEET.BO;
using E_MEET.Windforms.OutilsWindforms;
using System;
using System.Windows.Forms;

namespace E_MEET.Windforms
{
    public partial class NewRdv : Form
    {
        private Loading loading;
        private RendezVousManager RendezvousManager;
        private ClientManager Clientmanager;
        private UtilisateurManager utilisateurManager;
        private Client Oldclient;
        private string ChoixPeriodicite1;
        private string ChoixPeriodicite2;
        private string ChoixDeFin;
        public NewRdv(Client client)
        {
            InitializeComponent();
            loading = new Loading();
            RendezvousManager = new RendezVousManager();
            Clientmanager = new ClientManager();
            utilisateurManager = new UtilisateurManager();
            Oldclient = client;
        }
        private void FormRdv_Load(object sender, EventArgs e)
        {
            LabelName.Text = Oldclient.Nom;
            RdAnnu.Checked.ToString();
            PanelPeriodiciter.Visible = false;
            ComboBox3.Enabled = false;
            DateFin.Enabled = false;
            ComboBox4.Enabled = false;
            ComboBox5.Enabled = false;
            ComboBox1.Enabled = false;
            ComboBox2.Enabled = false;
            ComboBox6.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Panel2.Width += 3;
            if(Panel2.Width>=221)
            {
                timer1.Stop();
                loading.Close();
            }
        }
        private void Mybutton1_Click(object sender, EventArgs e)
        {
            try
            {
                Periodicite1();
                Plage();
                var rdv = new RendezVous(Oldclient.Nom,CmdDebut.Text, CmdFin.Text, TrackBar1.Value, ChoixPeriodicite1, ChoixPeriodicite2, ChoixDeFin, DateDebut.Value, DateFin.Value, TxtMotif.Text,TxtId.Text);                
                RendezvousManager.AddRdv(rdv);
                Clientmanager.AddClientRdv(Oldclient, rdv);                
                var clt = Clientmanager.AuthenticateClt(Oldclient.Email);                
                AddModifyUserClient(clt);
                Program.curclients.Add(clt);
                //loading.ShowDialog();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
        /// <summary>
        /// On supprime l'ancien client et on ajoute le nouveau client avec rendezVous
        /// </summary>
        /// <param name="clt"></param>
        private void AddModifyUserClient(Client clt)
        {
            var client = Program.CurrentUser.GetClient();
            try
            {
                foreach (var p in client)
                {
                    if (p.Email == clt.Email)
                    {
                        MessageBox.Show(clt.Prenom);
                        var clt1 = Clientmanager.AuthenticateClt(p.Email);
                        MessageBox.Show(clt1.Prenom);
                        Program.CurrentUser.DeleteClient(clt1);
                        utilisateurManager.AddUserClient(Program.CurrentUser, clt);
                        MessageBox.Show("Appointment is Added");
                    }
                }
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
                if(panel1.Visible==true)
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
                ChoixPeriodicite2 = "Le " + ComboBox1.Text + " " + ComboBox2.Text + " tout les " + ComboBox6.Text + " mois !";
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
                ChoixDeFin = "Fin apres "+ ComboBox3.Text+" Occurrences !";
            }
            else
            {
                ChoixDeFin = "Fin le :"+ DateFin.Value;
            }
        }

        private void RdQuoti_CheckedChanged(object sender, EventArgs e)
        {
            PanelPeriodiciter.Visible = true;
        }

        private void RdHebdo_CheckedChanged(object sender, EventArgs e)
        {
            PanelPeriodiciter.Visible = true;
        }

        private void RdMensu_CheckedChanged(object sender, EventArgs e)
        {
            PanelPeriodiciter.Visible = true;
        }
       
        //Au scroll du trackbar le label change
        
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            TrackBar1.Value = ((int)Math.Round((Double)TrackBar1.Value / 30, 0)) * 30;
            LblDuree.Text = "Durée: " + TrackBar1.Value + " minutes";
        }

        private void Mybutton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RdAnnu_CheckedChanged(object sender, EventArgs e)
        {
            PanelPeriodiciter.Visible = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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
            ComboBox3.Enabled = false ;
            DateFin.Enabled = false;
        }

        private void Rddfinition_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox4.Enabled = true;
            ComboBox5.Enabled = true;
            ComboBox1.Enabled = false;
            ComboBox2.Enabled = false;
            ComboBox6.Enabled = false;
        }

        private void Rdautre_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox1.Enabled = true;
            ComboBox2.Enabled = true;
            ComboBox6.Enabled = true;
            ComboBox4.Enabled = false;
            ComboBox5.Enabled = false;
        }
    }
}

using E_MEET.BLL;
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

namespace E_MEET.Windforms
{
    public partial class NewRdv : Form
    {
        private Loading loading;
        private RendezVousManager RendezvousManager;
        private ClientManager Clientmanager;
        public NewRdv()
        {
            InitializeComponent();
            loading = new Loading();
            RendezvousManager = new RendezVousManager();
            Clientmanager = new ClientManager();
        }
        private void FormRdv_Load(object sender, EventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

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
                loading.ShowDialog();
                MessageBox.Show("Appointment is Added");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
    }
}

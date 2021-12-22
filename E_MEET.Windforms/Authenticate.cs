using E_MEET.BLL;
using E_MEET.Windforms.OutilsWindforms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace E_MEET.Windforms
{
    public partial class Authenticate : Form
    {
        private bool ExitApp = true;
        private UtilisateurManager Utilisateurmanager;
        private Loading Loading1;
        public Authenticate()
        {
            InitializeComponent();
            Utilisateurmanager = new UtilisateurManager();
            Loading1 = new Loading();
        }
        private void Label1_Click(object sender, EventArgs e)
        {
            if (ExitApp)
                Environment.Exit(0);
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if(TxtEmail.Text.Contains('.')&& TxtEmail.Text.Contains('@'))
            {
                try
                {
                    Program.CurrentUser = Utilisateurmanager.Authenticate(TxtEmail.Text, TxtPassword.Text);                
                    Loading1.ShowDialog();
                    var form = new MainApp();
                    form.Show();
                    ExitApp = false;
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error",ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Format of Email not correct", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }           
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            MyMessageBox form = new MyMessageBox();
            form.Show();
            this.Close();
        }       

        private void timer1_Tick(object sender, EventArgs e)
        {
            Panel2.Width += 3;
            if (Panel2.Width >= 397)
            {
                timer1.Stop();
                Loading1.Close();
            }
        }
        private void Clear()
        {
            TxtEmail.Clear();
            TxtPassword.Clear();
        }
    }
}

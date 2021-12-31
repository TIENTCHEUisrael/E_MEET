using E_MEET.BLL;
using E_MEET.Windforms.User_sControl;
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
    public partial class MainApp : Form
    {
        private bool ExitApp = true;
        private UtilisateurManager utilisateurManager;
        public MainApp()
        {
            InitializeComponent();
            E_Home uc = new E_Home();
            AddUserControl(uc);
            utilisateurManager = new UtilisateurManager();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;//positionnement
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Home_Click(object sender, EventArgs e)
        {
            E_Home uc = new E_Home();
            AddUserControl(uc);
        }

        private void ListAppoint_Click(object sender, EventArgs e)
        {
            E_ListAppoint ul = new E_ListAppoint(Program.CurrentUser);
            AddUserControl(ul);
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            E_AddClient ua = new E_AddClient();
            AddUserControl(ua);
        }

        private void AddAppoint_Click(object sender, EventArgs e)
        {
            E_AddAppoint uaa = new E_AddAppoint();
            AddUserControl(uaa);
        }

        private void Information_Click(object sender, EventArgs e)
        {
            E_Information ui = new E_Information();
            AddUserControl(ui);
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            if (ExitApp)
                Environment.Exit(0);
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var form = new Authenticate();
            form.Show();
            ExitApp = false;
            this.Close();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            try
            {
            Label2.Text = Program.CurrentUser.Nom;
            PictureUser.ImageLocation = Program.CurrentUser.Photo;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            E_User eu = new E_User();
            AddUserControl(eu);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MainApp_Load(sender,e);            
        }
    }
}

using E_MEET.BLL;
using E_MEET.BO;
using E_MEET.Windforms.OutilsWindforms;
using System;
using System.Windows.Forms;

namespace E_MEET.Windforms
{
    public partial class AskUserAppoint : Form
    {
        private UtilisateurManager utilisateurManager;
        private Utilisateur Edituser;
        public AskUserAppoint()
        {
            InitializeComponent();
            utilisateurManager = new UtilisateurManager();
            Edituser = new Utilisateur();
        }
        private void AskUserAppoint_Load(object sender, EventArgs e)
        {
            LoadUser();
        }
        public void LoadUser()
        {
            var users = utilisateurManager.GetAllUSer();
            ListView1.Items.Clear();
            foreach (var u in users)
            {
                ListViewItem lvi = new ListViewItem(new String[] { u.Nom,u.Prenom,u.Email,u.Profession,u.Contact.ToString() });
                lvi.Tag = u;
                ListView1.Items.Add(lvi);
            }
        }
        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListView1.SelectedItems.Count == 0)
                return;
            var users = ListView1.SelectedItems[0].Tag as Utilisateur;
            InfoUser form = new InfoUser(users);
            form.ShowDialog();
            Edituser = users;
        }

        private void AskUserAppoint_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }

        private void askToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListView1.SelectedItems.Count == 0)
                return;
            var users = ListView1.SelectedItems[0].Tag as Utilisateur;
            MyMessageBox2 form = new MyMessageBox2(users);
            form.ShowDialog();
            Edituser = users;
        }

        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            informationToolStripMenuItem_Click(sender, e);
        }
    }
}

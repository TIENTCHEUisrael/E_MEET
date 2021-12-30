using E_MEET.BLL;
using E_MEET.BO;
using System;
using System.Windows.Forms;

namespace E_MEET.Windforms.User_sControl
{
    public partial class E_AddAppoint : UserControl
    {
        private Utilisateur EditUser;
        private Client EditClient;
        private UtilisateurManager utilisateurManager;
        public E_AddAppoint()
        {
            InitializeComponent();
            EditUser=new Utilisateur();
            EditClient = new Client();
            utilisateurManager = new UtilisateurManager();
        }

        private void E_AddAppoint_Load(object sender, EventArgs e)
        {
            LoadListView(Program.CurrentUser);
        }
        public void LoadListView(Utilisateur user)
        {
            var client = user.GetClient();
            ListView1.Items.Clear();
            foreach (var p in client)
            {
                ListViewItem lvi = new ListViewItem(new String[] {p.Nom,p.Prenom,p.Email,p.Contact.ToString(), p.Sexe, p.Localisation});
                lvi.Tag = p;
                ListView1.Items.Add(lvi);
            }
        }
        private void Mybutton3_Click(object sender, EventArgs e)
        {
            if (ListView1.SelectedItems.Count == 0)
                return;
            Program.CurrentClients = ListView1.SelectedItems[0].Tag as Client;            
            var form = new SetClient(Program.CurrentClients);
            form.ShowDialog();
        }

        private void Mybutton1_Click(object sender, EventArgs e)
        {
            if (ListView1.SelectedItems.Count == 0)
                return;
            Program.CurrentClients = ListView1.SelectedItems[0].Tag as Client;
            var form = new NewRdv(Program.CurrentClients);
            form.ShowDialog();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListView1.SelectedItems.Count == 0)
                return;
            var clt = ListView1.SelectedItems[0].Tag as Client;
            EditClient = clt;
            LoadListView(Program.CurrentUser);
        }

        private void Mybutton2_Click(object sender, EventArgs e)
        {
            if (ListView1.SelectedItems.Count == 0)
                return;           
            var product = ListView1.SelectedItems[0].Tag as Client;
            utilisateurManager.RemoveUserClient(Program.CurrentUser, product);
            LoadListView(Program.CurrentUser);
        }

        private void ListView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListView1.SelectedItems.Count == 0)
                return;
            var clt = ListView1.SelectedItems[0].Tag as Client;
            var form = new SetClient(clt);
            form.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            E_AddAppoint_Load(sender, e);
        }
    }
}

using E_MEET.BO;
using System;
using System.Windows.Forms;

namespace E_MEET.Windforms.User_sControl
{
    public partial class E_AddAppoint : UserControl
    {
        private Utilisateur editUser;
        public E_AddAppoint()
        {
            InitializeComponent();
            editUser=new Utilisateur();
        }

        private void E_AddAppoint_Load(object sender, EventArgs e)
        {

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
            var form = new SetClient();
            form.ShowDialog();
        }

        private void Mybutton1_Click(object sender, EventArgs e)
        {
            var form = new NewRdv();
            form.ShowDialog();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListView1.SelectedItems.Count == 0)
                return;
            var user = ListView1.SelectedItems[0].Tag as Utilisateur;
            editUser = user;
            LoadListView(Program.CurrentUser);
        }
    }
}

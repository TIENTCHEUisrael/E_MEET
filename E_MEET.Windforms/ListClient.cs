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

namespace E_MEET.Windforms
{
    public partial class ListClient : Form
    {
        private readonly Utilisateur User;
        public ListClient(Utilisateur us)
        {
            InitializeComponent();
            User = us;
        }
        private  void lloadListBox(Utilisateur user)
        {
            var client = user.GetClient();           
            ListBox1.Items.Clear();
            foreach (var p in client)
            {
                ListBox1.Tag = p;
                ListBox1.Items.Add(p.Nom);
            }
        }
        private void ListClient_Load(object sender, EventArgs e)
        {
            lloadListBox(User);
        }

        private void Mybutton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

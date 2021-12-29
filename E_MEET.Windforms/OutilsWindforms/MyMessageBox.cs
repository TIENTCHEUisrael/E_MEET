using System;
using System.Windows.Forms;

namespace E_MEET.Windforms.OutilsWindforms
{
    public partial class MyMessageBox : Form
    {
        private Loading loading;
        private bool ExitApp=true;
        public MyMessageBox()
        {
            InitializeComponent();
            loading = new Loading();
        }

        private void ButtonOui_Click(object sender, EventArgs e)
        {
            //loading.ShowDialog();
            Authenticate form = new Authenticate();
            form.Show();
            ExitApp = false;
            this.Close();
        }

        private void ButtonNon_Click(object sender, EventArgs e)
        {
            //loading.ShowDialog();
            NewUser form = new NewUser();
            form.Show();
            ExitApp = false;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            Panel2.Width += 3;
            if (Panel2.Width >= 319)
            {                
                timer1.Stop();               
                loading.Close();
            }
        }
    }
}

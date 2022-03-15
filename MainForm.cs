using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            AddMember addmember = new AddMember();
            addmember.Show();
            this.Hide();
        }

        private void BunifuThinButton25_Click(object sender, EventArgs e)
        {
            UpdateDelete updateDelete = new UpdateDelete();
            updateDelete.Show();
            this.Hide();
        }

        private void BunifuThinButton24_Click(object sender, EventArgs e)
        {
            ViewMember view = new ViewMember();
            view.Show();
            this.Hide();
        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
            this.Hide();
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GymManagementSystem
{
    public partial class ViewMember : Form
    {
        public ViewMember()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\GymDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select MId as [Member Id], MName as [Name], MPhone as [Phone Number], MGen as [Gender], MAge as [Age],MAmount as [Monthly Amount], MTiming as [Timing] from Member";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewMember_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void filterByName()
        {
            Con.Open();
            string query = "select MId as [Member Id], MName as [Name], MPhone as [Phone Number], MGen as [Gender], MAge as [Age],MAmount as [Monthly Amount], MTiming as [Timing] from Member where MName = '" + SearchMember.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            filterByName();
            SearchMember.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}

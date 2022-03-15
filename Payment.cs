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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\GymDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void fillName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select MName from Member", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MName", typeof(string));
            dt.Load(rdr);
            NameCb.ValueMember = "MName";
            NameCb.DataSource = dt;
            Con.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // NameTb.Text = "";
            AmountTb.Text = "";
        }

        private void BunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            fillName();
            populate();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            Con.Open();
            string query = "select PId as [Payment Id], PMonth as [Month], PMember as [Member], PAmount as [Amount] from Payment";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void filterByName()
        {
            Con.Open();
            string query = "select PId as [Payment Id], PMonth as [Month], PMember as [Member], PAmount as [Amount] from Payment where PMember ='"+searchName.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (NameCb.Text == "" || AmountTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            } else
            {
                string payperiode = Periode.Value.Month.ToString() + "-" + Periode.Value.Year.ToString();
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from payment where PMember = '"+NameCb.SelectedValue.ToString()+"' and PMonth ='"+payperiode+"'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Already Paid for This Mont");
                }
                else
                {
                    string query = "insert into Payment values('" + payperiode + "','" + NameCb.SelectedValue.ToString() + "', '" + AmountTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Paid Successfully");

                }
                Con.Close();
                populate();
            }
        }

        

        private void PaymentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            filterByName();
            searchName.Text = "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}

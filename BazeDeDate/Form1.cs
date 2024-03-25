using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazeDeDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=WindowsXP\SQLEXPRESS;AttachDbFilename=""C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\proiect.mdf"";Initial Catalog=proiect;Integrated Security=True;Encrypt=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            user_email.Clear();
            user_password.Clear();

            user_email.Focus();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            String Email, Parola;
            Email = user_email.Text;
            Parola = user_password.Text;
            try
            {
                String querry = "SELECT Email, Parola FROM Client WHERE Email = '" + user_email.Text + "' AND Parola= '" + user_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    Email = user_email.Text;
                    Parola = user_password.Text;

                    //page that needed to be load next

                    Form1 form2 = new Form1();
                    form2.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    user_email.Clear();
                    user_password.Clear();

                    //to focus username
                    user_email.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}

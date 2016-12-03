using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace inventory
{
    public partial class new_user : Form
    {
        private OleDbConnection new_connection = new OleDbConnection();

        public new_user()
        {
            InitializeComponent();
            new_connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\POS_PROJECT\inv3_test\inventory\inventory\Database2.accdb";
            new_connection.Open();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = false;


                if (success == false)
                {
                    if ((adminUsername.Text == "ADMIN" || adminUsername.Text == "admin") && AdminPassword.Text == "rude")
                    {
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = new_connection;
                        if (newPassword.Text == confirmPassword.Text)
                        {
                            command.CommandText = "insert into cred ([username],[password]) values('" + new_username.Text + "' , '" + newPassword.Text + "' ) ";

                            MessageBox.Show("Account as been created successfully");

                            command.ExecuteNonQuery();

                            success = true;


                        }

                        else
                            MessageBox.Show("The new password does not match the confirm password");
                    }

                    else if ((adminUsername.Text != "ADMIN" || adminUsername.Text != "admin") && (AdminPassword.Text != "rude" || AdminPassword.Text == "rude"))
                    {
                        MessageBox.Show("Invalid Aministrator's credential");

                    }
                }
            }

            catch(Exception)
            {
                //
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new_connection.Close();
            this.Hide();
            Form1 F1 = new Form1();
            F1.ShowDialog();
        }
    }
}

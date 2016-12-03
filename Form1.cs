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
    public partial class Form1 : Form
    {
        // Made it as global connection
       private OleDbConnection new_connection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent(); //Default constructor
            new_connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\POS_PROJECT\inv3_test\inventory\inventory\Database2.accdb";
        }

     /*   private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //WORKING ON IT WORKING ON IT
            /*this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2DataSet);
            
        }
     */
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                new_connection.Open();
                testLabel.Text = "Connection Successful";   
                new_connection.Close();
            }

            catch(Exception)
            {
                MessageBox.Show("Failed to establish the connection. Please try again!");
            }



            // TODO: This line of code loads data into the 'database2DataSet.inventory' table. You can move, or remove it, as needed.
            //this.inventoryTableAdapter.Fill(this.database2DataSet.inventory);

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
           
            new_connection.Open();
            OleDbCommand verification_command = new OleDbCommand();
            verification_command.Connection = new_connection;
            verification_command.CommandText = "select * from cred where username= '"+ textBox1.Text + "' and password='"+ textBox2.Text +"' " ;
            OleDbDataReader helper = verification_command.ExecuteReader();
               
            int counter = 0;
            while(helper.Read())
            {
                counter = counter + 1;
            }

            // checking if the username or password is correct.
            if(counter >= 1)
            {
                    
                MessageBox.Show("Username and password is correct");
                new_connection.Close(); // If the password is correct than close the current form and go to the next one.
                new_connection.Dispose(); // It release all the information from this form
                this.Hide(); // Hiding the current form

                pos_interface PI = new pos_interface();
                PI.ShowDialog();
            }

                //IF incorrect password
                else 
                    MessageBox.Show("Password is incorrect");
          
            //Closing connection is always good
            new_connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new_user NU = new new_user();
            NU.ShowDialog();
        }
    }
}   


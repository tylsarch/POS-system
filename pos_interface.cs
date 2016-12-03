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
    public partial class pos_interface : Form
    {
        private OleDbConnection new_connection = new OleDbConnection();

        public pos_interface()
        {
            InitializeComponent();
            new_connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\POS_PROJECT\inv3_test\inventory\inventory\Database2.accdb";
        }

        private void pos_interface_Load(object sender, EventArgs e)
        {
            try
            {
                new_connection.Open();
                //.Text = "Connection Successful";
               // new_connection.Close();
            }

            catch (Exception)
            {
               // MessageBox.Show("FAILED" + ex);
            }

        }

        private void inventory_button_Click(object sender, EventArgs e)
        {

            //new_connection.Close(); // If the password is correct than close the current form and go to the next one.
            new_connection.Dispose(); // It release all the information from this form
            this.Hide(); // Hiding the current form

            inventory_changes IC = new inventory_changes();
            IC.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {

                string ProductNameTemp = null, ProductPrice = null, temp = null;     //temporary string so we can give this string to listbox.
           
            OleDbCommand command = new OleDbCommand();
            command.Connection = new_connection;
            string query = "select * from inventory where Barcode= " + textBox1.Text + "";

            command.CommandText = query;

            OleDbDataReader finder = command.ExecuteReader();

            while (finder.Read())
            {
                    temp = finder["Barcode"].ToString();
                    ProductNameTemp = finder["ProductName"].ToString();
                    ProductPrice = finder["Price"].ToString();

                    if (textBox1.Text != temp)
                    {
                        MessageBox.Show("Sorry, the Item was not in the inventory");
                    }

                    else
                    {
                        listBox1.Items.Add(".   " + ProductNameTemp);
                        priceBox.Items.Add(ProductPrice);
                    }
                }

            } 
                catch (Exception)
            {
              
            }

            textBox1.Text = null;
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if (listBox1.SelectedIndex != -1)     // Because list starts from 1 so just a minor checker
            {
                temp = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(temp);
            }
            if(temp != -1)
            {
                priceBox.Items.RemoveAt(temp);
            }
            
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            this.Hide();
            F1.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a great day!!");
            Application.Exit();
        }

        private void checkout_Click_1(object sender, EventArgs e)
        {
            double total = 0.0;
            //double tex = 0.0;
            //double temp = 0.0;
            //string tmp = null;
            priceBox.BeginUpdate();
            for (int i = 0; i < priceBox.Items.Count; i++)
            {
                total += double.Parse(priceBox.Items[i].ToString());
            }
            priceBox.EndUpdate();
            checkoutBox.Text = total.ToString();

            taxBox.Text = "2.15";

            total += double.Parse(taxBox.Text);

            TotalamountBox.Text = total.ToString();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            double change = 0.0;
            if (receivedBox.Text != null)
            {
                change = double.Parse(TotalamountBox.Text) - double.Parse(receivedBox.Text);
            }
            else
            {
                MessageBox.Show("No amount received.");
            }
            changeBox.Text = change.ToString();
        }

        private void newticketButton_Click(object sender, EventArgs e)
        {
            for (int i = priceBox.Items.Count - 1; i >= 0; i--)
            {
                priceBox.Items.Remove(priceBox.Items[i]);
            }

            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Remove(listBox1.Items[i]);
            }

            taxBox.Text = null;
            checkoutBox.Text = null;
            TotalamountBox.Text = null;
            receivedBox.Text = null;
            changeBox.Text = null;
        }
    }
}

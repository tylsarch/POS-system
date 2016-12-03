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
    public partial class inventory_changes : Form
    {
        private OleDbConnection new_connection = new OleDbConnection();
        DataGridView dg = new DataGridView();

        public inventory_changes()
        {
            InitializeComponent();
            new_connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\POS_PROJECT\inv3_test\inventory\inventory\Database2.accdb";
            new_connection.Open();
        }

       private void inventory_changes_Load(object sender, EventArgs e)
        {
            try
            {
                //new_connection.Open();
                this.inventoryTableAdapter.Fill(this.database2DataSet.inventory);
                
                //new_connection.Close();
            }

            catch (Exception)
            {
             
            }
                       
        }
      
        private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                //new_connection.Open();
                OleDbCommand verification_command = new OleDbCommand();
                verification_command.Connection = new_connection;
               
                verification_command.CommandText = "insert into inventory ([ID],[Barcode],[ProductName],[Price]) values('"+iDTextBox.Text+"' , '" + barcodeTextBox.Text + "', '" + productNameTextBox.Text + "', '" + priceTextBox.Text + "' ) ";
               
                verification_command.ExecuteNonQuery();

                /*this.Validate();
                this.inventoryBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database2DataSet);
              */
                //new_connection.Close();
            }

            catch(Exception)
            {
             
            }
    
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
           try
           {   
            OleDbCommand command = new OleDbCommand();
            command.Connection = new_connection;
            string query = "delete from inventory where Barcode = " + barcodeTextBox.Text;

            command.CommandText = query;
               
                command.ExecuteNonQuery();

                Update();

                MessageBox.Show("Data edit successful");
            } 
                catch (Exception )
            {
              
            }
        
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                //new_connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = new_connection;
                string query = "insert  into inventory ([ID],[Barcode],[ProductName],[Price]) values('" + iDTextBox.Text + "' , '" + barcodeTextBox.Text + "', '" + productNameTextBox.Text + "', '" + priceTextBox.Text + "' ) ";
                //MessageBox.Show(query);

                command.CommandText = query;
               
                command.ExecuteNonQuery();
                MessageBox.Show("Data edit successful");
                //new_connection.Close();
            }

            catch (Exception)
            {
               
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new_connection.Dispose();
            new_connection.Close();
            GC.Collect();
            Close();

            this.Hide();
           
            pos_interface PI = new pos_interface();
            PI.ShowDialog();
        }

    }
}


// TODO: This line of code loads data into the 'database2DataSet.inventory' table. You can move, or remove it, as needed.
//this.inventoryTableAdapter.Fill(this.database2DataSet.inventory);
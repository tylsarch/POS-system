namespace inventory
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.database2DataSet = new inventory.Database2DataSet();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new inventory.Database2DataSetTableAdapters.inventoryTableAdapter();
            this.tableAdapterManager = new inventory.Database2DataSetTableAdapters.TableAdapterManager();
            this.testLabel = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "inventory";
            this.inventoryBindingSource.DataSource = this.database2DataSet;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.inventoryTableAdapter = this.inventoryTableAdapter;
            this.tableAdapterManager.UpdateOrder = inventory.Database2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(37, 9);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(0, 13);
            this.testLabel.TabIndex = 9;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.username_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.username_label.Location = new System.Drawing.Point(35, 55);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(124, 25);
            this.username_label.TabIndex = 10;
            this.username_label.Text = "USERNAME";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.password_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.password_label.Location = new System.Drawing.Point(34, 102);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(130, 25);
            this.password_label.TabIndex = 11;
            this.password_label.Text = "PASSWORD";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(202, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 30);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox2.Location = new System.Drawing.Point(202, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(227, 30);
            this.textBox2.TabIndex = 13;
            // 
            // Login_button
            // 
            this.Login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Login_button.Location = new System.Drawing.Point(202, 155);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(91, 34);
            this.Login_button.TabIndex = 14;
            this.Login_button.Text = "LOGIN";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exit_button.Location = new System.Drawing.Point(338, 155);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(91, 34);
            this.exit_button.TabIndex = 15;
            this.exit_button.Text = "EXIT";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(39, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Create new user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(585, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.testLabel);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private Database2DataSetTableAdapters.inventoryTableAdapter inventoryTableAdapter;
        private Database2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button button1;
    }
}


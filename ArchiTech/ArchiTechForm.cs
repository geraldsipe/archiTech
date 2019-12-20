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

namespace ArchiTech
{ 
    public partial class ArchiTechForm : Form
    {
        public ArchiTechForm()
        {
            InitializeComponent();
        }

     
         
  

        private void textBox1_TextChanged(object sender, EventArgs e)
        {//Enter new Project name

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Gerald/Documents/Database1.accdb");
                            OleDbCommand cmd = con.CreateCommand();    
    con.Open();    
    cmd.CommandText = "Insert into Student(FirstName,LastName)Values('" + textBox1.Text + "','" + textBox2.Text + "')";    
    cmd.Connection = con;    
    cmd.ExecuteNonQuery();    
    MessageBox.Show("Record Submitted","Congrats");    
    con.Close(); 
   

            ArchiTechFunctions f1 = new ArchiTechFunctions();
            this.Hide(); //Hides the main Forms
            f1.ShowDialog();
            this.Close(); //Closes the main Form
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Suppliers f4 = new Suppliers();
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }
    }
}

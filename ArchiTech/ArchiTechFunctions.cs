using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiTech
{
    public partial class ArchiTechFunctions : Form
    {
        public ArchiTechFunctions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//Structural Members Button
            StructuralMembersForm f2 = new StructuralMembersForm();
            this.Hide(); //Hides the main Forms
            f2.ShowDialog();
            this.Close(); //Closes the main Form
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OverallResults f3 = new OverallResults();
            this.Hide(); //Hides ArchiTechFunctions Form
            f3.ShowDialog();
            this.Close(); //Closes the main Form
        }
    }
}

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
    public partial class OverallResults : Form
    {
        public OverallResults()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArchiTechFunctions f5 = new ArchiTechFunctions();
            this.Hide();
            f5.ShowDialog();
            this.Close();
        }
    }
}

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
    public partial class StructuralMembersForm : Form
    {
        int footingNumber;
        int columnsNumber;
        int beamNumber;
        int slabnumber;

        double fwidth;
        double cwidth;
        double bwidth;
        double swidth;

        double flength;
        double clength;
        double blength;
        double slength;

        double fthickness;
        double cthickness;
        double bthickness;
        double sthickness;

        double fvolume;
        double cvolume;
        double bvolume;
        double svolume;
        

        public StructuralMembersForm()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {//On key press of Enter Footing textbox
            char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                //chr = 8 allows backspace
                e.Handled = true;
                MessageBox.Show("Please enter a Number value");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//Enter Number of Footings Edit Button
            textBox1.ReadOnly = false; // Makes the Textbox Editable
            textBox1.BackColor = System.Drawing.SystemColors.Window; // Changes the Textbox color to white
        }

        private void button2_Click(object sender, EventArgs e)
        {//Enter Number of Footings Save Button
            textBox1.ReadOnly = true; // Makes the Textbox Un-Editable
            textBox1.BackColor = System.Drawing.SystemColors.ControlLight; // Changes the Textbox color to dirty white

            footingNumber = int.Parse(textBox1.Text); //Gets the value of textBox2 and converts it to int to be stored in thickness variable

            for (int i = 1; i <= footingNumber; i++)
            {
                comboBox1.Items.Add("Footing" + i);
                comboBox5.Items.Add("Footing" + i);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//Show List Footings name ComboBox or Dropdown
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {//Footing Properties Groupbox

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {//On-Click Properties Footing Width TextBox
            char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 46 && chr != 8)
            {
                //chr = 46 allows "." 
                //chr = 8 allows backspace
                e.Handled = true;
                MessageBox.Show("Please enter a Number value");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {//On-Click Properties Footing Legth TextBox
            char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 46 && chr != 8)
            {
                //chr = 46 allows "." 
                //chr = 8 allows backspace
                e.Handled = true;
                MessageBox.Show("Please enter a Number value");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {//On-Click Properties Footing Thickness TextBox
            char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 46 && chr != 8)
            {
                //chr = 46 allows "." 
                //chr = 8 allows backspace
                e.Handled = true;
                MessageBox.Show("Please enter a Number value");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//Footing Properties Edit Button
            textBox2.ReadOnly = false; // Makes the Textbox Editable
            textBox2.BackColor = System.Drawing.SystemColors.Window; // Changes the Textbox color to white
            textBox3.ReadOnly = false; // Makes the Textbox Editable
            textBox3.BackColor = System.Drawing.SystemColors.Window; // Changes the Textbox color to white
            textBox4.ReadOnly = false; // Makes the Textbox Editable
            textBox4.BackColor = System.Drawing.SystemColors.Window; // Changes the Textbox color to white
        }

        private void button5_Click(object sender, EventArgs e)
        {//Footing Properties Save Button
            textBox2.ReadOnly = true; // Makes the Textbox Un-Editable
            textBox2.BackColor = System.Drawing.SystemColors.ControlLight; // Changes the Textbox color to dirty white
            textBox3.ReadOnly = true; // Makes the Textbox Un-Editable
            textBox3.BackColor = System.Drawing.SystemColors.ControlLight; // Changes the Textbox color to dirty white
            textBox4.ReadOnly = true; // Makes the Textbox Un-Editable
            textBox4.BackColor = System.Drawing.SystemColors.ControlLight; // Changes the Textbox color to dirty white

            fwidth = double.Parse(textBox2.Text); //Gets the value of textBox2 and converts it to double to be stored in width variable
            flength = double.Parse(textBox3.Text); //Gets the value of textBox3 and converts it to double to be stored in length variable
            fthickness = double.Parse(textBox4.Text); //Gets the value of textBox4 and converts it to double to be stored in thickness variable
            fvolume = fwidth * flength * fthickness;
            MessageBox.Show("the total volume is " +fvolume+ " cubic meter");
            label9.Text = "" +fvolume+ " cubic meter";
        }

        private void button4_Click(object sender, EventArgs e)
        {//Structural Members Overall Save Button

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {//Footing Tab Page

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {//Columns Tab Page

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {//Beams Tab Page

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {//Slabs Tab Page

        }

        private void StructuralMembersForm_Load(object sender, EventArgs e)
        {//Structural Members Form

        }

        private void button6_Click(object sender, EventArgs e)
        {//Go back to Functions Form button
            ArchiTechFunctions f6 = new ArchiTechFunctions();
            this.Hide();//Hides the Structural Members Form
            f6.ShowDialog();
            this.Close();//Closes the main form
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {// On key press of Enter Number of Columns Textbox
            char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                //chr = 8 allows backspace
                e.Handled = true;
                MessageBox.Show("Please enter a Number value");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {//Enter Number of Columns edit button
            textBox8.ReadOnly = false; // Makes the Textbox Editable
            textBox8.BackColor = System.Drawing.SystemColors.Window; // Changes the Textbox color to white
        }

        private void button7_Click(object sender, EventArgs e)
        {//Enter Number of Columns save button
            textBox8.ReadOnly = true; // Makes the Textbox Un-Editable
            textBox8.BackColor = System.Drawing.SystemColors.ControlLight; // Changes the Textbox color to dirty white

            columnsNumber = int.Parse(textBox8.Text); //Gets the value of textBox2 and converts it to int to be stored in thickness variable

            for (int i = 1; i <= columnsNumber; i++)
            {
                comboBox2.Items.Add("Column" + i);
                comboBox5.Items.Add("Beam" + i);
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {//On-Click Properties Columns Width TextBox
            char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 46 && chr != 8)
            {
                //chr = 46 allows "." 
                //chr = 8 allows backspace
                e.Handled = true;
                MessageBox.Show("Please enter a Number value");
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {//On-Click Properties Columns Length TextBox
            char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 46 && chr != 8)
            {
                //chr = 46 allows "." 
                //chr = 8 allows backspace
                e.Handled = true;
                MessageBox.Show("Please enter a Number value");
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {//On-Click Properties Columns Thickness TextBox
            char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 46 && chr != 8)
            {
                //chr = 46 allows "." 
                //chr = 8 allows backspace
                e.Handled = true;
                MessageBox.Show("Please enter a Number value");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {// Column Properties Edit Button
            textBox7.ReadOnly = false; // Makes the Textbox Editable
            textBox7.BackColor = System.Drawing.SystemColors.Window; // Changes the Textbox color to white
            textBox6.ReadOnly = false; // Makes the Textbox Editable
            textBox6.BackColor = System.Drawing.SystemColors.Window; // Changes the Textbox color to white
            textBox5.ReadOnly = false; // Makes the Textbox Editable
            textBox5.BackColor = System.Drawing.SystemColors.Window; // Changes the Textbox color to white
        }

        private void button8_Click(object sender, EventArgs e)
        {//Colums Properties Save Button
            textBox7.ReadOnly = true; // Makes the Textbox Un-Editable
            textBox7.BackColor = System.Drawing.SystemColors.ControlLight; // Changes the Textbox color to dirty white
            textBox6.ReadOnly = true; // Makes the Textbox Un-Editable
            textBox6.BackColor = System.Drawing.SystemColors.ControlLight; // Changes the Textbox color to dirty white
            textBox5.ReadOnly = true; // Makes the Textbox Un-Editable
            textBox5.BackColor = System.Drawing.SystemColors.ControlLight; // Changes the Textbox color to dirty white

            cwidth = double.Parse(textBox7.Text); //Gets the value of textBox2 and converts it to double to be stored in width variable
            clength = double.Parse(textBox6.Text); //Gets the value of textBox3 and converts it to double to be stored in length variable
            cthickness = double.Parse(textBox5.Text); //Gets the value of textBox4 and converts it to double to be stored in thickness variable
            cvolume = cwidth * clength * cthickness;
            MessageBox.Show("the total volume is " + cvolume + " cubic meter");
            label12.Text = "" + cvolume + " cubic meter";
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {//On Keypress of Enter Number of Beams textbox
            char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                //chr = 8 allows backspace
                e.Handled = true;
                MessageBox.Show("Please enter a Number value");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {//Enter Number of Beams Edit Button
            textBox12.ReadOnly = false; // Makes the Textbox Editable
            textBox12.BackColor = System.Drawing.SystemColors.Window; // Changes the Textbox color to white
        }

        private void button11_Click(object sender, EventArgs e)
        {//Enter Number of Beams save button
            textBox12.ReadOnly = true; // Makes the Textbox Un-Editable
            textBox12.BackColor = System.Drawing.SystemColors.ControlLight; // Changes the Textbox color to dirty white

            beamNumber = int.Parse(textBox12.Text); //Gets the value of textBox2 and converts it to int to be stored in thickness variable

            for (int i = 1; i <= beamNumber; i++)
            {
                comboBox3.Items.Add("Beam" + i);
                comboBox5.Items.Add("Beam" + i);
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {//On-Click Properties Beams Width TextBox
            char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 46 && chr != 8)
            {
                //chr = 46 allows "." 
                //chr = 8 allows backspace
                e.Handled = true;
                MessageBox.Show("Please enter a Number value");
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {//On-Click Properties Beams Length TextBox
            char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 46 && chr != 8)
            {
                //chr = 46 allows "." 
                //chr = 8 allows backspace
                e.Handled = true;
                MessageBox.Show("Please enter a Number value");
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {//On-Click Properties Beams Thickness TextBox
            char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 46 && chr != 8)
            {
                //chr = 46 allows "." 
                //chr = 8 allows backspace
                e.Handled = true;
                MessageBox.Show("Please enter a Number value");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {// Beam Properties Edit Button
            textBox11.ReadOnly = false; // Makes the Textbox Editable
            textBox11.BackColor = System.Drawing.SystemColors.Window; // Changes the Textbox color to white
            textBox10.ReadOnly = false; // Makes the Textbox Editable
            textBox10.BackColor = System.Drawing.SystemColors.Window; // Changes the Textbox color to white
            textBox9.ReadOnly = false; // Makes the Textbox Editable
            textBox9.BackColor = System.Drawing.SystemColors.Window; // Changes the Textbox color to white
        }

        private void button12_Click(object sender, EventArgs e)
        {//Beams Properties Save Button
            textBox11.ReadOnly = true; // Makes the Textbox Un-Editable
            textBox11.BackColor = System.Drawing.SystemColors.ControlLight; // Changes the Textbox color to dirty white
            textBox10.ReadOnly = true; // Makes the Textbox Un-Editable
            textBox10.BackColor = System.Drawing.SystemColors.ControlLight; // Changes the Textbox color to dirty white
            textBox9.ReadOnly = true; // Makes the Textbox Un-Editable
            textBox9.BackColor = System.Drawing.SystemColors.ControlLight; // Changes the Textbox color to dirty white

            bwidth = double.Parse(textBox11.Text); //Gets the value of textBox2 and converts it to double to be stored in width variable
            blength = double.Parse(textBox10.Text); //Gets the value of textBox3 and converts it to double to be stored in length variable
            bthickness = double.Parse(textBox9.Text); //Gets the value of textBox4 and converts it to double to be stored in thickness variable
            bvolume = bwidth * blength * bthickness;
            MessageBox.Show("the total volume is " + bvolume + " cubic meter");
            label21.Text = "" + bvolume + " cubic meter";
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {//On Keypress of Enter Number of Slabs textbox
            char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                //chr = 8 allows backspace
                e.Handled = true;
                MessageBox.Show("Please enter a Number value");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {//Enter Number of Slabs edit button
            textBox16.ReadOnly = false; // Makes the Textbox Editable
            textBox16.BackColor = System.Drawing.SystemColors.Window; // Changes the Textbox color to white
        }

        private void button15_Click(object sender, EventArgs e)
        {//Enter Number of Slabs save button
            textBox16.ReadOnly = true; // Makes the Textbox Un-Editable
            textBox16.BackColor = System.Drawing.SystemColors.ControlLight; // Changes the Textbox color to dirty white

            slabnumber = int.Parse(textBox16.Text); //Gets the value of textBox2 and converts it to int to be stored in thickness variable

            for (int i = 1; i <= slabnumber; i++)
            {
                comboBox4.Items.Add("Slab" + i);
                comboBox5.Items.Add("Slab" + i);
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {//On-Click Properties Slabs Thickness TextBox
            char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 46 && chr != 8)
            {
                //chr = 46 allows "." 
                //chr = 8 allows backspace
                e.Handled = true;
                MessageBox.Show("Please enter a Number value");
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {//On-Click Properties Slabs Thickness TextBox
            char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 46 && chr != 8)
            {
                //chr = 46 allows "." 
                //chr = 8 allows backspace
                e.Handled = true;
                MessageBox.Show("Please enter a Number value");
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {//On-Click Properties Slabs Thickness TextBox
            char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 46 && chr != 8)
            {
                //chr = 46 allows "." 
                //chr = 8 allows backspace
                e.Handled = true;
                MessageBox.Show("Please enter a Number value");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {// Slab Properties Edit Button
            textBox15.ReadOnly = false; // Makes the Textbox Editable
            textBox15.BackColor = System.Drawing.SystemColors.Window; // Changes the Textbox color to white
            textBox14.ReadOnly = false; // Makes the Textbox Editable
            textBox14.BackColor = System.Drawing.SystemColors.Window; // Changes the Textbox color to white
            textBox13.ReadOnly = false; // Makes the Textbox Editable
            textBox13.BackColor = System.Drawing.SystemColors.Window; // Changes the Textbox color to white
        }

        private void button16_Click(object sender, EventArgs e)
        {//Slab Properties Save Button
            textBox15.ReadOnly = true; // Makes the Textbox Un-Editable
            textBox15.BackColor = System.Drawing.SystemColors.ControlLight; // Changes the Textbox color to dirty white
            textBox14.ReadOnly = true; // Makes the Textbox Un-Editable
            textBox14.BackColor = System.Drawing.SystemColors.ControlLight; // Changes the Textbox color to dirty white
            textBox13.ReadOnly = true; // Makes the Textbox Un-Editable
            textBox13.BackColor = System.Drawing.SystemColors.ControlLight; // Changes the Textbox color to dirty white

            swidth = double.Parse(textBox15.Text); //Gets the value of textBox2 and converts it to double to be stored in width variable
            slength = double.Parse(textBox14.Text); //Gets the value of textBox3 and converts it to double to be stored in length variable
            sthickness = double.Parse(textBox13.Text); //Gets the value of textBox4 and converts it to double to be stored in thickness variable
            svolume = swidth * slength * sthickness;
            MessageBox.Show("the total volume is " + svolume + " cubic meter");
            label30.Text = "" + svolume + " cubic meter";
        }

    }
}

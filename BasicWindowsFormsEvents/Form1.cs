using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWindowsFormsEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CountriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("CurrentIndex = " + this.CountriesComboBox.SelectedIndex.ToString());

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked me!");
        }

        private void SubmitButton_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.X.ToString());
        }
    }
}

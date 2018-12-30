using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class DateCalculation : UserControl
    {
        public DateCalculation()
        {
            InitializeComponent();
            comboBox1.Items.Add("Different between dates");
            comboBox1.Items.Add("Add or Subtract day");
            comboBox1.SelectedIndex = 0;
            
            


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                dateCalculation_AddorSubtract1.Visible = false;
                dateCalculation_DifferentBetween1.Visible = true;
                dateCalculation_DifferentBetween1.BringToFront();
            }
            else
            {
                dateCalculation_DifferentBetween1.Visible = false;
                dateCalculation_AddorSubtract1.Visible = true;

                dateCalculation_AddorSubtract1.BringToFront();
            }
        }
    }
}

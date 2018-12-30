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
    public partial class DateCalculation_DifferentBetween : UserControl
    {
        public DateCalculation_DifferentBetween()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value == dateTimePicker2.Value)
            {
                lbl_vl.Text = "Same dates";
            }
            else
            {

                if (dateTimePicker1.Value > dateTimePicker2.Value)
                {

                    lbl_vl.Text = ((dateTimePicker1.Value - dateTimePicker2.Value).Days + 1).ToString() + " days";

                }
                else
                {
                    lbl_vl.Text = ((dateTimePicker2.Value - dateTimePicker1.Value).Days).ToString() + " days";

                }
            }

        }
    }
}

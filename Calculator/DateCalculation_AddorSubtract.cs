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
    public partial class DateCalculation_AddorSubtract : UserControl
    {
        public bool add = true;
        public DateTime daytime_value = new DateTime();
        public DateCalculation_AddorSubtract()
        {
            InitializeComponent();
            cbb_year.SelectedIndex = 0;
            cbb_month.SelectedIndex = 0;
            cbb_day.SelectedIndex = 0;



        }
        public int getvalue()
        {
            
            int result;
            result = Int32.Parse(cbb_year.Text) * 365 + Int32.Parse(cbb_month.Text) * 30 + Int32.Parse(cbb_day.Text);
            return result;
        }
        private void rdo_add_CheckedChanged(object sender, EventArgs e)
        {
            if(rdo_add.Checked == true)
            {
                add = true;
                DateTime vl1 = dateTimePicker1.Value;
                lbl_vl.Text = dateTimePicker1.Value.AddDays(getvalue()).ToString("D");
               
            }
            else
            {
                add = false;

                lbl_vl.Text = dateTimePicker1.Value.AddDays(-getvalue()).ToString("D");
            }
        }

     

        private void combobox_value_Change(object sender, EventArgs e)
        {
            if(cbb_day.SelectedIndex != -1 && cbb_year.SelectedIndex != -1 && cbb_month.SelectedIndex != -1)
            {
                if(add)
                {
                    lbl_vl.Text = dateTimePicker1.Value.AddDays(getvalue()).ToString("D");

                }
                else
                {
                    lbl_vl.Text = dateTimePicker1.Value.AddDays(-getvalue()).ToString("D");

                }

            }



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(add)
            {
                lbl_vl.Text = dateTimePicker1.Value.AddDays(getvalue()).ToString("D");

            }
            else
            {
                lbl_vl.Text = dateTimePicker1.Value.AddDays(-getvalue()).ToString("D");

            }
        }
    }
}

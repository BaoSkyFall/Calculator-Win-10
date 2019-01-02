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
    public partial class WeightAndMass : UserControl
    {
        public WeightAndMass()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;

        }
        public bool combochange = true;
        public bool text1 = true;
        public int vl1;
        public int vl2;
        public decimal exchange;
        // Mảng 2 chiều giá trị exchange của đại lượng Weight And Mass
        public decimal[,] exchange_array = new decimal[,]
        {
            {1m,200m,20m,0.2m,0.02m,0.002m,0.0002m,0.0000002m,0.007055m,0.000441m,0.000031m},
            {0.005m,1m,0.1m,0.001m,0.0001m,0.00001m,0.000001m,0.000000001m,0.000035m,0.000002m,0.00000015747304m},
            {0.05m,10m,1m,0.01m,0.001m,0.0001m,0.00001m,0.00000001m,0.000353m,0.000022m,0.000002m},
            {5m,1000m,100m,1m,0.1m,0.01m,0.001m,0.000001m,0.035274m,0.002205m,0.000157m},
            {50m,10000m,1000m,10m,1m,0.1m,0.01m,0.00001m,0.35274m,0.022046m,0.001575m},
            {500m,100000m,10000m,100m,10m,1m,0.1m,0.0001m,3.527396m,0.220462m,0.015747m},
            {5000m,1000000m,100000m,1000m,100m,10m,1m,0.001m,35.27396m,2.204623m,0.157473m},
            {5000000m,1000000000m,100000000m,1000000m,100000m,10000m,1000m,1m,35273.96m,2204.623m,157.473m},
            {141.7476m,28349.52m,2834.952m,28.34952m,2.834952m,0.283495m,0.02835m,0.000028m,1m,0.0625m,0.004464m},
            {2267.962m,453592.4m,45359.24m,453.5924m,45.35924m,4.535924m,0.453592m,0.000454m,16m,1m,0.071429m},
            {31751.47m,6350293m,635029.3m,6350.293m,635.0293m,63.50293m,6.350293m,0.00635m,224m,14m,1m }


        };
        private void keypres_txt(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (txt_text1.Text == "0" || txt_text2.Text == "0")
            {
                if (text1)
                {
                    txt_text1.Text = "";


                }
                else
                {
                    txt_text2.Text = "";
                }

            }
        }
        // Button số được click

        private void number_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (text1)
            {
                if (txt_text1.Text != "")
                {
                    if (Decimal.Parse(txt_text1.Text) == 0)
                    {
                        txt_text1.Text = "";
                    }
                }

                if (b.Text == ".")
                {
                    if (!txt_text1.Text.Contains("."))
                    {
                        txt_text1.Text = txt_text1.Text + ".";
                    }
                }
                else
                {
                    txt_text1.Text = txt_text1.Text + b.Text;
                }

            }
            else
            {
                if (txt_text2.Text != "")
                {
                    if (Decimal.Parse(txt_text2.Text) == 0)
                    {
                        txt_text2.Text = "";
                    }
                }

                if (b.Text == ".")
                {
                    if (!txt_text2.Text.Contains("."))
                    {
                        txt_text2.Text = txt_text2.Text + ".";
                    }
                }
                else
                {
                    txt_text2.Text = txt_text2.Text + b.Text;
                }
            }

        }

        // Xử lý khi textbox1 được click làm giá trị chính cần convert


        private void txt_text1_Click(object sender, EventArgs e)
        {
            text1 = true;
            combochange = true;
            txt_text1.ForeColor = SystemColors.WindowText;
            txt_text2.ForeColor = SystemColors.GrayText;

        }
        // Xử lý khi textbox2 được click làm giá trị chính cần convert

        private void txt_text2_Click(object sender, EventArgs e)
        {
            text1 = false;
            combochange = true;
            txt_text1.ForeColor = SystemColors.GrayText;
            txt_text2.ForeColor = SystemColors.WindowText;
        }
        // Xử lý khi textbox1 thay đổi text

        private void txt_text1_TextChanged(object sender, EventArgs e)
        {
            if (text1)
            {
                // Nếu combobox đã được thay đổi giá trị index
                if (combochange)
                { 
                    // Khóa combobox
                    combochange = false;
                    //Xử lý 2 giá trị combobox lấy exchange
                    exchange = (exchange_array[comboBox1.SelectedIndex, comboBox2.SelectedIndex]);
                }
                // Xử lý giá trị chuyển đổi

                if (txt_text1.Text != "")
                {
                    decimal d = Decimal.Parse(txt_text1.Text);
                    if (d == 0)
                    {
                        d = 0;
                        txt_text1.Text = "0";
                    }
                    txt_text2.Text = Math.Round((d * exchange), 6).ToString();
                    if (txt_text2.Text.Length > 16)
                    {
                        txt_text2.Text = txt_text2.Text.Substring(0, 16);
                    }
                }
                else if (txt_text1.Text == "0")
                {
                    clearall_click(sender, e);
                }
                else
                {
                    txt_text1.Text = "";
                    txt_text2.Text = "";

                }

            }
        }
        // Xử lý khi textbox2 thay đổi text

        private void txt_text2_TextChanged(object sender, EventArgs e)
        {
            if (!text1)
            {
                // Nếu combobox đã được thay đổi giá trị index
                if (combochange)
                {

                   
                    //Khóa combobox
                    combochange = false;
                    //Xử lý 2 giá trị combobox lấy exchange
                    exchange = exchange_array[comboBox2.SelectedIndex, comboBox1.SelectedIndex];
                }
                // Xử lý giá trị chuyển đổi
                if (txt_text2.Text != "")
                {
                    decimal d = Decimal.Parse(txt_text2.Text);
                    if (d == 0)
                    {
                        d = 0;
                        txt_text2.Text = "0";
                    }
                    txt_text1.Text = Math.Round((d * exchange), 6).ToString();
                    if (txt_text1.Text.Length > 16)
                    {
                        txt_text1.Text = txt_text1.Text.Substring(0, 16);
                    }
                }
                else if (txt_text2.Text == "0")
                {
                    clearall_click(sender, e);
                }
                else
                {
                    txt_text1.Text = "";
                    txt_text2.Text = "";

                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {
                combochange = true;
                if (text1)
                {
                    txt_text1_TextChanged(sender, e);
                }
                else
                {
                    txt_text2_TextChanged(sender, e);
                }


            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {
                combochange = true;

                if (text1)
                {
                    txt_text1_TextChanged(sender, e);
                }
                else
                {
                    txt_text2_TextChanged(sender, e);
                }


            }

        }
        // Lệnh xóa button 1 ky1 tu75
        private void delete_click(object sender, EventArgs e)
        {
            if (text1)
            {
                if (txt_text1.Text != "0" && txt_text1.Text != "")
                {
                    txt_text1.Text = txt_text1.Text.Remove(txt_text1.Text.Length - 1);
                }
            }
            else
            {
                if (txt_text2.Text != "0" && txt_text2.Text != "")
                {
                    txt_text2.Text = txt_text2.Text.Remove(txt_text2.Text.Length - 1);

                }
            }
        }

        private void clearall_click(object sender, EventArgs e)
        {
            txt_text1.Text = "0";
            txt_text2.Text = "0";
        }




    }
}


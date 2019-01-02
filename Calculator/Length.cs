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
    public partial class Length : UserControl
    {
        public Length()
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
        // Mảng 2 chiều giá trị exchange của đại lượng Length
        public decimal[,] exchange_array = new decimal[,]
        {
            {1m,0.001m,0.000001m,0.0000001m,0.000000001m,0.000000000001m,0.00000003937008m,0.00000000328084m,0.00000000109361m,0.00000000000062m},
            {1000m,1m,0.001m,0.0001m,0.000001m,0.000001m,0.03937m,0.003281m,0.001094m,0.00000062137119m},
            {1000000m,1000m,1m,0.1m,0.001m,0.000001m,0.03937m,0.003281m,0.001094m,0.00000062137119m},
            {10000000m,10000m,10m,1m,0.01m,0.00001m,0.393701m,0.032808m,0.010936m,0.000006m },
            {1000000000m,1000000m,1000m,100m,1m,0.001m,39.37008m,3.28084m,1.093613m,0.000621m},
            {1000000000000m,1000000000m,1000000m,100000m,1000m,1m,39370.08m,3280.84m,1093.613m,0.621371m},
            {25400000m,25400m,25.4m,2.54m,0.0254m,0.000025m,1m,0.083333m,0.027778m,0.000016m},
            {304800000m,304800m,304.8m,30.48m,0.3048m,0.000305m,12m,1m,0.333333m,0.000189m },
            {914400000m,914400m,914.4m,91.44m,0.9144m,0.000914m,36m,3m,1m,0.000568m},
            {1609344000000m,1609344000m,1609344m,160934.4m,1609.344m,1.609344m,63360m,5280m,1760m,1m},


        };
        // Lệnh xử lý chỉ nhập số từ textbox
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
                    txt_text2.Text = Math.Round((d * exchange), 14).ToString();
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
                    exchange = exchange_array[comboBox2.SelectedIndex,comboBox1.SelectedIndex];
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
                    txt_text1.Text = Math.Round((d * exchange), 14).ToString();
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

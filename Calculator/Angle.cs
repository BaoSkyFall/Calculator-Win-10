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
    public partial class Angle : UserControl
    {
        public Angle()
        {
            InitializeComponent();
        }
        public bool combochange = true;
        public bool text1 = true;
        public int vl1;
        public int vl2;
        public decimal exchange;
        // Mảng 2 chiều giá trị exchange của đại lượng Weight And Mass
        public decimal[,] exchange_array = new decimal[,]
        {
        {1m, 0.017453m, 1.111111m},
        {57.29578m, 1m, 63.66198m},
        {0.9m, 0.015708m, 1m}


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

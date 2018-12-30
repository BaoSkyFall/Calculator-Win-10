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
    public partial class Volume : UserControl
    {
        public Volume()
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
        // Mảng 2 chiều giá trị exchange của đại lượng Volume
        public decimal[,] exchange_array = new decimal[,]
        {
            {1,0.001m,0.000001m,0.000035m,0.000001m},
            {1000m,1m,0.001m,0.035315m,0.001308m},
            {1000000m,1000,1m,35.31467m,1.307951m},
            {28316.85m,28.31685m,0.028317m,1,0.037037m},
            {764554.9m,764.5549m,0.764555m,27m,1m}

        };
        private void Volume_Load(object sender, EventArgs e)
        {

        }
        // Xu ly cho phep nhap so
        private void textbox_keypress(object sender, KeyPressEventArgs e)
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
            // Nếu textbox chính là text1
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
                    button1_Click(sender, e);
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
            // Nếu text2 là text box chính cần đổi
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
                    button1_Click(sender, e);
                }
                else
                {
                    txt_text1.Text = "";
                    txt_text2.Text = "";

                }
            }

        }
       
        // Lệnh xóa button 1 ky1 tu75
        private void button17_Click(object sender, EventArgs e)
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
        // Lệnh xóa button CE
        private void button1_Click(object sender, EventArgs e)
        {
            txt_text1.Text = "0";
            txt_text2.Text = "0";
        }

        // Xử lý chỉ cho nhập số
       
        // Khi combobox 1 thay đổi giá trị chuyển đổi
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
        // Khi combobox 2 thay đổi giá trị chuyển đổi
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {
                if (text1)
                {
                    combochange = true;
                    txt_text1_TextChanged(sender, e);
                }
                else
                {
                    txt_text2_TextChanged(sender, e);
                }


            }



        }
    }
}

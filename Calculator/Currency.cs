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
    public partial class Currency : UserControl
    {

        public Currency()
        {
            InitializeComponent();
        
            comboBox1.SelectedIndex = 0;
             comboBox2.SelectedIndex = 1;
     
        }
        public bool combochange = true;
        public bool text1 = true;
        private const string urlPattern = "http://rate-exchange-1.appspot.com/currency?from={0}&to={1}";
        public string vl1;
        public string vl2;
        public decimal exchange;
        public static decimal CurrencyConversion(string fromCurrency, string toCurrency)
        {
            string url = string.Format(urlPattern, fromCurrency, toCurrency);

            using (var wc = new System.Net.WebClient())
            {
                var json = wc.DownloadString(url);

                Newtonsoft.Json.Linq.JToken token = Newtonsoft.Json.Linq.JObject.Parse(json);

                decimal exchangeRate = (decimal)token.SelectToken("rate");

                return exchangeRate;
            }
        }
        private void number_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(text1)
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

        private void txt_text1_TextChanged(object sender, EventArgs e)
        {
            if (text1)
            {
                if (combochange)
                {

                    switch (comboBox1.Text)
                    {
                        case "Australia - Dollar": vl1 = "AUD"; break;
                        case "Canadian - Dollar": vl1 = "CAD"; break;
                        case "France - European euro": vl1 = "EUR"; break;
                        case "Hong Kong - Hong Kong dollar": vl1 = "HKD"; break;
                        case "Japan - Japanese yen": vl1 = "JPY"; break;
                        case "Philippines - Philippines peso": vl1 = "PHP"; break;
                        case "Thailand - Thai baht": vl1 = "THB"; break;
                        case "United States of Ameria - United States dollar": vl1 = "USD"; break;
                        case "Vietnam - Vietnamese dong": vl1 = "VND"; break;
                    }
                    switch (comboBox2.Text)
                    {
                        case "Australia - Dollar": vl2 = "AUD"; break;
                        case "Canadian - Dollar": vl2 = "CAD"; break;
                        case "France - European euro": vl2 = "EUR"; break;
                        case "Hong Kong - Hong Kong dollar": vl2 = "HKD"; break;
                        case "Japan - Japanese yen": vl2 = "JPY"; break;
                        case "Philippines - Philippines peso": vl2 = "PHP"; break;
                        case "Thailand - Thai baht": vl2 = "THB"; break;
                        case "United States of Ameria - United States dollar": vl2 = "USD"; break;
                        case "Vietnam - Vietnamese dong": vl2 = "VND"; break;
                    }
                    combochange = false;
                    exchange = CurrencyConversion(vl1, vl2);
                }
                if (txt_text1.Text != "")
                {
                    if(txt_text1.Text.Length <30)
                    {
                        decimal d = Decimal.Parse(txt_text1.Text);
                        if (d == 0)
                        {
                            d = 0;
                            txt_text1.Text = "0";
                        }
                        txt_text2.Text = Math.Round((d * exchange), 2).ToString();
                        if (txt_text2.Text.Length > 16)
                        {
                            txt_text2.Text = txt_text2.Text.Substring(0, 16);
                        }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {
                combochange = true;
                if (text1)
                {
                    txt_text1_TextChanged(sender,e);
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
        private void txt_text1_KeyPress(object sender, KeyPressEventArgs e)
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
            if(text1)
                {
                    txt_text1.Text = "";


                }
            else
                {
                    txt_text2.Text = "";
                }

            }
           
        }



        private void txt_text2_TextChanged(object sender, EventArgs e)
        {
            if (!text1)
            {
                if (combochange)
                {


                    switch (comboBox1.Text)
                    {
                        case "Australia - Dollar": vl1 = "AUD"; break;
                        case "Canadian - Dollar": vl1 = "CAD"; break;
                        case "France - European euro": vl1 = "EUR"; break;
                        case "Hong Kong - Hong Kong dollar": vl1 = "HKD"; break;
                        case "Japan - Japanese yen": vl1 = "JPY"; break;
                        case "Philippines - Philippines peso": vl1 = "PHP"; break;
                        case "Thailand - Thai baht": vl1 = "THB"; break;
                        case "United States of Ameria - United States dollar": vl1 = "USD"; break;
                        case "Vietnam - Vietnamese dong": vl1 = "VND"; break;
                    }
                    switch (comboBox2.Text)
                    {
                        case "Australia - Dollar": vl2 = "AUD"; break;
                        case "Canadian - Dollar": vl2 = "CAD"; break;
                        case "France - European euro": vl2 = "EUR"; break;
                        case "Hong Kong - Hong Kong dollar": vl2 = "HKD"; break;
                        case "Japan - Japanese yen": vl2 = "JPY"; break;
                        case "Philippines - Philippines peso": vl2 = "PHP"; break;
                        case "Thailand - Thai baht": vl2 = "THB"; break;
                        case "United States of Ameria - United States dollar": vl2 = "USD"; break;
                        case "Vietnam - Vietnamese dong": vl2 = "VND"; break;
                    }
                    combochange = false;
                    exchange = CurrencyConversion(vl2, vl1);
                }
                if (txt_text2.Text != "")
                {
                    if (txt_text1.Text.Length < 30)
                    { 
                        decimal d = Decimal.Parse(txt_text2.Text);
                    if (d == 0)
                    {
                        d = 0;
                        txt_text2.Text = "0";
                    }
                    txt_text1.Text = Math.Round((d * exchange),2).ToString();
                    if(txt_text1.Text.Length >16)
                    {
                        txt_text1.Text = txt_text1.Text.Substring(0, 16);
                    }
                    }
                }
                else if(txt_text2.Text == "0")
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

     

        private void txt_text2_Click(object sender, EventArgs e)
        {
            text1 = false;
            combochange = true;
            txt_text1.ForeColor = SystemColors.GrayText;
            txt_text2.ForeColor = SystemColors.WindowText;
        
            //txt_text2_TextChanged(sender, e);
        }

        private void txt_text1_Click(object sender, EventArgs e)
        {
            text1 = true;
            combochange = true;
            txt_text1.ForeColor = SystemColors.WindowText;
            txt_text2.ForeColor = SystemColors.GrayText;
        
            //txt_text1_TextChanged(sender, e);
        }

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

     

        private void button1_Click(object sender, EventArgs e)
        {
            txt_text1.Text = "0";
            txt_text2.Text = "0";
        }

    }
}

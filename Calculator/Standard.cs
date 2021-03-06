﻿using System;
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
    public partial class Standard : UserControl
    {
        public string operation = "";
        public string convertation = "";

        public double result;
        bool enter_value = true;
        bool enter_operation = true;
        public Standard()
        {
            InitializeComponent();
        }

        private void number_click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            if (txt_display.Text == "0")
            {
                txt_display.Text = "";
            }
            if (b.Text == "." && txt_display.Text != "NaN" && txt_display.Text != "" && txt_display.Text != "∞")
            {
                if (!txt_display.Text.Contains("."))
                {
                    txt_display.Text = txt_display.Text + ".";
                }
            }
            else if(b.Text != ".")
            {
                if (txt_display.Text != "∞" && txt_display.Text != "NaN")
                {
                    txt_display.Text = txt_display.Text + b.Text;

                }
                else
                {
                    txt_showops.Text = "";
                    txt_display.Text = b.Text;
                }
            }
            
        }

        private void operation_click(object sender, EventArgs e)
        {
            if (txt_display.Text != "NaN" && txt_display.Text != "" && txt_display.Text != "∞")
            {

                if (enter_operation)
                {
                    Button b = (Button)sender;
                    operation = b.Text;
                    result = Double.Parse(txt_display.Text);
                    txt_showops.Text = txt_display.Text + " " + b.Text + " ";
                    txt_display.Text = "";
                    enter_operation = false;
                    enter_value = true;

                }
                else
                {

                    if (!enter_value)
                    {
                        if (operation == "+")
                        {

                            result = result + Double.Parse(txt_display.Text);
                            Button b = (Button)sender;
                            operation = b.Text;
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            txt_display.Text = "";

                        }
                        else if (operation == "-")
                        {
                            result = result - Double.Parse(txt_display.Text);
                            Button b = (Button)sender;
                            operation = b.Text;
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            txt_display.Text = "";

                        }
                        else if (operation == "*")
                        {
                            result = result * Double.Parse(txt_display.Text);
                            Button b = (Button)sender;
                            operation = b.Text;
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            txt_display.Text = "";

                        }
                        else if (operation == "/")
                        {
                            result = result / Double.Parse(txt_display.Text);
                            Button b = (Button)sender;
                            operation = b.Text;
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            txt_display.Text = "";
                        }
                        //result = Double.Parse(txt_display.Text);
                        enter_value = true;

                    }
                    else
                    {
                        Button b = (Button)sender;
                        txt_showops.Text = txt_showops.Text.Remove(txt_showops.Text.Length - 1);
                        operation = b.Text;
                        txt_showops.Text = txt_showops.Text + " " + b.Text + " ";
                    }

                }
            }
        }

        private void btn_equal_click(object sender, EventArgs e)
        {
            if (txt_display.Text != "∞" && txt_display.Text != "NaN" && txt_display.Text != "")
            {


                if (txt_display.Text == "")
                {
                    txt_display.Text = txt_showops.Text.Remove(txt_showops.Text.Length - 1);
                    enter_operation = true;
                    txt_showops.Text = "";

                }
                else if (!enter_value)
                {
                    if (operation == "+")
                    {

                        result = result + Double.Parse(txt_display.Text);
                        txt_history.Text = txt_showops.Text + txt_display.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();
                        txt_showops.Text = "";
                        txt_display.Text = result.ToString();
                        enter_operation = true;
                        enter_value = true;



                    }
                    else if (operation == "-")
                    {
                        result = result - Double.Parse(txt_display.Text);
                        txt_history.Text = txt_showops.Text + txt_display.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString(); ;

                        txt_showops.Text = "";
                        txt_display.Text = result.ToString();
                        enter_operation = true;
                        enter_value = true;


                    }
                    else if (operation == "*")
                    {
                        result = result * Double.Parse(txt_display.Text);
                        txt_history.Text = txt_showops.Text + txt_display.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();

                        txt_showops.Text = "";
                        txt_display.Text = result.ToString();
                        enter_value = true;
                        enter_operation = true;


                    }
                    else if (operation == "/")
                    {
                        result = result / Double.Parse(txt_display.Text);
                        txt_history.Text = txt_showops.Text + txt_display.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();

                        txt_showops.Text = "";
                        txt_display.Text = result.ToString();
                        enter_operation = true;
                        enter_value = true;
                    }
                    result = new double();


                }
            }

        }

        private void txt_display_KeyPress(object sender, KeyPressEventArgs e)
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
            if(txt_display.Text == "0")
            {
                txt_display.Text = "";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
         
                if (txt_display.Text != "0" && txt_display.Text != "")
                {
                    txt_display.Text = txt_display.Text.Remove(txt_display.Text.Length - 1);
                }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txt_display.Text = "0";
            txt_showops.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_display.Text = "0";
            txt_showops.Text = "";
        }

        private void convert_click(object sender, EventArgs e)
        {
            if (txt_display.Text != "∞" && txt_display.Text != "NaN" && txt_display.Text != "")
            {
                Button b = (Button)sender;
                convertation = b.Text;
                if (convertation == "1∕x")
                {
                    result = 1 / (Double.Parse(txt_display.Text));


                    txt_showops.Text = "1 / " + txt_display.Text;
                    txt_display.Text = result.ToString();

                    txt_history.Text = txt_showops.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();


                    enter_operation = true;
                    enter_value = true;
                    result = new double();

                }
                else if (convertation == "x²")
                {
                    result = Math.Pow(Double.Parse(txt_display.Text), 2);


                    txt_showops.Text = txt_display.Text + "²";
                    txt_display.Text = result.ToString();
                    enter_operation = true;
                    enter_value = true;
                    txt_history.Text = txt_showops.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();
                    result = new double();


                }
                else if (convertation == "✓")
                {
                    result = Math.Sqrt(Double.Parse(txt_display.Text));


                    txt_showops.Text = "✓ " + txt_display.Text;
                    txt_display.Text = result.ToString();
                    enter_operation = true;
                    enter_value = true;
                    txt_history.Text = txt_showops.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();
                    result = new double();
                    result = new double();


                }
                else if (convertation == "%")
                {
                    //result = result / Double.Parse(txt_display.Text);
                    //txt_showops.Text = "";
                    txt_display.Text = "0";
                    enter_operation = true;
                    enter_value = true;
                    result = new double();
                    txt_history.Text = txt_showops.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();


                }
                else if (convertation == "±")
                {

                    double temp = -Double.Parse(txt_display.Text);
                    txt_display.Text = temp.ToString();
                    txt_history.Text = txt_showops.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();

                }
            }
        }

        private void txt_display_TextChanged(object sender, EventArgs e)
        {
         
            enter_value = false;

        }

        private void delete_history(object sender, EventArgs e)
        {
            txt_history.Text = "";
        }
    }
}

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
    public partial class Scientific : UserControl
    {
        public string operation = "";
        public string converation = "";
        public bool degree = true;
        public bool hyp = false;

        public double result;
        bool enter_value = true;
        bool enter_operation = true;
        public Scientific()
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
                    if (b.Text == "x^y")
                    {
                        result = Double.Parse(txt_display.Text);
                        txt_showops.Text = txt_display.Text + " ^ "; 
                        txt_display.Text = "";
                        enter_operation = false;
                        enter_value = true;
                    }
                    else
                    {
                        result = Double.Parse(txt_display.Text);
                        txt_showops.Text = txt_display.Text + " " + b.Text + " ";
                        txt_display.Text = "";
                        enter_operation = false;
                        enter_value = true;
                    }


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
                        else if (operation == "Mod")
                        {
                            result = result % Double.Parse(txt_display.Text);
                            Button b = (Button)sender;
                            operation = b.Text;
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            txt_display.Text = "";
                        }
                        else if (operation == "x^y")
                        {
                            result = Math.Pow(result, Double.Parse(txt_display.Text));
                            Button b = (Button)sender;
                            operation = b.Text;
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            txt_display.Text = "";
                        }
                        enter_value = true;
                    }
                    else
                    {
                        Button b = (Button)sender;
                        txt_showops.Text = txt_showops.Text.Remove(txt_showops.Text.Length - 1);
                        operation = b.Text;
                        txt_showops.Text = txt_showops.Text + b.Text;
                    }
                    //result = Double.Parse(txt_display.Text);

                }
            }
        }

        private void btn_equal_click(object sender, EventArgs e)
        {
            if (txt_display.Text != "NaN" && txt_display.Text != "" && txt_display.Text != "∞")
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
                        txt_history.Text = txt_showops.Text + txt_display.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString(); ;


                        txt_showops.Text = "";
                        txt_display.Text = result.ToString();
                        enter_operation = true;
                        enter_value = false;
                    }
                    else if (operation == "-")
                    {
                        result = result - Double.Parse(txt_display.Text);
                        txt_history.Text = txt_showops.Text + txt_display.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString(); ;

                        txt_showops.Text = "";
                        txt_display.Text = result.ToString();
                        enter_operation = true;
                        enter_value = false;

                    }
                    else if (operation == "*")
                    {
                        result = result * Double.Parse(txt_display.Text);
                        txt_history.Text = txt_showops.Text + txt_display.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();

                        txt_showops.Text = "";
                        txt_display.Text = result.ToString();
                        enter_value = false;
                        enter_operation = true;

                    }
                    else if (operation == "/")
                    {
                        result = result / Double.Parse(txt_display.Text);
                        txt_history.Text = txt_showops.Text + txt_display.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();

                        txt_showops.Text = "";
                        txt_display.Text = result.ToString();
                        enter_operation = true;
                        enter_value = false;
                    }
                    else if (operation == "Mod")
                    {
                        result = result % Double.Parse(txt_display.Text);
                        txt_history.Text = txt_showops.Text + txt_display.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();

                        txt_showops.Text = "";
                        txt_display.Text = result.ToString();
                        enter_operation = true;
                        enter_value = false;
                    }
                    else if (operation == "x^y")
                    {
                        result = Math.Pow(result, Double.Parse(txt_display.Text));

                        txt_history.Text = txt_showops.Text + txt_display.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();

                        txt_showops.Text = "";
                        txt_display.Text = result.ToString();
                        enter_operation = true;
                        enter_value = false;
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
            if (txt_display.Text == "0")
            {
                txt_display.Text = "";
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

            if (txt_display.Text != "0" && txt_display.Text != "")
            {
                txt_display.Text = txt_display.Text.Remove(txt_display.Text.Length - 1);
            }

        }
        private static int Factorial(int n)
        {
            if (n < 0)
            {

                return -1;
            }
            else if (n == 1 || n == 0)
            {
                return 1;

            }

            return (n * Factorial(n - 1));

        }

        private void clearall_Click(object sender, EventArgs e)
        {
         
                txt_display.Text = "0";
                txt_showops.Text = "";

        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt_display.Text = "0";
            txt_showops.Text = "";
        }

        private void convert_click(object sender, EventArgs e)
        {
            if (txt_display.Text != "NaN" && txt_display.Text != "" && txt_display.Text != "∞")
            {


                Button b = (Button)sender;
                converation = b.Text;
                if (converation == "1∕x")
                {
                    result = 1 / (Double.Parse(txt_display.Text));


                    txt_showops.Text = "1/" + txt_display.Text;
                    txt_display.Text = result.ToString();
                    enter_operation = true;
                    enter_value = false;
                    txt_history.Text = txt_showops.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();

                    result = new double();

                }
                else if (converation == "x²")
                {
                    result = Math.Pow(Double.Parse(txt_display.Text), 2);


                    txt_showops.Text = txt_display.Text + "²";
                    txt_display.Text = result.ToString();
                    enter_operation = true;
                    enter_value = false;
                    txt_history.Text = txt_showops.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();

                    result = new double();

                }
                else if (converation == "✓")
                {
                    result = Math.Sqrt(Double.Parse(txt_display.Text));


                    txt_showops.Text = "✓" + txt_display.Text;
                    txt_display.Text = result.ToString();
                    enter_operation = true;
                    enter_value = false;
                    txt_history.Text = txt_showops.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();

                    result = new double();

                }
                else if (converation == "%")
                {
                    //result = result / Double.Parse(txt_display.Text);
                    //txt_showops.Text = "";
                    txt_display.Text = "0";
                    enter_operation = true;
                    enter_value = false;
                    txt_history.Text = txt_showops.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();

                    result = new double();


                }
                else if (converation == "±")
                {
                    if (txt_display.Text != "")
                    {
                        result = -Double.Parse(txt_display.Text);
                        txt_display.Text = result.ToString();
                        enter_operation = true;
                        enter_value = false;
                    }



                }
                else if (converation == "n!")
                {
                    int n = int.Parse(txt_display.Text);

                    txt_display.Text = Factorial(n).ToString();
                    if (txt_display.Text != "-1")
                    {
                        txt_showops.Text = n.ToString() + "!";
                        txt_history.Text = txt_showops.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();
                    }
                    else
                    {
                        txt_display.Text = "NaN";
                    }


                    enter_operation = true;
                    enter_value = false;
                    result = new double();

                }
                else if (converation == "10x")
                {
                    result = Math.Pow(10, Double.Parse(txt_display.Text));
                    txt_showops.Text = "10" + "^" + txt_display.Text;
                    txt_display.Text = result.ToString();

                    txt_history.Text = txt_showops.Text + " = " + txt_display.Text + "\n" + txt_history.Text.ToString();

                    enter_operation = true;
                    enter_value = false;
                    result = new double();

                }
                else if (converation == "Log")
                {
                    result = Math.Log10(Double.Parse(txt_display.Text));
                    txt_showops.Text = "Log10(" + txt_display.Text + ")";
                    txt_display.Text = result.ToString();

                    txt_history.Text = txt_showops.Text + " = " + txt_display.Text + "\n" + txt_history.Text.ToString();

                    enter_operation = true;
                    enter_value = false;
                    result = new double();

                }
                else if (converation == "Exp")
                {
                    result = Math.Exp(Double.Parse(txt_display.Text));
                    txt_showops.Text = "Log10(" + txt_display.Text + ")";
                    txt_display.Text = result.ToString();

                    txt_history.Text = txt_showops.Text + " = " + txt_display.Text + "\n" + txt_history.Text.ToString();

                    enter_operation = true;
                    enter_value = false;
                    result = new double();

                }
                else if (converation == "sin")
                {

                    if (degree)
                    {

                        result = Math.Sin(Math.PI * Double.Parse(txt_display.Text) / 180.0);


                    }
                    else
                    {

                        result = Math.Sin(Double.Parse(txt_display.Text));

                    }

                    txt_showops.Text = "sin( " + txt_display.Text + " )";


                    txt_display.Text = result.ToString();

                    txt_history.Text = txt_showops.Text + " = " + txt_display.Text + "\n" + txt_history.Text.ToString();

                    enter_operation = true;
                    enter_value = false;
                    result = new double();

                }
                else if (converation == "cos")
                {
                    if (degree)
                    {
                        result = Math.Cos(Math.PI * Double.Parse(txt_display.Text) / 180.0);



                    }
                    else
                    {

                        result = Math.Cos(Double.Parse(txt_display.Text));

                    }


                    txt_showops.Text = "cos( " + txt_display.Text + " )";

                    txt_display.Text = result.ToString();

                    txt_history.Text = txt_showops.Text + " = " + txt_display.Text + "\n" + txt_history.Text.ToString();

                    enter_operation = true;
                    enter_value = false;
                    result = new double();

                }
                else if (converation == "tan")
                {
                    if (degree)
                    {

                        result = Math.Tan(Math.PI * Double.Parse(txt_display.Text) / 180.0);



                    }
                    else
                    {

                        result = Math.Tan(Double.Parse(txt_display.Text));
                    }
                    txt_showops.Text = "tan( " + txt_display.Text + " )";


                    txt_display.Text = result.ToString();

                    txt_history.Text = txt_showops.Text + " = " + txt_display.Text + "\n" + txt_history.Text.ToString();

                    enter_operation = true;
                    enter_value = false;
                    result = new double();

                }
                else if (converation == "sinh")
                {
                    result = Math.Sinh(Double.Parse(txt_display.Text));
                    txt_showops.Text = "sinh( " + txt_display.Text + " )";


                    txt_display.Text = result.ToString();

                    txt_history.Text = txt_showops.Text + " = " + txt_display.Text + "\n" + txt_history.Text.ToString();

                    enter_operation = true;
                    enter_value = false;
                    result = new double();

                }
                else if (converation == "cosh")
                {
                    result = Math.Cosh(Double.Parse(txt_display.Text));
                    txt_showops.Text = "cosh( " + txt_display.Text + " )";


                    txt_display.Text = result.ToString();

                    txt_history.Text = txt_showops.Text + " = " + txt_display.Text + "\n" + txt_history.Text.ToString();

                    enter_operation = true;
                    enter_value = false;
                    result = new double();

                }
                else if (converation == "tanh")
                {
                    result = Math.Tanh(Double.Parse(txt_display.Text));
                    txt_showops.Text = "tanh( " + txt_display.Text + " )";


                    txt_display.Text = result.ToString();

                    txt_history.Text = txt_showops.Text + " = " + txt_display.Text + "\n" + txt_history.Text.ToString();

                    enter_operation = true;
                    enter_value = false;
                    result = new double();

                }
            }

        }

   

        private void pi_click(object sender, EventArgs e)
        {
            txt_display.Text = Math.PI.ToString();
        }

        private void txt_display_TextChanged(object sender, EventArgs e)
        {

            enter_value = false;
        }

        private void btn_deg_and_radi_Click(object sender, EventArgs e)
        {
            if(degree)
            {
                btn_deg_and_radi.Text = "RAD";
                degree = false;
            }
            else
            {
                btn_deg_and_radi.Text = "DEG";
                degree = true;
            }
        }

    

        private void btn_changhyp(object sender, EventArgs e)
        {
            if (!hyp)
            {
                btn_sin.Text = "sinh";
                btn_cos.Text = "cosh";
                btn_tan.Text = "tanh";
                hyp = true;
                btn_hyp.BackColor = System.Drawing.Color.Gainsboro;

            }
            else
            {
                btn_sin.Text = "sin";
                btn_cos.Text = "cos";
                btn_tan.Text = "tan";
                hyp = false;
                btn_hyp.BackColor = SystemColors.ButtonFace;

            }
        }

        private void delete_history(object sender, EventArgs e)
        {
            txt_history.Text = "";
        }
    }
}

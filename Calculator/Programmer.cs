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
    public partial class Programmer : UserControl
    {
        public Programmer()
        {
            InitializeComponent();
            Convert();

        }
        public string operation = "";
        public string convertation = "";

        bool enter_value = true;
        bool enter_operation = true;
        bool shift = false;
        public int result;

        public string mode = "DEC";
        public int temp_int_convert = new int();
        private void Change_Mode_Click_LBL(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            if(lb.Text == "DEC")
            {
                mode = "DEC";
                lbl_bin.BackColor = SystemColors.ButtonFace;
                lbl_hex.BackColor = SystemColors.ButtonFace;
                lbl_oct.BackColor = SystemColors.ButtonFace;
                lbl_dec.BackColor = SystemColors.Highlight;
                txt_display.Text = txt_dec.Text;
                panel_hex.Enabled = false;
                panel_bin.Enabled = true;
                panel_dec.Enabled = true;
                panel_oct.Enabled = true;
            }
            else if (lb.Text == "HEX")
            {
                mode = "HEX";
                lbl_bin.BackColor = SystemColors.ButtonFace;
                lbl_dec.BackColor = SystemColors.ButtonFace;
                lbl_oct.BackColor = SystemColors.ButtonFace;
                lbl_hex.BackColor = SystemColors.Highlight;
                panel_hex.Enabled = true;
                panel_bin.Enabled = true;
                panel_dec.Enabled = true;
                panel_oct.Enabled = true;

            }
            else if (lb.Text == "OCT")
            {
                mode = "OCT";

                lbl_bin.BackColor = SystemColors.ButtonFace;
                lbl_hex.BackColor = SystemColors.ButtonFace;
                lbl_dec.BackColor = SystemColors.ButtonFace;
                lbl_oct.BackColor = SystemColors.Highlight;
                txt_display.Text = txt_oct.Text;
                panel_hex.Enabled = false;
                panel_bin.Enabled = true;
                panel_dec.Enabled = false;
                panel_oct.Enabled = true;

            }
            else if (lb.Text == "BIN")
            {
                mode = "BIN";
                lbl_dec.BackColor = SystemColors.ButtonFace;
                lbl_hex.BackColor = SystemColors.ButtonFace;
                lbl_oct.BackColor = SystemColors.ButtonFace;
                lbl_bin.BackColor = SystemColors.Highlight;
                txt_display.Text = txt_bin.Text;
                panel_hex.Enabled = false;
                btn_1.BringToFront();
                panel_bin.Enabled = true;
                panel_dec.Enabled = false;
                panel_oct.Enabled = false;

            }
        }

        private void Input_Change(object sender, EventArgs e)
        {

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
        private void number_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (txt_display.Text == "0")
            {
                txt_display.Text = "";
            }
            if (b.Text == ".")
            {
                if (!txt_display.Text.Contains("."))
                {
                    txt_display.Text = txt_display.Text + ".";
                }
            }
            else
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
        private void delete_Click(object sender, EventArgs e)
        {

            if (txt_display.Text != "0" && txt_display.Text != "")
            {
                txt_display.Text = txt_display.Text.Remove(txt_display.Text.Length - 1);
            }

        }
        public  void Convert()
        {
            if (mode == "DEC")
            {
                txt_dec.Text = txt_display.Text;
                temp_int_convert = int.Parse(txt_display.Text);
                txt_hex.Text = System.Convert.ToString(temp_int_convert, 16).ToUpper();
                txt_bin.Text = System.Convert.ToString(temp_int_convert, 2);
                txt_oct.Text = System.Convert.ToString(temp_int_convert, 8);
            }
            else if (mode == "HEX")
            {
                txt_hex.Text = txt_display.Text;
                temp_int_convert = int.Parse(txt_hex.Text, System.Globalization.NumberStyles.HexNumber);
                txt_dec.Text = System.Convert.ToString(temp_int_convert, 10);
                txt_bin.Text = System.Convert.ToString(temp_int_convert, 2);
                txt_oct.Text = System.Convert.ToString(temp_int_convert, 8);
            }
            else if(mode == "OCT")
            {
                txt_oct.Text = txt_display.Text;
                temp_int_convert = System.Convert.ToInt32(txt_oct.Text, 8);
                txt_dec.Text = System.Convert.ToString(temp_int_convert, 10);
                txt_bin.Text = System.Convert.ToString(temp_int_convert, 2);
                txt_hex.Text = System.Convert.ToString(temp_int_convert, 16).ToUpper();

            }
            else if(mode =="BIN")
            {
                txt_bin.Text = txt_display.Text;
                temp_int_convert = System.Convert.ToInt32(txt_bin.Text, 2);
                txt_dec.Text = System.Convert.ToString(temp_int_convert, 10);
                txt_oct.Text = System.Convert.ToString(temp_int_convert, 8);
                txt_hex.Text = System.Convert.ToString(temp_int_convert, 16).ToUpper();
            }

        }
        private void Text_Change(object sender, EventArgs e)
        {
            if(txt_display.Text != "")
            {
                Convert();
                enter_value = false;

            }
        }

        private void operation_click(object sender, EventArgs e)
        {
            if (txt_display.Text != "∞" && txt_display.Text != "NaN")
            {
                if (enter_operation)
                {
                    Button b = (Button)sender;
                    operation = b.Text;

                    result = int.Parse(txt_dec.Text);
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

                            result = result + int.Parse(txt_dec.Text);
                            Button b = (Button)sender;
                            operation = b.Text;
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " +b.Text + " ";


                            txt_display.Text = "";

                        }
                        else if (operation == "-")
                        {
                            result = result - int.Parse(txt_dec.Text);
                            Button b = (Button)sender;
                            operation = b.Text;
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            txt_display.Text = "";

                        }
                        else if (operation == "*")
                        {
                            result = result * int.Parse(txt_dec.Text);
                            Button b = (Button)sender;
                            operation = b.Text;
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            txt_display.Text = "";

                        }
                        else if (operation == "/")
                        {
                            result = result / int.Parse(txt_dec.Text);
                            Button b = (Button)sender;
                            operation = b.Text;
                            txt_showops.Text = txt_showops.Text + txt_display.Text +" " + b.Text + " ";
                            txt_display.Text = "";
                        }
                        else if (operation == "Mod")
                        {
                            result = result % int.Parse(txt_dec.Text);
                            Button b = (Button)sender;
                            operation = b.Text;
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            txt_display.Text = "";
                        }
                       else if(operation == "And")
                        {
                            result = result & int.Parse(txt_dec.Text);
                            Button b = (Button)sender;
                            operation = b.Text;
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            txt_display.Text = "";
                        }
                        else if (operation == "Or")
                        {
                            result = result | int.Parse(txt_dec.Text);
                            Button b = (Button)sender;
                            operation = b.Text;
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            txt_display.Text = "";
                        }
                        else if (operation == "Xor")
                        {
                            result = result ^ int.Parse(txt_dec.Text);
                            Button b = (Button)sender;
                            operation = b.Text;
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            txt_display.Text = "";
                        }
                        else if(operation == "Lsh")
                        {
                            result = result <<= int.Parse(txt_dec.Text);
                            Button b = (Button)sender;
                            operation = b.Text;
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            txt_display.Text = "";
                        }
                        else if (operation == "Rsh")
                        {
                            result = result >>= int.Parse(txt_dec.Text);
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
                        if(operation != "And" && operation != "Or" && operation != "Xor" && operation != "Not" && operation != "Lsh" && operation != "Rsh")
                        {
                            txt_showops.Text = txt_showops.Text.Remove(txt_showops.Text.Length - 1);

                        }
                        else
                        {
                            txt_showops.Text = txt_showops.Text.Remove(txt_showops.Text.Length - 3);

                        }
                        operation = b.Text;
                        txt_showops.Text = txt_showops.Text + " " + b.Text + " ";
                    }
                    //result = int.Parse(txt_display.Text);

                }
            }
        }
        private void btn_equal_click(object sender, EventArgs e)
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
                    result = result + int.Parse(txt_dec.Text);
              
                 
                    txt_showops.Text = "";
                   

                    enter_operation = true;
                    enter_value = false;
                }
                else if (operation == "-")
                {
                    result = result - int.Parse(txt_dec.Text);
                   

                    txt_showops.Text = "";
                   

                    enter_operation = true;
                    enter_value = false;

                }
                else if (operation == "*")
                {
                    result = result * int.Parse(txt_dec.Text);


                    txt_showops.Text = "";
                   

                    enter_value = false;
                    enter_operation = true;

                }
                else if (operation == "/")
                {
                    result = result / int.Parse(txt_dec.Text);
                  

                    txt_showops.Text = "";
                   

                    enter_operation = true;
                    enter_value = false;
                }
                else if (operation == "Mod")
                {
                    result = result % int.Parse(txt_dec.Text);
              

                    txt_showops.Text = "";
                   
                    enter_operation = true;
                    enter_value = false;
                }
                else if (operation == "And")
                {
                    result = result & int.Parse(txt_dec.Text);


                    txt_showops.Text = "";
                   

                    enter_operation = true;
                    enter_value = false;
                }
                else if (operation == "Or")
                {
                    result = result | int.Parse(txt_dec.Text);


                    txt_showops.Text = "";
                   

                    enter_operation = true;
                    enter_value = false;
                }
                else if (operation == "Xor")
                {
                    result = result ^ int.Parse(txt_dec.Text);


                    txt_showops.Text = "";
                   

                    enter_operation = true;
                    enter_value = false;
                }
                else if (operation == "Xor")
                {
                    result = result ^ int.Parse(txt_dec.Text);


                    txt_showops.Text = "";
                   
                    enter_operation = true;
                    enter_value = false;
                }
                else if (operation == "Lsh")
                {
                    result <<= int.Parse(txt_dec.Text);


                    txt_showops.Text = "";
                   
                    enter_operation = true;
                    enter_value = false;
                }
                else if (operation == "Rsh")
                {
                    result >>= int.Parse(txt_dec.Text);


                    txt_showops.Text = "";
                   
                    enter_operation = true;
                    enter_value = false;
                }
                // Chuyển kiểu
                if (mode == "DEC")
                {
                    txt_display.Text = result.ToString();

                }
                else if (mode == "HEX")
                {
                    txt_display.Text = System.Convert.ToString(result, 16).ToUpper();



                }
                else if (mode == "BIN")
                {
                    txt_display.Text = System.Convert.ToString(result, 2);

                }
                else if (mode == "OCT")
                {
                    txt_display.Text = System.Convert.ToString(result, 8);

                }

                result = new int();
            }

        }

        private void convert_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            convertation = b.Text;
            if(convertation == "Not")
            {
               

                result = ~int.Parse(txt_dec.Text);


                txt_showops.Text = "Not ( " + txt_display.Text + " )";
               
                enter_operation = true;
                enter_value = false;
               

            }
            if (mode == "DEC")
            {
                txt_display.Text = result.ToString();

            }
            else if (mode == "HEX")
            {
                txt_display.Text = System.Convert.ToString(result, 16).ToUpper();



            }
            else if (mode == "BIN")
            {
                txt_display.Text = System.Convert.ToString(result, 2);

            }
            else if (mode == "OCT")
            {
                txt_display.Text = System.Convert.ToString(result, 8);

            }
            result = new int();

        }

        private void shift_click(object sender, EventArgs e)
        {
            if(!shift)
            {
                shift = true;
                btn_lsh.Text = "RoL";
                btn_rsh.Text = "RoR";
                btn_shift.FlatStyle = FlatStyle.Popup;



            }
            else
            {
                shift = false;
                btn_lsh.Text = "Lsh";
                btn_rsh.Text = "Rsh";
                btn_shift.FlatStyle = FlatStyle.Flat;

            }
        }
    }
}

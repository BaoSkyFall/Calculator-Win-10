using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom;
using System.CodeDom.Compiler;
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
        public string operator_str = "";
        bool enter_value = true;
        bool enter_operation = true;
        bool shift = false;
        public int result;

        public string mode = "DEC";
        public int temp_int_convert = new int();
        static double Calculate(string formula)
        {
            // create compile unit
            CodeCompileUnit compileUnit = new CodeCompileUnit();
            // add a namespace
            CodeNamespace codeNamespace = new CodeNamespace("MyCalculator");
            compileUnit.Namespaces.Add(codeNamespace);

            // add imports/using
            codeNamespace.Imports.Add(new CodeNamespaceImport("System"));

            // create a class
            CodeTypeDeclaration classType = new CodeTypeDeclaration("Calculator");
            classType.Attributes = MemberAttributes.Public;
            codeNamespace.Types.Add(classType);

            // create a method
            CodeMemberMethod method = new CodeMemberMethod();
            method.Name = "Calc";
            method.Attributes = MemberAttributes.Public;
            method.ReturnType = new CodeTypeReference(typeof(double));
            classType.Members.Add(method);

            // add the return statement with the calculation
            CodeMethodReturnStatement returnStatement = new CodeMethodReturnStatement(
                new CodeSnippetExpression(formula));
            method.Statements.Add(returnStatement);

            // add assemblies for linking
            String[] assemblyNames = {
                typeof(System._AppDomain).Assembly.Location,
                typeof(System.CodeDom.Compiler.GeneratedCodeAttribute).Assembly.Location,
            };

            // compile in memory
            CodeDomProvider provider = CodeDomProvider.CreateProvider("CS");
            CompilerParameters parameters = new CompilerParameters(assemblyNames);
            parameters.GenerateExecutable = false;
            parameters.GenerateInMemory = true;
            parameters.TreatWarningsAsErrors = false;

            // check for errors
            CompilerResults compilerResults = provider.CompileAssemblyFromDom(parameters, compileUnit);
            StringBuilder errors = new StringBuilder();
            string errorText = String.Empty;
            foreach (CompilerError compilerError in compilerResults.Errors)
                errorText += compilerError.ToString() + "\n";

            if (errors.Length == 0)
            {
                Type type = compilerResults.CompiledAssembly.GetType("MyCalculator.Calculator");
                object objInstance = Activator.CreateInstance(type);
                object result = type.GetMethod("Calc").Invoke(objInstance, new object[] { });
                return (double)result;
            }
            else
                throw new Exception(errorText);
        }
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
                btn_0.Enabled = true;
                btn_1.Enabled = true;
                btn_2.Enabled = true;
                btn_3.Enabled = true;

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
                btn_0.Enabled = true;
                btn_1.Enabled = true;
                btn_2.Enabled = true;
                btn_3.Enabled = true;
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
                btn_0.Enabled = true;
                btn_1.Enabled = true;
                btn_2.Enabled = false;
                btn_3.Enabled = false;
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
            if (b.Text == "." && txt_display.Text != "" && txt_display.Text != "NaN" && txt_display.Text != "∞")
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
                    if (b.Text == "(")
                    {
                        
                        operator_str = operator_str + b.Text;

                    }
                }
                else
                {
                    txt_showops.Text = "";
                    operator_str = "";
                    txt_display.Text = b.Text;
                }
            }

        }
        private void clearall_Click(object sender, EventArgs e)
        {

            txt_display.Text = "0";
            txt_showops.Text = "";
            operator_str = "";

        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt_display.Text = "0";
            txt_showops.Text = "";
            operator_str = "";
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
            if (txt_display.Text != "NaN" && txt_display.Text != "" && txt_display.Text != "∞" && !txt_display.Text.Contains(")"))
            {

                int count = txt_display.Text.Count(x => x == '(');
                if (mode == "DEC")
                {
                    if(count != 0 && txt_display.Text.Length > 1)
                    {     
                            txt_dec.Text = txt_display.Text.Substring(count);
                    }
                    else
                    {
                        if(!txt_display.Text.Contains("("))
                        {
                            txt_dec.Text = txt_display.Text;
                        }
                        else
                        {
                            txt_dec.Text = "0";
                        }

                    }
                    temp_int_convert = int.Parse(txt_dec.Text);
                    txt_hex.Text = System.Convert.ToString(temp_int_convert, 16).ToUpper();
                    txt_bin.Text = System.Convert.ToString(temp_int_convert, 2);
                    txt_oct.Text = System.Convert.ToString(temp_int_convert, 8);
                }
                else if (mode == "HEX")
                {
                    if (count != 0 && txt_display.Text.Length > 1)
                    {
                        txt_hex.Text = txt_display.Text.Substring(count);
                    }
                    else
                    {
                        if (!txt_display.Text.Contains("("))
                        {
                            txt_hex.Text = txt_display.Text;
                        }
                        else
                        {
                            txt_hex.Text = "0";
                        }

                    }
                    temp_int_convert = int.Parse(txt_hex.Text, System.Globalization.NumberStyles.HexNumber);
                    txt_dec.Text = System.Convert.ToString(temp_int_convert, 10);
                    txt_bin.Text = System.Convert.ToString(temp_int_convert, 2);
                    txt_oct.Text = System.Convert.ToString(temp_int_convert, 8);
                }
                else if (mode == "OCT")
                {
                    if (count != 0 && txt_display.Text.Length > 1)
                    {
                        txt_oct.Text = txt_display.Text.Substring(count);
                    }
                    else
                    {
                        if (!txt_display.Text.Contains("("))
                        {
                            txt_oct.Text = txt_display.Text;
                        }
                        else
                        {
                            txt_oct.Text = "0";
                        }

                    }
                    temp_int_convert = System.Convert.ToInt32(txt_oct.Text, 8);
                    txt_dec.Text = System.Convert.ToString(temp_int_convert, 10);
                    txt_bin.Text = System.Convert.ToString(temp_int_convert, 2);
                    txt_hex.Text = System.Convert.ToString(temp_int_convert, 16).ToUpper();

                }
                else if (mode == "BIN")
                {
                    if (count != 0 && txt_display.Text.Length > 1)
                    {
                        txt_bin.Text = txt_display.Text.Substring(count);
                    }
                    else
                    {
                        if (!txt_display.Text.Contains("("))
                        {
                            txt_bin.Text = txt_display.Text;
                        }
                        else
                        {
                            txt_bin.Text = "0";
                        }

                    }
                    txt_bin.Text = txt_display.Text;
                    temp_int_convert = System.Convert.ToInt32(txt_bin.Text, 2);
                    txt_dec.Text = System.Convert.ToString(temp_int_convert, 10);
                    txt_oct.Text = System.Convert.ToString(temp_int_convert, 8);
                    txt_hex.Text = System.Convert.ToString(temp_int_convert, 16).ToUpper();
                }

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
            if (txt_display.Text != "NaN" && txt_display.Text != "" && txt_display.Text != "∞" )
            {
                if (enter_operation)
                {
                    Button b = (Button)sender;
                    operation = b.Text;                
                    txt_showops.Text = txt_display.Text + " " + b.Text + " ";
                    operator_str = operator_str + txt_dec.Text + " " + b.Text + " ";
                    txt_display.Text = "";

                    enter_operation = false;
                    enter_value = true;


                }
                else
                {

                    if (!enter_value)
                    {
                        Button b = (Button)sender;
                        operation = b.Text;

                        if (operation == "+")
                        {

                           
                            
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " +b.Text + " ";
                            operator_str = operator_str + txt_dec.Text + " " + b.Text + " ";
                            txt_display.Text = "";

                        }
                        else if (operation == "-")
                        {
                            
                          
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            operator_str = operator_str + txt_dec.Text + " " + b.Text + " ";
                            txt_display.Text = "";

                        }
                        else if (operation == "*")
                        {
                           
                            
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            operator_str = operator_str + txt_dec.Text + " " + b.Text + " ";
                            txt_display.Text = "";

                        }
                        else if (operation == "/")
                        {
                            if(txt_dec.Text!= "0")
                            {
                               
                               
                                txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                                operator_str = operator_str + txt_dec.Text + " " + b.Text + " ";
                                txt_display.Text = "";
                            }
                            else
                            {
                                
                                txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";

                                operator_str = "";
                                txt_display.Text = "∞";
                            }
                     
                        }
                        else if (operation == "Mod")
                        {
                         
                         
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " % ";
                            operator_str = operator_str + txt_dec.Text + " " + b.Text + " ";
                            txt_display.Text = "";
                        }
                       else if(operation == "And")
                        {
                            result = result & int.Parse(txt_dec.Text);
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            txt_display.Text = "";
                        }
                        else if (operation == "Or")
                        {
                            result = result | int.Parse(txt_dec.Text);
                       
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            txt_display.Text = "";
                        }
                        else if (operation == "Xor")
                        {
                            result = result ^ int.Parse(txt_dec.Text);
                        
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            txt_display.Text = "";
                        }
                        else if(operation == "Lsh")
                        {
                            result = result <<= int.Parse(txt_dec.Text);
                       
                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            txt_display.Text = "";
                        }
                        else if (operation == "Rsh")
                        {
                            result = result >>= int.Parse(txt_dec.Text);
                     
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
            if (txt_display.Text != "NaN" && txt_display.Text != "" && txt_display.Text != "∞")
            {
                if (txt_display.Text.Contains(")"))
                {
                    int count = txt_display.Text.Count(x => x == ')');

                    operator_str = operator_str + txt_dec.Text;
                    for(int i=0;i< count;i++)
                    {
                        operator_str = operator_str + ")";

                    }
                }
                else
                {
                    operator_str = operator_str + txt_dec.Text;
                }
                

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
                        result = (int)Calculate(operator_str);

                        operator_str = "";

                        txt_showops.Text = "";


                        enter_operation = true;
                        enter_value = false;
                    }
                    else if (operation == "-")
                    {
                        result = (int)Calculate(operator_str);
                        operator_str = "";



                        txt_showops.Text = "";


                        enter_operation = true;
                        enter_value = false;

                    }
                    else if (operation == "*")
                    {
                        result = (int)Calculate(operator_str);
                        operator_str = "";



                        txt_showops.Text = "";


                        enter_value = false;
                        enter_operation = true;

                    }
                    else if (operation == "/")
                    {
                        if (txt_dec.Text != "0")
                        {
                            result = (int)Calculate(operator_str);
                            operator_str = "";



                            txt_showops.Text = "";
                        }
                        else
                        {
                            txt_display.Text = "∞";
                        }


                        enter_operation = true;
                        enter_value = false;
                    }
                    else if (operation == "Mod")
                    {
                        result = (int)Calculate(operator_str);
                        operator_str = "";



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
                    if (txt_display.Text != "∞" && txt_display.Text != "NaN")
                    {
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

                    }

                    result = new int();
                }
            }

        }

        private void convert_click(object sender, EventArgs e)
        {
            if (txt_display.Text != "NaN" && txt_display.Text != "" && txt_display.Text != "∞")
            {


                Button b = (Button)sender;
                convertation = b.Text;
                if (convertation == "Not")
                {


                    result = ~int.Parse(txt_dec.Text);


                    txt_showops.Text = "Not ( " + txt_display.Text + " )";

                    enter_operation = true;
                    enter_value = false;


                }
                else if (convertation == "±")
                {
                    if (txt_display.Text != "")
                    {
                        result = -int.Parse(txt_dec.Text);
                        txt_showops.Text = "- " + txt_display.Text;
                        enter_operation = true;
                        enter_value = false;
                    }

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

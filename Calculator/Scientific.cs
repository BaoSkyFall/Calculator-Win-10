﻿using System;
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
    public partial class Scientific : UserControl
    {
        public string operation = "";
        public string converation = "";
        public string operation_str = "";
        public bool degree = true;
        public bool hyp = false;
        
        public double result;
        bool enter_value = true;
        bool enter_operation = true;
        public Scientific()
        {
            InitializeComponent();
        }
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
        private void number_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (txt_display.Text == "0")
            {
                txt_display.Text = "";
            }
            if (b.Text == "." && txt_display.Text != "NaN" && txt_display.Text != "" && txt_display.Text != "∞" && txt_display.Text != "-∞")
            {
                if (!txt_display.Text.Contains("."))
                {
                    txt_display.Text = txt_display.Text + ".";
                }
            }
            else if(b.Text != ".")
            {
                if (txt_display.Text != "∞" && txt_display.Text != "NaN" && txt_display.Text != "-∞")
                {

                    txt_display.Text = txt_display.Text + b.Text;
                }
                else
                {
                    txt_showops.Text = "";
                    operation_str = txt_showops.Text;
                    txt_display.Text = b.Text;
                }
            }

        }

        private void operation_click(object sender, EventArgs e)
        {
            if (txt_display.Text != "NaN" && txt_display.Text != "" && txt_display.Text != "∞" && txt_display.Text != "-∞")
            {
                if (enter_operation)
                {
                    Button b = (Button)sender;
                    operation = b.Text;
                    result = new double();

                    if (b.Text == "Mod")
                    {

                        txt_showops.Text = txt_display.Text + " % ";
                        operation_str = txt_showops.Text;

                        txt_display.Text = "";
                        enter_operation = false;
                        enter_value = true;
                    }
                    else
                    {

                        txt_showops.Text = txt_display.Text + " " + b.Text + " ";
                        operation_str = txt_showops.Text;

                        txt_display.Text = "";
                        enter_operation = false;
                        enter_value = true;
                    }
                }



                else
                {

                    if (!enter_value)
                    {

                        Button b = (Button)sender;
                        operation = b.Text;
                        if (operation == "+")
                        {



                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            operation_str = txt_showops.Text;

                            txt_display.Text = "";

                        }
                        else if (operation == "-")
                        {


                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            operation_str = txt_showops.Text;

                            txt_display.Text = "";

                        }
                        else if (operation == "*")
                        {


                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            operation_str = txt_showops.Text;

                            txt_display.Text = "";

                        }
                        else if (operation == "/")
                        {

                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + b.Text + " ";
                            operation_str = txt_showops.Text;

                            txt_display.Text = "";
                        }
                        else if (operation == "Mod")
                        {


                            txt_showops.Text = txt_showops.Text + txt_display.Text + " " + "%" + " ";
                            operation_str = txt_showops.Text;

                            txt_display.Text = "";
                        }

                        enter_value = true;
                    }
                    else
                    {
                        Button b = (Button)sender;
                        txt_showops.Text = txt_showops.Text.Remove(txt_showops.Text.Length - 1);
                        operation_str = txt_showops.Text;

                        operation = b.Text;
                        txt_showops.Text = txt_showops.Text + b.Text;
                        operation_str = txt_showops.Text;

                    }
                    //result = Double.Parse(txt_display.Text);

                }
            }
        }
        

        private void btn_equal_click(object sender, EventArgs e)
        {
            if (txt_display.Text != "NaN" && txt_display.Text != "" && txt_display.Text != "∞" && txt_display.Text != "-∞")
            {


                if (txt_display.Text == "")
                {
                    txt_display.Text = txt_showops.Text.Remove(txt_showops.Text.Length - 1);
                    enter_operation = true;
                    txt_showops.Text = "";
                    operation_str = txt_showops.Text;


                }
                else if (!enter_value)
                {
                 if(txt_display.Text.Contains("."))
                    {
                        result = Calculate(operation_str + txt_display.Text) * 1.0;
                    }
                 else
                    {
                        result = Calculate(operation_str + txt_display.Text + ".0") * 1.0;
                    }
                        
                        txt_history.Text = txt_showops.Text + txt_display.Text+ " = " + result.ToString() + "\n" + txt_history.Text.ToString(); ;


                        txt_showops.Text = "";
                        txt_display.Text = result.ToString();
                        enter_operation = true;
                        enter_value = true;
                   
                    result = new double();
                    operation_str = "";
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
             if (txt_display.Text != "NaN" && txt_display.Text != "" && txt_display.Text != "∞" && txt_display.Text != "-∞")
            {


                Button b = (Button)sender;
                converation = b.Text;
                //if (converation == "1∕x")
                //{
                //    result = 1 / (Double.Parse(txt_display.Text));


                //    txt_showops.Text = txt_showops + "1/" + txt_display.Text;
                //    operation_str = txt_showops + result.ToString();
                //    txt_display.Text = result.ToString();
                //    enter_operation = true;
                //    enter_value = true;
                //    txt_history.Text = txt_showops.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();

                //    result = new double();

                //}
                //else 
                if (converation == "x²")
                {
                    result = Math.Pow(Double.Parse(txt_display.Text), 2);

                    //    txt_showops.Text = txt_showops + "1/" + txt_display.Text;
                    //    operation_str = txt_showops + result.ToString();
                    operation_str = txt_showops.Text;
                    txt_showops.Text = txt_showops.Text + txt_display.Text + "²";

                    txt_history.Text = txt_display.Text + "²" + " = " + result.ToString() + "\n" + txt_history.Text.ToString();

                    txt_display.Text = result.ToString();
                    enter_operation = true;
                    enter_value = false;

                    result = new double();

                }
                else if (converation == "✓")
                {
                    result = Math.Sqrt(Double.Parse(txt_display.Text));

                    operation_str = txt_showops.Text;

                    txt_showops.Text = txt_showops.Text +" ✓" + txt_display.Text;
                    txt_history.Text =  " ✓"+ txt_display.Text  + " = " + result.ToString() + "\n" + txt_history.Text.ToString();

                    txt_display.Text = result.ToString();
                    enter_operation = true;
                    enter_value = false;

                    result = new double();

                }
               
                else if (converation == "±")
                {
                    if (txt_display.Text != "")
                    {
                        result = -Double.Parse(txt_display.Text);
                        txt_display.Text = result.ToString();
                        enter_operation = true;
                     
                    }



                }
                else if (converation == "n!")
                {
                    int n = int.Parse(txt_display.Text);           
                    if (txt_display.Text != "-1")
                    {
                        operation_str = txt_showops.Text;

                        txt_showops.Text = txt_showops.Text + txt_display.Text + "!";
                        txt_history.Text = txt_display.Text + "! = " + n.ToString() + "\n" + txt_history.Text.ToString();

                        txt_display.Text = n.ToString();

                    }
                    else
                    {
                        txt_display.Text = "NaN";
                    }


                    enter_operation = true;
                    enter_value = false;
                    result = new double();

                }
                else if (converation == "10^x")
                {
                    result = Math.Pow(10, Double.Parse(txt_display.Text));
                    operation_str = txt_showops.Text;

                    txt_showops.Text = txt_showops.Text + "10 ^ " + txt_display.Text;
                    txt_history.Text = "10 ^ " + txt_display.Text + " = " + result.ToString() + "\n" + txt_history.Text.ToString();
                    txt_display.Text = result.ToString();

                    enter_operation = true;
                    enter_value = false;
                    result = new double();

                }
                else if (converation == "ln")
                {
                    result = Math.Log(Double.Parse(txt_display.Text));
                    operation_str = txt_showops.Text;

                    txt_showops.Text = txt_showops.Text + "Ln(" + txt_display.Text + ")";
                    txt_history.Text = "Ln(" + txt_display.Text + ") = " + result.ToString() + "\n" + txt_history.Text.ToString();
                    txt_display.Text = result.ToString();

                    enter_operation = true;
                    enter_value = false;
                    result = new double();

                }
                else if (converation == "Log")
                {
                    result = Math.Log10(Double.Parse(txt_display.Text));
                    operation_str = txt_showops.Text;

                    txt_showops.Text = txt_showops.Text + "Log(" + txt_display.Text + ")";
                    txt_history.Text = "Log(" + txt_display.Text + ") = " + result.ToString() + "\n" + txt_history.Text.ToString();
                    txt_display.Text = result.ToString();

                    enter_operation = true;
                    enter_value = false;
                    result = new double();

                }
                else if (converation == "Exp")
                {
                    result = Math.Exp(Double.Parse(txt_display.Text));
                    operation_str = txt_showops.Text;

                    txt_showops.Text = txt_showops.Text + "Exp(" + txt_display.Text + ")";
                    txt_history.Text = "Exp(" + txt_display.Text + ") = " + result.ToString() + "\n" + txt_history.Text.ToString();
                    txt_display.Text = result.ToString();

                    enter_operation = true;
                    enter_value = false;
                    result = new double();

                }
                else if (converation == "sin")
                {

                    if (degree)
                    {
                        if (int.Parse(txt_display.Text) % 180 != 0)
                        {
                            result = Math.Sin(Math.PI * Double.Parse(txt_display.Text) / 180.0);
                        }
                        else
                            result = 0;
                    }
                    //RAD
                    else
                    {
                        double degrees = Math.Round((180 / Math.PI) * double.Parse(txt_display.Text),0);
                        
                        if (degrees % 180 != 0)
                        {
                            result = Math.Sin(Math.PI * degrees / 180.0);
                            //result = Math.PI * result;
                        }
                        else
                            result = 0;
                    }

                    operation_str = txt_showops.Text;

                    txt_showops.Text = txt_showops.Text + "sin(" + txt_display.Text + ")";
                    txt_history.Text = "sin(" + txt_display.Text + ") = " + result.ToString() + "\n" + txt_history.Text.ToString();
                    txt_display.Text = result.ToString();

                    enter_operation = true;
                    enter_value = false;
                    result = new double();

                }
                else if (converation == "cos")
                {
                    if (degree)
                    {
                        if (int.Parse(txt_display.Text) % 90 != 0 || int.Parse(txt_display.Text) % 180 == 0)
                        {
                            result = Math.Cos(Math.PI * Double.Parse(txt_display.Text) / 180.0);
                        }
                        else
                            result = 0;
                    }
                    //RAD
                    else
                    {
                        double degrees = Math.Round((180 / Math.PI) * double.Parse(txt_display.Text), 0);

                        if (degrees % 90 != 0 && degrees % 180 == 0)
                        {
                            result = Math.Cos(Math.PI * degrees / 180.0);
                            //result = Math.PI * result;
                        }
                        else
                            result = 0;
                    }



                    operation_str = txt_showops.Text;

                    txt_showops.Text = txt_showops.Text + "cos(" + txt_display.Text + ")";
                    txt_history.Text = "cos(" + txt_display.Text + ") = " + result.ToString() + "\n" + txt_history.Text.ToString();
                    txt_display.Text = result.ToString();

                    enter_operation = true;
                    enter_value = true;
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
                    operation_str = txt_showops.Text;

                    txt_showops.Text = txt_showops.Text + "tan(" + txt_display.Text + ")";
                    txt_history.Text = "tan(" + txt_display.Text + ") = " + result.ToString() + "\n" + txt_history.Text.ToString();
                    txt_display.Text = result.ToString();

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
                    enter_value = true;
                    result = new double();

                }
                else if (converation == "cosh")
                {
                    result = Math.Cosh(Double.Parse(txt_display.Text));
                    txt_showops.Text = "cosh( " + txt_display.Text + " )";


                    txt_display.Text = result.ToString();

                    txt_history.Text = txt_showops.Text + " = " + txt_display.Text + "\n" + txt_history.Text.ToString();

                    enter_operation = true;
                    enter_value = true;
                    result = new double();

                }
                else if (converation == "tanh")
                {
                    result = Math.Tanh(Double.Parse(txt_display.Text));
                    txt_showops.Text = "tanh( " + txt_display.Text + " )";


                    txt_display.Text = result.ToString();

                    txt_history.Text = txt_showops.Text + " = " + txt_display.Text + "\n" + txt_history.Text.ToString();

                    enter_operation = true;
                    enter_value = true;
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Visible = false;
            lbl_title.Text = "Standard";
            this.BackColor = SystemColors.ButtonFace;
            btn_menu.BackColor = SystemColors.ButtonFace;

            standard.BringToFront();
    
      
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (treeView1.Visible == false)
            {
                treeView1.Visible = true;
                treeView1.BringToFront();

            }
            else
            {
                treeView1.Visible = false;

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "node_standard")
            {
                lbl_title.Text = "Standard";
                this.BackColor = SystemColors.ButtonFace;
                btn_menu.BackColor = SystemColors.ButtonFace;
                history1.Visible = true;
                history1.BringToFront();
                standard.BringToFront();
             
                treeView1.Visible = false;
            }
            else if (e.Node.Name == "node_scientific")
            {
                lbl_title.Text = "Scientific";
                this.BackColor = SystemColors.ButtonFace;
                btn_menu.BackColor = SystemColors.ButtonFace;
                history1.Visible = true;
                history1.BringToFront();
                scientific1.BringToFront();

         
                treeView1.Visible = false;

            }
            else if (e.Node.Name == "node_programmer")
            {
                lbl_title.Text = "Programmer";
                this.BackColor = SystemColors.ButtonFace;
                btn_menu.BackColor = SystemColors.ButtonFace;
                history1.Visible = true;
                history1.BringToFront();
                programmer1.BringToFront();
                treeView1.Visible = false;

            }
            else if (e.Node.Name == "node_datecalculation")
            {
                lbl_title.Text = "Date Calculation";
                this.BackColor = SystemColors.ButtonFace;
                btn_menu.BackColor = SystemColors.ButtonFace;
                history1.Visible = false;


                dateCalculation1.BringToFront();
                treeView1.Visible = false;

            }
            else if (e.Node.Name == "node_currency")
            {
                this.BackColor = SystemColors.ActiveBorder;
                btn_menu.BackColor = SystemColors.ActiveBorder;
                lbl_title.Text = "Currency";
                history1.Visible = false;


                currency1.Visible = true;
                currency1.BringToFront();
                treeView1.Visible = false;

            }
            else if (e.Node.Name == "node_volume")
            {
                history1.Visible = false;

                this.BackColor = SystemColors.ActiveBorder;
                btn_menu.BackColor = SystemColors.ActiveBorder;
                lbl_title.Text = "Volume";
         

                volume1.Visible = true;
                volume1.BringToFront();
                treeView1.Visible = false;


            }
            else if (e.Node.Name == "node_length")
            {
                history1.Visible = false;

                this.BackColor = SystemColors.ActiveBorder;
                btn_menu.BackColor = SystemColors.ActiveBorder;
                lbl_title.Text = "Length";
                length1.Visible = true;
          

                length1.BringToFront();
                treeView1.Visible = false;

            }
            else if (e.Node.Name == "node_weightandmass")
            {
                this.BackColor = SystemColors.ActiveBorder;
                btn_menu.BackColor = SystemColors.ActiveBorder;
                lbl_title.Text = "Weight And Mass";

                history1.Visible = false;

                weightAndMass1.Visible = true;
                weightAndMass1.BringToFront();
                treeView1.Visible = false;

                treeView1.Visible = false;

            }
           
        }

    }
}

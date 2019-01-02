namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Calculator");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("    Standard");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("    Scientific");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("    Programmer");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("    Date Calculation");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Converter");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("    Currency");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("    Volume");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("    Length");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("    Weight and Mass");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currency1 = new Calculator.Currency();
            this.dateCalculation1 = new Calculator.DateCalculation();
            this.scientific1 = new Calculator.Scientific();
            this.history1 = new Calculator.History();
            this.standard = new Calculator.Standard();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.volume1 = new Calculator.Volume();
            this.length1 = new Calculator.Length();
            this.weightAndMass1 = new Calculator.WeightAndMass();
            this.programmer1 = new Calculator.Programmer();
            this.SuspendLayout();
            // 
            // currency1
            // 
            this.currency1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.currency1.Location = new System.Drawing.Point(-4, 74);
            this.currency1.Name = "currency1";
            this.currency1.Size = new System.Drawing.Size(781, 577);
            this.currency1.TabIndex = 49;
            // 
            // dateCalculation1
            // 
            this.dateCalculation1.Location = new System.Drawing.Point(4, 74);
            this.dateCalculation1.Name = "dateCalculation1";
            this.dateCalculation1.Size = new System.Drawing.Size(769, 577);
            this.dateCalculation1.TabIndex = 48;
            // 
            // scientific1
            // 
            this.scientific1.Location = new System.Drawing.Point(4, 74);
            this.scientific1.Name = "scientific1";
            this.scientific1.Size = new System.Drawing.Size(773, 577);
            this.scientific1.TabIndex = 47;
            // 
            // history1
            // 
            this.history1.Location = new System.Drawing.Point(412, 0);
            this.history1.Name = "history1";
            this.history1.Size = new System.Drawing.Size(362, 646);
            this.history1.TabIndex = 46;
            // 
            // standard
            // 
            this.standard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.standard.Location = new System.Drawing.Point(0, 74);
            this.standard.Name = "standard";
            this.standard.Size = new System.Drawing.Size(773, 577);
            this.standard.TabIndex = 45;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(79, 24);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(140, 33);
            this.lbl_title.TabIndex = 43;
            this.lbl_title.Text = "Standard";
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.Location = new System.Drawing.Point(16, 12);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(57, 51);
            this.btn_menu.TabIndex = 42;
            this.btn_menu.Text = "≡";
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.button25_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.treeView1.Location = new System.Drawing.Point(79, 24);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "node_calculator";
            treeNode1.Text = "Calculator";
            treeNode2.Name = "Node9";
            treeNode2.Text = "";
            treeNode3.Name = "node_standard";
            treeNode3.Text = "    Standard";
            treeNode4.Name = "Node11";
            treeNode4.Text = "";
            treeNode5.Name = "node_scientific";
            treeNode5.Text = "    Scientific";
            treeNode6.Name = "Node13";
            treeNode6.Text = "";
            treeNode7.Name = "node_programmer";
            treeNode7.Text = "    Programmer";
            treeNode8.Name = "Node15";
            treeNode8.Text = "";
            treeNode9.Name = "node_datecalculation";
            treeNode9.Text = "    Date Calculation";
            treeNode10.Name = "Node17";
            treeNode10.Text = "";
            treeNode11.Name = "Node18";
            treeNode11.Text = "Converter";
            treeNode12.Name = "Node19";
            treeNode12.Text = "";
            treeNode13.Name = "node_currency";
            treeNode13.Text = "    Currency";
            treeNode14.Name = "Node21";
            treeNode14.Text = "";
            treeNode15.Name = "node_volume";
            treeNode15.Text = "    Volume";
            treeNode16.Name = "Node23";
            treeNode16.Text = "";
            treeNode17.Name = "node_length";
            treeNode17.Text = "    Length";
            treeNode18.Name = "Node25";
            treeNode18.Text = "";
            treeNode19.Name = "node_weightandmass";
            treeNode19.Text = "    Weight and Mass";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            this.treeView1.ShowLines = false;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.Size = new System.Drawing.Size(327, 592);
            this.treeView1.TabIndex = 44;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // volume1
            // 
            this.volume1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.volume1.Location = new System.Drawing.Point(-3, 74);
            this.volume1.Name = "volume1";
            this.volume1.Size = new System.Drawing.Size(781, 577);
            this.volume1.TabIndex = 50;
            // 
            // length1
            // 
            this.length1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.length1.Location = new System.Drawing.Point(-4, 74);
            this.length1.Name = "length1";
            this.length1.Size = new System.Drawing.Size(781, 577);
            this.length1.TabIndex = 51;
            // 
            // weightAndMass1
            // 
            this.weightAndMass1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.weightAndMass1.Location = new System.Drawing.Point(-4, 74);
            this.weightAndMass1.Name = "weightAndMass1";
            this.weightAndMass1.Size = new System.Drawing.Size(781, 577);
            this.weightAndMass1.TabIndex = 52;
            // 
            // programmer1
            // 
            this.programmer1.Location = new System.Drawing.Point(-4, 74);
            this.programmer1.Name = "programmer1";
            this.programmer1.Size = new System.Drawing.Size(781, 577);
            this.programmer1.TabIndex = 53;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 651);
            this.Controls.Add(this.programmer1);
            this.Controls.Add(this.weightAndMass1);
            this.Controls.Add(this.length1);
            this.Controls.Add(this.volume1);
            this.Controls.Add(this.currency1);
            this.Controls.Add(this.dateCalculation1);
            this.Controls.Add(this.scientific1);
            this.Controls.Add(this.history1);
            this.Controls.Add(this.standard);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Currency currency1;
        private DateCalculation dateCalculation1;
        private Scientific scientific1;
        private History history1;
        private Standard standard;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.TreeView treeView1;
        private Volume volume1;
        private Length length1;
        private WeightAndMass weightAndMass1;
        private Programmer programmer1;
    }
}
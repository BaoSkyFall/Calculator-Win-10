namespace Calculator
{
    partial class Standard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_showops = new System.Windows.Forms.TextBox();
            this.txt_display = new System.Windows.Forms.TextBox();
            this.btn_1x = new System.Windows.Forms.Button();
            this.btn_x2 = new System.Windows.Forms.Button();
            this.btn_square = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btn_minusplus = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.txt_history = new System.Windows.Forms.Label();
            this.button27 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_showops
            // 
            this.txt_showops.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_showops.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_showops.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_showops.Location = new System.Drawing.Point(22, 4);
            this.txt_showops.Multiline = true;
            this.txt_showops.Name = "txt_showops";
            this.txt_showops.ReadOnly = true;
            this.txt_showops.Size = new System.Drawing.Size(378, 22);
            this.txt_showops.TabIndex = 63;
            this.txt_showops.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_display
            // 
            this.txt_display.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_display.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_display.Location = new System.Drawing.Point(22, 39);
            this.txt_display.Multiline = true;
            this.txt_display.Name = "txt_display";
            this.txt_display.Size = new System.Drawing.Size(378, 58);
            this.txt_display.TabIndex = 62;
            this.txt_display.Text = "0";
            this.txt_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_display.TextChanged += new System.EventHandler(this.txt_display_TextChanged);
            this.txt_display.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_display_KeyPress);
            // 
            // btn_1x
            // 
            this.btn_1x.BackColor = System.Drawing.Color.DarkGray;
            this.btn_1x.FlatAppearance.BorderSize = 0;
            this.btn_1x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1x.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1x.Location = new System.Drawing.Point(310, 111);
            this.btn_1x.Name = "btn_1x";
            this.btn_1x.Size = new System.Drawing.Size(90, 69);
            this.btn_1x.TabIndex = 61;
            this.btn_1x.Text = "1∕x";
            this.btn_1x.UseVisualStyleBackColor = false;
            this.btn_1x.Click += new System.EventHandler(this.convert_click);
            // 
            // btn_x2
            // 
            this.btn_x2.BackColor = System.Drawing.Color.DarkGray;
            this.btn_x2.FlatAppearance.BorderSize = 0;
            this.btn_x2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_x2.Location = new System.Drawing.Point(214, 111);
            this.btn_x2.Name = "btn_x2";
            this.btn_x2.Size = new System.Drawing.Size(90, 69);
            this.btn_x2.TabIndex = 60;
            this.btn_x2.Text = "x²";
            this.btn_x2.UseVisualStyleBackColor = false;
            this.btn_x2.Click += new System.EventHandler(this.convert_click);
            // 
            // btn_square
            // 
            this.btn_square.BackColor = System.Drawing.Color.DarkGray;
            this.btn_square.FlatAppearance.BorderSize = 0;
            this.btn_square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_square.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_square.Location = new System.Drawing.Point(118, 111);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(90, 69);
            this.btn_square.TabIndex = 59;
            this.btn_square.Text = "✓";
            this.btn_square.UseVisualStyleBackColor = false;
            this.btn_square.Click += new System.EventHandler(this.convert_click);
            // 
            // btn_mod
            // 
            this.btn_mod.BackColor = System.Drawing.Color.DarkGray;
            this.btn_mod.FlatAppearance.BorderSize = 0;
            this.btn_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mod.Location = new System.Drawing.Point(22, 111);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(90, 69);
            this.btn_mod.TabIndex = 58;
            this.btn_mod.Text = "%";
            this.btn_mod.UseVisualStyleBackColor = false;
            this.btn_mod.Click += new System.EventHandler(this.convert_click);
            // 
            // btn_equal
            // 
            this.btn_equal.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_equal.FlatAppearance.BorderSize = 0;
            this.btn_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equal.Location = new System.Drawing.Point(310, 485);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(90, 69);
            this.btn_equal.TabIndex = 57;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = false;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Gainsboro;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(310, 335);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(90, 69);
            this.button19.TabIndex = 56;
            this.button19.Text = "-";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.operation_click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Gainsboro;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(310, 410);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(90, 69);
            this.button20.TabIndex = 55;
            this.button20.Text = "+";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.operation_click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Gainsboro;
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(310, 260);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(90, 69);
            this.button21.TabIndex = 54;
            this.button21.Text = "*";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.operation_click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Gainsboro;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(310, 186);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(90, 69);
            this.button22.TabIndex = 53;
            this.button22.Text = "/";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.operation_click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Gainsboro;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(214, 485);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(90, 69);
            this.button13.TabIndex = 52;
            this.button13.Text = ".";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.number_click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Gainsboro;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(214, 335);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 69);
            this.button14.TabIndex = 51;
            this.button14.Text = "6";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.number_click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Gainsboro;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(214, 410);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(90, 69);
            this.button15.TabIndex = 50;
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.number_click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Gainsboro;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(214, 260);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(90, 69);
            this.button16.TabIndex = 49;
            this.button16.Text = "9";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.number_click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Gainsboro;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(214, 186);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(90, 69);
            this.button17.TabIndex = 48;
            this.button17.Text = "⌫";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gainsboro;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(118, 485);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 69);
            this.button8.TabIndex = 47;
            this.button8.Text = "0";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.number_click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gainsboro;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(118, 335);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 69);
            this.button9.TabIndex = 46;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.number_click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Gainsboro;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(118, 410);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 69);
            this.button10.TabIndex = 45;
            this.button10.Text = "2";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.number_click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Gainsboro;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(118, 260);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(90, 69);
            this.button11.TabIndex = 44;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.number_click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Gainsboro;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(118, 186);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(90, 69);
            this.button12.TabIndex = 43;
            this.button12.Text = "C";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // btn_minusplus
            // 
            this.btn_minusplus.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_minusplus.FlatAppearance.BorderSize = 0;
            this.btn_minusplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minusplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minusplus.Location = new System.Drawing.Point(22, 485);
            this.btn_minusplus.Name = "btn_minusplus";
            this.btn_minusplus.Size = new System.Drawing.Size(90, 69);
            this.btn_minusplus.TabIndex = 42;
            this.btn_minusplus.Text = "±";
            this.btn_minusplus.UseVisualStyleBackColor = false;
            this.btn_minusplus.Click += new System.EventHandler(this.convert_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(22, 335);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 69);
            this.button4.TabIndex = 41;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(22, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 69);
            this.button3.TabIndex = 40;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(22, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 69);
            this.button2.TabIndex = 39;
            this.button2.Text = "7";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 69);
            this.button1.TabIndex = 38;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Gainsboro;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(22, 261);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(90, 69);
            this.button18.TabIndex = 39;
            this.button18.Text = "7";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.number_click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Gainsboro;
            this.button25.FlatAppearance.BorderSize = 0;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(22, 411);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(90, 69);
            this.button25.TabIndex = 40;
            this.button25.Text = "1";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.number_click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Gainsboro;
            this.button26.FlatAppearance.BorderSize = 0;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(22, 336);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(90, 69);
            this.button26.TabIndex = 41;
            this.button26.Text = "4";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.number_click);
            // 
            // txt_history
            // 
            this.txt_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_history.Location = new System.Drawing.Point(428, 39);
            this.txt_history.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_history.Name = "txt_history";
            this.txt_history.Size = new System.Drawing.Size(324, 441);
            this.txt_history.TabIndex = 68;
            this.txt_history.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button27.FlatAppearance.BorderSize = 0;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(695, 505);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(57, 51);
            this.button27.TabIndex = 64;
            this.button27.Text = "🗑";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.delete_history);
            // 
            // Standard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_history);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.txt_showops);
            this.Controls.Add(this.txt_display);
            this.Controls.Add(this.btn_1x);
            this.Controls.Add(this.btn_x2);
            this.Controls.Add(this.btn_square);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btn_minusplus);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Standard";
            this.Size = new System.Drawing.Size(781, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_showops;
        private System.Windows.Forms.TextBox txt_display;
        private System.Windows.Forms.Button btn_1x;
        private System.Windows.Forms.Button btn_x2;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btn_minusplus;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Label txt_history;
        private System.Windows.Forms.Button button27;
    }
}

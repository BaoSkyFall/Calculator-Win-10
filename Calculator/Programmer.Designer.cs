namespace Calculator
{
    partial class Programmer
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
            this.button42 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.txt_showops = new System.Windows.Forms.TextBox();
            this.txt_display = new System.Windows.Forms.TextBox();
            this.button44 = new System.Windows.Forms.Button();
            this.btn_E = new System.Windows.Forms.Button();
            this.btn_F = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.btn_shift = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.btn_lsh = new System.Windows.Forms.Button();
            this.btn_rsh = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.lbl_hex = new System.Windows.Forms.Label();
            this.txt_hex = new System.Windows.Forms.TextBox();
            this.txt_dec = new System.Windows.Forms.TextBox();
            this.lbl_dec = new System.Windows.Forms.Label();
            this.txt_oct = new System.Windows.Forms.TextBox();
            this.lbl_oct = new System.Windows.Forms.Label();
            this.txt_bin = new System.Windows.Forms.TextBox();
            this.lbl_bin = new System.Windows.Forms.Label();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.panel_oct = new System.Windows.Forms.Panel();
            this.panel_dec = new System.Windows.Forms.Panel();
            this.panel_hex = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.panel_oct.SuspendLayout();
            this.panel_dec.SuspendLayout();
            this.panel_hex.SuspendLayout();
            this.SuspendLayout();
            // 
            // button42
            // 
            this.button42.BackColor = System.Drawing.Color.Gainsboro;
            this.button42.Enabled = false;
            this.button42.FlatAppearance.BorderSize = 0;
            this.button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button42.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button42.Location = new System.Drawing.Point(271, 513);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(60, 40);
            this.button42.TabIndex = 204;
            this.button42.Text = ".";
            this.button42.UseVisualStyleBackColor = false;
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_0.FlatAppearance.BorderSize = 0;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(205, 514);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(60, 40);
            this.btn_0.TabIndex = 203;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.number_click);
            // 
            // button45
            // 
            this.button45.BackColor = System.Drawing.Color.Gainsboro;
            this.button45.FlatAppearance.BorderSize = 0;
            this.button45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button45.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button45.Location = new System.Drawing.Point(337, 513);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(60, 40);
            this.button45.TabIndex = 201;
            this.button45.Text = "=";
            this.button45.UseVisualStyleBackColor = false;
            this.button45.Click += new System.EventHandler(this.btn_equal_click);
            // 
            // txt_showops
            // 
            this.txt_showops.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_showops.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_showops.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_showops.Location = new System.Drawing.Point(19, 8);
            this.txt_showops.Multiline = true;
            this.txt_showops.Name = "txt_showops";
            this.txt_showops.Size = new System.Drawing.Size(378, 22);
            this.txt_showops.TabIndex = 170;
            this.txt_showops.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_display
            // 
            this.txt_display.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_display.Enabled = false;
            this.txt_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_display.Location = new System.Drawing.Point(19, 43);
            this.txt_display.Multiline = true;
            this.txt_display.Name = "txt_display";
            this.txt_display.Size = new System.Drawing.Size(378, 58);
            this.txt_display.TabIndex = 169;
            this.txt_display.Text = "0";
            this.txt_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_display.TextChanged += new System.EventHandler(this.Text_Change);
            this.txt_display.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_display_KeyPress);
            // 
            // button44
            // 
            this.button44.BackColor = System.Drawing.Color.Gainsboro;
            this.button44.FlatAppearance.BorderSize = 0;
            this.button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button44.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button44.Location = new System.Drawing.Point(139, 513);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(60, 40);
            this.button44.TabIndex = 202;
            this.button44.Text = "±";
            this.button44.UseVisualStyleBackColor = false;
            this.button44.Click += new System.EventHandler(this.convert_click);
            // 
            // btn_E
            // 
            this.btn_E.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_E.FlatAppearance.BorderSize = 0;
            this.btn_E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_E.Location = new System.Drawing.Point(0, 92);
            this.btn_E.Name = "btn_E";
            this.btn_E.Size = new System.Drawing.Size(60, 40);
            this.btn_E.TabIndex = 217;
            this.btn_E.Text = "E";
            this.btn_E.UseVisualStyleBackColor = false;
            this.btn_E.Click += new System.EventHandler(this.number_click);
            // 
            // btn_F
            // 
            this.btn_F.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_F.FlatAppearance.BorderSize = 0;
            this.btn_F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_F.Location = new System.Drawing.Point(66, 93);
            this.btn_F.Name = "btn_F";
            this.btn_F.Size = new System.Drawing.Size(60, 40);
            this.btn_F.TabIndex = 216;
            this.btn_F.Text = "F";
            this.btn_F.UseVisualStyleBackColor = false;
            this.btn_F.Click += new System.EventHandler(this.number_click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_3.FlatAppearance.BorderSize = 0;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(271, 467);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(60, 40);
            this.btn_3.TabIndex = 215;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.number_click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gainsboro;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(337, 467);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 40);
            this.button7.TabIndex = 212;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.operation_click);
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_C.FlatAppearance.BorderSize = 0;
            this.btn_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C.Location = new System.Drawing.Point(0, 46);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(60, 40);
            this.btn_C.TabIndex = 223;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = false;
            this.btn_C.Click += new System.EventHandler(this.number_click);
            // 
            // btn_D
            // 
            this.btn_D.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_D.FlatAppearance.BorderSize = 0;
            this.btn_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_D.Location = new System.Drawing.Point(66, 47);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(60, 40);
            this.btn_D.TabIndex = 222;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = false;
            this.btn_D.Click += new System.EventHandler(this.number_click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Gainsboro;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(137, 49);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 40);
            this.button10.TabIndex = 221;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.number_click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Gainsboro;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(71, 49);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 40);
            this.button11.TabIndex = 220;
            this.button11.Text = "5";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.number_click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Gainsboro;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(5, 49);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 40);
            this.button12.TabIndex = 219;
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.number_click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Gainsboro;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(337, 421);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 40);
            this.button13.TabIndex = 218;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.operation_click);
            // 
            // btn_A
            // 
            this.btn_A.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_A.FlatAppearance.BorderSize = 0;
            this.btn_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_A.Location = new System.Drawing.Point(0, 0);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(60, 40);
            this.btn_A.TabIndex = 229;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = false;
            this.btn_A.Click += new System.EventHandler(this.number_click);
            // 
            // btn_B
            // 
            this.btn_B.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_B.FlatAppearance.BorderSize = 0;
            this.btn_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_B.Location = new System.Drawing.Point(66, 1);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(60, 40);
            this.btn_B.TabIndex = 228;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = false;
            this.btn_B.Click += new System.EventHandler(this.number_click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Gainsboro;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(71, 0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(60, 40);
            this.button16.TabIndex = 227;
            this.button16.Text = "9";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.number_click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Gainsboro;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(5, 0);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(60, 40);
            this.button17.TabIndex = 226;
            this.button17.Text = "8";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.number_click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Gainsboro;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(5, 3);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(60, 40);
            this.button18.TabIndex = 225;
            this.button18.Text = "7";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.number_click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Gainsboro;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(337, 375);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(60, 40);
            this.button19.TabIndex = 224;
            this.button19.Text = "*";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.operation_click);
            // 
            // btn_shift
            // 
            this.btn_shift.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_shift.FlatAppearance.BorderSize = 0;
            this.btn_shift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shift.Location = new System.Drawing.Point(7, 329);
            this.btn_shift.Name = "btn_shift";
            this.btn_shift.Size = new System.Drawing.Size(60, 40);
            this.btn_shift.TabIndex = 235;
            this.btn_shift.Text = "↑";
            this.btn_shift.UseVisualStyleBackColor = false;
            this.btn_shift.Click += new System.EventHandler(this.shift_click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Gainsboro;
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(73, 330);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(60, 40);
            this.button21.TabIndex = 234;
            this.button21.Text = "Mod";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.operation_click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Gainsboro;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(271, 329);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(60, 40);
            this.button22.TabIndex = 233;
            this.button22.Text = "⌫";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.delete_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Gainsboro;
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(205, 329);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(60, 40);
            this.button23.TabIndex = 232;
            this.button23.Text = "C";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.clear_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Gainsboro;
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(139, 329);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(60, 40);
            this.button24.TabIndex = 231;
            this.button24.Text = "CE";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.clearall_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Gainsboro;
            this.button25.FlatAppearance.BorderSize = 0;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(337, 329);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(60, 40);
            this.button25.TabIndex = 230;
            this.button25.Text = "/";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.operation_click);
            // 
            // btn_lsh
            // 
            this.btn_lsh.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_lsh.FlatAppearance.BorderSize = 0;
            this.btn_lsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lsh.Location = new System.Drawing.Point(7, 283);
            this.btn_lsh.Name = "btn_lsh";
            this.btn_lsh.Size = new System.Drawing.Size(60, 40);
            this.btn_lsh.TabIndex = 241;
            this.btn_lsh.Text = "Lsh";
            this.btn_lsh.UseVisualStyleBackColor = false;
            this.btn_lsh.Click += new System.EventHandler(this.operation_click);
            // 
            // btn_rsh
            // 
            this.btn_rsh.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_rsh.FlatAppearance.BorderSize = 0;
            this.btn_rsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rsh.Location = new System.Drawing.Point(73, 284);
            this.btn_rsh.Name = "btn_rsh";
            this.btn_rsh.Size = new System.Drawing.Size(60, 40);
            this.btn_rsh.TabIndex = 240;
            this.btn_rsh.Text = "Rsh";
            this.btn_rsh.UseVisualStyleBackColor = false;
            this.btn_rsh.Click += new System.EventHandler(this.operation_click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Gainsboro;
            this.button28.FlatAppearance.BorderSize = 0;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.Location = new System.Drawing.Point(271, 283);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(60, 40);
            this.button28.TabIndex = 239;
            this.button28.Text = "Not";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.convert_click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.Gainsboro;
            this.button29.FlatAppearance.BorderSize = 0;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.Location = new System.Drawing.Point(205, 283);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(60, 40);
            this.button29.TabIndex = 238;
            this.button29.Text = "Xor";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.operation_click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.Gainsboro;
            this.button30.FlatAppearance.BorderSize = 0;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.Location = new System.Drawing.Point(139, 283);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(60, 40);
            this.button30.TabIndex = 237;
            this.button30.Text = "Or";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.operation_click);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.Gainsboro;
            this.button31.FlatAppearance.BorderSize = 0;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.Location = new System.Drawing.Point(337, 283);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(60, 40);
            this.button31.TabIndex = 236;
            this.button31.Text = "And";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.operation_click);
            // 
            // lbl_hex
            // 
            this.lbl_hex.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hex.Location = new System.Drawing.Point(9, 104);
            this.lbl_hex.Name = "lbl_hex";
            this.lbl_hex.Size = new System.Drawing.Size(59, 30);
            this.lbl_hex.TabIndex = 242;
            this.lbl_hex.Text = "HEX";
            this.lbl_hex.Click += new System.EventHandler(this.Change_Mode_Click_LBL);
            // 
            // txt_hex
            // 
            this.txt_hex.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_hex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_hex.Enabled = false;
            this.txt_hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hex.Location = new System.Drawing.Point(73, 104);
            this.txt_hex.Multiline = true;
            this.txt_hex.Name = "txt_hex";
            this.txt_hex.Size = new System.Drawing.Size(324, 30);
            this.txt_hex.TabIndex = 243;
            this.txt_hex.Click += new System.EventHandler(this.Input_Change);
            this.txt_hex.TextChanged += new System.EventHandler(this.Text_Change);
            // 
            // txt_dec
            // 
            this.txt_dec.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_dec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dec.Enabled = false;
            this.txt_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dec.Location = new System.Drawing.Point(73, 140);
            this.txt_dec.Multiline = true;
            this.txt_dec.Name = "txt_dec";
            this.txt_dec.Size = new System.Drawing.Size(324, 30);
            this.txt_dec.TabIndex = 245;
            this.txt_dec.Click += new System.EventHandler(this.Input_Change);
            // 
            // lbl_dec
            // 
            this.lbl_dec.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbl_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dec.Location = new System.Drawing.Point(9, 140);
            this.lbl_dec.Name = "lbl_dec";
            this.lbl_dec.Size = new System.Drawing.Size(59, 30);
            this.lbl_dec.TabIndex = 244;
            this.lbl_dec.Text = "DEC";
            this.lbl_dec.Click += new System.EventHandler(this.Change_Mode_Click_LBL);
            // 
            // txt_oct
            // 
            this.txt_oct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_oct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_oct.Enabled = false;
            this.txt_oct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_oct.Location = new System.Drawing.Point(73, 176);
            this.txt_oct.Multiline = true;
            this.txt_oct.Name = "txt_oct";
            this.txt_oct.Size = new System.Drawing.Size(324, 30);
            this.txt_oct.TabIndex = 247;
            this.txt_oct.Click += new System.EventHandler(this.Input_Change);
            // 
            // lbl_oct
            // 
            this.lbl_oct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_oct.Location = new System.Drawing.Point(9, 176);
            this.lbl_oct.Name = "lbl_oct";
            this.lbl_oct.Size = new System.Drawing.Size(59, 30);
            this.lbl_oct.TabIndex = 246;
            this.lbl_oct.Text = "OCT";
            this.lbl_oct.Click += new System.EventHandler(this.Change_Mode_Click_LBL);
            // 
            // txt_bin
            // 
            this.txt_bin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_bin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_bin.Enabled = false;
            this.txt_bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bin.Location = new System.Drawing.Point(73, 212);
            this.txt_bin.Multiline = true;
            this.txt_bin.Name = "txt_bin";
            this.txt_bin.Size = new System.Drawing.Size(324, 65);
            this.txt_bin.TabIndex = 249;
            this.txt_bin.Click += new System.EventHandler(this.Input_Change);
            // 
            // lbl_bin
            // 
            this.lbl_bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bin.Location = new System.Drawing.Point(9, 212);
            this.lbl_bin.Name = "lbl_bin";
            this.lbl_bin.Size = new System.Drawing.Size(59, 30);
            this.lbl_bin.TabIndex = 248;
            this.lbl_bin.Text = "BIN";
            this.lbl_bin.Click += new System.EventHandler(this.Change_Mode_Click_LBL);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_1.FlatAppearance.BorderSize = 0;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(139, 467);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(60, 40);
            this.btn_1.TabIndex = 213;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.number_click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_2.FlatAppearance.BorderSize = 0;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(206, 467);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(60, 40);
            this.btn_2.TabIndex = 214;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.number_click);
            // 
            // panel_oct
            // 
            this.panel_oct.Controls.Add(this.panel_dec);
            this.panel_oct.Controls.Add(this.button12);
            this.panel_oct.Controls.Add(this.button11);
            this.panel_oct.Controls.Add(this.button10);
            this.panel_oct.Controls.Add(this.button18);
            this.panel_oct.Location = new System.Drawing.Point(135, 374);
            this.panel_oct.Name = "panel_oct";
            this.panel_oct.Size = new System.Drawing.Size(200, 90);
            this.panel_oct.TabIndex = 251;
            // 
            // panel_dec
            // 
            this.panel_dec.Controls.Add(this.button17);
            this.panel_dec.Controls.Add(this.button16);
            this.panel_dec.Location = new System.Drawing.Point(66, 3);
            this.panel_dec.Name = "panel_dec";
            this.panel_dec.Size = new System.Drawing.Size(136, 43);
            this.panel_dec.TabIndex = 252;
            // 
            // panel_hex
            // 
            this.panel_hex.Controls.Add(this.btn_C);
            this.panel_hex.Controls.Add(this.btn_F);
            this.panel_hex.Controls.Add(this.btn_E);
            this.panel_hex.Controls.Add(this.btn_D);
            this.panel_hex.Controls.Add(this.btn_B);
            this.panel_hex.Controls.Add(this.btn_A);
            this.panel_hex.Enabled = false;
            this.panel_hex.Location = new System.Drawing.Point(7, 377);
            this.panel_hex.Name = "panel_hex";
            this.panel_hex.Size = new System.Drawing.Size(128, 134);
            this.panel_hex.TabIndex = 252;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 40);
            this.button1.TabIndex = 211;
            this.button1.Text = "(";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.number_click);
            // 
            // button41
            // 
            this.button41.BackColor = System.Drawing.Color.Gainsboro;
            this.button41.FlatAppearance.BorderSize = 0;
            this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button41.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button41.Location = new System.Drawing.Point(73, 514);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(60, 40);
            this.button41.TabIndex = 205;
            this.button41.Text = ")";
            this.button41.UseVisualStyleBackColor = false;
            this.button41.Click += new System.EventHandler(this.number_click);
            // 
            // Programmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.panel_hex);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.panel_oct);
            this.Controls.Add(this.txt_bin);
            this.Controls.Add(this.lbl_bin);
            this.Controls.Add(this.txt_oct);
            this.Controls.Add(this.lbl_oct);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.txt_dec);
            this.Controls.Add(this.lbl_dec);
            this.Controls.Add(this.txt_hex);
            this.Controls.Add(this.lbl_hex);
            this.Controls.Add(this.btn_lsh);
            this.Controls.Add(this.btn_rsh);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.btn_shift);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button41);
            this.Controls.Add(this.button42);
            this.Controls.Add(this.button44);
            this.Controls.Add(this.button45);
            this.Controls.Add(this.txt_showops);
            this.Controls.Add(this.txt_display);
            this.Name = "Programmer";
            this.Size = new System.Drawing.Size(781, 572);
            this.panel_oct.ResumeLayout(false);
            this.panel_dec.ResumeLayout(false);
            this.panel_hex.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.TextBox txt_showops;
        private System.Windows.Forms.TextBox txt_display;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button btn_E;
        private System.Windows.Forms.Button btn_F;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button btn_shift;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button btn_lsh;
        private System.Windows.Forms.Button btn_rsh;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Label lbl_hex;
        private System.Windows.Forms.TextBox txt_hex;
        private System.Windows.Forms.TextBox txt_dec;
        private System.Windows.Forms.Label lbl_dec;
        private System.Windows.Forms.TextBox txt_oct;
        private System.Windows.Forms.Label lbl_oct;
        private System.Windows.Forms.TextBox txt_bin;
        private System.Windows.Forms.Label lbl_bin;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Panel panel_oct;
        private System.Windows.Forms.Panel panel_dec;
        private System.Windows.Forms.Panel panel_hex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button41;
    }
}

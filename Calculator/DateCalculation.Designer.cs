namespace Calculator
{
    partial class DateCalculation
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_daygap = new System.Windows.Forms.Label();
            this.dateCalculation_DifferentBetween1 = new Calculator.DateCalculation_DifferentBetween();
            this.dateCalculation_AddorSubtract1 = new Calculator.DateCalculation_AddorSubtract();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(329, 37);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_daygap
            // 
            this.lbl_daygap.AutoSize = true;
            this.lbl_daygap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_daygap.Location = new System.Drawing.Point(25, 488);
            this.lbl_daygap.Name = "lbl_daygap";
            this.lbl_daygap.Size = new System.Drawing.Size(0, 24);
            this.lbl_daygap.TabIndex = 7;
            // 
            // dateCalculation_DifferentBetween1
            // 
            this.dateCalculation_DifferentBetween1.Location = new System.Drawing.Point(29, 192);
            this.dateCalculation_DifferentBetween1.Name = "dateCalculation_DifferentBetween1";
            this.dateCalculation_DifferentBetween1.Size = new System.Drawing.Size(341, 337);
            this.dateCalculation_DifferentBetween1.TabIndex = 8;
            // 
            // dateCalculation_AddorSubtract1
            // 
            this.dateCalculation_AddorSubtract1.Location = new System.Drawing.Point(31, 182);
            this.dateCalculation_AddorSubtract1.Name = "dateCalculation_AddorSubtract1";
            this.dateCalculation_AddorSubtract1.Size = new System.Drawing.Size(341, 392);
            this.dateCalculation_AddorSubtract1.TabIndex = 9;
            // 
            // DateCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateCalculation_AddorSubtract1);
            this.Controls.Add(this.dateCalculation_DifferentBetween1);
            this.Controls.Add(this.lbl_daygap);
            this.Controls.Add(this.comboBox1);
            this.Name = "DateCalculation";
            this.Size = new System.Drawing.Size(816, 577);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_daygap;
        private DateCalculation_DifferentBetween dateCalculation_DifferentBetween1;
        private DateCalculation_AddorSubtract dateCalculation_AddorSubtract1;
    }
}

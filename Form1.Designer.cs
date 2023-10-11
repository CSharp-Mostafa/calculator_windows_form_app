namespace WindowsFormsApp2
{
    partial class FrmHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblFirstOperant = new System.Windows.Forms.TextBox();
            this.LblSecondOperant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GrpBoxOperatorr = new System.Windows.Forms.GroupBox();
            this.RadBtnPlus = new System.Windows.Forms.RadioButton();
            this.RadBtnMinus = new System.Windows.Forms.RadioButton();
            this.RadBtnMultiplication = new System.Windows.Forms.RadioButton();
            this.RadBtnDivision = new System.Windows.Forms.RadioButton();
            this.RadBtnModolus = new System.Windows.Forms.RadioButton();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.TxtBoxExpresion = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxtBoxResult = new System.Windows.Forms.TextBox();
            this.GrpBoxOperatorr.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // LblFirstOperant
            // 
            this.LblFirstOperant.Location = new System.Drawing.Point(310, 69);
            this.LblFirstOperant.Name = "LblFirstOperant";
            this.LblFirstOperant.Size = new System.Drawing.Size(100, 20);
            this.LblFirstOperant.TabIndex = 1;
            // 
            // LblSecondOperant
            // 
            this.LblSecondOperant.Location = new System.Drawing.Point(629, 69);
            this.LblSecondOperant.Name = "LblSecondOperant";
            this.LblSecondOperant.Size = new System.Drawing.Size(100, 20);
            this.LblSecondOperant.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // GrpBoxOperatorr
            // 
            this.GrpBoxOperatorr.Controls.Add(this.RadBtnModolus);
            this.GrpBoxOperatorr.Controls.Add(this.RadBtnDivision);
            this.GrpBoxOperatorr.Controls.Add(this.RadBtnMultiplication);
            this.GrpBoxOperatorr.Controls.Add(this.RadBtnMinus);
            this.GrpBoxOperatorr.Controls.Add(this.RadBtnPlus);
            this.GrpBoxOperatorr.Location = new System.Drawing.Point(266, 159);
            this.GrpBoxOperatorr.Name = "GrpBoxOperatorr";
            this.GrpBoxOperatorr.Size = new System.Drawing.Size(198, 220);
            this.GrpBoxOperatorr.TabIndex = 4;
            this.GrpBoxOperatorr.TabStop = false;
            this.GrpBoxOperatorr.Text = "Operator";
            // 
            // RadBtnPlus
            // 
            this.RadBtnPlus.AutoSize = true;
            this.RadBtnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RadBtnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadBtnPlus.Location = new System.Drawing.Point(69, 40);
            this.RadBtnPlus.Name = "RadBtnPlus";
            this.RadBtnPlus.Size = new System.Drawing.Size(78, 17);
            this.RadBtnPlus.TabIndex = 0;
            this.RadBtnPlus.TabStop = true;
            this.RadBtnPlus.Text = "Addition+";
            this.RadBtnPlus.UseVisualStyleBackColor = false;
            // 
            // RadBtnMinus
            // 
            this.RadBtnMinus.AutoSize = true;
            this.RadBtnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RadBtnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadBtnMinus.Location = new System.Drawing.Point(69, 71);
            this.RadBtnMinus.Name = "RadBtnMinus";
            this.RadBtnMinus.Size = new System.Drawing.Size(62, 17);
            this.RadBtnMinus.TabIndex = 0;
            this.RadBtnMinus.TabStop = true;
            this.RadBtnMinus.Text = "Minus-";
            this.RadBtnMinus.UseVisualStyleBackColor = false;
            // 
            // RadBtnMultiplication
            // 
            this.RadBtnMultiplication.AutoSize = true;
            this.RadBtnMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RadBtnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadBtnMultiplication.Location = new System.Drawing.Point(70, 105);
            this.RadBtnMultiplication.Name = "RadBtnMultiplication";
            this.RadBtnMultiplication.Size = new System.Drawing.Size(105, 17);
            this.RadBtnMultiplication.TabIndex = 0;
            this.RadBtnMultiplication.TabStop = true;
            this.RadBtnMultiplication.Text = "Multiplication*";
            this.RadBtnMultiplication.UseVisualStyleBackColor = false;
            // 
            // RadBtnDivision
            // 
            this.RadBtnDivision.AutoSize = true;
            this.RadBtnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RadBtnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadBtnDivision.Location = new System.Drawing.Point(69, 138);
            this.RadBtnDivision.Name = "RadBtnDivision";
            this.RadBtnDivision.Size = new System.Drawing.Size(76, 17);
            this.RadBtnDivision.TabIndex = 0;
            this.RadBtnDivision.TabStop = true;
            this.RadBtnDivision.Text = "Division/";
            this.RadBtnDivision.UseVisualStyleBackColor = false;
            // 
            // RadBtnModolus
            // 
            this.RadBtnModolus.AutoSize = true;
            this.RadBtnModolus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RadBtnModolus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadBtnModolus.Location = new System.Drawing.Point(69, 168);
            this.RadBtnModolus.Name = "RadBtnModolus";
            this.RadBtnModolus.Size = new System.Drawing.Size(81, 17);
            this.RadBtnModolus.TabIndex = 0;
            this.RadBtnModolus.TabStop = true;
            this.RadBtnModolus.Text = "Modolus%";
            this.RadBtnModolus.UseVisualStyleBackColor = false;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.BackColor = System.Drawing.Color.Green;
            this.BtnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculate.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCalculate.Location = new System.Drawing.Point(27, 54);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(135, 48);
            this.BtnCalculate.TabIndex = 5;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = false;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // TxtBoxExpresion
            // 
            this.TxtBoxExpresion.Location = new System.Drawing.Point(618, 246);
            this.TxtBoxExpresion.Name = "TxtBoxExpresion";
            this.TxtBoxExpresion.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxExpresion.TabIndex = 1;
            this.TxtBoxExpresion.Text = "Expresion";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnExit.Location = new System.Drawing.Point(27, 356);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(135, 48);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtBoxResult
            // 
            this.TxtBoxResult.Location = new System.Drawing.Point(618, 371);
            this.TxtBoxResult.Name = "TxtBoxResult";
            this.TxtBoxResult.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxResult.TabIndex = 1;
            this.TxtBoxResult.Text = "Result";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 475);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.GrpBoxOperatorr);
            this.Controls.Add(this.LblSecondOperant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBoxResult);
            this.Controls.Add(this.TxtBoxExpresion);
            this.Controls.Add(this.LblFirstOperant);
            this.Controls.Add(this.label1);
            this.Name = "FrmHome";
            this.Text = "IsDB-BISEW";
            this.GrpBoxOperatorr.ResumeLayout(false);
            this.GrpBoxOperatorr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LblFirstOperant;
        private System.Windows.Forms.TextBox LblSecondOperant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GrpBoxOperatorr;
        private System.Windows.Forms.RadioButton RadBtnModolus;
        private System.Windows.Forms.RadioButton RadBtnDivision;
        private System.Windows.Forms.RadioButton RadBtnMultiplication;
        private System.Windows.Forms.RadioButton RadBtnMinus;
        private System.Windows.Forms.RadioButton RadBtnPlus;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox TxtBoxExpresion;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TxtBoxResult;
    }
}


﻿namespace BasicCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTotal = new TextBox();
            btn1 = new Button();
            btn4 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDiv = new Button();
            btnEqual = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(22, 12);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(490, 93);
            txtTotal.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(22, 134);
            btn1.Name = "btn1";
            btn1.Size = new Size(109, 79);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(22, 223);
            btn4.Name = "btn4";
            btn4.Size = new Size(109, 79);
            btn4.TabIndex = 12;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(149, 134);
            btn2.Name = "btn2";
            btn2.Size = new Size(109, 79);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(276, 134);
            btn3.Name = "btn3";
            btn3.Size = new Size(109, 79);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button2_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(149, 223);
            btn5.Name = "btn5";
            btn5.Size = new Size(109, 79);
            btn5.TabIndex = 15;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(276, 223);
            btn6.Name = "btn6";
            btn6.Size = new Size(109, 79);
            btn6.TabIndex = 16;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(22, 318);
            btn7.Name = "btn7";
            btn7.Size = new Size(109, 79);
            btn7.TabIndex = 17;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(149, 318);
            btn8.Name = "btn8";
            btn8.Size = new Size(109, 79);
            btn8.TabIndex = 18;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(276, 318);
            btn9.Name = "btn9";
            btn9.Size = new Size(109, 79);
            btn9.TabIndex = 19;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(149, 409);
            btn0.Name = "btn0";
            btn0.Size = new Size(109, 79);
            btn0.TabIndex = 20;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(403, 134);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(109, 79);
            btnPlus.TabIndex = 21;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(403, 223);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(109, 79);
            btnMinus.TabIndex = 22;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(403, 318);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(109, 79);
            btnMultiply.TabIndex = 23;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiv.Location = new Point(403, 409);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(109, 79);
            btnDiv.TabIndex = 24;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(276, 409);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(109, 79);
            btnEqual.TabIndex = 25;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += button8_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(22, 409);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 79);
            btnClear.TabIndex = 26;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 524);
            Controls.Add(btnClear);
            Controls.Add(btnEqual);
            Controls.Add(btnDiv);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTotal;
        private Button btn1;
        private Button btn4;
        private Button btn2;
        private Button btn3;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDiv;
        private Button btnEqual;
        private Button btnClear;
    }
}

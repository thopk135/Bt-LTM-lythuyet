namespace Calculator
{
    partial class Calculator1
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
            txtBox = new TextBox();
            cmd0 = new Button();
            cmd1 = new Button();
            cmd2 = new Button();
            cmd3 = new Button();
            cmd4 = new Button();
            cmd5 = new Button();
            cmd6 = new Button();
            cmd7 = new Button();
            cmd8 = new Button();
            cmd9 = new Button();
            cmdClear = new Button();
            cmdAdd = new Button();
            cmdSubtract = new Button();
            cmdMultiply = new Button();
            cmdDivide = new Button();
            cmdSquare = new Button();
            cmdSqrt = new Button();
            cmdCos = new Button();
            cmdSin = new Button();
            cmdTan = new Button();
            cmdEqual = new Button();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.Location = new Point(106, 12);
            txtBox.Multiline = true;
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(170, 60);
            txtBox.TabIndex = 0;
            // 
            // cmd0
            // 
            cmd0.Location = new Point(51, 289);
            cmd0.Name = "cmd0";
            cmd0.Size = new Size(60, 60);
            cmd0.TabIndex = 1;
            cmd0.Text = "0";
            cmd0.UseVisualStyleBackColor = true;
            cmd0.Click += cmd0_Click;
            // 
            // cmd1
            // 
            cmd1.Location = new Point(51, 232);
            cmd1.Name = "cmd1";
            cmd1.Size = new Size(60, 60);
            cmd1.TabIndex = 2;
            cmd1.Text = "1";
            cmd1.UseVisualStyleBackColor = true;
            cmd1.Click += cmd1_Click;
            // 
            // cmd2
            // 
            cmd2.Location = new Point(106, 232);
            cmd2.Name = "cmd2";
            cmd2.Size = new Size(60, 60);
            cmd2.TabIndex = 3;
            cmd2.Text = "2";
            cmd2.UseVisualStyleBackColor = true;
            cmd2.Click += cmd2_Click;
            // 
            // cmd3
            // 
            cmd3.Location = new Point(162, 232);
            cmd3.Name = "cmd3";
            cmd3.Size = new Size(60, 60);
            cmd3.TabIndex = 4;
            cmd3.Text = "3";
            cmd3.UseVisualStyleBackColor = true;
            cmd3.Click += cmd3_Click;
            // 
            // cmd4
            // 
            cmd4.Location = new Point(51, 174);
            cmd4.Name = "cmd4";
            cmd4.Size = new Size(60, 60);
            cmd4.TabIndex = 5;
            cmd4.Text = "4";
            cmd4.UseVisualStyleBackColor = true;
            cmd4.Click += cmd4_Click;
            // 
            // cmd5
            // 
            cmd5.Location = new Point(106, 174);
            cmd5.Name = "cmd5";
            cmd5.Size = new Size(60, 60);
            cmd5.TabIndex = 6;
            cmd5.Text = "5";
            cmd5.UseVisualStyleBackColor = true;
            cmd5.Click += cmd5_Click;
            // 
            // cmd6
            // 
            cmd6.Location = new Point(162, 174);
            cmd6.Name = "cmd6";
            cmd6.Size = new Size(60, 60);
            cmd6.TabIndex = 7;
            cmd6.Text = "6";
            cmd6.UseVisualStyleBackColor = true;
            cmd6.Click += cmd6_Click;
            // 
            // cmd7
            // 
            cmd7.Location = new Point(51, 122);
            cmd7.Name = "cmd7";
            cmd7.Size = new Size(60, 60);
            cmd7.TabIndex = 8;
            cmd7.Text = "7";
            cmd7.UseVisualStyleBackColor = true;
            cmd7.Click += cmd7_Click;
            // 
            // cmd8
            // 
            cmd8.Location = new Point(106, 122);
            cmd8.Name = "cmd8";
            cmd8.Size = new Size(60, 60);
            cmd8.TabIndex = 9;
            cmd8.Text = "8";
            cmd8.UseVisualStyleBackColor = true;
            cmd8.Click += cmd8_Click;
            // 
            // cmd9
            // 
            cmd9.Location = new Point(162, 122);
            cmd9.Name = "cmd9";
            cmd9.Size = new Size(60, 60);
            cmd9.TabIndex = 10;
            cmd9.Text = "9";
            cmd9.UseVisualStyleBackColor = true;
            cmd9.Click += cmd9_Click;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(51, 68);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(60, 60);
            cmdClear.TabIndex = 11;
            cmdClear.Text = "AC";
            cmdClear.UseVisualStyleBackColor = true;
            cmdClear.Click += cmdClear_Click;
            // 
            // cmdAdd
            // 
            cmdAdd.Location = new Point(218, 232);
            cmdAdd.Name = "cmdAdd";
            cmdAdd.Size = new Size(60, 60);
            cmdAdd.TabIndex = 12;
            cmdAdd.Text = "+";
            cmdAdd.UseVisualStyleBackColor = true;
            cmdAdd.Click += cmdAdd_Click;
            // 
            // cmdSubtract
            // 
            cmdSubtract.Location = new Point(218, 174);
            cmdSubtract.Name = "cmdSubtract";
            cmdSubtract.Size = new Size(60, 60);
            cmdSubtract.TabIndex = 13;
            cmdSubtract.Text = "-";
            cmdSubtract.UseVisualStyleBackColor = true;
            cmdSubtract.Click += cmdSubtract_Click;
            // 
            // cmdMultiply
            // 
            cmdMultiply.Location = new Point(218, 122);
            cmdMultiply.Name = "cmdMultiply";
            cmdMultiply.Size = new Size(60, 60);
            cmdMultiply.TabIndex = 14;
            cmdMultiply.Text = "*";
            cmdMultiply.UseVisualStyleBackColor = true;
            cmdMultiply.Click += cmdMultiply_Click;
            // 
            // cmdDivide
            // 
            cmdDivide.Location = new Point(218, 68);
            cmdDivide.Name = "cmdDivide";
            cmdDivide.Size = new Size(60, 60);
            cmdDivide.TabIndex = 15;
            cmdDivide.Text = "/";
            cmdDivide.UseVisualStyleBackColor = true;
            cmdDivide.Click += cmdDivide_Click;
            // 
            // cmdSquare
            // 
            cmdSquare.Location = new Point(106, 68);
            cmdSquare.Name = "cmdSquare";
            cmdSquare.Size = new Size(60, 60);
            cmdSquare.TabIndex = 16;
            cmdSquare.Text = "x^2";
            cmdSquare.UseVisualStyleBackColor = true;
            cmdSquare.Click += cmdSquare_Click;
            // 
            // cmdSqrt
            // 
            cmdSqrt.Location = new Point(162, 68);
            cmdSqrt.Name = "cmdSqrt";
            cmdSqrt.Size = new Size(60, 60);
            cmdSqrt.TabIndex = 17;
            cmdSqrt.Text = "x^(1/2)";
            cmdSqrt.UseVisualStyleBackColor = true;
            cmdSqrt.Click += cmdsqrt_Click;
            // 
            // cmdCos
            // 
            cmdCos.Location = new Point(162, 289);
            cmdCos.Name = "cmdCos";
            cmdCos.Size = new Size(60, 60);
            cmdCos.TabIndex = 18;
            cmdCos.Text = "Cos";
            cmdCos.UseVisualStyleBackColor = true;
            cmdCos.Click += cmdCos_Click;
            // 
            // cmdSin
            // 
            cmdSin.Location = new Point(106, 289);
            cmdSin.Name = "cmdSin";
            cmdSin.Size = new Size(60, 60);
            cmdSin.TabIndex = 19;
            cmdSin.Text = "Sin";
            cmdSin.UseVisualStyleBackColor = true;
            cmdSin.Click += cmdSin_Click;
            // 
            // cmdTan
            // 
            cmdTan.Location = new Point(218, 289);
            cmdTan.Name = "cmdTan";
            cmdTan.Size = new Size(60, 60);
            cmdTan.TabIndex = 20;
            cmdTan.Text = "Tan";
            cmdTan.UseVisualStyleBackColor = true;
            cmdTan.Click += cmdTan_Click;
            // 
            // cmdEqual
            // 
            cmdEqual.Location = new Point(51, 12);
            cmdEqual.Name = "cmdEqual";
            cmdEqual.Size = new Size(60, 60);
            cmdEqual.TabIndex = 21;
            cmdEqual.Text = "=";
            cmdEqual.UseVisualStyleBackColor = true;
            cmdEqual.Click += cmdequal_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 384);
            Controls.Add(cmdEqual);
            Controls.Add(cmdTan);
            Controls.Add(cmdSin);
            Controls.Add(cmdCos);
            Controls.Add(cmdSqrt);
            Controls.Add(cmdSquare);
            Controls.Add(cmdDivide);
            Controls.Add(cmdMultiply);
            Controls.Add(cmdSubtract);
            Controls.Add(cmdAdd);
            Controls.Add(cmdClear);
            Controls.Add(cmd9);
            Controls.Add(cmd8);
            Controls.Add(cmd7);
            Controls.Add(cmd6);
            Controls.Add(cmd5);
            Controls.Add(cmd4);
            Controls.Add(cmd3);
            Controls.Add(cmd2);
            Controls.Add(cmd1);
            Controls.Add(cmd0);
            Controls.Add(txtBox);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox;
        private Button cmd0;
        private Button cmd1;
        private Button cmd2;
        private Button cmd3;
        private Button cmd4;
        private Button cmd5;
        private Button cmd6;
        private Button cmd7;
        private Button cmd8;
        private Button cmd9;
        private Button cmdClear;
        private Button cmdAdd;
        private Button cmdSubtract;
        private Button cmdMultiply;
        private Button cmdDivide;
        private Button cmdSquare;
        private Button cmdSqrt;
        private Button cmdCos;
        private Button cmdSin;
        private Button cmdTan;
        private Button cmdEqual;
    }
}
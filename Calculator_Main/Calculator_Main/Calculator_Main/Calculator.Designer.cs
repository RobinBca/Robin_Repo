namespace Calculator_Main
{
    partial class Calculator
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
            txtShowResults = new TextBox();
            btnOne = new Button();
            btnFour = new Button();
            btnSeven = new Button();
            btnZero = new Button();
            btnTwo = new Button();
            btnFive = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnSix = new Button();
            btnThree = new Button();
            btnDoubleZero = new Button();
            BtnDot = new Button();
            btnDevide = new Button();
            btnMultiply = new Button();
            btnAdd = new Button();
            btnModDevide = new Button();
            btnMinus = new Button();
            btnEqual = new Button();
            Clear = new Button();
            btnPlay = new Button();
            btnNoUse = new Button();
            txtRobin = new TextBox();
            btnOff = new Button();
            SuspendLayout();
            // 
            // txtShowResults
            // 
            txtShowResults.Font = new Font("Segoe UI", 44F, FontStyle.Bold);
            txtShowResults.Location = new Point(40, 32);
            txtShowResults.Multiline = true;
            txtShowResults.Name = "txtShowResults";
            txtShowResults.Size = new Size(725, 101);
            txtShowResults.TabIndex = 0;
            txtShowResults.Text = "0";
            txtShowResults.TextAlign = HorizontalAlignment.Right;
            txtShowResults.TextChanged += txtShowResults_TextChanged;
            // 
            // btnOne
            // 
            btnOne.Location = new Point(164, 370);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(84, 59);
            btnOne.TabIndex = 1;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += button1_Click;
            // 
            // btnFour
            // 
            btnFour.Location = new Point(164, 308);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(84, 56);
            btnFour.TabIndex = 2;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnSeven
            // 
            btnSeven.Location = new Point(164, 244);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(84, 58);
            btnSeven.TabIndex = 3;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(164, 435);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(83, 59);
            btnZero.TabIndex = 4;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            btnTwo.Location = new Point(265, 370);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(83, 59);
            btnTwo.TabIndex = 5;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnFive
            // 
            btnFive.Location = new Point(265, 308);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(83, 56);
            btnFive.TabIndex = 6;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnEight
            // 
            btnEight.Location = new Point(263, 244);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(85, 58);
            btnEight.TabIndex = 7;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnNine
            // 
            btnNine.Location = new Point(363, 244);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(77, 58);
            btnNine.TabIndex = 8;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += button8_Click;
            // 
            // btnSix
            // 
            btnSix.Location = new Point(363, 308);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(77, 56);
            btnSix.TabIndex = 9;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += bntSix_Click;
            // 
            // btnThree
            // 
            btnThree.Location = new Point(363, 370);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(77, 59);
            btnThree.TabIndex = 10;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnDoubleZero
            // 
            btnDoubleZero.Location = new Point(263, 435);
            btnDoubleZero.Name = "btnDoubleZero";
            btnDoubleZero.Size = new Size(85, 59);
            btnDoubleZero.TabIndex = 11;
            btnDoubleZero.Text = "00";
            btnDoubleZero.UseVisualStyleBackColor = true;
            // 
            // BtnDot
            // 
            BtnDot.Location = new Point(363, 435);
            BtnDot.Name = "BtnDot";
            BtnDot.Size = new Size(77, 59);
            BtnDot.TabIndex = 12;
            BtnDot.Text = "O";
            BtnDot.UseVisualStyleBackColor = true;
            // 
            // btnDevide
            // 
            btnDevide.Location = new Point(475, 244);
            btnDevide.Name = "btnDevide";
            btnDevide.Size = new Size(77, 58);
            btnDevide.TabIndex = 13;
            btnDevide.Text = "➗";
            btnDevide.UseVisualStyleBackColor = true;
            btnDevide.Click += btnDevide_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(475, 308);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(77, 56);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(475, 370);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(77, 124);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModDevide
            // 
            btnModDevide.Location = new Point(574, 308);
            btnModDevide.Name = "btnModDevide";
            btnModDevide.Size = new Size(77, 56);
            btnModDevide.TabIndex = 16;
            btnModDevide.Text = "%";
            btnModDevide.UseVisualStyleBackColor = true;
            btnModDevide.Click += btnModDevide_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(574, 370);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(77, 51);
            btnMinus.TabIndex = 17;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(574, 435);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(77, 59);
            btnEqual.TabIndex = 18;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(53, 435);
            Clear.Name = "Clear";
            Clear.Size = new Size(78, 59);
            Clear.TabIndex = 19;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(53, 244);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(78, 29);
            btnPlay.TabIndex = 20;
            btnPlay.Text = "▶";
            btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnNoUse
            // 
            btnNoUse.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNoUse.Location = new Point(51, 288);
            btnNoUse.Name = "btnNoUse";
            btnNoUse.Size = new Size(80, 133);
            btnNoUse.TabIndex = 21;
            btnNoUse.UseMnemonic = false;
            btnNoUse.UseVisualStyleBackColor = true;
            btnNoUse.Click += btnNoUse_Click;
            // 
            // txtRobin
            // 
            txtRobin.BackColor = SystemColors.InfoText;
            txtRobin.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            txtRobin.ForeColor = Color.WhiteSmoke;
            txtRobin.Location = new Point(27, 159);
            txtRobin.Multiline = true;
            txtRobin.Name = "txtRobin";
            txtRobin.Size = new Size(746, 66);
            txtRobin.TabIndex = 22;
            txtRobin.Text = "Robin's Ltd Etd";
            txtRobin.TextAlign = HorizontalAlignment.Center;
            // 
            // btnOff
            // 
            btnOff.Location = new Point(672, 361);
            btnOff.Name = "btnOff";
            btnOff.Size = new Size(82, 133);
            btnOff.TabIndex = 23;
            btnOff.Text = "Off";
            btnOff.UseVisualStyleBackColor = true;
            btnOff.Click += btnOff_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.CalculatorPic;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 530);
            Controls.Add(btnOff);
            Controls.Add(txtRobin);
            Controls.Add(btnNoUse);
            Controls.Add(btnPlay);
            Controls.Add(Clear);
            Controls.Add(btnEqual);
            Controls.Add(btnMinus);
            Controls.Add(btnModDevide);
            Controls.Add(btnAdd);
            Controls.Add(btnMultiply);
            Controls.Add(btnDevide);
            Controls.Add(BtnDot);
            Controls.Add(btnDoubleZero);
            Controls.Add(btnThree);
            Controls.Add(btnSix);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnFive);
            Controls.Add(btnTwo);
            Controls.Add(btnZero);
            Controls.Add(btnSeven);
            Controls.Add(btnFour);
            Controls.Add(btnOne);
            Controls.Add(txtShowResults);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtShowResults;
        private Button btnOne;
        private Button btnFour;
        private Button btnSeven;
        private Button btnZero;
        private Button btnTwo;
        private Button btnFive;
        private Button btnEight;
        private Button btnNine;
        private Button btnSix;
        private Button btnThree;
        private Button btnDoubleZero;
        private Button BtnDot;
        private Button btnDevide;
        private Button btnMultiply;
        private Button btnAdd;
        private Button btnModDevide;
        private Button btnMinus;
        private Button btnEqual;
        private Button Clear;
        private Button btnPlay;
        private Button btnNoUse;
        private TextBox txtRobin;
        private Button btnOff;
    }
}
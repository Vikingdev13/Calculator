
namespace Calculator
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
            this.results = new System.Windows.Forms.TextBox();
            this.buttonSQRT = new System.Windows.Forms.Button();
            this.buttonSquared = new System.Windows.Forms.Button();
            this.buttonPosNeg = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonPI = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.equationText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // results
            // 
            this.results.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(12, 24);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(354, 44);
            this.results.TabIndex = 0;
            this.results.Text = "0";
            this.results.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonSQRT
            // 
            this.buttonSQRT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSQRT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSQRT.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.buttonSQRT.FlatAppearance.BorderSize = 5;
            this.buttonSQRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSQRT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSQRT.Location = new System.Drawing.Point(12, 96);
            this.buttonSQRT.Name = "buttonSQRT";
            this.buttonSQRT.Size = new System.Drawing.Size(66, 60);
            this.buttonSQRT.TabIndex = 1;
            this.buttonSQRT.Text = "SQRT";
            this.buttonSQRT.UseVisualStyleBackColor = false;
            this.buttonSQRT.Click += new System.EventHandler(this.buttonSQRT_Click);
            // 
            // buttonSquared
            // 
            this.buttonSquared.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSquared.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSquared.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.buttonSquared.FlatAppearance.BorderSize = 5;
            this.buttonSquared.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSquared.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSquared.Location = new System.Drawing.Point(84, 96);
            this.buttonSquared.Name = "buttonSquared";
            this.buttonSquared.Size = new System.Drawing.Size(66, 60);
            this.buttonSquared.TabIndex = 2;
            this.buttonSquared.Text = "x^2";
            this.buttonSquared.UseVisualStyleBackColor = false;
            this.buttonSquared.Click += new System.EventHandler(this.buttonSquared_Click);
            // 
            // buttonPosNeg
            // 
            this.buttonPosNeg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPosNeg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPosNeg.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.buttonPosNeg.FlatAppearance.BorderSize = 5;
            this.buttonPosNeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosNeg.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPosNeg.Location = new System.Drawing.Point(12, 360);
            this.buttonPosNeg.Name = "buttonPosNeg";
            this.buttonPosNeg.Size = new System.Drawing.Size(66, 60);
            this.buttonPosNeg.TabIndex = 3;
            this.buttonPosNeg.Text = "+/-";
            this.buttonPosNeg.UseVisualStyleBackColor = false;
            this.buttonPosNeg.Click += new System.EventHandler(this.buttonPosNeg_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDivide.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonDivide.FlatAppearance.BorderSize = 5;
            this.buttonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivide.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.Location = new System.Drawing.Point(228, 159);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(66, 60);
            this.buttonDivide.TabIndex = 4;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.operations);
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClearEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearEntry.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonClearEntry.FlatAppearance.BorderSize = 5;
            this.buttonClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearEntry.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearEntry.Location = new System.Drawing.Point(300, 160);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(66, 60);
            this.buttonClearEntry.TabIndex = 5;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = false;
            this.buttonClearEntry.Click += new System.EventHandler(this.buttonClearEntry_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSeven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSeven.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSeven.FlatAppearance.BorderSize = 5;
            this.buttonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeven.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeven.Location = new System.Drawing.Point(12, 160);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(66, 60);
            this.buttonSeven.TabIndex = 6;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonEight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonEight.FlatAppearance.BorderSize = 5;
            this.buttonEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEight.Location = new System.Drawing.Point(84, 162);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(66, 60);
            this.buttonEight.TabIndex = 7;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonNine.FlatAppearance.BorderSize = 5;
            this.buttonNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNine.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNine.Location = new System.Drawing.Point(156, 162);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(66, 60);
            this.buttonNine.TabIndex = 8;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonMultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMultiply.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonMultiply.FlatAppearance.BorderSize = 5;
            this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiply.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.Location = new System.Drawing.Point(228, 228);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(66, 60);
            this.buttonMultiply.TabIndex = 9;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.operations);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonClear.FlatAppearance.BorderSize = 5;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(300, 226);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(66, 60);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonFour.FlatAppearance.BorderSize = 5;
            this.buttonFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFour.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFour.Location = new System.Drawing.Point(12, 226);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(66, 60);
            this.buttonFour.TabIndex = 11;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonFive.FlatAppearance.BorderSize = 5;
            this.buttonFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFive.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFive.Location = new System.Drawing.Point(84, 228);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(66, 60);
            this.buttonFive.TabIndex = 12;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSix.FlatAppearance.BorderSize = 5;
            this.buttonSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSix.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSix.Location = new System.Drawing.Point(156, 228);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(66, 60);
            this.buttonSix.TabIndex = 13;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSubtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubtract.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonSubtract.FlatAppearance.BorderSize = 5;
            this.buttonSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubtract.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtract.Location = new System.Drawing.Point(228, 292);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(66, 60);
            this.buttonSubtract.TabIndex = 14;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = false;
            this.buttonSubtract.Click += new System.EventHandler(this.operations);
            // 
            // buttonPI
            // 
            this.buttonPI.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPI.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.buttonPI.FlatAppearance.BorderSize = 5;
            this.buttonPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPI.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPI.Location = new System.Drawing.Point(156, 96);
            this.buttonPI.Name = "buttonPI";
            this.buttonPI.Size = new System.Drawing.Size(66, 60);
            this.buttonPI.TabIndex = 15;
            this.buttonPI.Text = "PI";
            this.buttonPI.UseVisualStyleBackColor = false;
            this.buttonPI.Click += new System.EventHandler(this.buttonPI_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonEquals.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonEquals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEquals.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonEquals.FlatAppearance.BorderSize = 5;
            this.buttonEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquals.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquals.Location = new System.Drawing.Point(300, 292);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(67, 128);
            this.buttonEquals.TabIndex = 16;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTwo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonTwo.FlatAppearance.BorderSize = 5;
            this.buttonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTwo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTwo.Location = new System.Drawing.Point(84, 294);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(66, 60);
            this.buttonTwo.TabIndex = 17;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonAdd.FlatAppearance.BorderSize = 5;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(228, 359);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(66, 60);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.operations);
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonZero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonZero.FlatAppearance.BorderSize = 5;
            this.buttonZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZero.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZero.Location = new System.Drawing.Point(84, 360);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(66, 60);
            this.buttonZero.TabIndex = 19;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonThree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonThree.FlatAppearance.BorderSize = 5;
            this.buttonThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThree.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThree.Location = new System.Drawing.Point(156, 294);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(66, 60);
            this.buttonThree.TabIndex = 20;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDot.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonDot.FlatAppearance.BorderSize = 5;
            this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(156, 360);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(66, 60);
            this.buttonDot.TabIndex = 21;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOne.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonOne.FlatAppearance.BorderSize = 5;
            this.buttonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOne.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOne.Location = new System.Drawing.Point(12, 294);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(66, 60);
            this.buttonOne.TabIndex = 23;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.button_Click);
            // 
            // equationText
            // 
            this.equationText.BackColor = System.Drawing.Color.White;
            this.equationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equationText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.equationText.Location = new System.Drawing.Point(228, 96);
            this.equationText.Name = "equationText";
            this.equationText.Size = new System.Drawing.Size(139, 60);
            this.equationText.TabIndex = 24;
            this.equationText.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Calculator
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(386, 434);
            this.Controls.Add(this.equationText);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonPI);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonPosNeg);
            this.Controls.Add(this.buttonSquared);
            this.Controls.Add(this.buttonSQRT);
            this.Controls.Add(this.results);
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.Button buttonSQRT;
        private System.Windows.Forms.Button buttonSquared;
        private System.Windows.Forms.Button buttonPosNeg;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonPI;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Label equationText;
    }
}


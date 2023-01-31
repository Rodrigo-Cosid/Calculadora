namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up resources that are being used
        /// </summary>
        /// <param name="disposing"true if disposing of managed resources is required; otherwise false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Method required for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bntSeven = new System.Windows.Forms.Button();
            this.bntEight = new System.Windows.Forms.Button();
            this.bntNine = new System.Windows.Forms.Button();
            this.bntSum = new System.Windows.Forms.Button();
            this.bntSubtraction = new System.Windows.Forms.Button();
            this.bntSix = new System.Windows.Forms.Button();
            this.bntFive = new System.Windows.Forms.Button();
            this.bntFour = new System.Windows.Forms.Button();
            this.buttonApagarTudo = new System.Windows.Forms.Button();
            this.buttonApagarCal = new System.Windows.Forms.Button();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.bntMultiplication = new System.Windows.Forms.Button();
            this.bntThree = new System.Windows.Forms.Button();
            this.bntTwo = new System.Windows.Forms.Button();
            this.bntOne = new System.Windows.Forms.Button();
            this.bntDivision = new System.Windows.Forms.Button();
            this.buttonPonto = new System.Windows.Forms.Button();
            this.bntZero = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntSeven
            // 
            this.bntSeven.Location = new System.Drawing.Point(3, 80);
            this.bntSeven.Name = "bntSeven";
            this.bntSeven.Size = new System.Drawing.Size(45, 49);
            this.bntSeven.TabIndex = 0;
            this.bntSeven.Text = "7";
            this.bntSeven.UseVisualStyleBackColor = true;
            this.bntSeven.Click += new System.EventHandler(this.buttonSeven);
            // 
            // bntEight
            // 
            this.bntEight.Location = new System.Drawing.Point(54, 80);
            this.bntEight.Name = "bntEight";
            this.bntEight.Size = new System.Drawing.Size(45, 49);
            this.bntEight.TabIndex = 2;
            this.bntEight.Text = "8";
            this.bntEight.UseVisualStyleBackColor = true;
            this.bntEight.Click += new System.EventHandler(this.buttonEight);
            // 
            // bntNine
            // 
            this.bntNine.Location = new System.Drawing.Point(105, 80);
            this.bntNine.Name = "bntNine";
            this.bntNine.Size = new System.Drawing.Size(45, 49);
            this.bntNine.TabIndex = 3;
            this.bntNine.Text = "9";
            this.bntNine.UseVisualStyleBackColor = true;
            this.bntNine.Click += new System.EventHandler(this.buttonNine);
            // 
            // bntSum
            // 
            this.bntSum.Location = new System.Drawing.Point(156, 80);
            this.bntSum.Name = "bntSum";
            this.bntSum.Size = new System.Drawing.Size(45, 49);
            this.bntSum.TabIndex = 4;
            this.bntSum.Text = "+";
            this.bntSum.UseVisualStyleBackColor = true;
            this.bntSum.Click += new System.EventHandler(this.buttonSum);
            // 
            // bntSubtraction
            // 
            this.bntSubtraction.Location = new System.Drawing.Point(156, 135);
            this.bntSubtraction.Name = "bntSubtraction";
            this.bntSubtraction.Size = new System.Drawing.Size(45, 49);
            this.bntSubtraction.TabIndex = 8;
            this.bntSubtraction.Text = "-";
            this.bntSubtraction.UseVisualStyleBackColor = true;
            this.bntSubtraction.Click += new System.EventHandler(this.buttonSubtraction);
            // 
            // bntSix
            // 
            this.bntSix.Location = new System.Drawing.Point(105, 135);
            this.bntSix.Name = "bntSix";
            this.bntSix.Size = new System.Drawing.Size(45, 49);
            this.bntSix.TabIndex = 7;
            this.bntSix.Text = "6";
            this.bntSix.UseVisualStyleBackColor = true;
            this.bntSix.Click += new System.EventHandler(this.buttonSix);
            // 
            // bntFive
            // 
            this.bntFive.Location = new System.Drawing.Point(54, 135);
            this.bntFive.Name = "bntFive";
            this.bntFive.Size = new System.Drawing.Size(45, 49);
            this.bntFive.TabIndex = 6;
            this.bntFive.Text = "5";
            this.bntFive.UseVisualStyleBackColor = true;
            this.bntFive.Click += new System.EventHandler(this.buttonFive);
            // 
            // bntFour
            // 
            this.bntFour.Location = new System.Drawing.Point(3, 135);
            this.bntFour.Name = "bntFour";
            this.bntFour.Size = new System.Drawing.Size(45, 49);
            this.bntFour.TabIndex = 5;
            this.bntFour.Text = "4";
            this.bntFour.UseVisualStyleBackColor = true;
            this.bntFour.Click += new System.EventHandler(this.buttonFour);
            // 
            // buttonApagarTudo
            // 
            this.buttonApagarTudo.AccessibleName = "bntDeleteAll";
            this.buttonApagarTudo.Location = new System.Drawing.Point(207, 80);
            this.buttonApagarTudo.Name = "buttonApagarTudo";
            this.buttonApagarTudo.Size = new System.Drawing.Size(45, 49);
            this.buttonApagarTudo.TabIndex = 9;
            this.buttonApagarTudo.Text = "CE";
            this.buttonApagarTudo.UseVisualStyleBackColor = true;
            this.buttonApagarTudo.Click += new System.EventHandler(this.buttonDeleteAll);
            // 
            // buttonApagarCal
            // 
            this.buttonApagarCal.AccessibleName = "bntDeleteTxtResult";
            this.buttonApagarCal.Location = new System.Drawing.Point(207, 135);
            this.buttonApagarCal.Name = "buttonApagarCal";
            this.buttonApagarCal.Size = new System.Drawing.Size(45, 49);
            this.buttonApagarCal.TabIndex = 10;
            this.buttonApagarCal.Text = "C";
            this.buttonApagarCal.UseVisualStyleBackColor = true;
            this.buttonApagarCal.Click += new System.EventHandler(this.buttonDeleteTxtResult);
            // 
            // buttonIgual
            // 
            this.buttonIgual.Location = new System.Drawing.Point(207, 190);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(45, 98);
            this.buttonIgual.TabIndex = 15;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = true;
            this.buttonIgual.Click += new System.EventHandler(this.buttonEqual);
            // 
            // bntMultiplication
            // 
            this.bntMultiplication.Location = new System.Drawing.Point(156, 190);
            this.bntMultiplication.Name = "bntMultiplication";
            this.bntMultiplication.Size = new System.Drawing.Size(45, 49);
            this.bntMultiplication.TabIndex = 14;
            this.bntMultiplication.Text = "x";
            this.bntMultiplication.UseVisualStyleBackColor = true;
            this.bntMultiplication.Click += new System.EventHandler(this.buttonMultiplication);
            // 
            // bntThree
            // 
            this.bntThree.Location = new System.Drawing.Point(105, 190);
            this.bntThree.Name = "bntThree";
            this.bntThree.Size = new System.Drawing.Size(45, 49);
            this.bntThree.TabIndex = 13;
            this.bntThree.Text = "3";
            this.bntThree.UseVisualStyleBackColor = true;
            this.bntThree.Click += new System.EventHandler(this.buttonThree);
            // 
            // bntTwo
            // 
            this.bntTwo.Location = new System.Drawing.Point(54, 190);
            this.bntTwo.Name = "bntTwo";
            this.bntTwo.Size = new System.Drawing.Size(45, 49);
            this.bntTwo.TabIndex = 12;
            this.bntTwo.Text = "2";
            this.bntTwo.UseVisualStyleBackColor = true;
            this.bntTwo.Click += new System.EventHandler(this.buttonTwo);
            // 
            // bntOne
            // 
            this.bntOne.Location = new System.Drawing.Point(3, 190);
            this.bntOne.Name = "bntOne";
            this.bntOne.Size = new System.Drawing.Size(45, 49);
            this.bntOne.TabIndex = 11;
            this.bntOne.Text = "1";
            this.bntOne.UseVisualStyleBackColor = true;
            this.bntOne.Click += new System.EventHandler(this.buttonOne);
            // 
            // bntDivision
            // 
            this.bntDivision.Location = new System.Drawing.Point(156, 245);
            this.bntDivision.Name = "bntDivision";
            this.bntDivision.Size = new System.Drawing.Size(45, 49);
            this.bntDivision.TabIndex = 19;
            this.bntDivision.Text = "/";
            this.bntDivision.UseVisualStyleBackColor = true;
            this.bntDivision.Click += new System.EventHandler(this.buttonDivision);
            // 
            // buttonPonto
            // 
            this.buttonPonto.Location = new System.Drawing.Point(105, 245);
            this.buttonPonto.Name = "buttonPonto";
            this.buttonPonto.Size = new System.Drawing.Size(45, 49);
            this.buttonPonto.TabIndex = 18;
            this.buttonPonto.Text = ".";
            this.buttonPonto.UseVisualStyleBackColor = true;
            this.buttonPonto.Click += new System.EventHandler(this.buttonComma);
            // 
            // bntZero
            // 
            this.bntZero.Location = new System.Drawing.Point(3, 245);
            this.bntZero.Name = "bntZero";
            this.bntZero.Size = new System.Drawing.Size(96, 49);
            this.bntZero.TabIndex = 16;
            this.bntZero.Text = "0";
            this.bntZero.UseVisualStyleBackColor = true;
            this.bntZero.Click += new System.EventHandler(this.buttonZero);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(10, 12);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(242, 20);
            this.txtResult.TabIndex = 20;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.TextChanged += new System.EventHandler(this.textResult_TextChanged);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.Color.Transparent;
            this.lblOperacao.Location = new System.Drawing.Point(13, 15);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 13);
            this.lblOperacao.TabIndex = 21;
            this.lblOperacao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 303);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.bntDivision);
            this.Controls.Add(this.buttonPonto);
            this.Controls.Add(this.bntZero);
            this.Controls.Add(this.buttonIgual);
            this.Controls.Add(this.bntMultiplication);
            this.Controls.Add(this.bntThree);
            this.Controls.Add(this.bntTwo);
            this.Controls.Add(this.bntOne);
            this.Controls.Add(this.buttonApagarCal);
            this.Controls.Add(this.buttonApagarTudo);
            this.Controls.Add(this.bntSubtraction);
            this.Controls.Add(this.bntSix);
            this.Controls.Add(this.bntFive);
            this.Controls.Add(this.bntFour);
            this.Controls.Add(this.bntSum);
            this.Controls.Add(this.bntNine);
            this.Controls.Add(this.bntEight);
            this.Controls.Add(this.bntSeven);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntSeven;
        private System.Windows.Forms.Button bntEight;
        private System.Windows.Forms.Button bntNine;
        private System.Windows.Forms.Button bntSum;
        private System.Windows.Forms.Button bntSubtraction;
        private System.Windows.Forms.Button bntSix;
        private System.Windows.Forms.Button bntFive;
        private System.Windows.Forms.Button bntFour;
        private System.Windows.Forms.Button buttonApagarTudo;
        private System.Windows.Forms.Button buttonApagarCal;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.Button bntMultiplication;
        private System.Windows.Forms.Button bntThree;
        private System.Windows.Forms.Button bntTwo;
        private System.Windows.Forms.Button bntOne;
        private System.Windows.Forms.Button bntDivision;
        private System.Windows.Forms.Button buttonPonto;
        private System.Windows.Forms.Button bntZero;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblOperacao;
    }
}


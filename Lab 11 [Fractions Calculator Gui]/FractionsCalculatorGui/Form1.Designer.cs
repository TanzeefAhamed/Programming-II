namespace FractionsCalculatorGui
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
            this.txtFraction1 = new System.Windows.Forms.TextBox();
            this.txtFraction2 = new System.Windows.Forms.TextBox();
            this.rbtnDivide = new System.Windows.Forms.RadioButton();
            this.rbtnMultiply = new System.Windows.Forms.RadioButton();
            this.rbtnSubtract = new System.Windows.Forms.RadioButton();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFraction1
            // 
            this.txtFraction1.Location = new System.Drawing.Point(182, 158);
            this.txtFraction1.Name = "txtFraction1";
            this.txtFraction1.Size = new System.Drawing.Size(100, 20);
            this.txtFraction1.TabIndex = 0;
            // 
            // txtFraction2
            // 
            this.txtFraction2.Location = new System.Drawing.Point(182, 184);
            this.txtFraction2.Name = "txtFraction2";
            this.txtFraction2.Size = new System.Drawing.Size(100, 20);
            this.txtFraction2.TabIndex = 1;
            // 
            // rbtnDivide
            // 
            this.rbtnDivide.AutoSize = true;
            this.rbtnDivide.Location = new System.Drawing.Point(325, 207);
            this.rbtnDivide.Name = "rbtnDivide";
            this.rbtnDivide.Size = new System.Drawing.Size(62, 17);
            this.rbtnDivide.TabIndex = 2;
            this.rbtnDivide.TabStop = true;
            this.rbtnDivide.Text = "Division";
            this.rbtnDivide.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiply
            // 
            this.rbtnMultiply.AutoSize = true;
            this.rbtnMultiply.Location = new System.Drawing.Point(325, 184);
            this.rbtnMultiply.Name = "rbtnMultiply";
            this.rbtnMultiply.Size = new System.Drawing.Size(86, 17);
            this.rbtnMultiply.TabIndex = 3;
            this.rbtnMultiply.TabStop = true;
            this.rbtnMultiply.Text = "Multiplication";
            this.rbtnMultiply.UseVisualStyleBackColor = true;
            // 
            // rbtnSubtract
            // 
            this.rbtnSubtract.AutoSize = true;
            this.rbtnSubtract.Location = new System.Drawing.Point(325, 161);
            this.rbtnSubtract.Name = "rbtnSubtract";
            this.rbtnSubtract.Size = new System.Drawing.Size(79, 17);
            this.rbtnSubtract.TabIndex = 4;
            this.rbtnSubtract.TabStop = true;
            this.rbtnSubtract.Text = "Subtraction";
            this.rbtnSubtract.UseVisualStyleBackColor = true;
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Location = new System.Drawing.Point(325, 138);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(63, 17);
            this.rbtnAdd.TabIndex = 5;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "Addition";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(191, 223);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(182, 270);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 360);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rbtnAdd);
            this.Controls.Add(this.rbtnSubtract);
            this.Controls.Add(this.rbtnMultiply);
            this.Controls.Add(this.rbtnDivide);
            this.Controls.Add(this.txtFraction2);
            this.Controls.Add(this.txtFraction1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFraction1;
        private System.Windows.Forms.TextBox txtFraction2;
        private System.Windows.Forms.RadioButton rbtnDivide;
        private System.Windows.Forms.RadioButton rbtnMultiply;
        private System.Windows.Forms.RadioButton rbtnSubtract;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResult;
    }
}


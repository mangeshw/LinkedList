namespace LinkedList
{
    partial class Stack
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
            this.lblArray1 = new System.Windows.Forms.Label();
            this.txtArray1 = new System.Windows.Forms.TextBox();
            this.txtArray2 = new System.Windows.Forms.TextBox();
            this.lblArray2 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInfixToPostfix = new System.Windows.Forms.Button();
            this.btnEvalPostfix = new System.Windows.Forms.Button();
            this.btnNextGreater = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArray1
            // 
            this.lblArray1.AutoSize = true;
            this.lblArray1.Location = new System.Drawing.Point(7, 10);
            this.lblArray1.Name = "lblArray1";
            this.lblArray1.Size = new System.Drawing.Size(71, 13);
            this.lblArray1.TabIndex = 0;
            this.lblArray1.Text = "Enter Array 1:";
            // 
            // txtArray1
            // 
            this.txtArray1.Location = new System.Drawing.Point(90, 10);
            this.txtArray1.Name = "txtArray1";
            this.txtArray1.Size = new System.Drawing.Size(290, 20);
            this.txtArray1.TabIndex = 1;
            // 
            // txtArray2
            // 
            this.txtArray2.Location = new System.Drawing.Point(90, 36);
            this.txtArray2.Name = "txtArray2";
            this.txtArray2.Size = new System.Drawing.Size(290, 20);
            this.txtArray2.TabIndex = 2;
            // 
            // lblArray2
            // 
            this.lblArray2.AutoSize = true;
            this.lblArray2.Location = new System.Drawing.Point(7, 36);
            this.lblArray2.Name = "lblArray2";
            this.lblArray2.Size = new System.Drawing.Size(71, 13);
            this.lblArray2.TabIndex = 2;
            this.lblArray2.Text = "Enter Array 2:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(90, 62);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(290, 20);
            this.txtLength.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Array 1 Length:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(90, 87);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(290, 20);
            this.txtResult.TabIndex = 20;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(7, 87);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(10, 113);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInfixToPostfix
            // 
            this.btnInfixToPostfix.Location = new System.Drawing.Point(90, 113);
            this.btnInfixToPostfix.Name = "btnInfixToPostfix";
            this.btnInfixToPostfix.Size = new System.Drawing.Size(75, 23);
            this.btnInfixToPostfix.TabIndex = 5;
            this.btnInfixToPostfix.Text = "Infix-Postfix";
            this.btnInfixToPostfix.UseVisualStyleBackColor = true;
            this.btnInfixToPostfix.Click += new System.EventHandler(this.btnInfixToPostfix_Click);
            // 
            // btnEvalPostfix
            // 
            this.btnEvalPostfix.Location = new System.Drawing.Point(171, 113);
            this.btnEvalPostfix.Name = "btnEvalPostfix";
            this.btnEvalPostfix.Size = new System.Drawing.Size(75, 23);
            this.btnEvalPostfix.TabIndex = 6;
            this.btnEvalPostfix.Text = "Eval Postfix";
            this.btnEvalPostfix.UseVisualStyleBackColor = true;
            this.btnEvalPostfix.Click += new System.EventHandler(this.btnEvalPostfix_Click);
            // 
            // btnNextGreater
            // 
            this.btnNextGreater.Location = new System.Drawing.Point(252, 113);
            this.btnNextGreater.Name = "btnNextGreater";
            this.btnNextGreater.Size = new System.Drawing.Size(75, 23);
            this.btnNextGreater.TabIndex = 7;
            this.btnNextGreater.Text = "Next Greater";
            this.btnNextGreater.UseVisualStyleBackColor = true;
            this.btnNextGreater.Click += new System.EventHandler(this.btnNextGreater_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(10, 145);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 8;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // Stack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 174);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnNextGreater);
            this.Controls.Add(this.btnEvalPostfix);
            this.Controls.Add(this.btnInfixToPostfix);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArray2);
            this.Controls.Add(this.lblArray2);
            this.Controls.Add(this.txtArray1);
            this.Controls.Add(this.lblArray1);
            this.Name = "Stack";
            this.Text = "Stack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArray1;
        private System.Windows.Forms.TextBox txtArray1;
        private System.Windows.Forms.TextBox txtArray2;
        private System.Windows.Forms.Label lblArray2;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInfixToPostfix;
        private System.Windows.Forms.Button btnEvalPostfix;
        private System.Windows.Forms.Button btnNextGreater;
        private System.Windows.Forms.Button btnReverse;
    }
}
namespace LinkedList
{
    partial class CustomListForm
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
            this.lblEnterList1 = new System.Windows.Forms.Label();
            this.txtList1 = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblEnterValue = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.lblEnterIndex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterList1
            // 
            this.lblEnterList1.AutoSize = true;
            this.lblEnterList1.Location = new System.Drawing.Point(12, 7);
            this.lblEnterList1.Name = "lblEnterList1";
            this.lblEnterList1.Size = new System.Drawing.Size(63, 13);
            this.lblEnterList1.TabIndex = 0;
            this.lblEnterList1.Text = "Enter List 1:";
            // 
            // txtList1
            // 
            this.txtList1.Location = new System.Drawing.Point(80, 7);
            this.txtList1.Name = "txtList1";
            this.txtList1.Size = new System.Drawing.Size(329, 20);
            this.txtList1.TabIndex = 1;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(80, 34);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(329, 20);
            this.txtValue.TabIndex = 2;
            // 
            // lblEnterValue
            // 
            this.lblEnterValue.AutoSize = true;
            this.lblEnterValue.Location = new System.Drawing.Point(12, 34);
            this.lblEnterValue.Name = "lblEnterValue";
            this.lblEnterValue.Size = new System.Drawing.Size(65, 13);
            this.lblEnterValue.TabIndex = 2;
            this.lblEnterValue.Text = "Enter Value:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(80, 88);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(329, 20);
            this.txtResult.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 88);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(89, 115);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(171, 115);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(80, 61);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(329, 20);
            this.txtIndex.TabIndex = 3;
            // 
            // lblEnterIndex
            // 
            this.lblEnterIndex.AutoSize = true;
            this.lblEnterIndex.Location = new System.Drawing.Point(12, 61);
            this.lblEnterIndex.Name = "lblEnterIndex";
            this.lblEnterIndex.Size = new System.Drawing.Size(64, 13);
            this.lblEnterIndex.TabIndex = 8;
            this.lblEnterIndex.Text = "Enter Index:";
            // 
            // CustomListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 146);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.lblEnterIndex);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblEnterValue);
            this.Controls.Add(this.txtList1);
            this.Controls.Add(this.lblEnterList1);
            this.Name = "CustomListForm";
            this.Text = "CustomListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterList1;
        private System.Windows.Forms.TextBox txtList1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblEnterValue;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label lblEnterIndex;
    }
}
namespace LinkedList
{
    partial class WeightedGraphForm
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
            this.lblConnectVertices = new System.Windows.Forms.Label();
            this.txtConnectVertices = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNegativeCycle = new System.Windows.Forms.Button();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOperation = new System.Windows.Forms.TextBox();
            this.btnLongestPath = new System.Windows.Forms.Button();
            this.btnKruskalsMST = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConnectVertices
            // 
            this.lblConnectVertices.AutoSize = true;
            this.lblConnectVertices.Location = new System.Drawing.Point(4, 12);
            this.lblConnectVertices.Name = "lblConnectVertices";
            this.lblConnectVertices.Size = new System.Drawing.Size(88, 13);
            this.lblConnectVertices.TabIndex = 0;
            this.lblConnectVertices.Text = "Connect Vertices";
            // 
            // txtConnectVertices
            // 
            this.txtConnectVertices.Location = new System.Drawing.Point(109, 4);
            this.txtConnectVertices.Name = "txtConnectVertices";
            this.txtConnectVertices.Size = new System.Drawing.Size(225, 20);
            this.txtConnectVertices.TabIndex = 1;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(4, 39);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(109, 32);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(225, 20);
            this.txtWeight.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(4, 66);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(109, 59);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(225, 20);
            this.txtResult.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 114);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNegativeCycle
            // 
            this.btnNegativeCycle.Location = new System.Drawing.Point(164, 114);
            this.btnNegativeCycle.Name = "btnNegativeCycle";
            this.btnNegativeCycle.Size = new System.Drawing.Size(88, 23);
            this.btnNegativeCycle.TabIndex = 7;
            this.btnNegativeCycle.Text = "Negative Cycle";
            this.btnNegativeCycle.UseVisualStyleBackColor = true;
            this.btnNegativeCycle.Click += new System.EventHandler(this.btnNegativeCycle_Click);
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.Location = new System.Drawing.Point(85, 114);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(75, 23);
            this.btnAddEdge.TabIndex = 8;
            this.btnAddEdge.Text = "Add Edge";
            this.btnAddEdge.UseVisualStyleBackColor = true;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Operation";
            // 
            // txtOperation
            // 
            this.txtOperation.Location = new System.Drawing.Point(109, 87);
            this.txtOperation.Name = "txtOperation";
            this.txtOperation.ReadOnly = true;
            this.txtOperation.Size = new System.Drawing.Size(225, 20);
            this.txtOperation.TabIndex = 10;
            // 
            // btnLongestPath
            // 
            this.btnLongestPath.Location = new System.Drawing.Point(256, 114);
            this.btnLongestPath.Name = "btnLongestPath";
            this.btnLongestPath.Size = new System.Drawing.Size(78, 23);
            this.btnLongestPath.TabIndex = 11;
            this.btnLongestPath.Text = "Longest Path";
            this.btnLongestPath.UseVisualStyleBackColor = true;
            this.btnLongestPath.Click += new System.EventHandler(this.btnLongestPath_Click);
            // 
            // btnKruskalsMST
            // 
            this.btnKruskalsMST.Location = new System.Drawing.Point(6, 144);
            this.btnKruskalsMST.Name = "btnKruskalsMST";
            this.btnKruskalsMST.Size = new System.Drawing.Size(86, 23);
            this.btnKruskalsMST.TabIndex = 12;
            this.btnKruskalsMST.Text = "Kruskal\'s MST";
            this.btnKruskalsMST.UseVisualStyleBackColor = true;
            this.btnKruskalsMST.Click += new System.EventHandler(this.btnKruskalsMST_Click);
            // 
            // WeightedGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 171);
            this.Controls.Add(this.btnKruskalsMST);
            this.Controls.Add(this.btnLongestPath);
            this.Controls.Add(this.txtOperation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddEdge);
            this.Controls.Add(this.btnNegativeCycle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtConnectVertices);
            this.Controls.Add(this.lblConnectVertices);
            this.Name = "WeightedGraphForm";
            this.Text = "WeightedGraphForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnectVertices;
        private System.Windows.Forms.TextBox txtConnectVertices;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNegativeCycle;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOperation;
        private System.Windows.Forms.Button btnLongestPath;
        private System.Windows.Forms.Button btnKruskalsMST;
    }
}
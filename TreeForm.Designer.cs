namespace LinkedList
{
    partial class TreeForm
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
            this.btnLevelOrderTraversal = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnButton = new System.Windows.Forms.Button();
            this.btnInOrder = new System.Windows.Forms.Button();
            this.btnPostOrder = new System.Windows.Forms.Button();
            this.btnPreOrder = new System.Windows.Forms.Button();
            this.btnMaxDepth = new System.Windows.Forms.Button();
            this.btnMirrorTree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLevelOrderTraversal
            // 
            this.btnLevelOrderTraversal.Location = new System.Drawing.Point(9, 8);
            this.btnLevelOrderTraversal.Name = "btnLevelOrderTraversal";
            this.btnLevelOrderTraversal.Size = new System.Drawing.Size(120, 23);
            this.btnLevelOrderTraversal.TabIndex = 0;
            this.btnLevelOrderTraversal.Text = "Level Order Traversal";
            this.btnLevelOrderTraversal.UseVisualStyleBackColor = true;
            this.btnLevelOrderTraversal.Click += new System.EventHandler(this.btnLevelOrderTraversal_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(4, 111);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(47, 110);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(300, 20);
            this.txtResult.TabIndex = 99;
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(353, 109);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(75, 23);
            this.btnButton.TabIndex = 100;
            this.btnButton.Text = "Clear";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnInOrder
            // 
            this.btnInOrder.Location = new System.Drawing.Point(135, 8);
            this.btnInOrder.Name = "btnInOrder";
            this.btnInOrder.Size = new System.Drawing.Size(75, 23);
            this.btnInOrder.TabIndex = 101;
            this.btnInOrder.Text = "In Order";
            this.btnInOrder.UseVisualStyleBackColor = true;
            this.btnInOrder.Click += new System.EventHandler(this.btnInOrder_Click);
            // 
            // btnPostOrder
            // 
            this.btnPostOrder.Location = new System.Drawing.Point(216, 8);
            this.btnPostOrder.Name = "btnPostOrder";
            this.btnPostOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPostOrder.TabIndex = 102;
            this.btnPostOrder.Text = "Post Order";
            this.btnPostOrder.UseVisualStyleBackColor = true;
            this.btnPostOrder.Click += new System.EventHandler(this.btnPostOrder_Click);
            // 
            // btnPreOrder
            // 
            this.btnPreOrder.Location = new System.Drawing.Point(297, 8);
            this.btnPreOrder.Name = "btnPreOrder";
            this.btnPreOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPreOrder.TabIndex = 103;
            this.btnPreOrder.Text = "Pre Order";
            this.btnPreOrder.UseVisualStyleBackColor = true;
            this.btnPreOrder.Click += new System.EventHandler(this.btnPreOrder_Click);
            // 
            // btnMaxDepth
            // 
            this.btnMaxDepth.Location = new System.Drawing.Point(12, 37);
            this.btnMaxDepth.Name = "btnMaxDepth";
            this.btnMaxDepth.Size = new System.Drawing.Size(75, 23);
            this.btnMaxDepth.TabIndex = 104;
            this.btnMaxDepth.Text = "Max Depth";
            this.btnMaxDepth.UseVisualStyleBackColor = true;
            this.btnMaxDepth.Click += new System.EventHandler(this.btnMaxDepth_Click);
            // 
            // btnMirrorTree
            // 
            this.btnMirrorTree.Location = new System.Drawing.Point(93, 37);
            this.btnMirrorTree.Name = "btnMirrorTree";
            this.btnMirrorTree.Size = new System.Drawing.Size(75, 23);
            this.btnMirrorTree.TabIndex = 105;
            this.btnMirrorTree.Text = "Mirror Tree";
            this.btnMirrorTree.UseVisualStyleBackColor = true;
            this.btnMirrorTree.Click += new System.EventHandler(this.btnMirrorTree_Click);
            // 
            // TreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 135);
            this.Controls.Add(this.btnMirrorTree);
            this.Controls.Add(this.btnMaxDepth);
            this.Controls.Add(this.btnPreOrder);
            this.Controls.Add(this.btnPostOrder);
            this.Controls.Add(this.btnInOrder);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnLevelOrderTraversal);
            this.Name = "TreeForm";
            this.Text = "TreeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLevelOrderTraversal;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnInOrder;
        private System.Windows.Forms.Button btnPostOrder;
        private System.Windows.Forms.Button btnPreOrder;
        private System.Windows.Forms.Button btnMaxDepth;
        private System.Windows.Forms.Button btnMirrorTree;
    }
}
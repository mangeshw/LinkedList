namespace LinkedList
{
    partial class MainForm
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
            this.btnLinkedList = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnArray = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.btnCustomList = new System.Windows.Forms.Button();
            this.btnTree = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnWeightedGraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLinkedList
            // 
            this.btnLinkedList.Location = new System.Drawing.Point(8, 10);
            this.btnLinkedList.Name = "btnLinkedList";
            this.btnLinkedList.Size = new System.Drawing.Size(75, 23);
            this.btnLinkedList.TabIndex = 0;
            this.btnLinkedList.Text = "LinkedList";
            this.btnLinkedList.UseVisualStyleBackColor = true;
            this.btnLinkedList.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(89, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Searching and Sorting";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(216, 10);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(75, 23);
            this.btnArray.TabIndex = 2;
            this.btnArray.Text = "Array";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(298, 10);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(75, 23);
            this.btnStack.TabIndex = 3;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // btnCustomList
            // 
            this.btnCustomList.Location = new System.Drawing.Point(8, 39);
            this.btnCustomList.Name = "btnCustomList";
            this.btnCustomList.Size = new System.Drawing.Size(75, 23);
            this.btnCustomList.TabIndex = 4;
            this.btnCustomList.Text = "Custom List";
            this.btnCustomList.UseVisualStyleBackColor = true;
            this.btnCustomList.Click += new System.EventHandler(this.btnCustomList_Click);
            // 
            // btnTree
            // 
            this.btnTree.Location = new System.Drawing.Point(89, 39);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(75, 23);
            this.btnTree.TabIndex = 5;
            this.btnTree.Text = "Tree";
            this.btnTree.UseVisualStyleBackColor = true;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(171, 39);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(75, 23);
            this.btnGraph.TabIndex = 6;
            this.btnGraph.Text = "Graph";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnWeightedGraph
            // 
            this.btnWeightedGraph.Location = new System.Drawing.Point(252, 39);
            this.btnWeightedGraph.Name = "btnWeightedGraph";
            this.btnWeightedGraph.Size = new System.Drawing.Size(96, 23);
            this.btnWeightedGraph.TabIndex = 7;
            this.btnWeightedGraph.Text = "Weighted Graph";
            this.btnWeightedGraph.UseVisualStyleBackColor = true;
            this.btnWeightedGraph.Click += new System.EventHandler(this.btnWeightedGraph_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 127);
            this.Controls.Add(this.btnWeightedGraph);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnTree);
            this.Controls.Add(this.btnCustomList);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnArray);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLinkedList);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLinkedList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button btnCustomList;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnWeightedGraph;
    }
}
namespace LinkedList
{
    partial class GraphForm
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
            this.lblNumberOfNodes = new System.Windows.Forms.Label();
            this.txtNumberOfNodes = new System.Windows.Forms.TextBox();
            this.lblAddConnections = new System.Windows.Forms.Label();
            this.txtAddConnections = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBFS = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblOperationMessage = new System.Windows.Forms.Label();
            this.btnClearGraph = new System.Windows.Forms.Button();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.btnAllNodesConnected = new System.Windows.Forms.Button();
            this.btnRemoveEdge = new System.Windows.Forms.Button();
            this.btnDFS = new System.Windows.Forms.Button();
            this.btnAddDirectedEdge = new System.Windows.Forms.Button();
            this.btnMotherVertex = new System.Windows.Forms.Button();
            this.btnKnightProblem = new System.Windows.Forms.Button();
            this.btnMotherVertexOptimized = new System.Windows.Forms.Button();
            this.btnKCores = new System.Windows.Forms.Button();
            this.btnCycle = new System.Windows.Forms.Button();
            this.btnTopologicalSort = new System.Windows.Forms.Button();
            this.btnNumberOfPaths = new System.Windows.Forms.Button();
            this.btnWaterJug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumberOfNodes
            // 
            this.lblNumberOfNodes.AutoSize = true;
            this.lblNumberOfNodes.Location = new System.Drawing.Point(13, 13);
            this.lblNumberOfNodes.Name = "lblNumberOfNodes";
            this.lblNumberOfNodes.Size = new System.Drawing.Size(92, 13);
            this.lblNumberOfNodes.TabIndex = 0;
            this.lblNumberOfNodes.Text = "Number Of Nodes";
            // 
            // txtNumberOfNodes
            // 
            this.txtNumberOfNodes.Location = new System.Drawing.Point(124, 13);
            this.txtNumberOfNodes.Name = "txtNumberOfNodes";
            this.txtNumberOfNodes.Size = new System.Drawing.Size(248, 20);
            this.txtNumberOfNodes.TabIndex = 1;
            // 
            // lblAddConnections
            // 
            this.lblAddConnections.AutoSize = true;
            this.lblAddConnections.Location = new System.Drawing.Point(12, 48);
            this.lblAddConnections.Name = "lblAddConnections";
            this.lblAddConnections.Size = new System.Drawing.Size(88, 13);
            this.lblAddConnections.TabIndex = 2;
            this.lblAddConnections.Text = "Add Connections";
            // 
            // txtAddConnections
            // 
            this.txtAddConnections.Location = new System.Drawing.Point(124, 48);
            this.txtAddConnections.Name = "txtAddConnections";
            this.txtAddConnections.Size = new System.Drawing.Size(248, 20);
            this.txtAddConnections.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(15, 84);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(124, 84);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(248, 20);
            this.txtResult.TabIndex = 5;
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.Location = new System.Drawing.Point(165, 146);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(80, 23);
            this.btnAddEdge.TabIndex = 6;
            this.btnAddEdge.Text = "Add Edge";
            this.btnAddEdge.UseVisualStyleBackColor = true;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 146);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(3, 175);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print All Nodes";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnBFS
            // 
            this.btnBFS.Location = new System.Drawing.Point(98, 175);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(75, 23);
            this.btnBFS.TabIndex = 9;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = true;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(15, 115);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "Message";
            // 
            // lblOperationMessage
            // 
            this.lblOperationMessage.AutoSize = true;
            this.lblOperationMessage.Location = new System.Drawing.Point(124, 115);
            this.lblOperationMessage.Name = "lblOperationMessage";
            this.lblOperationMessage.Size = new System.Drawing.Size(0, 13);
            this.lblOperationMessage.TabIndex = 11;
            // 
            // btnClearGraph
            // 
            this.btnClearGraph.Location = new System.Drawing.Point(84, 146);
            this.btnClearGraph.Name = "btnClearGraph";
            this.btnClearGraph.Size = new System.Drawing.Size(75, 23);
            this.btnClearGraph.TabIndex = 12;
            this.btnClearGraph.Text = "Clear Graph";
            this.btnClearGraph.UseVisualStyleBackColor = true;
            this.btnClearGraph.Click += new System.EventHandler(this.btnClearGraph_Click);
            // 
            // btnAddNode
            // 
            this.btnAddNode.Location = new System.Drawing.Point(180, 175);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(75, 23);
            this.btnAddNode.TabIndex = 13;
            this.btnAddNode.Text = "Add Node";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // btnAllNodesConnected
            // 
            this.btnAllNodesConnected.Location = new System.Drawing.Point(251, 146);
            this.btnAllNodesConnected.Name = "btnAllNodesConnected";
            this.btnAllNodesConnected.Size = new System.Drawing.Size(121, 23);
            this.btnAllNodesConnected.TabIndex = 14;
            this.btnAllNodesConnected.Text = "All Nodes Conencted";
            this.btnAllNodesConnected.UseVisualStyleBackColor = true;
            this.btnAllNodesConnected.Click += new System.EventHandler(this.btnAllNodesConnected_Click);
            // 
            // btnRemoveEdge
            // 
            this.btnRemoveEdge.Location = new System.Drawing.Point(262, 175);
            this.btnRemoveEdge.Name = "btnRemoveEdge";
            this.btnRemoveEdge.Size = new System.Drawing.Size(110, 23);
            this.btnRemoveEdge.TabIndex = 15;
            this.btnRemoveEdge.Text = "Remove Edge";
            this.btnRemoveEdge.UseVisualStyleBackColor = true;
            this.btnRemoveEdge.Click += new System.EventHandler(this.btnRemoveEdge_Click);
            // 
            // btnDFS
            // 
            this.btnDFS.Location = new System.Drawing.Point(3, 202);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(75, 23);
            this.btnDFS.TabIndex = 16;
            this.btnDFS.Text = "DFS";
            this.btnDFS.UseVisualStyleBackColor = true;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // btnAddDirectedEdge
            // 
            this.btnAddDirectedEdge.Location = new System.Drawing.Point(84, 202);
            this.btnAddDirectedEdge.Name = "btnAddDirectedEdge";
            this.btnAddDirectedEdge.Size = new System.Drawing.Size(106, 23);
            this.btnAddDirectedEdge.TabIndex = 17;
            this.btnAddDirectedEdge.Text = "Add Directed Edge";
            this.btnAddDirectedEdge.UseVisualStyleBackColor = true;
            this.btnAddDirectedEdge.Click += new System.EventHandler(this.btnAddDirectedEdge_Click);
            // 
            // btnMotherVertex
            // 
            this.btnMotherVertex.Location = new System.Drawing.Point(196, 202);
            this.btnMotherVertex.Name = "btnMotherVertex";
            this.btnMotherVertex.Size = new System.Drawing.Size(91, 23);
            this.btnMotherVertex.TabIndex = 18;
            this.btnMotherVertex.Text = "Mother Vertex";
            this.btnMotherVertex.UseVisualStyleBackColor = true;
            this.btnMotherVertex.Click += new System.EventHandler(this.btnMotherVertex_Click);
            // 
            // btnKnightProblem
            // 
            this.btnKnightProblem.Location = new System.Drawing.Point(292, 202);
            this.btnKnightProblem.Name = "btnKnightProblem";
            this.btnKnightProblem.Size = new System.Drawing.Size(86, 23);
            this.btnKnightProblem.TabIndex = 19;
            this.btnKnightProblem.Text = "Knight Problem";
            this.btnKnightProblem.UseVisualStyleBackColor = true;
            this.btnKnightProblem.Click += new System.EventHandler(this.btnKnightProblem_Click);
            // 
            // btnMotherVertexOptimized
            // 
            this.btnMotherVertexOptimized.Location = new System.Drawing.Point(3, 230);
            this.btnMotherVertexOptimized.Name = "btnMotherVertexOptimized";
            this.btnMotherVertexOptimized.Size = new System.Drawing.Size(132, 23);
            this.btnMotherVertexOptimized.TabIndex = 20;
            this.btnMotherVertexOptimized.Text = "Mother Vertex Kosaraju";
            this.btnMotherVertexOptimized.UseVisualStyleBackColor = true;
            this.btnMotherVertexOptimized.Click += new System.EventHandler(this.btnMotherVertexOptimized_Click);
            // 
            // btnKCores
            // 
            this.btnKCores.Location = new System.Drawing.Point(140, 230);
            this.btnKCores.Name = "btnKCores";
            this.btnKCores.Size = new System.Drawing.Size(75, 23);
            this.btnKCores.TabIndex = 21;
            this.btnKCores.Text = "K Cores";
            this.btnKCores.UseVisualStyleBackColor = true;
            this.btnKCores.Click += new System.EventHandler(this.btnKCores_Click);
            // 
            // btnCycle
            // 
            this.btnCycle.Location = new System.Drawing.Point(220, 230);
            this.btnCycle.Name = "btnCycle";
            this.btnCycle.Size = new System.Drawing.Size(81, 23);
            this.btnCycle.TabIndex = 22;
            this.btnCycle.Text = "Detect Cycle";
            this.btnCycle.UseVisualStyleBackColor = true;
            this.btnCycle.Click += new System.EventHandler(this.btnCycle_Click);
            // 
            // btnTopologicalSort
            // 
            this.btnTopologicalSort.Location = new System.Drawing.Point(305, 229);
            this.btnTopologicalSort.Name = "btnTopologicalSort";
            this.btnTopologicalSort.Size = new System.Drawing.Size(75, 23);
            this.btnTopologicalSort.TabIndex = 23;
            this.btnTopologicalSort.Text = "Topological";
            this.btnTopologicalSort.UseVisualStyleBackColor = true;
            this.btnTopologicalSort.Click += new System.EventHandler(this.btnTopologicalSort_Click);
            // 
            // btnNumberOfPaths
            // 
            this.btnNumberOfPaths.Location = new System.Drawing.Point(3, 256);
            this.btnNumberOfPaths.Name = "btnNumberOfPaths";
            this.btnNumberOfPaths.Size = new System.Drawing.Size(75, 23);
            this.btnNumberOfPaths.TabIndex = 24;
            this.btnNumberOfPaths.Text = "# Paths";
            this.btnNumberOfPaths.UseVisualStyleBackColor = true;
            this.btnNumberOfPaths.Click += new System.EventHandler(this.btnNumberOfPaths_Click);
            // 
            // btnWaterJug
            // 
            this.btnWaterJug.Location = new System.Drawing.Point(84, 256);
            this.btnWaterJug.Name = "btnWaterJug";
            this.btnWaterJug.Size = new System.Drawing.Size(75, 23);
            this.btnWaterJug.TabIndex = 25;
            this.btnWaterJug.Text = "Water Jug";
            this.btnWaterJug.UseVisualStyleBackColor = true;
            this.btnWaterJug.Click += new System.EventHandler(this.btnWaterJug_Click);
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 284);
            this.Controls.Add(this.btnWaterJug);
            this.Controls.Add(this.btnNumberOfPaths);
            this.Controls.Add(this.btnTopologicalSort);
            this.Controls.Add(this.btnCycle);
            this.Controls.Add(this.btnKCores);
            this.Controls.Add(this.btnMotherVertexOptimized);
            this.Controls.Add(this.btnKnightProblem);
            this.Controls.Add(this.btnMotherVertex);
            this.Controls.Add(this.btnAddDirectedEdge);
            this.Controls.Add(this.btnDFS);
            this.Controls.Add(this.btnRemoveEdge);
            this.Controls.Add(this.btnAllNodesConnected);
            this.Controls.Add(this.btnAddNode);
            this.Controls.Add(this.btnClearGraph);
            this.Controls.Add(this.lblOperationMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnBFS);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddEdge);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtAddConnections);
            this.Controls.Add(this.lblAddConnections);
            this.Controls.Add(this.txtNumberOfNodes);
            this.Controls.Add(this.lblNumberOfNodes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(406, 268);
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfNodes;
        private System.Windows.Forms.TextBox txtNumberOfNodes;
        private System.Windows.Forms.Label lblAddConnections;
        private System.Windows.Forms.TextBox txtAddConnections;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblOperationMessage;
        private System.Windows.Forms.Button btnClearGraph;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.Button btnAllNodesConnected;
        private System.Windows.Forms.Button btnRemoveEdge;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.Button btnAddDirectedEdge;
        private System.Windows.Forms.Button btnMotherVertex;
        private System.Windows.Forms.Button btnKnightProblem;
        private System.Windows.Forms.Button btnMotherVertexOptimized;
        private System.Windows.Forms.Button btnKCores;
        private System.Windows.Forms.Button btnCycle;
        private System.Windows.Forms.Button btnTopologicalSort;
        private System.Windows.Forms.Button btnNumberOfPaths;
        private System.Windows.Forms.Button btnWaterJug;
    }
}
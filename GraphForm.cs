using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class GraphForm : Form
    {
        List<GraphNode> list = null;
        int bigO = 0;

        public GraphForm()
        {
            InitializeComponent();
            int[] f = new int[1];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddConnections.Text = String.Empty;
            txtNumberOfNodes.Text = String.Empty;
            txtResult.Text = String.Empty;
            lblOperationMessage.Text = String.Empty;
        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperationMessage.Text = String.Empty;
                int[] input = SearchForm.ConvertToIntArray(txtAddConnections.Text.Trim().Split(','));
                if (list == null)
                    list = new List<GraphNode>();
                GraphNode node1 = FindNode(input[0]);
                GraphNode node2 = FindNode(input[1]);
                if (node1 == null)
                {
                    node1 = new GraphNode();
                    node1.data = input[0];
                    list.Add(node1);
                }

                if (node2 == null)
                {
                    node2 = new GraphNode();
                    node2.data = input[1];
                    list.Add(node2);
                }
                node1.nodes.Add(node2);
                node2.nodes.Add(node1);
                lblOperationMessage.Text = "Edge Added";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in btnAddEdge_Click: " + ex.Message);
            }
            finally
            {

            }
        }

        GraphNode FindNode(int data)
        {
            int index = 0;
            foreach (GraphNode node in list)
            {
                if (node.data == data)
                    return node;
                index++;
            }
            return null;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperationMessage.Text = String.Empty;
                txtResult.Text = GetAllValues();
                lblOperationMessage.Text = "Printed All";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnPrint_Click error: " + ex.Message);
            }
        }

        public string GetAllValues()
        {
            StringBuilder builder = new StringBuilder();
            foreach (GraphNode node in list)
            {
                builder.Append(node.data);
                builder.Append(",");
            }
            builder.Remove(builder.Length - 1, 1);
            return builder.ToString();
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperationMessage.Text = String.Empty;
                ClearGraphTraversal();
                if (list.Count > 0)
                    txtResult.Text = BreadthFirstSearch(list[0]);
                else
                    txtResult.Text = "No node added for traversal.";
                lblOperationMessage.Text = "BFS done";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnBFS_Click error message: " + ex.Message);
            }
        }

        public string BreadthFirstSearch(GraphNode root)
        {
            if (root == null) return String.Empty;
            Queue<GraphNode> queue = new Queue<GraphNode>();

            StringBuilder builder = new StringBuilder();
            GraphNode node;
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                if (node.isVisited)
                    continue;
                node.isVisited = true;
                builder.Append(node.data);
                builder.Append(",");
                foreach (GraphNode connectedNode in node.nodes)
                    queue.Enqueue(connectedNode);
            }

            if (builder.Length > 0)
                builder.Remove(builder.Length - 1, 1);
            return Convert.ToString(builder);
        }

        private void btnClearGraph_Click(object sender, EventArgs e)
        {
            lblOperationMessage.Text = String.Empty;
            list = null;
            lblOperationMessage.Text = "Graph Cleared";
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperationMessage.Text = String.Empty;
                int data = Convert.ToInt32(txtNumberOfNodes.Text);
                AddNode(data);
                lblOperationMessage.Text = "Node Added";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnAddNode_Click error: " + ex.Message);
            }
        }

        public void AddNode(int data)
        {
            GraphNode node = new GraphNode();
            node.data = data;
            list.Add(node);
        }

        private void btnAllNodesConnected_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperationMessage.Text = String.Empty;
                ClearGraphTraversal();
                if(list.Count > 0)
                    txtResult.Text = AreAllNodesConnected(list[0]).ToString();
                lblOperationMessage.Text = "Are All Nodes Connected Done";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnAllNodesConnected_Click error: " + ex.Message);
            }
        }

        public bool AreAllNodesConnected(GraphNode root)
        {
            DFS(root, new StringBuilder());

            foreach (GraphNode node in list)
            {
                bigO++;
                if (!node.isVisited) return false;
            }
            return true;
        }

        public void ClearGraphTraversal()
        {
            foreach (GraphNode node in list)
                node.isVisited = false;
        }

        private void btnRemoveEdge_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperationMessage.Text = String.Empty;
                int[] input = SearchForm.ConvertToIntArray(txtAddConnections.Text.Trim().Split(','));
                RemoveEdge(input[0], input[1]);
                lblOperationMessage.Text = "Edge Removed";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnRemoveEdge_Click error: " + ex.Message);
            }
        }

        public void RemoveEdge(int data1, int data2)
        {
            foreach (GraphNode node in list)
            {
                if (node.data == data1)
                {
                    foreach (GraphNode removeNode in node.nodes)
                    {
                        if (removeNode.data == data2)
                        {
                            node.nodes.Remove(removeNode);
                            removeNode.nodes.Remove(node);
                            return;
                        }
                    }
                }
            }
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperationMessage.Text = String.Empty;
                ClearGraphTraversal();
                StringBuilder values = new StringBuilder();
                if (list.Count > 0)
                {
                    DFS(list[0], values);
                    if (values.Length > 0)
                        values.Remove(values.Length-1,1);
                    txtResult.Text = Convert.ToString(values);
                }
                else
                    txtResult.Text = "No node in Graph.";
                lblOperationMessage.Text = "DFS done";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnDFS_Click error: " + ex.Message);
            }
        }

        public void DFS(GraphNode root, StringBuilder values)
        {
            bigO++;
            if (root == null || root.isVisited) return;
            root.isVisited = true;
            values.Append(root.data);
            values.Append(",");
            foreach (GraphNode linkedNode in root.nodes)
            {
                bigO++;
                if (linkedNode.isVisited) continue;
                DFS(linkedNode, values);
            }
        }

        private void btnAddDirectedEdge_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperationMessage.Text = String.Empty;
                int[] input = SearchForm.ConvertToIntArray(txtAddConnections.Text.Trim().Split(','));
                AddDirectedEdge(input[0], input[1]);
                lblOperationMessage.Text = "Added Directed Edge";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnAddDirectedEdge_Click error: " + ex.Message);
            }
        }

        public void AddDirectedEdge(int sourceData, int destinationData)
        {
            if (list == null)
                list = new List<GraphNode>();
            GraphNode sourceNode = FindNode(sourceData);
            GraphNode destinationNode = FindNode(destinationData);
            if (sourceNode == null)
            {
                sourceNode = new GraphNode();
                sourceNode.data = sourceData;
                list.Add(sourceNode);
            }

            if (destinationNode == null)
            {
                destinationNode = new GraphNode();
                destinationNode.data = destinationData;
                list.Add(destinationNode);
            }
            sourceNode.nodes.Add(destinationNode);
        }

        private void btnMotherVertex_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperationMessage.Text = String.Empty;
                string motherVertexList = FindAllMotherVertex();
                txtResult.Text = motherVertexList;
                lblOperationMessage.Text = "Mother Vertex operation done.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnMotherVertex_Click error: " + ex.Message);
            }
        }

        public string FindAllMotherVertex()
        {
            bigO = 0;
            bool isMother = false;
            StringBuilder builder = new StringBuilder();
            foreach (GraphNode node in list)
            {
                ClearGraphTraversal();
                bigO++;
                isMother = AreAllNodesConnected(node);
                if (isMother)
                { 
                    builder.Append(node.data);
                    builder.Append(",");
                }
            }

            if (builder.Length > 0)
                builder.Remove(builder.Length - 1, 1);
            return Convert.ToString(builder);
        }

        private void btnKnightProblem_Click(object sender, EventArgs e)
        {
            try
            {
                int[] array = SearchForm.ConvertToIntArray(txtAddConnections.Text.Trim().Split(','));
                KnightProblem(array[0], array[1]);
            }
            catch
            {

            }
        }

        public void KnightProblem(int x, int y)
        {
            int boardSize = 6;

        }

        private void btnMotherVertexOptimized_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperationMessage.Text = String.Empty;
                string motherVertex = FindAllMotherVertexKosaraju();
                txtResult.Text = motherVertex;
                lblOperationMessage.Text = "Mother Vertex operation done.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnMotherVertexOptimized_Click error: " + ex.Message);
            }
        }

        public string FindAllMotherVertexKosaraju()
        {
            int lastVisited;
            ClearGraphTraversal();
            bigO = 0;
            lastVisited = FindLastVisitedNode(list[0]);
            
            return Convert.ToString(list[lastVisited].data);
        }

        public int FindLastVisitedNode(GraphNode root)
        {
            int lastVisited = -1, index = 0;
            
            foreach (GraphNode node in list)
            {
                bigO++;
                if (node.isVisited)
                {
                    index++;
                    continue;
                }
                DFSForMotherVertex(node);
                lastVisited = index;
                index++;
            }

            ClearGraphTraversal();
            DFSForMotherVertex(list[lastVisited]);
            bool areAllVisited = true;
            foreach (GraphNode node in list)
            {
                bigO++;
                areAllVisited = areAllVisited && node.isVisited;
            }

            if(areAllVisited)
                return lastVisited;
            return -1;
        }

        public void DFSForMotherVertex(GraphNode root)
        {
            bigO++;
            if (root == null || root.isVisited) return;
            root.isVisited = true;
            foreach (GraphNode linkedNode in root.nodes)
            {
                bigO++;
                if (linkedNode.isVisited) continue;
                DFSForMotherVertex(linkedNode);
            }
        }

        private void btnKCores_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperationMessage.Text = String.Empty;
                
                int cores = Convert.ToInt32(txtNumberOfNodes.Text);
                RemoveCores(cores);
                string values = String.Join(",", list.Select(x => x.data).ToList());
                values = String.IsNullOrEmpty(values) ? "All nodes were removed." : values;
                txtResult.Text = values;
                lblOperationMessage.Text = "K-Cores operation done.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnKCores_Click error: " + ex.Message);
            }
        }

        public void RemoveCores(int degree)
        {
            CreateDummyGraph();
            int index = 0;
            while (list.Count > 0 && index < list.Count)
            {
                if(!list[index].isVisited)
                    RemoveKCores(degree, list[index]);
                index++;
            } 
        }

        public void CreateDummyGraph()
        {
            list = new List<GraphNode>();
            GraphNode one = new GraphNode();
            one.data = 1;
            GraphNode two = new GraphNode();
            two.data = 2;
            GraphNode three = new GraphNode();
            three.data = 3;
            GraphNode four = new GraphNode();
            four.data = 4;
            GraphNode five = new GraphNode();
            five.data = 5;

            one.nodes.Add(two);
            two.nodes.Add(one);

            three.nodes.Add(three);

            three.nodes.Add(one);
            one.nodes.Add(three);

            two.nodes.Add(three);
            three.nodes.Add(two);

            four.nodes.Add(five);
            five.nodes.Add(four);

            four.nodes.Add(two);
            two.nodes.Add(four);

            list.Add(one);
            list.Add(two);
            list.Add(three);
            list.Add(four);
            list.Add(five);
        }

        public void RemoveKCores(int degree, GraphNode root)
        {
            if (root.isVisited) return;

            if (root.nodes.Count < degree)
            {
                root.isVisited = true;
                int index = 0;
                GraphNode node;
                while (index < root.nodes.Count)
                {
                    node = root.nodes[index];
                    node.nodes.Remove(root);
                    if (node.nodes.Count < degree)
                        RemoveKCores(degree, node);
                    index++;
                }

                list.Remove(root);
            }
        }
    }
}

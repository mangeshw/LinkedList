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
            foreach (GraphNode node in list)
            {
                if (node.data == data)
                    return node;
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
                if (list.Count > 0)
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
                        values.Remove(values.Length - 1, 1);
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

            if (areAllVisited)
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
            bigO = 0;
            while (list.Count > 0 && index < list.Count)
            {
                bigO++;
                if (!list[index].isVisited)
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
            bigO++;
            if (root.isVisited) return;

            if (root.nodes.Count < degree)
            {
                root.isVisited = true;
                int index = 0;
                GraphNode node;
                while (index < root.nodes.Count)
                {
                    bigO++;
                    node = root.nodes[index];
                    node.nodes.Remove(root);
                    if (node.nodes.Count < degree)
                        RemoveKCores(degree, node);
                    index++;
                }

                list.Remove(root);
            }
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperationMessage.Text = String.Empty;
                bool isCycleDetected = DetectCycle();
                txtResult.Text = isCycleDetected ? "Cycle Detected" : "Cycle Not Detected";
                lblOperationMessage.Text = "Detect Cycle operation done.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnCycle_Click error: " + ex.Message);
            }
        }

        public bool DetectCycle()
        {
            if (list.Count == 0) return false;
            HashSet<GraphNode> set = new HashSet<GraphNode>();
            return DetectCycleDFS(list[0], set);
        }

        public bool DetectCycleDFS(GraphNode root, HashSet<GraphNode> set)
        {
            if (root == null) return false;
            if (set.Contains(root))
                return true;
            set.Add(root);
            foreach (GraphNode node in root.nodes)
            {
                if (DetectCycleDFS(node, set))
                    return true;
            }
            set.Remove(root);
            return false;
        }

        private void btnTopologicalSort_Click(object sender, EventArgs e)
        {
            try
            {
                lblOperationMessage.Text = String.Empty;
                Stack<GraphNode> stack = new Stack<GraphNode>();

                if (list.Count > 0)
                {
                    ClearGraphTraversal();
                    foreach (GraphNode node in list)
                        TopologicalSort(node, stack);
                    string topologicalSort = stack.StackToString();
                    txtResult.Text = topologicalSort;
                }
                else
                    txtResult.Text = "Empty List";

                lblOperationMessage.Text = "Topological Sort done.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnTopologicalSort_Click error: " + ex.Message);
            }
            //Stack<int> e = new Stack<int>();

        }

        public void TopologicalSort(GraphNode root, Stack<GraphNode> stack)
        {
            if (root.isVisited) return;
            foreach (GraphNode node in root.nodes)
            {
                if (node.isVisited) continue;
                TopologicalSort(node, stack);
            }

            stack.Push(root);
            root.isVisited = true;
        }

        private void btnNumberOfPaths_Click(object sender, EventArgs e)
        {
            try
            {
                //Source is Root Node and Destination has to be entered in Number Of Nodes textbox.
                int targetVal = Convert.ToInt32(txtNumberOfNodes.Text);
                ClearGraphTraversal();
                int path = FindNumberOfPaths(targetVal, list[0], 0);
                txtResult.Text = Convert.ToString(path);
                lblOperationMessage.Text = "Operation: Number of Paths Successfull";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnNumberOfPaths_Click: " + ex.Message);
            }
        }

        public int FindNumberOfPaths(int target, GraphNode source, int path)
        {
            if (source.isVisited) return 0;
            foreach (GraphNode node in source.nodes)
            {
                if (node.data == target)
                    path += 1;
                else
                    path = FindNumberOfPaths(target, node, path);
            }
            return path;
        }

        private void btnWaterJug_Click(object sender, EventArgs e)
        {
            try
            {
                int[] input = SearchForm.ConvertToIntArray(txtNumberOfNodes.Text.Split(','));
                //4 3 2
                int[,] array = new int[input[0]+1, input[1]+1];
                int target = input[2];
                /*
                    Number of moves
                    1. Fill Jug A from Tank
                    2. Fill Jug B from Tank
                    3. Empty Jug A
                    4. Empty Jug B
                    5. Pour from Jug A to B
                    6. Pour from Jug B to A
                */
                string result = String.Empty;
                //List<Pair<int, int>> steps = WaterJugBFS(array, target);
                Stack<Pair<int, int>> steps = WaterJug_WithTree(array, target);
                if (steps != null && steps.Count > 0)
                {
                    //result = Utility.ListToString(steps);
                    result = Utility.StackPairToString(steps);
                    txtResult.Text = result;
                }
                else
                    txtResult.Text = "Solution doesn't exists.";
                
                lblOperationMessage.Text = "Water Jug operation performed.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnWaterJug_Click error: " + ex.Message);
            }
        }

        public List<Pair<int, int>> WaterJugBFS(int[,] input, int target)
        {
            Queue<Pair<int, int>> queue = new Queue<Pair<int, int>>();
            int jug_a = 0, jug_b = 0;
            Pair<int, int> pair = new Pair<int, int>(jug_a, jug_b);
            queue.Enqueue(pair);
            List<Pair<int, int>> steps = new List<Pair<int, int>>();
            bool solutionExists = false;
            List<GraphNode> list = new List<GraphNode>();

            while (queue.Count > 0)
            {
                pair = queue.Dequeue();
                if (input[pair.First, pair.Second] == 1) continue;

                steps.Add(pair);
                if ((pair.First == target && pair.Second == 0) || (pair.First == 0 && pair.Second == target))
                {
                    solutionExists = true;
                    break;
                }

                jug_a = pair.First;
                jug_b = pair.Second;
                input[jug_a, jug_b] = 1;
                WaterJug_AddConnectedNodes(input.GetLength(0)-1, input.GetLength(1)-1, queue, pair);
            }
            return solutionExists ? steps : null;
        }

        public void WaterJug_AddConnectedNodes(int capacity_a, int capacity_b, Queue<Pair<int, int>> queue, Pair<int, int> pair)
        {
            /*
                Number of moves
                1. Fill Jug A from Tank
                2. Fill Jug B from Tank
                3. Empty Jug A
                4. Empty Jug B
                5. Pour from Jug A to B
                6. Pour from Jug B to A
            */

            if (capacity_a > pair.First)
                queue.Enqueue(new Pair<int, int>(capacity_a, pair.Second));

            if (capacity_b > pair.Second)
                queue.Enqueue(new Pair<int, int>(pair.First, capacity_b));

            if (pair.First > 0)
                queue.Enqueue(new Pair<int, int>(0, pair.Second));

            if (pair.Second > 0)
                queue.Enqueue(new Pair<int, int>(pair.First, 0));

            if (capacity_b > pair.Second && pair.First > 0)
            {
                int afterPour_a = pair.First > capacity_b ? pair.First - capacity_b + pair.Second : 0;
                int afterPout_b = pair.First > capacity_b ? capacity_b : pair.First + pair.Second;
                queue.Enqueue(new Pair<int, int>(afterPour_a, afterPout_b));
            }

            if (capacity_a > pair.First && pair.Second > 0)
            {
                int afterPour_b = pair.Second > capacity_a ? Math.Min(pair.Second - capacity_a + pair.First, capacity_b) : 0;
                int afterPour_a = pair.Second > capacity_a ? capacity_a : Math.Min(pair.Second + pair.First, capacity_a);
                queue.Enqueue(new Pair<int, int>(afterPour_a, afterPour_b));
            }
        }

        public Stack<Pair<int, int>> WaterJug_WithTree(int[,] input, int target)
        { 
            Stack<Pair<int, int>> steps = new Stack<Pair<int, int>>();
            Queue<GraphNode> queue = new Queue<GraphNode>();
            int jug_a = 0, jug_b = 0;
            Pair<int, int> pair = new Pair<int, int>(jug_a, jug_b);
            
            GraphNode node = new GraphNode();
            node.pairData = pair;
            node.parentNode = null;
            queue.Enqueue(node);

            int capacity_a = input.GetLength(0);
            int capacity_b = input.GetLength(1);
            
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                if (input[node.pairData.First, node.pairData.Second] == 1) continue;
                if (node.pairData.First == target || node.pairData.Second == target)
                {
                    while (node != null)
                    {
                        steps.Push(node.pairData);
                        node = node.parentNode;
                    }
                    return steps;
                }
                else
                {
                    //Add All possible combinations to Queue
                    jug_a = node.pairData.First;
                    jug_b = node.pairData.Second;
                    input[jug_a, jug_b] = 1;
                    WaterJug_AddConnectedNodes_WithTree(capacity_a-1, capacity_b-1, queue, node);
                }
            }

            return steps;
        }
        
        public void WaterJug_AddConnectedNodes_WithTree(int capacity_a, int capacity_b, Queue<GraphNode> queue, GraphNode node)
        {
            /*
                Number of moves
                1. Fill Jug A from Tank
                2. Fill Jug B from Tank
                3. Empty Jug A
                4. Empty Jug B
                5. Pour from Jug A to B
                6. Pour from Jug B to A
            */

            GraphNode newNode = null;
            Pair<int, int> tuple = null;
            
            if (capacity_a > node.pairData.First)
            {
                tuple = new Pair<int, int>(capacity_a, node.pairData.Second);
                newNode = new GraphNode();
                newNode.pairData = tuple;
                node.nodes.Add(newNode);
                newNode.parentNode = node;
                queue.Enqueue(newNode);
            }

            if (capacity_b > node.pairData.Second)
            {
                tuple = new Pair<int, int>(node.pairData.First, capacity_b);
                newNode = new GraphNode();
                newNode.pairData = tuple;
                node.nodes.Add(newNode);
                newNode.parentNode = node;
                queue.Enqueue(newNode);
            }

            if (node.pairData.First > 0)
            {
                tuple = new Pair<int, int>(0, node.pairData.Second);
                newNode = new GraphNode();
                newNode.pairData = tuple;
                node.nodes.Add(newNode);
                newNode.parentNode = node;
                queue.Enqueue(newNode);
            }

            if (node.pairData.Second > 0)
            {
                tuple = new Pair<int, int>(node.pairData.First, 0);
                newNode = new GraphNode();
                newNode.pairData = tuple;
                node.nodes.Add(newNode);
                newNode.parentNode = node;
                queue.Enqueue(newNode);
            }

            if (capacity_b > node.pairData.Second && node.pairData.First > 0)
            {
                int afterPour_a = node.pairData.First > capacity_b ? node.pairData.First - capacity_b + node.pairData.Second : 0;
                int afterPout_b = node.pairData.First > capacity_b ? capacity_b : node.pairData.First + node.pairData.Second;
                tuple = new Pair<int, int>(afterPour_a, afterPout_b);
                newNode = new GraphNode();
                newNode.pairData = tuple;
                node.nodes.Add(newNode);
                newNode.parentNode = node;
                queue.Enqueue(newNode);
            }

            if (capacity_a > node.pairData.First && node.pairData.Second > 0)
            {
                int afterPour_b = node.pairData.Second > capacity_a ? Math.Min(node.pairData.Second - capacity_a + node.pairData.First, capacity_b) : 0;
                int afterPour_a = node.pairData.Second > capacity_a ? capacity_a : Math.Min(node.pairData.Second + node.pairData.First, capacity_a);
                tuple = new Pair<int, int>(afterPour_a, afterPour_b);
                newNode = new GraphNode();
                newNode.pairData = tuple;
                node.nodes.Add(newNode);
                newNode.parentNode = node;
                queue.Enqueue(newNode);
            }
        }
    }
}

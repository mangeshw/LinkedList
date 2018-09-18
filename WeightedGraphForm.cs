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
    public partial class WeightedGraphForm : Form
    {
        private List<WGraphNode> nodes = null;

        public WeightedGraphForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        public void ClearForm()
        {
            txtConnectVertices.Text = String.Empty;
            txtResult.Text = String.Empty;
            txtWeight.Text = String.Empty;
            txtOperation.Text = String.Empty;
        }

        private void btnNegativeCycle_Click(object sender, EventArgs e)
        {
            try
            {
                ClearForm();
                //TraverseGraph();
            }
            catch(Exception ex)
            {
                MessageBox.Show("btnNegativeCycle_Click: " + ex.Message);
            }
        }

        public bool TraverseGraph(WGraphNode root, int weight, WGraphNode destination)
        {
            if (root.isVisited) return false;
            return false;
        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            try
            {
                int[] input = SearchForm.ConvertToIntArray(txtConnectVertices.Text.Trim().Split(','));
                nodes = nodes ?? new List<WGraphNode>();
                WGraphNode source = FindNode(input[0]);
                if (source == null)
                {
                    source = new WGraphNode();
                    source.data = input[0];
                    nodes.Add(source);
                }
        
                WGraphNode destination = FindNode(input[1]);
                if (destination == null)
                {
                    destination = new WGraphNode();
                    destination.data = input[1];
                    nodes.Add(destination);
                }

                WGraphEdge edge = new WGraphEdge();
                edge.source = source;
                edge.destination = destination;
                edge.weight = Convert.ToInt32(txtWeight.Text);
                if (source.edges == null)
                    source.edges = new List<WGraphEdge>();
                source.edges.Add(edge);
                txtOperation.Text = "Operation Add Edge Successful";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnAddEdge_Click: " + ex.Message);
            }
        }

        public WGraphNode FindNode(int data)
        {
            foreach (WGraphNode node in nodes)
                if (node.data == data) return node;
            return null;
        }

        private void btnLongestPath_Click(object sender, EventArgs e)
        {
            try
            {
                ClearForm();
                //TraverseGraph();
                int maxWeight = int.MinValue;
                int weight = 0;
                foreach (WGraphNode node in nodes)
                {
                    weight = FindLongestPath(node, 0);
                    maxWeight = Math.Max(maxWeight, weight);
                }
                txtResult.Text = maxWeight.ToString();
                txtOperation.Text = "Operation Longest Path Successful";
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnNegativeCycle_Click: " + ex.Message);
            }
        }

        public int FindLongestPath(WGraphNode root, int inputWeight)
        {
            if (root.isVisited) return 0;
            int distance = 0;
            int maxWeight = 0;
            if (root.edges == null) return 0;

            foreach (WGraphEdge edge in root.edges)
            {
                distance += FindLongestPath(edge.destination, inputWeight);
                distance += edge.weight;
                maxWeight = Math.Max(maxWeight, inputWeight+distance);
                distance = 0;
            }

            return maxWeight;
        }

        private void btnKruskalsMST_Click(object sender, EventArgs e)
        {
            try
            {
                WeightedGraph graph = CreateDummyGraph();
                KruskalsMST(graph);
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnKruskalsMST_Click error: " + ex.Message);
            }
        }

        public WeightedGraph CreateDummyGraph()
        {
            WeightedGraph graph = new WeightedGraph();
            graph.vertices = 4;
            graph.edges = new List<WGraphEdge>();
            WGraphNode a = new WGraphNode();
            a.data = 1;
            WGraphNode b = new WGraphNode();
            b.data = 1;
            WGraphNode c = new WGraphNode();
            c.data = 1;
            WGraphNode d = new WGraphNode();
            d.data = 1;

            WGraphEdge edge = new WGraphEdge();
            edge.source = a;
            edge.destination = b;
            edge.weight = 10;
            graph.edges.Add(edge);

            edge = new WGraphEdge();
            edge.source = a;
            edge.destination = c;
            edge.weight = 5;
            graph.edges.Add(edge);

            edge = new WGraphEdge();
            edge.source = a;
            edge.destination = d;
            edge.weight = 6;
            graph.edges.Add(edge);

            edge = new WGraphEdge();
            edge.source = b;
            edge.destination = c;
            edge.weight = 15;
            graph.edges.Add(edge);

            edge = new WGraphEdge();
            edge.source = c;
            edge.destination = d;
            edge.weight = 4;
            graph.edges.Add(edge);

            return graph;
        }

        public void KruskalsMST(WeightedGraph graph)
        {
            //Sort all edges by their weight
            SortEdges(graph.edges);
            //Loop
            //  If no cycle formed then include in MST with Union Find 
            //  Else move on to next edge
            WGraphEdge[] parent = new WGraphEdge[graph.vertices];
            int index = 0;
            while (index < graph.edges.Count)
            {
                
            }
        }

        public void SortEdges(List<WGraphEdge> edges)
        {
            edges = edges.OrderBy(x => x.weight).ToList();
        }

        public void UnionFind(WGraphEdge edge)
        {
            
        }
    }
}

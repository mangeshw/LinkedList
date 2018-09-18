using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinkedList
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Dictionary<int, string> dict = new Dictionary<int, string>();
            //int ff = Convert.ToInt32('4');
             
            //dict = new Dictionary<int, string>(2);
            //StringBuilder build = new StringBuilder();
            //build.Append("1");
            //build.Append("2");
            //build.Append("3");
            //build.Append("4");
            //build.Append("5");
            //build.Append("6");
            //build.Remove(1, 3);
            //build.Remove(0, 3);
            ////int[] buffer = new int[1, 1];
            ////build.Length
            //string er = "123456";
            //char[] str = er.ToCharArray();
            
            //string ree = new string(str);
            //er = er.Remove(2, 3);
            ////er[3] = 'f';
            //dict.Add(1, "1");
            //dict.Add(2, "2");
            //dict.Add(3, "3");
            //int[] nums = { 3, 2, 1, 5, 6, 4 };
            //nums.ToList().Sort();
            //nums.Where(w => w == 2);
            //nums = nums.ToList().OrderByDescending(w => w).ToArray();
            //SortedSet<int> aa = new SortedSet<int>();
            //SortedList<int, List<List<int>>> ba = new SortedList<int, List<List<int>>>();
            //List<List<int>> list = new List<List<int>>();
            //IList<int> qq = new List<int>();
            //qq.Add(3);
            //ba.Add(0, qq as List<List<int>>);
            //list = ba.Values as List<List<int>>;

            //IList<IList<int>> k = null;
            //k = list as IList<IList<int>>;
            //int[] iarr = { 5 };
            //int[,] hh = new int[7, 8];
            //bool[] icConnected = new bool[5];
            //hh.GetLength(1);
            ////arr = { 35 };
            //aa.Add(1);
            //aa.Add(1);
            ////ba = aa;
            //int min = int.MinValue;
            //int max = int.MaxValue;
            ////max = Math.Sign(-2);
            ////max = Math.Sign(2);
            //int diff = min - max;
            //int?[] na = new int?[10];
            //int? a = min - 1;

            //List<int> r1 = new List<int>();
            ////list = r1;
            ////list.Insert(-1, 4);
            ////list.Insert(0, 4);
            ////list.Remove(4);
            //a = 0;
            //a += Convert.ToInt32(Math.Pow(10, 0)) * 2;
            //HashSet<int> set = new HashSet<int>();
            //set.Add(1);
            //set.Add(1);
            //a += Convert.ToInt32(Math.Pow(10, 1)) * 1;
            //int b = max + 1;
            //LNode node = new LNode();
            //node.IntegerData = 1;
            //LNode head = new LNode();
            //head = node;
            //node.IntegerData = 2;
            //node = node.Next;
            //node = new LNode();
            //node.IntegerData = 4;
            //aa.Add(1);
            //aa.Add(1);
            //int result;
            //bool cv = int.TryParse("w", out result);
            //int[,,] ar = new int[3, 2, 6];
            //a = ar.Length;
            //b = ar.Rank;
            //int a1 = ar.GetLength(0);
            //int a2 = ar.GetLength(1);
            //int[] aq = new int[10];
            //Class1 c = new Class1();
            //string lit = "romeo romeo wherefore art thou romeo wherefore wherefore";
            //List<string> exclude = new List<string>();
            //exclude.Add("art");
            //exclude.Add("thou");
            //c.retrieveMostFrequentlyUsedWords(lit, exclude);
            //Class2 cc = new Class2();
            //int x = 5;
            //string[] arr = { "a1 9 2 3 1", "g1 act car", "zo4 4 4 7", "ab1 off key dog", "a8 act zoo" };
            ////cc.reorderLines(x, arr);
            ////char v = ""[2];
            ////char.IsPunctuation(v);
            ////" ".Replace(" ", "");
            //String.Format("", 1, 2, 3);
            //HashSet<int> hSet = new HashSet<int>();
            //hSet.Add(1);
            //hSet.Add(0);
            //hSet.Add(1);
            //bool i = hSet.Contains(4);
            ////Hashtable t = new Hashtable();

            ////int a3 = ar.GetLength(3);
            //KeyValuePair<int, string> kvc = new KeyValuePair<int, string>();

            //foreach (KeyValuePair<int, string> kv in dict)
            //{
            //    //dict.ContainsKey("");
            //    //SortedDictionary<string, int> s = new SortedDictionary<string, int>();
            //    //kv.Value
            //}
            //List<string> l = new List<string>();
            //l.Contains("");
            //l.Insert(-1, "f");
            ////string.Join(",", arr)

            //string s = "anagram";
            ////List<char> v = s.OrderBy(x => x).ToList();
            //if ('b' > 'C')
            //    Console.WriteLine("aya");
            //int ascii = (int)'C';
            ////char c = (char)97;
            //s.ToCharArray();
            //GFG.ConstructSolution();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class LNode
    {
        public LNode Next;
        public LNode Previous;
        public int IntegerData;
        public string StringData;
        public int priority;

        public LNode()
        {
            priority = 0;
        }

        public LNode(int intData, int nodePriority)
        {
            IntegerData = intData;
            priority = nodePriority;
        }

    }

    public class SNode
    {
        public int Value;
        public char Val;
        //Ideally this class should be in different assembly as
        // next node should not be accessible to other classes.
        internal SNode Next;
    }

    public class StackList
    {
        SNode root = new SNode();
        public int Length = 0;

        public bool Push(SNode node)
        {
            if (Length == int.MaxValue)
                return false;
            node.Next = this.root;
            root = node;
            Length++;
            return true;
        }

        public SNode Pop()
        {
            if (Length <= 0)
                return null;
            SNode node = new SNode();
            node = root;
            root = root.Next;
            Length--;
            return node;
        }

        public SNode Peek()
        {
            return root;
        }
    }

    public class CustomList
    {
        private LNode _root;
        private LNode _front;
        private LNode _rear;
        private bool _isDeleteFrequent;

        private int _length = int.MinValue;
        private int _maximumInteger = int.MinValue;
        private int _minimumInteger = int.MaxValue;
        private int _highestPriority = int.MinValue;
        private int _lowestPriority = int.MaxValue;

        //This is Root for Stack, Head for LinkedList and Rear for Queue
        public LNode First { get; set; }
        //This is Front for Queue and Last node for LinkedList and Stack
        public LNode Last { get; set; }

        public int Length { get; private set; }
        public int MaximumInteger { get; private set; }
        public int MinimumInteger { get; private set; }
        public int HighestPriority { get; private set; }
        public int LowestPriority { get; private set; }

        public CustomList(bool isDeleteFrequent)
        {
            _isDeleteFrequent = isDeleteFrequent;
        }

        //Convert string array to Custom List
        public static CustomList ConvertToCustomList(string[] array, bool isIntegerList)
        {
            CustomList list = new CustomList(true);
            LNode node;
            for (int index = 0; index < array.Length; index++)
            {
                node = new LNode();
                if (isIntegerList)
                    node.IntegerData = Convert.ToInt32(array[index]);
                else
                    node.StringData = array[index];
                list.Add(node);
            }
            return list;
        }

        //Convert CustomList to integer array
        public static int[] ConvertIntegerListToArray(CustomList list)
        {
            int[] array = new int[list.Length];
            LNode node = list.First;
            for (int index = 0; index < list.Length; index++)
            {
                array[index] = node.IntegerData;
                node = node.Next;
            }
            return array;
        }

        //Convert CustomList to string array
        public static string[] ConvertStringListToArray(CustomList list)
        {
            string[] array = new string[list.Length];
            LNode node = list.First;
            for (int index = 0; index < list.Length; index++)
            {
                array[index] = node.StringData;
                node = node.Next;
            }
            return array;
        }

        //SetListVariables()
        private void SetListVariables(ListOperation operation, LNode node)
        {
            //These operations cost very high in delete operations.
            //if (_isDeleteFrequent == true)
            //    return;
            switch (operation)
            {
                case ListOperation.Delete:
                    Length--;
                    //Set Maximum
                    //Set Minimum
                    //Set Priority
                    break;
                case ListOperation.Insert:
                    //Set Length for all data structures
                    Length++;

                    //TODO
                    ////Set Maximum 
                    //if (node.IntegerData > MaximumInteger)
                    //    MaximumInteger = node.IntegerData;
                    ////Set Minimum
                    //if (node.IntegerData < MinimumInteger)
                    //    MinimumInteger = node.IntegerData;
                    ////Set Priority
                    //if (node.priority > HighestPriority)
                    //    HighestPriority = node.priority;
                    //if (node.priority < LowestPriority)
                    //    LowestPriority = node.priority;
                    break;

                default: return;
            }
        }

        //Add a node()
        public bool Add(LNode newNode)
        {
            if (Length == int.MaxValue)
                return false;
            newNode.Next = null;
            //Set Front for Queue
            if (Length == 0)
            {
                Last = newNode;
                First = newNode;
                SetListVariables(ListOperation.Insert, newNode);
                return true;
            }
            Last.Next = newNode;
            newNode.Previous = Last;
            Last = newNode;

            SetListVariables(ListOperation.Insert, newNode);
            return true;
        }

        //Add a node()
        public bool AddFirst(LNode newNode)
        {
            if (Length == int.MaxValue)
                return false;
            if (Length == 0)
            {
                First = newNode;
                Last = newNode;
                SetListVariables(ListOperation.Insert, newNode);
            }
            newNode.Next = First;
            newNode.Previous = null;
            //Set Front for Queue
            First.Previous = newNode;
            First = newNode;
            SetListVariables(ListOperation.Insert, newNode);
            return true;
        }

        //Delete()
        private LNode Delete(ListOperation operation)
        {
            LNode node;
            if (Length == 0)
                return null;
            if (operation == ListOperation.Pop || operation == ListOperation.Delete)
            {
                node = First;
                //Set Root for Stack
                First = First.Next;
                First.Previous = null;
                if (Length == 1)
                    Last = null;
                SetListVariables(ListOperation.Delete, node);
            }
            else if (operation == ListOperation.Dequeue)
            {
                node = Last;
                Last = Last.Previous;
                Last.Next = null;
                if (Length == 1)
                    First = null;
                SetListVariables(ListOperation.Delete, node);
            }
            else
                node = null;
            return node;
        }

        //Peek()
        public LNode Peek()
        {
            return First;
        }

        //Push()
        public bool Push(LNode newNode)
        {
            return AddFirst(newNode);
        }

        //Pop()
        public LNode Pop()
        {
            return Delete(ListOperation.Pop);
        }

        //Enqueue()
        public bool Enqueue(LNode newNode)
        {
            return AddFirst(newNode);
        }

        //Dequeue()
        public LNode Dequeue()
        {
            return Delete(ListOperation.Dequeue);
        }

        //InsertAfter for Doubly Linked List
        public bool InsertAfter(LNode node, LNode newNode)
        {
            if (node == null || newNode == null || Length == int.MaxValue)
                return false;
            LNode nextNode = node.Next;
            node.Next = newNode;
            newNode.Previous = node;
            if (nextNode != null)
            {
                nextNode.Previous = newNode;
                newNode.Next = nextNode;
            }
            else
            {
                newNode.Next = null;
                Last = newNode;
            }
            SetListVariables(ListOperation.Insert, newNode);
            return true;
        }

        //InsertBefore for Doubly Linked List
        public bool InsertBefore(LNode node, LNode newNode)
        {
            if (node == null || newNode == null || Length == int.MaxValue)
                return false;
            LNode previousNode = node.Previous;
            node.Previous = newNode;
            newNode.Next = node;
            if (previousNode != null)
            {
                previousNode.Next = newNode;
                newNode.Previous = previousNode;
            }
            else
            {
                newNode.Previous = null;
                First = newNode;
            }
            SetListVariables(ListOperation.Insert, newNode);
            return true;
        }

        public bool DeleteNode(LNode node)
        {
            if (node == null)
                return false;
            LNode nextNode = node.Next;
            LNode previousNode = node.Previous;
            if (node.Next == null && node.Previous == null)
            {
                Delete(ListOperation.Pop);
            }
            else if (nextNode == null)
                Delete(ListOperation.Dequeue);
            else if (previousNode == null)
                Delete(ListOperation.Pop);
            else
            {
                previousNode.Next = nextNode;
                nextNode.Previous = previousNode;
                SetListVariables(ListOperation.Delete, node);
            }
            return true;
        }
    }

    public enum ListOperation
    {
        Peek,
        Push,
        Pop,
        Enqueue,
        Dequeue,
        Insert,
        Delete
    }

    public class TreeNode
    {
        public TreeNode Left;
        public TreeNode Right;
        public int IntegerValue;
        public string StringValue;
    }

    public class Tree
    {
        public TreeNode Root;
        private int _nodeCount = 0;

        public int NodeCount { get; private set; }

        public Tree()
        {

        }

        public Tree(TreeNode RootNode)
        {
            Root = RootNode;
        }
        
    }

    public class GraphNode
    {
        public int data;
        public List<GraphNode> nodes = new List<GraphNode>();
        public bool isVisited = false;
    }

    public class WGraphEdge
    {
        public int weight;
        public WGraphNode source;
        public WGraphNode destination;
    }

    public class WGraphNode
    {
        public int data;
        public List<WGraphEdge> edges = null;
        public bool isVisited = false;
    }

    public class WeightedGraph
    {
        public int vertices;
        public List<WGraphEdge> edges = null;
    }

    public static class Utility
    {
        public static string StackToString<T>(this Stack<T> stack)
        {
            if (stack == null && stack.Count > 0) return String.Empty;
            StringBuilder str = new StringBuilder();

            while (stack.Count > 0)
            {
                dynamic node = stack.Pop();
                str.Append(node.data);
                str.Append(",");
            }

            if (str.Length > 0)
                str.Remove(str.Length - 1, 1);
            return str.ToString();
        }
        
    }

    public class Pair<T, U>
    {
        public T First;
        public U Second;

        public Pair(T first, U second)
        {
            this.First = first;
            this.Second = second;
        }

        public string ListToString(List<Pair<T, U>> list)
        {
            StringBuilder builder = new StringBuilder();
            foreach (Pair<T, U> pair in list)
            {
                builder.Append("(");
                builder.Append(Convert.ToString(pair.First));
                builder.Append(",");
                builder.Append(Convert.ToString(pair.Second));
                builder.Append(")");
                builder.Append(",");
            }

            if (builder.Length > 0)
                builder.Remove(builder.Length - 1, 1);
            return Convert.ToString(builder);
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            if(Length == 0)
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
            if(Length == 0)
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
}
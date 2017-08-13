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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private LNode GetListFromString(string list)
        {
            //string[] array = txtElements.Text.Split(',');
            string[] array = list.Split(',');
            //List<LNode> nodeList = new List<LNode>();
            LNode node, previousNode = null, headNode = null;
            for (int index = 0; index < array.Length; index++)
            {
                if (String.IsNullOrWhiteSpace(array[index]))
                    continue;
                node = new LNode();
                node.IntegerData = Convert.ToInt32(array[index]);
                if (index != 0 && previousNode != null)
                {
                    previousNode.Next = node;
                }
                else
                    headNode = node;
                //nodeList.Add(node);
                previousNode = node;
            }
            return headNode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LNode headNode = GetListFromString(txtElements.Text);
            PrintNodeList(headNode);
        }

        private void PrintNodeList(LNode head)
        {
            LNode node = head;
            StringBuilder builder = new StringBuilder();
            while (node != null)
            {
                builder.Append(node.IntegerData);
                builder.Append(" -> ");
                node = node.Next;
            }
            int length = builder.Length;
            label1.Text = builder.ToString().TrimEnd(new char[] { ' ', '-', '>', ' '});
        }

        private void btnGetLength_Click(object sender, EventArgs e)
        {
            LNode node = GetListFromString(txtElements.Text);
            int count = 0;
            while (node != null)
            {
                node = node.Next;
                count++;
            }
            label1.Text = "Length is: " + count.ToString();
        }
        
        private void btnReverse_Click(object sender, EventArgs e)
        {
            LNode node = GetListFromString(txtElements.Text);
            LNode rHead = null, temp = new LNode();
            while (node != null)
            {
                if (rHead == null)
                {
                    rHead = node;
                    node = node.Next;
                    rHead.Next = null;
                }
                else
                {
                    temp = node;
                    node = node.Next;
                    temp.Next = rHead;
                    rHead = temp;
                }
            }
            PrintNodeList(rHead);
        }

        private void btnRPrint_Click(object sender, EventArgs e)
        {
            LNode node = GetListFromString(txtElements.Text);
            label1.Text = String.Empty;
            label1.Text = PrintListUsingRecursion(node);
        }

        private string PrintListUsingRecursion(LNode node)
        {
            if (node == null)
                return null;
            int data = node.IntegerData;
            node = node.Next;
            return data + (node == null ? String.Empty : " -> " ) + PrintListUsingRecursion(node);
        }

        private void btnRGetLength_Click(object sender, EventArgs e)
        {
            LNode node = GetListFromString(txtElements.Text);
            label1.Text = "Length is: " + Convert.ToString(GetLengthUsingRecursion(node));
        }

        private int GetLengthUsingRecursion(LNode node)
        {
            if (node == null)
                return 0;
            node = node.Next;
            return 1 + GetLengthUsingRecursion(node);
        }

        private void btnRReverse_Click(object sender, EventArgs e)
        {
            LNode node = GetListFromString(txtElements.Text);
            label1.Text = ReversePrintUsingRecursion(node);
        }

        private string ReversePrintUsingRecursion(LNode node)
        {
            if (node == null)
                return String.Empty;
            int data = node.IntegerData;
            node = node.Next;
            return ReversePrintUsingRecursion(node) + (node == null ? String.Empty : " -> ") + data;
        }

        private void btnMergeSortedList_Click(object sender, EventArgs e)
        {
            LNode node1 = GetListFromString(txtElements.Text);
            LNode node2 = GetListFromString(txtArray2.Text);
            LNode head = MergeLists(node1, node2);
            PrintNodeList(head);
        }

        private LNode MergeLists(LNode node1, LNode node2)
        {
            if (node1 == null && node2 == null)
                return null;
            if (node1 == null)
                return node2;
            if (node2 == null)
                return node1;

            LNode head = null, temp = null, traversal = null, previousNode = null;
            while (node1 != null && node2 != null)
            {
                previousNode = traversal;
                if (node1.IntegerData <= node2.IntegerData)
                {
                    temp = node1;
                    node1 = node1.Next;
                    if (head == null)
                    {
                        head = temp;
                        traversal = temp;
                    }
                    else
                        traversal = temp;
                }
                else
                {
                    temp = node2;
                    node2 = node2.Next;
                    if (head == null)
                    {
                        head = temp;
                        traversal = temp;
                    }
                    else
                        traversal = temp;
                }
                if (head != traversal)
                    previousNode.Next = traversal;
                else
                    previousNode = head;
            }

            while (node1 != null)
            {
                previousNode = traversal;
                temp = node1;
                node1 = node1.Next;
                traversal = temp;
                previousNode.Next = traversal;
            }

            while (node2 != null)
            {
                previousNode = traversal;
                temp = node2;
                node2 = node2.Next;
                traversal = temp;
                previousNode.Next = traversal;
            }
            return head;
        }

        private void btnRMergeSort_Click(object sender, EventArgs e)
        {
            LNode node1 = GetListFromString(txtElements.Text);
            LNode node2 = GetListFromString(txtArray2.Text);
            LNode result = RMergeLists(node1, node2, null);
            label1.Text = PrintListUsingRecursion(result);
        }

        private LNode RMergeLists(LNode node1, LNode node2, LNode result)
        {
            if (node1 == null && node2 == null)
                return null;
            else if (node1 == null)
                result = node2;
            else if (node2 == null)
                result = node1;
            else
            {
                LNode temp;
                if (node1.IntegerData <= node2.IntegerData)
                {
                    temp = node1;
                    node1 = node1.Next;
                    result = temp;
                    result.Next = RMergeLists(node1, node2, result);
                }
                else
                {
                    temp = node2;
                    node2 = node2.Next;
                    result = temp;
                    result.Next = RMergeLists(node1, node2, result);
                }
            }
            return result;
        }

        private void btnDetectLoop_Click(object sender, EventArgs e)
        {
            LNode node = GetListFromString(txtElements.Text);
            node = MakeLoopInList(node);
            node = DetectAndRemoveLoop(node);
            label1.Text = PrintListUsingRecursion(node);
        }

        private LNode MakeLoopInList(LNode node)
        {
            LNode head = node, buffer = null, previousNode = null;
            int count = GetLengthUsingRecursion(node);
            if (count == 0)
                return null;
            Random random = new Random();
            int randomInt = random.Next(1, count), index = 1;
            while (node != null)
            {
                if (index == randomInt)
                    buffer = node;
                index++;
                previousNode = node;
                node = node.Next;
            }

            if(buffer != null && previousNode != null)
                previousNode.Next = buffer;
            return head;
        }

        private LNode DetectAndRemoveLoop(LNode node)
        {
            LNode slowNode = node, fastNode = node, head = node, previousNode = null;
            while (fastNode != null && slowNode != null)
            {
                fastNode = fastNode.Next;
                if (fastNode != null)
                    fastNode = fastNode.Next;
                previousNode = slowNode;
                slowNode = slowNode.Next;
                if (fastNode == slowNode)
                {
                    //previousNode.Next = null;
                    break;
                }
            }
            //1->2->3->4->5->6->4->5->6...
            LNode traversal = node;
            while (node != null || traversal == previousNode)
            {
                node = node.Next;
            }
            return head;
        }
    }
}

//private LNode MakeDummyList()
//{
//    LNode head = new LNode();
//    head.Data = "This is Head";
//    LNode node2 = new LNode();
//    node2.Data = "This is Node2";
//    LNode node3 = new LNode();
//    node3.Data = "This is Node3";
//    LNode node4 = new LNode();
//    node4.Data = "This is Node4";
//    LNode node5 = new LNode();
//    node5.Data = "This is Node5";
//    LNode node6 = new LNode();
//    node6.Data = "This is Node6";
//    LNode node7 = new LNode();
//    node7.Data = "This is Node7"; // Only this data is same.
//    LNode node8 = new LNode();
//    node8.Data = "This is Node8";
//    LNode node9 = new LNode();
//    node9.Data = "This is Node9";
//    LNode node10 = new LNode();
//    node10.Data = "This is Node10";
//    LNode node11 = new LNode();
//    node11.Data = "This is Node11";

//    head.Next = node2;
//    node2.Next = node3;
//    node3.Next = node4;
//    node4.Next = node5;
//    node5.Next = node6;
//    node6.Next = node7;
//    node7.Next = node8;
//    node8.Next = node9;
//    node9.Next = node10;
//    node10.Next = node11;
//    node11.Next = null;

//    return head;
//}

//private LNode MakeAnotherDummyList()
//{
//    LNode head = new LNode();
//    head.Data = "This is Head";
//    LNode node2 = new LNode();
//    node2.Data = "This is Node12";
//    LNode node3 = new LNode();
//    node3.Data = "This is Node13";
//    LNode node4 = new LNode();
//    node4.Data = "This is Node14";
//    LNode node5 = new LNode();
//    node5.Data = "This is Node15";
//    LNode node6 = new LNode();
//    node6.Data = "This is Node16";
//    LNode node7 = new LNode();
//    node7.Data = "This is Node7"; // Only this data is same.
//    LNode node8 = new LNode();
//    node8.Data = "This is Node18";
//    LNode node9 = new LNode();
//    node9.Data = "This is Node19";
//    LNode node10 = new LNode();
//    node10.Data = "This is Node20";
//    LNode node11 = new LNode();
//    node11.Data = "This is Node21";

//    head.Next = node2;
//    node2.Next = node3;
//    node3.Next = node4;
//    node4.Next = node5;
//    node5.Next = node6;
//    node6.Next = node7;
//    node7.Next = node8;
//    node8.Next = node9;
//    node9.Next = node10;
//    node10.Next = node11;
//    node11.Next = null;

//    return head;
//}


//4 Meetings
// 1:00 - 1:30
// 2:00 - 2:45
// 1:45 - 3:00
// 4:00 - 5:00
// 3:00 - 4:30
// 3:30 - 4:00

//Sort              Room
// 1:00 - 1:30      A 1:30
// 1:45 - 3:00      A 3:00
// 3:00 - 3:30      A 3:30
// 3:00 - 4:30      B 4:30
// 3:30 - 4:00      A 4:00
// 4:00 - 5:00      A 5:00

//1->2->3->4->5->6->7->8->NULL
//Head->1->2.. | Buff(Head)->1->2 | Head(1)->2->3.. | Buff->1(Temp)->NULL | Temp(Buff)->1->NULL
//Head->2->3.. | Buff(Head)->2->3 | Head(2)->3->4.. | Buff->2(Temp)->1->NULL | Temp(Buff)->2->1->NULL
//Head->3->4.. | Buff(Head)->3->4 | Head(3)->4->5.. | Buff->3(Temp)->2->1->NULL | Temp(Buff)->3->2->1->NULL

//int[] smallArray = { 2, 4, 50 };
//int[] midArray = { 25, 26, 40, 44 };
//int[] bigArray = { 12, 29, 33, 39, 52 };

//int smallIndex = 0, midIndex = 0, bigIndex = 0;
//int smallLength = 3, midLength = 4, bigLength = 5;

//int finalLength = smallLength + midLength + bigLength;

//int[] finalArray = new int[finalLength];

//            for (int index = 0; index<finalLength; index++)
//            {
//                int flag = 0;
//                if (smallArray.Length == smallIndex)
//                {
//                    flag += 1;
//                }
//                if (midArray.Length == midLength)
//                {
//                    flag += 3;
//                }
//                if (bigArray.Length == bigLength)
//                {
//                    flag += 9;
//                }

//                if (flag == 1)
//                {
//                    // Compare and Insert only Mid and Big Array
//                }
//                else if (flag == 3)
//                {
//                    // Compare and Insert only Small and Big Array
//                }
//                else if (flag == 4)
//                {
//                    // Insert Big Array
//                }
//                else if (flag == 9)
//                {
//                    //Compare and Insert Small and Big Array
//                }
//                else if (flag == 10)
//                {
//                    //Insert Mid Array
//                }
//                else if (flag == 12)
//                {
//                    //Insert Small Array
//                }
//                else
//                {
//                    //When none of the array has reached the limit.
//                    if (smallArray[smallIndex] > midArray[midIndex])
//                    {
//                        if (midArray[midIndex] > bigArray[bigIndex])
//                        {
//                            //Big Array Element is the smallest
//                            finalArray[index] = bigArray[bigIndex];
//                            bigIndex++;
//                            continue;
//                        }
//                        else if (midArray[midIndex] < bigArray[bigIndex])
//                        {
//                            //Mid Array Element is the smallest
//                            finalArray[index] = midArray[midIndex];
//                            midIndex++;
//                            continue;
//                        }
//                        else
//                        {
//                            //Mid and Big Array Element are the smallest
//                            finalArray[index] = midArray[midIndex];
//                            index++;
//                            midIndex++;
//                            finalArray[index] = bigArray[bigIndex];
//                            bigIndex++;
//                            continue;
//                        }
//                    }
//                    else if (smallArray[smallIndex] < midArray[midIndex])
//                    {
//                        if (smallArray[smallIndex] > bigArray[bigIndex])
//                        {
//                            //Big Array Element is the smallest
//                            finalArray[index] = bigArray[bigIndex];
//                            bigIndex++;
//                            continue;
//                        }
//                        else if (smallArray[smallIndex] < bigArray[bigIndex])
//                        {
//                            //Small Array Element is the smallest
//                            finalArray[index] = smallArray[smallIndex];
//                            smallIndex++;
//                            continue;
//                        }
//                        else
//                        {
//                            //Small and Big Array Element are the smallest
//                            finalArray[index] = smallArray[smallIndex];
//                            index++;
//                            smallIndex++;
//                            finalArray[index] = bigArray[bigIndex];
//                            bigIndex++;
//                            continue;
//                        }
//                    }
//                    else
//                    {
//                        //Small and Mid Array elements are equal.
//                        if (smallArray[smallIndex] > bigArray[bigIndex])
//                        {
//                            //Big Array Element is the smallest
//                            finalArray[index] = bigArray[bigIndex];
//                            bigIndex++;
//                            continue;
//                        }
//                        else if (smallArray[smallIndex] < bigArray[bigIndex])
//                        {
//                            //Mid and Small Array Element are the smallest
//                            finalArray[index] = smallArray[smallIndex];
//                            index++;
//                            smallIndex++;
//                            finalArray[index] = midArray[midIndex];
//                            midIndex++;
//                            continue;
//                        }
//                        else
//                        {
//                            //All elements are equal
//                            finalArray[index] = smallArray[smallIndex];
//                            index++;
//                            smallIndex++;
//                            finalArray[index] = midArray[midIndex];
//                            midIndex++;
//                            finalArray[index] = bigArray[bigIndex];
//                            bigIndex++;
//                            continue;
//                        }
//                    }
//                }
//            }





//            label1.Text = string.Join(",", finalArray);
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
    public partial class Stack : Form
    {
        public Stack()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtArray1.Text = String.Empty;
            txtArray2.Text = String.Empty;
            txtLength.Text = String.Empty;
            txtResult.Text = String.Empty;
        }

        public StackList ConvertToStack(char[] array)
        {
            SNode node;
            StackList stack = new StackList();
            for (int index = 0; index < array.Length; index++)
            {
                node = new SNode();
                node.Val = array[index];
                stack.Push(node);
            }
            return stack;
        }

        public StackList ConvertCommaSeparatedToStack(string[] array)
        {
            StackList list = new StackList();
            for(int index = 0; index < array.Length; index++)
            {
                SNode snode = new SNode();
                snode.Value = Convert.ToInt32(array[index]);
                list.Push(snode);
            }
            return list;
        }

        public string[] ConvertStackToArray(StackList list)
        {
            string[] array = new string[list.Length];
            for (int index = array.Length - 1; index >= 0; index--)
            {
                SNode node = list.Pop();
                if(String.IsNullOrWhiteSpace(Convert.ToString(node.Val)))
                    array[index] = node.Val.ToString();
                else
                    array[index] = node.Value.ToString();
            }
            return array;
        }

        private void btnInfixToPostfix_Click(object sender, EventArgs e)
        {
            string expression = txtArray1.Text;
            char[] array = expression.ToCharArray();
            StackList stackList = new StackList();
            SNode node;
            char[] result = new char[array.Length];
            int rIndex = 0, index = 0;
            while (index < array.Length)
            {
                if (array[index] >= 'a' && array[index] <= 'z')
                {
                    result[rIndex] = array[index];
                    rIndex++;
                }
                else if (array[index] == '/' || array[index] == '*' || array[index] == '^'
                    || array[index] == '+' || array[index] == '-')
                {
                    node = new SNode();
                    node.Val = array[index];
                    if (stackList.Length == 0)
                    {
                        stackList.Push(node);
                    }
                    else
                    {
                        int diff = GetOperatorValue(node.Val) - GetOperatorValue(stackList.Peek().Val);
                        if (diff > 0)
                        {
                            stackList.Push(node);
                        }
                        else
                        {
                            result[rIndex] = stackList.Pop().Val;
                            rIndex++;
                            continue;
                        }
                    }
                }
                index++;
            }
            while (stackList.Length != 0)
            {
                result[rIndex] = stackList.Pop().Val;
                rIndex++;
            }
            txtResult.Text = string.Join("", result);
        }

        public int GetOperatorValue(char op)
        {
            switch (op)
            {
                case '-': return 1;
                case '+': return 2;
                case '*': return 3;
                case '/': return 4;
                case '^': return 5;
                default: return 0;
            }
        }

        private void btnEvalPostfix_Click(object sender, EventArgs e)
        {
            char[] array = txtArray1.Text.ToCharArray();
            //abc*+b-
            int index = 0, num, op1, op2;
            StackList list = new StackList();
            SNode node;
            bool isDigit;
            while (index < array.Length)
            {
                isDigit = int.TryParse(array[index].ToString(), out num);
                if (isDigit)
                {
                    node = new SNode();
                    node.Value = num;
                    list.Push(node);
                }
                else
                {
                    op1 = list.Pop().Value;
                    op2 = list.Pop().Value;
                    node = new SNode();
                    switch (array[index])
                    {
                        case '/':
                            node.Value = op2 / op1;
                            break;
                        case '*':
                            node.Value = op2 * op1;
                            break;
                        case '+':
                            node.Value = op2 + op1;
                            break;
                        case '-':
                            node.Value = op2 - op1;
                            break;
                        case '^':
                            node.Value = op2 ^ op1;
                            break;
                    }
                    list.Push(node);
                }
                index++;
            }
            txtResult.Text = Convert.ToString(list.Peek().Value);
        }

        private void btnNextGreater_Click(object sender, EventArgs e)
        {
            int[] array = SearchForm.ConvertToIntArray(txtArray1.Text.Split(','));
            //Find next greatest
            //2 4 3 88 1 23 43 22 31 45
            int[] result = NextGreatestList(array);
            txtResult.Text = String.Join(",", result);
        }

        public int[] NextGreatestList(int[] array)
        {
            int index = array.Length - 1;
            int[] result = new int[array.Length];
            int[] buffer = new int[2];
            while (index >= 0)
            {
                //2 7 4 11 8 33 12
                if (buffer[0] == 0)
                {
                    result[index] = -1;
                    buffer[0] = array[index];
                }
                else
                {
                    bool isGreatest = buffer[0] < array[index];
                    if (!isGreatest && buffer[1] > array[index])
                    {
                        result[index] = buffer[1];
                    }
                    else if (!isGreatest)
                    {
                        result[index] = buffer[0];
                        buffer[1] = array[index];
                    }
                    else if (isGreatest)
                    {
                        result[index] = -1;
                        buffer[0] = array[index];
                        buffer[1] = 0;
                    }
                }
                index--;
            }
            return result;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            StackList list = ConvertCommaSeparatedToStack(txtArray1.Text.Split(','));
            StackList resultList = ReverseStack(list, new StackList());
            txtResult.Text = String.Join(", ", ConvertStackToArray(resultList));
        }

        public StackList ReverseStack(StackList list, StackList resultList)
        {
            if (list.Length == 0)
                return resultList;
            resultList.Push(list.Pop());
            return ReverseStack(list, resultList);
        }
    }
}

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
    public partial class CustomListForm : Form
    {
        public CustomListForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtList1.Text = String.Empty;
            txtValue.Text = String.Empty;
            txtResult.Text = String.Empty;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string[] array = txtList1.Text.Split(',');
            CustomList list = CustomList.ConvertToCustomList(array, true);
            int index = Convert.ToInt32(txtIndex.Text);
            int value = Convert.ToInt32(txtValue.Text);

            if (list.Length < index)
            {
                txtResult.Text = "Length of List is less than index specified.";
                return;
            }

            list = InsertNode(list, value, index);
            int[] intArray = CustomList.ConvertIntegerListToArray(list);
            txtResult.Text = String.Join(", ", intArray);
        }

        public CustomList InsertNode(CustomList list, int value, int insertIndex)
        {
            int index = 0;
            LNode newNode = new LNode();
            newNode.IntegerData = value;
            if (insertIndex == 0)
            {
                list.Push(newNode);
                return list;
            }
            LNode node = list.First, previousNode=null;
            while (index < insertIndex)
            {
                previousNode = node;
                node = node.Next;
                index++;
            }
            list.InsertAfter(previousNode, newNode);
            return list;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] array = txtList1.Text.Split(',');
            CustomList list = CustomList.ConvertToCustomList(array, true);
            int deleteIndex = Convert.ToInt32(txtIndex.Text);

            if(deleteIndex >= list.Length)
            {
                txtResult.Text = "Length of List is less than index specified.";
                return;
            }

            bool isDeleted = DeleteNode(list, deleteIndex);
            if (!isDeleted)
            {
                txtResult.Text = "Node not deleted.";
                return;
            }

            int[] intArray = CustomList.ConvertIntegerListToArray(list);
            txtResult.Text = String.Join(", ", intArray);
        }

        public bool DeleteNode(CustomList list, int deleteIndex)
        {
            LNode node = list.First;
            int index = 0;
            while(index < deleteIndex)
            {
                node = node.Next;
                index++;
            }
            return list.DeleteNode(node);
        }
    }
}

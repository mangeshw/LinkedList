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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 lList;
            try
            {
                lList = new Form1();
                lList.ShowDialog();
            }
            finally
            {
                lList = null;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm;
            try
            {
                searchForm = new SearchForm();
                searchForm.ShowDialog();
            }
            finally
            {
                searchForm = null;
            }
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            ArrayForm arrayForm;
            try
            {
                arrayForm = new ArrayForm();
                arrayForm.ShowDialog();
            }
            finally
            {
                arrayForm = null;
            }
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            Stack stackForm;
            try
            {
                stackForm = new Stack();
                stackForm.ShowDialog();
            }
            finally
            {
                stackForm = null;
            }
        }

        private void btnCustomList_Click(object sender, EventArgs e)
        {
            CustomListForm customListForm;
            try
            {
                customListForm = new CustomListForm();
                customListForm.ShowDialog();
            }
            finally
            {
                customListForm = null;
            }
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            TreeForm treeForm;
            try
            {
                treeForm = new TreeForm();
                treeForm.ShowDialog();
            }
            finally
            {
                treeForm = null;
            }
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            GraphForm graphForm;
            try
            {
                graphForm = new GraphForm();
                graphForm.ShowDialog();
            }
            finally
            {
                graphForm = null;
            }
        }

        private void btnWeightedGraph_Click(object sender, EventArgs e)
        {
            WeightedGraphForm wGraphForm;
            try
            {
                wGraphForm = new WeightedGraphForm();
                wGraphForm.ShowDialog();
            }
            finally
            {
                wGraphForm = null;
            }
        }
    }
}

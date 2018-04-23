using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes.Operations;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraEditors;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            tbl.Columns.Add("ParentID", typeof(int));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i + 1, 3 - i, DateTime.Now.AddDays(i), i % 3 });
            return tbl;
        }
   

        public Form1()
        {
            InitializeComponent();
            treeList1.DataSource = CreateTable(30);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            treeList1.ExpandAll();
            PrintAllNodes(treeList1);
        }

        private void PrintAllNodes(DevExpress.XtraTreeList.TreeList treeList)
        {
            treeList.NodesIterator.DoLocalOperation(new PrintNodesOperation(listBoxControl1), treeList.Nodes);
        }
    }

    public class PrintNodesOperation : TreeListOperation
    {

        private ListBoxControl _ListBox;
        public PrintNodesOperation(ListBoxControl listBox)
        {
            _ListBox = listBox;
            
        }

        public override void Execute(DevExpress.XtraTreeList.Nodes.TreeListNode node)
        {
            PrintNode(node);
        }

        private void PrintNode(DevExpress.XtraTreeList.Nodes.TreeListNode node)
        {
            string nodeAsString = NodeToString(node);
            _ListBox.Items.Add(nodeAsString);
        }
        private string NodeToString(DevExpress.XtraTreeList.Nodes.TreeListNode node)
        {
            string res = string.Empty;
            string indent = "    ";
            for (int i = 0; i < node.Level; i++)
            {
                res += indent;
            }
            if (node.HasChildren)
                res += "+";
            else
                res += indent;
            res += "|";
            foreach (TreeListColumn col in node.TreeList.VisibleColumns)
            {
                res += String.Format("{0};", node.GetDisplayText(col));
            }
            res += "|" + Environment.NewLine;
            return res;
        }
    }
}
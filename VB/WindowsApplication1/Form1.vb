Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.Nodes.Operations
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			tbl.Columns.Add("ParentID", GetType(Integer))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i + 1, 3 - i, DateTime.Now.AddDays(i), i Mod 3 })
			Next i
			Return tbl
		End Function


		Public Sub New()
			InitializeComponent()
			treeList1.DataSource = CreateTable(30)
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			treeList1.ExpandAll()
			PrintAllNodes(treeList1)
		End Sub

		Private Sub PrintAllNodes(ByVal treeList As DevExpress.XtraTreeList.TreeList)
			treeList.NodesIterator.DoLocalOperation(New PrintNodesOperation(listBoxControl1), treeList.Nodes)
		End Sub
	End Class

	Public Class PrintNodesOperation
		Inherits TreeListOperation

		Private _ListBox As ListBoxControl
		Public Sub New(ByVal listBox As ListBoxControl)
			_ListBox = listBox

		End Sub

		Public Overrides Sub Execute(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode)
			PrintNode(node)
		End Sub

		Private Sub PrintNode(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode)
			Dim nodeAsString As String = NodeToString(node)
			_ListBox.Items.Add(nodeAsString)
		End Sub
		Private Function NodeToString(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode) As String
			Dim res As String = String.Empty
			Dim indent As String = "    "
			For i As Integer = 0 To node.Level - 1
				res &= indent
			Next i
			If node.HasChildren Then
				res &= "+"
			Else
				res &= indent
			End If
			res &= "|"
			For Each col As TreeListColumn In node.TreeList.VisibleColumns
				res &= String.Format("{0};", node.GetDisplayText(col))
			Next col
			res &= "|" & Environment.NewLine
			Return res
		End Function
	End Class
End Namespace
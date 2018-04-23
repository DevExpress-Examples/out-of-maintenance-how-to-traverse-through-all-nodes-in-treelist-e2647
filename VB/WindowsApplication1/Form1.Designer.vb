Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Left
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.Size = New System.Drawing.Size(365, 482)
			Me.treeList1.TabIndex = 0
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listBoxControl1.Location = New System.Drawing.Point(365, 0)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(325, 427)
			Me.listBoxControl1.TabIndex = 1
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.simpleButton1.Location = New System.Drawing.Point(365, 427)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(325, 55)
			Me.simpleButton1.TabIndex = 2
			Me.simpleButton1.Text = "Test"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(690, 482)
			Me.Controls.Add(Me.listBoxControl1)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace


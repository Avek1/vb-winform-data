<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CategoryToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.SourceToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BackToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ForwardToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DeleteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DiscontinuedCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductsListBox = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.CategoryToolStripComboBox, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.SourceToolStripComboBox, Me.ToolStripSeparator2, Me.BackToolStripButton, Me.ForwardToolStripButton, Me.ToolStripSeparator3, Me.AddToolStripButton, Me.DeleteToolStripButton, Me.ToolStripSeparator4, Me.SaveToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1052, 28)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(72, 25)
        Me.ToolStripLabel1.Text = "Category:"
        '
        'CategoryToolStripComboBox
        '
        Me.CategoryToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryToolStripComboBox.Name = "CategoryToolStripComboBox"
        Me.CategoryToolStripComboBox.Size = New System.Drawing.Size(121, 28)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(57, 25)
        Me.ToolStripLabel2.Text = "Source:"
        '
        'SourceToolStripComboBox
        '
        Me.SourceToolStripComboBox.Items.AddRange(New Object() {"Objects", "DataSet"})
        Me.SourceToolStripComboBox.Name = "SourceToolStripComboBox"
        Me.SourceToolStripComboBox.Size = New System.Drawing.Size(121, 28)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'BackToolStripButton
        '
        Me.BackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackToolStripButton.Image = CType(resources.GetObject("BackToolStripButton.Image"), System.Drawing.Image)
        Me.BackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BackToolStripButton.Name = "BackToolStripButton"
        Me.BackToolStripButton.Size = New System.Drawing.Size(24, 25)
        Me.BackToolStripButton.Text = "BackToolStripButton"
        '
        'ForwardToolStripButton
        '
        Me.ForwardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ForwardToolStripButton.Image = CType(resources.GetObject("ForwardToolStripButton.Image"), System.Drawing.Image)
        Me.ForwardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ForwardToolStripButton.Name = "ForwardToolStripButton"
        Me.ForwardToolStripButton.Size = New System.Drawing.Size(24, 25)
        Me.ForwardToolStripButton.Text = "ForwardToolStripButton"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 28)
        '
        'AddToolStripButton
        '
        Me.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddToolStripButton.Image = CType(resources.GetObject("AddToolStripButton.Image"), System.Drawing.Image)
        Me.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddToolStripButton.Name = "AddToolStripButton"
        Me.AddToolStripButton.Size = New System.Drawing.Size(24, 25)
        Me.AddToolStripButton.Text = "AddToolStripButton"
        '
        'DeleteToolStripButton
        '
        Me.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteToolStripButton.Image = CType(resources.GetObject("DeleteToolStripButton.Image"), System.Drawing.Image)
        Me.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteToolStripButton.Name = "DeleteToolStripButton"
        Me.DeleteToolStripButton.Size = New System.Drawing.Size(24, 25)
        Me.DeleteToolStripButton.Text = "DeleteToolStripButton"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 28)
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(24, 25)
        Me.SaveToolStripButton.Text = "SaveToolStripButton"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1052, 685)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.DiscontinuedCheckBox)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.OrderTextBox)
        Me.TabPage1.Controls.Add(Me.QuantityTextBox)
        Me.TabPage1.Controls.Add(Me.StockTextBox)
        Me.TabPage1.Controls.Add(Me.PriceTextBox)
        Me.TabPage1.Controls.Add(Me.NameTextBox)
        Me.TabPage1.Controls.Add(Me.ProductsListBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1044, 656)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Form"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(394, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Discontinued"
        '
        'DiscontinuedCheckBox
        '
        Me.DiscontinuedCheckBox.AutoSize = True
        Me.DiscontinuedCheckBox.Location = New System.Drawing.Point(513, 241)
        Me.DiscontinuedCheckBox.Name = "DiscontinuedCheckBox"
        Me.DiscontinuedCheckBox.Size = New System.Drawing.Size(100, 21)
        Me.DiscontinuedCheckBox.TabIndex = 12
        Me.DiscontinuedCheckBox.Text = "CheckBox1"
        Me.DiscontinuedCheckBox.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(394, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Units on Order"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(394, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Quantity Per Unit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(394, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Units in Stock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(394, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Unit Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(394, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name"
        '
        'OrderTextBox
        '
        Me.OrderTextBox.Location = New System.Drawing.Point(513, 212)
        Me.OrderTextBox.Name = "OrderTextBox"
        Me.OrderTextBox.Size = New System.Drawing.Size(205, 22)
        Me.OrderTextBox.TabIndex = 6
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(513, 93)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(205, 22)
        Me.QuantityTextBox.TabIndex = 5
        '
        'StockTextBox
        '
        Me.StockTextBox.Location = New System.Drawing.Point(513, 176)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(205, 22)
        Me.StockTextBox.TabIndex = 4
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(513, 134)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(205, 22)
        Me.PriceTextBox.TabIndex = 3
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(513, 52)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(205, 22)
        Me.NameTextBox.TabIndex = 2
        '
        'ProductsListBox
        '
        Me.ProductsListBox.FormattingEnabled = True
        Me.ProductsListBox.ItemHeight = 16
        Me.ProductsListBox.Location = New System.Drawing.Point(36, 57)
        Me.ProductsListBox.Name = "ProductsListBox"
        Me.ProductsListBox.Size = New System.Drawing.Size(341, 324)
        Me.ProductsListBox.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ProductsDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1044, 656)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Grid"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ProductsDataGridView
        '
        Me.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductsDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ProductsDataGridView.Name = "ProductsDataGridView"
        Me.ProductsDataGridView.RowTemplate.Height = 24
        Me.ProductsDataGridView.Size = New System.Drawing.Size(1038, 650)
        Me.ProductsDataGridView.TabIndex = 0
        '
        'DataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 713)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DataForm"
        Me.Text = "Data Binding"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ProductsDataGridView As DataGridView
    Friend WithEvents ProductsListBox As ListBox
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents CategoryToolStripComboBox As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents SourceToolStripComboBox As ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BackToolStripButton As ToolStripButton
    Friend WithEvents ForwardToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents AddToolStripButton As ToolStripButton
    Friend WithEvents DeleteToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents Label6 As Label
    Friend WithEvents DiscontinuedCheckBox As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OrderTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
End Class

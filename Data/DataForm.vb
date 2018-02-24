Public Class DataForm
    Private _source As New ObjectSource()
    Private _catagoriesbindingsource As New BindingSource()
    Private _productsbindingsource As New BindingSource()

    Private Sub DataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _catagoriesbindingsource.DataSource = _source.GetCategories()
        CategoryToolStripComboBox.ComboBox.DisplayMember = "CategoryName"
        CategoryToolStripComboBox.ComboBox.ValueMember = "CategoryID"
        CategoryToolStripComboBox.ComboBox.DataSource = _catagoriesbindingsource

        ProductsDataGridView.DataSource = _productsbindingsource
        ProductsListBox.DataSource = _productsbindingsource
        ProductsListBox.DisplayMember = "ProductName"

        NameTextBox.DataBindings.Clear()
        NameTextBox.DataBindings.Add("Text", _productsbindingsource, "ProductName")
        QuantityTextBox.DataBindings.Add("Text", _productsbindingsource, "QuantityPerUnit")
        PriceTextBox.DataBindings.Add("Text", _productsbindingsource, "UnitPrice")
        StockTextBox.DataBindings.Add("Text", _productsbindingsource, "UnitsInStock")
        OrderTextBox.DataBindings.Add("Text", _productsbindingsource, "UnitsOnOrder")
        DiscontinuedCheckBox.DataBindings.Add("Checked", _productsbindingsource, "Discontinued")

    End Sub

    Private Sub CategoriesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryToolStripComboBox.SelectedIndexChanged
        Dim catId = CategoryToolStripComboBox.ComboBox.SelectedValue
        _productsbindingsource.DataSource = _source.GetProducts(catId)

    End Sub

    Private Sub AddToolStripButton_Click(sender As Object, e As EventArgs) Handles AddToolStripButton.Click
        Dim category = CType(CategoryToolStripComboBox.SelectedItem, Category)
        Dim form As New AddProductForm(category)
        Dim result = form.ShowDialog()

        If result = DialogResult.OK Then
            '_source.AddProduct(form.Product)
            _productsbindingsource.Add(form.Product)
        End If
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As Object, e As EventArgs) Handles DeleteToolStripButton.Click
        Dim product = CType(ProductsListBox.SelectedItem, Product)
        '_source.DeleteProduct(product)
        _productsbindingsource.Remove(product)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        _productsbindingsource.MovePrevious()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        _productsbindingsource.MoveNext()
    End Sub
End Class

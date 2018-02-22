Public Class DataForm
    Private _source As New ObjectSource()
    'Private _catagoriesBindingSource As New BindingSource()
    'Private _productsBindingSource As New BindingSource()

    Private Sub DataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '_catagoriesBindingSource.DataSource = _source.GetCategories()
        CategoryToolStripComboBox.ComboBox.DisplayMember = "CategoryName"
        CategoryToolStripComboBox.ComboBox.ValueMember = "CategoryID"
        'CategoryToolStripComboBox.ComboBox.DataSource = _catagoriesBindingSource
        CategoryToolStripComboBox.ComboBox.DataSource = _source.GetCategories()

    End Sub

    Private Sub CategoriesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryToolStripComboBox.SelectedIndexChanged
        Dim catId = CategoryToolStripComboBox.ComboBox.SelectedValue
        Dim products = _source.GetProducts(catId)

        ProductsDataGridView.DataSource = products
        ProductsListBox.DataSource = products
        ProductsListBox.DisplayMember = "ProductName"

        NameTextBox.DataBindings.Clear()
        NameTextBox.DataBindings.Add("Text", products, "ProductName")
        QuantityTextBox.DataBindings.Clear()
        QuantityTextBox.DataBindings.Add("Text", products, "QuantityPerUnit")
        PriceTextBox.DataBindings.Clear()
        PriceTextBox.DataBindings.Add("Text", products, "UnitPrice")
        StockTextBox.DataBindings.Clear()
        StockTextBox.DataBindings.Add("Text", products, "UnitsInStock")
        OrderTextBox.DataBindings.Clear()
        OrderTextBox.DataBindings.Add("Text", products, "UnitsOnOrder")
        DiscontinuedCheckBox.DataBindings.Clear()
        DiscontinuedCheckBox.DataBindings.Add("Checked", products, "Discontinued")

    End Sub


End Class

Public Class DataForm
    Private _source As New ObjectSource()
    Private _catagoriesBindingSource As New BindingSource()
    Private _productsBindingSource As New BindingSource()

    Private Sub DataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _catagoriesBindingSource.DataSource = _source.GetCategories()

        CategoriesComboBox.DisplayMember = "CategoryName"
        CategoriesComboBox.ValueMember = "CategoryID"
        CategoriesComboBox.DataSource = _catagoriesBindingSource

    End Sub
    ' COMPLEX BINDING
    'Private Sub CategoriesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoriesComboBox.SelectedIndexChanged
    '    Dim catId = CategoriesComboBox.SelectedValue
    '    ProductsListBox.DataSource = _source.GetProducts(catId)
    '    ProductsListBox.DisplayMember = "ProductName"
    'End Sub

    ' SIMPLE BINDING
    Private Sub CategoriesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoriesComboBox.SelectedIndexChanged, CategoriesComboBox2.SelectedIndexChanged
        Dim catId = CategoriesComboBox.SelectedValue
        Dim products = _source.GetProducts(catId)

        ProductsDataGridView.DataSource = products
        ProductsListBox.DataSource = products
        ProductsListBox.DisplayMember = "ProductName"

        NameTextBox.DataBindings.Clear()
        NameTextBox.DataBindings.Add("Text", products, "ProductName")
        PriceTextBox.DataBindings.Clear()

        PriceTextBox.DataBindings.Add("Text", products, "UnitPrice")
        StockTextBox.DataBindings.Clear()
        StockTextBox.DataBindings.Add("Text", products, "UnitsInStock")
    End Sub


End Class

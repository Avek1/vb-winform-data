Public Class DataForm
    Private _source As New ObjectSource()
    Private _catagoriesbindingsource As New BindingSource()
    Private _productsbindingsource As New BindingSource()

    Private _currentSource As ISource
    Private _objectSource As ObjectSource
    Private _dataSetSource As DataSetSource

    Private Sub DataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SourceToolStripComboBox.SelectedIndex = 0
        SetSource()
        BindCategories()


        _catagoriesbindingsource.DataSource = _source.GetCategories()
        CategoryToolStripComboBox.ComboBox.DisplayMember = "CategoryName"
        CategoryToolStripComboBox.ComboBox.ValueMember = "CategoryID"
        CategoryToolStripComboBox.ComboBox.DataSource = _catagoriesbindingsource

        ProductsDataGridView.DataSource = _productsbindingsource
        ProductsListBox.DisplayMember = "ProductName"
        ProductsListBox.ValueMember = "ProductID"
        ProductsListBox.DataSource = _productsbindingsource

        NameTextBox.DataBindings.Clear()
        NameTextBox.DataBindings.Add("Text", _productsbindingsource, "ProductName")
        QuantityTextBox.DataBindings.Add("Text", _productsbindingsource, "QuantityPerUnit")
        PriceTextBox.DataBindings.Add("Text", _productsbindingsource, "UnitPrice")
        StockTextBox.DataBindings.Add("Text", _productsbindingsource, "UnitsInStock")
        OrderTextBox.DataBindings.Add("Text", _productsbindingsource, "UnitsOnOrder")
        DiscontinuedCheckBox.DataBindings.Add("Checked", _productsbindingsource, "Discontinued")

    End Sub

    Private Sub CategoriesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryToolStripComboBox.SelectedIndexChanged
        'Dim catId = CategoryToolStripComboBox.ComboBox.SelectedValue
        '_productsbindingsource.DataSource = _source.GetProducts(catId)
        BindProducts()

    End Sub

    Private Sub AddToolStripButton_Click(sender As Object, e As EventArgs) Handles AddToolStripButton.Click
        Dim id = CategoryToolStripComboBox.ComboBox.SelectedValue
        Dim name = CategoryToolStripComboBox.Text
        Dim category As New Category(id, name)

        Dim form As New AddProductForm(category)
        Dim result = form.ShowDialog()

        If result = DialogResult.OK Then
            _currentSource.AddProduct(_productsbindingsource, form.Product)
        End If
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As Object, e As EventArgs) Handles DeleteToolStripButton.Click
        Dim productId = ProductsListBox.SelectedValue
        _currentSource.DeleteProduct(_productsbindingsource, productId)
    End Sub


    Private Sub BackToolStripButton_Click(sender As Object, e As EventArgs) Handles BackToolStripButton.Click
        _productsbindingsource.MovePrevious()
    End Sub

    Private Sub ForwardToolStripButton_Click(sender As Object, e As EventArgs) Handles ForwardToolStripButton.Click
        _productsbindingsource.MoveNext()
    End Sub

    Private Sub SourceToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SourceToolStripComboBox.SelectedIndexChanged
        SetSource()
        BindCategories()
        BindProducts()
    End Sub

    Private Sub SetSource()
        Select Case SourceToolStripComboBox.SelectedIndex
            Case 0
                If _objectSource Is Nothing Then
                    _objectSource = New ObjectSource()
                End If
                _currentSource = _objectSource
            Case 1
                If _dataSetSource Is Nothing Then
                    _dataSetSource = New DataSetSource()
                End If
                _currentSource = _dataSetSource
        End Select
    End Sub

    Private Sub BindCategories()
        _catagoriesbindingsource.DataSource = _currentSource.GetCategories()
    End Sub

    Private Sub BindProducts()
        Dim catId = CategoryToolStripComboBox.ComboBox.SelectedValue
        _productsbindingsource.DataSource = _currentSource.GetProducts(catId)
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        _currentSource.Save()
    End Sub


End Class

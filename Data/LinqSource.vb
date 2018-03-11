Imports Data

Public Class LinqSource
    Implements ISource

    Private _context As New NorthwindDataContext()

    Public Function GetCategories() As Object Implements ISource.GetCategories
        Return _context.LinqCategories()
    End Function

    Public Function GetProducts(categoryId As Integer) As Object Implements ISource.GetProducts
        Dim query = From p In _context.LinqProducts
                    Where p.CategoryID = categoryId
                    Select p

        Return query
    End Function

    Public Sub AddProduct(bindingSource As BindingSource, product As Product) Implements ISource.AddProduct
        Throw New NotImplementedException()
    End Sub

    Public Sub DeleteProduct(bindingSource As BindingSource, productId As Integer) Implements ISource.DeleteProduct
        Throw New NotImplementedException()
    End Sub

    Public Sub Save() Implements ISource.Save
        Throw New NotImplementedException()
    End Sub


End Class

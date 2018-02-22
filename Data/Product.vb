Public Class Product
    Public Property ProductId As Integer
    Public Property ProductName As String
    Public Property CategoryId As Integer
    Public Property QuantityPerUnit As String
    Public Property UnitPrice As Decimal
    Public Property UnitsInStock As Integer
    Public Property UnitsOnOrder As Integer
    Public Property Discontinued As Boolean

    Public Sub New(id As Integer, name As String, categoryId As Integer, quantityPerUnit As String, unitPrice As Decimal, unitsInStock As Integer, unitsOnOrder As Integer, discontinued As Boolean)
        Me.ProductId = id
        Me.ProductName = name
        Me.CategoryId = categoryId
        Me.QuantityPerUnit = quantityPerUnit
        Me.UnitPrice = unitPrice
        Me.UnitsInStock = unitsInStock
        Me.UnitsOnOrder = unitsOnOrder
        Me.Discontinued = discontinued
    End Sub
End Class

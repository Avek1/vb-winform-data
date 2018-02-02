Public Class Category
    Public Property CategoryId As Integer
    Public Property CategoryName As String

    Public Sub New(id As Integer, name As String)
        Me.CategoryId = id
        Me.CategoryName = name
    End Sub
End Class

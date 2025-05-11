Imports FakeShop.Common
Imports FakeShop.EntityLayer

Public Class ProductViewModel
    Inherits ViewModelBase

    Sub New()
        LoadProduct(1)
    End Sub

    Public Property Entity As Product

    Function LoadProduct(ByVal productId As Integer) As Product
        Return LoadProduct(productId, Nothing)
    End Function

    Function LoadProduct(ByVal productId As Integer, ByVal startingFilePath As String) As Product
        ' Hard-coded entity
        Entity = New Product() With {
            .ProductId = 1,
            .Name = "Wireless Mouse",
            .Description = "Ergonomic wireless mouse with adjustable DPI.",
            .Sku = "WM-1001",
            .Price = 24.99D,
            .StockQuantity = 150
        }

        Return Entity
    End Function
End Class

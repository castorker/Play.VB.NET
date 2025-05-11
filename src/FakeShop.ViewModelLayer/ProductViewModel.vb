Imports System.Collections.ObjectModel
Imports FakeShop.Common
Imports FakeShop.DataLayer
Imports FakeShop.EntityLayer

Public Class ProductViewModel
    Inherits ViewModelBase

    Sub New()
        LoadProducts()
        LoadProduct(500)
    End Sub

    Public Property Products As ObservableCollection(Of Product)
    Public Property Entity As Product

    ' ObservableCollection
    ' This collection raises an event to inform any
    ' bound controls to re-read the data when it changes
    Function LoadProducts() As ObservableCollection(Of Product)
        Return LoadProducts(Nothing)
    End Function

    Function LoadProducts(ByVal startingFilePath As String) As ObservableCollection(Of Product)
        ' Create a new instance of the product manager class
        Dim mgr = New ProductManager

        Products = mgr.LoadProducts(startingFilePath)

        Return Products
    End Function

    Function LoadProduct(ByVal productId As Integer) As Product
        Return LoadProduct(productId, Nothing)
    End Function

    Function LoadProduct(ByVal productId As Integer, ByVal startingFilePath As String) As Product
        ' Create a new instance of the product manager class
        Dim mgr = New ProductManager

        Entity = mgr.LoadProduct(productId, startingFilePath)

        ' Inform UI that the Entity property changed
        RaisePropertyChanged("Entity")

        Return Entity
    End Function

    'Function LoadProduct(ByVal productId As Integer, ByVal startingFilePath As String) As Product
    '    ' Hard-coded entity
    '    Entity = New Product() With {
    '        .ProductId = 1,
    '        .Name = "Wireless Mouse",
    '        .Description = "Ergonomic wireless mouse with adjustable DPI.",
    '        .Sku = "WM-1001",
    '        .Price = 24.99D,
    '        .StockQuantity = 150
    '    }

    '    Return Entity
    'End Function
End Class

Imports System.Collections.ObjectModel
Imports System.Configuration
Imports FakeShop.Common
Imports FakeShop.EntityLayer

' A "manager" class is responsible for making calls
' to the database, or other data repository
Public Class ProductManager
    Inherits DataManagerBase

    Function LoadProducts() As ObservableCollection(Of Product)
        Return LoadProducts(Nothing)
    End Function

    Function LoadProducts(ByVal startingFilePath As String) As ObservableCollection(Of Product)
        ' Create a new instance of products
        Dim ret = New ObservableCollection(Of Product)()

        Try
            ' Attempt to read from XML file
            ' The ConfigurationManager class reads key/value pairs
            ' from App.config or Web.config file.
            Dim doc = MyBase.LoadXElement(
                ConfigurationManager.AppSettings("ProductsFile"),
                startingFilePath)

            Dim products = From prod In doc.<Product>
                           Select New Product With {
                             .ProductId = Convert.ToInt32(prod.Element("ProductId").Value),
                             .Name = prod.Element("Name").Value,
                             .Description = prod.Element("Description").Value,
                             .Sku = prod.Element("Sku").Value,
                             .Price = Convert.ToDecimal(prod.Element("Price").Value),
                             .StockQuantity = Convert.ToInt32(prod.Element("StockQuantity").Value)
                           }

            ret = New ObservableCollection(Of Product)(products.ToList())

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.ToString())
        End Try

        Return ret
    End Function

    Function LoadProduct(ByVal productId As Integer) As Product
        Return LoadProduct(productId, Nothing)
    End Function

    Function LoadProduct(ByVal productId As Integer, ByVal startingFilePath As String) As Product
        ' Create a new instance of a product
        Dim ret = New Product()

        Try
            Dim list = LoadProducts(startingFilePath)

            If list IsNot Nothing Then
                If list.Count > 0 Then
                    ret = list.FirstOrDefault(Function(p) p.ProductId = productId)
                End If
            End If

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.ToString())
        End Try

        Return ret
    End Function
End Class

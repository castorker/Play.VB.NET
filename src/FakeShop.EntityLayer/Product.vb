Imports System.Text
Imports FakeShop.Common

Public Class Product
    Inherits CommonBase

    ' Constructor
    Public Sub New()
        MyBase.New()

    End Sub

    Public Sub New(ByVal productId As Integer, ByVal name As String,
                   ByVal description As String, ByVal sku As String,
                   ByVal price As Decimal, ByVal stockQuantity As Integer)
        MyBase.New()

        Me.ProductId = productId
        Me.Name = name
        Me.Description = description
        Me.Sku = sku
        Me.Price = price
        Me.StockQuantity = stockQuantity
    End Sub

    Public Property ProductId As Integer
    Public Property Name As String
    Public Property Description As String
    Public Property Sku As String
    Public Property Price As Decimal
    Public Property StockQuantity As Integer

    ' Override ToString() for easy debugging
    Public Overrides Function ToString() As String
        Return MyBase.ToString()

        'Return $"Product [ProductId={ProductId}, Name={Name}, 
        '    Description={Description}, Sku={Sku}, 
        '    Price={Price}, StockQuantity={StockQuantity}]"
    End Function

    Protected Overrides Function GetClassData() As String
        Dim sb As New StringBuilder(1024)

        sb.AppendLine("ProductId: " + ProductId.ToString())
        sb.AppendLine("Name: " + Name)
        sb.AppendLine("Description: " + Description)
        sb.AppendLine("SKU: " + Sku)
        sb.Append(MyBase.GetClassData())

        Return sb.ToString()
    End Function
End Class

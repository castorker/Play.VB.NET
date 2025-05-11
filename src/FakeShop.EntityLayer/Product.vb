Public Class Product
    ' Constructor
    Public Sub New(ByVal productId As Integer, ByVal name As String,
                   ByVal description As String, ByVal sku As String,
                   ByVal price As Decimal, ByVal stockQuantity As Integer)
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
        Return $"Product [ProductId={ProductId}, Name={Name}, 
            Description={Description}, Sku={Sku}, 
            Price={Price}, StockQuantity={StockQuantity}]"
    End Function
End Class

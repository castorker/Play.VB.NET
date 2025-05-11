Public Class Customer
    ' Constructor
    Public Sub New(ByVal customerId As Integer,
                   ByVal name As String, ByVal email As String,
                   ByVal address As String, ByVal phoneNumber As String)
        Me.CustomerId = customerId
        Me.Name = name
        Me.Email = email
        Me.Address = address
        Me.PhoneNumber = phoneNumber
    End Sub

    Public Property CustomerId As Integer
    Public Property Name As String
    Public Property Email As String
    Public Property Address As String
    Public Property PhoneNumber As String

    ' Override ToString() for easy debugging
    Public Overrides Function ToString() As String
        Return $"Customer [CustomerId={CustomerId}, Name={Name}, 
            Email={Email}, Address={Address}, PhoneNumber={PhoneNumber}]"
    End Function
End Class

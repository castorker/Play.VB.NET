Imports System.Text
Imports FakeShop.Common

Public Class Customer
    Inherits CommonBase

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
        Return MyBase.ToString()

        'Return $"Customer [CustomerId={CustomerId}, Name={Name}, 
        '    Email={Email}, Address={Address}, PhoneNumber={PhoneNumber}]"
    End Function

    Protected Overrides Function GetClassData() As String
        Dim sb As New StringBuilder(1024)

        sb.AppendLine("Customer ID: " + CustomerId.ToString())
        sb.AppendLine("Name: " + Name)
        sb.AppendLine("Email: " + Email)
        sb.AppendLine("Address: " + Address)
        sb.AppendLine("PhoneNumber: " + PhoneNumber)
        sb.Append(MyBase.GetClassData())

        Return sb.ToString()
    End Function
End Class

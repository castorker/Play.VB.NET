Imports FakeShop.Common
Imports FakeShop.EntityLayer

Public Class CustomerViewModel
    Inherits ViewModelBase

    Sub New()
        LoadCustomer(1)
    End Sub

    Public Property Entity As Customer

    Function LoadCustomer(ByVal customerId As Integer) As Customer
        ' Hard-code an entity
        Entity = New Customer With {
            .CustomerId = 1,
            .Name = "Alice Johnson",
            .Email = "alice.johnson@example.com",
            .Address = "123 Maple Street, Lisbon",
            .PhoneNumber = "+351 912345678"
        }

        Return Entity
    End Function
End Class

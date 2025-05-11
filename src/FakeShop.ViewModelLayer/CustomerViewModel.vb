Imports System.Collections.ObjectModel
Imports FakeShop.Common
Imports FakeShop.DataLayer
Imports FakeShop.EntityLayer

Public Class CustomerViewModel
    Inherits ViewModelBase

    Sub New()
        LoadCustomers()
        LoadCustomer(6)
    End Sub

    Public Property Customers As ObservableCollection(Of Customer)

    Public Property Entity As Customer

    Function LoadCustomers(ByVal Optional startingFilePath As String = "") As ObservableCollection(Of Customer)
        ' Create a new instance of customer manager
        Dim mgr = New CustomerManager

        Customers = mgr.LoadCustomers(startingFilePath)

        Return Customers
    End Function

    Function LoadCustomer(ByVal customerId As Integer, ByVal Optional startingFilePath As String = "") As Customer
        ' Create a new instance of customer manager
        Dim mgr = New CustomerManager

        Entity = mgr.LoadCustomer(customerId, startingFilePath)

        ' Inform UI that the Entity property changed
        RaisePropertyChanged("Entity")

        Return Entity
    End Function

    'Function LoadCustomer(ByVal customerId As Integer) As Customer
    '    ' Hard-coded an entity
    '    Entity = New Customer With {
    '        .CustomerId = 1,
    '        .Name = "Alice Johnson",
    '        .Email = "alice.johnson@example.com",
    '        .Address = "123 Maple Street, Lisbon",
    '        .PhoneNumber = "+351 912345678"
    '    }

    '    Return Entity
    'End Function
End Class

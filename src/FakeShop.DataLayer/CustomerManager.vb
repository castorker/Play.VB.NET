Imports System.Collections.ObjectModel
Imports System.Configuration
Imports FakeShop.Common
Imports FakeShop.EntityLayer

Public Class CustomerManager
    Inherits DataManagerBase

    Function LoadCustomers() As ObservableCollection(Of Customer)
        Return LoadCustomers(Nothing)
    End Function

    Function LoadCustomers(ByVal startingFilePath As String) As ObservableCollection(Of Customer)
        ' Create a new instance of customers
        Dim ret = New ObservableCollection(Of Customer)()

        Try
            ' Attempt to read from XML file
            Dim doc = MyBase.LoadXElement(
                ConfigurationManager.AppSettings("CustomersFile"),
            startingFilePath)

            Dim customers = From cust In doc.<Customer>
                            Select New Customer With {
                                .CustomerId = Convert.ToInt32(cust.Element("CustomerId").Value),
                                .Name = cust.Element("Name").Value,
                                .Email = cust.Element("Email").Value,
                                .Address = cust.Element("Address").Value,
                                .PhoneNumber = cust.Element("PhoneNumber").Value
                            }

            ret = New ObservableCollection(Of Customer)(customers.ToList())

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.ToString())
        End Try

        Return ret
    End Function

    Function LoadCustomer(ByVal customerId As Integer) As Customer
        Return LoadCustomer(customerId, Nothing)
    End Function

    Function LoadCustomer(ByVal customerId As Integer, ByVal startingFilePath As String) As Customer
        ' Create a new instance of a customer
        Dim ret = New Customer()

        Try
            Dim list = LoadCustomers(startingFilePath)

            If list IsNot Nothing Then
                If list.Count > 0 Then
                    ret = list.FirstOrDefault(Function(c) c.CustomerId = customerId)
                End If
            End If

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.ToString())
        End Try

        Return ret
    End Function
End Class

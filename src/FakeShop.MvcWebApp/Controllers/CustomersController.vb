Imports FakeShop.ViewModelLayer

Namespace Controllers
    Public Class CustomersController
        Inherits Controller

        ' GET: Customers
        Function CustomerList() As ActionResult
            Dim vm As New CustomerViewModel

            vm.LoadCustomers(Server.MapPath("/"))

            Return View(vm)
        End Function

        Function CustomerDetail(ByVal id As Integer) As ActionResult
            Dim vm As New CustomerViewModel

            vm.LoadCustomer(id, Server.MapPath("/"))

            Return View(vm)
        End Function
    End Class
End Namespace
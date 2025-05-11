Imports FakeShop.ViewModelLayer

Namespace Controllers
    Public Class ProductsController
        Inherits Controller

        ' GET: Products
        Function ProductList() As ActionResult
            Dim vm As New ProductViewModel

            vm.LoadProducts(Server.MapPath("/"))

            Return View(vm)
        End Function

        Function ProductDetail(ByVal id As Integer) As ActionResult
            Dim vm As New ProductViewModel

            vm.LoadProduct(id, Server.MapPath("/"))

            Return View(vm)
        End Function
    End Class
End Namespace
@ModelType FakeShop.ViewModelLayer.ProductViewModel

@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Products"
End Code

<table class="table table-bordered table-striped">
    <thead>
        <tr>
            <th>Product ID</th>
            <th>Product Name</th>
            <th>Product Description</th>
            <th>Stock Keeping Unit</th>
            <th>Stock Quantity</th>
            <th>Price</th>
        </tr>
    </thead>

    @For Each product In Model.Products
        @<tbody>
            <tr>
                <td>@product.ProductId</td>
                <td>@Html.ActionLink(product.Name, "ProductDetail",
                                      New With {.id = product.ProductId})</td>
                <td>@product.Description</td>
                <td>@product.Sku</td>
                <td>@product.StockQuantity</td>
                <td>@product.Price</td>
            </tr>
        </tbody>

    Next
</table>
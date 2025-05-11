@ModelType FakeShop.ViewModelLayer.CustomerViewModel

@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Customers"
End Code

<table class="table table-bordered table-striped">
    <thead>
        <tr>
            <th>Customer ID</th>
            <th>Customer Name</th>
            <th>Customer Email</th>
            <th>Customer Address</th>
            <th>Customer Phone Number</th>
        </tr>
    </thead>

    @For Each customer In Model.Customers
        @<tbody>
            <tr>
                <td>@customer.CustomerId</td>
                <td>@Html.ActionLink(customer.Name, "CustomerDetail", New With {.id = customer.CustomerId})</td>
                <td>@customer.Email</td>
                <td>@customer.Address</td>
                <td>@customer.PhoneNumber</td>
            </tr>
        </tbody>
    Next
</table>

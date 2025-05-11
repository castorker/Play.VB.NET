@ModelType FakeShop.ViewModelLayer.ProductViewModel

@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Product Detail"
End Code

<div class="row">
    <div class="col-sm-3">Product ID</div>
    <div class="col-sm-9">@Model.Entity.ProductId</div>
</div>
<div class="row">
    <div class="col-sm-3">Product Name</div>
    <div class="col-sm-9">@Model.Entity.Name</div>
</div>
<div class="row">
    <div class="col-sm-3">Product Description</div>
    <div class="col-sm-9">@Model.Entity.Description</div>
</div>
<div class="row">
    <div class="col-sm-3">Stock Keeping Unit</div>
    <div class="col-sm-9">@Model.Entity.Sku</div>
</div>
<div class="row">
    <div class="col-sm-3">Stock Quantity</div>
    <div class="col-sm-6">@Model.Entity.StockQuantity</div>
</div>
<div class="row">
    <div class="col-sm-3">Price</div>
    <div class="col-sm-9">@Model.Entity.Price</div>
</div>
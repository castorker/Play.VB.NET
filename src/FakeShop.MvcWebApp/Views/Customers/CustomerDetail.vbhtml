@ModelType FakeShop.ViewModelLayer.CustomerViewModel

@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Customer Detail"
End Code

<div class="row">
    <div class="col-sm-3">Customer ID</div>
    <div class="col-sm-9">@Model.Entity.CustomerId</div>
</div>
<div class="row">
    <div class="col-sm-3">Customer Name</div>
    <div class="col-sm-9">@Model.Entity.Name</div>
</div>
<div class="row">
    <div class="col-sm-3">Customer Email</div>
    <div class="col-sm-9">@Model.Entity.Email</div>
</div>
<div class="row">
    <div class="col-sm-3">Customer Address</div>
    <div class="col-sm-9">@Model.Entity.Address</div>
</div>
<div class="row">
    <div class="col-sm-3">Customer Phone Number</div>
    <div class="col-sm-9">@Model.Entity.PhoneNumber</div>
</div>
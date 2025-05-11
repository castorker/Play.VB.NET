# Play.VB.NET - FakeShop application

## Playing with VB.NET

* .NET Framework 4.8.1
* Visual Studio 2022
* C#
* XML

* Class Library (.NET Framework)
* WPF App (.NET Framework)
* ASP.NET Web Application (.NET Framework)

```mermaid
---
title: Product Entity
---
classDiagram
	class Product {
		+ProductId : Integer
		+Name : String
		+Description : String
		+Sku : String
		+Price : Decimal
		+StockQuantity : Integer
	}
```

```mermaid
---
title: Customer Entity
---
classDiagram
	class Customer {
		+CustomerId : Integer
		+Name : String
		+Email : String
		+Address : String
		+PhoneNumber : String
	}
```
if db_id(N'MagazaOptimizasyonu') is null
begin
    create database [MagazaOptimizasyonu];
end
go

use [MagazaOptimizasyonu];
go

set nocount on;
set xact_abort on;
go

begin transaction;

create table dbo.Roles
(
    RoleId tinyint identity(1, 1) not null,
    RoleName nvarchar(30) not null,
    constraint PK_Roles primary key clustered (RoleId),
    constraint UQ_Roles_RoleName unique (RoleName)
);

create table dbo.Categories
(
    CategoryId smallint identity(1, 1) not null,
    CategoryName nvarchar(50) not null,
    constraint PK_Categories primary key clustered (CategoryId),
    constraint UQ_Categories_CategoryName unique (CategoryName)
);

create table dbo.Brands
(
    BrandId smallint identity(1, 1) not null,
    BrandName nvarchar(80) not null,
    constraint PK_Brands primary key clustered (BrandId),
    constraint UQ_Brands_BrandName unique (BrandName)
);

create table dbo.Colors
(
    ColorId tinyint identity(1, 1) not null,
    ColorName nvarchar(30) not null,
    constraint PK_Colors primary key clustered (ColorId),
    constraint UQ_Colors_ColorName unique (ColorName)
);

create table dbo.Sizes
(
    SizeId tinyint identity(1, 1) not null,
    SizeName nvarchar(10) not null,
    constraint PK_Sizes primary key clustered (SizeId),
    constraint UQ_Sizes_SizeName unique (SizeName)
);

create table dbo.PaymentTypes
(
    PaymentTypeId tinyint identity(1, 1) not null,
    PaymentTypeName nvarchar(30) not null,
    constraint PK_PaymentTypes primary key clustered (PaymentTypeId),
    constraint UQ_PaymentTypes_PaymentTypeName unique (PaymentTypeName)
);

create table dbo.Customers
(
    CustomerId int identity(1, 1) not null,
    FirstName nvarchar(50) not null,
    LastName nvarchar(50) not null,
    Phone varchar(20) null,
    Email nvarchar(150) null,
    CreatedDate datetime2(7) not null constraint DF_Customers_CreatedDate default (sysdatetime()),
    constraint PK_Customers primary key clustered (CustomerId)
);

create table dbo.Users
(
    UserId int identity(1, 1) not null,
    UserName nvarchar(50) not null,
    PasswordHash nvarchar(255) not null,
    FirstName nvarchar(50) not null,
    LastName nvarchar(50) not null,
    RoleId tinyint null,
    IsActive bit not null constraint DF_Users_IsActive default ((1)),
    constraint PK_Users primary key clustered (UserId),
    constraint UQ_Users_UserName unique (UserName),
    constraint FK_Users_Roles foreign key (RoleId) references dbo.Roles (RoleId)
);

create table dbo.Products
(
    ProductId int identity(1, 1) not null,
    ProductName nvarchar(100) not null,
    CategoryId smallint not null,
    BrandId smallint null,
    Price decimal(10, 2) not null,
    Description nvarchar(500) null,
    IsActive bit not null constraint DF_Products_IsActive default ((1)),
    constraint PK_Products primary key clustered (ProductId),
    constraint CK_Products_Price check (Price >= 0),
    constraint FK_Products_Categories foreign key (CategoryId) references dbo.Categories (CategoryId),
    constraint FK_Products_Brands foreign key (BrandId) references dbo.Brands (BrandId)
);

create table dbo.ProductVariants
(
    VariantId int identity(1, 1) not null,
    ProductId int null,
    ColorId tinyint null,
    SizeId tinyint null,
    StockQuantity smallint null,
    constraint PK_ProductVariants primary key clustered (VariantId),
    constraint CK_ProductVariants_StockQuantity check (StockQuantity >= 0),
    constraint UQ_ProductVariants_Product_Color_Size unique (ProductId, ColorId, SizeId),
    constraint FK_ProductVariants_Products foreign key (ProductId) references dbo.Products (ProductId),
    constraint FK_ProductVariants_Colors foreign key (ColorId) references dbo.Colors (ColorId),
    constraint FK_ProductVariants_Sizes foreign key (SizeId) references dbo.Sizes (SizeId)
);

create table dbo.Sales
(
    SaleId int identity(1, 1) not null,
    CustomerId int null,
    UserId int null,
    PaymentTypeId tinyint null,
    SaleDate datetime2(7) not null constraint DF_Sales_SaleDate default (sysdatetime()),
    TotalAmount decimal(12, 2) not null,
    constraint PK_Sales primary key clustered (SaleId),
    constraint CK_Sales_TotalAmount check (TotalAmount >= 0),
    constraint FK_Sales_Customers foreign key (CustomerId) references dbo.Customers (CustomerId),
    constraint FK_Sales_Users foreign key (UserId) references dbo.Users (UserId),
    constraint FK_Sales_PaymentTypes foreign key (PaymentTypeId) references dbo.PaymentTypes (PaymentTypeId)
);

create table dbo.SaleDetails
(
    SaleDetailId int identity(1, 1) not null,
    SaleId int null,
    VariantId int null,
    Quantity smallint null,
    UnitPrice decimal(10, 2) null,
    Subtotal decimal(12, 2) null,
    constraint PK_SaleDetails primary key clustered (SaleDetailId),
    constraint CK_SaleDetails_Quantity check (Quantity > 0),
    constraint CK_SaleDetails_UnitPrice check (UnitPrice >= 0),
    constraint CK_SaleDetails_Subtotal check (Subtotal >= 0),
    constraint FK_SaleDetails_Sales foreign key (SaleId) references dbo.Sales (SaleId),
    constraint FK_SaleDetails_ProductVariants foreign key (VariantId) references dbo.ProductVariants (VariantId)
);

insert into dbo.Roles (RoleName)
select N'Yönetici'
where not exists (select 1 from dbo.Roles where RoleName = N'Yönetici');

insert into dbo.Roles (RoleName)
select N'Kasiyer'
where not exists (select 1 from dbo.Roles where RoleName = N'Kasiyer');

insert into dbo.PaymentTypes (PaymentTypeName)
select N'Nakit'
where not exists (select 1 from dbo.PaymentTypes where PaymentTypeName = N'Nakit');

insert into dbo.PaymentTypes (PaymentTypeName)
select N'Kredi Kartı'
where not exists (select 1 from dbo.PaymentTypes where PaymentTypeName = N'Kredi Kartı');

insert into dbo.PaymentTypes (PaymentTypeName)
select N'Banka Kartı'
where not exists (select 1 from dbo.PaymentTypes where PaymentTypeName = N'Banka Kartı');

commit transaction;
go

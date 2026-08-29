use [MagazaOptimizasyonu];
go

set nocount on;
set xact_abort on;
go

begin transaction;

declare @DemoDate date = convert(date, sysdatetime());
declare @DemoSaleDate datetime2(7) = dateadd(hour, 10, convert(datetime2(7), @DemoDate));

if not exists (select 1 from dbo.Categories where CategoryName = N'Giyim')
    insert into dbo.Categories (CategoryName) values (N'Giyim');

if not exists (select 1 from dbo.Categories where CategoryName = N'Ayakkabı')
    insert into dbo.Categories (CategoryName) values (N'Ayakkabı');

if not exists (select 1 from dbo.Brands where BrandName = N'Mavi')
    insert into dbo.Brands (BrandName) values (N'Mavi');

if not exists (select 1 from dbo.Brands where BrandName = N'Koton')
    insert into dbo.Brands (BrandName) values (N'Koton');

if not exists (select 1 from dbo.Brands where BrandName = N'Adidas')
    insert into dbo.Brands (BrandName) values (N'Adidas');

if not exists (select 1 from dbo.Colors where ColorName = N'Mavi')
    insert into dbo.Colors (ColorName) values (N'Mavi');

if not exists (select 1 from dbo.Colors where ColorName = N'Siyah')
    insert into dbo.Colors (ColorName) values (N'Siyah');

if not exists (select 1 from dbo.Colors where ColorName = N'Beyaz')
    insert into dbo.Colors (ColorName) values (N'Beyaz');

if not exists (select 1 from dbo.Sizes where SizeName = N'M')
    insert into dbo.Sizes (SizeName) values (N'M');

if not exists (select 1 from dbo.Sizes where SizeName = N'L')
    insert into dbo.Sizes (SizeName) values (N'L');

if not exists (select 1 from dbo.Sizes where SizeName = N'42')
    insert into dbo.Sizes (SizeName) values (N'42');

if not exists (select 1 from dbo.PaymentTypes where PaymentTypeName = N'Nakit')
    insert into dbo.PaymentTypes (PaymentTypeName) values (N'Nakit');

if not exists (select 1 from dbo.PaymentTypes where PaymentTypeName = N'Kredi Kartı')
    insert into dbo.PaymentTypes (PaymentTypeName) values (N'Kredi Kartı');

declare @AdminRoleId tinyint;
declare @CashierRoleId tinyint;
declare @CashPaymentTypeId tinyint;
declare @CardPaymentTypeId tinyint;

select @AdminRoleId = RoleId from dbo.Roles where RoleName = N'Yönetici';
select @CashierRoleId = RoleId from dbo.Roles where RoleName = N'Kasiyer';
select @CashPaymentTypeId = PaymentTypeId from dbo.PaymentTypes where PaymentTypeName = N'Nakit';
select @CardPaymentTypeId = PaymentTypeId from dbo.PaymentTypes where PaymentTypeName = N'Kredi Kartı';

if not exists (select 1 from dbo.Users where UserName = N'demo.admin')
    insert into dbo.Users (UserName, PasswordHash, FirstName, LastName, RoleId, IsActive)
    values
    (
        N'demo.admin',
        N'zCLSWfmRo95SCC+NDmN4tw==:JM5XAc3bihqBpRBCBs5tZKQkaFohU/zZrTMkMB+pukU=',
        N'Demo',
        N'Yönetici',
        @AdminRoleId,
        1
    );

if not exists (select 1 from dbo.Users where UserName = N'demo.cashier')
    insert into dbo.Users (UserName, PasswordHash, FirstName, LastName, RoleId, IsActive)
    values
    (
        N'demo.cashier',
        N'ZT1kshebWGyV+QWTPQ/AAQ==:t1Y4h5yW20tywJrlXeva0vZewl/IbtRY3U+Q3Vs4Q1M=',
        N'Demo',
        N'Kasiyer',
        @CashierRoleId,
        1
    );

declare @AdminUserId int;
declare @CashierUserId int;

select @AdminUserId = UserId from dbo.Users where UserName = N'demo.admin';
select @CashierUserId = UserId from dbo.Users where UserName = N'demo.cashier';

if not exists (select 1 from dbo.Customers where Email = N'deniz.kaya@example.com')
    insert into dbo.Customers (FirstName, LastName, Phone, Email)
    values (N'Deniz', N'Kaya', N'+90 555 000 0001', N'deniz.kaya@example.com');

if not exists (select 1 from dbo.Customers where Email = N'mert.yilmaz@example.com')
    insert into dbo.Customers (FirstName, LastName, Phone, Email)
    values (N'Mert', N'Yılmaz', N'+90 555 000 0002', N'mert.yilmaz@example.com');

declare @CustomerOneId int;
declare @CustomerTwoId int;

select @CustomerOneId = CustomerId from dbo.Customers where Email = N'deniz.kaya@example.com';
select @CustomerTwoId = CustomerId from dbo.Customers where Email = N'mert.yilmaz@example.com';

declare @ClothingCategoryId smallint;
declare @ShoesCategoryId smallint;
declare @MaviBrandId smallint;
declare @KotonBrandId smallint;
declare @AdidasBrandId smallint;
declare @BlueColorId tinyint;
declare @BlackColorId tinyint;
declare @WhiteColorId tinyint;
declare @MediumSizeId tinyint;
declare @LargeSizeId tinyint;
declare @Size42Id tinyint;

select @ClothingCategoryId = CategoryId from dbo.Categories where CategoryName = N'Giyim';
select @ShoesCategoryId = CategoryId from dbo.Categories where CategoryName = N'Ayakkabı';
select @MaviBrandId = BrandId from dbo.Brands where BrandName = N'Mavi';
select @KotonBrandId = BrandId from dbo.Brands where BrandName = N'Koton';
select @AdidasBrandId = BrandId from dbo.Brands where BrandName = N'Adidas';
select @BlueColorId = ColorId from dbo.Colors where ColorName = N'Mavi';
select @BlackColorId = ColorId from dbo.Colors where ColorName = N'Siyah';
select @WhiteColorId = ColorId from dbo.Colors where ColorName = N'Beyaz';
select @MediumSizeId = SizeId from dbo.Sizes where SizeName = N'M';
select @LargeSizeId = SizeId from dbo.Sizes where SizeName = N'L';
select @Size42Id = SizeId from dbo.Sizes where SizeName = N'42';

if not exists (select 1 from dbo.Products where ProductName = N'Basic Tişört')
    insert into dbo.Products (ProductName, CategoryId, BrandId, Price, Description, IsActive)
    values (N'Basic Tişört', @ClothingCategoryId, @MaviBrandId, 599.90, N'Günlük kullanıma uygun pamuklu tişört.', 1);

if not exists (select 1 from dbo.Products where ProductName = N'Slim Pantolon')
    insert into dbo.Products (ProductName, CategoryId, BrandId, Price, Description, IsActive)
    values (N'Slim Pantolon', @ClothingCategoryId, @KotonBrandId, 899.90, N'Slim kesim günlük pantolon.', 1);

if not exists (select 1 from dbo.Products where ProductName = N'Spor Ayakkabı')
    insert into dbo.Products (ProductName, CategoryId, BrandId, Price, Description, IsActive)
    values (N'Spor Ayakkabı', @ShoesCategoryId, @AdidasBrandId, 1499.90, N'Günlük kullanım için spor ayakkabı.', 1);

declare @TshirtProductId int;
declare @PantsProductId int;
declare @ShoesProductId int;

select @TshirtProductId = ProductId from dbo.Products where ProductName = N'Basic Tişört';
select @PantsProductId = ProductId from dbo.Products where ProductName = N'Slim Pantolon';
select @ShoesProductId = ProductId from dbo.Products where ProductName = N'Spor Ayakkabı';

if not exists
(
    select 1
    from dbo.ProductVariants
    where ProductId = @TshirtProductId and ColorId = @BlueColorId and SizeId = @MediumSizeId
)
    insert into dbo.ProductVariants (ProductId, ColorId, SizeId, StockQuantity)
    values (@TshirtProductId, @BlueColorId, @MediumSizeId, 20);

if not exists
(
    select 1
    from dbo.ProductVariants
    where ProductId = @TshirtProductId and ColorId = @BlackColorId and SizeId = @LargeSizeId
)
    insert into dbo.ProductVariants (ProductId, ColorId, SizeId, StockQuantity)
    values (@TshirtProductId, @BlackColorId, @LargeSizeId, 12);

if not exists
(
    select 1
    from dbo.ProductVariants
    where ProductId = @PantsProductId and ColorId = @BlackColorId and SizeId = @MediumSizeId
)
    insert into dbo.ProductVariants (ProductId, ColorId, SizeId, StockQuantity)
    values (@PantsProductId, @BlackColorId, @MediumSizeId, 10);

if not exists
(
    select 1
    from dbo.ProductVariants
    where ProductId = @ShoesProductId and ColorId = @WhiteColorId and SizeId = @Size42Id
)
    insert into dbo.ProductVariants (ProductId, ColorId, SizeId, StockQuantity)
    values (@ShoesProductId, @WhiteColorId, @Size42Id, 8);

declare @TshirtVariantId int;
declare @PantsVariantId int;
declare @ShoesVariantId int;

select @TshirtVariantId = VariantId
from dbo.ProductVariants
where ProductId = @TshirtProductId and ColorId = @BlueColorId and SizeId = @MediumSizeId;

select @PantsVariantId = VariantId
from dbo.ProductVariants
where ProductId = @PantsProductId and ColorId = @BlackColorId and SizeId = @MediumSizeId;

select @ShoesVariantId = VariantId
from dbo.ProductVariants
where ProductId = @ShoesProductId and ColorId = @WhiteColorId and SizeId = @Size42Id;

declare @SaleId int;

select @SaleId = SaleId
from dbo.Sales
where CustomerId = @CustomerOneId
  and UserId = @AdminUserId
  and PaymentTypeId = @CashPaymentTypeId
  and TotalAmount = 2099.70
  and convert(date, SaleDate) = @DemoDate;

if @SaleId is null
begin
    insert into dbo.Sales (CustomerId, UserId, PaymentTypeId, SaleDate, TotalAmount)
    values (@CustomerOneId, @AdminUserId, @CashPaymentTypeId, @DemoSaleDate, 2099.70);

    set @SaleId = convert(int, scope_identity());

    insert into dbo.SaleDetails (SaleId, VariantId, Quantity, UnitPrice, Subtotal)
    values
        (@SaleId, @TshirtVariantId, 2, 599.90, 1199.80),
        (@SaleId, @PantsVariantId, 1, 899.90, 899.90);
end;

set @SaleId = null;

select @SaleId = SaleId
from dbo.Sales
where CustomerId = @CustomerTwoId
  and UserId = @CashierUserId
  and PaymentTypeId = @CardPaymentTypeId
  and TotalAmount = 1499.90
  and convert(date, SaleDate) = @DemoDate;

if @SaleId is null
begin
    insert into dbo.Sales (CustomerId, UserId, PaymentTypeId, SaleDate, TotalAmount)
    values (@CustomerTwoId, @CashierUserId, @CardPaymentTypeId, @DemoSaleDate, 1499.90);

    set @SaleId = convert(int, scope_identity());

    insert into dbo.SaleDetails (SaleId, VariantId, Quantity, UnitPrice, Subtotal)
    values (@SaleId, @ShoesVariantId, 1, 1499.90, 1499.90);
end;

commit transaction;
go

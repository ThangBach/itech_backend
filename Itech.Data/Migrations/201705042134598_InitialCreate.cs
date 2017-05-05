namespace Itech.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 8000, unicode: false),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        StackTrace = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MemberCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 30),
                        PassWord = c.String(nullable: false, maxLength: 30),
                        Address = c.String(nullable: false),
                        BirthDay = c.String(),
                        Gender = c.String(),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(),
                        Status = c.Boolean(nullable: false),
                        MemberCategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MemberCategories", t => t.MemberCategoryID, cascadeDelete: true)
                .Index(t => t.MemberCategoryID);
            
            CreateTable(
                "dbo.MenuGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        URL = c.String(nullable: false),
                        DisplayOrder = c.Int(),
                        Target = c.String(),
                        Status = c.Boolean(nullable: false),
                        GroupMenuID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MenuGroups", t => t.GroupMenuID, cascadeDelete: true)
                .Index(t => t.GroupMenuID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quanlity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ProductID })
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 50),
                        CustomerEmail = c.String(nullable: false, maxLength: 30),
                        CustomerAddress = c.String(nullable: false, maxLength: 500),
                        CustomerMobile = c.String(nullable: false),
                        CustomerMessage = c.String(),
                        OrderDate = c.DateTime(nullable: false),
                        OrderDeliveryDate = c.DateTime(nullable: false),
                        PaymentMethod = c.String(),
                        PaymentStatus = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                        Description = c.String(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                        Image = c.String(nullable: false),
                        MoreImages = c.String(),
                        Price = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateBy = c.String(),
                        UpdateDate = c.DateTime(),
                        HomeFlag = c.Boolean(),
                        HotFlag = c.Boolean(),
                        ViewCount = c.Int(nullable: false),
                        Quanlity = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        BrandID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Brands", t => t.BrandID, cascadeDelete: true)
                .ForeignKey("dbo.ProductCategories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID)
                .Index(t => t.BrandID);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                        Description = c.String(),
                        ParentID = c.Int(),
                        DisplayOrder = c.Int(),
                        Image = c.String(),
                        Status = c.Boolean(nullable: false),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateBy = c.String(),
                        UpdateDate = c.DateTime(),
                        HomeFlag = c.Boolean(),
                        ViewCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PromotionDetails",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        PromotionID = c.Int(nullable: false),
                        Percent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductID, t.PromotionID })
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Promotions", t => t.PromotionID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.PromotionID);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 500),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Image = c.String(),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rates",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        MemberId = c.Int(nullable: false),
                        RateDate = c.DateTime(nullable: false),
                        RateNumber = c.Int(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => new { t.ProductId, t.MemberId })
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.SupportOnlines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Department = c.String(maxLength: 50),
                        Skype = c.String(maxLength: 50),
                        Mobile = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Yahoo = c.String(maxLength: 50),
                        Facebook = c.String(maxLength: 50),
                        Status = c.Boolean(nullable: false),
                        DisplayOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SystemConfigs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50, unicode: false),
                        ValueString = c.String(maxLength: 50),
                        ValueInt = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VisitorStatistics",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        VisitedDate = c.DateTime(nullable: false),
                        IPAddress = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rates", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Rates", "MemberId", "dbo.Members");
            DropForeignKey("dbo.PromotionDetails", "PromotionID", "dbo.Promotions");
            DropForeignKey("dbo.PromotionDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.ProductCategories");
            DropForeignKey("dbo.Products", "BrandID", "dbo.Brands");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Menus", "GroupMenuID", "dbo.MenuGroups");
            DropForeignKey("dbo.Members", "MemberCategoryID", "dbo.MemberCategories");
            DropIndex("dbo.Rates", new[] { "MemberId" });
            DropIndex("dbo.Rates", new[] { "ProductId" });
            DropIndex("dbo.PromotionDetails", new[] { "PromotionID" });
            DropIndex("dbo.PromotionDetails", new[] { "ProductID" });
            DropIndex("dbo.Products", new[] { "BrandID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.Menus", new[] { "GroupMenuID" });
            DropIndex("dbo.Members", new[] { "MemberCategoryID" });
            DropTable("dbo.VisitorStatistics");
            DropTable("dbo.SystemConfigs");
            DropTable("dbo.SupportOnlines");
            DropTable("dbo.Rates");
            DropTable("dbo.Promotions");
            DropTable("dbo.PromotionDetails");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Menus");
            DropTable("dbo.MenuGroups");
            DropTable("dbo.Members");
            DropTable("dbo.MemberCategories");
            DropTable("dbo.Footers");
            DropTable("dbo.Errors");
            DropTable("dbo.Brands");
        }
    }
}

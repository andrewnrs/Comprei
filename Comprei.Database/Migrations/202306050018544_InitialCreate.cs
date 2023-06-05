namespace Comprei.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Zipcode = c.String(maxLength: 12),
                        Street = c.String(),
                        District = c.String(),
                        Number = c.String(),
                        City = c.String(),
                        State = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        ModificationTime = c.DateTime(),
                        Deleted = c.Boolean(nullable: false),
                        DeletionTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 120),
                        Login = c.String(maxLength: 120),
                        Password = c.String(maxLength: 36),
                        Picture = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        ModificationTime = c.DateTime(),
                        Deleted = c.Boolean(nullable: false),
                        DeletionTime = c.DateTime(),
                        House_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Houses", t => t.House_Id)
                .Index(t => t.House_Id);
            
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nickname = c.String(maxLength: 40),
                        CreationTime = c.DateTime(nullable: false),
                        ModificationTime = c.DateTime(),
                        Deleted = c.Boolean(nullable: false),
                        DeletionTime = c.DateTime(),
                        Address_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
            CreateTable(
                "dbo.HouseStorages",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Observation = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        ModificationTime = c.DateTime(),
                        Deleted = c.Boolean(nullable: false),
                        DeletionTime = c.DateTime(),
                        House_Id = c.Long(),
                        Product_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Houses", t => t.House_Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.House_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 120),
                        Description = c.String(),
                        Barcode = c.Long(),
                        Picture = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        ModificationTime = c.DateTime(),
                        Deleted = c.Boolean(nullable: false),
                        DeletionTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShoppingLists",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        ModificationTime = c.DateTime(),
                        Deleted = c.Boolean(nullable: false),
                        DeletionTime = c.DateTime(),
                        Customer_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.ShoppingProducts",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DesiredAmount = c.Int(nullable: false),
                        Observation = c.String(),
                        Bought = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        ModificationTime = c.DateTime(),
                        Deleted = c.Boolean(nullable: false),
                        DeletionTime = c.DateTime(),
                        Product_Id = c.Long(),
                        ShoppingList_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.ShoppingLists", t => t.ShoppingList_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.ShoppingList_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingProducts", "ShoppingList_Id", "dbo.ShoppingLists");
            DropForeignKey("dbo.ShoppingProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ShoppingLists", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.HouseStorages", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.HouseStorages", "House_Id", "dbo.Houses");
            DropForeignKey("dbo.Customers", "House_Id", "dbo.Houses");
            DropForeignKey("dbo.Houses", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.ShoppingProducts", new[] { "ShoppingList_Id" });
            DropIndex("dbo.ShoppingProducts", new[] { "Product_Id" });
            DropIndex("dbo.ShoppingLists", new[] { "Customer_Id" });
            DropIndex("dbo.HouseStorages", new[] { "Product_Id" });
            DropIndex("dbo.HouseStorages", new[] { "House_Id" });
            DropIndex("dbo.Houses", new[] { "Address_Id" });
            DropIndex("dbo.Customers", new[] { "House_Id" });
            DropTable("dbo.ShoppingProducts");
            DropTable("dbo.ShoppingLists");
            DropTable("dbo.Products");
            DropTable("dbo.HouseStorages");
            DropTable("dbo.Houses");
            DropTable("dbo.Customers");
            DropTable("dbo.Addresses");
        }
    }
}

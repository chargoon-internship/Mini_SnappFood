namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initializing : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalPrice = c.Double(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        NatioalCode = c.String(),
                        HomeAddress = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Description = c.String(),
                        Time = c.DateTime(nullable: false),
                        FinalPrice = c.Double(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                        CartItem_Id = c.Int(nullable: false),
                        Restaurant_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CartItems", t => t.CartItem_Id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: false)
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_Id, cascadeDelete: false)
                .Index(t => t.Customer_Id)
                .Index(t => t.CartItem_Id)
                .Index(t => t.Restaurant_Id);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                        BeginDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Exist = c.Boolean(nullable: false),
                        Price = c.Double(nullable: false),
                        Restaurant_Id = c.Int(nullable: false),
                        CartItem_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CartItems", t => t.CartItem_Id, cascadeDelete: true)
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_Id, cascadeDelete: true)
                .Index(t => t.Restaurant_Id)
                .Index(t => t.CartItem_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CartItems", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Customers", "Id", "dbo.Users");
            DropForeignKey("dbo.Invoices", "Restaurant_Id", "dbo.Restaurants");
            DropForeignKey("dbo.Restaurants", "Id", "dbo.Users");
            DropForeignKey("dbo.Foods", "Restaurant_Id", "dbo.Restaurants");
            DropForeignKey("dbo.Foods", "CartItem_Id", "dbo.CartItems");
            DropForeignKey("dbo.Invoices", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Invoices", "CartItem_Id", "dbo.CartItems");
            DropIndex("dbo.Foods", new[] { "CartItem_Id" });
            DropIndex("dbo.Foods", new[] { "Restaurant_Id" });
            DropIndex("dbo.Restaurants", new[] { "Id" });
            DropIndex("dbo.Invoices", new[] { "Restaurant_Id" });
            DropIndex("dbo.Invoices", new[] { "CartItem_Id" });
            DropIndex("dbo.Invoices", new[] { "Customer_Id" });
            DropIndex("dbo.Customers", new[] { "Id" });
            DropIndex("dbo.CartItems", new[] { "Customer_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Foods");
            DropTable("dbo.Restaurants");
            DropTable("dbo.Invoices");
            DropTable("dbo.Customers");
            DropTable("dbo.CartItems");
        }
    }
}

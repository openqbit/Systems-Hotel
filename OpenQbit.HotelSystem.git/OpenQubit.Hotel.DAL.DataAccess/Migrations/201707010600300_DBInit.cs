namespace OpenQubit.Hotel.DAL.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Person", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        JobTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.JobType", t => t.JobTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Person", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId)
                .Index(t => t.JobTypeId);
            
            CreateTable(
                "dbo.JobType",
                c => new
                    {
                        JobTypeId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.JobTypeId);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        ItemID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Category = c.String(),
                        Description = c.String(),
                        ItemTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemID)
                .ForeignKey("dbo.ItemType", t => t.ItemTypeId, cascadeDelete: true)
                .Index(t => t.ItemTypeId);
            
            CreateTable(
                "dbo.ItemPrice",
                c => new
                    {
                        ItemPriceId = c.Int(nullable: false, identity: true),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(),
                        Price = c.Double(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemPriceId)
                .ForeignKey("dbo.Item", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.ItemType",
                c => new
                    {
                        ItemTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ItemTypeId);
            
            CreateTable(
                "dbo.KitchenOrder",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        OrderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        OrderTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Item", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.OrderType", t => t.OrderTypeID, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.OrderTypeID);
            
            CreateTable(
                "dbo.OrderType",
                c => new
                    {
                        OrderTypeId = c.Int(nullable: false, identity: true),
                        OrderName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.OrderTypeId);
            
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        OrderDetailID = c.Int(nullable: false, identity: true),
                        ItemPriceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderDetailID)
                .ForeignKey("dbo.ItemPrice", t => t.ItemPriceID, cascadeDelete: true)
                .Index(t => t.ItemPriceID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetail", "ItemPriceID", "dbo.ItemPrice");
            DropForeignKey("dbo.Order", "OrderTypeID", "dbo.OrderType");
            DropForeignKey("dbo.Order", "ItemId", "dbo.Item");
            DropForeignKey("dbo.Item", "ItemTypeId", "dbo.ItemType");
            DropForeignKey("dbo.ItemPrice", "ItemId", "dbo.Item");
            DropForeignKey("dbo.Employee", "PersonId", "dbo.Person");
            DropForeignKey("dbo.Employee", "JobTypeId", "dbo.JobType");
            DropForeignKey("dbo.Customer", "PersonId", "dbo.Person");
            DropIndex("dbo.OrderDetail", new[] { "ItemPriceID" });
            DropIndex("dbo.Order", new[] { "OrderTypeID" });
            DropIndex("dbo.Order", new[] { "ItemId" });
            DropIndex("dbo.ItemPrice", new[] { "ItemId" });
            DropIndex("dbo.Item", new[] { "ItemTypeId" });
            DropIndex("dbo.Employee", new[] { "JobTypeId" });
            DropIndex("dbo.Employee", new[] { "PersonId" });
            DropIndex("dbo.Customer", new[] { "PersonId" });
            DropTable("dbo.OrderDetail");
            DropTable("dbo.OrderType");
            DropTable("dbo.Order");
            DropTable("dbo.KitchenOrder");
            DropTable("dbo.ItemType");
            DropTable("dbo.ItemPrice");
            DropTable("dbo.Item");
            DropTable("dbo.JobType");
            DropTable("dbo.Employee");
            DropTable("dbo.Person");
            DropTable("dbo.Customer");
        }
    }
}

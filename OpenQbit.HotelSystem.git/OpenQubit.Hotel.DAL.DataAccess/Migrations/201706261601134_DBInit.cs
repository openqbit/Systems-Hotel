namespace OpenQubit.Hotel.DAL.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBInit : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Item", newName: "Order");
            DropForeignKey("dbo.ItemPrice", "ItemId", "dbo.Item");
            DropIndex("dbo.Order", new[] { "ItemTypeId" });
            DropPrimaryKey("dbo.Order");
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
                .Index(t => t.ItemTypeId);
            
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
            
            AddColumn("dbo.Order", "OrderID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Order", "OrderTypeID", c => c.Int(nullable: false));
            AlterColumn("dbo.Order", "ItemId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Order", "OrderID");
            CreateIndex("dbo.Order", "ItemId");
            CreateIndex("dbo.Order", "OrderTypeID");
            AddForeignKey("dbo.Order", "ItemId", "dbo.Item", "ItemID", cascadeDelete: true);
            AddForeignKey("dbo.Order", "OrderTypeID", "dbo.OrderType", "OrderTypeId", cascadeDelete: true);
            DropColumn("dbo.Order", "Name");
            DropColumn("dbo.Order", "Category");
            DropColumn("dbo.Order", "Description");
            DropColumn("dbo.Order", "ItemTypeId");
            DropColumn("dbo.Order", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Order", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Order", "ItemTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Order", "Description", c => c.String());
            AddColumn("dbo.Order", "Category", c => c.String());
            AddColumn("dbo.Order", "Name", c => c.String());
            DropForeignKey("dbo.OrderDetail", "ItemPriceID", "dbo.ItemPrice");
            DropForeignKey("dbo.Order", "OrderTypeID", "dbo.OrderType");
            DropForeignKey("dbo.Order", "ItemId", "dbo.Item");
            DropIndex("dbo.OrderDetail", new[] { "ItemPriceID" });
            DropIndex("dbo.Order", new[] { "OrderTypeID" });
            DropIndex("dbo.Order", new[] { "ItemId" });
            DropIndex("dbo.Item", new[] { "ItemTypeId" });
            DropPrimaryKey("dbo.Order");
            AlterColumn("dbo.Order", "ItemId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Order", "OrderTypeID");
            DropColumn("dbo.Order", "OrderID");
            DropTable("dbo.OrderDetail");
            DropTable("dbo.OrderType");
            DropTable("dbo.Item");
            AddPrimaryKey("dbo.Order", "ItemID");
            CreateIndex("dbo.Order", "ItemTypeId");
            AddForeignKey("dbo.ItemPrice", "ItemId", "dbo.Item", "ItemID", cascadeDelete: true);
            RenameTable(name: "dbo.Order", newName: "Item");
        }
    }
}

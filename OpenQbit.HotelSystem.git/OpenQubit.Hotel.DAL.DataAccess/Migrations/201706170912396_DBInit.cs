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
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ItemID)
                .ForeignKey("dbo.ItemType", t => t.ItemTypeId, cascadeDelete: true)
                .Index(t => t.ItemTypeId);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemPrice", "ItemId", "dbo.Item");
            DropForeignKey("dbo.Item", "ItemTypeId", "dbo.ItemType");
            DropForeignKey("dbo.Employee", "PersonId", "dbo.Person");
            DropForeignKey("dbo.Employee", "JobTypeId", "dbo.JobType");
            DropForeignKey("dbo.Customer", "PersonId", "dbo.Person");
            DropIndex("dbo.ItemPrice", new[] { "ItemId" });
            DropIndex("dbo.Item", new[] { "ItemTypeId" });
            DropIndex("dbo.Employee", new[] { "JobTypeId" });
            DropIndex("dbo.Employee", new[] { "PersonId" });
            DropIndex("dbo.Customer", new[] { "PersonId" });
            DropTable("dbo.ItemPrice");
            DropTable("dbo.ItemType");
            DropTable("dbo.Item");
            DropTable("dbo.JobType");
            DropTable("dbo.Employee");
            DropTable("dbo.Person");
            DropTable("dbo.Customer");
        }
    }
}

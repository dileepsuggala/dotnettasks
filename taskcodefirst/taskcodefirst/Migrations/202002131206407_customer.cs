namespace taskcodefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.customer",
                c => new
                    {
                        Cid = c.Int(nullable: false, identity: true),
                        Cname = c.String(),
                    })
                .PrimaryKey(t => t.Cid);
            
            CreateTable(
                "dbo.product",
                c => new
                    {
                        Pid = c.Int(nullable: false, identity: true),
                        Pname = c.String(maxLength: 250),
                        Price = c.Double(nullable: false),
                        customer_Cid = c.Int(),
                    })
                .PrimaryKey(t => t.Pid)
                .ForeignKey("dbo.customer", t => t.customer_Cid)
                .Index(t => t.customer_Cid);
            
            CreateTable(
                "dbo.purchase",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        Cid = c.Int(nullable: false),
                        Pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.customer", t => t.Cid, cascadeDelete: true)
                .ForeignKey("dbo.product", t => t.Pid, cascadeDelete: true)
                .Index(t => t.Cid)
                .Index(t => t.Pid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.product", "customer_Cid", "dbo.customer");
            DropForeignKey("dbo.purchase", "Pid", "dbo.product");
            DropForeignKey("dbo.purchase", "Cid", "dbo.customer");
            DropIndex("dbo.purchase", new[] { "Pid" });
            DropIndex("dbo.purchase", new[] { "Cid" });
            DropIndex("dbo.product", new[] { "customer_Cid" });
            DropTable("dbo.purchase");
            DropTable("dbo.product");
            DropTable("dbo.customer");
        }
    }
}

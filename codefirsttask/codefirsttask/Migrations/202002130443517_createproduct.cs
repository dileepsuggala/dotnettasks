namespace codefirsttask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createproduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.products",
                c => new
                    {
                        Pid = c.Int(nullable: false, identity: true),
                        Pname = c.String(),
                        Price = c.Double(nullable: false),
                        Cid = c.Int(),
                        Cname = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        product_Pid = c.Int(),
                    })
                .PrimaryKey(t => t.Pid)
                .ForeignKey("dbo.products", t => t.product_Pid)
                .Index(t => t.product_Pid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.products", "product_Pid", "dbo.products");
            DropIndex("dbo.products", new[] { "product_Pid" });
            DropTable("dbo.products");
        }
    }
}

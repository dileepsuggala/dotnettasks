namespace codefirsttask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createproduct1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.products", name: "product_Pid", newName: "customer_Pid");
            RenameIndex(table: "dbo.products", name: "IX_product_Pid", newName: "IX_customer_Pid");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.products", name: "IX_customer_Pid", newName: "IX_product_Pid");
            RenameColumn(table: "dbo.products", name: "customer_Pid", newName: "product_Pid");
        }
    }
}

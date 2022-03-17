namespace ExamWCD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.String());
            AlterColumn("dbo.Products", "UnitPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.Products", "UnitslnStock", c => c.Double(nullable: false));
            AlterColumn("dbo.Products", "UnitsOnOrder", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "UnitsOnOrder", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "UnitslnStock", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "UnitPrice", c => c.Int(nullable: false));
            AlterColumn("dbo.Categories", "CategoryName", c => c.Int(nullable: false));
        }
    }
}

namespace TheGalleryCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CuisineID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MealItems", "CuisineID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MealItems", "CuisineID");
        }
    }
}

namespace TheGalleryCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CuisineIDd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reservations", "CustomerName", c => c.String(nullable: false));
            AlterColumn("dbo.Reservations", "ContactNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reservations", "ContactNumber", c => c.String());
            AlterColumn("dbo.Reservations", "CustomerName", c => c.String());
        }
    }
}

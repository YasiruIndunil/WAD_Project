namespace TheGalleryCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialIdentitySetup2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        PromotionID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.PromotionID);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        TableID = c.Int(nullable: false, identity: true),
                        TableNumber = c.String(),
                        Capacity = c.Int(nullable: false),
                        IsAvailable = c.Boolean(nullable: false),
                        ParkingAvailability = c.Boolean(nullable: false),
                        Location = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.TableID);
            
            AddColumn("dbo.AspNetRoles", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetRoles", "Discriminator");
            DropTable("dbo.Tables");
            DropTable("dbo.Promotions");
        }
    }
}

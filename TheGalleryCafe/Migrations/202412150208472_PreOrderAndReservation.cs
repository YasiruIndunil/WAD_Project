namespace TheGalleryCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PreOrderAndReservation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PreOrders",
                c => new
                    {
                        PreOrderID = c.Int(nullable: false, identity: true),
                        ReservationID = c.Int(nullable: false),
                        MenuID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.PreOrderID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        ContactNumber = c.String(),
                        Email = c.String(),
                        ReservationDate = c.DateTime(nullable: false),
                        TableNumber = c.Int(nullable: false),
                        NumberOfGuests = c.Int(nullable: false),
                        SpecialRequests = c.String(),
                        IsConfirmed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reservations");
            DropTable("dbo.PreOrders");
        }
    }
}

namespace MovieTheater.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Guid(nullable: false),
                        Name = c.String(),
                        TicketPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Rating = c.String(),
                        Description = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        MovieDuration = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.MovieId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}

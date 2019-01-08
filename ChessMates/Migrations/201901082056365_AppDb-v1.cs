namespace ChessMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppDbv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Continents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Continent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Continents", t => t.Continent_Id)
                .Index(t => t.Continent_Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Sex = c.Int(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Rating = c.String(),
                        Title = c.Int(nullable: false),
                        Country_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        City = c.String(nullable: false),
                        Type = c.Int(nullable: false),
                        Country_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Countries", "Continent_Id", "dbo.Continents");
            DropForeignKey("dbo.Tournaments", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Players", "Country_Id", "dbo.Countries");
            DropIndex("dbo.Tournaments", new[] { "Country_Id" });
            DropIndex("dbo.Players", new[] { "Country_Id" });
            DropIndex("dbo.Countries", new[] { "Continent_Id" });
            DropTable("dbo.News");
            DropTable("dbo.Tournaments");
            DropTable("dbo.Players");
            DropTable("dbo.Countries");
            DropTable("dbo.Continents");
        }
    }
}

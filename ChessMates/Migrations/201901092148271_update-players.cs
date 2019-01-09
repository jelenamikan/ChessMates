namespace ChessMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateplayers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Players", "Fed", c => c.String());
            AddColumn("dbo.Players", "Wtit", c => c.String());
            AddColumn("dbo.Players", "Otit", c => c.String());
            AddColumn("dbo.Players", "Foa", c => c.String());
            AddColumn("dbo.Players", "ClRating", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "ClGames", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "CK", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "RaRating", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "RaGames", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "RK", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "BlRating", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "BlGames", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "BK", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "BirtYear", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "Flag", c => c.String());
            DropColumn("dbo.Players", "FirstName");
            DropColumn("dbo.Players", "LastName");
            DropColumn("dbo.Players", "BirthDate");
            DropColumn("dbo.Players", "Rating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "Rating", c => c.String());
            AddColumn("dbo.Players", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Players", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.Players", "FirstName", c => c.String(nullable: false));
            DropColumn("dbo.Players", "Flag");
            DropColumn("dbo.Players", "BirtYear");
            DropColumn("dbo.Players", "BK");
            DropColumn("dbo.Players", "BlGames");
            DropColumn("dbo.Players", "BlRating");
            DropColumn("dbo.Players", "RK");
            DropColumn("dbo.Players", "RaGames");
            DropColumn("dbo.Players", "RaRating");
            DropColumn("dbo.Players", "CK");
            DropColumn("dbo.Players", "ClGames");
            DropColumn("dbo.Players", "ClRating");
            DropColumn("dbo.Players", "Foa");
            DropColumn("dbo.Players", "Otit");
            DropColumn("dbo.Players", "Wtit");
            DropColumn("dbo.Players", "Fed");
            DropColumn("dbo.Players", "Name");
        }
    }
}

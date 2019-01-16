namespace ChessMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedbattr : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Countries", "Continent_Id", "dbo.Continents");
            DropForeignKey("dbo.Players", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Tournaments", "Country_Id", "dbo.Countries");
            DropIndex("dbo.Countries", new[] { "Continent_Id" });
            DropIndex("dbo.Players", new[] { "Country_Id" });
            DropIndex("dbo.Tournaments", new[] { "Country_Id" });
            RenameColumn(table: "dbo.Countries", name: "Continent_Id", newName: "continent");
            RenameColumn(table: "dbo.Players", name: "Country_Id", newName: "isoAlpha3");
            RenameColumn(table: "dbo.Tournaments", name: "Country_Id", newName: "isoAlpha3");
            DropPrimaryKey("dbo.Continents");
            DropPrimaryKey("dbo.Countries");
            DropPrimaryKey("dbo.Players");
            DropColumn("dbo.Players", "Id");
            DropPrimaryKey("dbo.Tournaments");
            AddColumn("dbo.Continents", "continent", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Continents", "continentName", c => c.String(nullable: false));
            AddColumn("dbo.Countries", "isoAlpha3", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Countries", "countryName", c => c.String(nullable: false));
            AddColumn("dbo.Players", "fideid", c => c.Long(nullable: false, identity: true));
            AddColumn("dbo.Players", "w_title", c => c.String());
            AddColumn("dbo.Players", "o_title", c => c.String());
            AddColumn("dbo.Players", "foa_title", c => c.String());
            AddColumn("dbo.Players", "rating", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "games", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "k", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "rapid_rating", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "rapid_games", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "rapid_k", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "blitz_rating", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "blitz_games", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "blitz_k", c => c.Int(nullable: false));
            AlterColumn("dbo.Countries", "continent", c => c.String(maxLength: 128));
            AlterColumn("dbo.Players", "isoAlpha3", c => c.String(maxLength: 128));
            AlterColumn("dbo.Tournaments", "Id", c => c.Long(nullable: false));
            AlterColumn("dbo.Tournaments", "isoAlpha3", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Continents", "continent");
            AddPrimaryKey("dbo.Countries", "isoAlpha3");
            AddPrimaryKey("dbo.Players", "fideid");
            AddPrimaryKey("dbo.Tournaments", "Id");
            CreateIndex("dbo.Countries", "continent");
            CreateIndex("dbo.Players", "isoAlpha3");
            CreateIndex("dbo.Tournaments", "isoAlpha3");
            AddForeignKey("dbo.Countries", "continent", "dbo.Continents", "continent");
            AddForeignKey("dbo.Players", "isoAlpha3", "dbo.Countries", "isoAlpha3");
            AddForeignKey("dbo.Tournaments", "isoAlpha3", "dbo.Countries", "isoAlpha3");
            DropColumn("dbo.Continents", "Id");
            DropColumn("dbo.Continents", "Name");
            DropColumn("dbo.Countries", "Id");
            DropColumn("dbo.Countries", "Name");
            DropColumn("dbo.Players", "Fed");
            DropColumn("dbo.Players", "Wtit");
            DropColumn("dbo.Players", "Otit");
            DropColumn("dbo.Players", "Foa");
            DropColumn("dbo.Players", "ClRating");
            DropColumn("dbo.Players", "ClGames");
            DropColumn("dbo.Players", "CK");
            DropColumn("dbo.Players", "RaRating");
            DropColumn("dbo.Players", "RaGames");
            DropColumn("dbo.Players", "RK");
            DropColumn("dbo.Players", "BlRating");
            DropColumn("dbo.Players", "BlGames");
            DropColumn("dbo.Players", "BK");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "BK", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "BlGames", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "BlRating", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "RK", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "RaGames", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "RaRating", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "CK", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "ClGames", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "ClRating", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "Foa", c => c.String());
            AddColumn("dbo.Players", "Otit", c => c.String());
            AddColumn("dbo.Players", "Wtit", c => c.String());
            AddColumn("dbo.Players", "Fed", c => c.String());
            AddColumn("dbo.Players", "Id", c => c.Long(nullable: false, identity: true));
            AddColumn("dbo.Countries", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Countries", "Id", c => c.Long(nullable: false, identity: true));
            AddColumn("dbo.Continents", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Continents", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Tournaments", "isoAlpha3", "dbo.Countries");
            DropForeignKey("dbo.Players", "isoAlpha3", "dbo.Countries");
            DropForeignKey("dbo.Countries", "continent", "dbo.Continents");
            DropIndex("dbo.Tournaments", new[] { "isoAlpha3" });
            DropIndex("dbo.Players", new[] { "isoAlpha3" });
            DropIndex("dbo.Countries", new[] { "continent" });
            DropPrimaryKey("dbo.Tournaments");
            DropPrimaryKey("dbo.Players");
            DropPrimaryKey("dbo.Countries");
            DropPrimaryKey("dbo.Continents");
            AlterColumn("dbo.Tournaments", "isoAlpha3", c => c.Long());
            AlterColumn("dbo.Tournaments", "Id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.Players", "isoAlpha3", c => c.Long());
            AlterColumn("dbo.Countries", "continent", c => c.Int());
            DropColumn("dbo.Players", "blitz_k");
            DropColumn("dbo.Players", "blitz_games");
            DropColumn("dbo.Players", "blitz_rating");
            DropColumn("dbo.Players", "rapid_k");
            DropColumn("dbo.Players", "rapid_games");
            DropColumn("dbo.Players", "rapid_rating");
            DropColumn("dbo.Players", "k");
            DropColumn("dbo.Players", "games");
            DropColumn("dbo.Players", "rating");
            DropColumn("dbo.Players", "foa_title");
            DropColumn("dbo.Players", "o_title");
            DropColumn("dbo.Players", "w_title");
            DropColumn("dbo.Players", "fideid");
            DropColumn("dbo.Countries", "countryName");
            DropColumn("dbo.Countries", "isoAlpha3");
            DropColumn("dbo.Continents", "continentName");
            DropColumn("dbo.Continents", "continent");
            AddPrimaryKey("dbo.Tournaments", "Id");
            AddPrimaryKey("dbo.Players", "Id");
            AddPrimaryKey("dbo.Countries", "Id");
            AddPrimaryKey("dbo.Continents", "Id");
            RenameColumn(table: "dbo.Tournaments", name: "isoAlpha3", newName: "Country_Id");
            RenameColumn(table: "dbo.Players", name: "isoAlpha3", newName: "Country_Id");
            RenameColumn(table: "dbo.Countries", name: "continent", newName: "Continent_Id");
            CreateIndex("dbo.Tournaments", "Country_Id");
            CreateIndex("dbo.Players", "Country_Id");
            CreateIndex("dbo.Countries", "Continent_Id");
            AddForeignKey("dbo.Tournaments", "Country_Id", "dbo.Countries", "Id");
            AddForeignKey("dbo.Players", "Country_Id", "dbo.Countries", "Id");
            AddForeignKey("dbo.Countries", "Continent_Id", "dbo.Continents", "Id");
        }
    }
}

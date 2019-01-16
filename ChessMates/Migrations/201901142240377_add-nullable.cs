namespace ChessMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Players", "rating", c => c.Int());
            AlterColumn("dbo.Players", "games", c => c.Int());
            AlterColumn("dbo.Players", "k", c => c.Int());
            AlterColumn("dbo.Players", "rapid_rating", c => c.Int());
            AlterColumn("dbo.Players", "rapid_games", c => c.Int());
            AlterColumn("dbo.Players", "rapid_k", c => c.Int());
            AlterColumn("dbo.Players", "blitz_rating", c => c.Int());
            AlterColumn("dbo.Players", "blitz_games", c => c.Int());
            AlterColumn("dbo.Players", "blitz_k", c => c.Int());
            AlterColumn("dbo.Players", "birthyear", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Players", "birthyear", c => c.Int(nullable: false));
            AlterColumn("dbo.Players", "blitz_k", c => c.Int(nullable: false));
            AlterColumn("dbo.Players", "blitz_games", c => c.Int(nullable: false));
            AlterColumn("dbo.Players", "blitz_rating", c => c.Int(nullable: false));
            AlterColumn("dbo.Players", "rapid_k", c => c.Int(nullable: false));
            AlterColumn("dbo.Players", "rapid_games", c => c.Int(nullable: false));
            AlterColumn("dbo.Players", "rapid_rating", c => c.Int(nullable: false));
            AlterColumn("dbo.Players", "k", c => c.Int(nullable: false));
            AlterColumn("dbo.Players", "games", c => c.Int(nullable: false));
            AlterColumn("dbo.Players", "rating", c => c.Int(nullable: false));
        }
    }
}

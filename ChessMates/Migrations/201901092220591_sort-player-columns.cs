namespace ChessMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sortplayercolumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "BirthYear", c => c.Int(nullable: false));
            DropColumn("dbo.Players", "BirtYear");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "BirtYear", c => c.Int(nullable: false));
            DropColumn("dbo.Players", "BirthYear");
        }
    }
}

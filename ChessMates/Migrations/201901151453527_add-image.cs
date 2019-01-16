namespace ChessMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addimage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "image");
        }
    }
}

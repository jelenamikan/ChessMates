namespace ChessMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makeplayeridstring : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Players");
            DropColumn("dbo.Players", "fideid");
            AddColumn("dbo.Players", "fideid", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Players", "fideid");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Players");
            DropColumn("dbo.Players", "fideid");
            AddColumn("dbo.Players", "fideid", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.Players", "fideid");
        }
    }
}

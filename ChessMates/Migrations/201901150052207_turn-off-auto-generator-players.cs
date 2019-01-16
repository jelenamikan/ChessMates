namespace ChessMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class turnoffautogeneratorplayers : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Players");
            AlterColumn("dbo.Players", "fideid", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.Players", "fideid");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Players");
            AlterColumn("dbo.Players", "fideid", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.Players", "fideid");
        }
    }
}

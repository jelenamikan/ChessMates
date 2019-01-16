namespace ChessMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class maketidauto : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Tournaments");
            AlterColumn("dbo.Tournaments", "Id", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.Tournaments", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Tournaments");
            AlterColumn("dbo.Tournaments", "Id", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.Tournaments", "Id");
        }
    }
}

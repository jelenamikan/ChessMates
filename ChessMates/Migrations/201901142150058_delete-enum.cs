namespace ChessMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteenum : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Players", "sex", c => c.String());
            AlterColumn("dbo.Players", "title", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Players", "title", c => c.Int(nullable: false));
            AlterColumn("dbo.Players", "sex", c => c.Int(nullable: false));
        }
    }
}

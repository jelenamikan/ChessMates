namespace ChessMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addauthorandimage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "Author", c => c.String());
            AddColumn("dbo.News", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.News", "ImageUrl");
            DropColumn("dbo.News", "Author");
        }
    }
}

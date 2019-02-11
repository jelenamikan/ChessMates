namespace ChessMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDescriptionToNews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "Description", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.News", "Description");
        }
    }
}

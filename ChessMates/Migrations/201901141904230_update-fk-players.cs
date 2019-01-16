namespace ChessMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatefkplayers : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Players", name: "isoAlpha3", newName: "country");
            RenameIndex(table: "dbo.Players", name: "IX_isoAlpha3", newName: "IX_country");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Players", name: "IX_country", newName: "IX_isoAlpha3");
            RenameColumn(table: "dbo.Players", name: "country", newName: "isoAlpha3");
        }
    }
}

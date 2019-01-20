namespace ChessMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5b5fc0ec-5bc7-42fc-b9e6-76e22da1bef4', N'admin@chessmates.com', 0, N'AKlnf23PsuznOWTuAl9hA2t4W8XpBbe6R29K8U1JKU5eo46dLyZz7B3Dtp6heIP0Zw==', N'92ef743a-ef56-473c-bb97-bc0b000dfedd', NULL, 0, 0, NULL, 1, 0, N'admin@chessmates.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cf604ffe-c2fc-44e5-a06c-5f25a8eb4820', N'Admin')                  
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5b5fc0ec-5bc7-42fc-b9e6-76e22da1bef4', N'cf604ffe-c2fc-44e5-a06c-5f25a8eb4820')
               ");
        }
        
        public override void Down()
        {
        }
    }
}

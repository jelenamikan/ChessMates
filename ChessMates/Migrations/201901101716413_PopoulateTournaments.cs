namespace ChessMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopoulateTournaments : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Tournaments VALUES ('European Individual Chess Championship 2019', convert(datetime, '17-Mar-2019',106), convert(datetime, '30-Mar-2019',106), 'Skopje', 0 , 130)");
            Sql("INSERT INTO Tournaments VALUES ('European Individual Women’s Chess Championship 2019', convert(datetime, '10-Apr-2019',106), convert(datetime, '23-Apr-2019',106), 'Antalya', 0 , 228)");
            Sql("INSERT INTO Tournaments VALUES ('World Amateur Championship 2019', convert(datetime, '23-Apr-2019',106), convert(datetime, '29-Apr-2019',106), 'Mexico City', 0 , 142)");
            Sql("INSERT INTO Tournaments VALUES ('European Team Championships 2019', convert(datetime, '23-Oct-2019',106), convert(datetime, '3-Nov-2019',106), 'Batumi', 0 , 81)");
            Sql("INSERT INTO Tournaments VALUES ('Blitz Individual Championships 2019', convert(datetime, '5-May-2019',106), convert(datetime, '5-May-2019',106), 'Nairobi', 1 , 115)");
            Sql("INSERT INTO Tournaments VALUES ('Rapid Individual Championships 2019', convert(datetime, '5-May-2019',106), convert(datetime, '5-May-2019',106), 'Nairobi', 2 , 115)");
        }
        
        public override void Down()
        {
        }
    }
}

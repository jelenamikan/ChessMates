namespace ChessMates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTournamentsv1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Tournaments VALUES ('44th World Chess Olympiad 2020', convert(datetime, '1-Aug-2020',106), convert(datetime, '15-Aug-2020',106), 'Khanty-Mansiysk', 0 , 182)");
            Sql("INSERT INTO Tournaments VALUES ('Panamerican Amateur Chess Championship 2020', convert(datetime, '14-Nov-2020',106), convert(datetime, '17-Nov-2020',106), 'San Paulo', 0 , 31)");
            Sql("INSERT INTO Tournaments VALUES ('45th World Chess Olympiad 2022', convert(datetime, '1-Aug-2022',106), convert(datetime, '14-Aug-2022',106), 'Minsk', 0 , 20)");
            Sql("INSERT INTO Tournaments VALUES ('19th WGM tournament - Mediterranean flower', convert(datetime, '2-Mar-2019',106), convert(datetime, '9-Mar-2019',106), 'Rijeka', 0 , 53)");
            Sql("INSERT INTO Tournaments VALUES ('2nd International Emanuel Lasker Blitz Tournament', convert(datetime, '2-Mar-2019',106), convert(datetime, '2-Mar-2019',106), 'Berlin', 1 , 82)");
            Sql("INSERT INTO Tournaments VALUES ('21st Dubai Open Chess CH. 2019', convert(datetime, '1-Mar-2019',106), convert(datetime, '9-Mar-2019',106), 'Dubai', 0 , 236)");
            Sql("INSERT INTO Tournaments VALUES ('13th Leiden Chess Tournament', convert(datetime, '12-Jul-2019',106), convert(datetime, '21-Jul-2019',106), 'Leiden', 0 , 155)");
            Sql("INSERT INTO Tournaments VALUES ('125th Richmond Rapidplay', convert(datetime, '11-Aug-2019',106), convert(datetime, '11-Aug-2019',106), 'London', 2 , 237)");
            Sql("INSERT INTO Tournaments VALUES ('33rd Winter Games Festival of Cannes', convert(datetime, '18-Feb-2019',106), convert(datetime, '24-Feb-2019',106), 'Cannes', 0 , 75)");
            Sql("INSERT INTO Tournaments VALUES ('Open Portugal', convert(datetime, '2-Feb-2019',106), convert(datetime, '9-Feb-2019',106), 'Lisboa', 0 , 177)");
            Sql("INSERT INTO Tournaments VALUES ('Stockholm Chess Challenge', convert(datetime, '26-Apr-2019',106), convert(datetime, '1-May-2019',106), 'Stockholm', 0 , 215)");
            Sql("INSERT INTO Tournaments VALUES ('Mount Everest Base Camp Chess For The World Record', convert(datetime, '9-May-2019',106), convert(datetime, '22-May-2019',106), 'Everest Base Camp', 1 , 154)");
            Sql("INSERT INTO Tournaments VALUES ('Icelandic Open 2019', convert(datetime, '25-May-2019',106), convert(datetime, '1-Jun-2019',106), 'Reykjavik', 0 , 100)");
            Sql("INSERT INTO Tournaments VALUES ('10th International Chess Open Dolomites Forni di Sopra', convert(datetime, '15-Jun-2019',106), convert(datetime, '22-Jun-2019',106), 'Forni di Sopra', 0 , 108)");
        }

        public override void Down()
        {
        }
    }
}

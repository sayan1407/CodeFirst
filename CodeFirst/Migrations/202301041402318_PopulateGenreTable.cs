namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES(1,'Action')");
            Sql("INSERT INTO Genres VALUES(2,'Comedy')");
            Sql("INSERT INTO Genres VALUES(3,'Crime')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Name = 'Crime'");
            Sql("DELETE FROM Genres WHERE Name = 'Comedy'");
            Sql("DELETE FROM Genres WHERE Name = 'Action'");

        }
    }
}

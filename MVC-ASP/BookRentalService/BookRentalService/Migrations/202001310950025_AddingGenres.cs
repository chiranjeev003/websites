namespace BookRentalService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO[dbo].[GenreModels] ( [Name]) VALUES( N'Comedy')");
            Sql("INSERT INTO[dbo].[GenreModels] ( [Name]) VALUES( N'Horror')");
            Sql("INSERT INTO[dbo].[GenreModels] ( [Name]) VALUES( N'Drama')");
            Sql("INSERT INTO[dbo].[GenreModels] ( [Name]) VALUES( N'Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}

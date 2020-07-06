namespace BookRentalService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BooksAndGenresAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BooksModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Author = c.String(),
                        DateAddedInRecord = c.DateTime(),
                        NumberInStocks = c.Int(nullable: false),
                        Genres_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.GenreModels", t => t.Genres_ID)
                .Index(t => t.Genres_ID);
            
            CreateTable(
                "dbo.GenreModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BooksModels", "Genres_ID", "dbo.GenreModels");
            DropIndex("dbo.BooksModels", new[] { "Genres_ID" });
            DropTable("dbo.GenreModels");
            DropTable("dbo.BooksModels");
        }
    }
}

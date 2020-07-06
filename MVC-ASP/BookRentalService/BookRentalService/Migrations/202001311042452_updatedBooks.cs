namespace BookRentalService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedBooks : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BooksModels", "Genres_ID", "dbo.GenreModels");
            DropIndex("dbo.BooksModels", new[] { "Genres_ID" });
            RenameColumn(table: "dbo.BooksModels", name: "Genres_ID", newName: "GenresID");
            AlterColumn("dbo.BooksModels", "GenresID", c => c.Int(nullable: false));
            CreateIndex("dbo.BooksModels", "GenresID");
            AddForeignKey("dbo.BooksModels", "GenresID", "dbo.GenreModels", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BooksModels", "GenresID", "dbo.GenreModels");
            DropIndex("dbo.BooksModels", new[] { "GenresID" });
            AlterColumn("dbo.BooksModels", "GenresID", c => c.Int());
            RenameColumn(table: "dbo.BooksModels", name: "GenresID", newName: "Genres_ID");
            CreateIndex("dbo.BooksModels", "Genres_ID");
            AddForeignKey("dbo.BooksModels", "Genres_ID", "dbo.GenreModels", "ID");
        }
    }
}

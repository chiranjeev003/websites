namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectedGenre : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Generes", newName: "Genres");
            DropForeignKey("dbo.Movies", "Genere_Id", "dbo.Generes");
            DropIndex("dbo.Movies", new[] { "Genere_Id" });
            RenameColumn(table: "dbo.Movies", name: "Genere_Id", newName: "Genre_Id");
            DropPrimaryKey("dbo.Genres");
            AddColumn("dbo.Movies", "GenreName", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "Genre_Id", c => c.Int());
            AlterColumn("dbo.Genres", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Genres", "Name", c => c.String(maxLength: 100));
            AddPrimaryKey("dbo.Genres", "Id");
            CreateIndex("dbo.Movies", "Genre_Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres", "Id");
            DropColumn("dbo.Movies", "GenereName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GenereName", c => c.Byte(nullable: false));
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Genres", "Name", c => c.String());
            AlterColumn("dbo.Genres", "Id", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Movies", "Genre_Id", c => c.Boolean());
            DropColumn("dbo.Movies", "GenreName");
            AddPrimaryKey("dbo.Genres", "Id");
            RenameColumn(table: "dbo.Movies", name: "Genre_Id", newName: "Genere_Id");
            CreateIndex("dbo.Movies", "Genere_Id");
            AddForeignKey("dbo.Movies", "Genere_Id", "dbo.Generes", "Id");
            RenameTable(name: "dbo.Genres", newName: "Generes");
        }
    }
}

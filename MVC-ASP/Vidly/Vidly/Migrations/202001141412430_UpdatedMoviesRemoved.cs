namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedMoviesRemoved : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Movies", "Movie_Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Movie_Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Movies", "Name");
        }
    }
}

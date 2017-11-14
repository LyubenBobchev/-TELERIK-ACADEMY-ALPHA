namespace Movie_DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreMovieRelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Genres", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Genres", new[] { "Movie_Id" });
            CreateTable(
                "dbo.MovieGenres",
                c => new
                    {
                        Movie_Id = c.Int(nullable: false),
                        Genre_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_Id, t.Genre_Id })
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .Index(t => t.Movie_Id)
                .Index(t => t.Genre_Id);
            
            DropColumn("dbo.Genres", "Movie_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "Movie_Id", c => c.Int());
            DropForeignKey("dbo.MovieGenres", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.MovieGenres", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.MovieGenres", new[] { "Genre_Id" });
            DropIndex("dbo.MovieGenres", new[] { "Movie_Id" });
            DropTable("dbo.MovieGenres");
            CreateIndex("dbo.Genres", "Movie_Id");
            AddForeignKey("dbo.Genres", "Movie_Id", "dbo.Movies", "Id");
        }
    }
}

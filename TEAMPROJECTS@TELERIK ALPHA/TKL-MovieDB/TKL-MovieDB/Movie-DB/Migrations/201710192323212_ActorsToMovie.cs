namespace Movie_DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActorsToMovie : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Movies", new[] { "Director_Id" });
            DropIndex("dbo.Movies", new[] { "Writer_Id" });
            DropIndex("dbo.People", new[] { "Movie_Id" });
            RenameColumn(table: "dbo.Movies", name: "Director_Id", newName: "DirectorId");
            RenameColumn(table: "dbo.Movies", name: "Writer_Id", newName: "WriterId");
            CreateTable(
                "dbo.MoviePersons",
                c => new
                    {
                        Movie_Id = c.Int(nullable: false),
                        Person_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_Id, t.Person_Id })
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.Person_Id, cascadeDelete: true)
                .Index(t => t.Movie_Id)
                .Index(t => t.Person_Id);
            
            AlterColumn("dbo.Movies", "DirectorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "WriterId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "WriterId");
            CreateIndex("dbo.Movies", "DirectorId");
            DropColumn("dbo.People", "Movie_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Movie_Id", c => c.Int());
            DropForeignKey("dbo.MoviePersons", "Person_Id", "dbo.People");
            DropForeignKey("dbo.MoviePersons", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.MoviePersons", new[] { "Person_Id" });
            DropIndex("dbo.MoviePersons", new[] { "Movie_Id" });
            DropIndex("dbo.Movies", new[] { "DirectorId" });
            DropIndex("dbo.Movies", new[] { "WriterId" });
            AlterColumn("dbo.Movies", "WriterId", c => c.Int());
            AlterColumn("dbo.Movies", "DirectorId", c => c.Int());
            DropTable("dbo.MoviePersons");
            RenameColumn(table: "dbo.Movies", name: "WriterId", newName: "Writer_Id");
            RenameColumn(table: "dbo.Movies", name: "DirectorId", newName: "Director_Id");
            CreateIndex("dbo.People", "Movie_Id");
            CreateIndex("dbo.Movies", "Writer_Id");
            CreateIndex("dbo.Movies", "Director_Id");
            AddForeignKey("dbo.People", "Movie_Id", "dbo.Movies", "Id");
        }
    }
}

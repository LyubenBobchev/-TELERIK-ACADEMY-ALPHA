namespace Movie_DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncludeMovie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        Year = c.String(),
                        ReleaseDate = c.String(),
                        Synopsis = c.String(maxLength: 300),
                        Budget = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Director_Id = c.Int(),
                        Writer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Director_Id)
                .ForeignKey("dbo.People", t => t.Writer_Id)
                .Index(t => t.Director_Id)
                .Index(t => t.Writer_Id);
            
            AddColumn("dbo.Genres", "Movie_Id", c => c.Int());
            AddColumn("dbo.People", "Movie_Id", c => c.Int());
            CreateIndex("dbo.Genres", "Movie_Id");
            CreateIndex("dbo.People", "Movie_Id");
            AddForeignKey("dbo.People", "Movie_Id", "dbo.Movies", "Id");
            AddForeignKey("dbo.Genres", "Movie_Id", "dbo.Movies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Writer_Id", "dbo.People");
            DropForeignKey("dbo.Genres", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Movies", "Director_Id", "dbo.People");
            DropForeignKey("dbo.People", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.People", new[] { "Movie_Id" });
            DropIndex("dbo.Movies", new[] { "Writer_Id" });
            DropIndex("dbo.Movies", new[] { "Director_Id" });
            DropIndex("dbo.Genres", new[] { "Movie_Id" });
            DropColumn("dbo.People", "Movie_Id");
            DropColumn("dbo.Genres", "Movie_Id");
            DropTable("dbo.Movies");
        }
    }
}

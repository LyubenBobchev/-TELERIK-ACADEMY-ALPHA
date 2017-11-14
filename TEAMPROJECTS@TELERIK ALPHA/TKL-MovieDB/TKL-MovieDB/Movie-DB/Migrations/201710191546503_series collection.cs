namespace Movie_DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seriescollection : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Series",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Genre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Genres", t => t.Genre_Id)
                .Index(t => t.Genre_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Series", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Series", new[] { "Genre_Id" });
            DropTable("dbo.Series");
        }
    }
}

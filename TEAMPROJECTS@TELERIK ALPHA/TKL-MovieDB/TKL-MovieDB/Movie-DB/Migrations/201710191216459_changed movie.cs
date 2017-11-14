namespace Movie_DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedmovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Movie", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Movie");
        }
    }
}

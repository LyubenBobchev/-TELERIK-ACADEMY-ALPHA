namespace Movie_DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seriesModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Series_ID", c => c.Int());
            AddColumn("dbo.People", "Series_ID1", c => c.Int());
            AddColumn("dbo.People", "Series_ID2", c => c.Int());
            AddColumn("dbo.Series", "Ongoing", c => c.String());
            AddColumn("dbo.Series", "NumberOfSeasons", c => c.Int(nullable: false));
            AddColumn("dbo.Series", "EpisodesPerSeason", c => c.Int(nullable: false));
            CreateIndex("dbo.People", "Series_ID");
            CreateIndex("dbo.People", "Series_ID1");
            CreateIndex("dbo.People", "Series_ID2");
            AddForeignKey("dbo.People", "Series_ID", "dbo.Series", "ID");
            AddForeignKey("dbo.People", "Series_ID1", "dbo.Series", "ID");
            AddForeignKey("dbo.People", "Series_ID2", "dbo.Series", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Series_ID2", "dbo.Series");
            DropForeignKey("dbo.People", "Series_ID1", "dbo.Series");
            DropForeignKey("dbo.People", "Series_ID", "dbo.Series");
            DropIndex("dbo.People", new[] { "Series_ID2" });
            DropIndex("dbo.People", new[] { "Series_ID1" });
            DropIndex("dbo.People", new[] { "Series_ID" });
            DropColumn("dbo.Series", "EpisodesPerSeason");
            DropColumn("dbo.Series", "NumberOfSeasons");
            DropColumn("dbo.Series", "Ongoing");
            DropColumn("dbo.People", "Series_ID2");
            DropColumn("dbo.People", "Series_ID1");
            DropColumn("dbo.People", "Series_ID");
        }
    }
}

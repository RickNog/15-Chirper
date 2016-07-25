namespace Chirper.WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chirps", "LikedCount", c => c.Int(nullable: false));
            AddColumn("dbo.Comments", "LikedCount", c => c.Int(nullable: false));
            DropColumn("dbo.Chirps", "LinkedCount");
            DropColumn("dbo.Comments", "LinkedCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "LinkedCount", c => c.Int(nullable: false));
            AddColumn("dbo.Chirps", "LinkedCount", c => c.Int(nullable: false));
            DropColumn("dbo.Comments", "LikedCount");
            DropColumn("dbo.Chirps", "LikedCount");
        }
    }
}

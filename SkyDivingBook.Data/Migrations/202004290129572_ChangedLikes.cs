namespace SkyDivingBook.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedLikes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Likes", "UserId", "dbo.Users");
            DropIndex("dbo.Likes", new[] { "UserId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Likes", "UserId");
            AddForeignKey("dbo.Likes", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
        }
    }
}

namespace SkyDivingBook.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedCode : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        LikeId = c.Int(nullable: false, identity: true),
                        PostId = c.Int(nullable: false),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.LikeId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Likes", "UserId", "dbo.Users");
            DropIndex("dbo.Likes", new[] { "UserId" });
            DropTable("dbo.Likes");
        }
    }
}

namespace SkyDivingBook.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedComment : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Comments", "Author");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "Author", c => c.Int(nullable: false));
        }
    }
}

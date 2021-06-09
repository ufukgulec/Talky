namespace Talky.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ChannelUserRegistries", "ChannelId", "dbo.Channels");
            DropForeignKey("dbo.ChannelUserRegistries", "UserId", "dbo.Users");
            DropIndex("dbo.ChannelUserRegistries", new[] { "ChannelId" });
            DropIndex("dbo.ChannelUserRegistries", new[] { "UserId" });
            DropTable("dbo.ChannelUserRegistries");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ChannelUserRegistries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        ChannelId = c.Int(nullable: false),
                        UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.ChannelUserRegistries", "UserId");
            CreateIndex("dbo.ChannelUserRegistries", "ChannelId");
            AddForeignKey("dbo.ChannelUserRegistries", "UserId", "dbo.Users", "Id");
            AddForeignKey("dbo.ChannelUserRegistries", "ChannelId", "dbo.Channels", "Id", cascadeDelete: true);
        }
    }
}

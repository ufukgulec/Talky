namespace Talky.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "Text", c => c.String(maxLength: 1000));
            DropColumn("dbo.Messages", "Content");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "Content", c => c.String(maxLength: 1000));
            DropColumn("dbo.Messages", "Text");
        }
    }
}

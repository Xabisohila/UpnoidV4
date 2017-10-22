namespace UpnoidV4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Description", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Description");
        }
    }
}

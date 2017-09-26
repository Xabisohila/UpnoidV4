namespace UpnoidV4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TenthMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "NumberInStock", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
        }
    }
}

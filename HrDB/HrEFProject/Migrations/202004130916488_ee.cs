namespace HrEFProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ee : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Humen", "statu", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Humen", "statu", c => c.Int());
        }
    }
}

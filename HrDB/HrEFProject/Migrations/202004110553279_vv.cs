namespace HrEFProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vv : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Humen", "statu", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Humen", "statu");
        }
    }
}

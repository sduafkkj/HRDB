namespace HrEFProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class re : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.salary_grant", "salary_standard_id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.salary_grant", "salary_standard_id");
        }
    }
}

namespace HrEFProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ss : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.salary_grant", "salary_standard_id", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.salary_grant", "salary_standard_id", c => c.Int(nullable: false));
        }
    }
}

namespace HrEFProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hrdb3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Humen",
                c => new
                    {
                        hfd_id = c.Int(nullable: false, identity: true),
                        human_id = c.Int(nullable: false),
                        first_kind_id = c.Int(nullable: false),
                        first_kind_name = c.String(),
                        second_kind_id = c.Int(nullable: false),
                        second_kind_name = c.String(),
                        third_kind_id = c.Int(nullable: false),
                        third_kind_name = c.String(),
                        human_name = c.String(),
                        salary_standard_id = c.Int(nullable: false),
                        salary_standard_name = c.String(),
                        salary_sum = c.Double(nullable: false),
                        demand_salaray_sum = c.Double(nullable: false),
                        paid_salary_sum = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.hfd_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Humen");
        }
    }
}

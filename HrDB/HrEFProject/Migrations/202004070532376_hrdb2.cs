namespace HrEFProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hrdb2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.config_file_first_kind",
                c => new
                    {
                        ffk_id = c.Int(nullable: false, identity: true),
                        first_kind_id = c.Int(nullable: false),
                        first_kind_name = c.String(),
                        first_kind_salary_id = c.Int(nullable: false),
                        first_kind_sale_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ffk_id);
            
            CreateTable(
                "dbo.config_file_second_kind",
                c => new
                    {
                        fsk_id = c.Int(nullable: false, identity: true),
                        first_kind_id = c.Int(nullable: false),
                        first_kind_name = c.String(),
                        second_kind_id = c.Int(nullable: false),
                        second_kind_name = c.String(),
                        second_salary_id = c.Int(nullable: false),
                        second_sale_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.fsk_id);
            
            CreateTable(
                "dbo.config_file_third_kind",
                c => new
                    {
                        ftk_id = c.Int(nullable: false, identity: true),
                        first_kind_id = c.Int(nullable: false),
                        first_kind_name = c.String(),
                        second_kind_id = c.Int(nullable: false),
                        second_kind_name = c.String(),
                        third_kind_id = c.Int(nullable: false),
                        third_kind_name = c.String(),
                        third_kind_sale_id = c.Int(nullable: false),
                        third_kind_is_retail = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ftk_id);
            
            CreateTable(
                "dbo.salary_grant",
                c => new
                    {
                        sgr_id = c.Int(nullable: false, identity: true),
                        salary_grant_id = c.Int(nullable: false),
                        first_kind_id = c.Int(nullable: false),
                        first_kind_name = c.String(),
                        second_kind_id = c.Int(nullable: false),
                        second_kind_name = c.String(),
                        third_kind_id = c.Int(nullable: false),
                        third_kind_name = c.String(),
                        human_amount = c.Int(nullable: false),
                        salary_standard_sum = c.Double(nullable: false),
                        salary_paid_sum = c.Double(nullable: false),
                        register = c.String(),
                        regist_time = c.DateTime(nullable: false),
                        checker = c.String(),
                        check_time = c.DateTime(nullable: false),
                        check_status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.sgr_id);
            
            CreateTable(
                "dbo.salary_grant_details",
                c => new
                    {
                        grd_id = c.Int(nullable: false, identity: true),
                        salary_grant_id = c.Int(nullable: false),
                        salary_standard_id = c.Int(nullable: false),
                        human_id = c.Int(nullable: false),
                        human_name = c.String(),
                        bouns_sum = c.Double(nullable: false),
                        sale_sum = c.Double(nullable: false),
                        deduct_sum = c.Double(nullable: false),
                        salary_standard_sum = c.Double(nullable: false),
                        salary_paid_sum = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.grd_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.salary_grant_details");
            DropTable("dbo.salary_grant");
            DropTable("dbo.config_file_third_kind");
            DropTable("dbo.config_file_second_kind");
            DropTable("dbo.config_file_first_kind");
        }
    }
}

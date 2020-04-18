namespace HrEFProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HRDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.salary_standard",
                c => new
                    {
                        ssd_id = c.Int(nullable: false, identity: true),
                        standard_id = c.String(maxLength: 30),
                        standard_name = c.String(maxLength: 60),
                        designer = c.String(maxLength: 60),
                        register = c.String(maxLength: 60),
                        checker = c.String(maxLength: 60),
                        changer = c.String(maxLength: 60),
                        regist_time = c.DateTime(nullable: false),
                        check_time = c.DateTime(nullable: false),
                        change_time = c.DateTime(nullable: false),
                        salary_sum = c.Double(nullable: false),
                        check_status = c.Int(nullable: false),
                        change_status = c.Int(nullable: false),
                        check_comment = c.String(maxLength: 500),
                        remark = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ssd_id);
            
            CreateTable(
                "dbo.salary_standard_details",
                c => new
                    {
                        sdt_id = c.Int(nullable: false, identity: true),
                        standard_id = c.String(),
                        standard_name = c.String(maxLength: 60),
                        item_id = c.Int(nullable: false),
                        item_name = c.String(maxLength: 60),
                        salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.sdt_id);
            
            CreateTable(
                "dbo.salar_standard_item",
                c => new
                    {
                        item_id = c.Int(nullable: false, identity: true),
                        item_name = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.item_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.salar_standard_item");
            DropTable("dbo.salary_standard_details");
            DropTable("dbo.salary_standard");
        }
    }
}

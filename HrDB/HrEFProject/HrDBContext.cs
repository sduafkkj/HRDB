using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrEFProject.Config;
namespace HrEFProject
{
   public class HrDBContext:DbContext
    {
        public HrDBContext():base("name=sql")
        {
           
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new salary_standardConfig());
            modelBuilder.Configurations.Add(new salary_standard_detailsConfig());
            modelBuilder.Configurations.Add(new salar_standard_itemConfig());
            modelBuilder.Configurations.Add(new config_file_first_kindConfig());
            modelBuilder.Configurations.Add(new config_file_second_kindConfig());
            modelBuilder.Configurations.Add(new config_file_third_kindConfig());
            modelBuilder.Configurations.Add(new salary_grantConfig());
            modelBuilder.Configurations.Add(new salary_grant_detailsConfig());
            modelBuilder.Configurations.Add(new HumanConfig());
            //modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());//加载整个程序集的配置类
        }
        public DbSet<salary_standard>salar{ get; set; }
        public DbSet<salary_standard_details> salar1 { get; set; }
        public DbSet<salar_standard_item> salar2 { get; set; }
        public DbSet<config_file_first_kind> con { get; set; }
        public DbSet<config_file_second_kind> con1 { get; set; }
        public DbSet<config_file_third_kind> con2 { get; set; }
        public DbSet<salary_grant> sg { get; set; }
        public DbSet<salary_grant_details> sg1 { get; set; }
        public virtual DbSet<Humen> hu { get; set; }
       
    }
}

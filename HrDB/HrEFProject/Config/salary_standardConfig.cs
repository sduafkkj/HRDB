using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrEFProject.Config
{
   public class salary_standardConfig:EntityTypeConfiguration<salary_standard>
    {
        public salary_standardConfig()
        {
            this.ToTable("salary_standard");//映射到表名
            this.HasKey(e => e.ssd_id);
            this.Property(e => e.standard_id).HasMaxLength(30);
            this.Property(e => e.standard_name).HasMaxLength(60);
            this.Property(e => e.designer).HasMaxLength(60);
            this.Property(e => e.register).HasMaxLength(60);
            this.Property(e => e.checker).HasMaxLength(60);
            this.Property(e => e.changer).HasMaxLength(60);
            this.Property(e => e.check_comment).HasMaxLength(500);
            this.Property(e => e.remark).HasMaxLength(500);
          
        }
    }
}

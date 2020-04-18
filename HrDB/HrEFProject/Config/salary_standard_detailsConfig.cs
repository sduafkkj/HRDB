using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrEFProject.Config
{
  public  class salary_standard_detailsConfig:EntityTypeConfiguration<salary_standard_details>
    {
        public salary_standard_detailsConfig()
        {
            this.ToTable("salary_standard_details");//映射到表名
            this.HasKey(e => e.sdt_id);
            this.Property(e => e.standard_name).HasMaxLength(60);
            this.Property(e => e.item_name).HasMaxLength(60);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrEFProject.Config
{
   public class salary_grant_detailsConfig: EntityTypeConfiguration<salary_grant_details>
    {
        public salary_grant_detailsConfig()
        {
            this.ToTable("salary_grant_details");//映射到表名
            this.HasKey(e => e.grd_id);
        }
    }
}

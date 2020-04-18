using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrEFProject.Config
{
   public class salary_grantConfig : EntityTypeConfiguration<salary_grant>
    {
        public salary_grantConfig()
        {
            this.ToTable("salary_grant");//映射到表名
            this.HasKey(e => e.sgr_id);
            
        }
    }
}

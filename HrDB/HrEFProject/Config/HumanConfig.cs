using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrEFProject.Config
{
   public class HumanConfig:EntityTypeConfiguration<Humen>
    {
        public HumanConfig()
        {
            this.ToTable("Humen");//映射到表名
            this.HasKey(e => e.hfd_id);
        }
    }
}

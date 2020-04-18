using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrEFProject.Config
{
   public class config_file_first_kindConfig : EntityTypeConfiguration<config_file_first_kind>
    {
        public config_file_first_kindConfig()
        {
            this.ToTable("config_file_first_kind");//映射到表名
            this.HasKey(e => e.ffk_id);
            
        }
    }
}

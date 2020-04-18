using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrEFProject.Config
{
   public class config_file_second_kindConfig: EntityTypeConfiguration<config_file_second_kind>
    {
        public config_file_second_kindConfig()
        {
            this.ToTable("config_file_second_kind");//映射到表名
            this.HasKey(e => e.fsk_id);
        }
    }
}

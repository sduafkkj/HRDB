using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrEFProject.Config
{
   public class salar_standard_itemConfig:EntityTypeConfiguration<salar_standard_item>
    {
        public salar_standard_itemConfig()
        {
            this.ToTable("salar_standard_item");//映射到表名
            this.HasKey(e => e.item_id);
            this.Property(e => e.item_name).HasMaxLength(60);
        }
    }
}

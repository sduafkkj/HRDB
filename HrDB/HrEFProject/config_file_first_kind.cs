using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrEFProject
{
  public  class config_file_first_kind
    {
        public int ffk_id { get; set; }//主键，自动增长列
        public int first_kind_id { get; set; }//一级机构编号
        public string first_kind_name { get; set; }//一级机构名称
        public int first_kind_salary_id { get; set; }//一级机构薪酬发放责任人编号
        public int first_kind_sale_id { get; set; }//一级机构销售责任人编号
    }
}

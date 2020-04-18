using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrEFProject
{
   public class Humen
    {
        public int hfd_id { get; set; }

        public int human_id { get; set; }

        public int first_kind_id { get; set; }
        public string first_kind_name { get; set; }
        public int second_kind_id { get; set; }
        public string second_kind_name { get; set; }
        public int third_kind_id { get; set; }
        public string third_kind_name { get; set; }
        public string human_name { get; set; }//姓名
        public int salary_standard_id { get; set; }//薪酬标准编号  
        public string salary_standard_name { get; set; }//薪酬标准名称 
        public double salary_sum { get; set; }//基本薪酬总额
        public double demand_salaray_sum { get; set; }//应发薪酬总额  
        public double paid_salary_sum { get; set; }//实发薪酬总额    
        public int statu { get; set; }//登记状态
    }
}

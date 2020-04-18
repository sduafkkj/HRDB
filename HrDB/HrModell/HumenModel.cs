using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrModell
{
   public class HumenModel
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
        public double jb { get; set; }
        public double gw { get; set; }
        public double jt { get; set; }
        public double wc { get; set; }
        public double wx { get; set; }
        public double jl { get; set; }
        public double jx { get; set; }
        public double yk { get; set; }
        public double sf { get; set; }
        public double zq { get; set; }
        public int grid { get; set; }
        public int sgrd { get; set; }
      
    }
}

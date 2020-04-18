using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrModell
{
   public class salary_grantModel
    {
        public int sgr_id { get; set; }
        public int salary_grant_id { get; set; }
        public int salary_standard_id { get; set; }
        public int first_kind_id { get; set; }
        public string first_kind_name { get; set; }
        public int second_kind_id { get; set; }
        public string second_kind_name { get; set; }
        public int third_kind_id { get; set; }
        public string third_kind_name { get; set; }
        public int human_amount { get; set; }
        public double salary_standard_sum { get; set; }
        public double salary_paid_sum { get; set; }
        public string register { get; set; }
        public DateTime regist_time { get; set; }
        public string checker { get; set; }
        public DateTime check_time { get; set; }
        public int check_status { get; set; }
    }
}

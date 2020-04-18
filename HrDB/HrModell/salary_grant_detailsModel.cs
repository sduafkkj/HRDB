using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrModell
{
  public  class salary_grant_detailsModel
    {
        public int grd_id { get; set; }
        public int salary_grant_id { get; set; }
        public int salary_standard_id { get; set; }
        public int human_id { get; set; }
        public string human_name { get; set; }
        public double bouns_sum { get; set; }
        public double sale_sum { get; set; }
        public double deduct_sum { get; set; }
        public double salary_standard_sum { get; set; }
        public double salary_paid_sum { get; set; }

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

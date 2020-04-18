using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrModell;
using HrIDAO;
using HrIBLL;
namespace HrBLL
{
    public class salary_grantModelBLL : salary_grantModelIBLL
    {
        public salary_grantModelIDAO MyProperty { get; set; }
        public int BJCreate(salary_grantModel bjm)
        {
            return MyProperty.BJCreate(bjm);
        }

        public int BJEdit(salary_grantModel bjm)
        {
            return MyProperty.BJEdit(bjm);
        }

        public List<salary_grantModel> GetPageList(int pageIndex, int pageSize, ref int totalCount)
        {
            return MyProperty.GetPageList(pageIndex,pageSize,ref totalCount);
        }

        public List<salary_grantModel> GetPageList2(int pageIndex, int pageSize, ref int totalCount, string gid, string name, string time, string time2)
        {
            return MyProperty.GetPageList2(pageIndex,pageSize,ref totalCount,gid,name,time,time2);
        }

        public List<salary_grantModel> SelectById(int id)
        {
            return MyProperty.SelectById(id);
        }

        public List<salary_grantModel> SelectById2(int id)
        {
            return MyProperty.SelectById2(id);
        }
    }
}

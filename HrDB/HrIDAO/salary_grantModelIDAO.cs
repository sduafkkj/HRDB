using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrModell;
namespace HrIDAO
{
   public interface salary_grantModelIDAO
    {
        int BJCreate(salary_grantModel bjm);

        List<salary_grantModel> GetPageList(int pageIndex, int pageSize, ref int totalCount);

        List<salary_grantModel> SelectById(int id);

        int BJEdit(salary_grantModel bjm);

        List<salary_grantModel> SelectById2(int id);

        List<salary_grantModel> GetPageList2(int pageIndex, int pageSize, ref int totalCount,string gid,string name,string time, string time2);
    }
}

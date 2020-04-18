using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrModell;
namespace HrIBLL
{
  public  interface salary_standardModelIBLL
    {
        List<salary_standardModel> BJSelect();

        int BJCreate(salary_standardModel bjm);

        List<string> BJSelectBy(string  name);

        int BJEdit(salary_standardModel bjm);

        salary_standardModel BJSelectBy2(int id);

        int BJDelete(salary_standardModel bjm);

        Dictionary<int, List<salary_standardModel>> Fenye(int a, int b);//分页

        Dictionary<int, List<salary_standardModel>> Fenye2(int a, int b, string id, string name, DateTime time1, DateTime time2);//条件分页
    }
}

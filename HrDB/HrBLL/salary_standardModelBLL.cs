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
    public class salary_standardModelBLL : salary_standardModelIBLL
    {
        public salary_standardModelIDAO MyProperty { get; set; }
        public int BJCreate(salary_standardModel bjm)
        {
            return MyProperty.BJCreate(bjm);
        }

        public int BJDelete(salary_standardModel bjm)
        {
            throw new NotImplementedException();
        }

        public int BJEdit(salary_standardModel bjm)
        {
            return MyProperty.BJEdit(bjm);
        }

        public List<salary_standardModel> BJSelect()
        {
            return MyProperty.BJSelect();
        }

        public List<string> BJSelectBy(string name)
        {
            return MyProperty.BJSelectBy(name);
        }

        public salary_standardModel BJSelectBy2(int id)
        {
            return MyProperty.BJSelectBy2(id);
        }

        public Dictionary<int,List<salary_standardModel>> Fenye(int a, int b)
        {
            return MyProperty.Fenye(a,b);
        }

        public Dictionary<int, List<salary_standardModel>> Fenye2(int a, int b, string id, string name, DateTime time1, DateTime time2)
        {
            return MyProperty.Fenye2(a,b,id,name,time1,time2);
        }
    }
}

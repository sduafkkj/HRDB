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
    public class salary_standard_detailsModelBLL : salary_standard_detailsModelIBLL
    {
        public salary_standard_detailsModelIDAO MyProperty { get; set; }
        public int BJCreate(salary_standard_detailsModel bjm)
        {
            return MyProperty.BJCreate(bjm);
        }

        public int BJDelete(salary_standard_detailsModel bjm)
        {
            throw new NotImplementedException();
        }

        public int BJEdit(salary_standard_detailsModel bjm)
        {
            return MyProperty.BJEdit(bjm);
        }

        public List<salary_standard_detailsModel> BJSelect()
        {
            return MyProperty.BJSelect();
        }

        public List<string> BJSelectBy(string name)
        {
            return MyProperty.BJSelectBy(name);
        }

        public List<salary_standard_detailsModel> BJSelectBy2(string id)
        {
            return MyProperty.BJSelectBy2(id);
        }

        public List<salary_standard_detailsModel> BJSelectBy3(string id)
        {
            return MyProperty.BJSelectBy3(id);
        }
    }
}

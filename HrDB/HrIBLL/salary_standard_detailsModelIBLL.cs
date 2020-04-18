using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrModell;
namespace HrIBLL
{
   public interface salary_standard_detailsModelIBLL
    {
        List<salary_standard_detailsModel> BJSelect();

        int BJCreate(salary_standard_detailsModel bjm);

        List<string> BJSelectBy(string name);

        List<salary_standard_detailsModel> BJSelectBy2(string id);

        List<salary_standard_detailsModel> BJSelectBy3(string id);

        int BJEdit(salary_standard_detailsModel bjm);

        int BJDelete(salary_standard_detailsModel bjm);
    }
}

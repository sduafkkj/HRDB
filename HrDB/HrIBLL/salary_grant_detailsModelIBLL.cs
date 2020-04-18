using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrModell;
namespace HrIBLL
{
   public interface salary_grant_detailsModelIBLL
    {
        int BJCreate(salary_grant_detailsModel bjm);

        List<salary_grant_detailsModel> SelectById(int id);

        int BJEdit(salary_grant_detailsModel bjm);

        List<salary_grant_detailsModel> SelectById2(int id,int id2);
    }
}

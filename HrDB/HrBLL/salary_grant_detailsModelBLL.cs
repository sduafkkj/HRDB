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
    public class salary_grant_detailsModelBLL : salary_grant_detailsModelIBLL
    {
        public salary_grant_detailsModelIDAO MyProperty { get; set; }
        public int BJCreate(salary_grant_detailsModel bjm)
        {
            return MyProperty.BJCreate(bjm);
        }

        public int BJEdit(salary_grant_detailsModel bjm)
        {
            return MyProperty.BJEdit(bjm);
        }

        public List<salary_grant_detailsModel> SelectById(int id)
        {
            return MyProperty.SelectById(id);
        }

        public List<salary_grant_detailsModel> SelectById2(int id ,int id2)
        {
            return MyProperty.SelectById2(id,id2);
        }
    }
}

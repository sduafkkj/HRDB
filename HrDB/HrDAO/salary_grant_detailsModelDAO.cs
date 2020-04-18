using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrModell;
using HrIDAO;
using HrEFProject;
namespace HrDAO
{
    public class salary_grant_detailsModelDAO : DaoBase<salary_grant_details>, salary_grant_detailsModelIDAO
    {
        public int BJCreate(salary_grant_detailsModel bjm)
        {
            //把DTO->EO
            salary_grant_details bj = new salary_grant_details()
            {
                salary_grant_id = bjm.salary_grant_id,
                salary_standard_id = bjm.salary_standard_id,
                human_id = bjm.human_id,
                human_name = bjm.human_name,
                bouns_sum = bjm.bouns_sum,
                sale_sum = bjm.sale_sum,
                deduct_sum = bjm.deduct_sum,
                salary_standard_sum = bjm.salary_standard_sum,
                salary_paid_sum = bjm.salary_paid_sum
                
            };
            return Add(bj);
        }

        public int BJEdit(salary_grant_detailsModel bjm)
        {
            salary_grant_details bj = new salary_grant_details()
            {
                salary_grant_id = bjm.salary_grant_id,
                grd_id = bjm.grd_id,
                salary_standard_id = bjm.salary_standard_id,
                human_id = bjm.human_id,
                human_name = bjm.human_name,
                bouns_sum = bjm.bouns_sum,
                sale_sum = bjm.sale_sum,
                deduct_sum = bjm.deduct_sum,
                salary_standard_sum = bjm.salary_standard_sum,
                salary_paid_sum = bjm.salary_paid_sum

            };
            return Edit(bj);
        }

        public List<salary_grant_detailsModel> SelectById(int id)
        {
            List<salary_grant_details> bj = SelectByGrant(id);
            List<salary_grant_detailsModel> list = new List<salary_grant_detailsModel>();
            //把EO->DTO
            foreach (salary_grant_details item in bj)
            {
                salary_grant_detailsModel bjm = new salary_grant_detailsModel()
                {
                    salary_grant_id = item.salary_grant_id,
                    grd_id=item.grd_id,
                    salary_standard_id = item.salary_standard_id,
                    human_id = item.human_id,
                    human_name = item.human_name,
                    bouns_sum = item.bouns_sum,
                    sale_sum = item.sale_sum,
                    deduct_sum = item.deduct_sum,
                    salary_standard_sum = item.salary_standard_sum,
                    salary_paid_sum = item.salary_paid_sum
                };
                list.Add(bjm);
            }

            return list;
        }

        public List<salary_grant_detailsModel> SelectById2(int id,int id2)
        {
            List<salary_grant_details> bj = SelectGrant11(id,id2);
            List<salary_grant_detailsModel> list = new List<salary_grant_detailsModel>();
            //把EO->DTO
            foreach (salary_grant_details item in bj)
            {
                salary_grant_detailsModel bjm = new salary_grant_detailsModel()
                {
                    salary_grant_id = item.salary_grant_id,
                    grd_id = item.grd_id,
                    salary_standard_id = item.salary_standard_id,
                    human_id = item.human_id,
                    human_name = item.human_name,
                    bouns_sum = item.bouns_sum,
                    sale_sum = item.sale_sum,
                    deduct_sum = item.deduct_sum,
                    salary_standard_sum = item.salary_standard_sum,
                    salary_paid_sum = item.salary_paid_sum
                };
                list.Add(bjm);
            }

            return list;
        }
    }
}

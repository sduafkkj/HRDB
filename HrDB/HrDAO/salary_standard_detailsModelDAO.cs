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
    public class salary_standard_detailsModelDAO : DaoBase<salary_standard_details>, salary_standard_detailsModelIDAO
    {
        public int BJCreate(salary_standard_detailsModel bjm)
        {
            salary_standard_details bj = new salary_standard_details()
            {
                standard_id = bjm.standard_id,
                standard_name = bjm.standard_name,
                item_id = bjm.item_id,
                item_name = bjm.item_name,
                salary = bjm.salary
              
            };
            return Add(bj);
        }

        public int BJDelete(salary_standard_detailsModel bjm)
        {
            throw new NotImplementedException();
        }

        public int BJEdit(salary_standard_detailsModel bjm)
        {
            salary_standard_details bj = new salary_standard_details()
            {
                
                standard_id = bjm.standard_id,
                standard_name = bjm.standard_name,
                sdt_id = bjm.sdt_id,
                item_id = bjm.item_id,
                item_name = bjm.item_name,
                salary = bjm.salary

            };
            return Edit(bj);
        }

        public List<salary_standard_detailsModel> BJSelect()
        {
            List<salary_standard_details> list = Select();
            List<salary_standard_detailsModel> list2 = new List<salary_standard_detailsModel>();
            //需要把ED->DTO
            foreach (salary_standard_details item in list)
            {
                salary_standard_detailsModel bjm = new salary_standard_detailsModel()
                {
                    standard_id = item.standard_id,
                    standard_name=item.standard_name,
                    sdt_id=item.sdt_id,
                    item_id=item.item_id,
                    item_name=item.item_name,
                    salary=item.salary
                };
                list2.Add(bjm);
            }
            return list2;
        }

        public List<string> BJSelectBy(string name)
        {
           List<string>list= SelectBy(name);
            //把EO->DTO
          
            return list;
        }

        public List<salary_standard_detailsModel> BJSelectBy2(string id)
        {
            List<salary_standard_details> bj = SelectBy1(id);
            List<salary_standard_detailsModel> list = new List<salary_standard_detailsModel>();
            //把EO->DTO
            foreach (salary_standard_details item in bj)
            {
                salary_standard_detailsModel bjm = new salary_standard_detailsModel()
                {
                    sdt_id = item.sdt_id,
                    standard_id = item.standard_id,
                    standard_name = item.standard_name,
                    item_id = item.item_id,
                    item_name = item.item_name,
                    salary = item.salary
                };
                list.Add(bjm);
            }
           
            return list;
        }

        public List<salary_standard_detailsModel> BJSelectBy3(string id)
        {
            List<salary_standard_details> bj = SelectBy3(id);
            List<salary_standard_detailsModel> list = new List<salary_standard_detailsModel>();
            //把EO->DTO
            foreach (salary_standard_details item in bj)
            {
                salary_standard_detailsModel bjm = new salary_standard_detailsModel()
                {
                    sdt_id = item.sdt_id,
                    standard_id = item.standard_id,
                    standard_name = item.standard_name,
                    item_id = item.item_id,
                    item_name = item.item_name,
                    salary = item.salary
                };
                list.Add(bjm);
            }

            return list;
        }
    }
}

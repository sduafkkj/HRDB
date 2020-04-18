using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrModell;
using HrIDAO;
using HrEFProject;
using System.Linq.Expressions;

namespace HrDAO
{
    public class HumenModelDAO : DaoBase<Humen>, HumenModelIDAO
    {
        public int BJEdit(HumenModel bjm)
        {
            Humen bj = new Humen()
            {
                hfd_id=bjm.hfd_id,
                first_kind_id=bjm.first_kind_id,
                human_id = bjm.human_id,
                first_kind_name = bjm.first_kind_name,
                second_kind_id = bjm.second_kind_id,
                second_kind_name = bjm.second_kind_name,
                third_kind_id = bjm.third_kind_id,
                third_kind_name = bjm.third_kind_name,
                human_name = bjm.human_name,
                salary_standard_id = bjm.salary_standard_id,
                salary_standard_name = bjm.salary_standard_name,
                salary_sum = bjm.salary_sum,
                demand_salaray_sum = bjm.demand_salaray_sum,
                paid_salary_sum = bjm.paid_salary_sum,
                statu=bjm.statu,
            };
            return Edit(bj);
        }

        public List<HumenModel> GetPageList(int pageIndex, int pageSize, ref int totalCount)
        {
            string strSql = "select * from salary_grant";
            string orderfied = "order by sgr_id desc";
            var data=SelectPageList<Humen>(strSql, pageIndex, pageSize, orderfied, ref totalCount);
            List<Humen> list = data.ToList();
            List<HumenModel> list2 = new List<HumenModel>();
            //需要把ED->DTO
            foreach (Humen item in list)
            {
                HumenModel bjm = new HumenModel()
                {
                    human_id = item.human_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    human_name = item.human_name,
                    salary_standard_id = item.salary_standard_id,
                    salary_standard_name = item.salary_standard_name,
                    salary_sum = item.salary_sum,
                    demand_salaray_sum = item.demand_salaray_sum,
                    paid_salary_sum = item.paid_salary_sum,

                };
                list2.Add(bjm);
            }
            return list2;
        }

        public List<HumenModel> SelectById(int id)
        {

            List<Humen> list = SelectByIds(id);
            List<HumenModel> list2 = new List<HumenModel>();
            //需要把ED->DTO
            foreach (Humen item in list)
            {
                HumenModel bjm = new HumenModel()
                {
                    human_id=item.human_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    human_name = item.human_name,
                    salary_standard_id = item.salary_standard_id,
                    salary_standard_name = item.salary_standard_name,
                    salary_sum = item.salary_sum,
                    demand_salaray_sum = item.demand_salaray_sum,
                    paid_salary_sum = item.paid_salary_sum,

                };
                list2.Add(bjm);
            }
            return list2;
        }

        public List<HumenModel> SelectById2(int id)
        {
            List<Humen> list = SelectByIds1(id);
            List<HumenModel> list2 = new List<HumenModel>();
            //需要把ED->DTO
            foreach (Humen item in list)
            {
                HumenModel bjm = new HumenModel()
                {
                    human_id = item.human_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    human_name = item.human_name,
                    salary_standard_id = item.salary_standard_id,
                    salary_standard_name = item.salary_standard_name,
                    salary_sum = item.salary_sum,
                    demand_salaray_sum = item.demand_salaray_sum,
                    paid_salary_sum = item.paid_salary_sum,

                };
                list2.Add(bjm);
            }
            return list2;
        }

        public List<HumenModel> SelectById3(int id)
        {
            List<Humen> list = SelectByIds2(id);
            List<HumenModel> list2 = new List<HumenModel>();
            //需要把ED->DTO
            foreach (Humen item in list)
            {
                HumenModel bjm = new HumenModel()
                {
                    human_id = item.human_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    human_name = item.human_name,
                    salary_standard_id = item.salary_standard_id,
                    salary_standard_name = item.salary_standard_name,
                    salary_sum = item.salary_sum,
                    demand_salaray_sum = item.demand_salaray_sum,
                    paid_salary_sum = item.paid_salary_sum,

                };
                list2.Add(bjm);
            }
            return list2;
        }

        public List<HumenModel> SelectById4(int id)
        {
            List<Humen> list =SelectByHid(id);
            List<HumenModel> list2 = new List<HumenModel>();
            //需要把ED->DTO
            foreach (Humen item in list)
            {
                HumenModel bjm = new HumenModel()
                {
                    human_id = item.human_id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    human_name = item.human_name,
                    salary_standard_id = item.salary_standard_id,
                    salary_standard_name = item.salary_standard_name,
                    salary_sum = item.salary_sum,
                    demand_salaray_sum = item.demand_salaray_sum,
                    paid_salary_sum = item.paid_salary_sum,
                };
                list2.Add(bjm);
            }
            return list2;
        }

        public List<HumenModel> SelectHid(int id)
        {
            List<Humen> bj = SelectHumenId(id);
            List<HumenModel> list = new List<HumenModel>();
            //把EO->DTO
            foreach (Humen item in bj)
            {
                HumenModel bjm = new HumenModel()
                {
                    hfd_id=item.hfd_id,
                    human_id = item.human_id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    human_name = item.human_name,
                    salary_standard_id = item.salary_standard_id,
                    salary_standard_name = item.salary_standard_name,
                    salary_sum = item.salary_sum,
                    demand_salaray_sum = item.demand_salaray_sum,
                    paid_salary_sum = item.paid_salary_sum,
                    statu=item.statu,
                };
                list.Add(bjm);
            }

            return list;
        }

        public List<HumenModel> SelectSid(int id)
        {
            List<Humen> list =SelectBSid(id);
            List<HumenModel> list2 = new List<HumenModel>();
            //需要把ED->DTO
            foreach (Humen item in list)
            {
                HumenModel bjm = new HumenModel()
                {
                    human_id = item.human_id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    human_name = item.human_name,
                    salary_standard_id = item.salary_standard_id,
                    salary_standard_name = item.salary_standard_name,
                    salary_sum = item.salary_sum,
                    demand_salaray_sum = item.demand_salaray_sum,
                    paid_salary_sum = item.paid_salary_sum,
                };
                list2.Add(bjm);
            }
            return list2;
        }
    }
}

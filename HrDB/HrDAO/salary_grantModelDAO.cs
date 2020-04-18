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
    public class salary_grantModelDAO : DaoBase<salary_grant>, salary_grantModelIDAO
    {
        public int BJCreate(salary_grantModel bjm)
        {
            //把DTO->EO
            salary_grant bj = new salary_grant()
            {
                salary_grant_id = bjm.salary_grant_id,
                salary_standard_id = bjm.salary_standard_id,
                first_kind_id = bjm.first_kind_id,
                first_kind_name = bjm.first_kind_name,
                second_kind_id = bjm.second_kind_id,
                second_kind_name = bjm.second_kind_name,
                third_kind_id = bjm.third_kind_id,
                third_kind_name = bjm.third_kind_name,
                human_amount = bjm.human_amount,
                salary_standard_sum = bjm.salary_standard_sum,
                salary_paid_sum = bjm.salary_paid_sum,
                register = bjm.register,
                regist_time = bjm.regist_time,
                checker = bjm.checker,
                check_time = bjm.check_time,
                check_status = bjm.check_status               
            };
            return Add(bj);
        }

        public int BJEdit(salary_grantModel bjm)
        {
            salary_grant bj = new salary_grant()
            {
                sgr_id = bjm.sgr_id,
                salary_grant_id = bjm.salary_grant_id,
                salary_standard_id = bjm.salary_standard_id,
                first_kind_id = bjm.first_kind_id,
                first_kind_name = bjm.first_kind_name,
                second_kind_id = bjm.second_kind_id,
                second_kind_name = bjm.second_kind_name,
                third_kind_id = bjm.third_kind_id,
                third_kind_name = bjm.third_kind_name,
                human_amount = bjm.human_amount,
                salary_standard_sum = bjm.salary_standard_sum,
                salary_paid_sum = bjm.salary_paid_sum,
                register = bjm.register,
                regist_time = bjm.regist_time,
                checker = bjm.checker,
                check_time = bjm.check_time,
                check_status = bjm.check_status

            };
            return Edit(bj);
        }

        public List<salary_grantModel> GetPageList(int pageIndex, int pageSize, ref int totalCount)
        {
            string strSql = "select * from salary_grant";
            string orderfied = "order by sgr_id desc";
            var data = SelectPageList<salary_grant>(strSql, pageIndex, pageSize, orderfied, ref totalCount);
            List<salary_grant> list = data.ToList();
            List<salary_grantModel> list2 = new List<salary_grantModel>();
            //需要把ED->DTO
            foreach (salary_grant item in list)
            {
                salary_grantModel bjm = new salary_grantModel()
                {
                    salary_grant_id = item.salary_grant_id,                  
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    human_amount = item.human_amount,
                    salary_standard_sum = item.salary_standard_sum,
                    salary_paid_sum = item.salary_paid_sum,
                    register = item.register,
                    regist_time = item.regist_time,
                    checker = item.checker,
                    check_time = item.check_time,
                    check_status = item.check_status

                };
                list2.Add(bjm);
            }
            return list2;
        }

        public List<salary_grantModel> GetPageList2(int pageIndex, int pageSize, ref int totalCount, string gid, string name, string time, string time2)
        {
            string strSql =$"select * from [dbo].[salary_grant] where [salary_grant_id] like '%{gid}%' and([first_kind_name] like '%{name}%' or[second_kind_name] like '%{name}%' or[third_kind_name] like '%{name}%')and[regist_time] > '{time}' and[regist_time] < '{time2}' ";
            string orderfied = "order by sgr_id desc";
            var data = SelectPageList<salary_grant>(strSql, pageIndex, pageSize, orderfied, ref totalCount);
            List<salary_grant> list = data.ToList();
            List<salary_grantModel> list2 = new List<salary_grantModel>();
            //需要把ED->DTO
            foreach (salary_grant item in list)
            {
                salary_grantModel bjm = new salary_grantModel()
                {
                    salary_grant_id = item.salary_grant_id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    human_amount = item.human_amount,
                    salary_standard_sum = item.salary_standard_sum,
                    salary_paid_sum = item.salary_paid_sum,
                    register = item.register,
                    regist_time = item.regist_time,
                    checker = item.checker,
                    check_time = item.check_time,
                    check_status = item.check_status

                };
                list2.Add(bjm);
            }
            return list2;
        }

        public List<salary_grantModel> SelectById(int id)
        {

            List<salary_grant> bj = SelectByGrant2(id);
            List<salary_grantModel> list = new List<salary_grantModel>();
            //把EO->DTO
            foreach (salary_grant item in bj)
            {
                salary_grantModel bjm = new salary_grantModel()
                {
                    salary_grant_id = item.salary_grant_id,
                    sgr_id=item.sgr_id,
                    salary_standard_id=item.salary_standard_id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    human_amount = item.human_amount,
                    salary_standard_sum = item.salary_standard_sum,
                    salary_paid_sum = item.salary_paid_sum,
                    register = item.register,
                    regist_time = item.regist_time,
                    checker = item.checker,
                    check_time = item.check_time,
                    check_status = item.check_status
                };
                list.Add(bjm);
            }

            return list;
        }

        public List<salary_grantModel> SelectById2(int id)
        {
            List<salary_grant> bj = SelectGrant3(id);
            List<salary_grantModel> list = new List<salary_grantModel>();
            //把EO->DTO
            foreach (salary_grant item in bj)
            {
                salary_grantModel bjm = new salary_grantModel()
                {
                    salary_grant_id = item.salary_grant_id,
                    sgr_id = item.sgr_id,
                    salary_standard_id = item.salary_standard_id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                    human_amount = item.human_amount,
                    salary_standard_sum = item.salary_standard_sum,
                    salary_paid_sum = item.salary_paid_sum,
                    register = item.register,
                    regist_time = item.regist_time,
                    checker = item.checker,
                    check_time = item.check_time,
                    check_status = item.check_status
                };
                list.Add(bjm);
            }

            return list;
        }
    }
}

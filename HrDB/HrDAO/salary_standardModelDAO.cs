using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrIDAO;
using HrModell;
using HrEFProject;
namespace HrDAO
{
    public class salary_standardModelDAO : DaoBase<salary_standard>, salary_standardModelIDAO
    {
        public int BJCreate(salary_standardModel bjm)
        {
            //把DTO->EO
            salary_standard bj = new salary_standard()
            {
                standard_id = bjm.standard_id,
                standard_name = bjm.standard_name,
                designer = bjm.designer,
                register = bjm.register,
                checker = bjm.checker,
                changer = bjm.changer,
                regist_time =DateTime.Now,
                check_time = bjm.check_time,
                change_time = bjm.change_time,
                check_status = bjm.check_status,
                change_status = bjm.change_status,
                check_comment = bjm.check_comment,
                salary_sum=bjm.salary_sum,
                remark = bjm.remark
            };
            return Add(bj);
        }

        public int BJDelete(salary_standardModel bjm)
        {
            throw new NotImplementedException();
        }

        public int BJEdit(salary_standardModel bjm)
        {
            salary_standard bj = new salary_standard()
            {
                ssd_id = bjm.ssd_id,
                standard_id = bjm.standard_id,
                standard_name = bjm.standard_name,
                designer = bjm.designer,
                register = bjm.register,
                checker = bjm.checker,
                changer = bjm.changer,
                regist_time = bjm.regist_time,
                check_time = bjm.check_time,
                change_time = bjm.change_time,
                check_status =1,
                change_status = bjm.change_status,
                check_comment = bjm.check_comment,
                salary_sum=bjm.salary_sum,
                remark = bjm.remark
            };
            return Edit(bj);
        }

        public List<salary_standardModel> BJSelect()
        {
            List<salary_standard> list = Select();
            List<salary_standardModel> list2 = new List<salary_standardModel>();
            //需要把ED->DTO
            foreach (salary_standard item in list)
            {
                salary_standardModel bjm = new salary_standardModel()
                {
                    ssd_id=item.ssd_id,
                    standard_id = item.standard_id,
                    standard_name = item.standard_name,
                    designer = item.designer,
                    register = item.register,
                    checker = item.checker,
                    changer = item.changer,
                    regist_time = item.regist_time,
                    check_time = item.check_time,
                    change_time = item.change_time,
                    check_status = item.check_status,
                    change_status = item.change_status,
                    check_comment = item.check_comment,
                    remark = item.remark
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

        public salary_standardModel BJSelectBy2(int id)
        {
            salary_standard bj = SelectBy2(id);
            //把EO->DTO
            salary_standardModel bjm = new salary_standardModel()
            {
                ssd_id = bj.ssd_id,
                standard_id = bj.standard_id,
                standard_name = bj.standard_name,
                designer = bj.designer,
                register = bj.register,
                checker = bj.checker,
                changer = bj.changer,
                regist_time = bj.regist_time,
                check_time = bj.check_time,
                change_time = bj.change_time,
                check_status = bj.check_status,
                change_status = bj.change_status,
                check_comment = bj.check_comment,
                salary_sum=bj.salary_sum,
                remark = bj.remark
            };
            return bjm;
        }

        Dictionary<int, List<salary_standardModel>> salary_standardModelIDAO.Fenye(int a, int b)
        {
            Dictionary<int, List<salary_standard>> dic = new Dictionary<int, List<salary_standard>>();
            Dictionary<int, List<salary_standardModel>> dic1 = new Dictionary<int, List<salary_standardModel>>();
            dic =Fenye(a,b);
            List<salary_standardModel> list2 = new List<salary_standardModel>();
            int rows = 0;
            foreach (KeyValuePair<int, List<salary_standard>> item1 in dic)
            {
                rows = item1.Key;
                foreach (salary_standard item in item1.Value)
                {
                    salary_standardModel bjm = new salary_standardModel()
                    {
                        ssd_id = item.ssd_id,
                        standard_id = item.standard_id,
                        standard_name = item.standard_name,
                        designer = item.designer,
                        register = item.register,
                        checker = item.checker,
                        changer = item.changer,
                        regist_time = item.regist_time,
                        check_time = item.check_time,
                        change_time = item.change_time,
                        check_status = item.check_status,
                        change_status = item.change_status,
                        check_comment = item.check_comment,
                        salary_sum=item.salary_sum,
                        remark = item.remark
                    };
                    list2.Add(bjm);
                }
              
            }
            dic1.Add(rows,list2);
            return dic1;
        }

        Dictionary<int, List<salary_standardModel>> salary_standardModelIDAO.Fenye2(int a, int b, string id, string name, DateTime time1, DateTime time2)
        {
            Dictionary<int, List<salary_standard>> dic = new Dictionary<int, List<salary_standard>>();
            Dictionary<int, List<salary_standardModel>> dic1 = new Dictionary<int, List<salary_standardModel>>();
            dic = Fenye2(a, b,id,name,time1,time2);
            List<salary_standardModel> list2 = new List<salary_standardModel>();
            int rows = 0;
            foreach (KeyValuePair<int, List<salary_standard>> item1 in dic)
            {
                rows = item1.Key;
                foreach (salary_standard item in item1.Value)
                {
                    salary_standardModel bjm = new salary_standardModel()
                    {
                        ssd_id = item.ssd_id,
                        standard_id = item.standard_id,
                        standard_name = item.standard_name,
                        designer = item.designer,
                        register = item.register,
                        checker = item.checker,
                        changer = item.changer,
                        regist_time = item.regist_time,
                        check_time = item.check_time,
                        change_time = item.change_time,
                        check_status = item.check_status,
                        change_status = item.change_status,
                        check_comment = item.check_comment,
                        salary_sum = item.salary_sum,
                        remark = item.remark
                    };
                    list2.Add(bjm);
                }

            }
            dic1.Add(rows, list2);
            return dic1;
        }
    }
}

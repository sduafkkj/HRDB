using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HrEFProject;
namespace HrDAO
{
    public class DaoBase<T> where T : class
    {
        HrDBContext hrdb = new HrDBContext();
        public List<T> Select()
        {
            //Set<T>():DbSet
            return hrdb.Set<T>().AsNoTracking().ToList();
        }
        public int Add(T t)
        {
            hrdb.Set<T>().Add(t);
            return hrdb.SaveChanges();
        }

        public List<string> SelectBy(Object obj)
        {
            List<string> list = new List<string>();
            var result = from e in hrdb.salar1
                             // where e.BZ == "S1"
                             //where e.BZ.Contains("1") //like '%1%'
                             // where e.BZ.StartsWith("S") //like 'S%'
                             //where e.BZ.EndsWith("2")  //like '%2'
                         where e.standard_name==""+obj+""//多条件的
                         select e;
         
            foreach (var item in result)
            {
                list.Add(item.standard_id);
            }
            return list;
        }
        public List<Humen> SelectByIds(int obj)//一级机构表id查询
        {
            List<Humen> list = new List<Humen>();
            var result = from e in hrdb.hu
                             // where e.BZ == "S1"
                             //where e.BZ.Contains("1") //like '%1%'
                             // where e.BZ.StartsWith("S") //like 'S%'
                             //where e.BZ.EndsWith("2")  //like '%2'
                         where e.first_kind_id==obj && e.statu==0//多条件的
                         select e;
            list = result.ToList();
            return list;
        }
        public List<Humen> SelectByIds1(int obj)//一级机构表id查询
        {
            List<Humen> list = new List<Humen>();
            var result = from e in hrdb.hu
                             // where e.BZ == "S1"
                             //where e.BZ.Contains("1") //like '%1%'
                             // where e.BZ.StartsWith("S") //like 'S%'
                             //where e.BZ.EndsWith("2")  //like '%2'
                         where e.second_kind_id == obj &&e.statu==0//多条件的
                         select e;
            list = result.ToList();
            return list;
        }
        public List<Humen> SelectByIds2(int obj)//一级机构表id查询
        {
            List<Humen> list = new List<Humen>();
            var result = from e in hrdb.hu
                             // where e.BZ == "S1"
                             //where e.BZ.Contains("1") //like '%1%'
                             // where e.BZ.StartsWith("S") //like 'S%'
                             //where e.BZ.EndsWith("2")  //like '%2'
                         where e.third_kind_id == obj && e.statu == 0//多条件的
                         select e;
            list = result.ToList();
            return list;
        }
        public List<salary_standard_details> SelectBy1(Object obj)
        {
            List<salary_standard_details> list = new List<salary_standard_details>();
            var result = from e in hrdb.salar1
                             // where e.BZ == "S1"
                             //where e.BZ.Contains("1") //like '%1%'
                             // where e.BZ.StartsWith("S") //like 'S%'
                             //where e.BZ.EndsWith("2")  //like '%2'
                         where e.standard_id == "" + obj + ""//多条件的
                         select e;
            list = result.ToList();
           
            return list;
        }
        public List<salary_grant_details> SelectByGrant(int obj)
        {
            List<salary_grant_details> list = new List<salary_grant_details>();
            var result = from e in hrdb.sg1
                             // where e.BZ == "S1"
                             //where e.BZ.Contains("1") //like '%1%'
                             // where e.BZ.StartsWith("S") //like 'S%'
                             //where e.BZ.EndsWith("2")  //like '%2'
                         where e.salary_grant_id== obj//多条件的
                         select e;
            list = result.ToList();

            return list;
        }
        public List<salary_grant_details> SelectGrant11(int id,int id2)
        {
            List<salary_grant_details> list = new List<salary_grant_details>();
            var persons = hrdb.sg1.Where(p => p.salary_standard_id == id&&p.salary_grant_id==id2).AsNoTracking();
            foreach (var item in persons)
            {
                salary_grant_details bjm = new salary_grant_details()
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
        public List<Humen> SelectHumenId(int id)
        {
            List<Humen> list = new List<Humen>();
            var persons = hrdb.hu.Where(p => p.human_id == id).AsNoTracking();
            foreach (var item in persons)
            {
                Humen bjm = new Humen()
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
        public List<salary_grant> SelectByGrant2(int obj)
        {
            List<salary_grant> list = new List<salary_grant>();
            var result = from e in hrdb.sg
                             // where e.BZ == "S1"
                             //where e.BZ.Contains("1") //like '%1%'
                             // where e.BZ.StartsWith("S") //like 'S%'
                             //where e.BZ.EndsWith("2")  //like '%2'
                         where e.salary_grant_id == obj//多条件的
                         select e;
            list = result.ToList();

            return list;
        }
        public List<salary_grant> SelectGrant3(int id)
        {
            List<salary_grant> list = new List<salary_grant>();
            var persons = hrdb.sg.Where(p => p.salary_grant_id == id).AsNoTracking();
            foreach (var item in persons)
            {
                salary_grant bj = new salary_grant()
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
                list.Add(bj);

            }
            return list;
        }
        public List<Humen> SelectBSid(int obj)
        {
            List<Humen> list = new List<Humen>();
            var result = from e in hrdb.hu
                             // where e.BZ == "S1"
                             //where e.BZ.Contains("1") //like '%1%'
                             // where e.BZ.StartsWith("S") //like 'S%'
                             //where e.BZ.EndsWith("2")  //like '%2'
                         where e.salary_standard_id== obj//多条件的
                         select e;
            list = result.ToList();

            return list;
        }
        private void FenLi(T t)//分离状态
        {
            var ObjContext = ((IObjectContextAdapter)hrdb).ObjectContext;//第1处
            //2 创建新的 ObjectSet< TEntity > 实例
            var objSet = ObjContext.CreateObjectSet<T>();
            //3 为特定对象创建实体键，如果实体键已存在，则返回该键。
            var objKey = ObjContext.CreateEntityKey(objSet.EntitySet.Name, t);//第2处
            //4 返回具有指定实体键的对象。
            object objT;
            var ext = ObjContext.TryGetObjectByKey(objKey, out objT);
            //5 从对象上下文移除对象。
            if (ext)
            {

                ObjContext.Detach(objT);
            }
        }
        public List<Humen> SelectByHid(int obj)
        {
            List<Humen> list = new List<Humen>();
            var result = from e in hrdb.hu
                             // where e.BZ == "S1"
                             //where e.BZ.Contains("1") //like '%1%'
                             // where e.BZ.StartsWith("S") //like 'S%'
                             //where e.BZ.EndsWith("2")  //like '%2'
                         where e.human_id ==obj//多条件的
                         select e;
            list = result.ToList();

            return list;
        }
        public int Edit(T t)
        {
            FenLi(t);
            hrdb.Set<T>().Attach(t);
            //t对象的属性值都要有
            hrdb.Entry(t).State = System.Data.Entity.EntityState.Modified;
            return hrdb.SaveChanges();
        }
      

        public int Delete(T t)
        {
            hrdb.Set<T>().Attach(t);
            hrdb.Entry(t).State = System.Data.Entity.EntityState.Deleted;
            return hrdb.SaveChanges();
        }

        public Dictionary<int,List<salary_standard>> Fenye(int currepage,int pagesize) {
         
            var data =hrdb.salar.OrderBy(e => e.ssd_id);
            int rows = data.Count();//总行数
            var result = data.Skip((currepage - 1) * pagesize)//忽略多少条
                  .Take(pagesize);//取多少条
            List<salary_standard> list = new List<salary_standard>();
            list = result.ToList();
            Dictionary<int, List<salary_standard>> dic = new Dictionary<int, List<salary_standard>>();
            dic.Add(rows,list);
            return dic;
        }
        public Dictionary<int, List<salary_standard>> Fenye2(int currepage, int pagesize,string id,string name,DateTime time1, DateTime time2)//按条件分页
        {
            Dictionary<int, List<salary_standard>> dic = new Dictionary<int, List<salary_standard>>();
            if (name != "" && id != "")
            {
                var data = hrdb.salar.OrderBy(e => e.ssd_id).Where(e => e.standard_id == id && e.standard_name == name && e.regist_time > time1 && e.regist_time < time2);
                dic= cx(currepage, pagesize, data);
            }
            else if (name == "" && id != "")
            {
                var data = hrdb.salar.OrderBy(e => e.ssd_id).Where(e => e.standard_id == id && e.regist_time > time1 && e.regist_time < time2);
                dic= cx(currepage, pagesize, data);
            }
            else if (id == "" && name != "")
            {
                var data = hrdb.salar.OrderBy(e => e.ssd_id).Where(e => e.standard_name == name && e.regist_time > time1 && e.regist_time < time2);
                dic= cx(currepage, pagesize, data);
            } else if (id == "" && name == "") {
                var data = hrdb.salar.OrderBy(e => e.ssd_id).Where(e => e.regist_time > time1 && e.regist_time < time2);
                dic= cx(currepage, pagesize, data);
            }
            return dic;

        }

        private static Dictionary<int, List<salary_standard>> cx(int currepage, int pagesize, IQueryable<salary_standard> data)
        {
            int rows = data.Count();//总行数
            var result = data.Skip((currepage - 1) * pagesize)//忽略多少条
                  .Take(pagesize);//取多少条
            List<salary_standard> list = new List<salary_standard>();
            list = result.ToList();
            Dictionary<int, List<salary_standard>> dic = new Dictionary<int, List<salary_standard>>();
            dic.Add(rows, list);
            return dic;
        }

        public T SelectBy2(Object obj)
        {
            return hrdb.Set<T>().Find(obj);
        }

        public List<salary_standard_details> SelectBy3(string id)
        {
            List<salary_standard_details> list = new List<salary_standard_details>();
            var persons = hrdb.salar1.Where(p => p.standard_id ==id).AsNoTracking();
            foreach (var item in persons)
            {
                salary_standard_details bj = new salary_standard_details()
                {
                    standard_id = item.standard_id,
                    standard_name = item.standard_name,
                    sdt_id = item.sdt_id,
                    item_id = item.item_id,
                    item_name = item.item_name,
                    salary = item.salary
                };
                list.Add(bj);
                
            }
            return list;
        }
        public List<T> FenYe<K>(Expression<Func<T, K>> order, Expression<Func<T, bool>> where, int currentPage, int PageSize, out int rows)
        {
            
            var result4 =hrdb.Set<T>()
                .AsNoTracking()
                .OrderBy(order);
            rows = result4.Count();//总行数
            var data = result4.Where(where)
                 .Skip((currentPage - 1) * PageSize)//忽略多少条数
                 .Take(PageSize)//取多少条数
                 .ToList();
            return data;
        }
        public  List<T> SelectPageList<T>(string sqlstr, int pageIndex, int pagesize, string orderByField, ref int totalCount) where T : class
        {
            SqlParameter[] spm = new SqlParameter[5];
            spm[0] = new SqlParameter("@Sql", sqlstr);
            spm[1] = new SqlParameter("@PageIndex", pageIndex);
            spm[2] = new SqlParameter("@PageSize", pagesize);
            spm[3] = new SqlParameter("@OrderByField", orderByField);
            spm[4] = new SqlParameter("@TotalRecord", totalCount);
            spm[4].Direction = ParameterDirection.Output;
            var data = hrdb.Database.SqlQuery<T>("exec Fenye @Sql,@PageIndex,@PageSize,@OrderByField,@TotalRecord out", spm).ToList();
            totalCount = Convert.ToInt32(spm[4].Value.ToString());
            return data;
        }

    }
}

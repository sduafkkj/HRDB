using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HrModell;
using HrEFProject;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    
    public class Try02Controller : ApiController
    {
        HrDBContext db = new HrDBContext();

        public List<HumenModel> GetHuman() {
            List<Humen> list = db.hu.ToList();
            List<HumenModel> list2 = new List<HumenModel>();
            foreach (Humen item in list)
            {
                HumenModel bjm = new HumenModel()
                {
                    hfd_id=item.hfd_id,
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

        [HttpGet]
        public HumenModel GetBj(int id)
        {
            Humen bj = db.hu.Find(id);
            HumenModel bjm = new HumenModel()
            {
                hfd_id=bj.hfd_id,
                human_id = bj.human_id,
                first_kind_name = bj.first_kind_name,
                second_kind_id = bj.second_kind_id,
                second_kind_name = bj.second_kind_name,
                third_kind_id = bj.third_kind_id,
                third_kind_name = bj.third_kind_name,
                human_name = bj.human_name,
                salary_standard_id = bj.salary_standard_id,
                salary_standard_name = bj.salary_standard_name,
                salary_sum = bj.salary_sum,
                demand_salaray_sum = bj.demand_salaray_sum,
                paid_salary_sum = bj.paid_salary_sum,
            };
            return bjm;
        }

        [HttpPost]
        public async Task<int> PostBj(Humen bj)
        {
            db.hu.Add(bj);
            int result = await db.SaveChangesAsync();
            return result;
        }
        [HttpPut]
        public async Task<int> PutBj(Humen bj)
        {            
            db.Set<Humen>().Attach(bj);
            db.Entry(bj).State = System.Data.Entity.EntityState.Modified;
            int result = await db.SaveChangesAsync();
            return result;
        }
        [HttpDelete]
        public async Task<int> Deletehu(int id )
        {
            Humen bj = db.hu.FirstOrDefault(e => e.hfd_id ==id);
            Console.WriteLine(db.Entry(bj).State);
            db.hu.Remove(bj);                   
            int result = await db.SaveChangesAsync();
            return result;
        }
    }
}

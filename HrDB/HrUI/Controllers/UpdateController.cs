using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HrIBLL;
using HrModell;
using Newtonsoft.Json;

namespace HrUI.Controllers
{
    public class UpdateController : Controller
    {
        // GET: Update
        public salary_standardModelIBLL MyProperty { get; set; }
        public salary_standard_detailsModelIBLL MyProperty2 { get; set; }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2(string id)
        {
            int page = 1;
            List<string> list = new List<string>(id.Split(','));
            if (list[2] == "")
            {
                list[2] = "1011-01-02";

            }
            if (list[3] == "")
            {
                list[3] = "3011-01-02";

            }
            if (list.Count == 5)
            {
                page = Convert.ToInt32(list[4]);
            }
            Dictionary<int, List<salary_standardModel>> list2 = MyProperty.Fenye2(page, 5, list[0], list[1], Convert.ToDateTime(list[2]), Convert.ToDateTime(list[3]));
            foreach (KeyValuePair<int, List<salary_standardModel>> item1 in list2)
            {
                ViewData["Data"] = item1.Value;
                int row = item1.Key;
                ViewData["row"] = row;
                ViewData["list"] = id;
                ViewData["page"] = page;
            }
            return View();
        }

        public ActionResult Upd(int id)
        {
            salary_standardModel sa = MyProperty.BJSelectBy2(id);

            salary_standard_detailsModel da = new salary_standard_detailsModel();
            List<salary_standard_detailsModel> li = MyProperty2.BJSelectBy2(sa.standard_id);
            foreach (salary_standard_detailsModel item in li)
            {
                if (item.item_name == "基本工资")
                {
                    sa.money1 = item.salary;

                }
                if (item.item_name == "岗位工资")
                {
                    sa.money2 = item.salary;

                }
                if (item.item_name == "交通补助")
                {
                    sa.money3 = item.salary;

                }
                if (item.item_name == "午餐补助")
                {
                    sa.money4 = item.salary;

                }
                if (item.item_name == "五险一金")
                {
                    sa.money5 = item.salary;

                }
            }
            ViewData.Model = sa;

            return View();
        }

        public ActionResult Upd2(salary_standardModel sa)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors).ToList();
            if (ModelState.IsValid)
            {
                if (MyProperty.BJEdit(sa) > 0)
                {
                    salary_standard_detailsModel sks = new salary_standard_detailsModel();
                    string id = sa.standard_id;
                    List<salary_standard_detailsModel> list = MyProperty2.BJSelectBy3(id);
                    for (int i = 0; i <list.Count; i++)
                    {
                        sks.sdt_id = list[i].sdt_id;
                        sks.standard_id = sa.standard_id;
                        sks.standard_name = sa.standard_name;
                        if (list[i].item_name=="基本工资") {
                            sks.item_id = 1;
                            sks.salary = sa.money1;
                        }
                        if (list[i].item_name == "岗位工资")
                        {
                            sks.item_id = 2;
                            sks.salary = sa.money2;
                        }
                        if (list[i].item_name == "交通补助")
                        {
                            sks.item_id = 3;
                            sks.salary = sa.money3;
                        }
                        if (list[i].item_name == "午餐补助")
                        {
                            sks.item_id = 4;
                            sks.salary = sa.money4;
                        }
                        if (list[i].item_name == "五险一金")
                        {
                            sks.item_id = 5;
                            sks.salary = sa.money5;
                        }
                        sks.item_name = list[i].item_name;                       
                        MyProperty2.BJEdit(sks);
                    }
                    return Content("<script>alert('修改成功');window.location.href='/Update/Index'</script>");
                }
                else
                {
                    return Content("<script>alert('修改失败');window.location.href='/Update/Index'</script>");
                }

            }

            else
            {
                return Content("<script>alert('请输入完整再提交');window.location.href='/Update/Upd/" + sa.ssd_id + "'</script>");
            }         
        }
    }
}
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
    public class CheckListController : Controller
    {
        // GET: CheckList
        public salary_standardModelIBLL MyProperty { get; set; }
        public salary_standard_detailsModelIBLL MyProperty2 { get; set; }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2(int id)
        {
           int pagesize = 5;
           Dictionary<int,List<salary_standardModel>>list=MyProperty.Fenye(id, pagesize);
            Dictionary<object, object> dic = new Dictionary<object, object>();
            foreach (KeyValuePair<int, List<salary_standardModel>> item1 in list)
            {
                dic["dt"] = item1.Value;
                int row  = item1.Key;
                dic["fy"] = row;
            }
           string zhi = JsonConvert.SerializeObject(dic);
           return Content(zhi);
        }
        [HttpGet]
        public ActionResult Fh(int id)
        {
            salary_standardModel sa=MyProperty.BJSelectBy2(id);
          
            salary_standard_detailsModel da = new salary_standard_detailsModel();
            List<salary_standard_detailsModel>li= MyProperty2.BJSelectBy2(sa.standard_id);
            foreach (salary_standard_detailsModel item in li)
            {
                if (item.item_name=="基本工资") {
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
            ViewData.Model =sa;
          
            return View();

        }
        [HttpPost]
        public ActionResult Fh(salary_standardModel sa)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors).ToList();
            if (ModelState.IsValid)
            {
                if (MyProperty.BJEdit(sa) > 0)
                {
                    return Content("<script>alert('修改成功');window.location.href='/CheckList/Index'</script>");
                }
                else {
                    return Content("<script>alert('修改失败');window.location.href='/CheckList/Index'</script>");
                }
            
            }
               
            else {
                return Content("<script>alert('请输入完整再提交');window.location.href='/CheckList/Fh/"+sa.ssd_id+"'</script>");
            }
        }
        }
}
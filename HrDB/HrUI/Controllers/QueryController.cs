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
    public class QueryController : Controller
    {
        // GET: Query
        public salary_standardModelIBLL MyProperty { get; set; }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2(string id)
        {
            int page=1;
            List<string> list = new List<string>(id.Split(','));
            if (list[2]=="") {
                list[2] = "1011-01-02";

            }
            if (list[3] == "")
            {
                list[3] = "3011-01-02";

            }
            if (list.Count==5) {
                page = Convert.ToInt32(list[4]);
            }
            Dictionary<int, List<salary_standardModel>> list2=MyProperty.Fenye2(page,5,list[0], list[1],Convert.ToDateTime(list[2]),Convert.ToDateTime(list[3]));
            foreach (KeyValuePair<int, List<salary_standardModel>> item1 in list2)
            {
                 ViewData["Data"]= item1.Value;
                int row = item1.Key;
                 ViewData["row"] = row;
                 ViewData["list"] = id;
                ViewData["page"] = page;
            }
            return View();
        }
    }
}
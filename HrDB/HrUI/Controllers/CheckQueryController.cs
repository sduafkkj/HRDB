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
    public class CheckQueryController : Controller
    {
        public salary_grantModelIBLL MyProperty { get; set; }
        // GET: CheckQuery
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2(string id) {
            List<string> list = new List<string>(id.Split(','));
            if (list[2] == "")
            {
                list[2] = "0011-01-02";

            }
            if (list[3] == "")
            {
                list[3] = "5011-01-02";

            }         
            Session["list"] = list;
            return View();
        }
        public ActionResult Index3(string id)
        {
            List<string>list=Session["list"] as List<string>;
            int row = 0;
           List<salary_grantModel>lla=MyProperty.GetPageList2(Convert.ToInt32(id),5,ref row,list[0],list[1],list[2],list[3]);
            Dictionary<object, object> dic = new Dictionary<object, object>();
            dic["dt"] =lla;
            dic["fy"] = row;
            string zhi = JsonConvert.SerializeObject(dic);
            return Content(zhi);          
        }
    }
}
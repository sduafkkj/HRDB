using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using HrIBLL;
using HrModell;
using Newtonsoft.Json;
namespace HrUI.Controllers
{

    public class GrantCheckController : Controller
    {
        public salary_grantModelIBLL MyProperty { get; set; }
        public salary_grant_detailsModelIBLL MyProperty2 { get; set; }
        public HumenModelBLL MyProperty3 { get; set; }
        public salary_standard_detailsModelIBLL MyProperty4 { get; set; }
        // GET: GrantCheck
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2(int id)
        {
            int row = 0;
            List<salary_grantModel>list=MyProperty.GetPageList(id,5,ref row);
            Dictionary<object, object> dic = new Dictionary<object, object>();           
                dic["dt"] =list;               
                dic["fy"] = row;            
            string zhi = JsonConvert.SerializeObject(dic);
            return Content(zhi);
           
        }
        public ActionResult Fh(int id)
        {
          List<salary_grantModel>sj=MyProperty.SelectById(id);
          List<salary_grant_detailsModel>list=MyProperty2.SelectById(sj[0].salary_grant_id);        
          List<salary_standard_detailsModel> kk = MyProperty4.BJSelectBy2(list[0].salary_standard_id.ToString());
            int j = 0;
            foreach (salary_grant_detailsModel item in list)
          {
              
                for (int i = 0; i <kk.Count ; i++)
                {
                    if (kk[i].item_name =="基本工资")
                    {
                        item.jb = kk[i].salary;
                    }
                    if (kk[i].item_name == "岗位工资")
                    {
                        item.gw = kk[i].salary;
                    }
                    if (kk[i].item_name == "交通补助")
                    {
                        item.jt = kk[i].salary;
                    }
                    if (kk[i].item_name == "午餐补助")
                    {
                        item.wc = kk[i].salary;
                    }
                    if (kk[i].item_name == "五险一金")
                    {
                        item.wx = kk[i].salary;
                    }
                }
                item.jl = list[j].bouns_sum;
                item.jx = list[j].sale_sum;
                item.yk = list[j].deduct_sum;
                item.sf = list[j].salary_paid_sum;
                item.zq= list[j].salary_standard_sum;
                item.grid= list[j].grd_id;
                item.sgrd = sj[0].sgr_id;               
                j++;
            }
           
          ViewData["list"] = list;
          ViewData["xcbh"] = id;
          ViewData["jgrs"] =sj[0].human_amount;
          ViewData["jbze"] = sj[0].salary_standard_sum;
          ViewData["sfze"] = sj[0].salary_paid_sum;
          return View();
        }
        [HttpPost]
        public ActionResult Fh(FormCollection collection)
        {
            string zid = collection["sgrid22"];
            List<string> ll = new List<string>(zid.Split(','));
            string zq= collection["sfzq"];
            string time = collection["time"];
            string name = collection["salaryGrant.checker"];
            string xcid = collection["xcid"];
            string row = collection["row"];
            List<salary_grantModel> sj = MyProperty.SelectById2(Convert.ToInt32(xcid));
            sj[0].salary_paid_sum = Convert.ToDouble(zq);
            sj[0].check_time =Convert.ToDateTime(time);
            sj[0].checker = name;
            sj[0].sgr_id =Convert.ToInt32(ll[0]);
            sj[0].salary_grant_id =Convert.ToInt32(xcid);
            if (MyProperty.BJEdit(sj[0]) > 0)
            {
                for (int i =1; i <=Convert.ToInt32(row); i++)
                {
                    string grdidp = "grdid" + i;
                    string grdid = collection[grdidp];
                    string jlidp = "jlid" + i;
                    string jlid = collection[jlidp];
                    string jxidp = "jxid" + i;
                    string jxid = collection[jxidp];
                    string ykidp = "ykid" + i;
                    string ykid = collection[ykidp];
                    string sfidp = "sfid" + i;
                    string sfid = collection[sfidp];
                    List<salary_grant_detailsModel> list = MyProperty2.SelectById2(sj[0].salary_standard_id,sj[0].salary_grant_id);
                    list[i-1].grd_id = Convert.ToInt32(grdid);
                    list[i-1].bouns_sum = Convert.ToDouble(jlid);
                    list[i-1].sale_sum = Convert.ToDouble(jxid);
                    list[i-1].deduct_sum = Convert.ToDouble(ykid);
                    list[i-1].salary_paid_sum = Convert.ToDouble(sfid);
                    MyProperty2.BJEdit(list[i-1]);
                  
                   
                }
             
                return Content("<script>alert('复核成功');window.location.href='/GrantCheck/Index'</script>");
            }
            else {
                return Content("<script>alert('复核失败');window.location.href='/GrantCheck/Index'</script>");
            }       
        }
    }
}
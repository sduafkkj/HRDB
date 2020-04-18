using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using HrIBLL;
using HrModell;
namespace HrUI.Controllers
{
    public class SalaryGrantController : Controller
    {
        public config_file_first_kindModelIBLL MyProperty { get; set; }
        public config_file_second_kindModelIBLL MyProperty2 { get; set; }
        public config_file_third_kindModelIBLL MyProperty3 { get; set; }
        public salary_standard_detailsModelIBLL MyProperty4 { get; set; }
        public salary_grant_detailsModelIBLL MyProperty6 { get; set; }
        public HumenModelBLL hu { get; set; }
        public salary_grantModelIBLL MyProperty5 { get; set; }
        // GET: SalaryGrant
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2(int id)
        {
            if (id == 1) {
                List<DataBag> sou = new List<DataBag>();
                List<config_file_first_kindModel> list = MyProperty.BJSelect();
                int countr = 0;
                double zq = 0;
                foreach (config_file_first_kindModel item in list)
                {
                    List<HumenModel> lhu = hu.SelectById(item.first_kind_id);
                    double sum = 0;
                    List<int> sid = new List<int>();
                    foreach (HumenModel sl in lhu)
                    {
                        sum += sl.salary_sum;
                        sid.Add(sl.human_id);
                    }
                    DataBag ss = new DataBag()
                    {
                        name = item.first_kind_name,
                        count = lhu.Count,
                        moneysum = sum,
                        id = sid
                    };
                    countr += ss.count;
                    zq += ss.moneysum;
                    sou.Add(ss);
                }
                ViewData["list"] = sou;
                ViewData["xcz"] = sou.Count;
                ViewData["countr"] = countr;
                ViewData["zq"] = zq;
                ViewData["jg"] = 1;
            }
            if (id == 2) {
                List<DataBag> sou = new List<DataBag>();
                List<config_file_second_kindModel> list = MyProperty2.BJSelect();
                int countr = 0;
                double zq = 0;
                foreach (config_file_second_kindModel item in list)
                {
                    List<HumenModel> lhu = hu.SelectById2(item.second_kind_id);
                    double sum = 0;
                    List<int> sid = new List<int>();
                    foreach (HumenModel sl in lhu)
                    {
                        sum += sl.salary_sum;
                        sid.Add(sl.human_id);
                    }
                    DataBag ss = new DataBag()
                    {
                        name = item.second_kind_name,
                        count = lhu.Count,
                        moneysum = sum,
                        id = sid
                    };
                    countr += ss.count;
                    zq += ss.moneysum;
                    sou.Add(ss);
                }
                ViewData["list"] = sou;
                ViewData["xcz"] = sou.Count;
                ViewData["countr"] = countr;
                ViewData["zq"] = zq;
                ViewData["jg"] = 2;
            }
            if (id == 3) {
                List<DataBag> sou = new List<DataBag>();
                List<config_file_third_kindModel> list = MyProperty3.BJSelect();
                int countr = 0;
                double zq = 0;
                foreach (config_file_third_kindModel item in list)
                {
                    List<HumenModel> lhu = hu.SelectById3(item.third_kind_id);
                    double sum = 0;
                    List<int> sid = new List<int>();
                    foreach (HumenModel sl in lhu)
                    {

                        sum += sl.salary_sum;
                        sid.Add(sl.human_id);

                    }
                    DataBag ss = new DataBag()
                    {
                        name = item.third_kind_name,
                        count = lhu.Count,
                        moneysum = sum,
                        id = sid
                    };
                    countr += ss.count;
                    zq += ss.moneysum;
                    sou.Add(ss);
                }
                ViewData["list"] = sou;
                ViewData["xcz"] = sou.Count;
                ViewData["countr"] = countr;
                ViewData["zq"] = zq;
                ViewData["jg"] = 3;
            }
            return View();
        }
        [HttpGet]
        public ActionResult QueryList(string id)
        {
            List<QueryList> ql = new List<QueryList>();
            List<string> list = new List<string>(id.Split(','));
            string xcid = "";
            double zong = 0;
            int bid = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                int hid = Convert.ToInt32(list[i]);
                bid = hid;
                List<HumenModel> list2 = hu.SelectById4(hid);
                xcid = (list2[0].salary_standard_id).ToString();
                List<salary_standard_detailsModel> mo = MyProperty4.BJSelectBy2(xcid);
                double money1 = 0;
                double money2 = 0;
                double money3 = 0;
                double money4 = 0;
                double money5 = 0;
                for (int j = 0; j < mo.Count; j++)
                {
                    if (mo[j].item_name == "基本工资")
                    {
                        money1 = mo[j].salary;
                    }
                    if (mo[j].item_name == "岗位工资")
                    {
                        money2 = mo[j].salary;
                    }
                    if (mo[j].item_name == "交通补助")
                    {
                        money3 = mo[j].salary;
                    }
                    if (mo[j].item_name == "午餐补助")
                    {
                        money4 = mo[j].salary;
                    }
                    if (mo[j].item_name == "五险一金")
                    {
                        money5 = mo[j].salary;
                    }
                }
                QueryList qu = new QueryList()
                {
                    did = hid,
                    name = list2[0].human_name,
                    jb = money1,
                    gw = money2,
                    jt = money3,
                    wc = money4,
                    wx = money5,
                    sf = money1 + money2 + money3 + money4 + money5
                };
                zong += qu.sf;
                ql.Add(qu);
            }
            ViewData["zhi"] = ql;
            ViewData["xcid"] = xcid;
            if (list[list.Count - 1] == "1") {
                ViewData["jg"] = "一级机构";
            }
            if (list[list.Count - 1] == "2")
            {
                ViewData["jg"] = "二级机构";
            }
            if (list[list.Count - 1] == "3")
            {
                ViewData["jg"] = "三级机构";
            }
            ViewData["countr"] = list.Count - 1;
            ViewData["sum"] = zong;
            ViewData["bid"] = bid;
            return View();
        }
        [HttpPost]
        public ActionResult QueryList(FormCollection collection)
        {
            string cxid = collection["xcid"];
            string jg = collection["jg"];
            string countr = collection["countr"];
            string sum = collection["sum"];
            string sfsum = collection["sfsum"];
            string djr = collection["djr"];
            string bid = collection["bid"];
            string rows = collection["row"];
            string djtime = collection["djtime"];
            List<HumenModel> list2 =hu.SelectById4(Convert.ToInt32(bid));
            DateTime dt = System.DateTime.Now;
            string strTime = dt.ToString("yyyyMMdd");
            Random rn=new Random();
            int num=rn.Next(1,100000);
            int bum = rn.Next(6, 10000);
            salary_grantModel gan = new salary_grantModel()
            {
                salary_grant_id = Convert.ToInt32(strTime)+num+bum,
                salary_standard_id = Convert.ToInt32(cxid),
                first_kind_id = list2[0].first_kind_id,
                first_kind_name = list2[0].first_kind_name,
                second_kind_id = list2[0].second_kind_id,
                second_kind_name = list2[0].second_kind_name,
                third_kind_id = list2[0].third_kind_id,
                third_kind_name = list2[0].third_kind_name,
                human_amount = Convert.ToInt32(countr),
                salary_standard_sum = Convert.ToDouble(sum),
                salary_paid_sum = Convert.ToDouble(sfsum),
                register = djr,
                regist_time = Convert.ToDateTime(djtime),
                check_status=1
            };
            int id = 0;
            if (jg== "一级机构")
            {
                id = 1;
            }
            if (jg == "二级机构")
            {
                id = 2;
            }
            if (jg == "三级机构")
            {
                id = 3;
            }
            if (MyProperty5.BJCreate(gan) > 0)
            {
                for (int i = 1; i <=Convert.ToInt32(rows); i++)
                {
                    string namep = "name" + i;
                    string name = collection[namep];
                    string didp = "did" + i;
                    string did = collection[didp];
                    string jlp = "jl" + i;
                    string jl = collection[jlp];
                    string jxp = "jx" + i;
                    string jx = collection[jxp];
                    string ykp = "yk" + i;
                    string yk = collection[ykp];
                    string salaryPaidSump="salaryPaidSum" + i;
                    string salaryPaidSum = collection[salaryPaidSump];
                    string salaryPaidSum2p = "salaryPaidSum2" + i;
                    string salaryPaidSum2 = collection[salaryPaidSum2p];
                    if (jl=="") {
                        jl = "0.00";
                    }
                    if (jx == "")
                    {
                        jx = "0.00";
                    }
                    if (yk == "")
                    {
                        yk = "0.00";
                    }
                    salary_grant_detailsModel gra = new salary_grant_detailsModel()
                    {
                        salary_grant_id = gan.salary_grant_id,
                        salary_standard_id = gan.salary_standard_id,
                        human_name = name,
                        human_id = Convert.ToInt32(did),
                        bouns_sum = Convert.ToDouble(jl),
                        sale_sum = Convert.ToDouble(jx),
                        deduct_sum = Convert.ToDouble(yk),
                        salary_standard_sum = Convert.ToDouble(salaryPaidSum),
                        salary_paid_sum = Convert.ToDouble(salaryPaidSum2),                       
                    };
                    MyProperty6.BJCreate(gra);
                    List<HumenModel>huid=hu.SelectHid(gra.human_id);
                    huid[0].statu = 1;
                    hu.BJEdit(huid[0]);
                }
                return Content("<script>alert('登记成功');window.location.href='/SalaryGrant/Index/" + id + "'</script>");
            }
            else {
                return Content("<script>alert('登记失败');window.location.href='/SalaryGrant/Index/" + id + "'</script>");
            }
          
        }
        public ActionResult Try(){
            return View();
        }
        public ActionResult TryInfo(FormCollection collection)
        {
            string toaction = collection["email"];
            //实例化一个发送邮件类。
            MailMessage mailMessage = new MailMessage();
            //发件人邮箱地址，方法重载不同，可以根据需求自行选择。
            mailMessage.From = new MailAddress("2923342707@qq.com");
            //收件人邮箱地址。
            mailMessage.To.Add(new MailAddress(toaction));
            //邮件标题。
            mailMessage.Subject = "发送邮件测试";
            //邮件内容。
            mailMessage.Body = "这是我给你发送的第一份邮件哦！";
            //实例化一个SmtpClient类。
            SmtpClient client = new SmtpClient();

            //在这里我使用的是qq邮箱，所以是smtp.qq.com，如果你使用的是126邮箱，那么就是smtp.126.com。
            client.Host = "smtp.qq.com";
            //使用安全加密连接。
            client.EnableSsl = true;
            //不和请求一块发送。
            client.UseDefaultCredentials = false;
            //验证发件人身份(发件人的邮箱，邮箱里的生成授权码);
            client.Credentials = new NetworkCredential("2923342707@qq.com", "hvdplejystfsdfgc");
            //发送
            client.Send(mailMessage);

            return Content("<script>alert('发送成了')</script>");
        }
    }
}
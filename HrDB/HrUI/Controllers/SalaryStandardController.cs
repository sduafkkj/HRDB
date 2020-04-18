using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HrIBLL;
using HrModell;
namespace HrUI.Controllers
{
    public class SalaryStandardController : Controller
    {
        // GET: SalaryStandard
        public salary_standardModelIBLL ji { get; set; }
        public salary_standard_detailsModelIBLL ki { get; set; }
      
        public ActionResult Index()
        {
            List<salary_standardModel>list=ji.BJSelect();
            string id=list[list.Count - 1].standard_id;
            string id2 = (Convert.ToInt32(id)+1).ToString();
            ViewData["id"] = id2;
            return View();
        }
      
        public ActionResult Index2(HrModell.salary_standardModel s)
        {
            if (ModelState.IsValid) {
                string dd = s.standard_name;
                if (ki.BJSelectBy(dd).Count > 0)
                {
                    List<string> list = ki.BJSelectBy(dd);
                    s.standard_id = list[list.Count - 1];
                    if (ji.BJCreate(s) > 0)
                    {
                        return Content("<script>alert('添加成功');window.location.href='/SalaryStandard/Index'</script>");
                    }
                    else
                    {
                        return Content("<script>alert('添加失败');window.location.href='/SalaryStandard/Index'</script>");
                    }
                }
                else
                {
                    if (s.item == true)
                    {
                        string[] itname = { "基本工资", "岗位工资", "交通补助", "午餐补助", "五险一金" };
                        double[] itmoney = { s.money1, s.money2, s.money3, s.money4, s.money5 };
                        int[] id = { 1, 2, 3, 4, 5 };
                        double sum = 0;
                        string sid = null;
                        for (int i = 0; i < 5; i++)
                        {

                            List<salary_standard_detailsModel> list = ki.BJSelect();
                            salary_standard_detailsModel da = new salary_standard_detailsModel();
                            da.standard_name = dd;
                            int a = Convert.ToInt32(list[list.Count - (i + 1)].standard_id) + 1;
                            da.standard_id = a.ToString();
                            da.item_name = itname[i];
                            da.item_id = id[i];
                            da.salary = itmoney[i];
                            if (ki.BJCreate(da) > 0)
                            {
                                sid = da.standard_id;
                                sum = itmoney[0] + itmoney[1] + itmoney[2] + itmoney[3] + itmoney[4];
                            }
                            else
                            {

                            }
                        }

                        s.salary_sum = sum;
                        s.standard_id = sid;
                        if (ji.BJCreate(s) > 0)
                        {
                            return Content("<script>alert('添加成功');window.location.href='/SalaryStandard/Index'</script>");
                        }
                        else
                        {
                            return Content("<script>alert('添加失败');window.location.href='/SalaryStandard/Index'</script>");
                        }

                    }
                    if (s.item == false)
                    {


                        double sum = 0;
                        string sid = null;
                        int count = 0;
                        if (s.item1 == true)
                        {
                            count++;
                        }
                        if (s.item2 == true)
                        {
                            count++;
                        }
                        if (s.item3 == true)
                        {
                            count++;
                        }
                        if (s.item4 == true)
                        {
                            count++;
                        }
                        if (s.item5 == true)
                        {
                            count++;
                        }
                        String[] itname = new String[count];
                        double[] itmoney = new double[count];
                        int[] id = new int[count];
                        int count2 = 0;
                        if (s.item1 == true)
                        {
                            count2++;
                            itname[count2 - 1] = "基本工资";
                            itmoney[count2 - 1] = s.money1;
                            id[count2 - 1] = 1;
                        }
                        if (s.item2 == true)
                        {
                            count2++;
                            itname[count2 - 1] = "岗位工资";
                            itmoney[count2 - 1] = s.money2;
                            id[count2 - 1] = 2;
                        }
                        if (s.item3 == true)
                        {
                            count2++;
                            itname[count2 - 1] = "交通补助";
                            itmoney[count2 - 1] = s.money3;
                            id[count2 - 1] = 3;
                        }
                        if (s.item4 == true)
                        {
                            count2++;
                            itname[count2 - 1] = "午餐补助";
                            itmoney[count2 - 1] = s.money4;
                            id[count2 - 1] = 4;
                        }
                        if (s.item5 == true)
                        {
                            count2++;
                            itname[count2 - 1] = "五险一金";
                            itmoney[count2 - 1] = s.money5;
                            id[count2 - 1] = 5;
                        }
                        for (int i = 0; i < itname.Length; i++)
                        {

                            List<salary_standard_detailsModel> list = ki.BJSelect();
                            salary_standard_detailsModel da = new salary_standard_detailsModel();
                            da.standard_name = dd;
                            int a = Convert.ToInt32(list[list.Count - (i + 1)].standard_id) + 1;
                            da.standard_id = a.ToString();
                            da.item_name = itname[i];
                            da.item_id = id[i];
                            da.salary = itmoney[i];
                            if (ki.BJCreate(da) > 0)
                            {
                                sid = da.standard_id;
                                sum += itmoney[i];
                            }
                            else
                            {
                                return Content("<script>alert('添加失败');window.location.href='/SalaryStandard/Index'</script>");
                            }

                        }
                        s.salary_sum = sum;
                        s.standard_id = sid;
                        if (ji.BJCreate(s) > 0)
                        {
                            return Content("<script>alert('添加成功');window.location.href='/SalaryStandard/Index'</script>");
                        }
                        else
                        {
                            return Content("<script>alert('添加失败');window.location.href='/SalaryStandard/Index'</script>");
                        }

                    }
                    else
                    {
                        return Content("<script>alert('添加失败');window.location.href='/SalaryStandard/Index'</script>");
                    }


                }

            }
            else {
                return Content("<script>alert('请填写完整');window.location.href='/SalaryStandard/Index'</script>");
            }
          
            
              
        }
    }
}
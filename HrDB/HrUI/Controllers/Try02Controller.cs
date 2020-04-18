using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using HrModell;

namespace HrUI.Controllers
{
    public class Try02Controller : Controller
    {
        // GET: Try02
        public async Task<ActionResult> Index()
        { 
            HttpClient hc = new HttpClient();         
            hc.BaseAddress = new Uri("https://localhost:44364/");
            HttpResponseMessage hp = await hc.GetAsync("api/Try02");
            ViewData.Model = await hp.Content.ReadAsAsync<List<HumenModel>>();//获取结果
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(HumenModel bjm)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44364/");
            HttpResponseMessage hp = await hc.PostAsJsonAsync("api/Try02", bjm);
            int result = await hp.Content.ReadAsAsync<int>();
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(bjm);
            }
        }
        [HttpGet]
        public async Task<ActionResult> Edit(int? id)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44364/");
            HttpResponseMessage hp = await hc.GetAsync("api/Try02/" + id);
            HumenModel bjm = await hp.Content.ReadAsAsync<HumenModel>();
            ViewData.Model = bjm;
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Edit(HumenModel bjm)
        {
          
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44364/");
            HttpResponseMessage hp = await hc.PutAsJsonAsync("api/Try02", bjm);
            try
            {
                int result = await hp.Content.ReadAsAsync<int>();
                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(bjm);
                }
            }
            catch (Exception ex)
            {
                string sr = ex.Message;
                throw;
            }
            
        }
        [HttpGet]
        public async Task<ActionResult> Delete(int? id)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44364/");
            HttpResponseMessage hp = await hc.DeleteAsync("api/Try02/" + id);
            int result = await hp.Content.ReadAsAsync<int>();
            if (result > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/Try02/Index'</script>");
            }
            else {
                return Content("<script>alert('删除失败');window.location.href='/Try02/Index'</script>");
            }
           
        }
    }
}
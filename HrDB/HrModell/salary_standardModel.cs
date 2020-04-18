using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrModell
{
    
    public class salary_standardModel
    {
        public int ssd_id { get; set; }//主键，自动增长列       
        public string standard_id { get; set; }//薪酬标准单编号   
        [Required(ErrorMessage = "姓名不能为空")]
        public string standard_name { get; set; }//薪酬标准单名称    
       
        public string designer { get; set; }//制定者名字      
        public string register { get; set; }//登记人     
        public string checker { get; set; }//复核人   
        public string changer { get; set; }//变更人   
        public DateTime regist_time { get; set; }//登记时间    
        public DateTime check_time { get; set; }//复核时间
        public DateTime change_time { get; set; }// 变更时间   
        [Required(ErrorMessage = "姓名不能为空")]
        public double salary_sum { get; set; }//薪酬总额  
        public int check_status { get; set; }//是否经过复核      
        public int change_status { get; set; }//更改状态    
    
        public string check_comment { get; set; }//复核意见    
       
        public string remark { get; set; }//备注
        public bool item{ get; set; }
        public bool item1 { get; set; }
        public bool item2 { get; set; }
        public bool item3 { get; set; }
        public bool item4 { get; set; }
        public bool item5 { get; set; }
        public double money1 { get; set; }
        public double money2 { get; set; }
        public double money3 { get; set; }
        public double money4 { get; set; }
        public double money5 { get; set; }
    }
}

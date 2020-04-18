using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrModell;
using HrIDAO;
using HrEFProject;
namespace HrDAO
{
    public class config_file_third_kindModelDAO : DaoBase<config_file_third_kind>, config_file_third_kindModelIDAO
    {
        public List<config_file_third_kindModel> BJSelect()
        {

            List<config_file_third_kind> list = Select();
            List<config_file_third_kindModel> list2 = new List<config_file_third_kindModel>();
            //需要把ED->DTO
            foreach (config_file_third_kind item in list)
            {
                config_file_third_kindModel bjm = new config_file_third_kindModel()
                {
                    ftk_id=item.ftk_id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    third_kind_id = item.third_kind_id,
                    third_kind_name = item.third_kind_name,
                };
                list2.Add(bjm);
            }
            return list2;
        }
    }
}

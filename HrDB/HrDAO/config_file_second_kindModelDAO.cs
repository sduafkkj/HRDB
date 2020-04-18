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
    public class config_file_second_kindModelDAO : DaoBase<config_file_second_kind>, config_file_second_kindModelIDAO
    {
        public List<config_file_second_kindModel> BJSelect()
        {
            List<config_file_second_kind> list = Select();
            List<config_file_second_kindModel> list2 = new List<config_file_second_kindModel>();
            //需要把ED->DTO
            foreach (config_file_second_kind item in list)
            {
                config_file_second_kindModel bjm = new config_file_second_kindModel()
                {
                    fsk_id=item.fsk_id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.second_kind_id,
                    second_kind_name = item.second_kind_name,
                    
            };
                list2.Add(bjm);
            }
            return list2;
        }
    }
}

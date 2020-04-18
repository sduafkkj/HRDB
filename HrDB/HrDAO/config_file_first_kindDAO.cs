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
    public class config_file_first_kindDAO : DaoBase<config_file_first_kind>, config_file_first_kindModelIDAO
    {
        public List<config_file_first_kindModel> BJSelect()
        {
            List<config_file_first_kind> list = Select();
            List<config_file_first_kindModel> list2 = new List<config_file_first_kindModel>();
            //需要把ED->DTO
            foreach (config_file_first_kind item in list)
            {
                config_file_first_kindModel bjm = new config_file_first_kindModel()
                {
                    ffk_id = item.ffk_id,
                    first_kind_id=item.first_kind_id,
                    first_kind_name=item.first_kind_name,

                };
                list2.Add(bjm);
            }
            return list2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrModell;
using HrIDAO;
using HrIBLL;
namespace HrBLL
{
    public class config_file_second_kindModelBLL : config_file_second_kindModelIBLL
    {
        public config_file_second_kindModelIDAO MyProperty { get; set; }
        public List<config_file_second_kindModel> BJSelect()
        {
            return MyProperty.BJSelect();
        }
    }
}

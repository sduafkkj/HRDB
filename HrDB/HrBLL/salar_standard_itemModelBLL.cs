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
    public class salar_standard_itemModelBLL : salar_standard_itemModelIBLL
    {
        public salar_standard_itemModelIDAO MyProperty { get; set; }
        public int BJCreate(salar_standard_itemModel bjm)
        {
            return MyProperty.BJCreate(bjm);
        }

        public int BJDelete(salar_standard_itemModel bjm)
        {
            throw new NotImplementedException();
        }

        public int BJEdit(salar_standard_itemModel bjm)
        {
            throw new NotImplementedException();
        }

        public List<salar_standard_itemModel> BJSelect()
        {
            return MyProperty.BJSelect();
        }

        public List<string> BJSelectBy(string name)
        {
            return MyProperty.BJSelectBy(name);
        }
    }
}

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
    public class salar_standard_itemModelDAO : DaoBase<salar_standard_item>, salar_standard_itemModelIDAO
    {
        public int BJCreate(salar_standard_itemModel bjm)
        {
            salar_standard_item bj = new salar_standard_item()
            {     
                item_id=bjm.item_id,
                item_name=bjm.item_name
            };
            return Add(bj);
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
            List<salar_standard_item> list = Select();
            List<salar_standard_itemModel> list2 = new List<salar_standard_itemModel>();
            //需要把ED->DTO
            foreach (salar_standard_item item in list)
            {
                salar_standard_itemModel bjm = new salar_standard_itemModel()
                {
                    item_id = item.item_id,
                    item_name = item.item_name
                };
                list2.Add(bjm);
            }
            return list2;
        }

        public List<string> BJSelectBy(string name)
        {
            List<string> bj = SelectBy(name);
            //把EO->DTO
           
            return bj;
        }
    }
}

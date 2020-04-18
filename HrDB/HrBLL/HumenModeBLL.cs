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
    public class HumenModeBLL : HumenModelBLL
    {
        public HumenModelIDAO MyProperty { get; set; }

        public int BJEdit(HumenModel bjm)
        {
            return MyProperty.BJEdit(bjm);
        }

        public List<HumenModel> GetPageList(int pageIndex, int pageSize, ref int totalCount)
        {
            return MyProperty.GetPageList( pageIndex,  pageSize, ref  totalCount);
        }

        public List<HumenModel> SelectById(int id)
        {
            return MyProperty.SelectById(id);
        }

        public List<HumenModel> SelectById2(int id)
        {
            return MyProperty.SelectById2(id);
        }

        public List<HumenModel> SelectById3(int id)
        {
            return MyProperty.SelectById3(id);
        }

        public List<HumenModel> SelectById4(int id)
        {
            return MyProperty.SelectById4(id);
        }

        public List<HumenModel> SelectHid(int id)
        {
            return MyProperty.SelectHid(id);
        }

        public List<HumenModel> SelectSid(int id)
        {
            return MyProperty.SelectSid(id);
        }
    }
}

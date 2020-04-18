using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrModell;
namespace HrIBLL
{
  public  interface HumenModelBLL
    {
        List<HumenModel> SelectById(int id);

        List<HumenModel> SelectById2(int id);

        List<HumenModel> SelectById3(int id);

        List<HumenModel> SelectById4(int id);//按humenid查询

        List<HumenModel> GetPageList(int pageIndex, int pageSize, ref int totalCount);

        List<HumenModel> SelectSid(int id);

        int BJEdit(HumenModel bjm);

        List<HumenModel> SelectHid(int id);//根据huidlinq语句查询
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrModell;
namespace HrIBLL
{
   public interface salar_standard_itemModelIBLL
    {
        List<salar_standard_itemModel> BJSelect();

        int BJCreate(salar_standard_itemModel bjm);

        List<string> BJSelectBy(string name);

        int BJEdit(salar_standard_itemModel bjm);

        int BJDelete(salar_standard_itemModel bjm);
    }
}

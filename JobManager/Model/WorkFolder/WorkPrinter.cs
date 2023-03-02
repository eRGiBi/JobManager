using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5BEO.Model.WorkFolder
{
    internal class WorkPrinter
    {
       
        public static string PrintTimeWS(Work work)
        {
            if (work.Hour != 0)
            {
                return work.Hour.ToString("F0") + "h " + work.Minute + "m";
            }
            else { return work.Minute.ToString() + "m"; }

        }
      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5BEO.Model.WorkFolder
{
    internal interface IWorkParser
    {
        List<Work> WorkParse(string[] colums);
    }
}

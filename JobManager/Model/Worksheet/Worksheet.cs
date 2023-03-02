using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5BEO.Model.Worksheet
{
    public class Worksheet
    {       
        public int NumberOfJobs { get; private set; }
        public int TotalMaterialCost { get; private set; }
        public int TotalWorkCost { get; private set; }
        public int TotalWorkTime { get; private set; }
        public int TotalCost
        {
            get
            {
                return TotalMaterialCost + TotalWorkCost;
            }
        }

        public Worksheet(int numberOfJobs, int totalMaterialCost, int totalWorkCost, int totalWorkTime)
        {
            NumberOfJobs = numberOfJobs;
            TotalMaterialCost = totalMaterialCost;
            TotalWorkCost = totalWorkCost;
            TotalWorkTime = totalWorkTime;
        }
       
    }
}

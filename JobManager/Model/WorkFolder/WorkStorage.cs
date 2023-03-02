using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5BEO.Model.WorkFolder
{
    internal class WorkStorage : IEnumerable<Work>
    {
        private List<Work> works;

        public WorkStorage()
        {
            works = new List<Work>();
        }

        public int Count { get { return works.Count; } }
        public Work this[int index] => works[index];

        public void StoreWorks(List<Work> newWorks)
        {
            works.Clear();
            works.AddRange(newWorks);
        }

        public IEnumerator<Work> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

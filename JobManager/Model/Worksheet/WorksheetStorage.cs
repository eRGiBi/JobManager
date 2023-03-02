using System.Collections;

namespace S5BEO.Model.Worksheet
{
    public class WorksheetStorage : IEnumerable<Worksheet>
    {
        private List<Worksheet> worksheets;

        public WorksheetStorage()
        {
            worksheets = new List<Worksheet>();
        }
        public int Count { get { return worksheets.Count; } }

        public void Add(Worksheet worksheet) { worksheets.Add(worksheet); }

        public void Clear() { worksheets.Clear(); }

        public Worksheet this[int index] => worksheets[index];



        public IEnumerator<Worksheet> GetEnumerator()
        {
            return new WorksheetStorageEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

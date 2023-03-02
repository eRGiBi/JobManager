namespace S5BEO.Model.Worksheet
{
    internal class WorksheetStorageEnumerator : IEnumerator<Worksheet>
    {
        private WorksheetStorage storage;
        private int index;

        public WorksheetStorageEnumerator (WorksheetStorage storage)
        {
            this.storage = storage;
            index = -1;
        }
        public Worksheet Current => storage[index];

        object System.Collections.IEnumerator.Current => Current;

        public void Dispose() { }
        public bool MoveNext() { return ++index < storage.Count; }
        public void Reset() { index= -1;}
    }
}
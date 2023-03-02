namespace S5BEO.Model.WorkFolder
{
    internal class WorkParser : IWorkParser
    {
        public List<Work> WorkParse(string[] colums)
        {
            List<Work> workList = new List<Work>();

            foreach (var column in colums)
            {
                string[] data = column.Split(';');

                if (data.Length == 3)
                {
                    workList.Add(
                        new Work(
                            data[0],
                            IntParse(data[1]),
                            IntParse(data[2]))
                        );
                }
            }
            return workList;
        }

        public static int IntParse(string toParse)
        {
            if (!int.TryParse(toParse, out int result) || result < 0)
            {
                throw new Exception();
            }
            else { return result; }
        }

    }
}

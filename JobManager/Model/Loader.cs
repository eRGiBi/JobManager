using S5BEO.Model.WorkFolder;

namespace S5BEO.Model
{
    internal class Loader
    {
        public static List<T> LoadFile<T>(string fileName, IWorkParser parser)
        {
            List<T> objectList = new List<T>();
            string text = "";


            using (StreamReader reader = new StreamReader(fileName))
            {
                text = reader.ReadToEnd();
                reader.Close();
            }

            string[] colums = text.Split(new string[] {Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries);


            objectList.AddRange((IEnumerable<T>)parser.WorkParse(colums));


            return objectList;
        }


    }

}


        
        
            



        

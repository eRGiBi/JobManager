namespace S5BEO.Model.WorkFolder
{
    public class Work
    {
        public const double HOURLY_RATE = 15000;
        public string WorkName { get; private set; }
        public int WorkTime { get; private set; }
        public int MaterialCost { get; private set; }

        public int Hour { get { return WorkTime / 60; } }
        public int Minute { get { return WorkTime % 60; } }

        public double WorkCost { get { return HOURLY_RATE * WorkTime / 60; } }

        public Work(string workname, int worktime, int materialcost)
        {
            WorkName = workname;
            WorkTime = worktime;
            MaterialCost = materialcost;
        }

    }
}

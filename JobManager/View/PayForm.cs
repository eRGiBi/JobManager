using S5BEO.Model.Worksheet;
using S5BEO.Model.WorkFolder;

namespace S5BEO.View
{
    public partial class PayForm : Form
    {
        private WorksheetStorage storage = new WorksheetStorage();

        private int NumberOfJobs = 0;
        private int TotalMateriralCost = 0;
        private int TotalWorkCost = 0;
        private int TotalWorkTime = 0;
        private int TotalCost = 0;

        public PayForm(WorksheetStorage worksheetstorage)
        {
            InitializeComponent();
            storage = worksheetstorage;
        }

        private void PayForm_Load(object sender, EventArgs e)
        {
            foreach (Worksheet worksheet in storage)
            {
                NumberOfJobs += worksheet.NumberOfJobs;
                TotalMateriralCost += worksheet.TotalMaterialCost;
                TotalWorkCost += worksheet.TotalWorkCost;
                TotalWorkTime += worksheet.TotalWorkTime;
                TotalCost += worksheet.TotalCost;
            }

            BillIfHalfHourStarted();

            NumberOfWorkSheetsLabel.Text = storage.Count.ToString();
            NumberOfJobsLabel.Text = NumberOfJobs.ToString();
            MaterailCostLabel.Text = TotalMateriralCost.ToString() + " Ft";
            WorkCostLabel.Text = TotalWorkCost.ToString() + " Ft";
            WorkTimeLabel.Text = TotalWorkTime.ToString() + " minutes";
            TotalCostLabel.Text = TotalCost.ToString() + " Ft";
        }

        private void PayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            storage.Clear();
        }

        private void BillIfHalfHourStarted()
        {
            double modTime = TotalWorkTime % 30;

            if (modTime != 0)
            {
                TotalCost += (int)((30 - modTime) / 60 * 15000);
            }
        }
    }


}

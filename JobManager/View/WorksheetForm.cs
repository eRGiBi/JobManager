using S5BEO.Model.WorkFolder;
using S5BEO.Model.Worksheet;


namespace S5BEO.View
{
    public partial class WorksheetForm : Form
    {
        private WorkStorage storage;
        private WorksheetStorage worksheetstorage;
        private List<WorksheetMenuControl> controls = new List<WorksheetMenuControl>();
        private int TotalWorkCost;
        private int TotalMaterailCost;

        internal WorksheetForm(WorkStorage storage, WorksheetStorage worksheetstorage)
        {
            InitializeComponent();
            this.storage = storage;
            this.worksheetstorage = worksheetstorage;
        }

        private const int lineSpace = 40;
        private const int starterY = 20;
        private const int checkboxX = 365;
        private const int workNameX = 0;
        private const int materialCostX = 155;
        private const int workTimeX = 285;

        private const int labelWidth = 144;
        private const int labelHeight = 15;

        private void WorksheetForm_Load(object sender, EventArgs e)
        {
            CreateDynamicControlList(storage);

            workCostNumberLabel.Visible = false;
            materailCostNumberLabel.Visible = false;
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            RecordData();

            FormClosing -= WorksheetForm_FormClosing;

            Close();
        }

        private void WorksheetForm_FormClosing(object? sender, FormClosingEventArgs e) //???
        {

            if (MessageBox.Show(
                "Exit without finalizing?",
                "Order not saved!",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void CreateDynamicControlList(WorkStorage storage)
        {
            for (int i = 0; i < storage.Count; i++)
            {
                CreateControl(storage[i], i);
            }
        }
        private void CreateControl(Work item, int index)
        {

            CheckBox checkbox = new CheckBox()
            {
                Checked = false,
                Location = new Point(checkboxX, starterY + index * lineSpace)
            };
            checkbox.CheckedChanged += new System.EventHandler(CheckBoxChanged);

            Label WorkNameLabel = new Label()
            {
                Text = item.WorkName.ToString(),
                Size = new Size(labelWidth, labelHeight),
                Location = new Point(workNameX, starterY + index * lineSpace)
            };

            Label MaterialCostLabel = new Label()
            {
                Text = item.MaterialCost.ToString() + " Ft",
                Location = new Point(materialCostX, starterY + index * lineSpace)
            };

            Label WorkTimeLabel = new Label()
            {
                Text = WorkPrinter.PrintTimeWS(item),
                Location = new Point(workTimeX, starterY + index * lineSpace)
            };

            ContentContainer.Controls.Add(checkbox);
            ContentContainer.Controls.Add(WorkNameLabel);
            ContentContainer.Controls.Add(MaterialCostLabel);
            ContentContainer.Controls.Add(WorkTimeLabel);

            controls.Add(new WorksheetMenuControl(item, checkbox));
        }

        private void CheckBoxChanged(object? sender, EventArgs e)
        {
            foreach (WorksheetMenuControl control in controls)
            {
                if (control.Checked && control.WasChecked == false)
                {

                    workCostNumberLabel.Visible = true;
                    materailCostNumberLabel.Visible = true;

                    TotalWorkCost += (int)control.Model.WorkCost;
                    workCostNumberLabel.Text = TotalWorkCost.ToString() + " Ft";

                    TotalMaterailCost += control.Model.MaterialCost;
                    materailCostNumberLabel.Text = TotalMaterailCost.ToString() + " Ft";

                    control.checkbox.Text = control.Model.WorkCost.ToString().PadLeft(15) + " Ft";

                    control.WasChecked = true;
                }

                else
                {
                    if (!control.Checked && control.WasChecked == true)
                    {

                        TotalWorkCost -= (int)control.Model.WorkCost;
                        workCostNumberLabel.Text = TotalWorkCost.ToString() + " Ft";

                        TotalMaterailCost -= control.Model.MaterialCost;
                        materailCostNumberLabel.Text = TotalMaterailCost.ToString() + " Ft";

                        control.checkbox.Text = "";

                        control.WasChecked = false;

                        if (TotalMaterailCost == 0 && TotalWorkCost == 0)
                        {
                            workCostNumberLabel.Visible = false;
                            materailCostNumberLabel.Visible = false;
                        }
                    }
                }
            }
        }
        private void RecordData()
        {
            int NumberOfJobs = 0;
            int TotalWorkTime = 0;

            foreach (WorksheetMenuControl control in controls)
            {
                if (control.Checked)
                {
                    NumberOfJobs++;
                    TotalWorkTime += control.Model.WorkTime;
                }
            }
            worksheetstorage.Add(new Worksheet(NumberOfJobs, TotalMaterailCost, TotalWorkCost, TotalWorkTime));
        }
    }
}

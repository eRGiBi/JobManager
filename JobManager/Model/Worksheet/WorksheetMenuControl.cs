using S5BEO.Model.WorkFolder;

namespace S5BEO.Model.Worksheet
{
    public class WorksheetMenuControl
    {
        public Work Model { get; private set; }
        public CheckBox checkbox { get; private set; }
        public bool WasChecked { get; set; }

        public bool Checked { get { return checkbox.Checked; } }


        public WorksheetMenuControl(Work model, CheckBox checkbox)
        {
            Model = model;
            this.checkbox = checkbox;
            WasChecked = false;
        }

    }
}

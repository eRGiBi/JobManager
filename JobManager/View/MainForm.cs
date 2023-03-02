using S5BEO.Model;
using S5BEO.Model.WorkFolder;
using S5BEO.Model.Worksheet;
using S5BEO.View;

namespace S5BEO
{
    public partial class MainForm : Form
    {
        private WorkStorage storage = new WorkStorage();
        private WorksheetStorage WSstorage = new WorksheetStorage();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            workSheetToolStripMenuItem.Enabled = false;
            payToolStripMenuItem.Enabled = false;
        }

        private void fileLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadFile();

            if (storage.Count > 0)
            {
                workSheetToolStripMenuItem.Enabled = true;
            }

            WSstorage.Clear();
            payToolStripMenuItem.Enabled = false;
        }
        private void worksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorksheetForm worksheet = new WorksheetForm(storage, WSstorage);
            worksheet.ShowDialog();

            if (WSstorage.Count() > 0)
            {
                payToolStripMenuItem.Enabled = true;
            }
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayForm payForm = new PayForm(WSstorage);
            payForm.ShowDialog();

            payToolStripMenuItem.Enabled = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                DateTime.Now.ToString("d") + "\nAbout",
                "About",
                MessageBoxButtons.OK);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to quit?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ReadFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    storage.StoreWorks(Loader.LoadFile<Work>(openFileDialog.FileName, new WorkParser()));
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        string.Format("Read did not complete!\nMessage: {0}",
                        exception.Message),
                        "Attention!");
                }
            }
        }
    }
}
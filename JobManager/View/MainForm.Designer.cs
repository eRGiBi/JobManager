namespace S5BEO
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainMenuStrip = new MenuStrip();
            fileLoadToolStripMenuItem = new ToolStripMenuItem();
            workSheetToolStripMenuItem = new ToolStripMenuItem();
            payToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileLoadToolStripMenuItem, workSheetToolStripMenuItem, payToolStripMenuItem, aboutToolStripMenuItem, exitToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(800, 24);
            mainMenuStrip.TabIndex = 1;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // fileLoadToolStripMenuItem
            // 
            fileLoadToolStripMenuItem.Name = "fileLoadToolStripMenuItem";
            fileLoadToolStripMenuItem.Size = new Size(64, 20);
            fileLoadToolStripMenuItem.Text = "Load file";
            fileLoadToolStripMenuItem.Click += fileLoadToolStripMenuItem_Click;
            // 
            // workSheetToolStripMenuItem
            // 
            workSheetToolStripMenuItem.Name = "workSheetToolStripMenuItem";
            workSheetToolStripMenuItem.Size = new Size(75, 20);
            workSheetToolStripMenuItem.Text = "Worksheet";
            workSheetToolStripMenuItem.Click += worksheetToolStripMenuItem_Click;
            // 
            // payToolStripMenuItem
            // 
            payToolStripMenuItem.Name = "payToolStripMenuItem";
            payToolStripMenuItem.Size = new Size(38, 20);
            payToolStripMenuItem.Text = "Pay";
            payToolStripMenuItem.Click += payToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "adatok.txt";
            openFileDialog.InitialDirectory = "..\\JobManager\\JobManager\\Data\\";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            Name = "MainForm";
            Text = "Service";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileLoadToolStripMenuItem;
        private ToolStripMenuItem workSheetToolStripMenuItem;
        private ToolStripMenuItem payToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private OpenFileDialog openFileDialog;
    }
}
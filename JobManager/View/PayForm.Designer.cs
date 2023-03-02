namespace S5BEO.View
{
    partial class PayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            NumberOfWorkSheetsLabel = new Label();
            NumberOfJobsLabel = new Label();
            MaterailCostLabel = new Label();
            WorkCostLabel = new Label();
            WorkTimeLabel = new Label();
            TotalCostLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 30);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of worksheets:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 75);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Number of jobs:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 120);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 2;
            label3.Text = "Material cost:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 165);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Wage:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 210);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Time:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 255);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 5;
            label6.Text = "Overall cost:";
            // 
            // NumberOfWorkSheetsLabel
            // 
            NumberOfWorkSheetsLabel.AutoSize = true;
            NumberOfWorkSheetsLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            NumberOfWorkSheetsLabel.Location = new Point(189, 30);
            NumberOfWorkSheetsLabel.Name = "NumberOfWorkSheetsLabel";
            NumberOfWorkSheetsLabel.Size = new Size(51, 20);
            NumberOfWorkSheetsLabel.TabIndex = 6;
            NumberOfWorkSheetsLabel.Text = "label7";
            // 
            // NumberOfJobsLabel
            // 
            NumberOfJobsLabel.AutoSize = true;
            NumberOfJobsLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            NumberOfJobsLabel.ForeColor = Color.Gold;
            NumberOfJobsLabel.Location = new Point(189, 75);
            NumberOfJobsLabel.Name = "NumberOfJobsLabel";
            NumberOfJobsLabel.Size = new Size(51, 20);
            NumberOfJobsLabel.TabIndex = 7;
            NumberOfJobsLabel.Text = "label8";
            // 
            // MaterailCostLabel
            // 
            MaterailCostLabel.AutoSize = true;
            MaterailCostLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            MaterailCostLabel.ForeColor = Color.FromArgb(192, 0, 192);
            MaterailCostLabel.Location = new Point(189, 120);
            MaterailCostLabel.Name = "MaterailCostLabel";
            MaterailCostLabel.Size = new Size(51, 20);
            MaterailCostLabel.TabIndex = 8;
            MaterailCostLabel.Text = "label9";
            // 
            // WorkCostLabel
            // 
            WorkCostLabel.AutoSize = true;
            WorkCostLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            WorkCostLabel.ForeColor = Color.IndianRed;
            WorkCostLabel.Location = new Point(189, 165);
            WorkCostLabel.Name = "WorkCostLabel";
            WorkCostLabel.Size = new Size(60, 20);
            WorkCostLabel.TabIndex = 9;
            WorkCostLabel.Text = "label10";
            // 
            // WorkTimeLabel
            // 
            WorkTimeLabel.AutoSize = true;
            WorkTimeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            WorkTimeLabel.Location = new Point(189, 210);
            WorkTimeLabel.Name = "WorkTimeLabel";
            WorkTimeLabel.Size = new Size(60, 20);
            WorkTimeLabel.TabIndex = 10;
            WorkTimeLabel.Text = "label11";
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            TotalCostLabel.ForeColor = Color.LightSkyBlue;
            TotalCostLabel.Location = new Point(189, 255);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(60, 20);
            TotalCostLabel.TabIndex = 11;
            TotalCostLabel.Text = "label12";
            // 
            // PayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 295);
            Controls.Add(TotalCostLabel);
            Controls.Add(WorkTimeLabel);
            Controls.Add(WorkCostLabel);
            Controls.Add(MaterailCostLabel);
            Controls.Add(NumberOfJobsLabel);
            Controls.Add(NumberOfWorkSheetsLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PayForm";
            Text = "Pay";
            FormClosing += PayForm_FormClosing;
            Load += PayForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label NumberOfWorkSheetsLabel;
        private Label NumberOfJobsLabel;
        private Label MaterailCostLabel;
        private Label WorkCostLabel;
        private Label WorkTimeLabel;
        private Label TotalCostLabel;
    }
}
namespace S5BEO.View
{
    partial class WorksheetForm
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
            ContentContainer = new Panel();
            RecordButton = new Button();
            materialCostLabel = new Label();
            materailCostNumberLabel = new Label();
            workCostNumberLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // ContentContainer
            // 
            ContentContainer.AutoScroll = true;
            ContentContainer.Location = new Point(25, 43);
            ContentContainer.Name = "ContentContainer";
            ContentContainer.Size = new Size(518, 428);
            ContentContainer.TabIndex = 0;
            // 
            // RecordButton
            // 
            RecordButton.Location = new Point(430, 494);
            RecordButton.Name = "RecordButton";
            RecordButton.Size = new Size(75, 23);
            RecordButton.TabIndex = 6;
            RecordButton.Text = "Order";
            RecordButton.UseVisualStyleBackColor = true;
            RecordButton.Click += RecordButton_Click;
            // 
            // materialCostLabel
            // 
            materialCostLabel.AutoSize = true;
            materialCostLabel.Location = new Point(12, 499);
            materialCostLabel.Name = "materialCostLabel";
            materialCostLabel.Size = new Size(106, 15);
            materialCostLabel.TabIndex = 4;
            materialCostLabel.Text = "Total material cost:";
            // 
            // materailCostNumberLabel
            // 
            materailCostNumberLabel.AutoSize = true;
            materailCostNumberLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            materailCostNumberLabel.ForeColor = Color.IndianRed;
            materailCostNumberLabel.Location = new Point(136, 495);
            materailCostNumberLabel.Name = "materailCostNumberLabel";
            materailCostNumberLabel.Size = new Size(51, 20);
            materailCostNumberLabel.TabIndex = 4;
            materailCostNumberLabel.Text = "label1";
            // 
            // workCostNumberLabel
            // 
            workCostNumberLabel.AutoSize = true;
            workCostNumberLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            workCostNumberLabel.ForeColor = Color.IndianRed;
            workCostNumberLabel.Location = new Point(329, 494);
            workCostNumberLabel.Name = "workCostNumberLabel";
            workCostNumberLabel.Size = new Size(42, 20);
            workCostNumberLabel.TabIndex = 5;
            workCostNumberLabel.Text = "label";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 25);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Material cost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 25);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 25);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 3;
            label3.Text = "Wage";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 499);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 7;
            label4.Text = "Total wage:";
            // 
            // WorksheetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 534);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(workCostNumberLabel);
            Controls.Add(materailCostNumberLabel);
            Controls.Add(materialCostLabel);
            Controls.Add(RecordButton);
            Controls.Add(ContentContainer);
            Name = "WorksheetForm";
            Text = "Worksheet order";
            FormClosing += WorksheetForm_FormClosing;
            Load += WorksheetForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ContentContainer;
        private Button RecordButton;
        private Label materialCostLabel;
        private Label materailCostNumberLabel;
        private Label workCostNumberLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
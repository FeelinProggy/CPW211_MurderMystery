namespace CPW211_MurderMystery
{
    partial class DisplayPrintInstructionsForm
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
            rtbPrintThemeInfo = new RichTextBox();
            lstPrintAssignedCast = new ListBox();
            lblPrintThemeInfo = new Label();
            lblPrintCast = new Label();
            btnPrintResults = new Button();
            btnCloseResults = new Button();
            SuspendLayout();
            // 
            // rtbPrintThemeInfo
            // 
            rtbPrintThemeInfo.Location = new Point(12, 27);
            rtbPrintThemeInfo.Name = "rtbPrintThemeInfo";
            rtbPrintThemeInfo.ReadOnly = true;
            rtbPrintThemeInfo.Size = new Size(314, 96);
            rtbPrintThemeInfo.TabIndex = 0;
            rtbPrintThemeInfo.Text = "";
            // 
            // lstPrintAssignedCast
            // 
            lstPrintAssignedCast.FormattingEnabled = true;
            lstPrintAssignedCast.ItemHeight = 15;
            lstPrintAssignedCast.Location = new Point(12, 144);
            lstPrintAssignedCast.Name = "lstPrintAssignedCast";
            lstPrintAssignedCast.Size = new Size(314, 79);
            lstPrintAssignedCast.TabIndex = 1;
            // 
            // lblPrintThemeInfo
            // 
            lblPrintThemeInfo.AutoSize = true;
            lblPrintThemeInfo.Location = new Point(12, 9);
            lblPrintThemeInfo.Name = "lblPrintThemeInfo";
            lblPrintThemeInfo.Size = new Size(76, 15);
            lblPrintThemeInfo.TabIndex = 2;
            lblPrintThemeInfo.Text = "Party Theme:";
            // 
            // lblPrintCast
            // 
            lblPrintCast.AutoSize = true;
            lblPrintCast.Location = new Point(12, 126);
            lblPrintCast.Name = "lblPrintCast";
            lblPrintCast.Size = new Size(84, 15);
            lblPrintCast.TabIndex = 3;
            lblPrintCast.Text = "Assigned Cast:";
            // 
            // btnPrintResults
            // 
            btnPrintResults.Location = new Point(12, 229);
            btnPrintResults.Name = "btnPrintResults";
            btnPrintResults.Size = new Size(75, 23);
            btnPrintResults.TabIndex = 4;
            btnPrintResults.Text = "Print";
            btnPrintResults.UseVisualStyleBackColor = true;
            btnPrintResults.Click += FeatureInDevelopmentB_Click;
            // 
            // btnCloseResults
            // 
            btnCloseResults.Location = new Point(251, 229);
            btnCloseResults.Name = "btnCloseResults";
            btnCloseResults.Size = new Size(75, 23);
            btnCloseResults.TabIndex = 5;
            btnCloseResults.Text = "Close";
            btnCloseResults.UseVisualStyleBackColor = true;
            btnCloseResults.Click += btnCloseResults_Click;
            // 
            // DisplayPrintInstructionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 264);
            Controls.Add(btnCloseResults);
            Controls.Add(btnPrintResults);
            Controls.Add(lblPrintCast);
            Controls.Add(lblPrintThemeInfo);
            Controls.Add(lstPrintAssignedCast);
            Controls.Add(rtbPrintThemeInfo);
            Name = "DisplayPrintInstructionsForm";
            Text = "Print Instructions";
            Load += DisplayPrintInstructionsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbPrintThemeInfo;
        private ListBox lstPrintAssignedCast;
        private Label lblPrintThemeInfo;
        private Label lblPrintCast;
        private Button btnPrintResults;
        private Button btnCloseResults;
    }
}
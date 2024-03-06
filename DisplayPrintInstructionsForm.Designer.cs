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
            rtbThemeSelection = new RichTextBox();
            lstAssignedCast = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnPrintResults = new Button();
            btnCloseResults = new Button();
            SuspendLayout();
            // 
            // rtbThemeSelection
            // 
            rtbThemeSelection.Location = new Point(122, 32);
            rtbThemeSelection.Name = "rtbThemeSelection";
            rtbThemeSelection.Size = new Size(275, 96);
            rtbThemeSelection.TabIndex = 0;
            rtbThemeSelection.Text = "";
            // 
            // lstAssignedCast
            // 
            lstAssignedCast.FormattingEnabled = true;
            lstAssignedCast.ItemHeight = 15;
            lstAssignedCast.Location = new Point(142, 161);
            lstAssignedCast.Name = "lstAssignedCast";
            lstAssignedCast.Size = new Size(346, 94);
            lstAssignedCast.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 32);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "Party Theme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 182);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 3;
            label2.Text = "Assigned Cast";
            // 
            // btnPrintResults
            // 
            btnPrintResults.Location = new Point(610, 41);
            btnPrintResults.Name = "btnPrintResults";
            btnPrintResults.Size = new Size(75, 23);
            btnPrintResults.TabIndex = 4;
            btnPrintResults.Text = "Print";
            btnPrintResults.UseVisualStyleBackColor = true;
            // 
            // btnCloseResults
            // 
            btnCloseResults.Location = new Point(619, 119);
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
            ClientSize = new Size(800, 450);
            Controls.Add(btnCloseResults);
            Controls.Add(btnPrintResults);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstAssignedCast);
            Controls.Add(rtbThemeSelection);
            Name = "DisplayPrintInstructionsForm";
            Text = "DisplayPrintInstructionsForm";
            Load += DisplayPrintInstructionsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbThemeSelection;
        private ListBox lstAssignedCast;
        private Label label1;
        private Label label2;
        private Button btnPrintResults;
        private Button btnCloseResults;
    }
}
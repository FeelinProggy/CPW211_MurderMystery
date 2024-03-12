
namespace CPW211_MurderMystery
{
    partial class PartyCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartyCreatorForm));
            cboTheme = new ComboBox();
            btnAddPlayers = new Button();
            lblTheme = new Label();
            btnRemovePlayers = new Button();
            rdoPlayScripted = new RadioButton();
            rdoPlayImprovise = new RadioButton();
            rdoKnowsMurdererYes = new RadioButton();
            rdoKnowsMurdererNo = new RadioButton();
            btnPrintInstructions = new Button();
            btnSaveGameInfo = new Button();
            lstPlayers = new ListBox();
            txtThemeSummary = new TextBox();
            groupBoxHowToPlay = new GroupBox();
            groupBoxKillerAwareOfIdentity = new GroupBox();
            txtBoxInstructions = new TextBox();
            btnRemoveAllPlayers = new Button();
            btnExit = new Button();
            groupBoxHowToPlay.SuspendLayout();
            groupBoxKillerAwareOfIdentity.SuspendLayout();
            SuspendLayout();
            // 
            // cboTheme
            // 
            cboTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTheme.FormattingEnabled = true;
            cboTheme.Location = new Point(114, 174);
            cboTheme.Name = "cboTheme";
            cboTheme.Size = new Size(253, 23);
            cboTheme.TabIndex = 1;
            cboTheme.SelectedIndexChanged += cboTheme_SelectedIndexChanged;
            // 
            // btnAddPlayers
            // 
            btnAddPlayers.Location = new Point(12, 280);
            btnAddPlayers.Name = "btnAddPlayers";
            btnAddPlayers.Size = new Size(115, 23);
            btnAddPlayers.TabIndex = 2;
            btnAddPlayers.Text = "Add Players";
            btnAddPlayers.UseVisualStyleBackColor = true;
            btnAddPlayers.Click += btnAddPlayers_Click;
            // 
            // lblTheme
            // 
            lblTheme.AutoSize = true;
            lblTheme.Location = new Point(12, 177);
            lblTheme.Name = "lblTheme";
            lblTheme.Size = new Size(96, 15);
            lblTheme.TabIndex = 0;
            lblTheme.Text = "Choose a theme:";
            // 
            // btnRemovePlayers
            // 
            btnRemovePlayers.Location = new Point(12, 309);
            btnRemovePlayers.Name = "btnRemovePlayers";
            btnRemovePlayers.Size = new Size(115, 23);
            btnRemovePlayers.TabIndex = 3;
            btnRemovePlayers.Text = "Remove Players";
            btnRemovePlayers.UseVisualStyleBackColor = true;
            btnRemovePlayers.Click += btnRemovePlayers_Click;
            // 
            // rdoPlayScripted
            // 
            rdoPlayScripted.AutoSize = true;
            rdoPlayScripted.Font = new Font("Segoe UI", 9F);
            rdoPlayScripted.Location = new Point(6, 22);
            rdoPlayScripted.Name = "rdoPlayScripted";
            rdoPlayScripted.Size = new Size(180, 19);
            rdoPlayScripted.TabIndex = 4;
            rdoPlayScripted.Text = "Do you want a scripted story?";
            rdoPlayScripted.UseVisualStyleBackColor = true;
            // 
            // rdoPlayImprovise
            // 
            rdoPlayImprovise.AutoSize = true;
            rdoPlayImprovise.Font = new Font("Segoe UI", 9F);
            rdoPlayImprovise.Location = new Point(6, 47);
            rdoPlayImprovise.Name = "rdoPlayImprovise";
            rdoPlayImprovise.Size = new Size(112, 19);
            rdoPlayImprovise.TabIndex = 4;
            rdoPlayImprovise.Text = "Or to improvise?";
            rdoPlayImprovise.UseVisualStyleBackColor = true;
            // 
            // rdoKnowsMurdererYes
            // 
            rdoKnowsMurdererYes.AutoSize = true;
            rdoKnowsMurdererYes.Font = new Font("Segoe UI", 9F);
            rdoKnowsMurdererYes.Location = new Point(6, 22);
            rdoKnowsMurdererYes.Name = "rdoKnowsMurdererYes";
            rdoKnowsMurdererYes.Size = new Size(42, 19);
            rdoKnowsMurdererYes.TabIndex = 5;
            rdoKnowsMurdererYes.TabStop = true;
            rdoKnowsMurdererYes.Text = "Yes";
            rdoKnowsMurdererYes.UseVisualStyleBackColor = true;
            // 
            // rdoKnowsMurdererNo
            // 
            rdoKnowsMurdererNo.AutoSize = true;
            rdoKnowsMurdererNo.Font = new Font("Segoe UI", 9F);
            rdoKnowsMurdererNo.Location = new Point(6, 47);
            rdoKnowsMurdererNo.Name = "rdoKnowsMurdererNo";
            rdoKnowsMurdererNo.Size = new Size(41, 19);
            rdoKnowsMurdererNo.TabIndex = 5;
            rdoKnowsMurdererNo.TabStop = true;
            rdoKnowsMurdererNo.Text = "No";
            rdoKnowsMurdererNo.UseVisualStyleBackColor = true;
            // 
            // btnPrintInstructions
            // 
            btnPrintInstructions.Location = new Point(133, 367);
            btnPrintInstructions.Name = "btnPrintInstructions";
            btnPrintInstructions.Size = new Size(115, 23);
            btnPrintInstructions.TabIndex = 6;
            btnPrintInstructions.Text = "Print Instructions";
            btnPrintInstructions.UseVisualStyleBackColor = true;
            btnPrintInstructions.Click += btnPrintInstructions_Click;
            // 
            // btnSaveGameInfo
            // 
            btnSaveGameInfo.Location = new Point(254, 367);
            btnSaveGameInfo.Name = "btnSaveGameInfo";
            btnSaveGameInfo.Size = new Size(115, 23);
            btnSaveGameInfo.TabIndex = 7;
            btnSaveGameInfo.Text = "Save Game Info";
            btnSaveGameInfo.UseVisualStyleBackColor = true;
            btnSaveGameInfo.Click += FeatureInDevelopmentA_Click;
            // 
            // lstPlayers
            // 
            lstPlayers.FormattingEnabled = true;
            lstPlayers.ItemHeight = 15;
            lstPlayers.Location = new Point(133, 282);
            lstPlayers.Name = "lstPlayers";
            lstPlayers.SelectionMode = SelectionMode.MultiSimple;
            lstPlayers.Size = new Size(234, 79);
            lstPlayers.TabIndex = 8;
            // 
            // txtThemeSummary
            // 
            txtThemeSummary.BorderStyle = BorderStyle.None;
            txtThemeSummary.Location = new Point(12, 203);
            txtThemeSummary.Multiline = true;
            txtThemeSummary.Name = "txtThemeSummary";
            txtThemeSummary.ReadOnly = true;
            txtThemeSummary.Size = new Size(355, 71);
            txtThemeSummary.TabIndex = 9;
            // 
            // groupBoxHowToPlay
            // 
            groupBoxHowToPlay.Controls.Add(rdoPlayScripted);
            groupBoxHowToPlay.Controls.Add(rdoPlayImprovise);
            groupBoxHowToPlay.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            groupBoxHowToPlay.Location = new Point(373, 174);
            groupBoxHowToPlay.Name = "groupBoxHowToPlay";
            groupBoxHowToPlay.Size = new Size(216, 72);
            groupBoxHowToPlay.TabIndex = 10;
            groupBoxHowToPlay.TabStop = false;
            groupBoxHowToPlay.Text = "How do you want to play?";
            // 
            // groupBoxKillerAwareOfIdentity
            // 
            groupBoxKillerAwareOfIdentity.Controls.Add(rdoKnowsMurdererNo);
            groupBoxKillerAwareOfIdentity.Controls.Add(rdoKnowsMurdererYes);
            groupBoxKillerAwareOfIdentity.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            groupBoxKillerAwareOfIdentity.Location = new Point(373, 260);
            groupBoxKillerAwareOfIdentity.Name = "groupBoxKillerAwareOfIdentity";
            groupBoxKillerAwareOfIdentity.Size = new Size(216, 72);
            groupBoxKillerAwareOfIdentity.TabIndex = 11;
            groupBoxKillerAwareOfIdentity.TabStop = false;
            groupBoxKillerAwareOfIdentity.Text = "Should the murderer know they're it?";
            // 
            // txtBoxInstructions
            // 
            txtBoxInstructions.BackColor = SystemColors.Control;
            txtBoxInstructions.BorderStyle = BorderStyle.FixedSingle;
            txtBoxInstructions.Location = new Point(12, 12);
            txtBoxInstructions.Multiline = true;
            txtBoxInstructions.Name = "txtBoxInstructions";
            txtBoxInstructions.ReadOnly = true;
            txtBoxInstructions.Size = new Size(577, 147);
            txtBoxInstructions.TabIndex = 12;
            txtBoxInstructions.Text = resources.GetString("txtBoxInstructions.Text");
            // 
            // btnRemoveAllPlayers
            // 
            btnRemoveAllPlayers.Location = new Point(12, 338);
            btnRemoveAllPlayers.Name = "btnRemoveAllPlayers";
            btnRemoveAllPlayers.Size = new Size(115, 23);
            btnRemoveAllPlayers.TabIndex = 13;
            btnRemoveAllPlayers.Text = "Remove All Players";
            btnRemoveAllPlayers.UseVisualStyleBackColor = true;
            btnRemoveAllPlayers.Click += btnRemoveAllPlayers_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(473, 367);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(115, 23);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // PartyCreatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(600, 401);
            Controls.Add(btnExit);
            Controls.Add(btnRemoveAllPlayers);
            Controls.Add(txtBoxInstructions);
            Controls.Add(groupBoxKillerAwareOfIdentity);
            Controls.Add(groupBoxHowToPlay);
            Controls.Add(txtThemeSummary);
            Controls.Add(lstPlayers);
            Controls.Add(btnSaveGameInfo);
            Controls.Add(btnPrintInstructions);
            Controls.Add(btnRemovePlayers);
            Controls.Add(lblTheme);
            Controls.Add(btnAddPlayers);
            Controls.Add(cboTheme);
            Name = "PartyCreatorForm";
            Text = "Murder Mystery Party Creator";
            Load += PartyCreatorForm_Load;
            groupBoxHowToPlay.ResumeLayout(false);
            groupBoxHowToPlay.PerformLayout();
            groupBoxKillerAwareOfIdentity.ResumeLayout(false);
            groupBoxKillerAwareOfIdentity.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboTheme;
        private Button btnAddPlayers;
        private Label lblTheme;
        private Button btnRemovePlayers;
        private RadioButton rdoPlayScripted;
        private RadioButton rdoPlayImprovise;
        private RadioButton rdoKnowsMurdererYes;
        private RadioButton rdoKnowsMurdererNo;
        private Button btnPrintInstructions;
        private Button btnSaveGameInfo;
        private TextBox txtThemeSummary;
        private GroupBox groupBoxHowToPlay;
        private GroupBox groupBoxKillerAwareOfIdentity;
        private TextBox txtBoxInstructions;
        private Button btnRemoveAllPlayers;
        private Button btnExit;
        private ListBox lstPlayers;
    }
}

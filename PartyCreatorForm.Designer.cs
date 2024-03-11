
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
            lblPlayImprovise = new Label();
            lblPlay = new Label();
            lblKnowsMurderer = new Label();
            rdoKnowsMurdererYes = new RadioButton();
            rdoKnowsMurdererNo = new RadioButton();
            btnPrintInstructions = new Button();
            btnSaveGameInfo = new Button();
            lstPlayers = new ListBox();
            txtThemeSummary = new TextBox();
            groupBoxHowToPlay = new GroupBox();
            groupBoxKillerAwareOfIdentity = new GroupBox();
            txtBoxInstructions = new TextBox();
            groupBoxHowToPlay.SuspendLayout();
            groupBoxKillerAwareOfIdentity.SuspendLayout();
            SuspendLayout();
            // 
            // cboTheme
            // 
            cboTheme.BackColor = SystemColors.Menu;
            cboTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTheme.FormattingEnabled = true;
            cboTheme.Location = new Point(125, 169);
            cboTheme.Name = "cboTheme";
            cboTheme.Size = new Size(145, 23);
            cboTheme.TabIndex = 1;
            cboTheme.SelectedIndexChanged += cboTheme_SelectedIndexChanged;
            // 
            // btnAddPlayers
            // 
            btnAddPlayers.Location = new Point(34, 283);
            btnAddPlayers.Name = "btnAddPlayers";
            btnAddPlayers.Size = new Size(100, 23);
            btnAddPlayers.TabIndex = 2;
            btnAddPlayers.Text = "Add Players";
            btnAddPlayers.UseVisualStyleBackColor = true;
            btnAddPlayers.Click += btnAddPlayers_Click;
            // 
            // lblTheme
            // 
            lblTheme.AutoSize = true;
            lblTheme.Location = new Point(23, 172);
            lblTheme.Name = "lblTheme";
            lblTheme.Size = new Size(96, 15);
            lblTheme.TabIndex = 0;
            lblTheme.Text = "Choose a theme:";
            // 
            // btnRemovePlayers
            // 
            btnRemovePlayers.Location = new Point(34, 312);
            btnRemovePlayers.Name = "btnRemovePlayers";
            btnRemovePlayers.Size = new Size(100, 23);
            btnRemovePlayers.TabIndex = 3;
            btnRemovePlayers.Text = "Remove Players";
            btnRemovePlayers.UseVisualStyleBackColor = true;
            btnRemovePlayers.Click += btnRemovePlayers_Click;
            // 
            // rdoPlayScripted
            // 
            rdoPlayScripted.AutoSize = true;
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
            rdoPlayImprovise.Location = new Point(6, 47);
            rdoPlayImprovise.Name = "rdoPlayImprovise";
            rdoPlayImprovise.Size = new Size(112, 19);
            rdoPlayImprovise.TabIndex = 4;
            rdoPlayImprovise.Text = "Or to improvise?";
            rdoPlayImprovise.UseVisualStyleBackColor = true;
            // 
            // lblPlayImprovise
            // 
            lblPlayImprovise.AutoSize = true;
            lblPlayImprovise.Location = new Point(6, 69);
            lblPlayImprovise.Name = "lblPlayImprovise";
            lblPlayImprovise.Size = new Size(137, 15);
            lblPlayImprovise.TabIndex = 0;
            lblPlayImprovise.Text = "(Character profiles only.)";
            // 
            // lblPlay
            // 
            lblPlay.AutoSize = true;
            lblPlay.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblPlay.Location = new Point(0, 2);
            lblPlay.Name = "lblPlay";
            lblPlay.Size = new Size(160, 17);
            lblPlay.TabIndex = 0;
            lblPlay.Text = "How do you want to play?";
            // 
            // lblKnowsMurderer
            // 
            lblKnowsMurderer.AutoSize = true;
            lblKnowsMurderer.Location = new Point(0, 9);
            lblKnowsMurderer.Name = "lblKnowsMurderer";
            lblKnowsMurderer.Size = new Size(202, 15);
            lblKnowsMurderer.TabIndex = 1;
            lblKnowsMurderer.Text = "Should the murderer know they're it?";
            // 
            // rdoKnowsMurdererYes
            // 
            rdoKnowsMurdererYes.AutoSize = true;
            rdoKnowsMurdererYes.Location = new Point(49, 27);
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
            rdoKnowsMurdererNo.Location = new Point(97, 27);
            rdoKnowsMurdererNo.Name = "rdoKnowsMurdererNo";
            rdoKnowsMurdererNo.Size = new Size(41, 19);
            rdoKnowsMurdererNo.TabIndex = 5;
            rdoKnowsMurdererNo.TabStop = true;
            rdoKnowsMurdererNo.Text = "No";
            rdoKnowsMurdererNo.UseVisualStyleBackColor = true;
            // 
            // btnPrintInstructions
            // 
            btnPrintInstructions.Location = new Point(181, 415);
            btnPrintInstructions.Name = "btnPrintInstructions";
            btnPrintInstructions.Size = new Size(119, 23);
            btnPrintInstructions.TabIndex = 6;
            btnPrintInstructions.Text = "Print Instructions";
            btnPrintInstructions.UseVisualStyleBackColor = true;
            btnPrintInstructions.Click += btnPrintInstructions_Click;
            // 
            // btnSaveGameInfo
            // 
            btnSaveGameInfo.Location = new Point(320, 415);
            btnSaveGameInfo.Name = "btnSaveGameInfo";
            btnSaveGameInfo.Size = new Size(112, 23);
            btnSaveGameInfo.TabIndex = 7;
            btnSaveGameInfo.Text = "Save Game Info";
            btnSaveGameInfo.UseVisualStyleBackColor = true;
            btnSaveGameInfo.Click += FeatureInDevelopmentA_Click;
            // 
            // lstPlayers
            // 
            lstPlayers.BackColor = SystemColors.Menu;
            lstPlayers.FormattingEnabled = true;
            lstPlayers.ItemHeight = 15;
            lstPlayers.Location = new Point(141, 283);
            lstPlayers.Name = "lstPlayers";
            lstPlayers.Size = new Size(144, 94);
            lstPlayers.TabIndex = 8;
            // 
            // txtThemeSummary
            // 
            txtThemeSummary.BackColor = Color.White;
            txtThemeSummary.BorderStyle = BorderStyle.None;
            txtThemeSummary.Location = new Point(70, 198);
            txtThemeSummary.Multiline = true;
            txtThemeSummary.Name = "txtThemeSummary";
            txtThemeSummary.ReadOnly = true;
            txtThemeSummary.Size = new Size(215, 79);
            txtThemeSummary.TabIndex = 9;
            // 
            // groupBoxHowToPlay
            // 
            groupBoxHowToPlay.Controls.Add(rdoPlayScripted);
            groupBoxHowToPlay.Controls.Add(rdoPlayImprovise);
            groupBoxHowToPlay.Controls.Add(lblPlayImprovise);
            groupBoxHowToPlay.Controls.Add(lblPlay);
            groupBoxHowToPlay.Location = new Point(332, 179);
            groupBoxHowToPlay.Name = "groupBoxHowToPlay";
            groupBoxHowToPlay.Size = new Size(205, 100);
            groupBoxHowToPlay.TabIndex = 10;
            groupBoxHowToPlay.TabStop = false;
            // 
            // groupBoxKillerAwareOfIdentity
            // 
            groupBoxKillerAwareOfIdentity.Controls.Add(lblKnowsMurderer);
            groupBoxKillerAwareOfIdentity.Controls.Add(rdoKnowsMurdererNo);
            groupBoxKillerAwareOfIdentity.Controls.Add(rdoKnowsMurdererYes);
            groupBoxKillerAwareOfIdentity.Location = new Point(332, 285);
            groupBoxKillerAwareOfIdentity.Name = "groupBoxKillerAwareOfIdentity";
            groupBoxKillerAwareOfIdentity.Size = new Size(205, 63);
            groupBoxKillerAwareOfIdentity.TabIndex = 11;
            groupBoxKillerAwareOfIdentity.TabStop = false;
            // 
            // txtBoxInstructions
            // 
            txtBoxInstructions.BorderStyle = BorderStyle.FixedSingle;
            txtBoxInstructions.Location = new Point(12, 12);
            txtBoxInstructions.Multiline = true;
            txtBoxInstructions.Name = "txtBoxInstructions";
            txtBoxInstructions.ReadOnly = true;
            txtBoxInstructions.Size = new Size(577, 147);
            txtBoxInstructions.TabIndex = 12;
            txtBoxInstructions.Text = resources.GetString("txtBoxInstructions.Text");
            // 
            // PartyCreatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 454);
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
        private Label lblPlayImprovise;
        private Label lblPlay;
        private Label lblKnowsMurderer;
        private RadioButton rdoKnowsMurdererYes;
        private RadioButton rdoKnowsMurdererNo;
        private Button btnPrintInstructions;
        private Button btnSaveGameInfo;
        private ListBox lstPlayers;
        private TextBox txtThemeSummary;
        private GroupBox groupBoxHowToPlay;
        private GroupBox groupBoxKillerAwareOfIdentity;
        private TextBox txtBoxInstructions;
    }
}

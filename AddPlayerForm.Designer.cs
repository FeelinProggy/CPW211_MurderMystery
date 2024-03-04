namespace CPW211_MurderMystery
{
    partial class AddPlayerForm
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
            txtPlayerName = new TextBox();
            rdoPlayerMale = new RadioButton();
            rdoPlayerFemale = new RadioButton();
            rdoPlayerNone = new RadioButton();
            lblPlayerName = new Label();
            lblCharacterPreference = new Label();
            btnSubmitSingle = new Button();
            btnSubmitMulti = new Button();
            btnClose = new Button();
            groupBoxGenderPref = new GroupBox();
            groupBoxGenderPref.SuspendLayout();
            SuspendLayout();
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(86, 12);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(100, 23);
            txtPlayerName.TabIndex = 1;
            txtPlayerName.KeyPress += txtPlayerName_KeyPress;
            // 
            // rdoPlayerMale
            // 
            rdoPlayerMale.AutoSize = true;
            rdoPlayerMale.Location = new Point(6, 22);
            rdoPlayerMale.Name = "rdoPlayerMale";
            rdoPlayerMale.Size = new Size(51, 19);
            rdoPlayerMale.TabIndex = 2;
            rdoPlayerMale.TabStop = true;
            rdoPlayerMale.Text = "Male";
            rdoPlayerMale.UseVisualStyleBackColor = true;
            // 
            // rdoPlayerFemale
            // 
            rdoPlayerFemale.AutoSize = true;
            rdoPlayerFemale.Location = new Point(6, 47);
            rdoPlayerFemale.Name = "rdoPlayerFemale";
            rdoPlayerFemale.Size = new Size(63, 19);
            rdoPlayerFemale.TabIndex = 2;
            rdoPlayerFemale.TabStop = true;
            rdoPlayerFemale.Text = "Female";
            rdoPlayerFemale.UseVisualStyleBackColor = true;
            // 
            // rdoPlayerNone
            // 
            rdoPlayerNone.AutoSize = true;
            rdoPlayerNone.Location = new Point(6, 72);
            rdoPlayerNone.Name = "rdoPlayerNone";
            rdoPlayerNone.Size = new Size(100, 19);
            rdoPlayerNone.TabIndex = 2;
            rdoPlayerNone.TabStop = true;
            rdoPlayerNone.Text = "No Preference";
            rdoPlayerNone.UseVisualStyleBackColor = true;
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Location = new Point(6, 15);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(74, 15);
            lblPlayerName.TabIndex = 0;
            lblPlayerName.Text = "Player Name";
            // 
            // lblCharacterPreference
            // 
            lblCharacterPreference.AutoSize = true;
            lblCharacterPreference.Location = new Point(0, 0);
            lblCharacterPreference.Name = "lblCharacterPreference";
            lblCharacterPreference.Size = new Size(117, 15);
            lblCharacterPreference.TabIndex = 0;
            lblCharacterPreference.Text = "Character Preference";
            // 
            // btnSubmitSingle
            // 
            btnSubmitSingle.Location = new Point(229, 64);
            btnSubmitSingle.Name = "btnSubmitSingle";
            btnSubmitSingle.Size = new Size(104, 43);
            btnSubmitSingle.TabIndex = 4;
            btnSubmitSingle.Text = "Submit and Close";
            btnSubmitSingle.UseVisualStyleBackColor = true;
            btnSubmitSingle.Click += btnSubmitSingle_Click;
            // 
            // btnSubmitMulti
            // 
            btnSubmitMulti.Location = new Point(229, 15);
            btnSubmitMulti.Name = "btnSubmitMulti";
            btnSubmitMulti.Size = new Size(104, 43);
            btnSubmitMulti.TabIndex = 3;
            btnSubmitMulti.Text = "Submit and Add Another Player";
            btnSubmitMulti.UseVisualStyleBackColor = true;
            btnSubmitMulti.Click += btnSubmitMulti_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(229, 116);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(104, 26);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // groupBoxGenderPref
            // 
            groupBoxGenderPref.Controls.Add(lblCharacterPreference);
            groupBoxGenderPref.Controls.Add(rdoPlayerMale);
            groupBoxGenderPref.Controls.Add(rdoPlayerFemale);
            groupBoxGenderPref.Controls.Add(rdoPlayerNone);
            groupBoxGenderPref.Location = new Point(69, 41);
            groupBoxGenderPref.Name = "groupBoxGenderPref";
            groupBoxGenderPref.Size = new Size(117, 100);
            groupBoxGenderPref.TabIndex = 6;
            groupBoxGenderPref.TabStop = false;
            // 
            // AddPlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 167);
            Controls.Add(groupBoxGenderPref);
            Controls.Add(btnClose);
            Controls.Add(btnSubmitMulti);
            Controls.Add(btnSubmitSingle);
            Controls.Add(lblPlayerName);
            Controls.Add(txtPlayerName);
            Name = "AddPlayerForm";
            Text = "AddPlayerForm";
            groupBoxGenderPref.ResumeLayout(false);
            groupBoxGenderPref.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlayerName;
        private RadioButton rdoPlayerMale;
        private RadioButton rdoPlayerFemale;
        private RadioButton rdoPlayerNone;
        private Label lblPlayerName;
        private Label lblCharacterPreference;
        private Button btnSubmitSingle;
        private Button btnSubmitMulti;
        private Button btnClose;
        private GroupBox groupBoxGenderPref;
    }
}
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
            btnSubmitSingle = new Button();
            btnSubmitMulti = new Button();
            btnClose = new Button();
            groupBoxGenderPref = new GroupBox();
            groupBoxGenderPref.SuspendLayout();
            SuspendLayout();
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(95, 6);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(158, 23);
            txtPlayerName.TabIndex = 1;
            txtPlayerName.KeyPress += txtPlayerName_KeyPress;
            // 
            // rdoPlayerMale
            // 
            rdoPlayerMale.AutoSize = true;
            rdoPlayerMale.Font = new Font("Segoe UI", 9F);
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
            rdoPlayerFemale.Font = new Font("Segoe UI", 9F);
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
            rdoPlayerNone.Font = new Font("Segoe UI", 9F);
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
            lblPlayerName.Location = new Point(12, 9);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(77, 15);
            lblPlayerName.TabIndex = 0;
            lblPlayerName.Text = "Player Name:";
            // 
            // btnSubmitSingle
            // 
            btnSubmitSingle.Location = new Point(149, 79);
            btnSubmitSingle.Name = "btnSubmitSingle";
            btnSubmitSingle.Size = new Size(104, 38);
            btnSubmitSingle.TabIndex = 4;
            btnSubmitSingle.Text = "Submit and Close";
            btnSubmitSingle.UseVisualStyleBackColor = true;
            btnSubmitSingle.Click += btnSubmitSingle_Click;
            // 
            // btnSubmitMulti
            // 
            btnSubmitMulti.Location = new Point(149, 35);
            btnSubmitMulti.Name = "btnSubmitMulti";
            btnSubmitMulti.Size = new Size(104, 38);
            btnSubmitMulti.TabIndex = 3;
            btnSubmitMulti.Text = "Submit and Add Another Player";
            btnSubmitMulti.UseVisualStyleBackColor = true;
            btnSubmitMulti.Click += btnSubmitMulti_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(149, 123);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(104, 26);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // groupBoxGenderPref
            // 
            groupBoxGenderPref.Controls.Add(rdoPlayerMale);
            groupBoxGenderPref.Controls.Add(rdoPlayerFemale);
            groupBoxGenderPref.Controls.Add(rdoPlayerNone);
            groupBoxGenderPref.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            groupBoxGenderPref.Location = new Point(12, 52);
            groupBoxGenderPref.Name = "groupBoxGenderPref";
            groupBoxGenderPref.Size = new Size(131, 97);
            groupBoxGenderPref.TabIndex = 6;
            groupBoxGenderPref.TabStop = false;
            groupBoxGenderPref.Text = "Character Preference";
            // 
            // AddPlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 162);
            Controls.Add(groupBoxGenderPref);
            Controls.Add(btnClose);
            Controls.Add(btnSubmitMulti);
            Controls.Add(btnSubmitSingle);
            Controls.Add(lblPlayerName);
            Controls.Add(txtPlayerName);
            Name = "AddPlayerForm";
            Text = "Add Players";
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
        private Button btnSubmitSingle;
        private Button btnSubmitMulti;
        private Button btnClose;
        private GroupBox groupBoxGenderPref;
    }
}
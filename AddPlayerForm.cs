namespace CPW211_MurderMystery
{
    public partial class AddPlayerForm : Form
    {
        public AddPlayerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Check if the Player Name is valid.
        /// </summary>
        /// <returns>True if valid.</returns>
        private static bool ValidatePlayerName(string playerName)
        {
            return !string.IsNullOrWhiteSpace(playerName);
        }

        /// <summary>
        /// Check if the Player Gender is valid.
        /// </summary>
        /// <param name="playerGender"></param>
        /// <returns>True if valid.</returns>
        private static bool ValidatePlayerGender(string playerGender)
        {
            return playerGender != "None";
        }

        /// <summary>
        /// Finds which radio button is Checked. If no radio button is Checked,
        /// set to "None".
        /// </summary>
        /// <returns>Returns the selected Gender.</returns>
        private string SelectedPlayerGender()
        {
            RadioButton? selectedRadioButton = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            return selectedRadioButton != null ? selectedRadioButton.Text : "None";
        }

        /// <summary>
        /// Adds Player to the database.
        /// </summary>
        private static void AddPlayer(string playerName, string playerGender)
        {
            Player p = new()
            {
                PlayerFullName = playerName,
                PlayerGender = playerGender
            };

            MurderMysteryContext context = new();
            context.Players.Add(p);
            context.SaveChanges();
            UpdateListBox();
        }

        /// <summary>
        /// Updates "lstPlayers" in the PartyCreatorForm.
        /// </summary>
        private static void UpdateListBox()
        {
            (Application.OpenForms["PartyCreatorForm"] as PartyCreatorForm)?.PopulateListBox();
        }

        /// <summary>
        /// Resets the AddPlayerForm.
        /// </summary>
        private void ResetForm()
        {
            txtPlayerName.Text = string.Empty;
            rdoPlayerMale.Checked = false;
            rdoPlayerFemale.Checked = false;
            rdoPlayerNone.Checked = false;
        }

        /// <summary>
        /// Check if the user submission is valid.
        /// </summary>
        /// <returns>True if valid.</returns>
        private static bool IsSubmissionValid(string playerName, string playerGender)
        {
            if (!ValidatePlayerName(playerName))
            {
                MessageBox.Show("Please enter a name.");

                return false;
            }
            if (!ValidatePlayerGender(playerGender))
            {
                MessageBox.Show("Please select a gender.");

                return false;
            }

            return true;
        }

        /// <summary>
        /// Adds Player to the database and resets the form.
        /// </summary>
        private void btnSubmitMulti_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text;
            string playerGender = SelectedPlayerGender();

            if (IsSubmissionValid(playerName, playerGender))
            {
                AddPlayer(playerName, playerGender);
                ResetForm();
            }
        }

        /// <summary>
        /// Adds Player to the database and closes the form.
        /// </summary>
        private void btnSubmitSingle_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text;
            string playerGender = SelectedPlayerGender();

            if (IsSubmissionValid(playerName, playerGender))
            {
                AddPlayer(playerName, playerGender);
                Close();
            }
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
        /// <param name="playerName"></param>
        /// <returns>True if valid.</returns>
        private static bool ValidatePlayerName(string playerName)
        {
            return !string.IsNullOrWhiteSpace(playerName);
        }

        /// <summary>
        /// Check if the Player Name already exists in the database.
        /// </summary>
        /// <param name="playerName"></param>
        /// <returns>True if the Name exists.</returns>
        private static bool PlayerNameExists(string playerName)
        {
            using MurderMysteryContext context = new();

            return context.Players.Any(p => p.PlayerName == playerName);
        }

        /// <summary>
        /// Check if the Player's Gender Preference is valid.
        /// </summary>
        /// <param name="GenderPreference"></param>
        /// <returns>True if valid.</returns>
        private static bool ValidateGenderPreference(string GenderPreference)
        {
            return GenderPreference != "None";
        }

        /// <summary>
        /// Finds which radio button is Checked. If no radio button is Checked,
        /// set to "None".
        /// </summary>
        /// <returns>Returns the selected Gender.</returns>
        private string SelectedGenderPreference()
        {
            RadioButton? selectedRadioButton = groupBoxGenderPref.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            return selectedRadioButton != null ? selectedRadioButton.Text : "None";
        }

        /// <summary>
        /// Adds Player to the database.
        /// </summary>
        private static void AddPlayer(string playerName, string playerGender)
        {
            Player p = new()
            {
                PlayerName = playerName,
                GenderPreference = playerGender
            };

            using MurderMysteryContext context = new();
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
        /// Get the number of Players from "lstPlayers" in the PartyCreatorForm.
        /// </summary>
        /// <returns>The number of Players.</returns>
        private static int? PlayerCount()
        {
            int? count = (Application.OpenForms["PartyCreatorForm"] as PartyCreatorForm)?.GetPlayerCount();

            return count;
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
            if (PlayerCount() >= 5)
            {
                MessageBox.Show("No more Players can be added.");

                return false;
            }

            if (!ValidatePlayerName(playerName))
            {
                MessageBox.Show("Please enter a name.");

                return false;
            }
            else if (PlayerNameExists(playerName))
            {
                MessageBox.Show("A Player with that name already exists.");

                return false;
            }

            if (!ValidateGenderPreference(playerGender))
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
            string playerGenderPreference = SelectedGenderPreference();

            if (IsSubmissionValid(playerName, playerGenderPreference))
            {
                AddPlayer(playerName, playerGenderPreference);
                ResetForm();
            }
        }

        /// <summary>
        /// Adds Player to the database and closes the form.
        /// </summary>
        private void btnSubmitSingle_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text;
            string playerGender = SelectedGenderPreference();

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

        /// <summary>
        /// Allows only Letters or Digits to be entered.
        /// </summary>
        private void txtPlayerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows the use of the Space and Backspace buttons
            List<char> allowedChars = [' ', '\b'];
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || allowedChars.Contains(e.KeyChar));
        }
    }
}

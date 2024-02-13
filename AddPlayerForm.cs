using RadioButton = System.Windows.Forms.RadioButton;

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
        private bool ValidatePlayerName()
        {
            if (string.IsNullOrWhiteSpace(txtPlayerName.Text))
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Finds which radio button is Checked.
        /// </summary>
        /// <returns>Returns the selected Gender.</returns>
        private string PlayerGenderSelected()
        {
            foreach (Control control in this.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = control as RadioButton;
                    if (radioButton.Checked)
                    {
                        return radioButton.Text.ToLower();
                    }
                }
            }

            return "no preference";
        }

        /// <summary>
        /// Adds Player to database.
        /// </summary>
        private void AddPlayer()
        {
            Player p = new()
            {
                PlayerFullName = txtPlayerName.Text,
                PlayerGender = PlayerGenderSelected()
            };

            MurderMysteryContext context = new();
            context.Players.Add(p);
            context.SaveChanges();
        }

        /// <summary>
        /// Updates "lstPlayers" in the PartyCreatorForm.
        /// </summary>
        private static void UpdateListBox()
        {
            (Application.OpenForms["PartyCreatorForm"] as PartyCreatorForm).PopulateListBox();
        }

        /// <summary>
        /// Resets the form.
        /// </summary>
        private void ResetForm()
        {
            txtPlayerName.Text = "";
            rdoPlayerMale.Checked = false;
            rdoPlayerFemale.Checked = false;
            rdoPlayerNone.Checked = false;
        }

        /// <summary>
        /// Adds Player to database and resets the form.
        /// </summary>
        private void btnSubmitMulti_Click(object sender, EventArgs e)
        {
            bool isValid = ValidatePlayerName();
            if (isValid)
            {
                AddPlayer();
                UpdateListBox();
                ResetForm();
            }
        }

        /// <summary>
        /// Adds Player to database and closes the form.
        /// </summary>
        private void btnSubmitSingle_Click(object sender, EventArgs e)
        {
            bool isValid = ValidatePlayerName();
            if (isValid)
            {
                AddPlayer();
                UpdateListBox();
                Close();
            }
        }

        /// <summary>
        /// Closes the form and updates "lstPlayers" in PartyCreatorForm.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            UpdateListBox();
            Close();
        }
    }
}

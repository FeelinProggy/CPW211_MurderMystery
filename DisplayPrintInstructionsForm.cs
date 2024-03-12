namespace CPW211_MurderMystery
{
    /// <summary>
    /// The DisplayPrintInstructionsForm displays the theme information and the characters assigned to players.
    /// Print function to be added at a later time for the user to print character information and scripts for players.
    /// </summary>
    public partial class DisplayPrintInstructionsForm : Form
    {
        private readonly Theme _theme;
        private readonly MurderMysteryContext _context;

        /// <summary>
        /// The constructor takes a Theme object as a parameter and initializes the _theme and _context fields.
        /// It also subscribes to the FormClosed event.
        /// </summary>
        /// <param name="theme">selectedTheme passed from PartyCreatorForm</param>
        public DisplayPrintInstructionsForm(Theme theme)
        {
            InitializeComponent();
            _theme = theme;
            _context = new MurderMysteryContext();
            FormClosed += DisplayPrintInstructionsForm_FormClosed;
        }

        // Sets the text of the rtbPrintThemeInfo control to the theme's title and summary,
        // calls the method to assign characters to players, and populates the cast list box.
        private void DisplayPrintInstructionsForm_Load(object sender, EventArgs e)
        {
            rtbPrintThemeInfo.Text = $"{_theme.Title}: {_theme.Summary}";
            CastAssignment.AssignCharacters(_context, _theme.ThemeId);
            PopulateCastListBox();
        }

        // The FormClosed event handler resets the AssignedCharacterId for all players and disposes of the _context object.
        private void DisplayPrintInstructionsForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _context.ResetAssignedCharacterId();
            _context.Dispose();
        }

        // Clears the list box and then adds the full name of each player and their assigned character.
        private void PopulateCastListBox()
        {

            lstPrintAssignedCast.Items.Clear();
            List<string> castList = [.. _context.Players
                .Where(p => p.AssignedCharacterId != null)
                .Select(p => $"{p.PlayerName} {TrimGender(p.GenderPreference)}  :  {p.AssignedCharacter.FullName} {TrimGender(p.AssignedCharacter.Gender)}")];
            foreach (string role in castList)
            {
                lstPrintAssignedCast.Items.Add(role);
            }
        }

        /// <summary>
        /// Trims the Gender string to something smaller.
        /// </summary>
        /// <param name="gender"></param>
        /// <returns>Returns a trimmed version of the string.</returns>
        private static string TrimGender(string gender)
        {
            if (gender == "Male")
            {
                return "[M]";
            }
            else if (gender == "Female")
            {
                return "[F]";
            }
            else
            {
                return "[NP]";
            }
        }

        private void btnCloseResults_Click(object sender, EventArgs e)
        {
            Close();
        }

        // The Click event handler for the FeatureInDevelopmentB button shows a message box that says "This feature is still being developed."
        private void FeatureInDevelopmentB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is still being developed.");
        }

        private void btnPrintResults_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is still being developed.");
        }
    }
}

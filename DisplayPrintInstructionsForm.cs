namespace CPW211_MurderMystery
{
    public partial class DisplayPrintInstructionsForm : Form
    {
        private Theme _theme;

        public DisplayPrintInstructionsForm(Theme theme)
        {
            InitializeComponent();
            _theme = theme;
            this.FormClosed += DisplayPrintInstructionsForm_FormClosed;
        }

        private void DisplayPrintInstructionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            using MurderMysteryContext context = new();
            context.ResetAssignedCharacterId();
        }

        private void DisplayPrintInstructionsForm_Load(object sender, EventArgs e)
        {
            rtbThemeSelection.Text = $"{_theme.Title}: {_theme.Summary}";

            using (var context = new MurderMysteryContext())
            {
                CastAssignment.AssignCharacters(context, _theme.ThemeId);
            }
        }

        private void btnCloseResults_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}





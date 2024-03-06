namespace CPW211_MurderMystery
{
    public partial class DisplayPrintInstructionsForm : Form
    {
        private Theme _theme;
        private MurderMysteryContext _context;

        public DisplayPrintInstructionsForm(Theme theme)
        {
            InitializeComponent();
            _theme = theme;
            _context = new MurderMysteryContext();
            this.FormClosed += DisplayPrintInstructionsForm_FormClosed;
        }

        private void DisplayPrintInstructionsForm_Load(object sender, EventArgs e)
        {
            rtbThemeSelection.Text = $"{_theme.Title}: {_theme.Summary}";
            CastAssignment.AssignCharacters(_context, _theme.ThemeId);
        }

        private void btnCloseResults_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayPrintInstructionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.ResetAssignedCharacterId();
            _context.Dispose();
        }
    }
}





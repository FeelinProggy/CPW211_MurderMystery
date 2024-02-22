namespace CPW211_MurderMystery
{
    public partial class PartyCreatorForm : Form
    {
        public PartyCreatorForm()
        {
            InitializeComponent();
            PopulateListBox();
        }

        /// <summary>
        /// Clears "lstPlayers" then populates it with data from the Players table.
        /// </summary>
        public void PopulateListBox()
        {
            lstPlayers.Items.Clear();

            using MurderMysteryContext context = new();
            var playerList = context.Players
                                    .Select(p => $"{p.PlayerFullName} : {p.PlayerGender}")
                                    .ToList();

            foreach (string playerData in playerList)
            {
                lstPlayers.Items.Add(playerData);
            }
        }

        /// <summary>
        /// Removes the selected Player from the database and "lstPlayers".
        /// </summary>
        /// <param name="playerToRemove"></param>
        private void RemovePlayer(string playerToRemove)
        {
            using MurderMysteryContext context = new();
            Player? selectedPlayer = context.Players.FirstOrDefault(p => p.PlayerFullName == playerToRemove);

            if (selectedPlayer != null)
            {
                context.Players.Remove(selectedPlayer);
                context.SaveChanges();
                lstPlayers.Items.RemoveAt(lstPlayers.SelectedIndex);
            }
        }

        /// <summary>
        /// Trims "lstPlayers" selected item so only the Player Name is left.
        /// </summary>
        /// <returns>Returns a trimmed version of the string.</returns>
        private string TrimPlayerName()
        {
            string? playerToRemove = lstPlayers.SelectedItem?.ToString();
            int index = playerToRemove.IndexOf(" :");

            return index >= 0 ? playerToRemove[..index] : playerToRemove;
        }

        private void btnAddPlayers_Click(object sender, EventArgs e)
        {
            using AddPlayerForm addPlayer = new();
            addPlayer.ShowDialog();
        }

        private void btnRemovePlayers_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex != -1)
            {
                RemovePlayer(TrimPlayerName());
            }
            else
            {
                MessageBox.Show("Select a Player from the list to remove.");
            }
        }
    }
}

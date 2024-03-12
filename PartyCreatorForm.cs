using Microsoft.EntityFrameworkCore;

namespace CPW211_MurderMystery
{
    public partial class PartyCreatorForm : Form
    {
        public PartyCreatorForm()
        {
            InitializeComponent();
            PopulateListBox();
        }
        private void PartyCreatorForm_Load(object sender, EventArgs e)
        {
            using MurderMysteryContext context = new(); // Initialize your context

            // Fetch data from the Themes table
            DbSet<Theme> themes = context.Themes;

            // Populate ComboBox with theme titles
            cboTheme.DataSource = themes.ToList();
            cboTheme.DisplayMember = "Title"; // Display the 'Title' property
        }

        private void cboTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTheme.SelectedItem != null)
            {
                // Retrieve the selected theme from the ComboBox
                Theme selectedTheme = (Theme)cboTheme.SelectedItem;

                // Update the TextBox with the corresponding summary
                txtThemeSummary.Text = selectedTheme.Summary;
            }
        }

        /// <summary>
        /// Clears "lstPlayers" then populates it with data from the Players table.
        /// </summary>
        public void PopulateListBox()
        {
            lstPlayers.Items.Clear();

            using MurderMysteryContext context = new();
            List<string> playerList = [.. context.Players.Select(p => $"{p.PlayerName} : {p.GenderPreference}")];

            foreach (string playerData in playerList)
            {
                lstPlayers.Items.Add(playerData);
            }
        }

        /// <summary>
        /// Get the number of Players from "lstPlayers".
        /// </summary>
        /// <returns>The number of Players.</returns>
        public int? GetPlayerCount()
        {
            return lstPlayers.Items.Count;
        }

        /// <summary>
        /// Removes the selected Players from the database and "lstPlayers".
        /// </summary>
        private void RemoveSelectedPlayers()
        {
            using MurderMysteryContext context = new();

            ListBox.SelectedObjectCollection selectedItems = lstPlayers.SelectedItems;

            if (selectedItems.Count > 0)
            {
                foreach (string? selectedPlayer in selectedItems.Cast<string>())
                {
                    string playerName = TrimPlayerName(selectedPlayer);
                    Player? player = context.Players.FirstOrDefault(p => p.PlayerName == playerName);
                    if (player != null)
                    {
                        context.Players.Remove(player);
                        context.SaveChanges();
                    }
                }

                // Remove selected items from the "lstPlayers".
                foreach (string? selectedPlayer in selectedItems.Cast<string>().ToList())
                {
                    lstPlayers.Items.Remove(selectedPlayer);
                }
            }
        }

        private void RemoveAllPlayers()
        {
            using MurderMysteryContext context = new();

            foreach (string? selectedPlayer in lstPlayers.Items.Cast<string>())
            {
                string playerName = TrimPlayerName(selectedPlayer);
                Player? player = context.Players.FirstOrDefault(p => p.PlayerName == playerName);
                if (player != null)
                {
                    context.Players.Remove(player);
                    context.SaveChanges();
                }
            }

            lstPlayers.Items.Clear();
        }

        /// <summary>
        /// Trims "lstPlayers" selected item so only the Player Name is left.
        /// </summary>
        /// <param name="playerName"></param>
        /// <returns>Returns a trimmed version of the string.</returns>
        private static string TrimPlayerName(string playerName)
        {
            int index = playerName.IndexOf(" :");

            return index >= 0 ? playerName[..index] : playerName;
        }

        private void btnAddPlayers_Click(object sender, EventArgs e)
        {
            if (GetPlayerCount() >= 5)
            {
                MessageBox.Show("No more Players can be added.");
            }
            else
            {
                using AddPlayerForm addPlayer = new();
                addPlayer.ShowDialog();
            }
        }

        private void btnRemovePlayers_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndices.Count > 0)
            {
                RemoveSelectedPlayers();
            }
            else if (lstPlayers.SelectedIndices.Count == 0 && GetPlayerCount() != 0)
            {
                MessageBox.Show("Select one or more Players from the list to remove.");
            }
            else
            {
                MessageBox.Show("There are no Players to remove.");
            }
        }

        private void btnRemoveAllPlayers_Click(object sender, EventArgs e)
        {
            if (GetPlayerCount() != 0)
            {
                RemoveAllPlayers();
            }
            else
            {
                MessageBox.Show("There are no Players to remove.");
            }
        }


        private void btnPrintInstructions_Click(object sender, EventArgs e)
        {
            if (GetPlayerCount() == 0)
            {
                MessageBox.Show("Add Players using the [Add Players] button.");
            }
            else if (cboTheme.SelectedItem is Theme selectedTheme && selectedTheme.ThemeId != 1)
            {
                using DisplayPrintInstructionsForm displayGame = new(selectedTheme);
                displayGame.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a theme.");
            }
        }

        private void FeatureInDevelopmentA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is still being developed.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

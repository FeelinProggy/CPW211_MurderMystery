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
			var player = context.Players.Select(p => new { p.PlayerFullName, p.PlayerGender }).ToList();

			foreach (var playerData in player)
			{
				string listItem = $"{playerData.PlayerFullName} : {playerData.PlayerGender}";
				lstPlayers.Items.Add(listItem);
			}
		}

		/// <summary>
		/// Removes the selected Player from the database.
		/// </summary>
		/// <param name="playerToRemove"></param>
		private void RemovePlayer(string playerToRemove)
		{
			lstPlayers.Items.RemoveAt(lstPlayers.SelectedIndex);

			using MurderMysteryContext context = new();
			Player player = context.Players.FirstOrDefault(p => p.PlayerFullName == playerToRemove);

			if (player != null)
			{
				context.Players.Remove(player);
				context.SaveChanges();
			}
		}

		/// <summary>
		/// Trims "lstPlayers" selected item so only the Player Name is left.
		/// </summary>
		/// <returns>Returns a trimmed version of the string.</returns>
		private string PlayerToRemoveTrim()
		{
			string playerToRemove = lstPlayers.SelectedItem.ToString();
			string trimCharacter = " :";
			int index = playerToRemove.IndexOf(trimCharacter);
			if (index >= 0)
			{
				playerToRemove = playerToRemove.Substring(0, index);
			}

			return playerToRemove;
		}

		private void btnAddPlayers_Click(object sender, EventArgs e)
		{
			AddPlayerForm addPlayer = new AddPlayerForm();
			addPlayer.ShowDialog();
		}

		private void btnRemovePlayers_Click(object sender, EventArgs e)
		{
			if (lstPlayers.SelectedIndex != -1)
			{
				string playerToRemove = PlayerToRemoveTrim();
				RemovePlayer(playerToRemove);
			}
		}
	}
}

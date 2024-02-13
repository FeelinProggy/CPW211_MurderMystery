using Microsoft.Data.SqlClient;
using System.Windows.Forms;

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

            using (var context = new MurderMysteryContext())
            {
                var player = context.Players.Select(p => new {p.PlayerFullName, p.PlayerGender}).ToList();

                foreach (var playerData in player)
                {
                    string listItem = $"{playerData.PlayerFullName} : {playerData.PlayerGender}";
                    lstPlayers.Items.Add(listItem);
                }
            }
        }

        private void btnAddPlayers_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayer = new AddPlayerForm();
            addPlayer.ShowDialog();
        }

        private void btnRemovePlayers_Click(object sender, EventArgs e)
        {

        }
    }
}

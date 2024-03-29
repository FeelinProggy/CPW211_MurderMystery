/*
using CPW211_MurderMystery;
using System.Text;

using MurderMysteryContext context = new();

Player p1 = new()
{
    PlayerName = "Player 1",
    GenderPreference = "Mmale" // Invalid Gender
};

Player p2 = new()
{
    PlayerName = ":Person 2:", // Invalid Name
    GenderPreference = "Female"
};

Player p3 = new()
{
    PlayerName = "User Three", // Name already exists
    GenderPreference = "No Preference"
};

// Add to database
//context.Players.Add(p1);
//context.SaveChanges(); // Should throw an Error: Invalid Gender

//context.Players.Add(p2);
//context.SaveChanges(); // Should throw an Error: Invalid Name

//context.Players.Add(p3);
//context.SaveChanges(); // Should throw an Error: Name already exists

List<Player> allPlayers = [.. context.Players];
StringBuilder displayAllPlayers = new();
foreach (Player player in allPlayers)
{
    if (player.PlayerGender == "No Preference")
    {
        displayAllPlayers.AppendLine($"{player.PlayerFullName} has {player.PlayerGender}");
    }
    else
    {
        displayAllPlayers.AppendLine($"{player.PlayerFullName} is {player.PlayerGender}");
    }
}
MessageBox.Show(displayAllPlayers.ToString());
*/

namespace CPW211_MurderMystery
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PartyCreatorForm());
        }
    }
}

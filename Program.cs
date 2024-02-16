/*
using CPW211_MurderMystery;
using System.Text;

using MurderMysteryContext dbContext = new();

Player p1 = new()
{
    PlayerFullName = "Joe Ortiz",
    PlayerGender = "Mmale"
};

Player p2 = new()
{
    PlayerFullName = "Jane Ortiz",
    PlayerGender = "Female"
};

Player p3 = new()
{
    PlayerFullName = "J Ortiz",
    PlayerGender = "No preference"
};

// Add to database
dbContext.Players.Add(p1);
dbContext.SaveChanges(); // Should throw an Error

dbContext.Players.Add(p2);
dbContext.SaveChanges();

dbContext.Players.Add(p3);
dbContext.SaveChanges();

List<Player> allPlayers = dbContext.Players.ToList();
StringBuilder displayAllPlayers = new();
foreach (Player player in allPlayers)
{
    if (player.PlayerGender == "no preference")
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

/*
using CPW211_MurderMystery;

using PlayerContext dbContext = new();

Player p1 = new()
{
    PlayerFullName = "Joe Ortiz",
    PlayerGender = "male"
};

Player p2 = new()
{
    PlayerFullName = "Jane Ortiz",
    PlayerGender = "female"
};

Player p3 = new()
{
    PlayerFullName = "J Ortiz",
    PlayerGender = "no preference"
};

dbContext.Players.Add(p1);
dbContext.SaveChanges();

dbContext.Players.Add(p2);
dbContext.SaveChanges();

dbContext.Players.Add(p3);
dbContext.SaveChanges();

List<Player> allPlayers = dbContext.Players.ToList();
foreach (Player player in allPlayers)
{
    if (player.PlayerGender == "no preference")
    {
        MessageBox.Show($"{player.PlayerFullName} has {player.PlayerGender}");
    }
    else
    {
        MessageBox.Show($"{player.PlayerFullName} is a {player.PlayerGender}");
    }
}
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

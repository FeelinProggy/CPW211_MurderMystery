﻿namespace CPW211_MurderMystery
{
    public class CastAssignment
    {
        /// <summary>
        /// This class is called from DisplayPrintInstructionsForm to assign characters to players based on the preferences given on the AddPlayerForm.
        /// The options at this time are Male, Female, and No preference. The characters' genders are given in the Characters table based on the Theme selected.
        /// </summary>
        /// <param name="context">_context passed from DisplayPrintInstructionsForm</param>
        /// <param name="selectedThemeId">Theme selected on PartyCreatorForm</param>
        public static void AssignCharacters(MurderMysteryContext context, int selectedThemeId)
        {
            // Get all players and the characters for the selected theme
            List<Player> players = [.. context.Players];
            List<Character> characters = [.. context.Characters
                .Where(c => c.ThemeId == selectedThemeId)];

            // Loop through each player
            foreach (Player player in players)
            {
                // Get the player's gender preference
                string genderPreference = player.GenderPreference;

                // Get the list of available characters that match the player's gender preference
                List<Character> availableCharacters = characters.Where(c => c.Gender == genderPreference && !context.Players.Any(p => p.AssignedCharacterId == c.CharacterId)).ToList();

                Character? assignedCharacter = null;

                // If there are any available characters that match the player's gender preference
                if (availableCharacters.Count != 0)
                {
                    // Assign a random character from the list of available characters
                    assignedCharacter = availableCharacters[new Random().Next(availableCharacters.Count)];
                }
                else
                {
                    // If no characters of the preferred gender are available, get the list of any remaining characters
                    List<Character> remainingCharacters = characters.Where(c => !context.Players.Any(p => p.AssignedCharacterId == c.CharacterId)).ToList();

                    // If there are any remaining characters
                    if (remainingCharacters.Count != 0)
                    {
                        // Assign a random character from the list of remaining characters
                        assignedCharacter = remainingCharacters[new Random().Next(remainingCharacters.Count)];
                    }
                }

                // If a character was assigned
                if (assignedCharacter != null)
                {
                    // Set the player's AssignedCharacterId to the ID of the assigned character
                    player.AssignedCharacterId = assignedCharacter.CharacterId;

                    // Remove the assigned character from the list of available characters
                    characters.Remove(assignedCharacter);
                }
            }

            // Save the changes to the context
            context.SaveChanges();
        }
    }
}

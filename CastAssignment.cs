using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_MurderMystery
{
    public class CastAssignment
    {
        
        public static void AssignCharacters(MurderMysteryContext context, int selectedThemeId)
        {
            var players = context.Players.ToList();
            var characters = context.Characters
                .Where(c => c.ThemeId == selectedThemeId)
                .ToList();

            foreach (var player in players)
            {
                var genderPreference = player.GenderPreference;
                var availableCharacters = characters.Where(c => c.Gender == genderPreference && !context.Players.Any(p => p.AssignedCharacterId == c.CharacterId)).ToList();

                Character assignedCharacter = null;
                if (availableCharacters.Any())
                {
                    // Assign character based on gender preference
                    assignedCharacter = availableCharacters[new Random().Next(availableCharacters.Count)];
                }
                else
                {
                    // If no characters of the preferred gender are available, assign any remaining character
                    var remainingCharacters = characters.Where(c => !context.Players.Any(p => p.AssignedCharacterId == c.CharacterId)).ToList();
                    if (remainingCharacters.Any())
                    {
                        assignedCharacter = remainingCharacters[new Random().Next(remainingCharacters.Count)];
                    }
                }

                if (assignedCharacter != null)
                {
                    player.AssignedCharacterId = assignedCharacter.CharacterId;
                    characters.Remove(assignedCharacter); // Remove the assigned character from the list
                }
            }

            context.SaveChanges();
        }

    }
}

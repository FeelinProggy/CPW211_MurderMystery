using System.ComponentModel.DataAnnotations;

namespace CPW211_MurderMystery
{
    /// <summary>
    /// The Players for the game.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// The Player Id.
        /// </summary>
        [Key]
        public int PlayerId { get; set; }

        /// <summary>
        /// The Players name or alias.
        /// </summary>
        [StringLength(50)]
        public required string PlayerName { get; set; }

        /// <summary>
        /// The Players gender preference.
        /// </summary>
        [StringLength(13)]
        public required string GenderPreference { get; set; }


        public int? AssignedCharacterId { get; set; }


        public Character? AssignedCharacter { get; set; }

    }
}
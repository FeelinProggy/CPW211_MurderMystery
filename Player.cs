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
        /// The Player name.
        /// </summary>
        [StringLength(50)]
        public string PlayerFullName { get; set; }

        /// <summary>
        /// The Player gender.
        /// </summary>
        [StringLength(13)]
        public string PlayerGender { get; set; }
    }
}
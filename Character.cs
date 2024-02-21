using System.ComponentModel.DataAnnotations;

namespace CPW211_MurderMystery
{
    /// <summary>
    /// The Characters for the game.
    /// </summary>
    public class Character
    {
        /// <summary>
        /// The Characters Id number.
        /// </summary>
        [Key]
        public int CharacterId { get; set; }

        /// <summary>
        /// Foreign key to the Character's story Theme.
        /// </summary>
        public int ThemeId { get; set; }

        /// <summary>
        /// Navigation property for the 
        /// Character's Theme.
        /// </summary>
        public Theme Theme { get; set; }

        /// <summary>
        /// The Characters first and last name.
        /// </summary>
        [StringLength(50)]
        public string FullName { get; set; }

        /// <summary>
        /// The Characters gender.
        /// </summary>
        [StringLength(13)]
        public string Gender { get; set; }

        /// <summary>
        /// The Characters job.
        /// </summary>
        [StringLength(50)]
        public string Occupation { get; set; }

        /// <summary>
        /// The Character's quotes.
        /// </summary>
        [StringLength(500)]
        public string CharScript { get; set; }

        /// <summary>
        /// The Description of the character and their personality.
        /// </summary>
        [StringLength(500)]
        public string Desc { get; set; }
    }
}
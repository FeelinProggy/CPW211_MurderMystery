﻿using System.ComponentModel.DataAnnotations;

namespace CPW211_MurderMystery
{
    /// <summary>
    /// The Themes for the game.
    /// </summary>
    public class Theme
    {
        /// <summary>
        /// The Theme Id.
        /// </summary>
        [Key]
        public int ThemeId { get; set; }

        /// <summary>
        /// The Theme title.
        /// </summary>
        [StringLength(50)]
        public required string Title { get; set; }

        /// <summary>
        /// The Theme Summary.
        /// </summary>
        [StringLength(500)]
        public required string Summary { get; set; }

        /// <summary>
        /// Navigation property for the 
        /// Characters in the Theme.
        /// </summary>
        public ICollection<Character>? Characters { get; set; } 
    }
}

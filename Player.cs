using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_MurderMystery
{
    public class Player
    {
        /// <summary>
        /// The player id
        /// </summary>
        [Key]
        public int PlayerId { get; set; }

        /// <summary>
        /// The player name
        /// </summary>
        [Required]
        [MaxLength(150)]
        public string PlayerFullName { get; set; }

        /// <summary>
        /// The players gender
        /// </summary>
        public string PlayerGender { get; set; }
    }
}

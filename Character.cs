using System.ComponentModel.DataAnnotations;


namespace CPW211_MurderMystery
{
    public class Character
    {

        /// <summary>
        /// Characters Id number
        /// </summary>
        [Key]
        public int CharacterId { get; set; }
    

        /// <summary>
        /// Characters first and last name
        /// </summary>
        public string FullName { get; set; }
        
        /// <summary>
        /// Characters gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Characters job
        /// </summary>
        public string Occupation { get; set; }

        /// <summary>
        /// Character's quotes
        /// </summary>
        public string CharScript { get; set; }

        /// <summary>
        /// Description of the character and their personality
        /// </summary>
        public string Desc { get; set; }

    }

}
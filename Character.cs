using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_MurderMystery
{
    internal class Character
    {
        private int _characterId;

        public Character(string fullName, string gender, string occupation, string script, string description)
        {
            FullName = fullName;
            Gender = gender;
            Occupation = occupation;
            CharScript = script;
            Desc = description;
        }

        /// <summary>
        /// Characters Id number
        /// </summary>
        public int CharacterId
        {
            get { return _characterId; }
            set { _characterId = value; }
        }

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

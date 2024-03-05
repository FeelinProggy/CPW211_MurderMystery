using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_MurderMystery
{
    public class CastAssignment
    {
        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    class Player
    {
        public Player(string name, string fillType
            )
        {
            Name = name;
            FillType = fillType;
        }

        public string Name { get; set; }

        public string FillType { get; set; }
    }
}

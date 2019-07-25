using System;
using System.Collections.Generic;

namespace Pappelitos.Domain
{
    public class Player
    {
        public int Id {get; set;}
        public String Name {get; set;}
        public Player (String name){
            this.Name = name;
        }
    }
}

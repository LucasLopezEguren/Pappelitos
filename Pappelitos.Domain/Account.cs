using System;
using System.Collections.Generic;

namespace Pappelitos.Domain
{
    public class Account
    {
        public int Id {get; set;}
        public String Username {get; set;}
        public String Password {get; set;}
        public String Mail {get; set;}
        public List<Player> Players {get; set;}
        public List<Match> Matches {get; set;}

        public Account (){
            this.Players = new List<Player>();  
            Player user = new Player(Username);
            this.Players.Add(user);
            this.Matches = new List<Match>();   
        }
    }
}

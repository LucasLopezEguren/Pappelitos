﻿using System;
using System.Collections.Generic;

namespace Pappelitos.Domain
{
    public class Account
    {
        public int Id {get; set;}
        public String Username {get; set;}
        public String Password {get; set;}
        public String Mail {get; set;}
        public IEnumerable<Player> Players {get; set;}
        public IEnumerable<Match> Matches {get; set;}
    }
}

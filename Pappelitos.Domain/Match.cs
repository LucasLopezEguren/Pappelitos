using System;
using System.Collections.Generic;

namespace Pappelitos.Domain
{
    public class Match
    {
        public int Id {get; set;}
        public List<String> TeamA {get; set;}
        public List<String> TeamB {get; set;}
        public int ScoreA {get; set;}
        public int ScoreB {get; set;}
        public List<Card> Cards {get; set;}
        public int TimePerRound {get; set;}
    }
}

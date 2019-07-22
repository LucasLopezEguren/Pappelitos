using System;
using System.Collections.Generic;

namespace Pappelitos.Domain
{
    public class Category
    {
        public int Id {get; set;}
        public String Name {get; set;}
        public String Description {get; set;}
        public List<Card> Cards {get; set;}
    }
}

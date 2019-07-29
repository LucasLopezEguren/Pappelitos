using System;
using Pappelitos.Domain;

namespace Pappelitos.BusinessLogic.Interface
{
    public interface IMatchLogic 
    {
        Match AddMatch(Match toAdd);
        Match UpdateMatch(Match toUpdate);
        void DeleteMatch(int id);
    }
}

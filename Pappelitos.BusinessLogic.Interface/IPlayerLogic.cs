using System;
using Pappelitos.Domain;

namespace Pappelitos.BusinessLogic.Interface
{
    public interface IPlayerLogic 
    {
        Player AddPlayer(String toAdd);
        void DeletePlayer(int id);
    }
}

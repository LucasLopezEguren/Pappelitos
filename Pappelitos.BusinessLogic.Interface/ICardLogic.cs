using System;
using Pappelitos.Domain;

namespace Pappelitos.BusinessLogic.Interface
{
    public interface ICardLogic 
    {
        Card AddCard(Card toAdd);
        Card UpdateCard(Card toUpdate);
        void DeleteCard(int id);
    }
}

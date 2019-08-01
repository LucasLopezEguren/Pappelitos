using System;
using Pappelitos.Domain;
using Pappelitos.BusinessLogic.Interface;
using Pappelitos.DataAccess.Interface;

namespace Pappelitos.BusinessLogic
{
    public class CardLogic : ICardLogic
    {
        private IRepository<Card> cardRepository;
        public CardLogic(IRepository<Card> repository)
        {
            this.cardRepository = repository;
        }
        public Card AddCard(Card card)
        {
            cardRepository.Add(card);
            cardRepository.Save();
            return card;
        }
        public void DeleteCard(int id)
        {
            Card toDelete = cardRepository.GetById(id);
            cardRepository.Delete(toDelete);
            cardRepository.Save();
        }
        public Card UpdateCard(Card card)
        {
            cardRepository.Update(card);
            cardRepository.Save();
            return card;
        }
    }
}

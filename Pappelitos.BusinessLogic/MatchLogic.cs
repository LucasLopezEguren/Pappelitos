using System;
using Pappelitos.Domain;
using Pappelitos.BusinessLogic.Interface;
using Pappelitos.DataAccess.Interface;

namespace Pappelitos.BusinessLogic
{
    public class MatchLogic : IMatchLogic
    {
        private IRepository<Match> matchRepository;
        public MatchLogic(IRepository<Match> repository)
        {
            this.matchRepository = repository;
        }
        public Match AddMatch(Match match)
        {
            matchRepository.Add(match);
            matchRepository.Save();
            return match;
        }
        public void DeleteMatch(int id)
        {
            Match toDelete = matchRepository.GetByID(id);
            matchRepository.Delete(toDelete);
            matchRepository.Save();
        }
        public Match UpdateMatch(Match match)
        {
            matchRepository.Update(match);
            matchRepository.Save();
            return match;
        }
    }
}

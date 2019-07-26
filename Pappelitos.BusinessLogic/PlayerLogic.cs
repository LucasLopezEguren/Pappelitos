using System;
using Pappelitos.Domain;
using System.Collections.Generic;
using Pappelitos.BusinessLogic.Interface;
using Pappelitos.DataAccess.Interface;

namespace Pappelitos.BusinessLogic
{
    public class PlayerLogic : IPlayerLogic
    {
        private IRepository<Player> playerRepository;
        public PlayerLogic(IRepository<Player> repository)
        {
            this.playerRepository = repository;
        }
        public Player AddPlayer(String playerName)
        {
            Player player = new Player(playerName);
            playerRepository.Add(player);
            playerRepository.Save();
            return player;
        }
        public void DeletePlayer(int id)
        {
            Player toDelete = playerRepository.GetByID(id);
            playerRepository.Delete(toDelete);
            playerRepository.Save();
        }
        public Player UpdatePlayer(Player player)
        {
            playerRepository.Update(player);
            playerRepository.Save();
            return player;
        }
    }
}

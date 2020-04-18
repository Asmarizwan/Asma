using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc2Hockey.Models
{
    public class PlayerRepository : IPlayerRepository
    {
        public Player Get(int Id)
        {
            return GetAll().FirstOrDefault(p => p.Id == Id);
        }

        public IEnumerable<Player> GetAll()
        {
            return new[]
           {
                new Player{ Id = 1, JerseyNumber = 13, Name = "Mats Sundin"},
                new Player{ Id = 2, JerseyNumber = 21, Name = "Peter Forsberg"},
                new Player{ Id = 3, JerseyNumber = 5, Name = "Niklas Lidström"}
            };
        }
    }
}

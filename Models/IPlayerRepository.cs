using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc2Hockey.Models
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> GetAll();
        Player Get(int id);
    }
}

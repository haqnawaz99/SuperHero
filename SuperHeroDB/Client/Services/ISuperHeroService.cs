using SuperHeroDB.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroDB.Client.Services
{
    public interface ISuperHeroService
    {
        Task<List<SuperHero>> GetSuperHeroes();

        Task<SuperHero> GetSuperHero(int id);
    }
}

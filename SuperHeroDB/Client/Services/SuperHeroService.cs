using SuperHeroDB.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SuperHeroDB.Client.Services
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly HttpClient httpClient;
        public SuperHeroService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<SuperHero>> GetSuperHeroes()
        {
          return  await httpClient.GetFromJsonAsync<List<SuperHero>>("api/superhero");
        }

        public async Task<SuperHero> GetSuperHero(int id)
        {
            return await httpClient.GetFromJsonAsync<SuperHero>($"api/superhero/{id}");
        }
    }
}

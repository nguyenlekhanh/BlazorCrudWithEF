﻿using System.Net.Http.Json;

namespace BlazorCrudWithEF.Client.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly HttpClient _http;

        public SuperHeroService(HttpClient http) 
        {   
            _http = http;
        }

        public List<SuperHero> Heroes { get; set; } = new List<SuperHero>();
        public List<Comic> Comics { get; set; } = new List<Comic>();
        public HttpClient Http { get; }

        public Task GetComics()
        {
            throw new NotImplementedException();
        }

        public Task<SuperHero> GetSingleHero(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetSuperHeroes()
        {
            var result = await _http.GetFromJsonAsync<List<SuperHero>>("api/superhero");
            if(result != null)
            {
                Heroes = result;
            }
            
        }
    }
}

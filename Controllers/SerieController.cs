using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TvHeaven.Models;


namespace TvHeaven.Controllers 
{

    [ApiController] // Decoration
    [Route("api/[controller]")]
    public class SerieController : ControllerBase
    {

        private List<Serie> GetAllSerie() 
        {
            List<Serie> newSerieList = new List<Serie>
            {
                new Serie 
                { 
                    Id = 1000, 
                    Title = "Lusifer", 
                    Category ="Drama", 
                    year = 2021 
                },

                new Serie 
                { 
                    Id = 1001, 
                    Title = "Game of Thrones", 
                    Category ="Drama", 
                    year = 2014 
                },

                new Serie 
                { 
                    Id = 1002, 
                    Title = "Animal Kingdom", 
                    Category ="Action", 
                    year = 2019 
                    },

                new Serie 
                { 
                    Id = 1003, 
                    Title = "Simpsons", 
                    Category ="Comedy", 
                    year = 2020 
                }
            };

            return newSerieList;
        } 

        [HttpGet] // domene/api/controller
        public IEnumerable<Serie> Get()
        {
            return GetAllSerie();
        }

        [HttpGet("{id}")] // domenene/api/controller/id
        public Serie Get(int id)
        {
            Serie serie = GetAllSerie().Find( serie => serie.Id == id );
            return serie;
        }

    }
}
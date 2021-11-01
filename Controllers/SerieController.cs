using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TvHeaven.Models;
using TvHeaven.Services;


namespace TvHeaven.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class SerieController : ControllerBase
    {
        private readonly SerieService _serieService;

        public SerieController(SerieService serieService)
        {
            _serieService = serieService;
        }

        [HttpGet]
        public IEnumerable<Serie> Get()
        {
            return _serieService.Get();    
        }        
    }
}
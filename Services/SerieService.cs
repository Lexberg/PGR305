using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using TvHeaven.Models;

namespace TvHeaven.Services
{

    public class SerieService 
    {
        private readonly IMongoCollection<Serie> _series;

        public SerieService(ISerieDatabaseSettings settings)
        {
            var client = new MongoClient( settings.ConnectionString );
            var database = client.GetDatabase( settings.DatabaseName );
            _series = database.GetCollection<Serie>( settings.SeriesCollectionName );            
        }

        public List<Serie> Get()
        {
            return _series.Find( serie => true ).ToList();
        }

    }

}
using TvHeaven.Interfaces;

namespace TvHeaven.Models 
{
    public class Serie : ISerie {
        public int Id { get; init; }
        public string Title { get; set; }
        public string Category { get; set; }
        public double year { get; set; }


    }
}
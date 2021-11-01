namespace TvHeaven.Models{
    public class SerieDatabaseSettings : ISerieDatabaseSettings
    {
        public string SeriesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
    public interface ISerieDatabaseSettings
    {
        string SeriesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
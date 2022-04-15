namespace MongoDBAPI.Data
{
    public class MoviesDatabaseSettings
    {
        public string ConnectionString { get; set; } = string.Empty;

        public string DataBaseName { get; set; } = string.Empty;

        public string MoviesCollectionName { get; set; } = string.Empty;
    }
}

namespace MovieTheater.Data
{
    public class Application
    {
        public static MovieTheaterEntity GetDatabaseInstance()
        {
            return new MovieTheaterEntity();
        }
    }
}
using API.Model;

namespace API.Services
{
    public interface IMovieService
    {
        public List<Movie> GetMovies(string searchItem);  
        public bool BookMovie(Booking movie);
    }
}

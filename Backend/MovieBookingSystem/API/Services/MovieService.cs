using API.Model;

namespace API.Services
{
    public class MovieService : IMovieService
    {
        public static List<Movie> MoviesList = new List<Movie>()
        {
            new Movie()
            {
                Id = 1,
                Title = "3 Idiots",
                Theaters = new List<Theater>()
                {
                    new Theater(){
                        Id = 1,
                        CityId = 1,
                        TheaterName = "Theater 1",
                        Screens = new List<Screen>()
                        {
                            new Screen()
                            {
                                Seats = new List<Seats>()
                                {
                                    new Seats()
                                    {
                                        SeatNumber = 1,
                                        SeatStatus = Enums.SeatStatus.Available,
                                        SeatTypes = Enums.SeatTypes.Prime
                                    },
                                    new Seats()
                                    {
                                        SeatNumber = 2,
                                        SeatStatus = Enums.SeatStatus.Available,
                                        SeatTypes = Enums.SeatTypes.Recliner
                                    }
                                }
                            }
                        }
                    }
                }
            }
        };

        public bool BookMovie(Booking movie)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetMovies(string searchItem)
        {
            if (String.IsNullOrEmpty(searchItem))
            {
                return MoviesList;
            }
            return MoviesList.Where(x => x.Title.Contains(searchItem)).Select(x => x).ToList();
        }
    }
}

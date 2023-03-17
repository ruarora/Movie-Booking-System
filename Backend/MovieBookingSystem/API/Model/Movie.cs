using API.Enums;

namespace API.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public MovieLanguage Language { get; set; }
        public List<Theater> Theaters { get; set; }
    }
}
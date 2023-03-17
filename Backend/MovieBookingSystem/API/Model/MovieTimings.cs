namespace API.Model
{
    public class MovieTimings
    {
        public int MovieId { get; set; }
        public int TheaterId { get; set; }
        public DateTime MovieDate { get; set; }
        public List<DateTime> Timings { get; set; }
    }
}

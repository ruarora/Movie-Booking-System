namespace API.Model
{
    public class MovieTiming
    {
        public int MovieId { get; set; }
        public int TheaterId { get; set; }
        public int ScreenId { get; set; }
        public DateTime MovieDate { get; set; }
        public DateTime MovieTime { get; set; }
    }
}

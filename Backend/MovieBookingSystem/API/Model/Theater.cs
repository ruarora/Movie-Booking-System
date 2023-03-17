namespace API.Model
{
    public class Theater
    {
        public int Id { get; set; }
        public string TheaterName { get; set; }
        public int CityId { get; set; }
        public List<Screen> Screens { get; set; }
        //public int MovieId { get; set; }
    }
}

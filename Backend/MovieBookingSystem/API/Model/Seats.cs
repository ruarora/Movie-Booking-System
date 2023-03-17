using API.Enums;

namespace API.Model
{
    public class Seats
    {
        public int SeatNumbers { get; set; }
        public int TheaterId { get; set; }
        public SeatStatus SeatStatus {get;set;} 
        public SeatTypes SeatTypes { get; set; }

    }
}

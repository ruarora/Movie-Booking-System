using API.Enums;

namespace API.Model
{
    public class Seats
    {
        public int SeatNumber { get; set; }
        public SeatStatus SeatStatus {get;set;} 
        public SeatTypes SeatTypes { get; set; }
        public int Price { get; set; }
    }
}

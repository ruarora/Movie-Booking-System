using API.Enums;

namespace API.Model
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int UserId { get;set; }
        public int MovieId { get; set; }
        public List<Seats> BookedSeats { get; set; }
        public DateTime BookingDate { get; set; }
        public MovieTimings MovieTimings { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }
}

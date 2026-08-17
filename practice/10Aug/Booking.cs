namespace _10_Aug.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public int PassengerId { get; set; }

        public Passenger? Passenger { get; set; }

        public int BusId { get; set; }

        public Bus? Bus { get; set; }

        public int StateId { get; set; }

        public State? State { get; set; }

        public DateTime TravelDate { get; set; }

        public int SeatNumber { get; set; }
    }
}

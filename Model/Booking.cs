namespace Taxi_Booking.Model
{
    public class Booking
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public string? PickupPoint { get; set; }

        public string? Destination { get; set; }

        public double Current_Location_Latitude { get; set; }

        public double Current_Location_Longitude { get; set; }


    }
}

namespace FlightWebApp.Models
{
    public enum FlightType
    {
        Domestic,
        International,
        Charter,
        Ondemand

    }

    public class Flight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FlightId { get; set; }
        [StringLength(70)]
        public string Flight_name { get; set; }
        [StringLength(70)]
        public string? Flight_descriptiom { get; set; }

        public FlightType Flight_Type { get; set; }
        [StringLength(70)]
        public string flight_total_capacity { get; set; }


    }
}

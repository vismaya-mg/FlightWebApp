namespace FlightWebApp.Models.ViewModel
{
   
        public class FlightViewModel
        {
            [Required]
            [StringLength(50)]
            [Display(Name = "Flight Name")]
            public string Flight_name { get; set; }
            [Required]
            [StringLength(100)]
            [Display(Name = "Flight Description")]
            public string? Flight_descriptiom { get; set; }
            [Required]
            [Display(Name = "Flight Type")]
            public FlightType Flight_Type { get; set; }
            [StringLength(70)]
            [Display(Name = "Flight Total Capacity")]
            public string flight_total_capacity { get; set; }

        }
    
}

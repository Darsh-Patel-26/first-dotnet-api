using System.ComponentModel.DataAnnotations;

namespace DriversApi.Models
{
    public class DriverDto
    {
        [Required]
        public int DriverNo { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Races { get; set; }

        public int Wins { get; set; }

        public int Wdc { get; set; }

        [Required]
        public string Team { get; set; }

        public string Logo { get; set; }

        [Required]
        public string Photo { get; set; }
    }
}

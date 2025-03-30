using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAPI
{


    public class Gun
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // 👈 this tells EF to auto-generate Id
        public int Id { get; set; }

        public string Manufacturer { get; set; } = "";
        public string Model { get; set; } = "";
        public string Caliber { get; set; } = "";
        public float BarrelLengthInches { get; set; }
        public bool IsAutomatic { get; set; }
    }
}

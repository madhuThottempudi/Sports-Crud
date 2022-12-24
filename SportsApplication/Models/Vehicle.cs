using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsApplication.Models
{
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Vehicle_Name { get; set; }
        public string Veh_Company { get; set; }
        public string Veh_Type { get; set; }
        [NotMapped]
        public string Owner_Name { get; set; }

        public float Weight { get; set; }
    }
}


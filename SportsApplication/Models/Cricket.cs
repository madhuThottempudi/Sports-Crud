using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsApplication.Models
{
    public class Cricket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Player_Name { get; set; }
        public string Country { get; set; }
        [Column(Order = 5)]
        public int Age { get; set; }
        public string Designation { get; set; }

    }
}

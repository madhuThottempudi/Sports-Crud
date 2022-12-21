using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsApplication.Models
{
    public class Bigbash 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Player_Id { get; set; }
        public string Player_Name { get; set; }
        [Column("Cost")]
        public string Player_Cost { get; set; }
        public string Country { get; set; }

        [NotMapped]
        public string Details { get; set; }
 
    }
}

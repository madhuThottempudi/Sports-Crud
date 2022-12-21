using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsApplication.Models
{
    public class Ipl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Player_Id { get; set; }
        public string Player_Name { get; set; }
        public string Ipl_Team { get; set; }
        public string Role { get; set; }

        //[ForeignKey(nameof(Player_Id))]
        //public 
        public Bigbash Bigbash { get; set; }
    }
}

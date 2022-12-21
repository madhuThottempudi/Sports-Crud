using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsApplication.Models
{
    public class Football
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Player_Id { get; set; }
        public string Player_Name { get; set; }
        public string Tropies { get; set; }

        [ForeignKey("FootballClub")]
        public int PlayerRefId { get; set; }

        public FootballClub FootballClub { get; set; }

    }
}

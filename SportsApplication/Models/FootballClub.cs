using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsApplication.Models
{
    public class FootballClub
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Player_Id { get; set; }
        public string Club_Name { get; set; }
        public string Position { get; set; }

        public ICollection<Football> Footballs { get; set; }

    }
}

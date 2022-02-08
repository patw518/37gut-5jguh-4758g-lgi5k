using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TurAppen.Model
{
    public class Walk
    {
        public Walk()
        {
            //Participants = new HashSet<ApplicationUser>();
        }

        [Required]
        public int Id { get; set; }
        public string Description { get; set; }
        /*[NotMapped]
        public ICollection<ApplicationUser> Participants { get; set; }*/
        public string ParticipantsJSON { get; set; }
        public int OwnerId { get; set; }
        /*[NotMapped]
        public ICollection<Comment> Comments { get; set; }*/
        public string CommentsJSON { get; set; }
        /*[NotMapped]
        public ICollection<string> Images { get; set; }*/

        public string ImagesJSON { get; set; }
        public string ExpectedWeather { get; set; }
        public string RegionCode { get; set; }
        
        /*[NotMapped]
        public ICollection<string> EquipmentInfo { get; set; }*/

        public string EquipmentInfoJSON { get; set; }
        
        /*[NotMapped]
        public ICollection<int> Ratings { get; set; }*/
        public string RatingsJSON { get; set; }
        public int Lat { get; set; } // location data
        public int Lon { get; set; } // location data
        public int DifficultyLevel { get; set; } // Same as in Person.cs

    }
}

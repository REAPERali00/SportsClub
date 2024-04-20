using System.ComponentModel.DataAnnotations;

namespace A2.Models
{
    public class News
    {
        public int NewsId { get; set; }

        [StringLength(255)]
        [Display(Name = "File Name")]
        public string FileName { get; set; }

        [Url]
        public string Url { get; set; }

        public string SportClubId { get; set; }

        public SportClub SportsClub { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace Mission4Assignment_ZM.Models
{
    public class MovieAdd
    {
        //this is the PK
        [Key]
        [Required]
        public string Title { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }

        //NOT required
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        //something for 25 charcters
        public string Notes { get; set; }
    }
}

﻿using System.ComponentModel.DataAnnotations;

namespace RealState.Models
{
    public class Listing
    {
        [Required]
        public string Id {get; set; }

        public  string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }


    }
}

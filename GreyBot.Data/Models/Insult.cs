﻿using System.ComponentModel.DataAnnotations;

namespace GreyBot.Data.Models
{
    public class Insult
    {
        public int Id { get; set; }
        [StringLength(500, MinimumLength = 5)]
        public string? Text { get; set; }
    }
}

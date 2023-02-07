﻿using Clubs.Enums;
using System.ComponentModel.DataAnnotations;

namespace Clubs.Models
{
    public class ClubToCreateDto
    {
        [Required(ErrorMessage = "Agrega un nombre")]
        [MaxLength(20)]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Agrega una liga")]
        [MaxLength(30)]
        public League League { get; set; }
    }
}

﻿using System.ComponentModel.DataAnnotations;

namespace KisanBazaar.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
    }
}

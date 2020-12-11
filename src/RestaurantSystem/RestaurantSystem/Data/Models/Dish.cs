﻿using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class Dish
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string DishName { get; set; }

        [Required]
        public double DishPrice { get; set; }

        [Required]
        public double DishWeight { get; set; }

        public ICollection<Product> Products { get; set; } = new HashSet<Product>();

        public ICollection<DishProducts2> DishProducts2 { get; set; } = new HashSet<DishProducts2>();

    }
}

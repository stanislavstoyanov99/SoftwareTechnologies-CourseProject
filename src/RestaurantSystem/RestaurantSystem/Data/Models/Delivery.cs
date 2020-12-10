﻿using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class Delivery
    {

        public int Id { get; set; }

        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }

        [Required]
        public double DeliveryPrice { get; set; }

        [Required]
        public DateTime DeliveryDate { get; set; }

        public ICollection<Product> Products { get; set; } = new HashSet<Product>();

    }
}

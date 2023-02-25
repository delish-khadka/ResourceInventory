﻿using System.ComponentModel.DataAnnotations;

namespace ResourceInventory.Model.CategoryModel
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public Nullable<int> Active { get; set; }
    }
}

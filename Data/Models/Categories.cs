﻿using System.Collections.Generic;

namespace ПР37_Осокин.Data.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Items> Items { get; set; }
    }
}

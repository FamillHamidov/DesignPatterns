﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.EntityLayer.Concrete
{
	public class Category
	{
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Product> Products { get; set; } = null!;
    }
}

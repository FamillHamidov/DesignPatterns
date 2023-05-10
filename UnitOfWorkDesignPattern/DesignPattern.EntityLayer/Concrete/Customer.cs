﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.EntityLayer.Concrete
{
	public class Customer
	{
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Balance { get; set; } = null!;
	}
}

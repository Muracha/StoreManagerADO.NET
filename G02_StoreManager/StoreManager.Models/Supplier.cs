﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.Models
{
	public class Supplier
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public int Fax { get; set; }
	}
}

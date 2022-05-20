﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.Models
{
	public class Category
	{
        public int ID { get; set; }
        public string Name { get; set; }
        public int ParentID { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }


    }
}

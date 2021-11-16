﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperORM.Models
{
    public class Vegetable
    {
        public int Veg_id { get; set; }
        public string VegetableName { get; set; }
        public string VegetableType { get; set; }
        public int VegetablePrice { get; set; }
        public string FarmerName { get; set; }
        public string ProductionState { get; set; }
    }
}
﻿using shop.Libraries.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace shop.Models {
 public class Establishment {
        public int Id { get; set; }
        public string Logo { get; set; }
        public EstablishmentType  Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}

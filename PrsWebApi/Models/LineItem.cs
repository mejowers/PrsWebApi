﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrsWebApi.Models {
    public class LineItem {

        public int Id { get; set; }

        public virtual Request request { get; set; }
        public int RequestId { get; set; }

        public virtual Product product { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }

    }
}

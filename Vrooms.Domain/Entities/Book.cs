﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vrooms.Domain.Entities
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short? PublicationYear { get; set; }
        public long? ISBN { get; set; }
        public string Description { get; set; }
    }
}
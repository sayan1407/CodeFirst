﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Genre
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public ICollection<Video> Videos { get; set; }
    }
}

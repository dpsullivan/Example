using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleGame
{
    public interface Item
    {
        public string Name { get; set; }
        public string Category { get; set; }
    }
}

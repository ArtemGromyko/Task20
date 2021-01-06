using System;
using System.Collections.Generic;
using System.Text;

namespace Task20
{
    class Worker
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }

        public Worker() { }
        public Worker(string n, string p, int a)
        {
            Name = n;
            Position = p;
            Age = a;
        }
    }
}
 
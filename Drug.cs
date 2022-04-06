using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35
{
    internal class Drug
    {
        public string Name { get; set; }
        public int UnikalId { get; }
        public TypeDrug Type { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return $"Unikal Id: {UnikalId}, Name: {Name}, Price: {Price}, Count: {Count}";
        }
    }
    
}

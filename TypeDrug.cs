using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35
{
    internal class TypeDrug
    {
        public int UnikalId { get; }
        public string TypeName { get; set; }

        public static int Count { get; set; }

        public TypeDrug()
        {
            UnikalId = ++Count;
        }
        public override string ToString()
        {
            return TypeName;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    class TypeDrung
    {

        public TypeDrung()
        {
            UnikalId++;
        }
        public static int UnikalId;
        public string TypeName;
        public override string ToString()
        {
            return $" Name:{this.TypeName}";
        }
    }
}

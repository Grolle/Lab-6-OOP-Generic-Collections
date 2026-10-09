using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6_OOP_Generic_Collections
{
    internal class IdGenerator
    {
        private static int id = 0;
        public static int GenerateUniqueID() => ++id;
    }
}

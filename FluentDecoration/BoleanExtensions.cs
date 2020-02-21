using System;
using System.Collections.Generic;
using System.Text;

namespace FluentDecoration
{
    public static class BoleanExtensions
    {
        public static bool And(this bool b1, bool b2)
        {
            return b1 && b2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FluentDecoration
{
    public static class BoleanExtensions
    {
        public static bool And(this bool b1, bool b2) => b1 && b2;
        public static bool Or(this bool b1, bool b2) => b1 || b2;
    }
}

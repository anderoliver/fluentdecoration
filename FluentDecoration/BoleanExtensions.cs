namespace FluentDecoration
{
    public static class BoleanExtensions
    {
        public static bool And(this bool b1, bool b2)
        {
            return b1 && b2;
        }

        public static bool Or(this bool b1, bool b2)
        {
            return b1 || b2;
        }
    }
}

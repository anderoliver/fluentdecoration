namespace FluentDecoration
{
    public static class ObjectExtensions
    {
        public static bool IsNull<T>(this T obj) where T : class => obj is null;

        public static bool IsNotNull<T>(this T obj) where T : class => !IsNull(obj);

        public static bool ElseThrow(this bool success, System.Exception ex)
        {
            if (!success)
                throw ex;

            return success;
        }

        public static bool ElseThrow(this bool success, string msg)
        {
            if (!success)
                throw new System.Exception(msg);

            return success;
        }
    }
}

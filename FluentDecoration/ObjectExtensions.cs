namespace FluentDecoration
{
    /// <summary>
    /// Provides extension methods for common operations and validations for all of objects.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// <para>Verifies if an object is null.</para>
        /// <para>Returns true whether <paramref name="obj"/> is null, otherwise false.</para>
        /// </summary>
        /// <typeparam name="T">The type of the object to verify.</typeparam>
        /// <param name="obj">The object instance to verify.</param>
        /// <returns>Returns true whether <paramref name="obj"/> is null, otherwise false.</returns>
        public static bool IsNull<T>(this T obj) where T : class
        {
            return obj is null;
        }

        /// <summary>
        /// <para>Verifies if an object is not null.</para>
        /// <para>Returns true whether <paramref name="obj"/> is not null, otherwise false.</para>
        /// </summary>
        /// <typeparam name="T">The type of the object to verify.</typeparam>
        /// <param name="obj">The object instance to verify.</param>
        /// <returns>Returns true whether <paramref name="obj"/> is not null, otherwise false.</returns>
        public static bool IsNotNull<T>(this T obj) where T : class
        {
            return !IsNull(obj);
        }

        /// <summary>
        /// <para>Throws an exception when check the <paramref name="success"/> value.</para>
        /// <para>Returns the <paramref name="success"/> value whether true, otherwise throws the exception <paramref name="ex"/>.</para>
        /// </summary>
        /// <param name="success">The conditional value to throw the exception.</param>
        /// <param name="ex">The exception to throw.</param>
        /// <returns>Returns the <paramref name="success"/> value whether true, otherwise throws the exception <paramref name="ex"/>.</returns>
        public static bool ElseThrow(this bool success, System.Exception ex)
        {
            if (!success)
            {
                throw ex;
            }

            return success;
        }

        /// <summary>
        /// <para>Throws an exception when check the <paramref name="success"/> value.</para>
        /// <para>Returns the <paramref name="success"/> value whether true, otherwise throws an <see cref="System.Exception"/> with <paramref name="msg"/> as message.</para>
        /// </summary>
        /// <param name="success">The conditional value to throw the exception.</param>
        /// <param name="msg">The exception message.</param>
        /// <returns>Returns the <paramref name="success"/> value whether true, otherwise throws an <see cref="System.Exception"/> with <paramref name="msg"/> as message.</returns>
        public static bool ElseThrow(this bool success, string msg)
        {
            if (!success)
            {
                throw new System.Exception(msg);
            }

            return success;
        }
    }
}

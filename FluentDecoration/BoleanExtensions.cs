namespace FluentDecoration
{
    /// <summary>
    /// Provides extension methods for common operations and validations for booleans.
    /// </summary>
    public static class BoleanExtensions
    {
        /// <summary>
        /// <para>Verifies if <paramref name="b1"/> and <paramref name="b2"/> are true.</para>
        /// <para>Returns true whether <paramref name="b1"/> and <paramref name="b2"/> are true, otherwise false.</para>
        /// </summary>
        /// <param name="b1">First boolean.</param>
        /// <param name="b2">Second boolean.</param>
        /// <returns>Returns true whether <paramref name="b1"/> and <paramref name="b2"/> are true, otherwise false.</returns>
        public static bool And(this bool b1, bool b2)
        {
            return b1 && b2;
        }

        /// <summary>
        /// <para>Verifies if <paramref name="b1"/> or <paramref name="b2"/> are true.</para>
        /// <para>Returns true whether <paramref name="b1"/> or <paramref name="b2"/> are true, otherwise false.</para>
        /// </summary>
        /// <param name="b1">First boolean.</param>
        /// <param name="b2">Second boolean.</param>
        /// <returns>Returns true whether <paramref name="b1"/> or <paramref name="b2"/> are true, otherwise false.</returns>
        public static bool Or(this bool b1, bool b2)
        {
            return b1 || b2;
        }
    }
}

namespace SimplePG.Utilities
{
    using System;

    public static class Ensure
    {
        public static void IsNotNull(object o, string argumentName)
        {
            if(o == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }
    }
}
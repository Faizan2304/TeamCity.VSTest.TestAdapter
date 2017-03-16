﻿namespace TeamCity.VSTest.TestAdapter
{
    internal static class Strings
    {
        public static bool IsNullOrWhiteSpace(this string str)
        {
            if (str == null)
            {
                return true;
            }

            return str.Trim() == string.Empty;
        }
    }
}

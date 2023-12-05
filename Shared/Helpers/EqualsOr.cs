using System;

namespace ClaudiaIDE.Helpers
{
    internal static class ComparisonExtension
    {
        public static bool EqualsOr(this Object obj, params Object[] value)
        {
            foreach (var v in value) if (obj.Equals(v)) return true;
            return false;
        }

        public static bool EqualsAnd(this Object obj, params Object[] value)
        {

            foreach (var v in value) if (!obj.Equals(v)) return false;
            return true;
        }
    }
}
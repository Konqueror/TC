using System.Text;

namespace _01.StringBuilderExtension
{
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder value, int startIndex, int length)
        {
            return new StringBuilder(value.ToString(), startIndex, length, value.Capacity);
        }
    }
}

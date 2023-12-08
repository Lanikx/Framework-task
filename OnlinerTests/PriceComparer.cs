

using System.Collections;

namespace OnlinerTests
{
    public class PriceComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            if (double.Parse(x) > double.Parse(y))
            {
                return -1;
            }
            if (double.Parse(x) < double.Parse(y))
            {
                return 1;
            }
            return 0;
        }
    }
}

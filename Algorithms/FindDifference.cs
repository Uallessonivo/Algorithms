namespace Algorithms
{
    internal class FindDifference
    {
        public char FindTheDifference(string s, string t)
        {
            return (char)(s + t).Aggregate(0, (x, c) => x ^ (c));
        }
    }
}

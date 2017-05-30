namespace HammingDistance
{
    public class Solution
    {
        public int HammingDistance(int x, int y)
        {
            int dist = 0;
            int length = max(x, y);
            length = log(length);
            for (int i=0; i < length; i++)
            {
                if (x % 2 != y % 2)
                {
                    dist++;
                }
                x /= 2;
                y /= 2;
            }
            return dist;
        }

        private int log(int length)
        {
            int counter = 0;
            while (length > 0)
            {
                counter++;
                length /= 2;
            }
            return counter;
        }

        private int max(int one, int two)
        {
            if (one < two)
                return two;
            return one;
        }
    }
}
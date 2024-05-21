using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JosephusSurvivor
{
    public class Josephus
    {
        public static int JosSurvivor(int n, int k)
        {
            if (n == 1) return n;
            var circle = Enumerable.Range(1, n).ToList();
            var index = 0;
            do
            {
                index = (index + k-1) % circle.Count;
                circle.RemoveAt(index);
            } while (circle.Count>1);

            return circle.FirstOrDefault();
        }
    }
}
